using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Nomina.Entidad
{
    public class ConceptosNomina
    {
        public int IdEmpresa { get; set; }
        public string Numero { get; set; }
        public char Tipo { get; set; } //P = Percepción, D = Deducción, O = Obligación
        public string Descripcion { get; set; }
        public string Formula { get; set; } //expresión o nota de cálculo
        public string TipoClaveSAT { get; set; }
        public string CuentaContable { get; set; }
        public string Activo { get; set; }

        public ConceptosNomina() { }

        public ConceptosNomina (int idEmpresa, string numero, char tipo, string descripcion, string formula, string tipoClaveSAT, string cuentaContable, string activo)
        {
            this.IdEmpresa = idEmpresa;
            this.Numero = numero;
            this.Tipo = tipo;
            this.Descripcion = descripcion;
            this.Formula = formula;
            this.TipoClaveSAT = tipoClaveSAT;
            this.CuentaContable = cuentaContable;
            this.Activo = activo;
        }
    }
}
