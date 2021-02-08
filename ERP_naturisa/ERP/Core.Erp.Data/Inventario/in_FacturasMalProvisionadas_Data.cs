using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Inventario
{
    public class in_FacturasMalProvisionadas_Data
    {
        public List<in_FacturasMalProvisionadas_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<in_FacturasMalProvisionadas_Info> Lista = new List<in_FacturasMalProvisionadas_Info>();
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "declare @IdEmpresa int = "+IdEmpresa.ToString()+","
                                        +" @FechaIni date = datefromparts("+FechaIni.Year.ToString()+","+FechaIni.Month.ToString()+","+FechaIni.Day.ToString()+"),"
                                        +" @FechaFin date = datefromparts("+FechaFin.Year.ToString()+","+FechaFin.Month.ToString()+","+FechaFin.Day.ToString()+")"

                                        +" select a.IdEmpresa, a.IdAprobacion, a.IdTipoCbte_Ogiro, a.IdCbteCble_Ogiro, a.Fecha_Factura, d.cm_fecha,a.Observacion, a.Serie+'-'+a.Serie2+'-'+a.num_documento as num_documento, f.pr_descripcion, b.Cantidad, b.Costo_uni, b.SubTotal, b.valor_Iva, b.Total,"
                                        +" i.pe_nombreCompleto, j.dc_Valor, j.cb_Fecha"
                                        +" from cp_Aprobacion_Ing_Bod_x_OC as a join"
                                        +" cp_Aprobacion_Ing_Bod_x_OC_det as b on a.IdEmpresa = b.IdEmpresa and a.IdAprobacion = b.IdAprobacion join"
                                        +" in_Ing_Egr_Inven_det as c on b.IdEmpresa_Ing_Egr_Inv = c.IdEmpresa and b.IdSucursal_Ing_Egr_Inv = c.IdSucursal and b.IdMovi_inven_tipo_Ing_Egr_Inv = c.IdMovi_inven_tipo and b.IdNumMovi_Ing_Egr_Inv = c.IdNumMovi and b.Secuencia_Ing_Egr_Inv = c.Secuencia join"
                                        +" in_Ing_Egr_Inven as d on c.IdEmpresa = d.IdEmpresa and c.IdSucursal = d.IdSucursal and c.IdMovi_inven_tipo = d.IdMovi_inven_tipo and c.IdNumMovi = d.IdNumMovi left join"
                                        +" in_parametro as e on a.IdEmpresa = e.IdEmpresa join"
                                        +" in_Producto as f on c.IdEmpresa = f.IdEmpresa and c.IdProducto = f.IdProducto join"
                                        +" in_Motivo_Inven as g on d.IdEmpresa = g.IdEmpresa and d.IdMotivo_Inv = g.IdMotivo_Inv join"
                                        +" cp_proveedor as h on a.IdEmpresa = h.IdEmpresa and a.IdProveedor = h.IdProveedor join"
                                        +" tb_persona as i on h.IdPersona = i.IdPersona left join"
                                        +" ("
                                        +" select a.IdEmpresa, a.IdTipoCbte, a.IdCbteCble, c.cb_Fecha, sum(a.dc_Valor) dc_Valor "
                                        +" from ct_cbtecble_det as a join"
                                        +" in_parametro as b on a.IdEmpresa = b.IdEmpresa and a.IdCtaCble = b.IdCtaCble_Provision join"
                                        +" ct_cbtecble as c on a.IdEmpresa = c.IdEmpresa and a.IdTipoCbte = c.IdTipoCbte and a.IdCbteCble = c.IdCbteCble "
                                        +" where c.IdEmpresa = @IdEmpresa "
                                        +" group by a.IdEmpresa, a.IdTipoCbte, a.IdCbteCble, c.cb_Fecha"
                                        +" ) as j on a.IdEmpresa_Ogiro = j.IdEmpresa and a.IdTipoCbte_Ogiro = j.IdTipoCbte and a.IdCbteCble_Ogiro = j.IdCbteCble"
                                        +" where a.IdCbteCble_Ogiro is not null"
                                        +" and a.IdEmpresa = @IdEmpresa"
                                        +" and a.Fecha_Factura > @FechaFin"
                                        +" and d.cm_fecha between @FechaIni and @FechaFin"
                                        +" and g.Genera_Movi_Inven = 'S'";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new in_FacturasMalProvisionadas_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdAprobacion = Convert.ToDecimal(reader["IdAprobacion"]),
                            IdTipoCbte_Ogiro = Convert.ToInt32(reader["IdTipoCbte_Ogiro"]),
                            IdCbteCble_Ogiro = Convert.ToDecimal(reader["IdCbteCble_Ogiro"]),
                            Fecha_Factura = Convert.ToDateTime(reader["Fecha_Factura"]),
                            cm_fecha = Convert.ToDateTime(reader["cm_fecha"]),
                            Observacion = Convert.ToString(reader["Observacion"]),
                            num_documento = Convert.ToString(reader["num_documento"]),
                            pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                            Cantidad = Convert.ToDouble(reader["Cantidad"]),
                            Costo_uni = Convert.ToDouble(reader["Costo_uni"]),
                            SubTotal = Convert.ToDouble(reader["SubTotal"]),
                            valor_Iva = Convert.ToDouble(reader["valor_Iva"]),
                            Total = Convert.ToDouble(reader["Total"]),
                            pe_nombreCompleto = Convert.ToString(reader["pe_nombreCompleto"]),
                            dc_Valor = reader["dc_Valor"] == DBNull.Value ? null : (double?)reader["dc_Valor"],
                            cb_Fecha = reader["cb_Fecha"] == DBNull.Value ? null : (DateTime?)reader["cb_Fecha"],

                            Agrupar = reader["IdCbteCble_Ogiro"].ToString() + " / " + Convert.ToString(reader["num_documento"])
                        });
                    }
                    reader.Close();
                    return Lista;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
