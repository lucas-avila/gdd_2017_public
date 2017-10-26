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

        public void doSearch() {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@bill_number", Util.convertStringToNumber(txtBillNumber.Text)));
            parameters.Add(new Parameter("@bill_com_id", cmbCompany.SelectedValue));
            parameters.Add(new Parameter("@bill_cli_id", cmbClient.SelectedValue));

            if (dbDate.Checked) {
                parameters.Add(new Parameter("@bill_date", dbDate.Value));
            }

            if (dbExpiration.Checked){
                parameters.Add(new Parameter("@bill_expiration", dbExpiration.Value));
            }

            gridBill.DataSource = StoreManager.getInstance().executeReadStore<BillTable>("sp_search_bills", new BillTableMapper(), parameters);

        }

        private void btnAdd_Click(object sender, EventArgs e){
            new CUBill(this).Show();
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

        private void gridBill_CellContentClick(object sender, DataGridViewCellEventArgs e){

            if (e.RowIndex < 0 || e.ColumnIndex < 0){
                return;
            }
            string columnName = this.gridBill.Columns[e.ColumnIndex].Name;

            BillTable selected = ((BillTable)gridBill.Rows[e.RowIndex].DataBoundItem);

            if ("colEdit".Equals(columnName)){

                List<Parameter> parameters = new List<Parameter>();
                parameters.Add(new Parameter("@bill_id",selected.id));

                Boolean canEdit = Convert.ToBoolean(StoreManager.getInstance().getStoreProcedureResult("sp_can_edit_bill", parameters));

                if (!canEdit) {
                    MessageBox.Show("La factura no se puede editar porque posee una rendicion y/o un pago", "Info");
                    return;
                }

                Bill bill = StoreManager.getInstance().executeReadSingleResult<Bill>("sp_get_bill", new BillMapper(), parameters);

                (new CUBill(this, bill)).Show();
            }

        }
    }
}
