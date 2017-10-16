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

namespace PagoAgilFrba.CRUDRole
{
    public partial class ModifyRole : Form
    {

        Role role;
        int cant_func;
        public ModifyRole(String role_name)
        {
            InitializeComponent();

            role = getRole(role_name);
            textBoxRoleName.Text = role_name;
            setComboBoxStatus(role.active);
            funcBox.DataSource = getRoleFunctionalitiesNames();
        }

        private Role getRole(String role_name)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@role_name", role_name));
            return StoreManager.getInstance().executeReadStore<Role>("sp_get_role", new RoleMapper(), parameters).First();
        }

        private List<String> getRoleFunctionalitiesNames()
        {
            return getRoleFunctionalities().Select(func => func.name).ToList();
        }

        private List<Functionality> getRoleFunctionalities()
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@role_id", role.id));
            List<Functionality> functionalities = StoreManager.getInstance()
                   .executeReadStore<Functionality>("sp_get_role_functionalities", new FunctionalityMapper(), parameters);
            cant_func = functionalities.Count;
            return functionalities;
        }
        private void setComboBoxStatus(Boolean status)
        {
            comboBoxStatus.DisplayMember = "Status";
            comboBoxStatus.ValueMember = "Value";

            var items = new[]
            {
                new { Status = "Inhabilitado", Value = "Inhabilitado"},
                new { Status = "Habilitado", Value = "Habilitado"}
            };

            comboBoxStatus.DataSource = items;

            if (status)
                comboBoxStatus.SelectedIndex = 1;
            else
                comboBoxStatus.SelectedIndex = 0;
        }

        private void btnAddFunc_Click(object sender, EventArgs e)
        {
            new AddFunctionalitiesForm(getRoleFunctionalitiesNames(), role.name).Show();
            this.Hide();
        }

        private void btnRemoveFunc_Click(object sender, EventArgs e)
        {
            String functionality = funcBox.SelectedItem.ToString();

            if (String.IsNullOrEmpty(functionality))
            {
                MessageBox.Show("Debe seleccionar una funcionalidad para eliminarla", "Error");
                return;
            }

            deleteFunctionality(functionality);
        } 

        private void deleteFunctionality(String name)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@role_id", role.id));
            parameters.Add(new Parameter("@func_id", getFunctionalityId(name)));
            StoreManager.getInstance().executeNonQuery("sp_remove_role_functionality", parameters);
            funcBox.DataSource = getRoleFunctionalitiesNames();
        }

        private int getFunctionalityId(String name)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@func_name", name));
            return StoreManager.getInstance()
                   .executeReadStore<Functionality>("sp_get_functionality", new FunctionalityMapper(), parameters)
                   .First()
                   .id;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var new_role_name = textBoxRoleName.Text;

            if (String.IsNullOrEmpty(new_role_name))
            {
                MessageBox.Show("Debe ingresar un nombre para el rol", "Error");
                return;
            }

            if(no_changes(new_role_name))
            {
                MessageBox.Show("No se detectaron cambios en el nombre ni el estado", "Advertencia");
                this.Hide();
                new CRUDRoleForm().Show();
                return;
            }

            if (new_role_name != role.name)
            {
                if (role_already_exists(new_role_name))
                {
                    MessageBox.Show("El nombre del rol ingresado ya se encuentra en uso", "Error");
                    return;
                }
            }
            //Update the tables with the new information.
            update_tables(new_role_name);
            MessageBox.Show("Se modifico el rol exitosamente.", "Exito");
            this.Hide();
            new CRUDRoleForm().Show();
        }

        private Boolean no_changes(String new_name)
        {
            return new_name == role.name
                && role.active == Convert.ToBoolean(comboBoxStatus.SelectedIndex);
        }

        private void update_tables(String new_name)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@role_id", role.id));
            parameters.Add(new Parameter("@role_name", new_name));
            parameters.Add(new Parameter("@role_active", comboBoxStatus.SelectedIndex));
            StoreManager.getInstance().executeNonQuery("sp_update_role", parameters);

            if (Convert.ToBoolean(comboBoxStatus.SelectedIndex))
                removeRoleFromUsers();
        }

        private void removeRoleFromUsers()
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@role_id", role.id));
            StoreManager.getInstance().executeNonQuery("sp_remove_role_from_users", parameters);
        }

        private Boolean role_already_exists(String roleName)
        {
            List<Role> roles = StoreManager.getInstance().executeReadStore<Role>("sp_get_all_roles", new RoleMapper(), null);
            return roles.FindIndex(element => element.name == roleName) >= 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CRUDRoleForm().Show();
        }

        /**********************Auto-Generated Method for Designer***************************/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ModifyRole_Load(object sender, EventArgs e)
        {

        }
    }
}
