using Core.Erp.Data.General;
using Core.Erp.Info.Contabilidad_Fj;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Contabilidad_Fj
{
    public class ct_distribucion_gastos_x_periodo_Data
    {
        public List<ct_distribucion_gastos_x_periodo_Info> get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                int IdPeriodo_ini = Convert.ToInt32(Fecha_ini.Date.Year.ToString() + Fecha_ini.Date.Month.ToString("00"));
                int IdPeriodo_fin = Convert.ToInt32(Fecha_fin.Date.Year.ToString() + Fecha_fin.Date.Month.ToString("00"));

                List<ct_distribucion_gastos_x_periodo_Info> Lista = new List<ct_distribucion_gastos_x_periodo_Info>();

                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    var lst = from q in Context.ct_distribucion_gastos_x_periodo
                              where q.IdEmpresa == IdEmpresa
                              && IdPeriodo_ini <= q.IdPeriodo && q.IdPeriodo <= IdPeriodo_fin
                              select q;

                    foreach (var item in lst)
                    {
                        ct_distribucion_gastos_x_periodo_Info info = new ct_distribucion_gastos_x_periodo_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdDistribucion = item.IdDistribucion;
                        info.IdPeriodo = item.IdPeriodo;
                        info.Fecha = item.Fecha;
                        info.Observacion = item.Observacion;
                        info.Estado = item.Estado;
                        info.IdEmpresa_ct = item.IdEmpresa_ct;
                        info.IdTipoCbte_ct = item.IdTipoCbte_ct;
                        info.IdCbteCble_ct = item.IdCbteCble_ct;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public decimal get_id(int IdEmpresa)
        {
            try
            {
                decimal ID = 0;

                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    var lst = from q in Context.ct_distribucion_gastos_x_periodo
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() == 0)
                        ID = 1;
                    else
                        ID = lst.Max(q => q.IdDistribucion) + 1;
                }

                return ID;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(ct_distribucion_gastos_x_periodo_Info info)
        {
            try
            {
                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    ct_distribucion_gastos_x_periodo Entity = new ct_distribucion_gastos_x_periodo();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdDistribucion = info.IdDistribucion = get_id(info.IdEmpresa);
                    Entity.IdPeriodo = info.IdPeriodo;
                    Entity.Fecha = info.Fecha;
                    Entity.Estado = info.Estado;
                    Entity.Observacion = info.Observacion;
                    Context.ct_distribucion_gastos_x_periodo.Add(Entity);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(ct_distribucion_gastos_x_periodo_Info info)
        {
            try
            {
                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    ct_distribucion_gastos_x_periodo Entity = Context.ct_distribucion_gastos_x_periodo.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdDistribucion == info.IdDistribucion);
                    if (Entity != null)
                    {                        
                        Entity.Fecha = info.Fecha;
                        Entity.Observacion = info.Observacion;
                        Context.SaveChanges();
                    }
                    
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(int IdEmpresa, decimal IdDistribucion)
        {
            try
            {
                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    ct_distribucion_gastos_x_periodo Entity = Context.ct_distribucion_gastos_x_periodo.FirstOrDefault(q => q.IdEmpresa == IdEmpresa && q.IdDistribucion == IdDistribucion);
                    if (Entity != null)
                    {
                        Entity.Estado = false;
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
