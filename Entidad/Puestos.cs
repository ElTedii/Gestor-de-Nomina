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
    public class Puestos
    {
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Nivel { get; set; }
        public Decimal SueldoBase { get; set; }

        public Puestos() { }

        public Puestos (int IdEmpresa, string Nombre, string Nivel, Decimal SueldoBase)
        {
            this.IdEmpresa = IdEmpresa;
            this.Nombre = Nombre;
            this.Nivel = Nivel;
            this.SueldoBase = SueldoBase;
        }
    }
}
