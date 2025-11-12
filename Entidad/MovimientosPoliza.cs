using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Gestor_de_Nomina.Entidad
{
    public class MovimientosPoliza
    {
        public int IdPoliza { get; set; }
        public string CuentaContable { get; set; }
        public string Concepto { get; set; }
        public Decimal Cargo { get; set; }
        public Decimal Abono { get; set; }

        public MovimientosPoliza() { }

        public MovimientosPoliza(int idPoliza, string cuentaContable, string concepto, Decimal cargo, Decimal abono)
        {
            this.IdPoliza = idPoliza;
            this.CuentaContable = cuentaContable;
            this.Concepto = concepto;
            this.Cargo = cargo;
            this.Abono = abono;
        }
    }
}
