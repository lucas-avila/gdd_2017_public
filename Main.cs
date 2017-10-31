using PagoAgilFrba.Model;
using PagoAgilFrba.Utils;
using PagoAgilFrba.Mappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.CRUDRole;
using PagoAgilFrba.CRUDBranch;
using PagoAgilFrba.CRUDBill;
using PagoAgilFrba.CRUDCompany;
using PagoAgilFrba.CRUDPayment;
using PagoAgilFrba.Refund;
using PagoAgilFrba.InvoiceView;

namespace PagoAgilFrba
{
    public partial class Main : Form{

        private User user;

        public Main(User user){
            InitializeComponent();
            this.user = user;
            this.Text = "Bienvenido " + user.userName+ " - Sucursal "+user.actualBranch.name+" - Rol "+user.actualRole.name;
            loadFuncionalities();
        }

        private void loadFuncionalities(){
            List<Functionality> funcionalities = searchFuncionalities();

            Dictionary<String, EventHandler> functions = getFunctions();

            int i=1;
            int cantVisible = 0;
            foreach(Functionality function in funcionalities){
                String btnId = "button"+i;

                Control[] control = this.Controls.Find(btnId,false);

                if (control != null && control.Length > 0) { 
                    control[0].Visible = true;
                    control[0].Text = function.name;
                    control[0].Click += functions[function.name];
                    cantVisible++;
                }

                i++;
            }
                this.Height = cantVisible * button1.Height + 170;
        }

        private Dictionary<String, EventHandler> getFunctions(){
            Dictionary<String, EventHandler> result = new Dictionary<String, EventHandler>();

            result.Add("ABM ROL",onClickABMRole);
            result.Add("ABM CLIENTE",onClickABMCliente);
            result.Add("ABM EMPRESA",onClickABMEmpresa);
            result.Add("ABM SUCURSAL",onClickABMSucursal);
            result.Add("ABM FACTURAS",onClickABMFacturas);
            result.Add("REGISTRO PAGO",onClickRegistroPago);
            result.Add("RENDICION FACTURAS",onClickRendicionFacturas);
            result.Add("LISTADO ESTADISTICO", onClickListadoEstadistico);
            result.Add("DEVOLUCIONES", onClickDevoluciones);

            return result;
        }

        private void onClickDevoluciones(object sender, EventArgs e){
            new RefundView().Show();
        }

        private void onClickListadoEstadistico(object sender, EventArgs e){
            MessageBox.Show("TODO");
        }

        private void onClickRendicionFacturas(object sender, EventArgs e){
            new s().Show();
        }

        private void onClickRegistroPago(object sender, EventArgs e){
            new CUPayment(user.actualBranch).Show();
        }

        private void onClickABMFacturas(object sender, EventArgs e){
            new CRUDBillForm().Show();
        }

        private void onClickABMSucursal(object sender, EventArgs e){
            new CRUDBranchForm().Show();
        }

        private void onClickABMEmpresa(object sender, EventArgs e){
            new CRUDCompanyForm().Show();
        }

        private void onClickABMCliente(object sender, EventArgs e){
            MessageBox.Show("TODO");
        }

        private void onClickABMRole(object sender, EventArgs e){
            new CRUDRoleForm().Show();
        }

        private List<Functionality> searchFuncionalities(){
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@role_id", user.actualRole.id));
            List<Functionality> functionalities = StoreManager.getInstance()
                   .executeReadStore<Functionality>("sp_get_role_functionalities", new FunctionalityMapper(), parameters);

            return functionalities;
        }

        private void btnLogout_Click(object sender, EventArgs e){
            new LoginForm().Show();
            this.Hide();
        }
    }
}
