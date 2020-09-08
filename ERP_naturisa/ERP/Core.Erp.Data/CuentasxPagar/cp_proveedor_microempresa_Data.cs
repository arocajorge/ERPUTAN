using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_proveedor_microempresa_Data
    {
        public List<cp_proveedor_microempresa_Info> GetList()
        {
            try
            {
                List<cp_proveedor_microempresa_Info> Lista = new List<cp_proveedor_microempresa_Info>();


                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public cp_proveedor_microempresa_Info GetInfo(string Ruc)
        {
            try
            {
                cp_proveedor_microempresa_Info info = new cp_proveedor_microempresa_Info();

                string Conexion = ConexionERP.GetConnectionString();

                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();

                    string Query = "SELECT Ruc,Nombre FROM cp_proveedor_microempresa WHERE Ruc = '" + Ruc + "'";
                    SqlCommand command = new SqlCommand(Query, connection);
                    var returnValue = command.ExecuteScalar();
                    if (returnValue == null)
                        return null;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        info.Ruc = reader[0].ToString();
                        info.Nombre = reader[1].ToString();
                    }
                    reader.Close();
                }
                
                return info;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
