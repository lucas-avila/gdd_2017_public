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
    public partial class CRUDCompanyForm : Form
    {
        List<Entry> entries;
        public CRUDCompanyForm()
        {
            InitializeComponent();
            setGridCompanies();
            setEntryBox();
        }

        private void setEntryBox()
        {
            entries = StoreManager.getInstance()
                .executeReadStore<Entry>("sp_get_all_entries", new EntryMapper(), null);
            entryBox.DataSource = entries;
            entryBox.DisplayMember = "description";
            entryBox.ValueMember = "description";
            this.entryBox.DropDownStyle = ComboBoxStyle.DropDownList;
            entryBox.SelectedItem = null;
        }

        private void setGridCompanies()
        {
            List<Company> companies = StoreManager.getInstance().executeReadStore<Company>("sp_get_all_companies", new CompanyMapper(), null);
            gridCompanies.DataSource = companies;
            gridCompanies.Columns["name"].DisplayIndex = 0;
            gridCompanies.Columns["cuit"].DisplayIndex = 1;
            gridCompanies.Columns["entry"].DisplayIndex = 2;
            gridCompanies.Columns["address"].Visible = false;
            gridCompanies.Columns["active"].DisplayIndex = 4;
            gridCompanies.Columns["id"].Visible = false;

            gridCompanies.Columns["name"].HeaderText = "Empresa";
            gridCompanies.Columns["cuit"].HeaderText = "CUIT";
            gridCompanies.Columns["entry"].HeaderText = "Rubro";
            gridCompanies.Columns["address"].HeaderText = "Dirección";
            gridCompanies.Columns["active"].HeaderText = "Habilitada";

            gridCompanies.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridCompanies.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridCompanies.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridCompanies.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void doSearch()
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@com_name", nameBox.Text));
            parameters.Add(new Parameter("@com_cuit", cuitBox.Text));
            parameters.Add(new Parameter("@com_ent_id", getEntryId(entryBox.GetItemText(entryBox.SelectedItem))));
            gridCompanies.DataSource = StoreManager.getInstance().executeReadStore<Company>("sp_search_companies", new CompanyMapper(), parameters);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void gridCompanies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            String columnName = this.gridCompanies.Columns[e.ColumnIndex].Name;

            Company selected = ((Company)gridCompanies.Rows[e.RowIndex].DataBoundItem);

            if ("modify".Equals(columnName))
            {
                (new CUCompanyForm(new DelegateCUCompany(this), selected)).Show();
            }

            if ("active".Equals(columnName))
            {
                List<Parameter> parameters = new List<Parameter>();
                parameters.Add(new Parameter("@com_id", selected.id));
                StoreManager.getInstance().executeNonQuery("sp_change_active_company", parameters);
                this.doSearch();
            }

        }

        private int? getEntryId(string description)
        {
            foreach (Entry entry in entries)
            {
                if (entry.description == description)
                    return entry.id;
            }
            return null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            (new CUCompanyForm(new DelegateCUCompany(this))).Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            nameBox.Text = null;
            cuitBox.Text = null;
            entryBox.SelectedItem = null;
        }
    }

    public class DelegateCUCompany : CUCompanyForm.DelegateForm
    {

        public CRUDCompanyForm form;

        public DelegateCUCompany(CRUDCompanyForm form)
        {
            this.form = form;
        }

        public void afterUpdate()
        {
            form.doSearch();
        }
    }
}
