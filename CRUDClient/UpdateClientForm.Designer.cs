namespace PagoAgilFrba.CRUDClient
{
    partial class UpdateClientForm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchLastnametxtSearchLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridClients = new System.Windows.Forms.DataGridView();
            this.modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearchDni = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(269, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(169, 45);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 20;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dni:";
            // 
            // txtSearchLastnametxtSearchLastname
            // 
            this.txtSearchLastnametxtSearchLastname.Location = new System.Drawing.Point(237, 16);
            this.txtSearchLastnametxtSearchLastname.Name = "txtSearchLastnametxtSearchLastname";
            this.txtSearchLastnametxtSearchLastname.Size = new System.Drawing.Size(122, 20);
            this.txtSearchLastnametxtSearchLastname.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(56, 16);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(122, 20);
            this.txtSearchName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre: ";
            // 
            // gridClients
            // 
            this.gridClients.AllowUserToAddRows = false;
            this.gridClients.AllowUserToDeleteRows = false;
            this.gridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modify});
            this.gridClients.Location = new System.Drawing.Point(12, 74);
            this.gridClients.Name = "gridClients";
            this.gridClients.ReadOnly = true;
            this.gridClients.Size = new System.Drawing.Size(517, 161);
            this.gridClients.TabIndex = 14;
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
            // txtSearchDni
            // 
            this.txtSearchDni.Location = new System.Drawing.Point(395, 16);
            this.txtSearchDni.Name = "txtSearchDni";
            this.txtSearchDni.Size = new System.Drawing.Size(122, 20);
            this.txtSearchDni.TabIndex = 23;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 241);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(517, 34);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // UpdateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 287);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSearchDni);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchLastnametxtSearchLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridClients);
            this.Name = "UpdateClientForm";
            this.Text = "UpdateClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchLastnametxtSearchLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridClients;
        private System.Windows.Forms.DataGridViewButtonColumn modify;
        private System.Windows.Forms.TextBox txtSearchDni;
        private System.Windows.Forms.Button btnEdit;
    }
}