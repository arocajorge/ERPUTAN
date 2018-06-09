using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Caja;
using Core.Erp.Data.Caja;
using Core.Erp.Business.General;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;


namespace Core.Erp.Business.Caja
{
    
    public class caj_Caja_Movimiento_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        caj_Caja_Movimiento_Data data = new caj_Caja_Movimiento_Data();



        public List<caj_Caja_Movimiento_Info> Get_list_Ingreso(int IdEmpresa,DateTime FechaIni,DateTime FechaFin, ref string MensajeError)
        {
            try
            {
                return data.Get_list_Ingreso(IdEmpresa,FechaIni,FechaFin, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Ingreso", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Bus) };
            }

        }

        public List<caj_Caja_Movimiento_Info> Get_list_Egreso(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string MensajeError)
        {
            try
            {
                return data.Get_list_Egreso(IdEmpresa,FechaIni,FechaFin, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Egreso", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Bus) };
            }

        }

        public Boolean GrabarDB(ref caj_Caja_Movimiento_Info info, ref string MensajeError)
        {
            try
            {
                Boolean res = true;                               
                // grabar diario caja
                ct_Cbtecble_Bus CbteCble_Data = new ct_Cbtecble_Bus();
                decimal idCbteCble = 0;

                if (CbteCble_Data.GrabarDB(info.Info_CbteCble_x_Caja_Movi, ref idCbteCble, ref MensajeError))
                {
                    //  GrabarDB caja
                    info.IdCbteCble = idCbteCble;
                    info.IdTipocbte = info.Info_CbteCble_x_Caja_Movi.IdTipoCbte;

                    // optener el recibo opin 2017/03/24
                    Caj_Talonario_Recibo_Info Talonario_Info = new Caj_Talonario_Recibo_Info();
                    Caj_Talonario_Recibo_Bus Talonario_bus = new Caj_Talonario_Recibo_Bus();                   
                    string IdTipo_Docu = string.Empty;
                    if (info.cm_Signo == "+"){IdTipo_Docu = "RECIB_CAJA";}else { IdTipo_Docu = "VALE_CAJA"; }

                    info.IdPuntoVta = (info.IdPuntoVta == null) ? 1 : 0;

                    Talonario_Info  = Talonario_bus.Get_Ultimo_Recibo_No_Usado(info.IdEmpresa, (int)info.IdSucursal, (int)info.IdPuntoVta, IdTipo_Docu, ref MensajeError);
                    if (Talonario_Info != null)
                    {
                        info.IdRecibo = Talonario_Info.IdRecibo;     
                    }

                    if (data.GrabarDB(info, ref  MensajeError))
                    {
                        // cambio a usado el recibo optenido opin 2017/03/24
                        Talonario_Info.Usado = true;                        
                        Talonario_bus.ModificarDB(Talonario_Info, ref MensajeError);
                      
                        string mensaje = "";
                        cp_orden_pago_cancelaciones_Bus bus_pagoCance = new cp_orden_pago_cancelaciones_Bus();
                        
                        foreach (var item in info.List_OrdenCan)
                        {
                            
                            

                            if (item.IdOrdenPago_op > 0)
                            {
                                item.IdEmpresa_pago = info.Info_CbteCble_x_Caja_Movi.IdEmpresa;
                                item.IdCbteCble_pago = idCbteCble;
                                item.IdTipoCbte_pago = info.Info_CbteCble_x_Caja_Movi.IdTipoCbte;
                                bus_pagoCance.GuardarDB(item, info.Info_CbteCble_x_Caja_Movi.IdEmpresa, ref mensaje);
                            }
                            else
                            {
                                //// no hay OP hay q generarla
                                cp_orden_pago_Bus BusOP = new cp_orden_pago_Bus();
                                cp_orden_pago_Info InfoOP = new cp_orden_pago_Info();
                                cp_orden_pago_det_Info Info_det_OP = new cp_orden_pago_det_Info();
                                List<cp_orden_pago_det_Info> List_Info_det_OP = new List<cp_orden_pago_det_Info>();
                                decimal IdOP = 0;

                                InfoOP.IdEmpresa = info.Info_CbteCble_x_Caja_Movi.IdEmpresa;
                                InfoOP.IdEntidad = Convert.ToDecimal(item.IdEntidad);
                                InfoOP.IdEstadoAprobacion = "APRO";
                                InfoOP.IdFormaPago = "EFEC";
                                InfoOP.IdTipo_Persona = item.IdTipo_Persona;
                                InfoOP.IdOrdenPago = 0;
                                InfoOP.IdPersona = item.IdPersona;
                                InfoOP.IdTipo_op = item.IdTipo_op;
                                InfoOP.Observacion = "O/P x Generada por Cruze con EG/Cja..";
                                InfoOP.Saldo = 0;
                                InfoOP.Total_cancelado = Convert.ToDecimal(item.MontoAplicado);
                                InfoOP.Total_OP = Convert.ToDecimal(item.MontoAplicado);

                                /////////////

                                Info_det_OP.IdEmpresa = InfoOP.IdEmpresa;
                                Info_det_OP.IdOrdenPago = 0;
                                Info_det_OP.Secuencia = 1;

                                Info_det_OP.IdEmpresa_cxp = item.IdEmpresa_cxp;
                                Info_det_OP.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                                Info_det_OP.IdCbteCble_cxp = item.IdCbteCble_cxp;

                                Info_det_OP.Valor_a_pagar = item.MontoAplicado;
                                Info_det_OP.Referencia = "";

                                Info_det_OP.IdFormaPago = "EFEC";
                                Info_det_OP.Fecha_Pago = DateTime.Now;
                                Info_det_OP.IdEstadoAprobacion = "APRO";

                                Info_det_OP.Idbanco = 1;

                                Info_det_OP.IdUsuario_Aproba = "";
                                Info_det_OP.fecha_hora_Aproba = DateTime.Now;
                                Info_det_OP.Motivo_aproba = "x conciliacion con NC cxp";

                                List_Info_det_OP.Add(Info_det_OP);
                                InfoOP.Detalle = List_Info_det_OP;

                                BusOP.GuardaDB(InfoOP, ref IdOP, ref mensaje);



                                item.IdEmpresa_pago = info.Info_CbteCble_x_Caja_Movi.IdEmpresa;
                                item.IdCbteCble_pago = info.Info_CbteCble_x_Caja_Movi.IdCbteCble;
                                item.IdTipoCbte_pago = info.Info_CbteCble_x_Caja_Movi.IdTipoCbte;
                                item.IdEmpresa_op = InfoOP.IdEmpresa;
                                item.IdOrdenPago_op = IdOP;
                                item.Secuencia_op = Info_det_OP.Secuencia;
                                item.Observacion = "Cruze /Egr Caja";
                                bus_pagoCance.GuardarDB(item, info.Info_CbteCble_x_Caja_Movi.IdEmpresa, ref mensaje);

                                //info.DetalleMovCaja
                                
                                caj_Caja_Movimiento_det_Bus BusDetCaja = new caj_Caja_Movimiento_det_Bus();
                                BusDetCaja.ModificarDB_IdOP_x_Det(info.Info_CbteCble_x_Caja_Movi.IdEmpresa, info.Info_CbteCble_x_Caja_Movi.IdCbteCble, info.Info_CbteCble_x_Caja_Movi.IdTipoCbte, item.Secuencia, InfoOP.IdEmpresa, IdOP, ref mensaje);

                            }



                        }



                                                                 
                    }
                    else
                    {
                        res = false;                   
                    }
                }
                else
                {
                    res = false;               
                }                           
                return res;               
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Bus) };
            }

        }

