namespace PagoAgilFrba.CRUDBill
{
    partial class CUBill
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
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dbDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dbExpiration = new System.Windows.Forms.DateTimePicker();
            this.gridItems = new System.Windows.Forms.DataGridView();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Location = new System.Drawing.Point(132, 8);
            this.txtBillNumber.MaxLength = 18;
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(278, 20);
            this.txtBillNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nro. Factura:";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(132, 35);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(278, 21);
            this.cmbCompany.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Empresa:";
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(132, 62);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(278, 21);
            this.cmbClient.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha de alta:";
            // 
            // dbDate
            // 
            this.dbDate.Checked = false;
            this.dbDate.CustomFormat = "";
            this.dbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dbDate.Location = new System.Drawing.Point(132, 89);
            this.dbDate.Name = "dbDate";
            this.dbDate.Size = new System.Drawing.Size(278, 20);
            this.dbDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha de Vencimiento:";
            // 
            // dbExpiration
            // 
            this.dbExpiration.Checked = false;
            this.dbExpiration.CustomFormat = "";
            this.dbExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dbExpiration.Location = new System.Drawing.Point(132, 115);
            this.dbExpiration.Name = "dbExpiration";
            this.dbExpiration.Size = new System.Drawing.Size(278, 20);
            this.dbExpiration.TabIndex = 4;
            // 
            // gridItems
            // 
            this.gridItems.AllowUserToAddRows = false;
            this.gridItems.AllowUserToDeleteRows = false;
            this.gridItems.AllowUserToResizeColumns = false;
            this.gridItems.AllowUserToResizeRows = false;
            this.gridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridItems.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuantity,
            this.colAmount,
            this.colDelete});
            this.gridItems.Location = new System.Drawing.Point(15, 190);
            this.gridItems.MultiSelect = false;
            this.gridItems.Name = "gridItems";
            this.gridItems.RowHeadersVisible = false;
            this.gridItems.ShowCellErrors = false;
            this.gridItems.ShowCellToolTips = false;
            this.gridItems.ShowEditingIcon = false;
            this.gridItems.ShowRowErrors = false;
            this.gridItems.Size = new System.Drawing.Size(395, 116);
            this.gridItems.TabIndex = 7;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(335, 161);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Agregar Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(335, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "quantity";
            this.colQuantity.FillWeight = 70F;
            this.colQuantity.HeaderText = "Cantidad";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "amount";
            this.colAmount.HeaderText = "Monto";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.FillWeight = 50F;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Borrar";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // CUBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dbExpiration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dbDate);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBillNumber);
            this.Name = "CUBill";
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dbDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dbExpiration;
        private System.Windows.Forms.DataGridView gridItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}