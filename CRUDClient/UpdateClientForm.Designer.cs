﻿namespace PagoAgilFrba.CRUDClient
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
            this.txtSearchLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridClients = new System.Windows.Forms.DataGridView();
            this.txtSearchDni = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modify = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            // txtSearchLastname
            // 
            this.txtSearchLastname.Location = new System.Drawing.Point(237, 16);
            this.txtSearchLastname.Name = "txtSearchLastname";
            this.txtSearchLastname.Size = new System.Drawing.Size(122, 20);
            this.txtSearchLastname.TabIndex = 18;
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
            this.name,
            this.lastName,
            this.dni,
            this.birth,
            this.email,
            this.address,
            this.postcode,
            this.modify});
            this.gridClients.Location = new System.Drawing.Point(12, 74);
            this.gridClients.Name = "gridClients";
            this.gridClients.ReadOnly = true;
            this.gridClients.Size = new System.Drawing.Size(743, 161);
            this.gridClients.TabIndex = 14;
            // 
            // txtSearchDni
            // 
            this.txtSearchDni.Location = new System.Drawing.Point(395, 16);
            this.txtSearchDni.Name = "txtSearchDni";
            this.txtSearchDni.Size = new System.Drawing.Size(122, 20);
            this.txtSearchDni.TabIndex = 23;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(523, 14);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(232, 54);
            this.btnCreate.TabIndex = 24;
            this.btnCreate.Text = "Crear nuevo cliente";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "lastName";
            this.lastName.HeaderText = "Apellido";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // birth
            // 
            this.birth.DataPropertyName = "birthday";
            this.birth.HeaderText = "Nacimiento";
            this.birth.Name = "birth";
            this.birth.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Direccion";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // postcode
            // 
            this.postcode.DataPropertyName = "postCode";
            this.postcode.HeaderText = "Codigo postal";
            this.postcode.Name = "postcode";
            this.postcode.ReadOnly = true;
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
            // UpdateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 251);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtSearchDni);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchLastname);
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
        private System.Windows.Forms.TextBox txtSearchLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridClients;
        private System.Windows.Forms.TextBox txtSearchDni;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcode;
        private System.Windows.Forms.DataGridViewButtonColumn modify;
    }
}