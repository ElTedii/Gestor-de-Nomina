using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Nomina
{
    public partial class frmCFDI : Form
    {
        public frmCFDI()
        {
            InitializeComponent();
        }

        private void btnTimb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timbrado simulado: UUID guardado");
        }
    }
}
