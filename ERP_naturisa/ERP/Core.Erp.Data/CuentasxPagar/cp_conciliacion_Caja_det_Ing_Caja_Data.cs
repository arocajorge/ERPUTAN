using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_conciliacion_Caja_det_Ing_Caja_Data
    {
        string mensaje = string.Empty;

        public List<cp_conciliacion_Caja_det_Ing_Caja_Info> Get_List_Ingresos_x_conciliacion(int idEmpresa, decimal idConciliacion_Caja)
        {
            try
            {
                List<cp_conciliacion_Caja_det_Ing_Caja_Info> Lista = new List<cp_conciliacion_Caja_det_Ing_Caja_Info>();

                using (EntitiesCuentasxPagar Conexion = new EntitiesCuentasxPagar())
                {
                    var lst = from q in Conexion.vwcp_conciliacion_Caja_det_Ing_Caja
                              where q.IdEmpresa == idEmpresa &&
                              q.IdConciliacion_Caja == idConciliacion_Caja
                              select q;

                    foreach (var item in lst)
                    {
                        cp_conciliacion_Caja_det_Ing_Caja_Info info = new cp_conciliacion_Caja_det_Ing_Caja_Info();

                        info.valor_aplicado = item.valor_aplicado;
                        info.cm_observacion = item.cm_observacion;
                        info.cm_fecha = item.cm_fecha;
                        info.IdPeriodo = item.IdPeriodo;
                        info.Marcado = true;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cp_conciliacion_Caja_det_Ing_Caja_Info> Get_List_Ingresos_x_conciliar(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, int IdCaja)
        {
            try
            {
                List<cp_conciliacion_Caja_det_Ing_Caja_Info> lista = new List<cp_conciliacion_Caja_det_Ing_Caja_Info>();

                using (EntitiesCaja Context = new EntitiesCaja())
                {
                    var lst = from q in Context.vwcaj_Caja_Movimiento_x_Conciliar
                              where q.IdEmpresa == IdEmpresa
                              //&& Fecha_ini <= q.cm_fecha 
                              && q.cm_fecha <= Fecha_fin
                              && q.IdCaja == IdCaja
                              && q.Saldo > 0
                              select q;

                    foreach (var item in lst)
                    {
                        cp_conciliacion_Caja_det_Ing_Caja_Info info = new cp_conciliacion_Caja_det_Ing_Caja_Info();
                        info.IdEmpresa_movcaj = item.IdEmpresa;
                        info.IdTipocbte_movcaj = item.IdTipocbte;
                        info.IdCbteCble_movcaj = item.IdCbteCble;
                        info.cm_observacion = item.cm_observacion;
                        info.cm_fecha = item.cm_fecha;
                        info.IdPeriodo = item.IdPeriodo;
                        info.Total_movi = item.Total_movi;
                        info.Total_aplicado = item.Total_aplicado;
                        info.Saldo = item.Saldo;
                        info.Marcado = true;
                        lista.Add(info);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }        
        }

        public Boolean GuardarDB(List<cp_conciliacion_Caja_det_Ing_Caja_Info> lst)
        {
            try
            {
                int sec = 1;                   
                

                using (EntitiesCuentasxPagar Conexion = new EntitiesCuentasxPagar())
                {
                    foreach (cp_conciliacion_Caja_det_Ing_Caja_Info item in lst)
                    {
                        var lst_ing = from q in Conexion.cp_conciliacion_Caja_det_Ing_Caja
                                  where q.IdEmpresa_movcaj == item.IdEmpresa_movcaj
                                  && q.IdTipocbte_movcaj == item.IdTipocbte_movcaj
                                  && q.IdCbteCble_movcaj == item.IdCbteCble_movcaj
                                  && q.IdConciliacion_Caja == item.IdConciliacion_Caja
                                  select q;

                        if (lst_ing.Count() == 0)
                        {
                            var lst_ing_2 = from q in Conexion.cp_conciliacion_Caja_det_Ing_Caja
                                            where q.IdEmpresa == item.IdEmpresa
                                            && q.IdConciliacion_Caja == item.IdConciliacion_Caja
                                            && q.secuencia == item.secuencia
                                            select q;

                            if (lst_ing_2.Count() == 0)
                            {
                                cp_conciliacion_Caja_det_Ing_Caja Entity = new cp_conciliacion_Caja_det_Ing_Caja();
                                Entity.IdEmpresa = item.IdEmpresa;
                                Entity.IdConciliacion_Caja = item.IdConciliacion_Caja;
                                Entity.secuencia = sec;
                                Entity.IdEmpresa_movcaj = item.IdEmpresa_movcaj;
                                Entity.IdCbteCble_movcaj = item.IdCbteCble_movcaj;
                                Entity.IdTipocbte_movcaj = item.IdTipocbte_movcaj;
                                Entity.valor_aplicado = item.valor_aplicado;
                                Conexion.cp_conciliacion_Caja_det_Ing_Caja.Add(Entity);
                                Conexion.SaveChanges();
                                sec++;
                            }                            
                        }
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarDB(int idEmpresa, decimal idConciliacion_caja)
        {
            try
            {
                using (EntitiesCuentasxPagar Conexion = new EntitiesCuentasxPagar())
                {
                    Conexion.Database.ExecuteSqlCommand("Delete from cp_conciliacion_Caja_det_Ing_Caja where idEmpresa = " + idEmpresa + " and IdConciliacion_Caja = "+idConciliacion_caja+" ");
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
