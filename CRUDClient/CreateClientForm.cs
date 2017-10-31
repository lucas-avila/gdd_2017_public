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

namespace PagoAgilFrba.CRUDClient
{
    public partial class CreateClientForm : Form
    {
        decimal dni;
        String name, lastName, address, email, postcode;
        DateTime birthday;
        Boolean active;

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
                txtDni.Text = edit.dni.ToString();
                txtLastName.Text = edit.lastName;
                dtBirthday.Value = edit.birthday;
                txtMail.Text = edit.email;
                txtAddress.Text = edit.address;
                txtPostcode.Text = edit.postCode;
                chkActive.Checked = edit.active;
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
            validateParams();
            fillAttributes();
            List<Parameter> parameters = generateQueryParams();
            if (isNew)
                StoreManager.getInstance().executeNonQuery("sp_create_client", parameters);
            else
            {
                parameters.Add(new Parameter("@cli_id", edit.id));
                StoreManager.getInstance().executeNonQuery("sp_update_client", parameters);
            }
            this.Hide();
            this.delegateForm.afterUpdate();
        }

        private void validateParams()
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Debe ingresar nombre", "Error");
                return;
            }

            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Debe ingresar una direccion", "Error");
                return;
            }

            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Debe ingresar un apellido", "Error");
                return;
            }

            if (String.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Debe ingresar un email", "Error");
                return;
            }

            if (String.IsNullOrEmpty(txtPostcode.Text) || Util.convertStringToNumber(txtPostcode.Text) == null)
            {
                MessageBox.Show("Debe un codigo postal (solo numerico)", "Error");
                return;
            }

            if (!isNew)
                return;
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@cli_email", txtMail.Text));

            Client result = StoreManager.getInstance().executeReadSingleResult<Client>("sp_exists_client_email", new ClientMapper(), parameters);

            if (result != null)
            {
                MessageBox.Show("Debe ingresar un email que no esté en uso", "Error");
                return;
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
            parameters.Add(new Parameter("@cli_active", active));
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
            active = chkActive.Checked;
        }

        public interface DelegateForm
        {
            void afterUpdate();
        }
    }
}
