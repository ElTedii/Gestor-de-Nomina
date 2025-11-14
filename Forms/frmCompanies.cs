using Gestor_de_Nomina.DAO;
using Gestor_de_Nomina.Forms;
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
    public partial class frmCompanies : Form
    {
        public frmCompanies()
        {
            InitializeComponent();
        }

        private void frmCompanies_Load(object sender, EventArgs e)
        {
            dGEmpresas.DataSource = EmpresaDAO.ObtenerEmpresas();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            outCompany frm = new outCompany();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        private void refrescar()
        {

            dGEmpresas.DataSource = EmpresaDAO.ObtenerEmpresas();

        }
    }
}
