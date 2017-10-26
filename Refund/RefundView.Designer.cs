namespace PagoAgilFrba.Refund
{
    partial class RefundView
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
            this.dniBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.billNroBox = new System.Windows.Forms.TextBox();
            this.billsBox = new System.Windows.Forms.DataGridView();
            this.refund = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.billsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.N.I del Cliente:";
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(105, 6);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(215, 20);
            this.dniBox.TabIndex = 1;
            this.dniBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(352, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar facturas";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro de Factura: ";
            // 
            // billNroBox
            // 
            this.billNroBox.Location = new System.Drawing.Point(105, 35);
            this.billNroBox.Name = "billNroBox";
            this.billNroBox.Size = new System.Drawing.Size(101, 20);
            this.billNroBox.TabIndex = 4;
            // 
            // billsBox
            // 
            this.billsBox.AllowUserToAddRows = false;
            this.billsBox.AllowUserToDeleteRows = false;
            this.billsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refund});
            this.billsBox.Location = new System.Drawing.Point(12, 79);
            this.billsBox.Name = "billsBox";
            this.billsBox.ReadOnly = true;
            this.billsBox.Size = new System.Drawing.Size(415, 150);
            this.billsBox.TabIndex = 5;
            this.billsBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billsBox_CellContentClick);
            // 
            // refund
            // 
            this.refund.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.refund.HeaderText = "Acción";
            this.refund.Name = "refund";
            this.refund.ReadOnly = true;
            this.refund.Text = "Reembolsar";
            this.refund.UseColumnTextForButtonValue = true;
            // 
            // RefundView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 261);
            this.Controls.Add(this.billsBox);
            this.Controls.Add(this.billNroBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.label1);
            this.Name = "RefundView";
            this.Text = "Devoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.billsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox billNroBox;
        private System.Windows.Forms.DataGridView billsBox;
        private System.Windows.Forms.DataGridViewButtonColumn refund;
    }
}