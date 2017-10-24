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

namespace PagoAgilFrba.CRUDBill{
    public partial class CRUDBillForm : Form{
        public CRUDBillForm(){
            InitializeComponent();

            setCmbCompany();

            gridBill.AutoGenerateColumns = false;
        }

        private void setCmbCompany(){
            cmbCompany.Name = "name";
            cmbCompany.DataSource = StoreManager.getInstance().executeReadStore<Company>("sp_search_companies", new CompanyMapper());

            cmbCompany.DisplayMember = "name";
            cmbCompany.ValueMember = "id";
            cmbCompany.SelectedItem = null;
        }

        private void btnSearch_Click(object sender, EventArgs e){
            doSearch();
        }

        private void doSearch() { 
            
        }

        private void btnAdd_Click(object sender, EventArgs e){
            new CUBill().Show();
        }

        private void btnClearFilters_Click(object sender, EventArgs e){
            txtBillNumber.Text = null;
            cmbCompany.Text = null;
            cmbClient.Text = null;
            dbDate.Value = DateTime.Now;
            dbDate.Checked = false;
            dbExpiration.Value = DateTime.Now;
            dbExpiration.Checked = false;
        }
    }
}
