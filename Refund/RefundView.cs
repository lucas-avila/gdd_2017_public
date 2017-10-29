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
using PagoAgilFrba.Refund;

namespace PagoAgilFrba.Refund{
    public partial class RefundView : Form{
        public RefundView(){
            InitializeComponent();

            setCmbCompany();
            setCmbClient();
            gridBill.AutoGenerateColumns = false;
        }

        private void setCmbCompany(){
            cmbCompany.DataSource = StoreManager.getInstance().executeReadStore<Company>("sp_search_companies", new CompanyMapper());
            cmbCompany.DisplayMember = "name";
            cmbCompany.ValueMember = "id";
            cmbCompany.SelectedItem = null;
        }

        private void setCmbClient(){
            cmbClient.DataSource = StoreManager.getInstance().executeReadStore<ClientCombo>("sp_search_client_combo",new ClientComboMapper());
            cmbClient.DisplayMember = "name";
            cmbClient.ValueMember = "id";
            cmbClient.SelectedItem = null;
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

            gridBill.DataSource = StoreManager.getInstance().executeReadStore<BillTable>("sp_search_bills_candidates_to_refund", new BillTableMapper(), parameters);

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

            if ("colRefund".Equals(columnName)){

                if (canBeRefunded(selected))
                {
                    new ReasonForm(selected.id, this).Show();
                }
                else
                {
                    MessageBox.Show("No se puede reembolsar una factura ya rendida.", "Error");
                    return;
                }
            }

        }

        private Boolean canBeRefunded(BillTable bill)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@bill_id", bill.id));
            return Convert.ToBoolean(StoreManager.getInstance().getStoreProcedureResult("sp_bill_can_be_refunded", parameters));
        }
    }
}
