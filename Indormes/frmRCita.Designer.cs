namespace Pro_Veterinaria.Indormes
{
    partial class frmRCita
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
            this.rvCita = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chTodo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rvCita
            // 
            this.rvCita.LocalReport.ReportEmbeddedResource = "Pro_Veterinaria.Indormes.rCita.rdlc";
            this.rvCita.Location = new System.Drawing.Point(37, 184);
            this.rvCita.Name = "rvCita";
            this.rvCita.ServerReport.BearerToken = null;
            this.rvCita.Size = new System.Drawing.Size(738, 255);
            this.rvCita.TabIndex = 0;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(268, 77);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(263, 24);
            this.cbEstado.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(537, 73);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 36);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chTodo
            // 
            this.chTodo.AutoSize = true;
            this.chTodo.Location = new System.Drawing.Point(159, 71);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(62, 20);
            this.chTodo.TabIndex = 5;
            this.chTodo.Text = "Todo";
            this.chTodo.UseVisualStyleBackColor = true;
            // 
            // frmRCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chTodo);
            this.Controls.Add(this.rvCita);
            this.Name = "frmRCita";
            this.Text = "frmRCita";
            this.Load += new System.EventHandler(this.frmRCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rvCita;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chTodo;
    }
}