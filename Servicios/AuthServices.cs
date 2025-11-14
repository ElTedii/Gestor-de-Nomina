using Gestor_de_Nomina.DAO;
using Gestor_de_Nomina.Entidad;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Nomina.Servicios
{
    public class AuthServices
    {
        private UsuariosDAO usuariosDAO = new UsuariosDAO();

        public Usuarios Login(string username, string password)
        {
            Usuarios usuarios = usuariosDAO.ObtenerPorUsuario(username);
            if (usuarios == null)
                return null;

            // Generar hash del password ingresado
            string passwordIngresadoHash = GenerarSHA256(password);

            // Comparar con el hash guardado
            if (password == usuarios.PasswordHash)
                return usuarios;

            return null;
        }

        public string GenerarSHA256(string texto)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256.Create())
            {
                byte[] result = hash.ComputeHash(Encoding.UTF8.GetBytes(texto));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
