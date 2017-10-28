using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Utils;
using PagoAgilFrba.Model;
using PagoAgilFrba.Mappers;

namespace PagoAgilFrba.CRUDPayment{
    public partial class CUPayment : Form{

        private List<Bill> bills = new List<Bill>();

        public CUPayment(Branch selectedBranch){
            InitializeComponent();
            init(selectedBranch);
        }

        private void init(Branch selectedBranch){
            gridBills.AutoGenerateColumns = false;
            setDbDate();
            setCmbBranch(selectedBranch);
            setCmbPaymentMethod();
        }

        private void setCmbPaymentMethod(){
            List<PaymentMethod> payments = StoreManager.getInstance().executeReadStore<PaymentMethod>("sp_search_payment_methods", new PaymentMethodMapper());
            cmbPaymentMethod.ValueMember = "id";
            cmbPaymentMethod.DisplayMember = "description";
            cmbPaymentMethod.DataSource = payments;
        }

        private void setDbDate(){
            dbDate.Value = Util.getSysDate();
            dbDate.Enabled = false;
        }

        private void setCmbBranch(Branch selectedBranch){
            cmbBranch.ValueMember = "id";
            cmbBranch.DisplayMember = "name";
            cmbBranch.DataSource = new List<Branch> { selectedBranch };
            cmbBranch.SelectedItem = selectedBranch;
            cmbBranch.Enabled = false;
        }

        private void btnAddBill_Click(object sender, EventArgs e){
            new AddBill(this).Show();
        }

        private void btnSave_Click(object sender, EventArgs e){

            if (bills.Count == 0) {
                MessageBox.Show("Debe ingresar una o más facturas", "Error");
                return;
            }

            if (cmbPaymentMethod.SelectedValue == null) {
                MessageBox.Show("Debe seleccionar una forma de pago", "Error");
                return;
            }

            decimal pk = StoreManager.getInstance().executeNonQueryResultPKDecimal("sp_add_payment", getInsertParameters()).Value;

            saveBills(pk);

            MessageBox.Show("Pago N° " + pk + " generado");
            this.Hide();
        }

        private void saveBills(decimal pk){
            foreach(Bill bill in bills){
                List<Parameter> parameters = new List<Parameter>();
                parameters.Add(new Parameter("@bill_pay_nro", pk));
                parameters.Add(new Parameter("@bill_id", bill.id));
                StoreManager.getInstance().executeNonQuery("sp_update_bill_payment", parameters);
            }
        }

        private List<Parameter> getInsertParameters(){
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@pay_branch_id", cmbBranch.SelectedValue));
            parameters.Add(new Parameter("@pay_paym_id", cmbPaymentMethod.SelectedValue));
            parameters.Add(new Parameter("@pay_date", dbDate.Value));
            parameters.Add(new Parameter("@pay_total", nroAmount.Value));
            return parameters;
        }

        private void gridBills_CellContentClick(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex < 0 || e.ColumnIndex < 0){
                return;
            }
            string columnName = this.gridBills.Columns[e.ColumnIndex].Name;

            Bill selected = ((Bill)gridBills.Rows[e.RowIndex].DataBoundItem);

            if ("colDelete".Equals(columnName)){
                gridBills.DataSource = null;
                bills.Remove(selected);
                nroAmount.Value = nroAmount.Value - selected.total;
                gridBills.DataSource = bills;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e){
            this.Hide();
        }

        public void addBill(Bill bill) {
            if (bills.Find(b => b.id.Equals(bill.id)) != null){
                MessageBox.Show("El pago ya contiene la factura numero " + bill.number,"Error");
            } else {
                gridBills.DataSource = null;
                bills.Add(bill);
                nroAmount.Value = nroAmount.Value + bill.total;
                gridBills.DataSource = bills;
            }
        }
    }
}
