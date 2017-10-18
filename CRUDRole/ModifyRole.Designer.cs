namespace PagoAgilFrba.CRUDRole
{
    partial class ModifyRole
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
            this.textBoxRoleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.funcBox = new System.Windows.Forms.ListBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnAddFunc = new System.Windows.Forms.Button();
            this.btnRemoveFunc = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // textBoxRoleName
            // 
            this.textBoxRoleName.Location = new System.Drawing.Point(65, 21);
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.Size = new System.Drawing.Size(192, 20);
            this.textBoxRoleName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estado:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Funcionalidades:";
            // 
            // funcBox
            // 
            this.funcBox.FormattingEnabled = true;
            this.funcBox.Location = new System.Drawing.Point(15, 100);
            this.funcBox.Name = "funcBox";
            this.funcBox.Size = new System.Drawing.Size(171, 121);
            this.funcBox.TabIndex = 15;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(65, 52);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 16;
            // 
            // btnAddFunc
            // 
            this.btnAddFunc.Location = new System.Drawing.Point(197, 100);
            this.btnAddFunc.Name = "btnAddFunc";
            this.btnAddFunc.Size = new System.Drawing.Size(75, 23);
            this.btnAddFunc.TabIndex = 17;
            this.btnAddFunc.Text = "Agregar";
            this.btnAddFunc.UseVisualStyleBackColor = true;
            this.btnAddFunc.Click += new System.EventHandler(this.btnAddFunc_Click);
            // 
            // btnRemoveFunc
            // 
            this.btnRemoveFunc.Location = new System.Drawing.Point(197, 129);
            this.btnRemoveFunc.Name = "btnRemoveFunc";
            this.btnRemoveFunc.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFunc.TabIndex = 18;
            this.btnRemoveFunc.Text = "Eliminar";
            this.btnRemoveFunc.UseVisualStyleBackColor = true;
            this.btnRemoveFunc.Click += new System.EventHandler(this.btnRemoveFunc_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(176, 226);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(96, 23);
            this.btnAccept.TabIndex = 19;
            this.btnAccept.Text = "Aceptar cambios";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ModifyRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnRemoveFunc);
            this.Controls.Add(this.btnAddFunc);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.funcBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRoleName);
            this.Controls.Add(this.label1);
            this.Name = "ModifyRole";
            this.Text = "Modificar Rol";
            this.Load += new System.EventHandler(this.ModifyRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox funcBox;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button btnAddFunc;
        private System.Windows.Forms.Button btnRemoveFunc;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}