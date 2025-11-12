using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Nomina.Entidad
{
    public class RecibosTimbrados
    {
        public int IdPeriodo { get; set; }
        public int IdEmpleado { get; set; }
        public string Folio { get; set; }
        public string UUID { get; set; }
        public DateTime FechaEmision { get; set; }
        public Decimal TotalPercepciones { get; set; }
        public Decimal TotalDeducciones { get; set; }
        public Decimal NetoPagar { get; set; }
        public bool Emitido {  get; set; }
        public bool Cancelado { get; set; }
        public string Metadatos { get; set; } //XML

        public RecibosTimbrados (int idPeriodo, int idEmpleado, string folio, string uUID, DateTime fechaEmision, Decimal totalPercepciones, Decimal totalDeducciones, Decimal netoPagar, bool emitido, bool cancelado, string metadatos)
        {
            this.IdPeriodo = idPeriodo;
            this.IdEmpleado = idEmpleado;
            this.Folio = folio;
            this.UUID = uUID;
            this.FechaEmision = fechaEmision;
            this.TotalPercepciones = totalPercepciones;
            this.TotalDeducciones = totalDeducciones;
            this.NetoPagar = netoPagar;
            this.Emitido = emitido;
            this.Cancelado = cancelado;
            this.Metadatos = metadatos;
        }
    }
}
