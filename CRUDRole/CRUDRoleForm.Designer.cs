namespace PagoAgilFrba.CRUDRole
{
    partial class CRUDRoleForm
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.rolesBox = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(200, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 155);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(95, 23);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // rolesBox
            // 
            this.rolesBox.FormattingEnabled = true;
            this.rolesBox.Location = new System.Drawing.Point(12, 54);
            this.rolesBox.Name = "rolesBox";
            this.rolesBox.Size = new System.Drawing.Size(200, 95);
            this.rolesBox.TabIndex = 10;
            this.rolesBox.SelectedIndexChanged += new System.EventHandler(this.roles_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(117, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CRUDRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 191);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rolesBox);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Name = "CRUDRoleForm";
            this.Text = "Roles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ListBox rolesBox;
        private System.Windows.Forms.Button btnDelete;
    }
}