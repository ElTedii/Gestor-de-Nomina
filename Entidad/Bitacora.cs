using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gestor_de_Nomina.Entidad
{
    public class Bitacora
    {
        public int IdUsuario { get; set; }
        public string Entidad { get; set; }
        public string IdEntidad {  get; set; }
        public string Accion {  get; set; }
        public string Detalle { get; set; }

        public Bitacora() { }

        public Bitacora(int idUsuario, string entidad, string idEntidad, string accion, string detalle)
        {
            this.IdUsuario = idUsuario;
            this.Entidad = entidad;
            this.IdEntidad = idEntidad;
            this.Accion = accion;
            this.Detalle = detalle;
        }
    }
}
