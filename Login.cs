using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Utils;
using PagoAgilFrba.Mappers;
using PagoAgilFrba.Model;

namespace PagoAgilFrba
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e){

            var username = txtUser.Text;
            var password = txtPassword.Text;
            

            if (String.IsNullOrEmpty(password) || String.IsNullOrEmpty(username)){
                MessageBox.Show("Debe ingresar usuario y contraseña", "Error");
            } else {
                List<Parameter> parameters = new List<Parameter>();
                parameters.Add(new Parameter("@username", username));

                User logged = StoreManager.getInstance().executeReadSingleResult<User>("sp_get_user", new UserMapper(), parameters);

                if (logged == null) {
                    MessageBox.Show("Usuario no encontrado", "Error");
                    return;
                }

                if (!logged.password.Equals(Crypto.encrypt(password))) {
                    MessageBox.Show("Contraseña incorrecta", "Error");
                    return;
                }

                //TODO ver que se hace con la variable logged y a quien se la pasa

            }
        }
    }
}
