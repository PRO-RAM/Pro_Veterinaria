using Pro_Veterinaria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Veterinaria.Busquedas
{
    public partial class frmBusquedaReceta : Form
    {
        ConexionSQL x = new ConexionSQL();  
        public frmBusquedaReceta()
        {
            InitializeComponent();
            this.recetaTableAdapter.Connection.ConnectionString = x.Conexion;
            this.rect_detTableAdapter.Connection.ConnectionString = x.Conexion;
        }
        private void cargardetalle(int id)
        {
            this.rect_detTableAdapter.Fill(this.dsvRceta_Detalle.Rect_det, id);

        }

        private void frmBusquedaReceta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsvRceta_Detalle.Rect_det' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'el_sasaDataSet.Receta' Puede moverla o quitarla según sea necesario.
            this.recetaTableAdapter.Fill(this.el_sasaDataSet.Receta);

        }

        private void dgRceta_SelectionChanged(object sender, EventArgs e)
        {
            cargardetalle(el_sasaDataSet.Receta[recetaBindingSource.Position].id);
        }
    }
}
