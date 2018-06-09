using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Facturacion_Grafinpren;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion_Grafinpren
{
    public class fa_factura_graf_Data
    {
        string mensaje = "";

        public List<fa_factura_Info> Get_List_factura(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<fa_factura_Info> FacturaInfo = new List<fa_factura_Info>();
                EntitiesFacturacion_Grafinpren OEFAC = new EntitiesFacturacion_Grafinpren();

                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());


                IQueryable<Facturacion_Grafinpren.vwfa_factura_graf> SelectFactura;
                if (IdSucursalIni == 0)
                {
                    SelectFactura = from q in OEFAC.vwfa_factura_graf
                                    where q.IdEmpresa == IdEmpresa && q.vt_fecha >= FechaIni && q.vt_fecha <= FechaFin
                                    select q;
                }
                else
                {
                    if (IdBodegaIni == 0)
                    {
                        SelectFactura = from q in OEFAC.vwfa_factura_graf
                                        where q.IdEmpresa == IdEmpresa
                                        && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                        && q.vt_fecha >= FechaIni && q.vt_fecha <= FechaFin
                                        select q;
                    }
                    else
                    {
                        SelectFactura = from q in OEFAC.vwfa_factura_graf
                                        where q.IdEmpresa == IdEmpresa
                                        && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                                        && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                        && q.vt_fecha >= FechaIni && q.vt_fecha <= FechaFin
                                        select q;
                    }
                }

                var CabeceraFactura = from cab in SelectFactura
                                      group cab by new
                                      {
                                          cab.IdEmpresa,
                                          cab.IdSucursal,
                                          cab.IdBodega,
                                          cab.bo_Descripcion,
                                          cab.IdCbteVta,
                                          cab.vt_NumFactura,
                                          cab.IdCliente,
                                          cab.vt_tipoDoc,
                                          cab.vt_flete,
                                          cab.vt_serie1,
                                          cab.vt_autorizacion,
                                          cab.vt_serie2,
                                          cab.IdUsuario,
                                          cab.pe_nombreCompleto,
                                          cab.pe_razonSocial,
                                          cab.IdVendedor,
                                          cab.Ve_Vendedor,
                                          cab.vt_tipo_venta,
                                          cab.Su_Descripcion,
                                          cab.vt_OtroValor1,
                                          cab.vt_OtroValor2,
                                          cab.CodCbteVta,
                                          cab.vt_seguro,
                                          cab.vt_interes,
                                          cab.vt_fecha,
                                          cab.vt_fech_venc,
                                          cab.vt_plazo,
                                          cab.vt_Observacion,
                                          cab.Estado,
                                          cab.IdCaja,
                                          cab.IdEmpresa_nc_anu,
                                          cab.IdSucursal_nc_anu,
                                          cab.IdBodega_nc_anu,
                                          cab.IdNota_nc_anu,

                                          //datos internos
                                          cab.num_op,
                                          cab.num_cotizacion,
                                          cab.IdEquipo,
                                          cab.fecha_op,
                                          cab.fecha_cotizacion,
                                          cab.porc_comision,
                                          cab.pe_direccion
                                      }
                                          into grouping
                                          select new { grouping.Key, subototal = grouping.Sum(p => p.vt_Subtotal), iva = grouping.Sum(p => p.vt_iva), Total = grouping.Sum(p => p.vt_total) };
                foreach (var item in CabeceraFactura)
                {
                    fa_factura_Info info = new fa_factura_Info();

                    List<fa_factura_det_info> ListDet = new List<fa_factura_det_info>();

                    info.IdCbteVta = item.Key.IdCbteVta;
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.IdBodega = item.Key.IdBodega;
                    info.vt_serie1 = item.Key.vt_serie1;
                    info.vt_serie2 = item.Key.vt_serie2;
                    info.vt_tipo_venta = item.Key.vt_tipo_venta;
                    info.Bodega = item.Key.bo_Descripcion;
                    info.vt_NumFactura = item.Key.vt_NumFactura;
                    info.Cliente = item.Key.pe_razonSocial;
                    info.Vendedor = item.Key.Ve_Vendedor;
                    info.Sucursal = item.Key.Su_Descripcion;
                    info.vt_autorizacion = item.Key.vt_autorizacion;
                    info.IdCliente = item.Key.IdCliente;
                    info.vt_fecha = item.Key.vt_fecha;
                    info.IdVendedor = item.Key.IdVendedor;
                    info.CodCbteVta = item.Key.CodCbteVta;
                    info.vt_fech_venc = item.Key.vt_fech_venc;
                    info.vt_plazo = item.Key.vt_plazo;
                    info.IdUsuario = item.Key.IdUsuario;
                    info.vt_Observacion = item.Key.vt_Observacion;
                    info.Subtotal = Convert.ToDouble(item.subototal);
                    info.vt_OtroValor1 = item.Key.vt_OtroValor1;
                    info.vt_OtroValor2 = item.Key.vt_OtroValor2;
                    info.vt_flete = item.Key.vt_flete;
                    info.vt_interes = item.Key.vt_interes;
                    info.vt_seguro = item.Key.vt_seguro;
                    info.vt_tipoDoc = item.Key.vt_tipoDoc;
                    info.Estado = item.Key.Estado;
                    info.IVA = item.iva;
                    info.Total = item.Total;
                    info.IdCaja = item.Key.IdCaja;
                    
                    //datos internos
                    info.Factura_Graf.num_op = item.Key.num_op;
                    info.Factura_Graf.num_cotizacion = item.Key.num_cotizacion;
                    info.Factura_Graf.porc_comision = Convert.ToDouble(item.Key.porc_comision);
                    info.Factura_Graf.IdEquipo = Convert.ToInt32(item.Key.IdEquipo);
                    info.Factura_Graf.fecha_op = Convert.ToDateTime(item.Key.fecha_op);
                    info.Factura_Graf.fecha_cotizacion = Convert.ToDateTime(item.Key.fecha_cotizacion);
                    info.Factura_Graf.pe_direccion = item.Key.pe_direccion;

                    info.IdEmpresa_nc_anu = Convert.ToInt32(item.Key.IdEmpresa_nc_anu);
                    info.IdSucursal_nc_anu = Convert.ToInt32(item.Key.IdSucursal_nc_anu);
                    info.IdBodega_nc_anu = Convert.ToInt32(item.Key.IdBodega_nc_anu);
                    info.IdNota_nc_anu = Convert.ToDecimal(item.Key.IdNota_nc_anu);

                    FacturaInfo.Add(info);
                }
                return FacturaInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_factura_graf_Info> Get_List_factura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                EntitiesFacturacion_Grafinpren OEFAC = new EntitiesFacturacion_Grafinpren();

                List<fa_factura_graf_Info> FacturaInfo = new List<fa_factura_graf_Info>();

                var CabeceraFactura = from q in OEFAC.vwfa_factura_graf
                                      where q.IdEmpresa == IdEmpresa
                                      && q.IdSucursal == IdSucursal
                                      && q.IdBodega == IdBodega
                                      && q.IdCbteVta == IdCbteVta
                                      select q;

                foreach (var item in CabeceraFactura)
                {
                    fa_factura_graf_Info info = new fa_factura_graf_Info();
                    
                    //datos internos
                    info.num_op = item.num_op;
                    info.num_cotizacion = item.num_cotizacion;
                    info.porc_comision = Convert.ToDouble(item.porc_comision);
                    info.IdEquipo = Convert.ToInt32(item.IdEquipo);
                    info.fecha_op = Convert.ToDateTime(item.fecha_op);
                    info.fecha_cotizacion = Convert.ToDateTime(item.fecha_cotizacion);
                    info.pe_direccion = item.pe_direccion;
                    info.Observacion = item.vt_Observacion;

                    FacturaInfo.Add(info);
                }
                return FacturaInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public fa_factura_graf_Info Get_Info_graf(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {

                fa_factura_graf_Info info = new fa_factura_graf_Info();
                EntitiesFacturacion_Grafinpren OEFAC = new EntitiesFacturacion_Grafinpren();

                var CabeceraFactura = from q in OEFAC.fa_factura_graf
                                      where q.IdEmpresa == IdEmpresa
                                      && q.IdSucursal == IdSucursal
                                      && q.IdBodega == IdBodega
                                      && q.IdCbteVta == IdCbteVta
                                      select q;

                foreach (var item in CabeceraFactura)
                {
                    info = new fa_factura_graf_Info();
                    //datos internos
                    info.num_op = item.num_op;
                    info.num_cotizacion = item.num_cotizacion;
                    info.porc_comision = Convert.ToDouble(item.porc_comision);
                    info.IdEquipo = Convert.ToInt32(item.IdEquipo);
                    info.fecha_op = Convert.ToDateTime(item.fecha_op);
                    info.fecha_cotizacion = Convert.ToDateTime(item.fecha_cotizacion);
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(fa_factura_graf_Info info, decimal id, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion_Grafinpren context = new EntitiesFacturacion_Grafinpren())
                {
                    fa_factura_graf address = new fa_factura_graf();
                    
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdBodega = info.IdBodega;
                    address.IdCbteVta = (info.IdCbteVta == 0) ? id : info.IdCbteVta;
                    address.num_op = info.num_op;
                    address.fecha_op = info.fecha_op;
                    address.num_cotizacion = info.num_cotizacion;
                    address.fecha_cotizacion = info.fecha_cotizacion;
                    address.IdEquipo = info.IdEquipo;
                    address.porc_comision = info.porc_comision;
                    
                    context.fa_factura_graf.Add(address);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_factura_graf_Info info, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion_Grafinpren context = new EntitiesFacturacion_Grafinpren())
                {
                    var contact = context.fa_factura_graf.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdBodega == info.IdBodega && obj.IdCbteVta == info.IdCbteVta);

                    if (contact != null)
                    {
                        contact.num_op = info.num_op;
                        contact.fecha_op = info.fecha_op;
                        contact.num_cotizacion = info.num_cotizacion;
                        contact.fecha_cotizacion = info.fecha_cotizacion;
                        contact.IdEquipo = info.IdEquipo;
                        contact.porc_comision = info.porc_comision;

                        context.SaveChanges();
                    }
                    else
                    {
                        decimal id = 0;
                        GrabarDB(info, id, ref mensaje);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
    }
}
