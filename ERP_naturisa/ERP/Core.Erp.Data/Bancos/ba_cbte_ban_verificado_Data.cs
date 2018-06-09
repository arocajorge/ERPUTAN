using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Bancos
{
    public class ba_cbte_ban_verificado_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(List<ba_cbte_ban_verificado_Info> List_Info) 
        {
            try
            {
                using (EntitiesBanco entity = new EntitiesBanco())
                {
                   int C= 1;
                    foreach (var item in List_Info)
                    {
                        if (C == 1) EliminarDB(item.IdEmpresa, item.IdPeriodo);

                        ba_cbte_ban_verificado Verificacion = new ba_cbte_ban_verificado();
                        Verificacion.IdEmpresa = item.IdEmpresa;
                        Verificacion.IdCbteCble = item.IdCbteCble;
                        Verificacion.IdPeriodo = item.IdPeriodo;
                        Verificacion.IdTipocbte = item.IdTipocbte;
                        Verificacion.observacion = item.observacion;
                        Verificacion.Secuencia = C; C++;
                        Verificacion.SecuenciaCbteCble = item.SecuenciaCbteCble;
                        Verificacion.tipo_IngEgr = item.tipo_IngEgr;
                        entity.ba_cbte_ban_verificado.Add(Verificacion);
                    }

                    entity.SaveChanges();
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

        public Boolean EliminarDB(int IdEmpresa ,int Idperiodo)
        {
            try
            {
                using (EntitiesBanco entity = new EntitiesBanco())
                {
                      entity.Database.ExecuteSqlCommand("delete ba_cbte_ban_verificado where IdEmpresa = "+IdEmpresa+" and IdPeriodo= "+Idperiodo);
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

        public List<ba_cbte_ban_verificado_Info> Get_List_cbte_ban_verificado(int IdEmpresa, int Idperiodo) 
        {
            try
            {
                using (EntitiesBanco Entity = new EntitiesBanco())
                {
                    List<ba_cbte_ban_verificado> Consulta = Entity.ba_cbte_ban_verificado.Where<ba_cbte_ban_verificado>(v => v.IdEmpresa == IdEmpresa && v.IdPeriodo == Idperiodo).ToList();


                    return (from q in Consulta select new ba_cbte_ban_verificado_Info { IdEmpresa= q.IdEmpresa,
                                                                                        tipo_IngEgr= q.tipo_IngEgr ,
                                                                                        SecuenciaCbteCble = q.SecuenciaCbteCble, 
                                                                                        Secuencia=q.Secuencia, 
                                                                                        observacion = q.observacion, 
                                                                                        IdTipocbte =q.IdTipocbte, 
                                                                                        IdPeriodo= q.IdPeriodo , 
                                                                                        IdCbteCble = q.IdCbteCble }).ToList();



                }
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
