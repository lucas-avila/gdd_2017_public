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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.CRUDRole
{
    public partial class CreateRole : Form
    {
        private TextBox txtName;
        private ListBox Funcionalidades;
        private Label label2;
        private Button btnCreate;
        private Label label3;
        private Button btnCancel;
        private Label label1;

        public CreateRole()
        {
            InitializeComponent();
            //<<summary>>
            /**First we get all the functionalities from the DB
             * (mapping each one to Functionality.class) and then
             * we get the names. Finally we set the ListBox data with
             * the names.
             */
            //<</summary>>
            List<Functionality> functionalities = StoreManager.getInstance()
                .executeReadStore<Functionality>("sp_get_functionalities", new FunctionalityMapper(), null);
            List<String> func_names = functionalities.Select(func => func.name).ToList();
            Funcionalidades.DataSource = func_names;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var roleName = txtName.Text;
            var functionalities = Funcionalidades.SelectedItems;
            //We check the a name and the selected functionality.
            if (String.IsNullOrEmpty(roleName) || functionalities.Count == 0){
                MessageBox.Show("Debe ingresar un nombre para el rol y elegir al menos una funcionalidad", "Error");
                return;
            }

            //Check that the role_name is not used...
            if (role_already_exists(roleName))
            {
                MessageBox.Show("El nombre del rol ingresado ya se encuentra en uso", "Error");
                return;
            }
            //Update the tables with the new information.
            update_tables(roleName);
            MessageBox.Show("Se agrego el rol exitosamente.", "Exito");
            this.Hide();
            new CRUDRoleForm().Show();
        }

        private void update_tables(String roleName)
        {
            // First we add the new role to Role table.
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@role_name", roleName));
            parameters.Add(new Parameter("@role_active", 1));
            StoreManager.getInstance().executeNonQuery("sp_add_role", parameters);

            //Then we add the relation between the role and its functionalities.
            foreach (String func in Funcionalidades.SelectedItems)
            {
                parameters.Clear();
                parameters.Add(new Parameter("@role_name", roleName));
                parameters.Add(new Parameter("@func_name", func));
                StoreManager.getInstance().executeNonQuery("sp_link_functionality_role", parameters);
            }
        }

        private Boolean role_already_exists(String roleName)
        {
            List<Role> roles = StoreManager.getInstance().executeReadStore<Role>("sp_get_all_roles", new RoleMapper(), null);
            return roles.FindIndex(element => element.name == roleName) >= 0;
        }

        /**********************Auto-Generated Method for Designer***************************/
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Funcionalidades = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 20);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // Funcionalidades
            // 
            this.Funcionalidades.BackColor = System.Drawing.SystemColors.Window;
            this.Funcionalidades.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Funcionalidades.FormattingEnabled = true;
            this.Funcionalidades.Location = new System.Drawing.Point(15, 110);
            this.Funcionalidades.Name = "Funcionalidades";
            this.Funcionalidades.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Funcionalidades.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Funcionalidades.Size = new System.Drawing.Size(243, 121);
            this.Funcionalidades.TabIndex = 13;
            this.Funcionalidades.SelectedIndexChanged += new System.EventHandler(this.Funcionalidades_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "A continuación seleccione las funcionalidades.";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(197, 237);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "(Use ALT+CLICK para selección múltiple)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateRole
            // 
            this.AccessibleName = "";
            this.ClientSize = new System.Drawing.Size(284, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Funcionalidades);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "CreateRole";
            this.Text = "Crear Rol";
            this.Load += new System.EventHandler(this.CreateRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void CreateRole_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CRUDRoleForm().Show();
        }
    }
}