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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (Entities db = new Entities())
            {
                List<Role> roles = db.Role.Where((r) => r.role_active == true).ToList<Role>();

                MessageBox.Show("Cantidad de roles activos en DB " + roles.Count);
            }

        }
    }
}
