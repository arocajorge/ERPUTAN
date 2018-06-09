using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
namespace Core.Erp.Business.Roles_Fj
{
   
   public class ro_Remplazo_x_emplado_Bus
   {
       ro_Remplazo_x_emplado_Data data = new ro_Remplazo_x_emplado_Data();
       ro_Empleado_Novedad_Bus novedad_bus = new ro_Empleado_Novedad_Bus();
       ro_Empleado_Novedad_Det_Bus novedad_det_bus = new ro_Empleado_Novedad_Det_Bus();
       ro_Parametros_Bus bus_parametros = new ro_Parametros_Bus();
       ro_Parametros_Info info_parametros = new ro_Parametros_Info();
       cp_orden_pago_tipo_x_empresa_Bus bus_ordenpagoTipo = new cp_orden_pago_tipo_x_empresa_Bus();
       cp_orden_pago_tipo_x_empresa_Info infoOptipo = new cp_orden_pago_tipo_x_empresa_Info();
       cp_orden_pago_Info CabOP = new cp_orden_pago_Info();
       ct_Cbtecble_Info infocont = new ct_Cbtecble_Info();



       cp_orden_pago_Bus bus_op = new cp_orden_pago_Bus();
       ct_Cbtecble_Bus bus_ct = new ct_Cbtecble_Bus();

