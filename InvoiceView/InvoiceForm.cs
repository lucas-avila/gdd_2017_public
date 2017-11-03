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
using System.Runtime.CompilerServices;

namespace PagoAgilFrba.InvoiceView
{
    public partial class InvoiceForm : Form
    {
        private Decimal total;

        public InvoiceForm(){
            InitializeComponent();
            setCmbCompany();
            numPercentage.ValueChanged += numPercentage_change;
        }

        private void setCmbCompany(){
            List<Company> companies = StoreManager.getInstance().executeReadStore<Company>("sp_search_companies", new CompanyMapper());
            cmbCompany.DataSource = companies.FindAll(c => c.active);
            cmbCompany.DisplayMember = "name";
            cmbCompany.ValueMember = "id";
            cmbCompany.SelectedItem = null;

            cmbCompany.SelectedValueChanged += cmbCompany_change;
            dbDate.ValueChanged += cmbCompany_change;
        }

        private void cmbCompany_change(object sender, EventArgs e){
            if (cmbCompany.SelectedValue != null) {
                List<Parameter> parameters = new List<Parameter>();
                parameters.Add(new Parameter("@com_id", cmbCompany.SelectedValue));
                parameters.Add(new Parameter("@date", dbDate.Value));

                Dictionary<string,object> result = StoreManager.getInstance().executeReadSingleResult<Dictionary<string, object>>("sp_get_data_invoice", new DefaultMapper(), parameters);

                if (result["TOTAL"] != null && !String.IsNullOrEmpty(result["TOTAL"].ToString())){
                    total = (Decimal)result["TOTAL"];
                    numBills.Value = (int)result["QUANTITY"];
                }else {
                    total = 0;
                    numBills.Value = 0;
                }

                numPercentage_change(null, null);
            }
        }

        private void numPercentage_change(object sender, EventArgs e){
            numAmount.Value = total*(numPercentage.Value/100);
            numTotal.Value = total - numAmount.Value;
        }

        private void btnSave_Click(object sender, EventArgs e){

            if (cmbCompany.SelectedValue == null) {
                MessageBox.Show("Debe seleccionar una empresa", "Error");
                return;
            }

            if (numBills.Value <= 0) {
                MessageBox.Show("Debe seleccionar un periodo con facturas pagas", "Error");
                return;
            }

            if (String.IsNullOrEmpty(numPercentage.Text) || numPercentage.Value <= 0) {
                MessageBox.Show("El porcentaje debe ser mayor a 0", "Error");
                return;
            }

            if (existInvoiceInMonth(cmbCompany.SelectedValue, dbDate.Value)) {
                MessageBox.Show("Ya existe una rendicion para la compañía en ese mes", "Error");
                return;
            }

            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@inv_company_id", cmbCompany.SelectedValue));
            parameters.Add(new Parameter("@inv_date", dbDate.Value));
            parameters.Add(new Parameter("@inv_amount", numAmount.Value));
            parameters.Add(new Parameter("@inv_total", numTotal.Value));
            parameters.Add(new Parameter("@inv_fee_percentage", numPercentage.Value));

            StoreManager.getInstance().executeNonQuery("sp_insert_invoice", parameters);
            this.Hide();
        }

        private bool existInvoiceInMonth(object companyId, DateTime dateTime){
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@com_id", companyId));
            parameters.Add(new Parameter("@date", dbDate.Value));

            return Convert.ToBoolean(StoreManager.getInstance().getStoreProcedureResult("sp_check_exist_invoice", parameters));
        }

        private void btnCancel_Click(object sender, EventArgs e){
            this.Hide();
        }
    }
}
