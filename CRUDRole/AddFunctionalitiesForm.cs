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
    public partial class AddFunctionalitiesForm : Form
    {
        String role_name;
        public AddFunctionalitiesForm(List<String> func_names, String name)
        {
            InitializeComponent();
            role_name = name;
            funcBox.DataSource = filterFunctionalitiesAlreadyInUse(func_names);
        }

        private List<String> filterFunctionalitiesAlreadyInUse(List<String> func_names)
        {
            List<Functionality> functionalities = StoreManager.getInstance()
                .executeReadStore<Functionality>("sp_get_functionalities", new FunctionalityMapper(), null);
            List<String> all_func_names = functionalities.Select(func => func.name).ToList();
            return all_func_names.Where(func_name => !func_names.Contains(func_name))
                                               .ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var functionalities = funcBox.SelectedItems;
            //We check that there is at least a one functionality selected.
            if (functionalities.Count == 0)
            {
                MessageBox.Show("Debe elegir al menos una funcionalidad", "Error");
                return;
            }
            //Update the tables with the new information.
            update_tables();
            MessageBox.Show("Se agrego la/s funcionalidad/es exitosamente.", "Exito");
            this.Hide();
            new ModifyRole(role_name).Show();
        }

        private void update_tables()
        {
            // First we add the new role to Role table.
            List<Parameter> parameters = new List<Parameter>();
            //Then we add the relation between the role and its functionalities.
            foreach (String func in funcBox.SelectedItems)
            {
                parameters.Clear();
                parameters.Add(new Parameter("@role_name", role_name));
                parameters.Add(new Parameter("@func_name", func));
                StoreManager.getInstance().executeNonQuery("sp_link_functionality_role", parameters);
            }
        }
    }
}
