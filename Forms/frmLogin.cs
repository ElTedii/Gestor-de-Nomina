using Gestor_de_Nomina.Entidad;
using Gestor_de_Nomina.Servicios;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;

            AuthServices auth = new AuthServices();
            Usuarios user = auth.Login(usuario, pass);

            if (user != null)
            {
                MessageBox.Show("Bienvenido " + user.NombreCompleto);

                //Abrir Pantalla Principal
                this.Hide();
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
