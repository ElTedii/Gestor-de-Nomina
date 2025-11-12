using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Nomina.Entidad
{
    public class Periodo
    {
        public int Anio { get; set; }
        public int Mes {  get; set; }
        public int NumeroPeriodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }
        public int DiasPago { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Calculado { get; set; }
        public bool Afectado {  get; set; }

        public Periodo() { }

        public Periodo(int anio, int mes, int numeroPeriodo, DateTime fechaInicio, DateTime fechaFin, int diasPago, DateTime fechaPago, bool calculado, bool afectado)
        {
            this.Anio = anio;
            this.Mes = mes;
            this.NumeroPeriodo = numeroPeriodo;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.DiasPago = diasPago;
            this.FechaPago = fechaPago;
            this.Calculado = calculado;
            this.Afectado = afectado;
        }
    }
}
