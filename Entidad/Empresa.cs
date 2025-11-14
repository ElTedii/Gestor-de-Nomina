using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Nomina.Entidad
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string NombreFiscal { get; set; }
        public string RFC { get; set; }
        public string RegistroIMSS { get; set; }
        public string RegistroInfonavit { get; set; }
        public string RegimenFiscal { get; set; }
        public string ClaveCFDI { get; set; }
        public bool EmitirRecibo { get; set; }
        public Guid GUIDEmpresa { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Empresa() { }

        public Empresa(string nombreFiscal, string rfc, string registroIMSS, string registroInfonavit, string regimenFiscal, string claveCFDI, bool emitirRecibo, Guid guidEmpresa)
        {
            NombreFiscal = nombreFiscal;
            RFC = rfc;
            RegistroIMSS = registroIMSS;
            RegistroInfonavit = registroInfonavit;
            RegimenFiscal = regimenFiscal;
            ClaveCFDI = claveCFDI;
            EmitirRecibo = emitirRecibo;
            GUIDEmpresa = guidEmpresa;
        }
    }

}
