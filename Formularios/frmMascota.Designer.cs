﻿namespace Pro_Veterinaria.Formularios
{
    partial class frmMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMascota));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cbDomicilio = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Blue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGuardar,
            this.tsBuscar,
            this.tsLimpiar,
            this.tsEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(904, 39);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsGuardar
            // 
            this.tsGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsGuardar.Image")));
            this.tsGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGuardar.Name = "tsGuardar";
            this.tsGuardar.Size = new System.Drawing.Size(36, 36);
            this.tsGuardar.Text = "Guardar";
            this.tsGuardar.Click += new System.EventHandler(this.tsGuardar_Click);
            // 
            // tsBuscar
            // 
            this.tsBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsBuscar.Image")));
            this.tsBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBuscar.Name = "tsBuscar";
            this.tsBuscar.Size = new System.Drawing.Size(36, 36);
            this.tsBuscar.Text = "Buscar";
            // 
            // tsLimpiar
            // 
            this.tsLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tsLimpiar.Image")));
            this.tsLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLimpiar.Name = "tsLimpiar";
            this.tsLimpiar.Size = new System.Drawing.Size(36, 36);
            this.tsLimpiar.Text = "Limpiar";
            this.tsLimpiar.Click += new System.EventHandler(this.tsLimpiar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminar.Image")));
            this.tsEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(36, 36);
            this.tsEliminar.Text = "Eliminar";
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Domicilio";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(650, 53);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(184, 40);
            this.dtpFecha.TabIndex = 17;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(328, 86);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(275, 35);
            this.txtId.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(328, 144);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 35);
            this.txtNombre.TabIndex = 19;
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(328, 268);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(275, 35);
            this.txtAPaterno.TabIndex = 20;
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(328, 211);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(275, 35);
            this.txtAMaterno.TabIndex = 21;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(328, 396);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(275, 35);
            this.txtCorreo.TabIndex = 22;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(329, 463);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(274, 35);
            this.txtTelefono.TabIndex = 23;
            // 
            // cbDomicilio
            // 
            this.cbDomicilio.FormattingEnabled = true;
            this.cbDomicilio.Location = new System.Drawing.Point(326, 333);
            this.cbDomicilio.Name = "cbDomicilio";
            this.cbDomicilio.Size = new System.Drawing.Size(278, 36);
            this.cbDomicilio.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(325, 523);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(279, 47);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(904, 684);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbDomicilio);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.txtAPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMascota";
            this.Text = "frmMascota";
            this.Load += new System.EventHandler(this.frmMascota_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsGuardar;
        private System.Windows.Forms.ToolStripButton tsBuscar;
        private System.Windows.Forms.ToolStripButton tsLimpiar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cbDomicilio;
        private System.Windows.Forms.Button btnBuscar;
    }
}