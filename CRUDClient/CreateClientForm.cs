﻿using PagoAgilFrba.Model;
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

namespace PagoAgilFrba.CRUDClient
{
    public partial class CreateClientForm : Form
    {
        decimal dni;
        String name, lastName, address, email, postcode;
        DateTime birthday;

        private DelegateForm delegateForm;
        private Client edit;
        private Boolean isNew;

        //CU -> Create/Update
        public CreateClientForm(DelegateForm delegateForm, Client edit = null)
        {
            InitializeComponent();
            setInitialData(edit);
            this.delegateForm = delegateForm;
            this.edit = edit != null ? edit : new Client();
        }

        private void setInitialData(Client edit)
        {
            if (edit != null)
            {
                this.Text = "Editar cliente";
                txtName.Text = edit.name;
                txtAddress.Text = edit.address;
                txtPostcode.Text = edit.postCode;
                this.isNew = false;
            }
            else
            {
                this.Text = "Agregar cliente";
                this.isNew = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillAttributes();
            List<Parameter> parameters = generateQueryParams();
            if (isNew)
                StoreManager.getInstance().executeNonQuery("sp_create_client", parameters);
            else
            {
                parameters.Add(new Parameter("@cli_id", edit.id));
                StoreManager.getInstance().executeNonQuery("sp_update_client", parameters);
            }
        }

        private List<Parameter> generateQueryParams()
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@cli_dni", dni));
            parameters.Add(new Parameter("@cli_name", name));
            parameters.Add(new Parameter("@cli_last_name", lastName));
            parameters.Add(new Parameter("@cli_date_birth", birthday));
            parameters.Add(new Parameter("@cli_email", email));
            parameters.Add(new Parameter("@cli_address", address));
            parameters.Add(new Parameter("@cli_postal_code", postcode));
            return parameters;
        }

        private void fillAttributes()
        {
            if (!Decimal.TryParse(txtDni.Text, out dni)) { }
                //show messagebox informing that the dni entered is not a number
            name = txtName.Text;
            lastName = txtLastName.Text;
            address = txtAddress.Text;
            email = txtMail.Text;
            postcode = txtPostcode.Text;
            birthday = dtBirthday.Value;
        }

        public interface DelegateForm
        {
            void afterUpdate();
        }
    }
}