       string error = "";
       string mensaje = "";
       public bool Guardar_DB(ro_Remplazo_x_emplado_Info info, ref int Id_Remplazo, ref decimal id_novedad)
        {
            try
            {
                decimal iddiario=0;
                decimal idop=0;
                if (data.Guardar_DB(info, ref Id_Remplazo))
                {
                    if (info.Descuenta_rol == true)
                    {
                            ro_Empleado_Novedad_Info info_novedad = new ro_Empleado_Novedad_Info();
                            info_novedad = Get_novedad_info(info);
                           if (novedad_bus.GrabarDB(info_novedad, ref id_novedad, ref error))
                               {                                                           
                                    info_novedad.InfoNovedadDet.IdNovedad = id_novedad;
                                    info_novedad.InfoNovedadDet.IdEmpresa = info.IdEmpresa;
                                    if (novedad_det_bus.GrabarDB(info_novedad.InfoNovedadDet, ref error))
                                      {
                                           info.IdNovedad = id_novedad;
                                           info.Id_remplazo = Id_Remplazo;
                                           Modificar_DB_IdNovedad(info);
                                       }
                                }
                    }

                      GetOrdenPao(info);
                      GetAsientoContable(info);
                    if (bus_ct.GrabarDB(infocont, ref iddiario, ref mensaje))
                    {
                        foreach (var item in CabOP.Detalle)
                        {
                            item.IdTipoCbte_cxp = infocont.IdTipoCbte;
                            item.IdCbteCble_cxp = iddiario;
                        }

                        if (bus_op.GuardaDB(CabOP, ref idop, ref mensaje))
                        {
                           
                        }

                    }
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
               
            }
        }

        public bool Modificar_DB(ro_Remplazo_x_emplado_Info info)
        {
            try
            {
                decimal id_novedad = 0;
                ro_Empleado_Novedad_Info info_novedad = new ro_Empleado_Novedad_Info();

                if (data.Modificar_DB(info))
                {
                    if (info.Descuenta_rol == true)
                    {
                        info_novedad = Get_novedad_info(info);
                        if (info.IdNovedad != null && info.IdNovedad > 0)// si existe novedad creada
                        {
                            if (novedad_bus.ModificarDB(info_novedad))
                            {
                                info_novedad.InfoNovedadDet.IdNovedad = info_novedad.IdNovedad;
                                if (novedad_det_bus.ModificarDB(info_novedad.InfoNovedadDet, ref error))
                                {
                                }
                            }

                        }
                        else// si se actualizo el registro y no existe novedad de descuento
                        {

                                info_novedad = Get_novedad_info(info);
                                if (novedad_bus.GrabarDB(info_novedad, ref id_novedad, ref error))
                                {
                                    info_novedad.InfoNovedadDet.IdNovedad = id_novedad;
                                    info_novedad.InfoNovedadDet.IdEmpresa = info.IdEmpresa;
                                    if (novedad_det_bus.GrabarDB(info_novedad.InfoNovedadDet, ref error))
                                    {
                                        info.IdNovedad = id_novedad;
                                        Modificar_DB_IdNovedad(info);
                                    }
                                }
                            

                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
               
            }
        }
        public bool Anular_DB(ro_Remplazo_x_emplado_Info info)
        {
            try
            {
                return data.Anular_DB(info);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
                
            }
        }

        public List<ro_Remplazo_x_emplado_Info> listado_remplazo(int IdEmpresa, DateTime fecha_desde, DateTime fecha_hasta)
        {
            try
            {
                return data.listado_remplazo(IdEmpresa, fecha_desde, fecha_hasta);
             }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
        public List<ro_Remplazo_x_emplado_Info> listado_remplazo_Historico(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return data.listado_remplazo_Historico(IdEmpresa, IdEmpleado);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool Modificar_DB_IdNovedad(ro_Remplazo_x_emplado_Info info)
        {
            try
            {

                return data.Modificar_DB_IdNovedad(info);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);

            }
        }

        public bool Get_si_existe_remplazo_activo(ro_Remplazo_x_emplado_Info info)
        {
            try
            {
                return data.Get_si_existe_remplazo_activo(info);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
        #region Armar la novedad si se descuenta al empleado
        public ro_Empleado_Novedad_Info Get_novedad_info(ro_Remplazo_x_emplado_Info info)
        {
            try
            {
                ro_Empleado_Novedad_Info novedad_info = new ro_Empleado_Novedad_Info();
                novedad_info.IdEmpresa = info.IdEmpresa;
                novedad_info.IdEmpleado = info.IdEmpleado;
                novedad_info.IdNomina_Tipo =(int) info.IdNomina_Tipo;
                novedad_info.Fecha = (DateTime)info.Fecha_descuenta_rol;
                novedad_info.TotalValor = info.Total_pagar_remplazo;
                novedad_info.Fecha_PrimerPago =(DateTime) info.Fecha_descuenta_rol;
                novedad_info.NumCoutas = 1;
                novedad_info.Fecha_Transac = DateTime.Now;
                novedad_info.IdUsuario = info.IdUsuario;
                novedad_info.Estado = "A";
                novedad_info.IdCalendario = info.IdPeriodo.ToString();
                novedad_info.IdNomina_Tipo =(int) info.IdNomina_Tipo;
                novedad_info.IdNomina_TipoLiqui =(int) info.IdNomina_TipoLiqui;
                novedad_info.IdUsuario = info.IdUsuario;
                if (info.IdNovedad != null)
                {
                    novedad_info.IdNovedad = (decimal)info.IdNovedad;
                }
               // creo el detalle de la novedad.
                ro_Empleado_Novedad_Det_Info Novedad_detalle_info = new ro_Empleado_Novedad_Det_Info();
                Novedad_detalle_info.IdEmpleado = info.IdEmpresa;
                Novedad_detalle_info.IdEmpleado = info.IdEmpleado;
                Novedad_detalle_info.Secuencia = 1;
                Novedad_detalle_info.IdRubro = info.IdRubro;
                Novedad_detalle_info.Valor = info.Total_pagar_remplazo;
                Novedad_detalle_info.EstadoCobro = "PEN";
                Novedad_detalle_info.Estado = "A";
                Novedad_detalle_info.IdCalendario = info.IdPeriodo.ToString();
                Novedad_detalle_info.Observacion = info.Observacion;
                novedad_info.InfoNovedadDet = Novedad_detalle_info;
              //  novedad_info.InfoNovedadDet
                return novedad_info;

            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        #endregion
        public List<ro_Remplazo_x_emplado_Info> Get_lista_remplazo_para_reversar_horas_extras(int IdEmpresa, DateTime Fecha_Maxima, DateTime Fecha_minina)
        {
            try
            {
                return data.Get_lista_remplazo_para_reversar_horas_extras(IdEmpresa, Fecha_Maxima, Fecha_minina);
            }
            catch (Exception ex)
            {
                
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

       private cp_orden_pago_Info GetOrdenPao(ro_Remplazo_x_emplado_Info info)
       {

           try
           {
               
               info_parametros = bus_parametros.Get_Parametros(info.IdEmpresa);
               infoOptipo = bus_ordenpagoTipo.Get_Info_orden_pago_tipo_x_empresa(info.IdEmpresa, info_parametros.IdTipoOP_PagoTerceros);

               CabOP = new cp_orden_pago_Info();
               CabOP.IdTipoFlujo = info_parametros.IdTipoFlujoOP_PagoTerceros;          
               CabOP.IdEmpresa = info.IdEmpresa;
               CabOP.IdOrdenPago = 0;
               CabOP.IdTipo_op = info_parametros.IdTipoOP_PagoTerceros;
               CabOP.IdProveedor = info.IdEmpleado;
               CabOP.Observacion =info.Observacion;
               CabOP.Fecha = info.Fecha;
               CabOP.IdFormaPago = info_parametros.IdFormaOP_PagoTerceros;
               CabOP.Fecha_Pago = info.Fecha;
               CabOP.IdBanco = info_parametros.IdBancoOP_PagoTerceros;
               CabOP.IdEstadoAprobacion = "PENDI";            
               CabOP.IdPersona = info.IdPersona;
               CabOP.IdTipo_Persona = "EMPLEA";
               CabOP.IdEntidad = info.IdEmpleado_Remplazo;
               CabOP.IdUsuario = info.IdUsuario;


               cp_orden_pago_det_Info detalleop = new cp_orden_pago_det_Info();
               detalleop.IdEmpresa = info.IdEmpresa;
               detalleop.Secuencia = 1;
               detalleop.IdEmpresa_cxp = info.IdEmpresa;
               detalleop.Valor_a_pagar =Convert.ToDouble( info.Total_pagar_remplazo);
               detalleop.Referencia = "Pago de eventuale";
               detalleop.IdFormaPago = info_parametros.IdFormaOP_PagoTerceros;
               detalleop.Fecha_Pago =Convert.ToDateTime( info.Fecha);
               detalleop.Idbanco = info_parametros.IdBancoOP_PagoTerceros;
               detalleop.IdEstadoAprobacion = "PENDI";
               CabOP.Detalle.Add(detalleop);
               return CabOP;


           }
           catch (Exception ex)
           {
               
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
           }
       }



       private ct_Cbtecble_Info GetAsientoContable(ro_Remplazo_x_emplado_Info info)
       {
           try
           {

                infocont = new ct_Cbtecble_Info();
               infocont.IdEmpresa = info.IdEmpresa;
               infocont.IdTipoCbte =Convert.ToInt32( info_parametros.IdTipoCbte_AsientoSueldoXPagar);
               infocont.IdPeriodo =Convert.ToInt32( info.Fecha.Year.ToString() + info.Fecha.Month.ToString().PadLeft(2, '0'));
               infocont.cb_Valor =Convert.ToDouble( info.Total_pagar_remplazo);
               infocont.cb_Fecha =Convert.ToDateTime( info.Fecha);
               infocont.cb_Observacion = "Pago de remplado de " + info.pe_nombreCompleto;
               info.Estado = "A";
               infocont.Anio = info.Fecha.Year;
               infocont.Mes = info.Fecha.Year;
               infocont.IdUsuario = info.IdUsuario;
               infocont.cb_FechaTransac = DateTime.Now;
               infocont.IdUsuario = "";
               infocont.Estado = "A";
               infocont.Mayorizado = "N";
               infocont.IdUsuario = info.IdUsuario;
               ct_Cbtecble_det_Info infocont_deth = new ct_Cbtecble_det_Info();
               infocont_deth.IdEmpresa = info.IdEmpresa;
               infocont_deth.IdTipoCbte = Convert.ToInt32(info_parametros.IdTipoCbte_AsientoSueldoXPagar);
               infocont_deth.IdCtaCble=infoOptipo.IdCtaCble;
               infocont_deth.dc_Valor = Convert.ToDouble(info.Total_pagar_remplazo);
               infocont_deth.dc_Observacion = "Pago de remplazo " + info.pe_nombreCompleto;
               infocont_deth.secuencia = 1;
               infocont._cbteCble_det_lista_info.Add(infocont_deth);



               ct_Cbtecble_det_Info infocont_detd = new ct_Cbtecble_det_Info();
               infocont_detd.IdEmpresa = info.IdEmpresa;
               infocont_detd.IdTipoCbte = Convert.ToInt32(info_parametros.IdTipoCbte_AsientoSueldoXPagar);
               infocont_detd.IdCtaCble = infoOptipo.IdCtaCble;
               infocont_detd.dc_Valor = Convert.ToDouble(info.Total_pagar_remplazo) * -1;
               infocont_detd.dc_Observacion = "Pago de remplazo " + info.pe_nombreCompleto;
               infocont_detd.secuencia = 2;

               infocont._cbteCble_det_lista_info.Add(infocont_detd);
               infocont_detd.secuencia = 2;

               return infocont;
           }
           catch (Exception ex)
           {

               return new ct_Cbtecble_Info();
           }

       }
      
   }
}
