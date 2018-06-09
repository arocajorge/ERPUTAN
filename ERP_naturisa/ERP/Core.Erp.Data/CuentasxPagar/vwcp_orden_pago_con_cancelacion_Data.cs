using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Bancos;
namespace Core.Erp.Data.CuentasxPagar
{

    public class vwcp_orden_pago_con_cancelacion_Data
    {
        string mensaje = "";

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_Con_Saldo
            (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdEstado_Aprobacion, string IdUsuario)
        {
            try
            {
                decimal IdPersonaIni = 0;
                decimal IdPersonaFin = 0;
                decimal IdEntidadIni = 0;
                decimal IdEntidadFin = 0;

                if (IdTipoPersona == "" || IdTipoPersona == null)
                {
                    IdPersonaIni = 1;
                    IdPersonaFin = 999999;
                    IdEntidadIni = 1;
                    IdEntidadFin = 999999;
                }
                else
                {

                    IdPersonaIni = IdPersona;
                    IdPersonaFin = IdPersona;
                    IdEntidadIni = IdEntidad;
                    IdEntidadFin = IdEntidad;
                }
                List<vwcp_orden_pago_con_cancelacion_Info> lM = new List<vwcp_orden_pago_con_cancelacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                db.SetCommandTimeOut(3000);

                var select_ = (from T in db.spcp_Get_Data_orden_pago_con_cancelacion_data(IdEmpresa, IdPersonaIni, IdPersonaFin, IdTipoPersona, IdEntidadIni, IdEntidadFin, IdEstado_Aprobacion, IdUsuario, false)

                               select T
                               );
                foreach (var item in select_)
                {
                    vwcp_orden_pago_con_cancelacion_Info dat = new vwcp_orden_pago_con_cancelacion_Info();


                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.Referencia = item.Referencia;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.IdTipoPersona = item.IdTipoPersona;
                    dat.IdPersona = Convert.ToDecimal(item.IdPersona);
                    dat.IdEntidad = item.IdEntidad;
                    dat.Fecha_OP = item.Fecha_OP;
                    dat.Fecha_Fa_Prov = Convert.ToDateTime(item.Fecha_Fa_Prov);
                    dat.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.Fecha_Venc_Fac_Prov);
                    dat.Observacion = item.Observacion;
                    dat.Nom_Beneficiario = item.Nom_Beneficiario;
                    dat.Girar_Cheque_a = item.Girar_Cheque_a;
                    dat.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);
                    dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    dat.Total_cancelado_OP = item.Total_cancelado_OP;
                    dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.IdFormaPago = item.IdFormaPago;
                    dat.Fecha_Pago = item.Fecha_Pago;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                    dat.Cbte_cxp = item.Cbte_cxp;
                    dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    dat.IdCbteCble_cxp = item.IdCbteCble_cxp;
                    dat.IdBanco = item.IdBanco;
                    dat.Referencia2 = item.Referencia2;

                    lM.Add(dat);

                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion
          (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdEstado_Aprobacion, string IdUsuario)
        {


            try
            {

                decimal IdPersonaIni = 0;
                decimal IdPersonaFin = 0;
                decimal IdEntidadIni = 0;
                decimal IdEntidadFin = 0;


                if (IdTipoPersona == "" || IdTipoPersona == null)
                {
                    IdPersonaIni = 1;
                    IdPersonaFin = 999999;
                    IdEntidadIni = 1;
                    IdEntidadFin = 999999;
                    IdTipoPersona = "";

                }
                else
                {

                    IdPersonaIni = IdPersona;
                    IdPersonaFin = IdPersona;
                    IdEntidadIni = IdEntidad;
                    IdEntidadFin = IdEntidad;
                }


                List<vwcp_orden_pago_con_cancelacion_Info> lM = new List<vwcp_orden_pago_con_cancelacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
                db.SetCommandTimeOut(3000);
                var select_ = (from T in db.spcp_Get_Data_orden_pago_con_cancelacion_data(IdEmpresa, IdPersonaIni, IdPersonaFin, IdTipoPersona, IdEntidadIni, IdEntidadFin, IdEstado_Aprobacion, IdUsuario, true)

                               select T
                               );


                foreach (var item in select_)
                {
                    vwcp_orden_pago_con_cancelacion_Info dat = new vwcp_orden_pago_con_cancelacion_Info();


                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.Referencia = item.Referencia;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.IdTipoPersona = item.IdTipoPersona;
                    dat.IdPersona = Convert.ToDecimal(item.IdPersona);
                    dat.IdEntidad = item.IdEntidad;
                    dat.Fecha_OP = item.Fecha_OP;
                    dat.Fecha_Fa_Prov = Convert.ToDateTime(item.Fecha_Fa_Prov);
                    dat.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.Fecha_Venc_Fac_Prov);
                    dat.Observacion = item.Observacion;
                    dat.Nom_Beneficiario = item.Nom_Beneficiario;
                    dat.Girar_Cheque_a = item.Girar_Cheque_a;
                    dat.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);
                    dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    dat.Total_cancelado_OP = item.Total_cancelado_OP;
                    dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.IdFormaPago = item.IdFormaPago;
                    dat.Fecha_Pago = item.Fecha_Pago;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                    dat.Cbte_cxp = item.Cbte_cxp;
                    dat.Estado = item.Estado;
                    dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    dat.IdCbteCble_cxp = item.IdCbteCble_cxp;

                    dat.IdEstadoAprobacion_AUX = item.IdEstadoAprobacion;
                    dat.IdBanco = item.IdBanco;
                    dat.Referencia2 = item.Referencia2;



                    lM.Add(dat);

                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_para_aprobacion
          (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdEstado_Aprobacion)
        {
            try
            {

                decimal IdPersonaIni = 0;
                decimal IdPersonaFin = 0;
                decimal IdEntidadIni = 0;
                decimal IdEntidadFin = 0;


                if (IdTipoPersona == "TODOS" || IdTipoPersona == null)
                {
                    IdPersonaIni = 1;
                    IdPersonaFin = 999999;
                    IdEntidadIni = 1;
                    IdEntidadFin = 999999;
                    //IdTipoPersona = "";
                }
                else
                {

                    IdPersonaIni = IdPersona;
                    IdPersonaFin = IdPersona;
                    IdEntidadIni = IdEntidad;
                    IdEntidadFin = IdEntidad;
                }


                List<vwcp_orden_pago_con_cancelacion_Info> lM = new List<vwcp_orden_pago_con_cancelacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                db.SetCommandTimeOut(3000);

                IQueryable<vwcp_orden_pago_para_aprobacion> select_;
                if (IdEntidad != 0 && IdTipoPersona != "TODOS")
                {
                    select_ = (from T in db.vwcp_orden_pago_para_aprobacion
                               where T.IdEmpresa == IdEmpresa
                                        && T.IdEntidad >= IdEntidadIni && T.IdEntidad <= IdEntidadFin
                                        && T.IdTipo_Persona == IdTipoPersona
                                        && T.IdPersona >= IdPersonaIni && T.IdPersona <= IdPersonaFin
                                        && T.IdEstadoAprobacion == IdEstado_Aprobacion
                               select T
                               );
                }
                else
                    if (IdTipoPersona == "TODOS")
                    {
                        select_ = (from T in db.vwcp_orden_pago_para_aprobacion
                                   where T.IdEmpresa == IdEmpresa
                                            && T.IdEntidad >= IdEntidadIni && T.IdEntidad <= IdEntidadFin
                                            && T.IdPersona >= IdPersonaIni && T.IdPersona <= IdPersonaFin
                                            && T.IdEstadoAprobacion == IdEstado_Aprobacion
                                   select T
                                   );
                    }
                    else
                        if (IdEntidad == 0 && IdTipoPersona != "TODOS")
                            select_ = (from T in db.vwcp_orden_pago_para_aprobacion
                                       where T.IdEmpresa == IdEmpresa
                                                && T.IdTipo_Persona == IdTipoPersona
                                                && T.IdEstadoAprobacion == IdEstado_Aprobacion
                                       select T
                                       );
                        else
                            select_ = (from T in db.vwcp_orden_pago_para_aprobacion
                                       where T.IdEmpresa == IdEmpresa
                                                && T.IdEstadoAprobacion == IdEstado_Aprobacion
                                       select T
                                   );


                foreach (var item in select_)
                {
                    vwcp_orden_pago_con_cancelacion_Info dat = new vwcp_orden_pago_con_cancelacion_Info();


                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.Referencia = item.Referencia;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia;
                    dat.IdTipoPersona = item.IdTipo_Persona;
                    dat.IdPersona = Convert.ToDecimal(item.IdPersona);
                    dat.IdEntidad = item.IdEntidad;
                    dat.Fecha_OP = item.Fecha_Pago;
                    dat.Fecha_Fa_Prov = Convert.ToDateTime(item.co_FechaFactura);
                    dat.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.co_FechaFactura_vct);
                    dat.Observacion = item.co_observacion;
                    dat.Nom_Beneficiario = item.pe_nombreCompleto;
                    dat.dias_vencido = item.dias_vencido;
                    //dat.Girar_Cheque_a = item.Girar_Cheque_a;
                    dat.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);
                    dat.Valor_estimado_a_pagar_OP = item.Valor_a_pagar;
                    //dat.Total_cancelado_OP = item.Total_cancelado_OP;
                    //dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.IdFormaPago = item.IdFormaPago;
                    dat.Fecha_Pago = item.Fecha_Pago;
                    //dat.IdCtaCble = item.IdCtaCble;
                    //dat.IdCentroCosto = item.IdCentroCosto;
                    //dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                    //dat.Cbte_cxp = item.Cbte_cxp;
                    dat.Estado = item.Estado;
                    dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    dat.IdCbteCble_cxp = item.IdCbteCble_cxp;

                    dat.IdEstadoAprobacion_AUX = item.IdEstadoAprobacion;
                    //dat.IdBanco = item.IdBanco;
                    dat.Referencia2 = item.Referencia2;



                    lM.Add(dat);

                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion(int IdEmpresa, string IdUsuario, ref string mensaje)
        {
            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> Lst = new List<vwcp_orden_pago_con_cancelacion_Info>();
                using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                {
                    //cxp.SetCommandTimeOut(3000);

                    var consulta = (from T in cxp.spcp_Get_Data_orden_pago_con_cancelacion_data(IdEmpresa, 1, 99999, "", 1, 99999, "", IdUsuario, false)

                                    select T
                               );

                    foreach (var item in consulta)
                    {
                        vwcp_orden_pago_con_cancelacion_Info info = new vwcp_orden_pago_con_cancelacion_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipo_op = item.IdTipo_op;
                        info.Referencia = item.Referencia;
                        info.IdOrdenPago = item.IdOrdenPago;
                        info.Secuencia_OP = item.Secuencia_OP;
                        info.IdTipoPersona = item.IdTipoPersona;
                        info.IdPersona = Convert.ToDecimal(item.IdPersona);
                        info.IdEntidad = item.IdEntidad;
                        info.Fecha_OP = item.Fecha_OP;
                        info.Fecha_Fa_Prov = Convert.ToDateTime(item.Fecha_Fa_Prov);
                        info.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.Fecha_Venc_Fac_Prov);
                        info.Observacion = item.Observacion;
                        info.Nom_Beneficiario = item.Nom_Beneficiario_2;
                        info.Girar_Cheque_a = item.Girar_Cheque_a;
                        info.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);
                        info.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                        info.Total_cancelado_OP = item.Total_cancelado_OP;
                        info.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                        info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        info.IdFormaPago = item.IdFormaPago;
                        info.Fecha_Pago = item.Fecha_Pago;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdSubCentro_Costo = item.IdSubCentro_Costo;
                        info.Cbte_cxp = item.Cbte_cxp;
                        //info.Valor_aplicado = item.Valor_aplicado;
                        //info.IdAprobacion = item.IdAprobacion;
                        info.Estado = item.Estado;
                        info.Saldo_x_Pagar2 = item.Saldo_x_Pagar_OP;//DEREK MEJIA 07/03/2014

                        info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        info.IdBanco = item.IdBanco;
                        info.Referencia2 = item.Referencia2;

                        Lst.Add(info);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion(int IdEmpresa, decimal IdConciliacion, ref string mensaje)
        {
            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> Lst = new List<vwcp_orden_pago_con_cancelacion_Info>();
                using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                {
                    var CC = from q in cxp.vwcp_conciliacion_x_orden_pago
                             where q.IdEmpresa == IdEmpresa &&
                             q.IdConciliacion == IdConciliacion
                             select q;

                    foreach (var item in CC)
                    {
                        vwcp_orden_pago_con_cancelacion_Info info = new vwcp_orden_pago_con_cancelacion_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipo_op = item.IdTipo_op;
                        info.Referencia = item.Referencia;
                        info.IdOrdenPago = item.IdOrdenPago;
                        info.Secuencia_OP = item.Secuencia_OP;
                        info.IdTipoPersona = item.IdTipoPersona;
                        info.IdPersona = item.IdPersona;
                        info.IdEntidad = item.IdEntidad;
                        info.Fecha_OP = item.Fecha_OP;
                        info.Fecha_Fa_Prov = item.Fecha_Fa_Prov;
                        info.Fecha_Venc_Fac_Prov = item.Fecha_Venc_Fac_Prov;
                        info.Observacion = item.Observacion;
                        info.Nom_Beneficiario = item.Nom_Beneficiario_2;
                        info.Girar_Cheque_a = item.Girar_Cheque_a;
                        info.Valor_a_pagar = item.Valor_a_pagar;
                        info.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                        info.Total_cancelado_OP = item.Total_cancelado_OP;

                        info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        info.IdFormaPago = item.IdFormaPago;
                        info.Fecha_Pago = item.Fecha_Pago;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdSubCentro_Costo = item.IdSubCentro_Costo;
                        info.Cbte_cxp = item.Cbte_cxp;
                        info.Valor_aplicado = item.MontoAplicado;
                        info.Saldo_x_Pagar_OP = item.SaldoActual;
                        info.Saldo_x_Pagar2 = item.SaldoAnterior;

                        //info.IdAprobacion = item.IdAprobacion;
                        info.Estado = item.Estado;



                        Lst.Add(info);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_Mayor_a_cero
          (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdEstado_Aprobacion, string IdUsuario)
        {

            try
            {
                decimal IdPersonaIni = 0;
                decimal IdPersonaFin = 0;
                decimal IdEntidadIni = 0;
                decimal IdEntidadFin = 0;

                if (IdTipoPersona == "" || IdTipoPersona == null)
                {
                    IdPersonaIni = 1;
                    IdPersonaFin = 999999;
                    IdEntidadIni = 1;
                    IdEntidadFin = 999999;
                    IdTipoPersona = "";
                }
                else
                {
                    IdPersonaIni = IdPersona;
                    IdPersonaFin = IdPersona;
                    IdEntidadIni = IdEntidad;
                    IdEntidadFin = IdEntidad;
                }

                List<vwcp_orden_pago_con_cancelacion_Info> lM = new List<vwcp_orden_pago_con_cancelacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                db.SetCommandTimeOut(3000);

                var select_ = (from T in db.spcp_Get_Data_orden_pago_con_cancelacion_data(IdEmpresa, IdPersonaIni, IdPersonaFin, IdTipoPersona, IdEntidadIni, IdEntidadFin, IdEstado_Aprobacion, IdUsuario, true)

                               select T
                               );
                foreach (var item in select_)
                {
                    vwcp_orden_pago_con_cancelacion_Info dat = new vwcp_orden_pago_con_cancelacion_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.Referencia = item.Referencia;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.IdTipoPersona = item.IdTipoPersona;
                    dat.IdPersona = Convert.ToDecimal(item.IdPersona);
                    dat.IdEntidad = item.IdEntidad;
                    dat.Fecha_OP = item.Fecha_OP;
                    dat.Fecha_Fa_Prov = Convert.ToDateTime(item.Fecha_Fa_Prov);
                    dat.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.Fecha_Venc_Fac_Prov);
                    dat.Observacion = item.Observacion;
                    dat.Nom_Beneficiario = item.Nom_Beneficiario;
                    dat.Girar_Cheque_a = item.Girar_Cheque_a;
                    dat.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);
                    dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    dat.Total_cancelado_OP = item.Total_cancelado_OP;
                    dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.IdFormaPago = item.IdFormaPago;
                    dat.Fecha_Pago = item.Fecha_Pago;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                    dat.Cbte_cxp = item.Cbte_cxp;
                    dat.Estado = item.Estado;
                    dat.Nom_Beneficiario_2 = item.Nom_Beneficiario_2;
                    dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    dat.IdCbteCble_cxp = item.IdCbteCble_cxp;

                    dat.Referencia2 = item.Referencia2;
                    dat.IdBanco = item.IdBanco;
                    dat.Saldo_x_Pagar2 = item.Saldo_x_Pagar_OP;

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_Mayor_a_cero
      (int IdEmpresa, string IdTipo_op, decimal IdProveedor, string IdEstado_Aprobacion, string IdUsuario)
        {

            try
            {

                List<vwcp_orden_pago_con_cancelacion_Info> lM = new List<vwcp_orden_pago_con_cancelacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                db.SetCommandTimeOut(3000);

                var select_ = (from T in db.spcp_Get_Data_orden_pago_con_cancelacion_data(IdEmpresa, 1, 99999, "PROVEE", IdProveedor, IdProveedor, IdEstado_Aprobacion, IdUsuario, false)
                               where T.IdTipo_op.Contains(IdTipo_op)
                               select T
                               );

                foreach (var item in select_)
                {
                    vwcp_orden_pago_con_cancelacion_Info dat = new vwcp_orden_pago_con_cancelacion_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.Referencia = item.Referencia;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.IdTipoPersona = item.IdTipoPersona;
                    dat.IdPersona = Convert.ToDecimal(item.IdPersona);
                    dat.IdEntidad = item.IdEntidad;
                    dat.Fecha_OP = item.Fecha_OP;
                    dat.Fecha_Fa_Prov = Convert.ToDateTime(item.Fecha_Fa_Prov);
                    dat.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.Fecha_Venc_Fac_Prov);
                    dat.Observacion = item.Observacion;
                    dat.Nom_Beneficiario = item.Nom_Beneficiario;
                    dat.Girar_Cheque_a = item.Girar_Cheque_a;

                    dat.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);
                    dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    dat.Total_cancelado_OP = item.Total_cancelado_OP;
                    dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;

                    dat.Saldo_x_Pagar2 = item.Saldo_x_Pagar_OP;


                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.IdFormaPago = item.IdFormaPago;
                    dat.Fecha_Pago = item.Fecha_Pago;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                    dat.Cbte_cxp = item.Cbte_cxp;
                    dat.Estado = item.Estado;
                    dat.Nom_Beneficiario_2 = item.Nom_Beneficiario_2;
                    dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    dat.IdCbteCble_cxp = item.IdCbteCble_cxp;

                    dat.Referencia2 = item.Referencia2;
                    dat.IdBanco = item.IdBanco;

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_
        (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdUsuario, string IdEstado_Aprobacion)
        {

            try
            {
                decimal IdPersonaIni = 0;
                decimal IdPersonaFin = 0;
                decimal IdEntidadIni = 0;
                decimal IdEntidadFin = 0;

                if (IdTipoPersona == "" || IdTipoPersona == null)
                {
                    IdPersonaIni = 1;
                    IdPersonaFin = 999999;
                    IdEntidadIni = 1;
                    IdEntidadFin = 999999;
                    IdTipoPersona = "";
                }
                else
                {
                    IdPersonaIni = IdPersona;
                    IdPersonaFin = IdPersona;
                    IdEntidadIni = IdEntidad;
                    IdEntidadFin = IdEntidad;
                }

                List<vwcp_orden_pago_con_cancelacion_Info> lM = new List<vwcp_orden_pago_con_cancelacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                db.SetCommandTimeOut(3000);

                var select_ = (from T in db.spcp_Get_Data_orden_pago_con_cancelacion_data(IdEmpresa, IdPersonaIni, IdPersonaFin, IdTipoPersona, IdEntidadIni, IdEntidadFin, IdEstado_Aprobacion, IdUsuario, true)

                               select T
                               );
                foreach (var item in select_)
                {
                    vwcp_orden_pago_con_cancelacion_Info dat = new vwcp_orden_pago_con_cancelacion_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.Referencia = item.Referencia;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.IdTipoPersona = item.IdTipoPersona;
                    dat.IdPersona = Convert.ToDecimal(item.IdPersona);
                    dat.IdEntidad = item.IdEntidad;
                    dat.Fecha_OP = item.Fecha_OP;
                    dat.Fecha_Fa_Prov = Convert.ToDateTime(item.Fecha_Fa_Prov);
                    dat.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.Fecha_Venc_Fac_Prov);
                    dat.Observacion = item.Observacion;
                    dat.Nom_Beneficiario = item.Nom_Beneficiario;
                    dat.Girar_Cheque_a = item.Girar_Cheque_a;
                    dat.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);
                    dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    dat.Total_cancelado_OP = item.Total_cancelado_OP;
                    dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.IdFormaPago = item.IdFormaPago;
                    dat.Fecha_Pago = item.Fecha_Pago;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                    dat.Cbte_cxp = item.Cbte_cxp;
                    dat.Estado = item.Estado;
                    dat.Nom_Beneficiario_2 = item.Nom_Beneficiario_2;
                    dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    dat.IdCbteCble_cxp = item.IdCbteCble_cxp;
                    dat.IdBanco = item.IdBanco;
                    dat.Referencia2 = item.Referencia2;
                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_Mayor_a_cero_
          (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdUsuario, string IdEstado_Aprobacion)
        {
            try
            {
                decimal IdPersonaIni = 0;
                decimal IdPersonaFin = 0;
                decimal IdEntidadIni = 0;
                decimal IdEntidadFin = 0;

                if (IdTipoPersona == "" || IdTipoPersona == null)
                {
                    IdPersonaIni = 1;
                    IdPersonaFin = 999999;
                    IdEntidadIni = 1;
                    IdEntidadFin = 999999;
                    IdTipoPersona = "";
                }
                else
                {
                    IdPersonaIni = IdPersona;
                    IdPersonaFin = IdPersona;
                    IdEntidadIni = IdEntidad;
                    IdEntidadFin = IdEntidad;
                }

                List<vwcp_orden_pago_con_cancelacion_Info> lM = new List<vwcp_orden_pago_con_cancelacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                db.SetCommandTimeOut(3000);

                var select_ = (from T in db.spcp_Get_Data_orden_pago_con_cancelacion_data(IdEmpresa, IdPersonaIni, IdPersonaFin, IdTipoPersona, IdEntidadIni, IdEntidadFin, IdEstado_Aprobacion, IdUsuario, false)

                               select T
                               );
                foreach (var item in select_)
                {
                    vwcp_orden_pago_con_cancelacion_Info dat = new vwcp_orden_pago_con_cancelacion_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.Referencia = item.Referencia;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.IdTipoPersona = item.IdTipoPersona;
                    dat.IdPersona = Convert.ToDecimal(item.IdPersona);
                    dat.IdEntidad = item.IdEntidad;
                    dat.Fecha_OP = item.Fecha_OP;
                    dat.Fecha_Fa_Prov = Convert.ToDateTime(item.Fecha_Fa_Prov);
                    dat.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.Fecha_Venc_Fac_Prov);
                    dat.Observacion = item.Observacion;
                    dat.Nom_Beneficiario = item.Nom_Beneficiario;
                    dat.Girar_Cheque_a = item.Girar_Cheque_a;
                    dat.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);
                    dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    dat.Total_cancelado_OP = item.Total_cancelado_OP;
                    dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                    dat.IdBanco = item.IdBanco;
                    dat.Saldo_x_Pagar2 = item.Saldo_x_Pagar_OP;

                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.IdFormaPago = item.IdFormaPago;
                    dat.Fecha_Pago = item.Fecha_Pago;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                    dat.Cbte_cxp = item.Cbte_cxp;
                    dat.Estado = item.Estado;
                    dat.Nom_Beneficiario_2 = item.Nom_Beneficiario_2;
                    dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    dat.IdCbteCble_cxp = item.IdCbteCble_cxp;

                    dat.Referencia2 = item.Referencia2;
                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_Mayor_a_cero_x_OrdenPago
       (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdUsuario, string IdEstado_Aprobacion)
        {
            try
            {


                decimal IdPersonaIni = 0;
                decimal IdPersonaFin = 0;
                decimal IdEntidadIni = 0;
                decimal IdEntidadFin = 0;

                if (IdTipoPersona == "" || IdTipoPersona == null || IdTipoPersona == "TODOS")
                {
                    IdPersonaIni = 1;
                    IdPersonaFin = 999999;
                    IdEntidadIni = 1;
                    IdEntidadFin = 999999;
                    IdTipoPersona = "";
                }
                else
                {
                    IdPersonaIni = IdPersona;
                    IdPersonaFin = IdPersona;
                    IdEntidadIni = IdEntidad;
                    IdEntidadFin = IdEntidad;
                }



                List<vwcp_orden_pago_con_cancelacion_Info> lM = new List<vwcp_orden_pago_con_cancelacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                var select_ = (from T in db.spcp_Get_Data_orden_pago_con_cancelacion_data(IdEmpresa, IdPersonaIni, IdPersonaFin, IdTipoPersona, IdEntidadIni, IdEntidadFin, IdEstado_Aprobacion, IdUsuario, false)

                               select T
                                );

                foreach (var item in select_)
                {
                    vwcp_orden_pago_con_cancelacion_Info dat = new vwcp_orden_pago_con_cancelacion_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.Referencia = item.Referencia;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.IdTipoPersona = item.IdTipoPersona;
                    dat.IdPersona = Convert.ToDecimal(item.IdPersona);
                    dat.IdEntidad = item.IdEntidad;
                    dat.Fecha_OP = item.Fecha_OP;
                    dat.Fecha_Fa_Prov = Convert.ToDateTime(item.Fecha_Fa_Prov);
                    dat.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.Fecha_Venc_Fac_Prov);
                    dat.Observacion = item.Observacion;
                    dat.Nom_Beneficiario = item.Nom_Beneficiario;
                    dat.Girar_Cheque_a = item.Girar_Cheque_a;
                    dat.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);
                    dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    dat.Total_cancelado_OP = item.Total_cancelado_OP;
                    dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                    dat.IdBanco = item.IdBanco;
                    dat.Saldo_x_Pagar2 = item.Saldo_x_Pagar_OP;

                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.IdFormaPago = item.IdFormaPago;
                    dat.Fecha_Pago = item.Fecha_Pago;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                    dat.Cbte_cxp = item.Cbte_cxp;
                    dat.Estado = item.Estado;
                    dat.Nom_Beneficiario_2 = item.Nom_Beneficiario_2;
                    dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    dat.IdCbteCble_cxp = item.IdCbteCble_cxp;

                    dat.Referencia2 = item.Referencia2;
                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero(int IdEmpresa, string IdEstado_Aprobacion, string IdUsuario)
        {
            List<vwcp_orden_pago_con_cancelacion_Info> lM = new List<vwcp_orden_pago_con_cancelacion_Info>();

            try
            {


                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                db.SetCommandTimeOut(3000);

                var select_ = (from T in db.spcp_Get_Data_orden_pago_con_cancelacion_data(IdEmpresa, 1, 99999, "", 1, 99999, IdEstado_Aprobacion, IdUsuario, false)
                               where T.IdTipo_op != "ANTI_PROVEE"
                                        && T.IdTipo_op != "OTROS_CONC"
                               select T
                               );
                foreach (var item in select_)
                {
                    vwcp_orden_pago_con_cancelacion_Info dat = new vwcp_orden_pago_con_cancelacion_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.Referencia = item.Referencia;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.IdTipoPersona = item.IdTipoPersona;
                    dat.IdPersona = Convert.ToDecimal(item.IdPersona);
                    dat.IdEntidad = item.IdEntidad;
                    dat.Fecha_OP = item.Fecha_OP;
                    dat.Fecha_Fa_Prov = Convert.ToDateTime(item.Fecha_Fa_Prov);
                    dat.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.Fecha_Venc_Fac_Prov);
                    dat.Observacion = item.Observacion;
                    dat.Nom_Beneficiario = item.Nom_Beneficiario;
                    dat.Girar_Cheque_a = item.Girar_Cheque_a;
                    dat.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);
                    dat.IdBanco = item.IdBanco;
                    dat.Total_cancelado_OP = item.Total_cancelado_OP;

                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.IdFormaPago = item.IdFormaPago;
                    dat.Fecha_Pago = item.Fecha_Pago;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                    dat.Cbte_cxp = item.Cbte_cxp;
                    dat.Estado = item.Estado;
                    dat.Nom_Beneficiario_2 = item.Nom_Beneficiario_2;
                    dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    dat.IdCbteCble_cxp = item.IdCbteCble_cxp;

                    dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;

                    dat.Saldo_x_Pagar2 = item.Saldo_x_Pagar_OP;

                    dat.Referencia2 = item.Referencia2;
                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_transferencia(int IdEmpresa, decimal IdArchivo, DateTime fechaInicio, DateTime fechaFin, string IdUsuario)
        {
            List<vwcp_orden_pago_con_cancelacion_Info> lM = new List<vwcp_orden_pago_con_cancelacion_Info>();
            List<vwtb_persona_beneficiario_Info> Lista_Beneficiarios = new List<vwtb_persona_beneficiario_Info>();
            vwtb_persona_beneficiario_Data Data_Beneficiario = new vwtb_persona_beneficiario_Data();

            try
            {
                fechaInicio = fechaInicio.Date;
                fechaFin = fechaFin.Date;

                // buscar datos del beneficiarios

                Lista_Beneficiarios = Data_Beneficiario.Get_List_Datos_Beneficiarios(IdEmpresa);


                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                db.SetCommandTimeOut(3000);

                var select_ = db.spcp_Get_Data_orden_pago_con_Transferencia_data(IdEmpresa, IdArchivo, fechaInicio, fechaFin, IdUsuario);



                foreach (var item in select_)
                {
                    vwcp_orden_pago_con_cancelacion_Info dat = new vwcp_orden_pago_con_cancelacion_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.Referencia = item.Referencia;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.IdTipoPersona = item.IdTipoPersona;
                    dat.IdPersona = Convert.ToDecimal(item.IdPersona);
                    dat.IdEntidad = item.IdEntidad;
                    dat.Fecha_OP = Convert.ToDateTime(item.Fecha_OP);
                    dat.Fecha_Fa_Prov = Convert.ToDateTime(item.Fecha_Fa_Prov);
                    dat.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.Fecha_Venc_Fac_Prov);
                    dat.Observacion = item.Observacion;
                    dat.Nom_Beneficiario = item.Nom_Beneficiario;
                    dat.Girar_Cheque_a = item.Girar_Cheque_a;
                    dat.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);
                    dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    dat.Total_cancelado_OP = item.Total_cancelado_OP;
                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.IdFormaPago = item.IdFormaPago;
                    dat.Fecha_Pago = item.Fecha_Pago;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                    dat.Cbte_cxp = item.Cbte_cxp;
                    dat.Estado = item.Estado;
                    dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    dat.IdCbteCble_cxp = item.IdCbteCble_cxp;
                    dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                    dat.Saldo_x_Pagar2 = item.Saldo_x_Pagar_OP;
                    dat.Referencia2 = item.Referencia2;
                    dat.IdBanco_acreditacion = item.IdBanco_acreditacion;
                    dat.CodigoLegal = item.CodigoLegal;
                    dat.Check = item.Checked;
                    dat.IdEmpresa_pago = item.IdEmpresa_pago;
                    dat.IdTipoCbte_pago = item.IdTipoCbte_pago;
                    dat.IdCbteCble_pago = item.IdCbteCble_pago;
                    dat.tipo_cbte_pago = item.tipo_cbte_pago;
                    dat.Secuencial_reg_x_proceso = item.Secuencial_reg_x_proceso;

                    // anado los datos beneficiarios
                    vwtb_persona_beneficiario_Info info_Beneficiario = new vwtb_persona_beneficiario_Info();
                    try
                    {
                        info_Beneficiario = Lista_Beneficiarios.Where(v => v.IdTipo_Persona == dat.IdTipoPersona && v.IdEntidad == dat.IdEntidad && v.IdPersona == dat.IdPersona && v.IdEmpresa == dat.IdEmpresa).FirstOrDefault();
                    }
                    catch (Exception)
                    {


                    }
                    dat.Beneficiario = info_Beneficiario;
                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_x_list_op(int IdEmpresa, List<Nullable<decimal>> list_op, string IdUsuario)
        {
            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> Lista = new List<vwcp_orden_pago_con_cancelacion_Info>();

                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    Context.SetCommandTimeOut(3000);

                    var lst = from q in Context.spcp_Get_Data_orden_pago_con_cancelacion_data(IdEmpresa, 1, 99999, "", 1, 99999, "APRO", IdUsuario, false)
                              where list_op.Contains(q.IdOrdenPago)
                              select q;
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ba_Archivo_Transferencia_Det_Info> Get_List_orden_pago_con_archivo_Transeferencia(int IdEmpresa, int IdArchivo)
        {
            List<ba_Archivo_Transferencia_Det_Info> lM = new List<ba_Archivo_Transferencia_Det_Info>();
            try
            {


                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
                var select_ = (from T in db.vwcp_ba_Archivo_Transferencia_Det
                               where T.IdEmpresa == IdEmpresa
                                        && T.IdArchivo == IdArchivo
                               select T
                               );
                foreach (var item in select_)
                {
                    ba_Archivo_Transferencia_Det_Info dat = new ba_Archivo_Transferencia_Det_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdArchivo = item.IdArchivo;
                    dat.IdProceso_bancario = item.IdProceso_bancario;
                    dat.IdEmpresa_OP = item.IdEmpresa_OP;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.Valor = Convert.ToDecimal(item.Valor_a_pagar);
                    dat.Observacion_op = item.Observacion;
                    dat.Beneficiario = item.pe_nombreCompleto;
                    dat.IdPersona = item.IdPersona;
                    dat.fecha_op = item.Fecha_Pago;
                    dat.Secuencia = item.Secuencia;
                    dat.Estado = item.Estado;
                    dat.Estado_OP = item.IdEstadoAprobacion;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.check = true;
                    dat.Estado_Transferencia = "OP CON TRANSFERENCIA";
                    dat.IdEntidad = item.IdEntidad;
                    dat.IdTipo_Persona = item.IdTipo_Persona;
                    dat.IdPersona = item.IdPersona;
                    dat.pe_cedulaRuc = item.pe_cedulaRuc;

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        /*
        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero
      (int IdEmpresa, decimal IdOrdenPago, int Secuencia_OP)
        {
            try
            {

                List<vwcp_orden_pago_con_cancelacion_Info> lM = new List<vwcp_orden_pago_con_cancelacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
                var select_ = (from T in db.vwcp_orden_pago_con_cancelacion
                               where T.IdEmpresa == IdEmpresa
                                        && T.IdOrdenPago == IdOrdenPago
                                        && T.Secuencia_OP == Secuencia_OP
                                       
                               select T
                               );
                foreach (var item in select_)
                {
                    vwcp_orden_pago_con_cancelacion_Info dat = new vwcp_orden_pago_con_cancelacion_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.Referencia = item.Referencia;
                    dat.IdOrdenPago = item.IdOrdenPago;
                    dat.Secuencia_OP = item.Secuencia_OP;
                    dat.IdTipoPersona = item.IdTipoPersona;
                    dat.IdPersona = Convert.ToDecimal(item.IdPersona);
                    dat.IdEntidad = item.IdEntidad;
                    dat.Fecha_OP = item.Fecha_OP;
                    dat.Fecha_Fa_Prov = Convert.ToDateTime(item.Fecha_Fa_Prov);
                    dat.Fecha_Venc_Fac_Prov = Convert.ToDateTime(item.Fecha_Venc_Fac_Prov);
                    dat.Observacion = item.Observacion;
                    dat.Nom_Beneficiario = item.Nom_Beneficiario;
                    dat.Girar_Cheque_a = item.Girar_Cheque_a;
                    dat.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);

                    dat.Total_cancelado_OP = item.Total_cancelado_OP;

                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.IdFormaPago = item.IdFormaPago;
                    dat.Fecha_Pago = item.Fecha_Pago;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                    dat.Cbte_cxp = item.Cbte_cxp;
                    dat.Estado = item.Estado;
                    dat.Nom_Beneficiario_2 = item.Nom_Beneficiario_2;
                    dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    dat.IdCbteCble_cxp = item.IdCbteCble_cxp;
                    dat.IdBanco = item.IdBanco;
                    dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                    dat.IdBanco = item.IdBanco;
                    //  dat.Saldo_x_Pagar2 = item.Valor_estimado_a_pagar_OP;

                    dat.Saldo_x_Pagar2 = item.Saldo_x_Pagar_OP;
                    dat.Referencia2 = item.Referencia2;

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
         * */

        public vwcp_orden_pago_con_cancelacion_Data()
        {

        }
    }
}
