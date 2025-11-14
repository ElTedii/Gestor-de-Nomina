using Gestor_de_Nomina.Entidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Nomina.DAO
{
    public class EmpresaDAO
    {
        public static List<Empresa> ObtenerEmpresas()
        {
            List<Empresa> lista = new List<Empresa>();

            using (SqlConnection conexion = BDConexion.GetConexion())
            {
                conexion.Open();
                string query = "SELECT * FROM Empresas;";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Empresa empresa = new Empresa();
                    empresa.IdEmpresa = reader.GetInt32(0);
                    empresa.NombreFiscal = reader.GetString(1);
                    empresa.RFC = reader.GetString(2);
                    empresa.RegistroIMSS = reader.GetString(3);
                    empresa.RegistroInfonavit = reader.GetString(4);
                    empresa.RegimenFiscal = reader.GetString(5);
                    empresa.ClaveCFDI = reader.GetString(6);
                    empresa.EmitirRecibo = reader.GetBoolean(7);
                    empresa.GUIDEmpresa = reader.GetGuid(8);
                    empresa.FechaCreacion = reader.GetDateTime(9);

                    lista.Add(empresa);

                }
                return lista;
            }
        }

        public static bool Insertar(Empresa emp)
        {
            using (SqlConnection conexion = BDConexion.GetConexion())
            {
                conexion.Open();

                string query = @"INSERT INTO Empresas 
                        (NombreFiscal, RFC, RegistroIMSS, RegistroInfonavit, RegimenFiscal, 
                         ClaveCFDI, EmitirRecibo, GUIDEmpresa)
                         VALUES
                        (@NombreFiscal, @RFC, @RegistroIMSS, @RegistroInfonavit, @RegimenFiscal,
                         @ClaveCFDI, @EmitirRecibo, NEWID());";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@NombreFiscal", emp.NombreFiscal);
                cmd.Parameters.AddWithValue("@RFC", (object)emp.RFC ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RegistroIMSS", (object)emp.RegistroIMSS ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RegistroInfonavit", (object)emp.RegistroInfonavit ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RegimenFiscal", (object)emp.RegimenFiscal ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ClaveCFDI", (object)emp.ClaveCFDI ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EmitirRecibo", emp.EmitirRecibo);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool Actualizar(Empresa emp)
        {
            using (SqlConnection conexion = BDConexion.GetConexion())
            {
                conexion.Open();

                string query = @"UPDATE Empresas SET 
                         NombreFiscal = @NombreFiscal,
                         RFC = @RFC,
                         RegistroIMSS = @RegistroIMSS,
                         RegistroInfonavit = @RegistroInfonavit,
                         RegimenFiscal = @RegimenFiscal,
                         ClaveCFDI = @ClaveCFDI,
                         EmitirRecibo = @EmitirRecibo
                         WHERE IdEmpresa = @IdEmpresa;";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@NombreFiscal", emp.NombreFiscal);
                cmd.Parameters.AddWithValue("@RFC", (object)emp.RFC ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RegistroIMSS", (object)emp.RegistroIMSS ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RegistroInfonavit", (object)emp.RegistroInfonavit ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RegimenFiscal", (object)emp.RegimenFiscal ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ClaveCFDI", (object)emp.ClaveCFDI ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EmitirRecibo", emp.EmitirRecibo);
                cmd.Parameters.AddWithValue("@IdEmpresa", emp.IdEmpresa);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool Eliminar(int idEmpresa)
        {
            using (SqlConnection conexion = BDConexion.GetConexion())
            {
                conexion.Open();

                string query = "DELETE FROM Empresas WHERE IdEmpresa = @IdEmpresa";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdEmpresa", idEmpresa);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static Empresa ObtenerPorId(int id)
        {
            using (SqlConnection conexion = BDConexion.GetConexion())
            {
                conexion.Open();

                string query = "SELECT * FROM Empresas WHERE IdEmpresa = @Id";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Empresa
                    {
                        IdEmpresa = reader.GetInt32(0),
                        NombreFiscal = reader.GetString(1),
                        RFC = reader.IsDBNull(2) ? null : reader.GetString(2),
                        RegistroIMSS = reader.IsDBNull(3) ? null : reader.GetString(3),
                        RegistroInfonavit = reader.IsDBNull(4) ? null : reader.GetString(4),
                        RegimenFiscal = reader.IsDBNull(5) ? null : reader.GetString(5),
                        ClaveCFDI = reader.IsDBNull(6) ? null : reader.GetString(6),
                        EmitirRecibo = reader.GetBoolean(7),
                        GUIDEmpresa = reader.GetGuid(8),
                        FechaCreacion = reader.GetDateTime(9)
                    };
                }

                return null;
            }
        }

    }
}
