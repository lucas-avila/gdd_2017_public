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

namespace PagoAgilFrba.CRUDBranch {
    public partial class CRUDBranchForm : Form {
        
        public CRUDBranchForm() {
            InitializeComponent();
            gridBranch.AutoGenerateColumns = false;
        }

        private void btnSearch_Click(object sender, EventArgs e){
            doSearch();
        }

        private void doSearch() {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@name", txtName.Text));
            parameters.Add(new Parameter("@address", txtAddress.Text));
            parameters.Add(new Parameter("@postal_code", Util.convertStringToNumber(txtPostalCode.Text)));
            gridBranch.DataSource = StoreManager.getInstance().executeReadStore<Branch>("sp_search_branchs", new BranchMapper(), parameters);
        }

        private void btnClearFilters_Click(object sender, EventArgs e){
            txtAddress.Text = null;
            txtName.Text = null;
            txtPostalCode.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e){
            (new CUBranch(new DelegateCUBranch(this))).Show();
        }

        private void gridBranch_CellContentClick(object sender, DataGridViewCellEventArgs e){

            if (e.RowIndex < 0 || e.ColumnIndex < 0){
                return;
            }
            string columnName = this.gridBranch.Columns[e.ColumnIndex].Name;

            Branch selected = ((Branch)gridBranch.Rows[e.RowIndex].DataBoundItem);

            if ("colEdit".Equals(columnName)) {
                (new CUBranch(new DelegateCUBranch(this),selected)).Show();
            }

            if ("colActive".Equals(columnName)){
                List<Parameter> parameters = new List<Parameter>();
                parameters.Add(new Parameter("@branch_id", selected.id));
                StoreManager.getInstance().executeNonQuery("sp_change_active_branch", parameters);
                doSearch();
            }

        }

        private class DelegateCUBranch : CUBranch.DelegateForm {

            private CRUDBranchForm form;

            public DelegateCUBranch(CRUDBranchForm form) {
                this.form = form;
            }

            public void afterUpdate(){
                form.doSearch();
            }
        }

    }
}
