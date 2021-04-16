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
        public List<in_ProductoPor_tb_bodega_Info> GetList(int IdEmpresa, int IdSucursal, int IdBodega, bool MostrarNoAsignados)
        {
            try
            {
                List<in_ProductoPor_tb_bodega_Info> Lista = new List<in_ProductoPor_tb_bodega_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select a.IdEmpresa,a.IdSucursal, a.IdBodega, a.IdProducto, b.pr_descripcion, c.ca_Categoria, d.nom_linea, e.nom_grupo, f.fa_Descripcion"
                                        + " from in_ProductoPor_tb_bodega as a join"
                                        + " in_producto as b on a.idempresa = b.idempresa and a.idproducto = b.IdProducto join"
                                        + " in_categorias as c on b.IdEmpresa = c.IdEmpresa and b.IdCategoria = c.IdCategoria join"
                                        + " in_linea as d on b.IdEmpresa = d.IdEmpresa and b.IdCategoria = d.IdCategoria and b.IdLinea = d.IdLinea join"
                                        + " in_grupo as e on b.IdEmpresa = e.IdEmpresa and b.IdCategoria = e.IdCategoria and b.IdGrupo = e.IdGrupo and b.IdLinea  = e.IdLinea left join"
                                        + " in_Familia as f on b.IdEmpresa = f.IdEmpresa and b.IdFamilia = f.IdFamilia"
                                        + " where b.Estado = 'A' and a.[IdEmpresa] = " + IdEmpresa.ToString() + " and a.IdSucursal = " + IdSucursal.ToString() + " and a.IdBodega = " + IdBodega.ToString();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new in_ProductoPor_tb_bodega_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdBodega = Convert.ToInt32(reader["IdBodega"]),
                            IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                            pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                            ca_Categoria = Convert.ToString(reader["ca_Categoria"]),
                            nom_linea = Convert.ToString(reader["nom_linea"]),
                            nom_grupo = Convert.ToString(reader["nom_grupo"]),
                            fa_Descripcion = Convert.ToString(reader["fa_Descripcion"]),
                            Seleccionado = true
                        });
                    }
                    reader.Close();
                    if (MostrarNoAsignados)
                    {
                        command.CommandText = "select b.IdEmpresa, b.IdProducto, b.pr_descripcion, c.ca_Categoria, d.nom_linea, e.nom_grupo, f.fa_Descripcion"
                                            +" from in_producto as b join"
                                            +" in_categorias as c on b.IdEmpresa = c.IdEmpresa and b.IdCategoria = c.IdCategoria join"
                                            +" in_linea as d on b.IdEmpresa = d.IdEmpresa and b.IdCategoria = d.IdCategoria and b.IdLinea = d.IdLinea join"
                                            +" in_grupo as e on b.IdEmpresa = e.IdEmpresa and b.IdCategoria = e.IdCategoria and b.IdGrupo = e.IdGrupo and b.IdLinea  = e.IdLinea left join"
                                            +" in_Familia as f on b.IdEmpresa = f.IdEmpresa and b.IdFamilia = f.IdFamilia"
                                            +" where b.Estado = 'A' and b.IdEmpresa = "+IdEmpresa.ToString()+" and not exists("
                                            +" select x.IdEmpresa from in_ProductoPor_tb_bodega as x"
                                            +" where b.IdEmpresa = x.IdEmpresa"
                                            +" and b.IdProducto = x.IdProducto"
                                            +" and x.IdEmpresa = "+IdEmpresa.ToString()
                                            +" and x.IdSucursal = "+IdSucursal.ToString()
                                            +" and x.IdBodega = "+IdBodega.ToString()
                                            +" )";
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Lista.Add(new in_ProductoPor_tb_bodega_Info
                            {
                                IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                                IdSucursal = IdSucursal,
                                IdBodega = IdBodega,
                                IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                                pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                                ca_Categoria = Convert.ToString(reader["ca_Categoria"]),
                                nom_linea = Convert.ToString(reader["nom_linea"]),
                                fa_Descripcion = Convert.ToString(reader["fa_Descripcion"]),
                                nom_grupo = Convert.ToString(reader["nom_grupo"]),
                                Seleccionado = false
                            });
                        }
                        reader.Close();
                    }
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
                    command.ExecuteNonQuery();
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

        public string Validar(int IdEmpresa, int IdSucursal, int IdBodega, List<decimal> Lista)
        {
            try
            {
                string retorno = string.Empty;

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    string InCondition = string.Empty;
                    foreach (var item in Lista)
                    {
                        InCondition += (string.IsNullOrEmpty(InCondition) ? "" : ",") + item.ToString();
                    }
                    command.CommandText = "select a.IdProducto, a.pr_descripcion "
                                        + " from in_Producto as a "
                                        + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.IdProducto in (" + InCondition + ")"
                                        + " and not exists("
                                        + " select * from in_ProductoPor_tb_bodega as b"
                                        + " where a.IdEmpresa = b.IdEmpresa and a.IdProducto = b.IdProducto"
                                        + " and b.IdEmpresa = " + IdEmpresa.ToString()
                                        + " and b.IdProducto in (" + InCondition + ")"
                                        + " and b.IdSucursal = " + IdSucursal.ToString()
                                        + " and b.IdBodega = " + IdBodega.ToString()
                                        + " )";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        retorno += (string.IsNullOrEmpty(retorno) ? "" : "\n") + ("\t") + ("[" + reader["IdProducto"].ToString() + "] " + reader["pr_descripcion"].ToString());
                    }
                    reader.Close();

                    if (!string.IsNullOrEmpty(retorno))
                    {
                        command.CommandText = "SELECT ltrim(rtrim(b.Su_Descripcion))Su_Descripcion, ltrim(rtrim(a.bo_Descripcion))bo_Descripcion"
                                            + " FROM tb_bodega as a join"
                                            + " tb_sucursal as b on a.IdEmpresa = b.IdEmpresa and a.IdSucursal = b.IdSucursal "
                                            + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.IdSucursal = " + IdSucursal.ToString() + " and a.IdBodega = " + IdBodega.ToString();
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            retorno = "Productos no asignados: \nSucursal: " + reader["Su_Descripcion"].ToString() + "\nBodega: " + reader["bo_Descripcion"].ToString() +"\n"+ retorno;
                        }
                    }
                }

                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ValidarExisteEnMultiplesBodegas(int IdEmpresa, int IdSucursal, int IdBodega, bool EsBodegaSecundaria, decimal IdProducto)
        {
            try
            {
                Dictionary<string, string> ListMensaje = new Dictionary<string, string>();
                string Mensaje = string.Empty;
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "declare @IdEmpresa int = "+IdEmpresa.ToString()+","
                                        +" @IdSucursal int = "+IdSucursal.ToString()+","
                                        +" @IdProducto numeric(18,0) = "+IdProducto.ToString()+","
                                        +" @EsBodegaSecundaria bit = "+(EsBodegaSecundaria ? "1" : "0")+","
                                        +" @IdBodega int = "+IdBodega.ToString()
                                        +" select a.IdEmpresa, a.IdSucursal, a.IdBodega, a.IdProducto, b.bo_Descripcion, c.pr_descripcion,"
                                        +" 'El producto ['+cast(@IdProducto as varchar)+'] '+rtrim(ltrim(pr_descripcion))+' no puede estar registrado en multiples bodegas de la misma sucursal' as MensajeGeneral"
                                        +" from in_ProductoPor_tb_bodega as a with (nolock)"
                                        +" join tb_bodega as b with (nolock) on a.idempresa = b.idempresa and a.IdSucursal = b.IdSucursal and a.IdBodega = b.IdBodega"
                                        +" join in_Producto as c with (nolock) on a.IdEmpresa = c.IdEmpresa and a.IdProducto = c.IdProducto"
                                        +" where a.IdEmpresa = @IdEmpresa "
                                        +" and a.IdSucursal = @IdSucursal "
                                        +" and a.IdProducto = @IdProducto"
                                        +" and isnull(b.EsBodegaSecundaria,0) = @EsBodegaSecundaria"
                                        +" and a.IdBodega <> @IdBodega";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListMensaje.Add(reader["bo_Descripcion"].ToString(), reader["MensajeGeneral"].ToString());
                    }
                    reader.Close();
                    if (ListMensaje.Count == 0)
                        return string.Empty;

                    Mensaje = ListMensaje.First().Value;
                    foreach (var item in ListMensaje)
                    {
                        Mensaje += "\n"+item.Key;
                    }
                }
                return Mensaje;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
