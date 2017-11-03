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
            this.txtSearchLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridClients = new System.Windows.Forms.DataGridView();
            this.txtSearchDni = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(885, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(538, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(341, 23);
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
            this.txtSearchLastname.MaxLength = 255;
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
            this.txtSearchName.MaxLength = 255;
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
            this.gridClients.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.name,
            this.lastName,
            this.birth,
            this.email,
            this.address,
            this.postcode,
            this.colActive,
            this.colEdit});
            this.gridClients.GridColor = System.Drawing.SystemColors.Menu;
            this.gridClients.Location = new System.Drawing.Point(12, 43);
            this.gridClients.MultiSelect = false;
            this.gridClients.Name = "gridClients";
            this.gridClients.ReadOnly = true;
            this.gridClients.RowHeadersVisible = false;
            this.gridClients.Size = new System.Drawing.Size(948, 328);
            this.gridClients.TabIndex = 14;
            this.gridClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClients_CellContentClick);
            // 
            // txtSearchDni
            // 
            this.txtSearchDni.Location = new System.Drawing.Point(395, 16);
            this.txtSearchDni.MaxLength = 18;
            this.txtSearchDni.Name = "txtSearchDni";
            this.txtSearchDni.Size = new System.Drawing.Size(122, 20);
            this.txtSearchDni.TabIndex = 23;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 377);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(948, 54);
            this.btnCreate.TabIndex = 24;
            this.btnCreate.Text = "Crear nuevo cliente";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
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
            // colActive
            // 
            this.colActive.DataPropertyName = "active";
            this.colActive.HeaderText = "Activo";
            this.colActive.Name = "colActive";
            this.colActive.ReadOnly = true;
            this.colActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEdit.HeaderText = "Acción";
            this.colEdit.MinimumWidth = 80;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Modificar";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // UpdateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 437);
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
            this.Text = "Panel de clientes";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    }
}