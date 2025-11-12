using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Nomina.Entidad
{
    public class Bancos
    {
        public string Nombre {  get; set; }
        public string Clave { get; set; }
        public bool Activo { get; set; }

        public Bancos () { }

        public Bancos(string Nombre, string Clave, bool Activo) 
        { 
            this.Nombre = Nombre;
            this.Clave = Clave;
            this.Activo = Activo;
        }
    }
}
