using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Nomina.Entidad
{
    public class ParametrosSistema
    {
        public string Clave { get; set; }
        public string Valor { get; set; }
        public string Descripcion {  get; set; }
        public DateTime FechaModificacion {  get; set; }

        public ParametrosSistema () { }

        public ParametrosSistema (string Clave, string Valor, string Descripcion, DateTime FechaModificacion)
        {
            this.Clave = Clave;
            this.Valor = Valor;
            this.Descripcion = Descripcion;
            this.FechaModificacion = FechaModificacion;
        }
    }
}
