namespace PagoAgilFrba.ListadoEstadistico
{
    partial class ClientList1
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clientes segun porcentaje de facturas pagadas";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colLastName,
            this.colDni,
            this.colValue});
            this.grid.Location = new System.Drawing.Point(12, 40);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(429, 196);
            this.grid.TabIndex = 2;
            // 
            // colName
            // 
            this.colName.HeaderText = "Nombre";
            this.colName.Name = "colName";
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Apellido";
            this.colLastName.Name = "colLastName";
            // 
            // colDni
            // 
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Porcentaje de facturas";
            this.colValue.Name = "colValue";
            // 
            // ClientList1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid);
            this.Name = "ClientList1";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
    }
}