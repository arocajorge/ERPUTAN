using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt008_Data
    {
        public List<XINV_Rpt008_Info> GetList(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                List<XINV_Rpt008_Info> Lista = new List<XINV_Rpt008_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "select e.IdEmpresa, e.IdSucursal, e.IdOrdenCompra, "
                                +" h.codigo+'-'+cast(e.IdOrdenCompra as varchar) as CodigoOC, e.Secuencia, f.pr_descripcion,"
                                +" i.oc_fecha, j.cm_fecha, b.co_FechaFactura, d.dm_cantidad_sinConversion, K.Descripcion as NomUnidadMedida,"
                                +" c.Costo_uni, c.Descuento, c.SubTotal, c.valor_Iva, c.Total, g.Su_Descripcion as SucursalIngreso,"
                                +" m.pe_nombreCompleto, b.co_observacion, b.co_subtotal_siniva, b.co_subtotal_iva, b.co_valoriva, b.co_total,"
                                +" b.co_FechaFactura_vct, b.co_serie+'-'+b.co_factura co_factura, isnull(n.re_valor_retencion,0) re_valor_retencion, b.co_total - isnull(re_valor_retencion,0) as ValorAPagar,"
                                +" c.IdNumMovi_Ing_Egr_Inv"
                                +" from cp_Aprobacion_Ing_Bod_x_OC as a inner join"
                                +" cp_orden_giro as b on a.idempresa = b.idempresa and a.IdTipoCbte_Ogiro = b.IdTipoCbte_Ogiro and a.IdCbteCble_Ogiro = b.IdCbteCble_Ogiro inner join"
                                +" cp_Aprobacion_Ing_Bod_x_OC_det as c on a.IdEmpresa = c.IdEmpresa and a.IdAprobacion = c.IdAprobacion inner join"
                                +" in_Ing_Egr_Inven_det as d on c.IdEmpresa_Ing_Egr_Inv = d.IdEmpresa and c.IdSucursal_Ing_Egr_Inv = d.IdSucursal and c.IdMovi_inven_tipo_Ing_Egr_Inv = d.IdMovi_inven_tipo and c.IdNumMovi_Ing_Egr_Inv = d.IdNumMovi and c.Secuencia_Ing_Egr_Inv = d.Secuencia inner join"
                                +" com_ordencompra_local_det as e on d.IdEmpresa_oc = e.IdEmpresa and d.IdSucursal_oc = e.IdSucursal and d.IdOrdenCompra = e.IdOrdenCompra and d.Secuencia_oc = e.Secuencia left join"
                                +" in_Producto as f on e.idempresa = f.idempresa and e.IdProducto = f.IdProducto left join"
                                +" tb_sucursal as g on d.IdEmpresa = g.IdEmpresa and d.IdSucursal = g.IdSucursal left join"
                                +" tb_sucursal as h on e.IdEmpresa = h.IdEmpresa and e.IdSucursal = h.IdSucursal left join"
                                +" com_ordencompra_local as i on e.idempresa = i.idempresa and e.IdSucursal = i.IdSucursal and e.IdOrdenCompra = i.IdOrdenCompra left join"
                                +" in_Ing_Egr_Inven as j on d.IdEmpresa = j.IdEmpresa and d.IdSucursal = j.IdSucursal and d.IdMovi_inven_tipo = j.IdMovi_inven_tipo and d.IdNumMovi = j.IdNumMovi left join"
                                +" in_UnidadMedida as k on d.IdUnidadMedida_sinConversion = k.IdUnidadMedida left join"
                                +" cp_proveedor as l on b.IdEmpresa = l.IdEmpresa and b.IdProveedor = l.IdProveedor left join"
                                +" tb_persona as m on l.IdPersona = m.IdPersona left join"
                                +" ("
                                +" select a.IdEmpresa_Ogiro, a.IdTipoCbte_Ogiro, a.IdCbteCble_Ogiro, sum(b.re_valor_retencion) re_valor_retencion "
                                +" from cp_retencion as a inner join"
                                +" cp_retencion_det as b on a.IdEmpresa = b.IdEmpresa and a.IdRetencion = b.IdRetencion"
                                +" where a.IdEmpresa = "+IdEmpresa.ToString()+" and a.IdTipoCbte_Ogiro = "+IdTipoCbte.ToString()+" and a.IdCbteCble_Ogiro = "+IdCbteCble.ToString()
                                +" group by a.IdEmpresa_Ogiro, a.IdTipoCbte_Ogiro, a.IdCbteCble_Ogiro"
                                +" ) as n on b.IdEmpresa = n.IdEmpresa_Ogiro and b.IdTipoCbte_Ogiro = n.IdTipoCbte_Ogiro and b.IdCbteCble_Ogiro = n.IdCbteCble_Ogiro"
                                +" where b.IdEmpresa = "+IdEmpresa.ToString()+" and b.IdTipoCbte_Ogiro = "+IdTipoCbte.ToString()+" and b.IdCbteCble_Ogiro = "+IdCbteCble.ToString();
                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new XINV_Rpt008_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdOrdenCompra = Convert.ToDecimal(reader["IdOrdenCompra"]),
                            CodigoOC = Convert.ToString(reader["CodigoOC"]),
                            Secuencia = Convert.ToInt32(reader["Secuencia"]),
                            pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                            oc_fecha = Convert.ToDateTime(reader["oc_fecha"]),
                            cm_fecha = Convert.ToDateTime(reader["cm_fecha"]),
                            co_FechaFactura = Convert.ToDateTime(reader["co_FechaFactura"]),
                            dm_cantidad_sinConversion = Convert.ToDouble(reader["dm_cantidad_sinConversion"]),
                            NomUnidadMedida = Convert.ToString(reader["NomUnidadMedida"]),
                            Costo_uni = Convert.ToDouble(reader["Costo_uni"]),
                            Descuento = Convert.ToDouble(reader["Descuento"]),
                            SubTotal = Convert.ToDouble(reader["SubTotal"]),
                            valor_Iva = Convert.ToDouble(reader["valor_Iva"]),
                            Total = Convert.ToDouble(reader["Total"]),
                            SucursalIngreso = Convert.ToString(reader["SucursalIngreso"]),
                            pe_nombreCompleto = Convert.ToString(reader["pe_nombreCompleto"]),
                            co_observacion = Convert.ToString(reader["co_observacion"]),
                            co_subtotal_siniva = Convert.ToDouble(reader["co_subtotal_siniva"]),
                            co_subtotal_iva = Convert.ToDouble(reader["co_subtotal_iva"]),
                            co_valoriva = Convert.ToDouble(reader["co_valoriva"]),
                            co_total = Convert.ToDouble(reader["co_total"]),
                            co_FechaFactura_vct = Convert.ToDateTime(reader["co_FechaFactura_vct"]),
                            co_factura = Convert.ToString(reader["co_factura"]),
                            re_valor_retencion = Convert.ToDouble(reader["re_valor_retencion"]),
                            ValorAPagar = Convert.ToDouble(reader["ValorAPagar"]),
                            IdNumMovi_Ing_Egr_Inv = Convert.ToDecimal(reader["IdNumMovi_Ing_Egr_Inv"])
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