        public Boolean ModificarDB(caj_Caja_Movimiento_Info info, ref string MensajeError)
        {
            try
            {
               return data.ModificarDB(info, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Bus) };
            }

        }

        public Boolean AnularDB(caj_Caja_Movimiento_Info info, ref string MensajeError)
        {
            try
            {
               return data.AnularDB(info, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Bus) };
            }

        }

        public caj_Caja_Movimiento_Info Get_Info_MovimientoCaja(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte, ref string MensajeError)
        {
            try
            {
                return data.Get_Info_MovimientoCaja(IdEmpresa, IdCbteCble, IdTipoCbte, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_MovimientoCaja_Rpt", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Bus) };
            }
        }

        public caj_rpt_Caja_Movimiento_Info Get_Info_MovimientoCaja_Rpt(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte, ref string MensajeError)
        {
            try
            {
              return data.Get_Info_MovimientoCaja_Rpt(IdEmpresa, IdCbteCble, IdTipoCbte, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_MovimientoCaja_Rpt", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Bus) };
            }

        }
     
        public List<vwcaj_MovCaja_x_Cobro_Info> Get_list_MovimientosCaja_x_Cobro(int Idempresa, int IdTipocbte_Caja, decimal IdCbteCble_Caja, ref string MensajeError)
        {
            try
            {
               return data.Get_list_MovimientosCaja_x_Cobro(Idempresa, IdTipocbte_Caja, IdCbteCble_Caja, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_MovimientosCaja_x_Cobro", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Bus) };
            }

        }

        public List<vwcaj_MovCaja_x_Cobro_Info> Get_list_MovimientosCaja_x_Cobro_Anticipo(int Idempresa, int IdTipocbte_Caja, decimal IdCbteCble_Caja, ref string MensajeError)
        {
            try
            {
                return data.Get_list_MovimientosCaja_x_Cobro_Anticipo(Idempresa, IdTipocbte_Caja, IdCbteCble_Caja, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_MovimientosCaja_x_Cobro_Anticipo", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Bus) };
            }

        }



        private Boolean Validar_y_corregir_objeto(ref caj_Caja_Movimiento_Info Caja_Movi_Info, ref string msg)
        {
            try
            {
                #region 'Validaciones'
                /*--- validaciones */


                if (Caja_Movi_Info.IdEmpresa <= 0 && Caja_Movi_Info.IdSucursal <= 0 )
                {
                    msg = "Error en la cabecera de fact uno de los PK es <=0";
                    return false;
                }



                if (Caja_Movi_Info.IdCaja <= 0)
                {
                    msg = "Erro en la cabecera de id caja es <=0";
                    return false;
                }



                if (Caja_Movi_Info.list_Caja_Movi_det.Count == 0)
                {
                    msg = "la factura no tiene detalle ";
                    return false;
                }


                foreach (var item in Caja_Movi_Info.list_Caja_Movi_det)
                {

                    if (item.cr_Valor == 0)
                    {
                        msg = "el valor id:" + item.IdCobro_tipo + " tiene cantidad cero ";
                    }

                    
                }

                /*--- Fin validaciones */


                /*--- corrigiendo data */

                Caja_Movi_Info.Estado = (string.IsNullOrEmpty(Caja_Movi_Info.Estado) == true) ? "A" : Caja_Movi_Info.Estado;

                if (Caja_Movi_Info.IdTipo_Persona == "" || Caja_Movi_Info.IdTipo_Persona == null)
                {
                    tb_persona_tipo_Bus BusTipoPersona = new tb_persona_tipo_Bus();
                    tb_persona_tipo_Info InfoTipoPersona = new tb_persona_tipo_Info();
                    InfoTipoPersona = BusTipoPersona.Get_List_persona_tipo().FirstOrDefault();
                    Caja_Movi_Info.IdTipo_Persona = InfoTipoPersona.IdTipo_Persona;
                }


                if (Caja_Movi_Info.IdPersona <= 0 )
                {
                    tb_persona_bus BusPersona = new tb_persona_bus();
                    tb_persona_Info InfoPersona = new tb_persona_Info();
                    InfoPersona = BusPersona.Get_Info_Persona(1);
                    Caja_Movi_Info.IdPersona = InfoPersona.IdPersona;
                }
               
               

                /*--- corrigiendo data */

                #endregion

                return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_y_corregir_objeto", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Bus) };


            }
        }

        public caj_Caja_Movimiento_Bus(){}
    }
}
