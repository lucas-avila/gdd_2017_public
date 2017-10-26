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

namespace PagoAgilFrba.Refund
{
    public partial class RefundView : Form
    {
        public RefundView()
        {
            InitializeComponent();
        }

        public void setBillsBox()
        {
            billsBox.Columns["id"].Visible = false;
            billsBox.Columns["number"].DisplayIndex = 0;
            billsBox.Columns["cli_dni"].DisplayIndex = 1;
            billsBox.Columns["com_id"].Visible = false;
            billsBox.Columns["total"].DisplayIndex = 2;

            billsBox.Columns["number"].HeaderText = "Nro";
            billsBox.Columns["cli_dni"].HeaderText = "Cliente D.N.I";
            billsBox.Columns["total"].HeaderText = "Total";

            billsBox.Columns["cli_dni"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            billsBox.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            billsBox.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            billsBox.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void doSearch()
        {
            if (String.IsNullOrEmpty(dniBox.Text)  && String.IsNullOrEmpty(billNroBox.Text))
            {
                MessageBox.Show("Debe ingresar algún parámetro de búsqueda.", "Error");
                return;
            }
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@cli_dni", Util.convertStringToNumber(dniBox.Text)));
            parameters.Add(new Parameter("@bill_number", Util.convertStringToNumber(billNroBox.Text)));
            billsBox.DataSource = StoreManager.getInstance().executeReadStore<Bill>("sp_search_bills", new BillMapper(), parameters);
            setBillsBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.doSearch();
        }

        private void billsBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            String columnName = this.billsBox.Columns[e.ColumnIndex].Name;

            Bill selected = ((Bill)billsBox.Rows[e.RowIndex].DataBoundItem);

            if ("refund".Equals(columnName))
            {
                if (canBeRefunded(selected))
                {
                    MessageBox.Show("Good job", "Success");
                    return;
                    //TODO: do the refund...
                }
                else
                {
                    MessageBox.Show("No se puede reembolsar una factura ya rendida.", "Error");
                    return;
                }
            }

        }
        
        private Boolean canBeRefunded(Bill bill)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@bill_id", bill.id));
            return Convert.ToBoolean(StoreManager.getInstance().getStoreProcedureResult("sp_bill_can_be_refunded", parameters));
        }
    }
}
