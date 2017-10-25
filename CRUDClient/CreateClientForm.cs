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

        public CreateClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillAttributes();
            StoreManager.getInstance().executeNonQuery("sp_create_client", generateQueryParams());
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
    }
}
