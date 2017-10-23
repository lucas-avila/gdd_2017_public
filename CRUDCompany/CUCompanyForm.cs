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
    public partial class CUCompanyForm : Form
    {
        private DelegateForm delegateForm;
        private Company edit;
        private Boolean isNew;
        private List<Entry> entries;
        public CUCompanyForm(DelegateForm delegateForm, Company edit = null)
        {
            InitializeComponent();
            setInitialData(edit);
            setEntryBox(edit);
            this.delegateForm = delegateForm;
            this.edit = edit != null ? edit : new Company();
        }

        private void setInitialData(Company edit)
        {
            if (edit != null)
            {
                this.Text = "Editar Empresa";
                statusBox.Checked = edit.active;
                nameBox.Text = edit.name;
                addressBox.Text = edit.address;
                cuitBox.Text = edit.cuit;
                this.isNew = false;
            }
            else
            {
                this.Text = "Crear Sucursal";
                statusBox.Checked = true;
                this.isNew = true;
            }
        }

        private void setEntryBox(Company edit)
        {
            entries = StoreManager.getInstance()
                .executeReadStore<Entry>("sp_get_all_entries", new EntryMapper(), null);
            entryBox.DataSource = entries;
            entryBox.DisplayMember = "description";
            entryBox.ValueMember = "description";
            entryBox.DropDownStyle = ComboBoxStyle.DropDownList;
            entryBox.SelectedItem = null;
            if (!isNew)
            {
                Entry entry = entries.Find(ent => ent.id == edit.entry);
                entryBox.SelectedIndex = entryBox.Items.IndexOf(entry);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String cuit = cuitBox.Text;
            String entry_description = this.entryBox.GetItemText(this.entryBox.SelectedItem);
            String address = addressBox.Text;
            Boolean active = statusBox.Checked;
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

            if (isNew)
            {
                if (cuitAlreadyExists(cuit))
                {
                    MessageBox.Show("El CUIT ingresado ya se encuentra en uso.", "Error");
                    return;
                }
            }

            if (String.IsNullOrEmpty(entryBox.GetItemText(entryBox.SelectedItem)))
            {
                MessageBox.Show("Debe seleccionar un rubro.", "Error");
                return;
            }

            addData(name, cuit, address, entry_description, active);
            MessageBox.Show("Se guardó la empresa con éxito", "Éxito");
            this.Hide();
            this.delegateForm.afterUpdate();
        }

        private void addData(String name, String cuit, String address, String entry, Boolean active)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@com_id", getCompanyId()));
            parameters.Add(new Parameter("@com_name", name));
            parameters.Add(new Parameter("@com_ent_id", getEntryId(entry)));
            parameters.Add(new Parameter("@com_cuit", cuit));
            parameters.Add(new Parameter("@com_address", address));
            parameters.Add(new Parameter("@com_active", active));
            StoreManager.getInstance().executeNonQuery("sp_insert_update_company", parameters);
        }

        private int? getCompanyId()
        {
            if (!this.isNew)
            {
                return edit.id;
            }
            return null;
        }

        private int? getEntryId(string description)
        {
            foreach (Entry entry in entries)
            {
                if (entry.description == description)
                    return entry.id;
            }
            return null;
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
  
        public interface DelegateForm
        {
            void afterUpdate();
        }
    }
}
