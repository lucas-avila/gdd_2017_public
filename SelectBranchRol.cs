using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class SelectBranchRol : Form{

        private List<Role> roles { get; set; }
        private List<Branch> branchs { get; set; }
        private User user { get; set; }

        public SelectBranchRol(List<Role> roles, List<Branch> branchs, User user){
            InitializeComponent();
            this.roles = roles;
            this.branchs = branchs;
            this.user = user;
        }

        private void btnAceptar_Click(object sender, EventArgs e){

            if (cmbBranch.SelectedItem == null) {
                MessageBox.Show("Debe seleccionar una sucursal");
                return;
            }

            if (cmbRole.SelectedItem == null){
                MessageBox.Show("Debe seleccionar un rol");
                return;
            }

            user.actualBranch = (Branch)cmbBranch.SelectedItem;
            user.actualRole = (Role)cmbRole.SelectedItem;

            Main main = new Main(user);
            main.Show();
            this.Hide();

        }

        private void SelectBranchRol_Load(object sender, EventArgs e){

            cmbBranch.DataSource = branchs;
            cmbBranch.DisplayMember = "name";
            cmbRole.DataSource = roles;
            cmbRole.DisplayMember = "name";
        }
    }
}
