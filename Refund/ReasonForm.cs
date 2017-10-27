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
    public partial class ReasonForm : Form
    {
        int id;
        RefundView view;
        public ReasonForm(int bill_id, RefundView view)
        {
            InitializeComponent();
            this.id = bill_id;
            this.view = view;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(reasonBox.Text))
            {
                MessageBox.Show("Debe ingresar una razón para la devolución.", "Error");
                return;
            }
            if(reasonBox.Text.Length > 255)
            {
                MessageBox.Show("La razón no debe exceder los 255 caracteres.", "Error");
                return;
            }

            refund_bill();
            this.view.doSearch();
        }

        private void refund_bill()
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@bill_id", this.id));
            parameters.Add(new Parameter("@ref_reason", reasonBox.Text));
            StoreManager.getInstance().executeNonQuery("sp_refund_bill", parameters);
            MessageBox.Show("Se realizó la devolución.", "Éxito");
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.view.doSearch();
            this.Hide();
        }
    }
}
