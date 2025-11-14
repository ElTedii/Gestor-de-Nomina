using Gestor_de_Nomina.Entidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gestor_de_Nomina.DAO
{
    public class UsuariosDAO
    {
        public Usuarios ObtenerPorUsuario(string usuario)
        {
            using (SqlConnection cn = BDConexion.GetConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Usuarios WHERE Usuario = @Usuario AND Activo = 1", cn);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new Usuarios
                    {
                        Usuario = dr["Usuario"].ToString(),
                        NombreCompleto = dr["NombreCompleto"].ToString(),
                        PasswordHash = dr["PasswordHash"].ToString(),
                        Rol = dr["Rol"].ToString(),
                        Activo = Convert.ToBoolean(dr["Activo"])
                    };
                }
            }

            return null;
        }

    }
}
