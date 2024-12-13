namespace Pro_Veterinaria.Indormes
{
    partial class frmRreceta
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
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chTodo = new System.Windows.Forms.CheckBox();
            this.rvReceta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(262, 47);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(263, 24);
            this.cbEstado.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(531, 43);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 36);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chTodo
            // 
            this.chTodo.AutoSize = true;
            this.chTodo.Location = new System.Drawing.Point(153, 41);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(62, 20);
            this.chTodo.TabIndex = 9;
            this.chTodo.Text = "Todo";
            this.chTodo.UseVisualStyleBackColor = true;
            // 
            // rvReceta
            // 
            this.rvReceta.LocalReport.ReportEmbeddedResource = "Pro_Veterinaria.Indormes.Report1.rdlc";
            this.rvReceta.Location = new System.Drawing.Point(31, 154);
            this.rvReceta.Name = "rvReceta";
            this.rvReceta.ServerReport.BearerToken = null;
            this.rvReceta.Size = new System.Drawing.Size(988, 255);
            this.rvReceta.TabIndex = 8;
            // 
            // frmRreceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chTodo);
            this.Controls.Add(this.rvReceta);
            this.Name = "frmRreceta";
            this.Text = "frmRreceta";
            this.Load += new System.EventHandler(this.frmRreceta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chTodo;
        public Microsoft.Reporting.WinForms.ReportViewer rvReceta;
    }
}