using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Model;
using PagoAgilFrba.Utils;
using PagoAgilFrba.Mappers;

namespace PagoAgilFrba.CRUDBill{
    public partial class CUBill : Form{

        private List<Item> items;
        private CRUDBillForm form;
        private Bill bill;
        private Boolean isNew;
        private List<int> toDelete;

        public CUBill(CRUDBillForm form,Bill bill = null){
            InitializeComponent();
            
            this.form = form;
            this.isNew = (bill == null);
            this.bill = bill;
            this.toDelete = new List<int>();

            initData();
            populateCombos();

            if (!isNew){
                setData();
            }
        }

        private void setData() {
            txtBillNumber.Text = bill.number.ToString();
            cmbClient.SelectedValue = bill.cli_id;
            cmbCompany.SelectedValue = bill.com_id;
            dbDate.Value = bill.date;
            dbExpiration.Value = bill.expiration;
            
            gridItems.DataSource = items;
        }

        private void populateCombos(){
            setCmbCompany();
            setCmbClient();
        }

        private void setCmbCompany(){
            cmbCompany.DataSource = StoreManager.getInstance().executeReadStore<Company>("sp_search_companies", new CompanyMapper());
            cmbCompany.DisplayMember = "name";
            cmbCompany.ValueMember = "id";
            cmbCompany.SelectedItem = null;
        }

        private void setCmbClient(){
            cmbClient.DataSource = StoreManager.getInstance().executeReadStore<ClientCombo>("sp_search_client_combo", new ClientComboMapper());
            cmbClient.DisplayMember = "name";
            cmbClient.ValueMember = "id";
            cmbClient.SelectedItem = null;
        }

        private void initData(){
            gridItems.AutoGenerateColumns = false;

            if (!isNew){
                List<Parameter> parameters = new List<Parameter>();
                parameters.Add(new Parameter("@it_bill_id", bill.id));
                items = StoreManager.getInstance().executeReadStore<Item>("sp_search_items_bill", new ItemMapper(), parameters);
            }else{
                items = new List<Item>();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e){
            new AddItem(this).Show();
        }

        private void button1_Click(object sender, EventArgs e){
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e){

            Decimal? billNumber = Util.convertStringToNumber(txtBillNumber.Text);

            if (!billNumber.HasValue) {
                MessageBox.Show("Debe ingresar el numero de factura","Error");
                return;
            }

            if (cmbCompany.SelectedItem == null){
                MessageBox.Show("Debe seleccionar una empresa", "Error");
                return;
            }

            if (cmbClient.SelectedItem == null){
                MessageBox.Show("Debe seleccionar un cliente", "Error");
                return;
            }

            if (items.Count == 0) {
                MessageBox.Show("Debe agregar al menos un item", "Error");
                return;
            }

            if (dbDate.Value.CompareTo(dbExpiration.Value) >= 0) {
                MessageBox.Show("La fecha de vencimiento debe ser posterior a la fecha de alta", "Error");
                return;
            }

            if (existBillNumber(billNumber.Value, bill.id)){
                MessageBox.Show("Ya existe el numero de factura " + txtBillNumber.Text, "Error");
                return;
            }

            Decimal possibleTotal =  items.Sum<Item>(i => i.amount);

            if (!Util.numberInRange(possibleTotal)) {
                MessageBox.Show("El valor de la factura es demasiado elevado (maximo 18 caracteres)", "Error");
                return;
            }

            doSave();
            form.doSearch();
            this.Hide();
        }

        private bool existBillNumber(Decimal billNumber, int bill_id){
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@bill_number", billNumber));
            if (!isNew){
                parameters.Add(new Parameter("@bill_id", bill_id));
            }

            Bill result = StoreManager.getInstance().executeReadSingleResult<Bill>("sp_check_bill_number", new BillMapper(), parameters);

            return result != null;
        }

        private void doSave(){
            getData();

            List<Parameter> parameters = getParametersSaveBill();

            int? pk = StoreManager.getInstance().executeNonQueryResultPK("sp_insert_update_bill", parameters);

            if (pk.HasValue) {
                bill.id = pk.Value;
            }

            doSaveItems();
        }

        private void doSaveItems(){
            deleteItems();

            foreach (Item it in items) {
                List<Parameter> parameters = new List<Parameter>();
                parameters.Add(new Parameter("@it_bill_id", bill.id));
                parameters.Add(new Parameter("@it_number", it.number));
                parameters.Add(new Parameter("@it_amount", it.amount));
                parameters.Add(new Parameter("@it_quantity", it.quantity));
                StoreManager.getInstance().executeNonQuery("sp_insert_update_item", parameters);
            }
        }

        private void deleteItems(){
            foreach(int numberDelete in toDelete){
                List<Parameter> parameters = new List<Parameter>();
                parameters.Add(new Parameter("@it_bill_id", bill.id));
                parameters.Add(new Parameter("@it_number", numberDelete));
                StoreManager.getInstance().executeNonQuery("sp_delete_item", parameters);
            }
        }

        private void getData(){
            bill.total = items.Sum<Item>(i => i.amount);
            bill.number = Util.convertStringToNumber(txtBillNumber.Text).Value;
            bill.date = dbDate.Value;
            bill.com_id = (int)cmbCompany.SelectedValue;
            bill.cli_id = (int)cmbClient.SelectedValue;
            bill.expiration = dbExpiration.Value;
        }

        private List<Parameter> getParametersSaveBill() {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@bill_id", bill.id));
            parameters.Add(new Parameter("@bill_total",bill.total));
            parameters.Add(new Parameter("@bill_number", bill.number));
            parameters.Add(new Parameter("@bill_date", bill.date));
            parameters.Add(new Parameter("@bill_expiration", bill.expiration));
            parameters.Add(new Parameter("@bill_com_id", bill.com_id));
            parameters.Add(new Parameter("@bill_cli_id", bill.cli_id));
            return parameters;
        }

        public void newItem(Item item){
            gridItems.DataSource = null;
            items.Add(item);
            gridItems.DataSource = items;
        }

        private void gridItems_CellContentClick(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex < 0 || e.ColumnIndex < 0){
                return;
            }
            string columnName = this.gridItems.Columns[e.ColumnIndex].Name;

            Item selected = ((Item)gridItems.Rows[e.RowIndex].DataBoundItem);

            if ("colDelete".Equals(columnName)){
                gridItems.DataSource = null;
                items.Remove(selected);
                
                if (selected.number.HasValue) {
                    toDelete.Add(selected.number.Value);
                }

                gridItems.DataSource = items;
            }
        }
    }
}
