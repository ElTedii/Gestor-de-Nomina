using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Nomina.Entidad
{
    internal class PolizasContables
    {
        public int IdPeriodo { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal TotalCargos { get; set; }
        public Decimal TotalAbonos { get; set; }
        public string Descripcion { get; set; }
        public bool Exportada { get; set; }

        public PolizasContables() { }

        public PolizasContables(int idPeriodo, string tipo, DateTime fecha, Decimal totalCargos, Decimal totalAbonos, string descripcion, bool exportada)
        {
            this.IdPeriodo = idPeriodo;
            this.Tipo = tipo;
            this.Fecha = fecha;
            this.TotalCargos = totalCargos;
            this.TotalAbonos = totalAbonos;
            this.Descripcion = descripcion;
            this.Exportada = exportada;
        }
    }
}
