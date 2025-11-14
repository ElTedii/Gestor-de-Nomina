using Gestor_de_Nomina.DAO;
using Gestor_de_Nomina.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Nomina.Forms
{
    public partial class outCompany : Form
    {
        public outCompany()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();

            empresa.NombreFiscal = txtNombre.Text;
            empresa.RFC = txtRFC.Text;
            empresa.RegimenFiscal = txtRegFis.Text;
            empresa.RegistroIMSS = txtRegIMSS.Text;
            empresa.RegistroInfonavit = txtRegINFO.Text;
            empresa.ClaveCFDI = txtCFDI.Text;

            if (chkregEmitir.Checked)
                empresa.EmitirRecibo = true;
            else
                empresa.EmitirRecibo = false;

            EmpresaDAO.Insertar(empresa);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
