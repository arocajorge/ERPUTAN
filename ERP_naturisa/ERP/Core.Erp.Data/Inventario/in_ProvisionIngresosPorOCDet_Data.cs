using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Inventario
{
    public class in_ProvisionIngresosPorOCDet_Data
    {
        public List<in_ProvisionIngresosPorOCDet_Info> GetList(int IdEmpresa, decimal IdProvision)
        {
            try
            {
                List<in_ProvisionIngresosPorOCDet_Info> Lista = new List<in_ProvisionIngresosPorOCDet_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select a.IdEmpresa, j.IdProvision, j.Secuencia, a.IdSucursal, a.IdMovi_inven_tipo, a.IdNumMovi, a.secuencia as Secuencia_inv, "
                                        + " d.bo_Descripcion, e.Su_Descripcion, C.tm_descripcion,h.IdProducto, h.pr_descripcion, d.IdCtaCtble_Inve, i.pc_Cuenta , j.Costo as Costo"
                                        + " from in_Ing_Egr_Inven_det as a join"
                                        + " in_Ing_Egr_Inven as b on a.IdEmpresa = b.IdEmpresa and a.IdSucursal = b.IdSucursal and a.IdMovi_inven_tipo = b.IdMovi_inven_tipo and a.IdNumMovi = b.IdNumMovi join"
                                        + " in_movi_inven_tipo as c on a.IdEmpresa = c.IdEmpresa and a.IdMovi_inven_tipo = c.IdMovi_inven_tipo left join"
                                        + " tb_bodega as d on a.IdEmpresa = d.IdEmpresa and a.IdSucursal = d.IdSucursal and a.IdBodega = d.IdBodega left join"
                                        + " tb_sucursal as e on a.IdEmpresa = e.IdEmpresa and a.IdSucursal = e.IdSucursal join"
                                        + " in_Producto as h on a.idempresa = h.idempresa and a.IdProducto = h.IdProducto left join"
                                        + " ct_plancta as i on d.idempresa = i.idempresa and d.IdCtaCtble_Inve = i.IdCtaCble join"
                                        + " in_ProvisionIngresosPorOCDet as j on a.IdEmpresa = j.IdEmpresa and a.IdSucursal = j.IdSucursal and a.IdMovi_inven_tipo = j.IdMovi_inven_tipo and a.IdNumMovi = j.IdNumMovi and a.Secuencia = j.Secuencia_inv"
                                        + " WHERE IdEmpresa = " + IdEmpresa.ToString() + " and IdProvision = " + IdProvision.ToString();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new in_ProvisionIngresosPorOCDet_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdProvision = Convert.ToDecimal(reader["IdProvision"]),
                            Secuencia = Convert.ToInt32(reader["Secuencia"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdMovi_inven_tipo = Convert.ToInt32(reader["IdMovi_inven_tipo"]),
                            IdNumMovi = Convert.ToDecimal(reader["IdNumMovi"]),
                            Secuencia_inv = Convert.ToInt32(reader["Secuencia_inv"]),
                            bo_Descripcion = Convert.ToString(reader["bo_Descripcion"]),
                            Su_Descripcion = Convert.ToString(reader["Su_Descripcion"]),
                            tm_descripcion = Convert.ToString(reader["tm_descripcion"]),
                            IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                            pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                            IdCtaCtble_Inve = Convert.ToString(reader["IdCtaCtble_Inve"]),
                            pc_Cuenta = Convert.ToString(reader["pc_Cuenta"]),
                            Costo = Convert.ToDouble(reader["Costo"])
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

        public List<in_ProvisionIngresosPorOCDet_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<in_ProvisionIngresosPorOCDet_Info> Lista = new List<in_ProvisionIngresosPorOCDet_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "DECLARE @IdEmpresa int = "+IdEmpresa.ToString()
                                        + " ,@FechaIni date = datefromparts("+FechaIni.Year.ToString()+","+FechaIni.Month.ToString()+","+FechaIni.Day.ToString()+")"
                                        + " ,@FechaFin date = datefromparts("+FechaFin.Year.ToString()+","+FechaFin.Month.ToString()+","+FechaFin.Day.ToString()+")"

                                        + " select a.IdEmpresa, a.IdSucursal, a.IdMovi_inven_tipo, a.IdNumMovi, a.secuencia Secuencia_inv, d.bo_Descripcion, e.Su_Descripcion, C.tm_descripcion,h.IdProducto, h.pr_descripcion, d.IdCtaCtble_Inve, i.pc_Cuenta, (a.dm_cantidad_sinConversion * a.mv_costo_sinConversion) as Costo"
                                        + " from in_Ing_Egr_Inven_det as a join"
                                        + " in_Ing_Egr_Inven as b on a.IdEmpresa = b.IdEmpresa and a.IdSucursal = b.IdSucursal and a.IdMovi_inven_tipo = b.IdMovi_inven_tipo and a.IdNumMovi = b.IdNumMovi join"
                                        + " in_movi_inven_tipo as c on a.IdEmpresa = c.IdEmpresa and a.IdMovi_inven_tipo = c.IdMovi_inven_tipo left join"
                                        + " tb_bodega as d on a.IdEmpresa = d.IdEmpresa and a.IdSucursal = d.IdSucursal and a.IdBodega = d.IdBodega left join"
                                        + " tb_sucursal as e on a.IdEmpresa = e.IdEmpresa and a.IdSucursal = e.IdSucursal left join"
                                        + " cp_Aprobacion_Ing_Bod_x_OC_det as f on a.IdEmpresa = f.IdEmpresa_Ing_Egr_Inv and a.IdSucursal = f.IdSucursal_Ing_Egr_Inv and a.IdMovi_inven_tipo = f.IdMovi_inven_tipo_Ing_Egr_Inv and a.IdNumMovi = f.IdNumMovi_Ing_Egr_Inv and a.Secuencia = f.Secuencia_Ing_Egr_Inv LEFT JOIN"
                                        + " cp_Aprobacion_Ing_Bod_x_OC as g on f.IdEmpresa = g.IdEmpresa and f.IdAprobacion = g.IdAprobacion and g.Fecha_Factura <= @FechaFin LEFT join"
                                        + " in_Producto as h on a.idempresa = h.idempresa and a.IdProducto = h.IdProducto left join"
                                        + " ct_plancta as i on d.idempresa = i.idempresa and d.IdCtaCtble_Inve = i.IdCtaCble"
                                        + " where b.IdEmpresa = @IdEmpresa and b.cm_fecha between @FechaIni and @FechaFin and f.Secuencia is null and b.Estado = 'A' AND A.IdOrdenCompra IS NOT NULL";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new in_ProvisionIngresosPorOCDet_Info
                        {
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdMovi_inven_tipo = Convert.ToInt32(reader["IdMovi_inven_tipo"]),
                            IdNumMovi = Convert.ToDecimal(reader["IdNumMovi"]),
                            Secuencia_inv = Convert.ToInt32(reader["Secuencia_inv"]),
                            bo_Descripcion = Convert.ToString(reader["bo_Descripcion"]),
                            Su_Descripcion = Convert.ToString(reader["Su_Descripcion"]),
                            tm_descripcion = Convert.ToString(reader["tm_descripcion"]),
                            IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                            pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                            IdCtaCtble_Inve = Convert.ToString(reader["IdCtaCtble_Inve"]),
                            pc_Cuenta = Convert.ToString(reader["pc_Cuenta"]),
                            Costo = Convert.ToDouble(reader["Costo"])
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
    }
}
