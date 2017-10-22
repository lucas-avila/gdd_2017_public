namespace PagoAgilFrba.CRUDBill
{
    partial class CRUDBillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridBill = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dbDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dbExpiration = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBill)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBill
            // 
            this.gridBill.AllowUserToAddRows = false;
            this.gridBill.AllowUserToDeleteRows = false;
            this.gridBill.AllowUserToOrderColumns = true;
            this.gridBill.AllowUserToResizeRows = false;
            this.gridBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBill.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gridBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCompany,
            this.colClient,
            this.colDate,
            this.colExpiration,
            this.colTotal,
            this.colEdit});
            this.gridBill.Location = new System.Drawing.Point(12, 98);
            this.gridBill.MultiSelect = false;
            this.gridBill.Name = "gridBill";
            this.gridBill.ReadOnly = true;
            this.gridBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridBill.RowHeadersVisible = false;
            this.gridBill.Size = new System.Drawing.Size(704, 226);
            this.gridBill.TabIndex = 8;
            // 
            // colName
            // 
            this.colName.FillWeight = 105F;
            this.colName.HeaderText = "Nro. Factura";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCompany
            // 
            this.colCompany.HeaderText = "Empresa";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            // 
            // colClient
            // 
            this.colClient.HeaderText = "Cliente";
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Fecha de Alta";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colExpiration
            // 
            this.colExpiration.HeaderText = "Fecha de vencimiento";
            this.colExpiration.Name = "colExpiration";
            this.colExpiration.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.FillWeight = 70F;
            this.colEdit.HeaderText = "";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEdit.Text = "Editar";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(641, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(641, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Filtrar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(562, 69);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilters.TabIndex = 6;
            this.btnClearFilters.Text = "Limpiar";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nro. Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Empresa:";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Location = new System.Drawing.Point(89, 13);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(129, 20);
            this.txtBillNumber.TabIndex = 0;
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(346, 14);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(129, 21);
            this.cmbCompany.TabIndex = 1;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(540, 13);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(129, 21);
            this.cmbClient.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cliente:";
            // 
            // dbDate
            // 
            this.dbDate.Checked = false;
            this.dbDate.CustomFormat = "";
            this.dbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dbDate.Location = new System.Drawing.Point(89, 40);
            this.dbDate.Name = "dbDate";
            this.dbDate.ShowCheckBox = true;
            this.dbDate.Size = new System.Drawing.Size(129, 20);
            this.dbDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de alta:";
            // 
            // dbExpiration
            // 
            this.dbExpiration.Checked = false;
            this.dbExpiration.CustomFormat = "";
            this.dbExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dbExpiration.Location = new System.Drawing.Point(346, 40);
            this.dbExpiration.Name = "dbExpiration";
            this.dbExpiration.ShowCheckBox = true;
            this.dbExpiration.Size = new System.Drawing.Size(129, 20);
            this.dbExpiration.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha de Vencimiento:";
            // 
            // CRUDBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 333);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dbExpiration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dbDate);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.txtBillNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.gridBill);
            this.Name = "CRUDBillForm";
            this.Text = "CRUDBIllForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dbDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dbExpiration;
        private System.Windows.Forms.Label label5;
    }
}