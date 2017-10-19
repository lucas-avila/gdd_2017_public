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
        }

        private void btnSearch_Click(object sender, EventArgs e){
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@name", txtName.Text));
            parameters.Add(new Parameter("@address", txtAddress.Text));
            parameters.Add(new Parameter("@postal_code", Util.convertStringToNumber(txtPostalCode.Text) ));

            gridBranch.DataSource = StoreManager.getInstance().executeReadStore<Branch>("sp_search_branchs", new BranchMapper(), parameters);
        }

        private void btnClearFilters_Click(object sender, EventArgs e){
            txtAddress.Text = null;
            txtName.Text = null;
            txtPostalCode.Text = null;
        }

    }
}
