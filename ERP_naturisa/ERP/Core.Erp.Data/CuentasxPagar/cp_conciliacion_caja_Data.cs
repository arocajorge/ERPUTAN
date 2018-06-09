using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Data.Caja;
using Core.Erp.Info.Caja;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_conciliacion_caja_Data
    {
        string mensaje = "";
        public Boolean ModificarDB(cp_conciliacion_caja_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_conciliacion_Caja.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa
                        && obj.IdConciliacion_Caja == Info.IdConciliacion_Caja);
                    if (contact != null)
                    {
                        contact.IdEmpresa_op = Info.IdEmpresa_op;
                        contact.IdOrdenPago_op = Info.IdOrdenPago_op;
                        contact.IdEstadoCierre = Info.IdEstadoCierre;
                        contact.Fecha_ini = Info.Fecha_ini;
                        contact.Fecha_fin = Info.Fecha_fin;
                        contact.Saldo_cont_al_periodo = Info.Saldo_cont_al_periodo;
                        contact.Ingresos = Info.Ingresos;
                        contact.Total_Ing = Info.Total_Ing;
                        contact.Total_fact_vale = Info.Total_fact_vale;
                        contact.Total_fondo = Info.Total_fondo;
                        contact.Dif_x_pagar_o_cobrar = Info.Dif_x_pagar_o_cobrar;
                        contact.IdTipoFlujo = Info.IdTipoFlujo;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }      

        public Boolean ModificarDB_valores(cp_conciliacion_caja_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_conciliacion_Caja.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa
                        && obj.IdConciliacion_Caja == Info.IdConciliacion_Caja);
                    if (contact != null)
                    {
                        contact.Saldo_cont_al_periodo = Info.Saldo_cont_al_periodo;
                        contact.Ingresos = Info.Ingresos;
                        contact.Total_Ing = Info.Total_Ing;
                        contact.Total_fact_vale = Info.Total_fact_vale;
                        contact.Total_fondo = Info.Total_fondo;
                        contact.Dif_x_pagar_o_cobrar = Info.Dif_x_pagar_o_cobrar;
                        contact.Observacion = Info.Observacion;
                        contact.IdEstadoCierre = Info.IdEstadoCierre;
                        contact.Fecha_ini = Info.Fecha_ini;
                        contact.Fecha_fin = Info.Fecha_fin;
                        contact.IdTipoFlujo = Info.IdTipoFlujo;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id;
                using (EntitiesCuentasxPagar base_ = new EntitiesCuentasxPagar())
                {

                    var q = from C in base_.cp_conciliacion_Caja
                            where C.IdEmpresa == IdEmpresa
                            select C;
                    if (q.ToList().Count == 0)
                        return 1;
                    else
                    {

                        var select_ = (from T in base_.cp_conciliacion_Caja
                                       where T.IdEmpresa == IdEmpresa
                                       select T.IdConciliacion_Caja).Max();
                        Id = select_ + 1;
                        return Id;
                    }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public void GenerarRpt(int IdEmpresa,decimal IdConciliacion_Caja,string IdUsuario,string nom_pc)
        {
            try
            {
                using (EntitiesCuentasxPagar base_ = new EntitiesCuentasxPagar())
                {
                    string query = "exec  spCXP_Rpt_RCXP002 " +IdEmpresa +" , "+IdConciliacion_Caja+" , '"+IdUsuario+ "', '"+nom_pc+"'";
                    base_.Database.ExecuteSqlCommand(query);
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<cp_conciliacion_caja_Info> Get_List_Conciliacion_Caja(int IdEmpresa, DateTime Fecha_Desde, DateTime Fecha_Hasta)
        {
            try
            {
                List<cp_conciliacion_caja_Info> lM = new List<cp_conciliacion_caja_Info>();
                using (EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar())
                {
                    var select_ = from T in Base.vwcp_Conciliacion_Caja
                                  where T.IdEmpresa == IdEmpresa 
                                  && T.Fecha >= Fecha_Desde 
                                  && T.Fecha <= Fecha_Hasta
                                  select T;

                    foreach (var item in select_)
                    {
                        cp_conciliacion_caja_Info dat = new cp_conciliacion_caja_Info();

                        dat.IdEmpresa = item.IdEmpresa;
                        dat.IdConciliacion_Caja = item.IdConciliacion_Caja;
                        dat.IdCaja = item.IdCaja;
                        dat.Fecha = item.Fecha;
                        dat.IdEstadoCierre = item.IdEstadoCierre;
                        dat.Observacion = item.Observacion;
                        dat.IdEmpresa_op = item.IdEmpresa_op;
                        dat.IdOrdenPago_op = item.IdOrdenPago_op;
                        dat.IdCtaCble = item.IdCtaCble;
                        dat.Valor_pagado =item.Valor_pagado;
                        dat.nom_Caja =item.nom_Caja;
                        dat.nom_Estado = item.nom_Estado;
                        dat.Icono_Buscar = true;
                        dat.Saldo_cont_al_periodo = item.Saldo_cont_al_periodo;
                        dat.Ingresos = item.Ingresos;
                        dat.Total_Ing = item.Total_Ing;
                        dat.Total_fact_vale = item.Total_fact_vale;
                        dat.Total_fondo = item.Total_fondo;
                        dat.Dif_x_pagar_o_cobrar = item.Dif_x_pagar_o_cobrar;
                        dat.IdPeriodo = item.IdPeriodo;
                        dat.Fecha_ini = item.Fecha_ini;
                        dat.Fecha_fin = item.Fecha_fin;
                        dat.IdTipoFlujo = item.IdTipoFlujo;
                        dat.IdEmpresa_mov_caj = item.IdEmpresa_mov_caj;
                        dat.IdTipoCbte_mov_caj = item.IdTipoCbte_mov_caj;
                        dat.IdCbteCble_mov_caj = item.IdCbteCble_mov_caj;
                        lM.Add(dat);
                    }
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(cp_conciliacion_caja_Info info, ref decimal IdConciliacion_Caja, ref string mensaje)
        {
            Boolean res = true;
            try
            {

                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();

                    cp_conciliacion_Caja address = new cp_conciliacion_Caja();
                    address.IdEmpresa =info.IdEmpresa;
                    address.IdConciliacion_Caja = info.IdConciliacion_Caja = IdConciliacion_Caja  = GetId(info.IdEmpresa);
                    address.IdPeriodo = info.IdPeriodo;
                    address.Fecha = Convert.ToDateTime(info.Fecha);
                    address.IdCaja = info.IdCaja;
                    address.IdEstadoCierre = info.IdEstadoCierre;
                    address.Observacion = info.Observacion==""?".":info.Observacion;
                    address.IdEmpresa_op = info.IdEmpresa_op==0?null:info.IdEmpresa_op;
                    address.IdOrdenPago_op = info.IdOrdenPago_op == 0 ? null : info.IdOrdenPago_op;
                    address.IdCtaCble = info.IdCtaCble;
                    address.Fecha_ini = info.Fecha_ini;
                    address.Fecha_fin = info.Fecha_fin;
                    address.Saldo_cont_al_periodo = info.Saldo_cont_al_periodo;
                    address.Ingresos = info.Ingresos;
                    address.Total_Ing = info.Total_Ing;
                    address.Total_fact_vale = info.Total_fact_vale;
                    address.Total_fondo = info.Total_fondo;
                    address.Dif_x_pagar_o_cobrar = info.Dif_x_pagar_o_cobrar;
                    address.IdTipoFlujo = info.IdTipoFlujo;
                    context.cp_conciliacion_Caja.Add(address);
                    context.SaveChanges();
                   
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB_campos_mov_caj(cp_conciliacion_caja_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_conciliacion_Caja.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa
                        && obj.IdConciliacion_Caja == Info.IdConciliacion_Caja);
                    if (contact != null)
                    {
                        contact.IdEmpresa_mov_caj = Info.IdEmpresa_mov_caj;
                        contact.IdTipoCbte_mov_caj = Info.IdTipoCbte_mov_caj;
                        contact.IdCbteCble_mov_caj = Info.IdCbteCble_mov_caj;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string Eliminar_facturas_o_vales(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, string TipoCbte, bool Eliminar_desvincular)
        {
            try
            {
                string Mensaje = "";
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var lst = from q in Context.spCXP_eliminar_factura_vale_conciliacion_caja(IdEmpresa, IdTipoCbte, IdCbteCble, TipoCbte, Eliminar_desvincular)
                              select q;

                    foreach (var item in lst)
                    {
                        Mensaje = item.ToString();
                    }
                }

                return Mensaje;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }




        public cp_conciliacion_caja_Data(){}
    }
}

