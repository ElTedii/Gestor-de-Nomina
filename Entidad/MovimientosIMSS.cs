using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestor_de_Nomina.Entidad
{
    public class MovimientosIMSS
    {
        public int IdEmpleado { get; set; }
        public string TipoMovimiento { get; set; } // Alta / Baja / CambioSalario / CambioContrato
        public DateTime FechaMovimiento { get; set; }
        public Decimal SalarioBaseCotizacion { get; set; }
        public string ArchivoGenerado { get; set; }
        public bool Procesado {  get; set; }
        public string Observaciones { get; set; }

        public MovimientosIMSS() { }

        public MovimientosIMSS(int idEmpleado, string tipoMovimiento, DateTime fechaMovimiento, Decimal salarioBaseCotizacion, string archivoGenerado, bool procesado, string observaciones)
        {
            this.IdEmpleado = idEmpleado;
            this.TipoMovimiento = tipoMovimiento;
            this.FechaMovimiento = fechaMovimiento;
            this.SalarioBaseCotizacion = salarioBaseCotizacion;
            this.ArchivoGenerado = archivoGenerado;
            this.Procesado = procesado;
            this.Observaciones = observaciones;
        }
    }
}
