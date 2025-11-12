using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestor_de_Nomina.Entidad
{
    public class Departamentos
    {
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Responsable { get; set; }

        public Departamentos () { }

        public Departamentos(int IdEmpresa, string Nombre, string Responsable)
        {
            this.IdEmpresa = IdEmpresa;
            this.Nombre = Nombre;
            this.Responsable = Responsable;
        }
    }
}
