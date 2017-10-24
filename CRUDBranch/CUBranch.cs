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
using PagoAgilFrba.Mappers;

namespace PagoAgilFrba.CRUDBranch{

    public partial class CUBranch : Form{

        private DelegateForm delegateForm;
        private Branch edit;
        private Boolean isNew;

        //CU -> Create/Update
        public CUBranch(DelegateForm delegateForm, Branch edit = null){
            InitializeComponent();
            setInitialData(edit);
            this.delegateForm = delegateForm;
            this.edit = edit != null ? edit : new Branch();
        }

        private void setInitialData(Branch edit){
            if (edit != null){
                this.Text = "Editar Sucursal";
                cbActive.Checked = edit.active;
                txtName.Text = edit.name;
                txtAddress.Text = edit.address;
                txtPostalCode.Text = edit.postalCode.ToString();
                this.isNew = false;
            }else{
                this.Text = "Agregar Sucursal";
                this.isNew = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e){

            if (String.IsNullOrEmpty(txtName.Text)) {
                MessageBox.Show("Debe ingresar nombre", "Error");
                return;
            }

            if (String.IsNullOrEmpty(txtAddress.Text)){
                MessageBox.Show("Debe ingresar una direccion", "Error");
                return;
            }

            if (String.IsNullOrEmpty(txtPostalCode.Text) || Util.convertStringToNumber(txtPostalCode.Text) == null){
                MessageBox.Show("Debe un codigo postal (solo numerico)", "Error");
                return;
            }

            if (existPostalCode(txtPostalCode.Text, edit.id)) {
                MessageBox.Show("Ya existe el codigo postal "+txtPostalCode.Text, "Error");
                return;
            }

            getData();

            insertOrUpdate();
        }

        private void insertOrUpdate(){
            List<Parameter> parameters = new List<Parameter>();
            
            parameters.Add(new Parameter("@branch_id", this.getBranchId()));
            parameters.Add(new Parameter("@branch_name", edit.name));
            parameters.Add(new Parameter("@branch_address", edit.address));
            parameters.Add(new Parameter("@branch_postal_code", edit.postalCode));
            parameters.Add(new Parameter("@branch_active", edit.active));

            StoreManager.getInstance().executeNonQuery("sp_insert_update_branch", parameters);
            this.Hide();
            this.delegateForm.afterUpdate();
        }

        private void getData(){
            edit.name = txtName.Text;
            edit.active = cbActive.Checked;
            edit.address = txtAddress.Text;
            edit.postalCode = (decimal)Util.convertStringToNumber(txtPostalCode.Text);
        }

        private bool existPostalCode(string postalCode, int branchId){
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@postal_code", Util.convertStringToNumber(postalCode)));
            parameters.Add(new Parameter("@branch_id", this.getBranchId()));

            Branch result = StoreManager.getInstance().executeReadSingleResult<Branch>("sp_check_postal_code_branch", new BranchMapper(), parameters);
            
            return result != null;
        }

        public int? getBranchId() {
            if (!this.isNew){
                return edit.id;
            }
            return null;
        }

        private void btnCancel_Click(object sender, EventArgs e){
            this.Hide();
        }

        public interface DelegateForm{
            void afterUpdate();
        }
    }
}
