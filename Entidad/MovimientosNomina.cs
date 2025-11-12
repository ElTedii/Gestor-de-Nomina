using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Nomina.Entidad
{
    public class MovimientosNomina
    {
        public int IdPeriodo { get; set; }
        public int IdEmpleado { get; set; }
        public int IdConcepto { get; set; }
        public Decimal Importe { get; set; }
        public Decimal Valor { get; set; }
        public string TipoMovimiento { get; set; }
        public string Observaciones { get; set; }

        public MovimientosNomina () { }

        public MovimientosNomina (int idPeriodo, int idEmpleado, int idConcepto, Decimal importe, Decimal valor, string tipoMovimiento, string observaciones)
        {
            this.IdPeriodo = idPeriodo;
            this.IdEmpleado = idEmpleado;
            this.IdConcepto = idConcepto;
            this.Importe = importe;
            this.Valor = valor;
            this.TipoMovimiento = tipoMovimiento;
            this.Observaciones = observaciones;
        }
    }
}
