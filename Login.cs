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

                if (!validateUser(logged, parameters)) {
                    return;
                }

                selectRolBranch(logged);
            }
        }

        private void selectRolBranch(User logged){
            List<Role> roles = findRoles(logged);

            if (roles.Count() == 0){
                MessageBox.Show("El usuario no posee roles asignados", "Info");
                return;
            }

            List<Branch> branchs = findBranchs(logged);

            if (branchs.Count() == 0){
                MessageBox.Show("El usuario no posee sucursales asignadas", "Info");
                return;
            }

            if (branchs.Count() == 1 && roles.Count() == 1){
                logged.actualBranch = branchs.FirstOrDefault();
                logged.actualRole = roles.FirstOrDefault();

                Main main = new Main(logged);
                main.Show();
                this.Hide();
            }else{
                SelectBranchRol select = new SelectBranchRol(roles,branchs,logged);
                select.Show();
                this.Hide();
            }
        }

        private Boolean validateUser(User logged, List<Parameter> parameters){
            if (logged == null){
                MessageBox.Show("Usuario no encontrado", "Error");
                return false;
            }

            if (!logged.active){
                MessageBox.Show("Usuario inactivo", "Error");
                return false;
            }

            if (!logged.password.Equals(Crypto.encrypt(txtPassword.Text))){
                MessageBox.Show("Contraseña incorrecta", "Error");
                logged.userAttempts++;
                parameters.Add(new Parameter("@login_attempts", logged.userAttempts));
                StoreManager.getInstance().executeNonQuery("sp_update_user_attempts", parameters);
                return false;
            }

            if (logged.userAttempts > 0){
                logged.userAttempts = 0;
                parameters.Add(new Parameter("@login_attempts", 0));
                StoreManager.getInstance().executeNonQuery("sp_update_user_attempts", parameters);
            }

            return true;
        }

        private List<Role> findRoles(User user) {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@user_id", user.userName));
            parameters.Add(new Parameter("@active", 1));

            return StoreManager.getInstance().executeReadStore<Role>("sp_get_roles", new RoleMapper(), parameters);
        }

        private List<Branch> findBranchs(User user){
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@user_id", user.userName));

            return StoreManager.getInstance().executeReadStore<Branch>("sp_get_branchs", new BranchMapper(), parameters);
        }
    }
}
