using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Veterinaria.Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipo x = new frmTipo();
            x.Show();
            this.Hide();
        }
    }
}
