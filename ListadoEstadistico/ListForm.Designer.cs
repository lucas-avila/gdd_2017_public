namespace PagoAgilFrba.ListadoEstadistico
{
    partial class ListForm
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
            this.cmbOptions = new System.Windows.Forms.ComboBox();
            this.cmbTrimester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtYear = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione criterio de busqueda";
            // 
            // cmbOptions
            // 
            this.cmbOptions.FormattingEnabled = true;
            this.cmbOptions.Items.AddRange(new object[] {
            "Companías con mayor porcentaje de facturas cobradas",
            "Companías con mayor cantidad de rendiciones",
            "Clientes con mayor porcentaje de facturas pagadas",
            "Clientes con mayor cantidad de pagos ejecutados"});
            this.cmbOptions.Location = new System.Drawing.Point(13, 30);
            this.cmbOptions.Name = "cmbOptions";
            this.cmbOptions.Size = new System.Drawing.Size(341, 21);
            this.cmbOptions.TabIndex = 1;
            // 
            // cmbTrimester
            // 
            this.cmbTrimester.FormattingEnabled = true;
            this.cmbTrimester.Items.AddRange(new object[] {
            "1er trimestre",
            "2do trimestre",
            "3er trimestre",
            "4to trimestre"});
            this.cmbTrimester.Location = new System.Drawing.Point(222, 57);
            this.cmbTrimester.Name = "cmbTrimester";
            this.cmbTrimester.Size = new System.Drawing.Size(132, 21);
            this.cmbTrimester.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año";
            // 
            // dtYear
            // 
            this.dtYear.Location = new System.Drawing.Point(45, 57);
            this.dtYear.Name = "dtYear";
            this.dtYear.Size = new System.Drawing.Size(111, 20);
            this.dtYear.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trimestre";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(13, 87);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(340, 35);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generar listado";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 133);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTrimester);
            this.Controls.Add(this.cmbOptions);
            this.Controls.Add(this.label1);
            this.Name = "ListForm";
            this.Text = "Listado estadistico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOptions;
        private System.Windows.Forms.ComboBox cmbTrimester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
    }
}