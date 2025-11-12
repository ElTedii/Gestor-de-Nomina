using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestor_de_Nomina.Entidad
{
    public class AvisosINFONAVIT
    {
        public int IdEmpleado { get; set; }
        public string NumeroCredito { get; set; }
        public string TipoAviso { get; set; } // Alta / Modificación / Suspensión
        public DateTime FechaInicioDescuento { get; set; }
        public Decimal PorcentajeDescuento { get; set; }
        public Decimal MontoDescuento { get; set; }
        public bool Procesado { get; set; }

        public AvisosINFONAVIT () { }

        public AvisosINFONAVIT (int idEmpleado, string numeroCredito, string tipoAviso, DateTime fechaInicioDescuento, Decimal porcentajeDescuento, Decimal montoDescuento, bool procesado)
        {
            this.IdEmpleado = idEmpleado;
            this.NumeroCredito = numeroCredito;
            this.TipoAviso = tipoAviso;
            this.FechaInicioDescuento = fechaInicioDescuento;
            this.PorcentajeDescuento = porcentajeDescuento;
            this.MontoDescuento = montoDescuento;
            this.Procesado = procesado;
        }
    }
}
