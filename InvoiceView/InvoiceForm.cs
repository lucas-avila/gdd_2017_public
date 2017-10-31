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

namespace PagoAgilFrba.InvoiceView
{
    public partial class s : Form
    {
        public s(){
            InitializeComponent();
            setCmbCompany();
        }

        private void setCmbCompany(){
            List<Company> companies = StoreManager.getInstance().executeReadStore<Company>("sp_search_companies", new CompanyMapper());
            cmbCompany.DataSource = companies.FindAll(c => c.active);
            cmbCompany.DisplayMember = "name";
            cmbCompany.ValueMember = "id";
            cmbCompany.SelectedItem = null;
        }

        private void btnSave_Click(object sender, EventArgs e){

            if (cmbCompany.SelectedValue == null) {
                MessageBox.Show("Debe seleccionar una empresa", "Error");
                return;
            }

            if (numPercentage.Value <= 0) {
                MessageBox.Show("El porcentaje debe ser mayor a 0", "Error");
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e){
            this.Hide();
        }
    }
}
