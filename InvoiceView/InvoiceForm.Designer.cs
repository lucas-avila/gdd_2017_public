namespace PagoAgilFrba.InvoiceView
{
    partial class InvoiceForm
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
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.numPercentage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dbDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numBills = new System.Windows.Forms.NumericUpDown();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.numTotal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa :";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(120, 47);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(228, 21);
            this.cmbCompany.TabIndex = 1;
            // 
            // numPercentage
            // 
            this.numPercentage.Location = new System.Drawing.Point(120, 89);
            this.numPercentage.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numPercentage.Name = "numPercentage";
            this.numPercentage.Size = new System.Drawing.Size(228, 20);
            this.numPercentage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porcentaje :";
            // 
            // dbDate
            // 
            this.dbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dbDate.Location = new System.Drawing.Point(120, 21);
            this.dbDate.Name = "dbDate";
            this.dbDate.Size = new System.Drawing.Size(228, 20);
            this.dbDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(192, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "* Solo se le puede rendir a empresas activas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad de Facturas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Importe total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Comision:";
            // 
            // numBills
            // 
            this.numBills.Enabled = false;
            this.numBills.Location = new System.Drawing.Point(120, 118);
            this.numBills.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numBills.Name = "numBills";
            this.numBills.ReadOnly = true;
            this.numBills.Size = new System.Drawing.Size(228, 20);
            this.numBills.TabIndex = 14;
            // 
            // numAmount
            // 
            this.numAmount.Enabled = false;
            this.numAmount.Location = new System.Drawing.Point(120, 146);
            this.numAmount.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.ReadOnly = true;
            this.numAmount.Size = new System.Drawing.Size(228, 20);
            this.numAmount.TabIndex = 15;
            // 
            // numTotal
            // 
            this.numTotal.Enabled = false;
            this.numTotal.Location = new System.Drawing.Point(120, 174);
            this.numTotal.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            131072});
            this.numTotal.Name = "numTotal";
            this.numTotal.ReadOnly = true;
            this.numTotal.Size = new System.Drawing.Size(228, 20);
            this.numTotal.TabIndex = 16;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 242);
            this.Controls.Add(this.numTotal);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.numBills);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dbDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numPercentage);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceForm";
            this.Text = "Rendicion";
            ((System.ComponentModel.ISupportInitialize)(this.numPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.NumericUpDown numPercentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dbDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numBills;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.NumericUpDown numTotal;
    }
}