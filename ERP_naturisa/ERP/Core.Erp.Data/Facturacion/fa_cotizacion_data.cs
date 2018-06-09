using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.Facturacion
{
    public class fa_cotizacion_data
    {
        string mensaje = "";

        public List<fa_cotizacion_info> Get_List_cotizacion(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin
            , DateTime FechaIni, DateTime FechaFin)
        {

            try
            {
                List<fa_cotizacion_info> CotizacionInfo = new List<fa_cotizacion_info>();

                EntitiesFacturacion OEFAC = new EntitiesFacturacion();
                //
                var SelectCotizacion = from q in OEFAC.vwfa_cotizacion_detalle select q ;
                if (IdSucursalIni == 0)
                {
                   SelectCotizacion = from q in OEFAC.vwfa_cotizacion_detalle
                                      where q.IdEmpresa == IdEmpresa && q.cc_fecha >= FechaIni && q.cc_fecha <= FechaFin
                                           select q;

                }
                else
                {
                    //
                    SelectCotizacion = from q in OEFAC.vwfa_cotizacion_detalle
                                           where q.IdEmpresa == IdEmpresa
                                           && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                                           && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                           && q.cc_fecha >= FechaIni && q.cc_fecha <= FechaFin
                                           select q;
                }


                var CabeceraCotizacion = from cab in SelectCotizacion
                                         group cab by new
                                         {
                                             cab.IdEmpresa,
                                             cab.IdSucursal,
                                             cab.IdBodega,
                                             cab.bo_Descripcion,
                                             cab.IdCotizacion,
                                             cab.pe_nombre,
                                             cab.pe_apellido
                                           ,
                                             cab.Ve_Vendedor,
                                             cab.Su_Descripcion,
                                             cab.cc_dirigidoA,
                                             cab.CodCotizacion,
                                             cab.cc_fecha,
                                             cab.cc_fechaVencimiento,
                                             cab.cc_diasPlazo,
                                             cab.cc_observacion
                                          ,
                                             cab.cc_estado
                                         }
                                             into grouping
                                             select new { grouping.Key, subototal = grouping.Sum(p => p.dc_subtotal), iva = grouping.Sum(p => p.dc_iva), Total = grouping.Sum(p => p.dc_total) };


                foreach (var item in CabeceraCotizacion)
                {
                    fa_cotizacion_info info = new fa_cotizacion_info();


                    List<fa_cotizacion_det_info> ListDet_coti = new List<fa_cotizacion_det_info>();


                    info.IdCotizacion = item.Key.IdCotizacion;
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.IdBodega = item.Key.IdBodega;
                    info.Bodega = item.Key.bo_Descripcion;
                    info.Cliente = item.Key.pe_apellido + "" + item.Key.pe_nombre;
                    info.Vendedor = item.Key.Ve_Vendedor;
                    info.Sucursal = item.Key.Su_Descripcion;
                    info.cc_dirigidoA = item.Key.cc_dirigidoA;
                    info.cc_fecha = item.Key.cc_fecha;
                    info.CodCotizacion = item.Key.CodCotizacion;
                    info.cc_fechaVencimiento = item.Key.cc_fechaVencimiento;
                    info.cc_diasPlazo = item.Key.cc_diasPlazo;
                    info.cc_observacion = item.Key.cc_observacion;
                    info.subtotal = Convert.ToDecimal(item.subototal);
                    info.cc_estado = item.Key.cc_estado;
                    info.iva = item.iva;
                    info.total = item.Total;


                    info.lista_detalle = ListDet_coti;


                    CotizacionInfo.Add(info);


                }

                return CotizacionInfo;
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

        public List<fa_cotizacion_info> Get_List_cotizacion_para_facturacion(int IdEmpresa, int IdSucursal, int IdBodega, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<fa_cotizacion_info> CotizacionInfo = new List<fa_cotizacion_info>();

                EntitiesFacturacion OEFAC = new EntitiesFacturacion();
                //
                var SelectCotizacion = from q in OEFAC.vwfa_cotizacion_detalle where q.IdEmpresa==IdEmpresa && q.cc_estado=="A"
                                       && q.IdBodega==IdBodega && q.IdSucursal==IdSucursal && q.cc_fecha>=FechaIni && q.cc_fecha<=FechaFin
                                      select q;
                var TablaInte = from q in OEFAC.fa_factura_x_fa_cotizacion
                                where q.fa_IdEmpresa == IdEmpresa && q.fa_IdSucursal == IdSucursal && q.fa_IdBodega == IdBodega
                                select q;
                var CabeceraCotizacion = from cab in SelectCotizacion
                                         group cab by new
                                         {
                                             cab.IdEmpresa,
                                             cab.IdSucursal,
                                             cab.IdBodega,
                                             cab.bo_Descripcion,
                                             cab.IdCotizacion,
                                             cab.pe_nombre,
                                             cab.pe_apellido
                                           ,
                                             cab.Ve_Vendedor,
                                             cab.Su_Descripcion,
                                             cab.cc_dirigidoA,
                                             cab.CodCotizacion,
                                             cab.cc_fecha,
                                             cab.cc_fechaVencimiento,
                                             cab.cc_diasPlazo,
                                             cab.cc_observacion
                                          ,
                                             cab.cc_estado
                                         }
                                             into grouping
                                             select new { grouping.Key, subototal = grouping.Sum(p => p.dc_subtotal), iva = grouping.Sum(p => p.dc_iva), Total = grouping.Sum(p => p.dc_total) };

                foreach (var item in CabeceraCotizacion)
                {
                    fa_cotizacion_info info = new fa_cotizacion_info();

                    List<fa_cotizacion_det_info> ListDet_coti = new List<fa_cotizacion_det_info>();


                    info.IdCotizacion = item.Key.IdCotizacion;
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.IdBodega = item.Key.IdBodega;
                    info.Bodega = item.Key.bo_Descripcion;
                    info.Cliente = item.Key.pe_apellido + "" + item.Key.pe_nombre;
                    info.Vendedor = item.Key.Ve_Vendedor;
                    info.Sucursal = item.Key.Su_Descripcion;
                    info.cc_dirigidoA = item.Key.cc_dirigidoA;
                    info.cc_fecha = item.Key.cc_fecha;
                    info.CodCotizacion = item.Key.CodCotizacion;
                    info.cc_fechaVencimiento = item.Key.cc_fechaVencimiento;
                    info.cc_diasPlazo = item.Key.cc_diasPlazo;
                    info.cc_observacion = item.Key.cc_observacion;
                    info.subtotal = Convert.ToDecimal(item.subototal);
                    info.cc_estado = item.Key.cc_estado;
                    info.iva = item.iva;
                    info.total = item.Total;
                    
                    info.lista_detalle = ListDet_coti;
                    var ww = (from q in TablaInte
                              where q.cc_IdCotizacion == item.Key.IdCotizacion
                             select q).Count();
                    if (Convert.ToInt32(ww) == 0)
                    {
                        CotizacionInfo.Add(info);
                    }

                }

                return CotizacionInfo;
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

        public Boolean ActualizarEstado(int IdEmpresa, fa_cotizacion_info oDeT)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_cotizacion.FirstOrDefault(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdCotizacion == oDeT.IdCotizacion);
                    if (contact != null)
                    {
                        contact.MotivoAnu = oDeT.MotivoAnu;
                        contact.ip = oDeT.ip;
                        contact.nom_pc = oDeT.nom_pc;
                        contact.Fecha_UltAnu = oDeT.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = oDeT.IdUsuarioUltAnu;
                        contact.cc_estado = "I";
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


        public Boolean ValidarCodCot(string CodCotizacion)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    EntitiesFacturacion factCot = new EntitiesFacturacion();
                    var select = (from C in factCot.fa_cotizacion
                                  where C.CodCotizacion == CodCotizacion
                                  select C.CodCotizacion).Count();
                    var id = (from C in factCot.fa_cotizacion
                                  where C.CodCotizacion == CodCotizacion
                                  select C.IdCotizacion).Max();
                    //IdCotizacion = id;
                    if (select == 0)
                    { 
                        return false;
                    } else 
                    {
                        return true;
                    }
                }

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
        
        public Boolean GrabarDB(fa_cotizacion_info info, ref decimal IdNumCotizacion, ref string msgs)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    EntitiesFacturacion factCot = new EntitiesFacturacion();
                    

                        var ID = ((from C in factCot.fa_cotizacion
                                   where C.IdEmpresa == info.IdEmpresa && C.IdBodega == info.IdBodega && C.IdSucursal == info.IdSucursal
                                  select C.IdCotizacion).ToList().Count()==0)?1:((from C in factCot.fa_cotizacion
                                  where C.IdEmpresa == info.IdEmpresa && C.IdBodega == info.IdBodega && C.IdSucursal == info.IdSucursal
                                  select C.IdCotizacion).Max() + 1);
                    
                    if (ValidarCodCot(info.CodCotizacion)) { msgs = "\n EL Codigo " + info.CodCotizacion + " de la Cotizacion ya esta en Uso. \n Ingrese otro."; return false; }
                    
                    

                    var addressG = new fa_cotizacion();
                    addressG.IdEmpresa = info.IdEmpresa;
                    addressG.IdSucursal = info.IdSucursal;
                    addressG.IdBodega = info.IdBodega;
                    addressG.IdCotizacion = IdNumCotizacion = ID;
                    
                    addressG.IdCliente = info.IdCliente;
                    addressG.IdVendedor = info.IdVendedor;
                    addressG.cc_fecha = Convert.ToDateTime(info.cc_fecha.ToShortDateString()) ;
                    addressG.cc_diasPlazo = Convert.ToInt16(info.cc_diasPlazo);
                    addressG.cc_dirigidoA = info.cc_dirigidoA;
                    addressG.cc_estado = "A";
                    addressG.cc_fechaVencimiento = Convert.ToDateTime(info.cc_fechaVencimiento.ToShortDateString()) ;
                    addressG.cc_observacion = info.cc_observacion;
                    addressG.cc_tipopago = info.cc_tipopago;
                    addressG.cc_transporte = Convert.ToDouble( info.cc_transporte);
                    addressG.cc_interes = info.cc_interes;
                    addressG.cc_otroValor1 = info.cc_otroValor1;
                    addressG.cc_otroValor2 = info.cc_otroValor2;
                    addressG.CodCotizacion = (info.CodCotizacion=="")?"COT-"+Convert.ToString(info.IdCotizacion):info.CodCotizacion;
                    info.CodCotizacion = addressG.CodCotizacion;
                    addressG.Fecha_Transac = DateTime.Now;
                    addressG.ip = info.ip;
                    addressG.IdUsuario = info.IdUsuario;
                    addressG.nom_pc = info.nom_pc;
                    context.fa_cotizacion.Add(addressG);
                    context.SaveChanges();
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

        public fa_cotizacion_info Get_Info_cotizacion(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCotizacion)
        {
            try
            {
                fa_cotizacion_info infCot = new fa_cotizacion_info();
                EntitiesFacturacion entitieFa = new EntitiesFacturacion();
                var selectBaParam = from C in entitieFa.fa_cotizacion
                                    where C.IdEmpresa == IdEmpresa
                                    && C.IdSucursal == IdSucursal 
                                    && C.IdBodega == IdBodega 
                                    && C.IdCotizacion == IdCotizacion
                                    select C;

                foreach (var item in selectBaParam)
                {

                    infCot.IdEmpresa = item.IdEmpresa;
                    infCot.IdSucursal = item.IdSucursal;
                    infCot.IdBodega = item.IdBodega;
                    infCot.IdCotizacion = item.IdCotizacion;
                    infCot.IdCliente = Convert.ToInt32(item.IdCliente);
                    infCot.IdVendedor = Convert.ToInt32(item.IdVendedor);
                    infCot.cc_fecha = Convert.ToDateTime(item.cc_fecha);
                    infCot.cc_diasPlazo = Convert.ToInt16(item.cc_diasPlazo);
                    infCot.cc_dirigidoA = item.cc_dirigidoA;
                    infCot.cc_estado = item.cc_estado;
                    infCot.cc_fechaVencimiento = Convert.ToDateTime(item.cc_fechaVencimiento);
                    infCot.cc_observacion = item.cc_observacion;
                    infCot.cc_tipopago = item.cc_tipopago;
                    infCot.cc_otroValor1 = Convert.ToDouble( item.cc_otroValor1);
                    infCot.cc_otroValor2 = Convert.ToDouble(item.cc_otroValor2);
                    infCot.cc_transporte = Convert.ToDouble(item.cc_transporte);
                    infCot.cc_interes = Convert.ToDouble(item.cc_interes);
                    infCot.CodCotizacion = item.CodCotizacion;
                    infCot.ip = item.ip;
                    infCot.IdUsuario = item.IdUsuario;
                    infCot.nom_pc = item.nom_pc;
                }
                return (infCot);
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

        public Boolean ModificarDB(fa_cotizacion_info info, ref string msgs)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_cotizacion.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa
                        && cot.IdCotizacion == info.IdCotizacion && cot.IdSucursal == info.IdSucursal && cot.IdBodega == info.IdBodega);

                    if (contact != null)
                    {
                        contact.IdCliente = info.IdCliente;
                        contact.IdVendedor = info.IdVendedor;
                        contact.cc_fecha = Convert.ToDateTime(info.cc_fecha.ToShortDateString());
                        contact.cc_diasPlazo = Convert.ToInt16(info.cc_diasPlazo);
                        contact.cc_dirigidoA = info.cc_dirigidoA;
                        contact.cc_fechaVencimiento = Convert.ToDateTime(info.cc_fechaVencimiento.ToShortDateString());
                        contact.cc_observacion = info.cc_observacion;
                        contact.cc_tipopago = info.cc_tipopago;
                        contact.cc_transporte = info.cc_transporte;
                        contact.cc_interes = info.cc_interes;
                        contact.cc_otroValor1 = info.cc_otroValor1;
                        contact.cc_otroValor2 = info.cc_otroValor2;
                        contact.CodCotizacion = info.CodCotizacion;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
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

        public Boolean AnularDB(fa_cotizacion_info info, ref string mensajeE)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_cotizacion.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdCotizacion == info.IdCotizacion && cot.IdSucursal == info.IdSucursal && cot.IdBodega == info.IdBodega);
                    if (contact != null)
                    {
                        contact.cc_estado = "I";
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.MotivoAnu = info.MotivoAnu;
                        contact.IdUsuarioUltAnu = info.IdUsuario;
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
                mensajeE = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeE);
                throw new Exception(ex.ToString());
            }
        }

    }
}
