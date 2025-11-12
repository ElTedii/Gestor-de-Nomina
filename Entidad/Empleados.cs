using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestor_de_Nomina.Entidad
{
    public class Empleados
    {
        public int IdEmpresa { get; set; }
        public string CodigoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string RFC {  get; set; }
        public string CURP { get; set; }
        public string NSS { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaBaja { get; set; }
        public Decimal SueldoDiario { get; set; }
        public Decimal SueldoIntegrado { get; set; }
        public int IdDepartamento { get; set; }
        public int IdPuesto { get; set; }
        public int IdBanco { get; set; }
        public string Clabe { get; set; }
        public string TipoContrato { get; set; }
        public bool AltaIMSS { get; set; }
        public bool BajaIMSS { get; set; }
        public bool CambioCotizacionIMSS { get; set; }
        public bool Activo {  get; set; }

        public Empleados() { }

        public Empleados(int IdEmpresa, string CodigoEmpleado, string Nombre, string ApellidoPaterno, string ApellidoMaterno, string RFC, string NSS, DateTime FechaNacimiento, DateTime FechaIngreso, DateTime FechaBaja, Decimal SueldoDiario, Decimal SueldoIntegrado, int IdDepartamento, int IdPuesto, int IdBanco, string Clabe, string TipoContrato, bool AltaIMSS, bool BajaIMSS, bool CambioCotizacionIMSS, bool Activo)
        {
            this.IdEmpresa = IdEmpresa;
            this.CodigoEmpleado = CodigoEmpleado;
            this.Nombre = Nombre;
            this.ApellidoPaterno = ApellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.RFC = RFC;
            this.NSS = NSS;
            this.FechaNacimiento = FechaNacimiento;
            this.FechaIngreso = FechaIngreso;
            this.FechaBaja = FechaBaja;
            this.SueldoDiario = SueldoDiario;
            this.SueldoIntegrado = SueldoIntegrado;
            this.IdDepartamento = IdDepartamento;
            this.IdPuesto = IdPuesto;
            this.IdBanco = IdBanco;
            this.Clabe = Clabe;
            this.TipoContrato = TipoContrato;
            this.AltaIMSS = AltaIMSS;
            this.BajaIMSS = BajaIMSS;
            this.Activo = Activo;
        }
    }
}
