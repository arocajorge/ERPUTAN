using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data;
using System.Data.SqlClient;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt014_Data
    {
        public List<XINV_Rpt014_Info> GetList(int IdEmpresa, decimal IdProducto, DateTime FechaIni, DateTime FechaFin, string IdCentroCosto, int IdSucursal, int IdBodega)
        {
            try
            {
                List<XINV_Rpt014_Info> Lista = new List<XINV_Rpt014_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT a.IdEmpresa, a.IdSucursal, a.IdMovi_inven_tipo, a.IdNumMovi, a.Secuencia, a.IdBodega, b.cm_fecha, a.IdProducto, d.pr_descripcion,"
                                +" a.IdCentroCosto, a.IdCentroCosto_sub_centro_costo, e.Centro_costo as NomCentroCosto, f.Centro_costo as NomSubCentro, c.Su_Descripcion,"
                                + " h.tm_descripcion, i.bo_Descripcion, abs(a.dm_cantidad) dm_cantidad, a.IdEstadoAproba, j.Descripcion as NomUnidadMedida"
                                +" FROM in_Ing_Egr_Inven_det as a inner join"
                                +" in_Ing_Egr_Inven as b on a.IdEmpresa = b.IdEmpresa and a.IdSucursal = b.IdSucursal and a.IdMovi_inven_tipo = b.IdMovi_inven_tipo and a.IdNumMovi = b.IdNumMovi left join"
                                +" tb_sucursal as c on a.IdEmpresa = c.IdEmpresa and a.IdSucursal = c.IdSucursal left join"
                                +" in_producto as d on a.idempresa = d.IdEmpresa and a.IdProducto = d.IdProducto inner join"
                                +" ct_centro_costo as e on a.IdEmpresa = e.IdEmpresa and a.IdCentroCosto = e.IdCentroCosto inner join"
                                +" ct_centro_costo_sub_centro_costo as f on a.IdEmpresa = f.IdEmpresa and a.IdCentroCosto = f.IdCentroCosto and a.IdCentroCosto_sub_centro_costo = f.IdCentroCosto_sub_centro_costo inner join"
                                +" in_Motivo_Inven as g on b.IdEmpresa = g.IdEmpresa and b.IdMotivo_Inv = g.IdMotivo_Inv left join"
                                +" in_movi_inven_tipo as h on a.IdEmpresa = h.IdEmpresa and a.IdMovi_inven_tipo = h.IdMovi_inven_tipo left join"
                                +" tb_bodega as i on a.IdEmpresa = i.IdEmpresa and a.IdSucursal = i.IdSucursal and a.IdBodega = i.IdBodega left join"
                                + " in_UnidadMedida as j on d.IdUnidadMedida_consumo = j.IdUnidadMedida"
                                + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and g.Genera_Movi_Inven = 'S' and b.cm_fecha between DATEFROMPARTS(" + FechaIni.Year.ToString() + "," + FechaIni.Month.ToString() + "," + FechaIni.Day.ToString() + ") and DATEFROMPARTS(" + FechaFin.Year.ToString() + "," + FechaFin.Month.ToString() + "," + FechaFin.Day.ToString() + ") and b.signo = '-' and b.Estado = 'A'";
                    if (IdProducto > 0)
                        query += " and a.IdProducto = "+IdProducto.ToString();
                    if (!string.IsNullOrEmpty(IdCentroCosto) && IdCentroCosto != "Todos" )
                        query += " and a.IdCentroCosto = '"+IdCentroCosto+"'";
                    if(IdSucursal > 0)
                        query += " and a.IdSucursal = " + IdSucursal.ToString();
                    if (IdBodega > 0)
                        query += " and a.IdBodega = " + IdBodega.ToString();

                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new XINV_Rpt014_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdMovi_inven_tipo = Convert.ToInt32(reader["IdMovi_inven_tipo"]),
                            IdNumMovi = Convert.ToDecimal(reader["IdNumMovi"]),
                            Secuencia = Convert.ToInt32(reader["Secuencia"]),
                            IdBodega = Convert.ToInt32(reader["IdBodega"]),
                            cm_fecha = Convert.ToDateTime(reader["cm_fecha"]),
                            IdProducto = Convert.ToInt32(reader["IdProducto"]),
                            pr_descripcion = "["+reader["IdProducto"].ToString()+"] "+ Convert.ToString(reader["pr_descripcion"]),
                            IdCentroCosto = Convert.ToString(reader["IdCentroCosto"]),
                            IdCentroCosto_sub_centro_costo = Convert.ToString(reader["IdCentroCosto_sub_centro_costo"]),
                            NomCentroCosto = Convert.ToString(reader["NomCentroCosto"]),
                            NomSubcentro = Convert.ToString(reader["NomSubcentro"]),
                            IdEstadoAproba = Convert.ToString(reader["IdEstadoAproba"]),
                            Su_Descripcion = Convert.ToString(reader["Su_Descripcion"]),
                            tm_descripcion = Convert.ToString(reader["tm_descripcion"]),
                            bo_Descripcion = Convert.ToString(reader["bo_Descripcion"]),
                            dm_cantidad = Convert.ToDouble(reader["dm_cantidad"]),
                            NomUnidadMedida = Convert.ToString(reader["NomUnidadMedida"])
                        });
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
