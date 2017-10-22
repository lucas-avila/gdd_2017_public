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

namespace PagoAgilFrba.CRUDCompany
{
    public partial class CreateCompanyForm : Form
    {
        List<Entry> entries;
        public CreateCompanyForm()
        {
            InitializeComponent();
            setEntryBox();
        }

        private void setEntryBox()
        {
            entries = StoreManager.getInstance()
                   .executeReadStore<Entry>("sp_get_all_entries", new EntryMapper(), null);
            entryBox.DataSource = entries;
            entryBox.DisplayMember = "description";
            entryBox.ValueMember = "description";
            this.entryBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String cuit = cuitBox.Text;
            String entry_description = this.entryBox.GetItemText(this.entryBox.SelectedItem);
            String address = addressBox.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Debe ingresar un nombre", "Error");
                return;
            }
            if (String.IsNullOrEmpty(cuit))
            {
                MessageBox.Show("Debe ingresar un CUIT", "Error");
                return;
            }
            if (String.IsNullOrEmpty(address))
            {
                MessageBox.Show("Debe ingresar una dirección", "Error");
                return;
            }
            if (name.Length > 255 || address.Length > 255)
            {
                MessageBox.Show("El nombre y la direccion pueden tener como máximo 255 caracteres.", "Error");
                return;
            }
            if (cuit.Length > 50)
            {
                MessageBox.Show("El cuit puede tener como maximo 50 numeros.", "Error");
                return;
            }
            if (!cuit.All(char.IsDigit))
            {
                MessageBox.Show("El CUIT solo puede contener números. Si está usando '-' por favor remuevalos", "Error");
                return;
            }

            if (cuitAlreadyExists(cuit))
            {
                MessageBox.Show("El CUIT ingresado ya se encuentra en uso.", "Error");
                return;
            }

            addCompany(name, cuit, address, entry_description);
            MessageBox.Show("La compañía se agrego con éxito", "Éxito");
            this.Hide();
        }

        private void addCompany(String name, String cuit, String address, String entry)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@com_name", name));
            parameters.Add(new Parameter("@com_ent_id", getEntryId(entry)));
            parameters.Add(new Parameter("@com_cuit", cuit));
            parameters.Add(new Parameter("@com_address", address));
            StoreManager.getInstance().executeNonQuery("sp_add_company", parameters);
        }

        private int getEntryId(string description)
        {
            foreach (Entry entry in entries)
            {
                if (entry.description == description)
                    return entry.id;
            }
            return 0;
        }

        private Boolean cuitAlreadyExists(String cuit)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@com_cuit", cuit));
            return StoreManager.getInstance()
                .executeReadStore<Company>("sp_check_cuit", new CompanyMapper(), parameters)
                .Count != 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
