﻿using PagoAgilFrba.Mappers;
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
    public partial class CRUDRoleForm : Form
    {
        public CRUDRoleForm()
        {
            InitializeComponent();
            setRolesBox();
        }

        private void setRolesBox()
        {
            List<Role> roles = StoreManager.getInstance()
                               .executeReadStore<Role>("sp_get_all_roles", new RoleMapper(), null);
            List<String> roles_names = roles.Select(role => role.name).ToList();
            rolesBox.DataSource = roles_names;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateRole createRole = new CreateRole();
            createRole.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            String role_name = rolesBox.SelectedItem.ToString();
            if (String.IsNullOrEmpty(role_name))
            {
                MessageBox.Show("Debe seleccionar un rol de la lista para modificarlo", "Error");
                return;
            }

            new ModifyRole(role_name).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void roles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String role = rolesBox.SelectedItem.ToString();

            if (String.IsNullOrEmpty(role))
            {
                MessageBox.Show("Debe seleccionar un rol para inhabilitar", "Error");
                return;
            }

            disableRole(role);
        }

        private void disableRole(String role_name)
        {
            Role role = getRole(role_name);
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@role_name", role_name));
            StoreManager.getInstance().executeNonQuery("sp_disable_role", parameters);
            MessageBox.Show("Se inhabilitó el rol correctamente", "Éxito");
        }

        private Role getRole(String role_name)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@role_name", role_name));
            return StoreManager.getInstance().executeReadStore<Role>("sp_get_role", new RoleMapper(), parameters).First();
        }
    }
}
