using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_devol_venta_Data
    {
        string mensaje = "";

        public List<fa_devol_venta_Info> Get_List_devol_venta(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin
            , DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<fa_devol_venta_Info> DEVInfo = new List<fa_devol_venta_Info>();
                
                EntitiesFacturacion OEFAC = new EntitiesFacturacion();
                //
                var SelectFactura = from q in OEFAC.vwfa_devolucion select q;
                if (IdSucursalIni == 0)
                {
                    SelectFactura = from q in OEFAC.vwfa_devolucion
                                    where q.IdEmpresa == IdEmpresa && q.dv_fecha >= FechaIni && q.dv_fecha <= FechaFin
                                    select q;

                }
                else
                {
                    //
                    SelectFactura = from q in OEFAC.vwfa_devolucion
                                    where q.IdEmpresa == IdEmpresa
                                    && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                                    && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                    && q.dv_fecha >= FechaIni && q.dv_fecha <= FechaFin
                                    select q;
                }


                var CabeceraFactura = from cab in SelectFactura
                                      group cab by new
                                      {
                                          cab.IdEmpresa,
                                          cab.IdSucursal,
                                          cab.IdBodega,
                                          cab.IdDevolucion,
                                          cab.bo_Descripcion,
                                          cab.IdCbteVta,
                                          cab.IdCliente,
                                          cab.dv_fecha,
                                          cab.IdUsuario,
                                          cab.pe_nombreCompleto,
                                          cab.IdVendedor,
                                          cab.Ve_Vendedor,
                                          cab.Su_Descripcion,
                                          cab.IdNota,
                                          //cab.dv_iva,
                                          //cab.dv_subtotal,
                                          cab.vt_NumFactura,
                                          cab.vt_serie1,
                                          cab.vt_serie2,
                                          cab.dv_seguro,
                                          cab.dv_flete,
                                          cab.dv_interes,
                                          cab.dv_OtroValor1,
                                          cab.dv_OtroValor2,

                                          cab.CodDevolucion,
                                          cab.dv_Observacion,
                                          cab.Estado
                                      }
                                          into grouping
                                          select new { grouping.Key, subototal = grouping.Sum(p => p.dv_subtotal), iva = grouping.Sum(p => p.dv_iva), Total = grouping.Sum(p => p.dv_total) };

                foreach (var item in CabeceraFactura)
                {
                    fa_devol_venta_Info info = new fa_devol_venta_Info();

                    List<fa_devol_venta_det_Info> ListDet = new List<fa_devol_venta_det_Info>();


                    info.IdCbteVta = item.Key.IdCbteVta;
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.IdBodega = item.Key.IdBodega;
                    info.Bodega = item.Key.bo_Descripcion;
                    info.IdDevolucion = item.Key.IdDevolucion;
                    info.Cliente = item.Key.pe_nombreCompleto;
                    info.Vendedor = item.Key.Ve_Vendedor;
                    info.Sucursal = item.Key.Su_Descripcion;
                    info.IdCliente = item.Key.IdCliente;
                    info.dv_fecha = item.Key.dv_fecha;
                    info.IdVendedor = item.Key.IdVendedor;
                    info.IdCbteVta = item.Key.IdCbteVta;
                    info.IdUsuario = item.Key.IdUsuario;
                    info.dv_Observacion = item.Key.dv_Observacion;
                    info.Subtotal = Convert.ToDouble(item.subototal);
                    info.Estado = item.Key.Estado;
                    info.IVA = item.iva;
                    info.Total = item.Total;
                    info.vt_serie1 = item.Key.vt_serie1;
                    info.IdNota = item.Key.IdNota;
                    info.vt_serie2=item.Key.vt_serie2;
                    info.vt_NumFactura = item.Key.vt_NumFactura;
                    info.CodDevolucion = item.Key.CodDevolucion;
                    info.dv_seguro = Convert.ToDouble(item.Key.dv_seguro);
                    info.dv_flete = Convert.ToDouble(item.Key.dv_flete);
                    info.dv_interes = Convert.ToDouble(item.Key.dv_interes);
                    info.dv_OtroValor1 = Convert.ToDouble(item.Key.dv_OtroValor1);
                    info.dv_OtroValor2 = Convert.ToDouble(item.Key.dv_OtroValor2);
                    DEVInfo.Add(info);

                }

                return DEVInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        
        }

        public Boolean GuardarDB(fa_devol_venta_Info Info, ref string msg) 
        {
            try
            {
                using (EntitiesFacturacion context =new EntitiesFacturacion())
                {
                    EntitiesFacturacion Dev = new EntitiesFacturacion();

                    
                    decimal IdDev = 0;
                    try
                    {
                        IdDev = (from C in Dev.fa_devol_venta where C.IdBodega == Info.IdBodega && C.IdSucursal == Info.IdSucursal && C.IdEmpresa == Info.IdEmpresa select C.IdDevolucion).Max() + 1;
                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                        msg = ex.InnerException + " " + ex.Message;
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);    
                    }
                    if (IdDev == 0) { IdDev = 1; }
                    var addressG = new fa_devol_venta();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdSucursal = Info.IdSucursal;
                    addressG.IdBodega = Info.IdBodega;
                    addressG.IdDevolucion = Info.IdDevolucion=IdDev;
                    addressG.IdCbteVta = Info.IdCbteVta;
                    addressG.CodDevolucion = (Info.CodDevolucion == "") ? "DEV" + IdDev.ToString() : Info.CodDevolucion;
                    addressG.IdCliente = Info.IdCliente;
                    addressG.IdVendedor = Info.IdVendedor;
                    addressG.dv_fecha = Convert.ToDateTime(Info.dv_fecha.ToShortDateString());
                    addressG.IdCbteVta = Info.IdCbteVta;
                    addressG.IdNota = Info.IdNota;
                    addressG.dv_Observacion = Info.dv_Observacion;
                    addressG.dv_seguro = Info.dv_seguro;
                    addressG.dv_flete = Info.dv_flete;
                    addressG.dv_interes = Info.dv_interes;
                    addressG.dv_OtroValor1 = Info.dv_OtroValor1;
                    addressG.dv_OtroValor2 = Info.dv_OtroValor2;
                    addressG.IdUsuario = Info.IdUsuario;
                    addressG.Estado = Info.Estado;                  
                    addressG.IdUsuario = Info.IdUsuario;
                  
                    
                    if (Info.DetalleDeVta !=null)
                    {
                        context.fa_devol_venta.Add(addressG);
                        context.SaveChanges();
                        msg = Convert.ToString(IdDev);
                
                        fa_devol_venta_det_Data oData = new fa_devol_venta_det_Data();
                        oData.GuardarDB(Info.DetalleDeVta, ref msg);
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

        public fa_devol_venta_Info Get_Info_devol_venta(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdDevolucion, ref string msg)
        {
            try
            {
                fa_devol_venta_Info info = new fa_devol_venta_Info();
                    EntitiesFacturacion Dev = new EntitiesFacturacion();

                    var Devo = from C in Dev.fa_devol_venta where C.IdBodega == IdBodega && C.IdSucursal == IdSucursal && C.IdEmpresa == IdEmpresa && C.IdDevolucion == IdDevolucion select C;

                    foreach (var item in Devo)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdDevolucion = item.IdDevolucion;
                        info.IdCbteVta = item.IdCbteVta;
                        info.CodDevolucion = item.CodDevolucion;
                        info.IdCliente = item.IdCliente;
                        info.IdVendedor = item.IdVendedor;
                        info.dv_fecha = Convert.ToDateTime(item.dv_fecha.ToShortDateString());
                        info.IdCbteVta = item.IdCbteVta;
                        info.IdNota = item.IdNota;
                        info.dv_Observacion = item.dv_Observacion;
                        info.dv_seguro = Convert.ToDouble(item.dv_seguro);
                        info.dv_flete = Convert.ToDouble(item.dv_flete);
                        info.dv_interes = Convert.ToDouble(item.dv_interes);
                        info.dv_OtroValor1 = Convert.ToDouble(item.dv_OtroValor1);
                        info.dv_OtroValor2 = Convert.ToDouble(item.dv_OtroValor2);
                        info.IdUsuario = item.IdUsuario;
                        info.Estado = item.Estado;
                        info.IdUsuario = item.IdUsuario;
                        info.mvInv_IdEmpresa = Convert.ToInt32(item.mvInv_IdEmpresa);
                        info.mvInv_IdSucursal = Convert.ToInt32(item.mvInv_IdSucursal);
                        info.mvInv_IdBodega = Convert.ToInt32(item.mvInv_IdBodega);
                        info.mvInv_IdMovi_inven_tipo = Convert.ToInt32(item.mvInv_IdMovi_inven_tipo);
                        info.mvInv_IdNumMovi = Convert.ToInt32(item.mvInv_IdNumMovi);


                        msg = Convert.ToString(item.CodDevolucion);
                    }
                return info;
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

        public Boolean ModificarDB(fa_devol_venta_Info info, ref string msgs)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_devol_venta.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdDevolucion == info.IdDevolucion && cot.IdSucursal == info.IdSucursal && cot.IdBodega == info.IdBodega);
                    if (contact != null)
                    {
                        contact.mvInv_IdEmpresa = info.mvInv_IdEmpresa;
                        contact.mvInv_IdSucursal = info.mvInv_IdSucursal;
                        contact.mvInv_IdBodega = info.mvInv_IdBodega;
                        contact.mvInv_IdNumMovi = info.mvInv_IdNumMovi;
                        contact.mvInv_IdMovi_inven_tipo = info.mvInv_IdMovi_inven_tipo;

                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msgs = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarCabeceraAnulacion(fa_devol_venta_Info info, ref string msgs)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_devol_venta.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa 
                        && cot.IdSucursal == info.IdSucursal && cot.IdBodega == info.IdBodega
                        && cot.mvInv_IdEmpresa == info.IdEmpresa
                        && cot.mvInv_IdSucursal == info.IdSucursal
                        && cot.mvInv_IdBodega == info.IdBodega
                        && cot.mvInv_IdMovi_inven_tipo == info.mvInv_IdMovi_inven_tipo
                        && cot.mvInv_IdNumMovi == info.mvInv_IdNumMovi);

                    if (contact != null)
                    {
                        contact.mvInv_IdEmpresa_x_Anu = info.mvInv_IdEmpresa_x_Anu;
                        contact.mvInv_IdSucursal_x_Anu = info.mvInv_IdSucursal_x_Anu;
                        contact.mvInv_IdBodega_x_Anu = info.mvInv_IdBodega_x_Anu;
                        contact.mvInv_IdMovi_inven_tipo_x_Anu = info.mvInv_IdMovi_inven_tipo_x_Anu;
                        contact.mvInv_IdNumMovi_x_Anu = info.mvInv_IdNumMovi_x_Anu;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msgs = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdDevolucion,string Motivo)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_devol_venta.FirstOrDefault(cot => cot.IdEmpresa == IdEmpresa && cot.IdDevolucion == IdDevolucion && cot.IdSucursal == IdSucursal && cot.IdBodega == IdBodega);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.MotivoAnulacion = Motivo;
                        contact.Estado = "I";
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean consultaDevolucionFactura(int IdEmpresa, int IdSucursal, int IdBodega, Decimal IdCteVta)
        {
            try
            {
                EntitiesFacturacion fac = new EntitiesFacturacion();
                var val = (from q in fac.fa_devol_venta
                          where q.IdEmpresa == IdEmpresa 
                          && q.IdSucursal == IdSucursal 
                          && q.IdBodega == IdBodega 
                          && q.IdCbteVta == IdCteVta
                          select q).Count();
                if (val > 0)
                    return false;
                else
                    return true;
                
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<vwFa_FacturasConDevolucionxItemSaldos_Info> Get_List_Fa_FacturasConDevolucionxItemSaldos(int IdEmpresa, int IdSucursal, int IdBodega, Decimal IdCteVta) 
        {
            try
            {
                List<vwFa_FacturasConDevolucionxItemSaldos_Info> List = new List<vwFa_FacturasConDevolucionxItemSaldos_Info>();
                EntitiesFacturacion fac = new EntitiesFacturacion();
                var val = from q in fac.vwFa_FacturasConDevolucionxItemSaldos
                          where q.IdEmpresa == IdEmpresa 
                          && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega 
                          && q.IdCbteVta == IdCteVta
                          select q;
                foreach (var item in val)
                {
                    vwFa_FacturasConDevolucionxItemSaldos_Info info = new vwFa_FacturasConDevolucionxItemSaldos_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.dv_seguro=Convert.ToDouble( item.dv_seguro);
                    info.dv_flete=Convert.ToDouble(item.dv_flete);
                    info.dv_interes=Convert.ToDouble( item.dv_interes);
                    info.dv_OtroValor1=Convert.ToDouble( item.dv_OtroValor1);
                    info.dv_OtroValor2=Convert.ToDouble( item.dv_OtroValor2);
                    
                    info.vt_PorDesc = item.vt_PorDescUnitario;
                    info.vt_DescUni = item.vt_DescUnitario;

                    info.vt_iva = item.vt_iva;
                    info.IdCbteVta = item.IdCbteVta;
                    info.vt_cantidad = item.vt_cantidad;
                    info.dv_cantidad = item.dv_cantidad;
                    info.dv_saldo = item.dv_saldo;
                    info.vt_Precio = item.vt_Precio;
                    info.vt_PrecioFinal = item.vt_PrecioFinal;
                    List.Add(info);
                }
                return List;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<vwFa_FacturasConDevolucionxItemSaldos_Info> Get_List_Fa_FacturasConDevolucionxItemSaldos(int IdEmpresa, int IdSucursal, int IdBodega, Decimal IdCteVta, decimal IdDevolucion)
        {
            try
            {
                List<vwFa_FacturasConDevolucionxItemSaldos_Info> List = new List<vwFa_FacturasConDevolucionxItemSaldos_Info>();
                EntitiesFacturacion fac = new EntitiesFacturacion();
                var val = from q in fac.vwFa_FacturasConDevolucionxItemConsulta
                          where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega 
                          && q.IdCbteVta == IdCteVta && q.IdDevolucion == IdDevolucion
                          select q;
                foreach (var item in val)
                {
                    vwFa_FacturasConDevolucionxItemSaldos_Info info = new vwFa_FacturasConDevolucionxItemSaldos_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.dv_seguro = Convert.ToDouble(item.dv_seguro);
                    info.dv_flete = Convert.ToDouble(item.dv_flete);
                    info.dv_interes = Convert.ToDouble(item.dv_interes);
                    info.dv_OtroValor1 = Convert.ToDouble(item.dv_OtroValor1);
                    info.dv_OtroValor2 = Convert.ToDouble(item.dv_OtroValor2);
                    info.vt_PorDesc = item.vt_PorDescUnitario;
                    info.vt_DescUni = item.vt_DescUnitario;
                     info.vt_iva = item.vt_iva;
                    info.IdCbteVta = item.IdCbteVta;
                    info.vt_cantidad = item.vt_cantidad;
                    info.dv_cantidad = item.dv_cantidad;
                    info.dv_saldo = item.dv_saldo;
                    info.vt_Precio = item.vt_Precio;
                    info.vt_PrecioFinal = item.vt_PrecioFinal;

                    List.Add(info);
                }
                return List;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
