using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Model;
using PagoAgilFrba.Utils;
using PagoAgilFrba.Mappers;

namespace PagoAgilFrba.CRUDPayment{
    public partial class AddBill : Form{

        private CUPayment form;

        public AddBill(CUPayment form){
            InitializeComponent();
            this.form = form;
        }

        private void btnAdd_Click(object sender, EventArgs e){
            Bill bill = StoreManager.getInstance().executeReadSingleResult<Bill>
                ("sp_get_bill_by_number", new BillMapper(), new List<Parameter> { new Parameter("@bill_number", numBill.Value) });

            if (bill == null) {
                MessageBox.Show("Factura no encontrada", "Error");
                return;
            }

            if (bill.expiration.CompareTo(Util.getSysDate()) < 0){
                MessageBox.Show("La factura se encuentra expirada", "Error");
                return;
            }

            if (companyInactive(bill.com_id)) {
                MessageBox.Show("La compañía se encuentra inactiva", "Error");
                return;
            }
            form.addBill(bill);
            this.Hide();
        }

        private bool companyInactive(int companyId){
            return !Convert.ToBoolean(StoreManager.getInstance().getStoreProcedureResult("sp_company_active", new List<Parameter> { new Parameter("@com_id", companyId) }));
        }

        private void btnCancel_Click(object sender, EventArgs e){
            this.Hide();
        }
    }
}
