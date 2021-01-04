using Core.Erp.Info.Contabilidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_DistribucionDetDistribuido_Data
    {
        public List<ct_DistribucionDetDistribuido_Info> GetList(int IdEmpresa, decimal IdDistribucion)
        {
            List<ct_DistribucionDetDistribuido_Info> Lista = new List<ct_DistribucionDetDistribuido_Info>();

            using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select IdEmpresa,IdDistribucion,Secuencia,IdCtaCble,IdCentroCosto_sub_centro_costo,IdCentroCosto,F1,F2,IdCentroCosto +'-'+ IdCentroCosto_sub_centro_costo IdRegistro "                                    +" from [dbo].[ct_DistribucionDetDistribuido]"
                                    +" where IdEmpresa = "+IdEmpresa.ToString()+" and IdDistribucion = "+IdDistribucion.ToString();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Lista.Add(new ct_DistribucionDetDistribuido_Info
                    {
                        IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                        IdDistribucion = Convert.ToDecimal(reader["IdDistribucion"]),
                        Secuencia = Convert.ToInt32(reader["Secuencia"]),
                        IdCtaCble = Convert.ToString(reader["IdCtaCble"]),
                        IdCentroCosto_sub_centro_costo = reader["IdCentroCosto_sub_centro_costo"] == DBNull.Value ? null : Convert.ToString(reader["IdCentroCosto_sub_centro_costo"]),
                        IdCentroCosto = reader["IdCentroCosto"] == DBNull.Value ? null : Convert.ToString(reader["IdCentroCosto"]),
                        F1 = Convert.ToDecimal(reader["F1"]),
                        F2 = Convert.ToDecimal(reader["F2"]),
                        IdRegistro = reader["IdRegistro"] == DBNull.Value ? null : Convert.ToString(reader["IdRegistro"])
                    });
                }
                reader.Close();
            }

            return Lista;
        }
    }
}
