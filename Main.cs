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

            int i=1;
            foreach(Functionality function in funcionalities){
                String btnId = "button"+i;

                Control[] control = this.Controls.Find(btnId,false);

                if (control != null && control.Length > 0) { 
                    control[0].Visible = true;
                    control[0].Text = function.name;
                }

                i++;
            }
        }

        private List<Functionality> searchFuncionalities(){
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@role_id", user.actualRole.id));
            List<Functionality> functionalities = StoreManager.getInstance()
                   .executeReadStore<Functionality>("sp_get_role_functionalities", new FunctionalityMapper(), parameters);

            return functionalities;
        }
    }
}
