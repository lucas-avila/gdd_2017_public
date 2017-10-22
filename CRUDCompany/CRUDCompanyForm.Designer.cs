namespace PagoAgilFrba.CRUDCompany
{
    partial class CRUDCompanyForm
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
            this.gridCompanies = new System.Windows.Forms.DataGridView();
            this.modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cuitBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.entryBox = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCompanies
            // 
            this.gridCompanies.AllowUserToAddRows = false;
            this.gridCompanies.AllowUserToDeleteRows = false;
            this.gridCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompanies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modify});
            this.gridCompanies.Location = new System.Drawing.Point(12, 64);
            this.gridCompanies.Name = "gridCompanies";
            this.gridCompanies.ReadOnly = true;
            this.gridCompanies.Size = new System.Drawing.Size(505, 150);
            this.gridCompanies.TabIndex = 0;
            this.gridCompanies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCompanies_CellContentClick);
            // 
            // modify
            // 
            this.modify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modify.HeaderText = "Acción";
            this.modify.Name = "modify";
            this.modify.ReadOnly = true;
            this.modify.Text = "Modificar";
            this.modify.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre: ";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(56, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(122, 20);
            this.nameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUIT:";
            // 
            // cuitBox
            // 
            this.cuitBox.Location = new System.Drawing.Point(222, 6);
            this.cuitBox.Name = "cuitBox";
            this.cuitBox.Size = new System.Drawing.Size(122, 20);
            this.cuitBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rubro:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(169, 35);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // entryBox
            // 
            this.entryBox.FormattingEnabled = true;
            this.entryBox.Location = new System.Drawing.Point(395, 6);
            this.entryBox.Name = "entryBox";
            this.entryBox.Size = new System.Drawing.Size(121, 21);
            this.entryBox.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(442, 220);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(269, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CRUDCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 255);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.entryBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cuitBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridCompanies);
            this.Name = "CRUDCompanyForm";
            this.Text = "Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.gridCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCompanies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuitBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox entryBox;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridViewButtonColumn modify;
        private System.Windows.Forms.Button btnClear;
    }
}