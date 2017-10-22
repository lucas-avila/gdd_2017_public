using PagoAgilFrba.Mappers;
using PagoAgilFrba.Model;
using PagoAgilFrba.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoAgilFrba.CRUDCompany
{
    public partial class SearchCompaniesForm : Form
    {
        public SearchCompaniesForm()
        {
            InitializeComponent();
            setGridCompanies();
        }

        private void setGridCompanies()
        {
            List<Company> companies = StoreManager.getInstance().executeReadStore<Company>("sp_get_all_companies", new CompanyMapper(), null);
            gridCompanies.DataSource = companies;
            gridCompanies.Columns["name"].DisplayIndex = 0;
            gridCompanies.Columns["cuit"].DisplayIndex = 1;
            gridCompanies.Columns["entry"].DisplayIndex = 2;
            gridCompanies.Columns["address"].DisplayIndex = 3;
            gridCompanies.Columns["active"].Visible = false;
            gridCompanies.Columns["id"].Visible = false;

            gridCompanies.Columns["name"].HeaderText = "Empresa";
            gridCompanies.Columns["cuit"].HeaderText = "CUIT";
            gridCompanies.Columns["entry"].HeaderText = "Rubro";
            gridCompanies.Columns["address"].HeaderText = "Dirección";

            gridCompanies.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridCompanies.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridCompanies.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridCompanies.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }
    }
}
