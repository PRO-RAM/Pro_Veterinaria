namespace Pro_Veterinaria.Busquedas
{
    partial class frmBusquedaReceta
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
            this.components = new System.ComponentModel.Container();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.dgRceta = new System.Windows.Forms.DataGridView();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.el_sasaDataSet = new Pro_Veterinaria.El_sasaDataSet();
            this.recetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetaTableAdapter = new Pro_Veterinaria.El_sasaDataSetTableAdapters.RecetaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dianosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsvRceta_Detalle = new Pro_Veterinaria.dsvRceta_Detalle();
            this.rectdetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rect_detTableAdapter = new Pro_Veterinaria.dsvRceta_DetalleTableAdapters.Rect_detTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRecetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_sasaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvRceta_Detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectdetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.AllowUserToDeleteRows = false;
            this.dgDetalle.AutoGenerateColumns = false;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idRecetaDataGridViewTextBoxColumn,
            this.idProductosDataGridViewTextBoxColumn,
            this.canproDataGridViewTextBoxColumn,
            this.preproDataGridViewTextBoxColumn});
            this.dgDetalle.DataSource = this.rectdetBindingSource;
            this.dgDetalle.Location = new System.Drawing.Point(58, 297);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.ReadOnly = true;
            this.dgDetalle.RowHeadersWidth = 51;
            this.dgDetalle.RowTemplate.Height = 24;
            this.dgDetalle.Size = new System.Drawing.Size(976, 210);
            this.dgDetalle.TabIndex = 1;
            // 
            // dgRceta
            // 
            this.dgRceta.AllowUserToAddRows = false;
            this.dgRceta.AllowUserToDeleteRows = false;
            this.dgRceta.AutoGenerateColumns = false;
            this.dgRceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dianosticoDataGridViewTextBoxColumn,
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.mascotaDataGridViewTextBoxColumn,
            this.idServicioDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgRceta.DataSource = this.recetaBindingSource;
            this.dgRceta.Location = new System.Drawing.Point(58, 42);
            this.dgRceta.Name = "dgRceta";
            this.dgRceta.ReadOnly = true;
            this.dgRceta.RowHeadersWidth = 51;
            this.dgRceta.Size = new System.Drawing.Size(976, 210);
            this.dgRceta.TabIndex = 2;
            this.dgRceta.SelectionChanged += new System.EventHandler(this.dgRceta_SelectionChanged);
            // 
            // bntCancelar
            // 
            this.bntCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bntCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCancelar.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelar.ForeColor = System.Drawing.Color.White;
            this.bntCancelar.Location = new System.Drawing.Point(585, 604);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(228, 48);
            this.bntCancelar.TabIndex = 67;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(250, 604);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(228, 48);
            this.btnAceptar.TabIndex = 66;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // el_sasaDataSet
            // 
            this.el_sasaDataSet.DataSetName = "El_sasaDataSet";
            this.el_sasaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recetaBindingSource
            // 
            this.recetaBindingSource.DataMember = "Receta";
            this.recetaBindingSource.DataSource = this.el_sasaDataSet;
            // 
            // recetaTableAdapter
            // 
            this.recetaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dianosticoDataGridViewTextBoxColumn
            // 
            this.dianosticoDataGridViewTextBoxColumn.DataPropertyName = "Dianostico";
            this.dianosticoDataGridViewTextBoxColumn.HeaderText = "Dianostico";
            this.dianosticoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dianosticoDataGridViewTextBoxColumn.Name = "dianosticoDataGridViewTextBoxColumn";
            this.dianosticoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dianosticoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmpleadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // mascotaDataGridViewTextBoxColumn
            // 
            this.mascotaDataGridViewTextBoxColumn.DataPropertyName = "Mascota";
            this.mascotaDataGridViewTextBoxColumn.HeaderText = "Mascota";
            this.mascotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mascotaDataGridViewTextBoxColumn.Name = "mascotaDataGridViewTextBoxColumn";
            this.mascotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.mascotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idServicioDataGridViewTextBoxColumn
            // 
            this.idServicioDataGridViewTextBoxColumn.DataPropertyName = "idServicio";
            this.idServicioDataGridViewTextBoxColumn.HeaderText = "idServicio";
            this.idServicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idServicioDataGridViewTextBoxColumn.Name = "idServicioDataGridViewTextBoxColumn";
            this.idServicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idServicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // dsvRceta_Detalle
            // 
            this.dsvRceta_Detalle.DataSetName = "dsvRceta_Detalle";
            this.dsvRceta_Detalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rectdetBindingSource
            // 
            this.rectdetBindingSource.DataMember = "Rect_det";
            this.rectdetBindingSource.DataSource = this.dsvRceta_Detalle;
            // 
            // rect_detTableAdapter
            // 
            this.rect_detTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idRecetaDataGridViewTextBoxColumn
            // 
            this.idRecetaDataGridViewTextBoxColumn.DataPropertyName = "idReceta";
            this.idRecetaDataGridViewTextBoxColumn.HeaderText = "idReceta";
            this.idRecetaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRecetaDataGridViewTextBoxColumn.Name = "idRecetaDataGridViewTextBoxColumn";
            this.idRecetaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRecetaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idProductosDataGridViewTextBoxColumn
            // 
            this.idProductosDataGridViewTextBoxColumn.DataPropertyName = "idProductos";
            this.idProductosDataGridViewTextBoxColumn.HeaderText = "idProductos";
            this.idProductosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProductosDataGridViewTextBoxColumn.Name = "idProductosDataGridViewTextBoxColumn";
            this.idProductosDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductosDataGridViewTextBoxColumn.Width = 125;
            // 
            // canproDataGridViewTextBoxColumn
            // 
            this.canproDataGridViewTextBoxColumn.DataPropertyName = "Can_pro";
            this.canproDataGridViewTextBoxColumn.HeaderText = "Can_pro";
            this.canproDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.canproDataGridViewTextBoxColumn.Name = "canproDataGridViewTextBoxColumn";
            this.canproDataGridViewTextBoxColumn.ReadOnly = true;
            this.canproDataGridViewTextBoxColumn.Width = 125;
            // 
            // preproDataGridViewTextBoxColumn
            // 
            this.preproDataGridViewTextBoxColumn.DataPropertyName = "Pre_pro";
            this.preproDataGridViewTextBoxColumn.HeaderText = "Pre_pro";
            this.preproDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preproDataGridViewTextBoxColumn.Name = "preproDataGridViewTextBoxColumn";
            this.preproDataGridViewTextBoxColumn.ReadOnly = true;
            this.preproDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmBusquedaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 694);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgRceta);
            this.Controls.Add(this.dgDetalle);
            this.Name = "frmBusquedaReceta";
            this.Text = "frmBusquedaReceta";
            this.Load += new System.EventHandler(this.frmBusquedaReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_sasaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvRceta_Detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectdetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgDetalle;
        public System.Windows.Forms.DataGridView dgRceta;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button btnAceptar;
        public El_sasaDataSet el_sasaDataSet;
        public System.Windows.Forms.BindingSource recetaBindingSource;
        public El_sasaDataSetTableAdapters.RecetaTableAdapter recetaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dianosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        public dsvRceta_Detalle dsvRceta_Detalle;
        public System.Windows.Forms.BindingSource rectdetBindingSource;
        public dsvRceta_DetalleTableAdapters.Rect_detTableAdapter rect_detTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canproDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preproDataGridViewTextBoxColumn;
    }
}