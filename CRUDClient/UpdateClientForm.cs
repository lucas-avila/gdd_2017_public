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

namespace PagoAgilFrba.CRUDClient
{
    public partial class UpdateClientForm : Form
    {
        public UpdateClientForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            doSearch();
        }

        private void doSearch()
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@cli_name", txtSearchName.Text));
            parameters.Add(new Parameter("@cli_last_name", txtSearchLastname.Text));
            parameters.Add(new Parameter("@cli_dni", Util.convertStringToNumber(txtSearchDni.Text)));
            gridClients.DataSource = StoreManager.getInstance().executeReadStore<Client>("sp_select_client", new ClientMapper(), parameters);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new CreateClientForm(new DelegateCUClient(this)).Show();
        }

        private void gridClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            string columnName = this.gridClients.Columns[e.ColumnIndex].Name;

            Client selected = ((Client)gridClients.Rows[e.RowIndex].DataBoundItem);

            if ("colEdit".Equals(columnName))
            {
                (new CreateClientForm(new DelegateCUClient(this), selected)).Show();
            }
        }

        private class DelegateCUClient : CreateClientForm.DelegateForm
        {

            private UpdateClientForm form;

            public DelegateCUClient(UpdateClientForm form)
            {
                this.form = form;
            }

            public void afterUpdate()
            {
                form.doSearch();
            }
        }
    }
}
