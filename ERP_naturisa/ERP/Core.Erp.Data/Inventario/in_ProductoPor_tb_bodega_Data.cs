using Core.Erp.Info.Inventario;
using FastMember;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Inventario
{
    public class in_ProductoPor_tb_bodega_Data
    {
        public List<in_ProductoPor_tb_bodega_Info> GetList(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                List<in_ProductoPor_tb_bodega_Info> Lista = new List<in_ProductoPor_tb_bodega_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT [IdEmpresa],[IdSucursal],[IdBodega],[IdProducto] FROM [dbo].[in_ProductoPor_tb_bodega] where [IdEmpresa] = " + IdEmpresa.ToString() + " and IdSucursal = " + IdSucursal.ToString() + " and IdBodega = "+IdBodega.ToString();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new in_ProductoPor_tb_bodega_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdBodega = Convert.ToInt32(reader["IdBodega"]),
                            IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                        });
                    }
                    reader.Close();
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(int IdEmpresa, int IdSucursal, int IdBodega, List<in_ProductoPor_tb_bodega_Info> Lista)
        {
            try
            {
                using (SqlConnection sourceConnection =
                    new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    sourceConnection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = sourceConnection;
                    command.CommandText = "DELETE in_ProductoPor_tb_bodega WHERE [IdEmpresa] = " + IdEmpresa.ToString() + " and IdSucursal = " + IdSucursal.ToString() + " and IdBodega = " + IdBodega.ToString();
                    Console.WriteLine("Inserting asset reciving to database....");
                    using (var bcp = new SqlBulkCopy(ConexionERP.GetConnectionString()))
                    {
                        using (var reader = ObjectReader.Create(Lista, "IdEmpresa","IdSucursal","IdBodega","IdProducto"))
                        {
                            #region Column mapping
                            bcp.ColumnMappings.Add("IdEmpresa", "IdEmpresa");
                            bcp.ColumnMappings.Add("IdSucursal", "IdSucursal");
                            bcp.ColumnMappings.Add("IdBodega", "IdBodega");
                            bcp.ColumnMappings.Add("IdProducto", "IdProducto");
                            #endregion
                            bcp.BulkCopyTimeout = 3000;
                            bcp.DestinationTableName = "in_ProductoPor_tb_bodega";
                            bcp.WriteToServer(reader);
                        }
                    }

                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
