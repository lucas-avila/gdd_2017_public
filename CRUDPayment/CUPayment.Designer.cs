namespace PagoAgilFrba.CRUDPayment
{
    partial class CUPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.dbDate = new System.Windows.Forms.DateTimePicker();
            this.gridBills = new System.Windows.Forms.DataGridView();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.nroAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nroAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha de Cobro :";
            // 
            // dbDate
            // 
            this.dbDate.CustomFormat = "";
            this.dbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dbDate.Location = new System.Drawing.Point(103, 47);
            this.dbDate.Name = "dbDate";
            this.dbDate.Size = new System.Drawing.Size(201, 20);
            this.dbDate.TabIndex = 12;
            // 
            // gridBills
            // 
            this.gridBills.AllowUserToAddRows = false;
            this.gridBills.AllowUserToDeleteRows = false;
            this.gridBills.AllowUserToResizeColumns = false;
            this.gridBills.AllowUserToResizeRows = false;
            this.gridBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBills.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gridBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuantity,
            this.colDelete});
            this.gridBills.Location = new System.Drawing.Point(14, 169);
            this.gridBills.MultiSelect = false;
            this.gridBills.Name = "gridBills";
            this.gridBills.RowHeadersVisible = false;
            this.gridBills.ShowCellErrors = false;
            this.gridBills.ShowCellToolTips = false;
            this.gridBills.ShowEditingIcon = false;
            this.gridBills.ShowRowErrors = false;
            this.gridBills.Size = new System.Drawing.Size(292, 116);
            this.gridBills.TabIndex = 11;
            this.gridBills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBills_CellContentClick);
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "number";
            this.colQuantity.FillWeight = 70F;
            this.colQuantity.HeaderText = "Numero de Factura";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Forma de Pago :";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(103, 73);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(201, 21);
            this.cmbPaymentMethod.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sucursal :";
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(103, 20);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(201, 21);
            this.cmbBranch.TabIndex = 17;
            // 
            // nroAmount
            // 
            this.nroAmount.DecimalPlaces = 2;
            this.nroAmount.Enabled = false;
            this.nroAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nroAmount.Location = new System.Drawing.Point(103, 100);
            this.nroAmount.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            131072});
            this.nroAmount.Name = "nroAmount";
            this.nroAmount.ReadOnly = true;
            this.nroAmount.Size = new System.Drawing.Size(201, 20);
            this.nroAmount.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Importe :";
            // 
            // btnAddBill
            // 
            this.btnAddBill.Location = new System.Drawing.Point(208, 140);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(98, 23);
            this.btnAddBill.TabIndex = 20;
            this.btnAddBill.Text = "Agregar Factura";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(228, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(147, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CUPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 333);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nroAmount);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbDate);
            this.Controls.Add(this.gridBills);
            this.Name = "CUPayment";
            this.Text = "Pago";
            ((System.ComponentModel.ISupportInitialize)(this.gridBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nroAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dbDate;
        private System.Windows.Forms.DataGridView gridBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.NumericUpDown nroAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}