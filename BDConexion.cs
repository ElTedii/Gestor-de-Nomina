using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Gestor_de_Nomina
{
    public class BDConexion
    {
        private static string conexion = "Server=TEDSS-PC\\SQLEXPRESS; Database=Prueba1; Integrated Security=true; TrustServerCertificate=True;";

        public static SqlConnection GetConexion()
        {
            return new SqlConnection(conexion);
        }
    }
}
