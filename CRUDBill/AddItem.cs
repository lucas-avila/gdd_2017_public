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

namespace PagoAgilFrba.CRUDBill{
    public partial class AddItem : Form{

        private CUBill form;

        public AddItem(CUBill form){
            InitializeComponent();
            this.form = form;
        }

        private void btnAdd_Click(object sender, EventArgs e){

            decimal? amount = Util.convertStringToNumber(txtAmount.Text);

            if (!amount.HasValue || amount <= 0) {
                MessageBox.Show("Debe ingresar un monto mayor a 0 (solo numeros con el formato #,##)","Error");
                return;
            }

            if (numQuantity.Value <= 0) {
                MessageBox.Show("Debe ingresar la cantidad","Error");
                return;
            }

            form.newItem(new Item(amount.Value, numQuantity.Value));
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e){
            this.Hide();
        }

    }
}
