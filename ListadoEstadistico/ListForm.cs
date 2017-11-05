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
    public partial class ListForm : Form
    {
        private DateTime dt1;
        private DateTime dt2;

        public ListForm()
        {
            InitializeComponent();
            dtYear.Format = DateTimePickerFormat.Custom;
            dtYear.CustomFormat = "yyyy";
            dtYear.ShowUpDown = true;
        }

        private void fillDateTimes()
        {
            int year = dtYear.Value.Year;
            switch (cmbTrimester.SelectedIndex)
            {
                case 0:
                    dt1 = new DateTime(year, 1, 1);
                    dt2 = new DateTime(year, 3, 31);
                    break;
                case 1:
                    dt1 = new DateTime(year, 4, 1);
                    dt2 = new DateTime(year, 6, 30);
                    break;
                case 2:
                    dt1 = new DateTime(year, 7, 1);
                    dt2 = new DateTime(year, 9, 30);
                    break;
                case 3:
                    dt1 = new DateTime(year, 10, 1);
                    dt2 = new DateTime(year, 12, 31);
                    break;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            fillDateTimes();
            switch (cmbOptions.SelectedIndex)
            {
                case 0:
                    new CompanyList1(dt1, dt2).Show();
                    break;
                case 1:
                    new CompanyList2(dt1, dt2).Show();
                    break;
                case 2:
                    new ClientList1(dt1, dt2).Show();
                    break;
                case 3:
                    new ClientList2(dt1, dt2).Show();
                    break;
            }
        }
    }
}
