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
    public partial class Main : Form
    {
        public Main(User user){
            InitializeComponent();

            this.Text = "Bienvenido " + user.userName+ " - Sucursal "+user.actualBranch.name+" - Rol "+user.actualRole.name;
        }
    }
}
