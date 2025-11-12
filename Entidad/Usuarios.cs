using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Nomina.Entidad
{
    public class Usuarios
    {
        public string Usuario { get; set; }
        public string NombreCompleto { get; set; }
        public string PasswordHash { get; set; }
        public string Rol { get; set; }
        public bool Activo {  get; set; }

        public Usuarios() { }

        public Usuarios(string usuario, string nombreCompleto, string passwordHash, string rol, bool activo)
        {
            this.Usuario = usuario;
            this.NombreCompleto = nombreCompleto;
            this.PasswordHash = passwordHash;
            this.Rol = rol;
            this.Activo = activo;
        }
    }
}
