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
using System.Windows.Forms;

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class ClientList2 : Form
    {
        public ClientList2(DateTime dt1, DateTime dt2)
        {
            InitializeComponent();
            this.dt1 = dt1;
            this.dt2 = dt2;
            doSearch();
        }
        private DateTime dt1, dt2;

        private void doSearch()
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@first_date", dt1));
            parameters.Add(new Parameter("@last_date", dt2));
            grid.DataSource = StoreManager.getInstance().executeReadStore<TopClientResult>("sp_top_clients_by_quantity_payments", new TopClientResultMapper(), parameters);
        }
    }
}
