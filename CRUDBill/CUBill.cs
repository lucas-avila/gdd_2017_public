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

namespace PagoAgilFrba.CRUDBill{
    public partial class CUBill : Form{

        private List<Item> items;

        public CUBill(){
            InitializeComponent();
            initData();
        }

        private void initData(){
            gridItems.AutoGenerateColumns = false;
            items = new List<Item>();
        }

        private void btnAddItem_Click(object sender, EventArgs e){
            new AddItem(this).Show();
        }

        private void button1_Click(object sender, EventArgs e){
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e){

            Decimal? billNumber = Util.convertStringToNumber(txtBillNumber.Text);

            if (!billNumber.HasValue) {
                MessageBox.Show("Debe ingresar el numero de factura","Error");
                return;
            }

            if (cmbCompany.SelectedItem == null){
                MessageBox.Show("Debe seleccionar una empresa", "Error");
                return;
            }

            if (cmbClient.SelectedItem == null){
                MessageBox.Show("Debe seleccionar un cliente", "Error");
                return;
            }

            if (items.Count == 0) {
                MessageBox.Show("Debe agregar al menos un item", "Error");
                return;
            }
        }

        public void newItem(Item item){
            items.Add(item);
            gridItems.DataSource = items;
        }
    }
}
