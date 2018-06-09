using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Bancos
{
    public class ba_Conciliacion_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Conciliacion_Data data = new ba_Conciliacion_Data();
        ba_Conciliacion_det_IngEgr_Bus bus_det = new ba_Conciliacion_det_IngEgr_Bus();

        public List<vwba_TransaccionesAConciliar_Info> Get_List_Transacciones_x_Conciliar(int IdEmpresa, string IdCtaCble, DateTime F_inicio, DateTime F_fin)
        {
            try
            {
                return data.Get_List_Transacciones_x_Conciliar(IdEmpresa, IdCtaCble, F_inicio, F_fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ba_Conciliacion_Bus", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_Bus) };
            }
        }




        public List<vwba_TransaccionesAConciliar_Info> Get_List_Transacciones_x_Conciliar(int IdEmpresa, string IdCtaCble, DateTime F_inicio, DateTime F_fin, int IdConciliacion, int IdBanco)
        {
            try
            {
                return data.Get_List_Transacciones_x_Conciliar(IdEmpresa, IdCtaCble, F_inicio, F_fin,IdConciliacion,IdBanco);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ba_Conciliacion_Bus", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_Bus) };
            }
        }




        public List<ba_Conciliacion_Info> Get_List_Conciliacion(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return data.Get_List_Conciliacion(IdEmpresa, Fecha_ini, Fecha_fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Conciliacion", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_Bus) };
            }
        }

        public Boolean GrabarDB(ba_Conciliacion_Info info, ref decimal IdConciliacion, ref string msg)
        {
            try
            {
                Boolean RES = false;

                RES=data.GrabarDB(info, ref IdConciliacion, ref msg);
                if (RES == true)
                {
                    if (info.Estado_Conciliacion == "CONCILIADO")
                    {
                        foreach (var item in info.LstConciliadas)
                        {
                            ba_Cbte_Ban_Bus BusCbteBan = new ba_Cbte_Ban_Bus();
                            ba_Cbte_Ban_Info InfoCbteBan= new ba_Cbte_Ban_Info();
                            InfoCbteBan.IdEmpresa = item.IdEmpresa;
                            InfoCbteBan.IdTipocbte = item.IdTipocbte;
                            InfoCbteBan.IdCbteCble = item.IdCbteCble;

                            BusCbteBan.Modificar_estado_Cheq(InfoCbteBan, eEstado_Cheque.ESTCBCOB, ref msg);
                        }


                    }
                }


                return RES;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_Bus) };
            }
        }

        public Boolean ModificarDB(ba_Conciliacion_Info info)
        {
            try
            {
                string msg = "";

                Boolean RES = false;

                RES = data.ModificarDB(info);
                if (RES == true)
                {
                    if (info.Estado_Conciliacion == "CONCILIADO")
                    {
                        foreach (var item in info.LstConciliadas)
                        {
                            ba_Cbte_Ban_Bus BusCbteBan = new ba_Cbte_Ban_Bus();
                            ba_Cbte_Ban_Info InfoCbteBan = new ba_Cbte_Ban_Info();
                            InfoCbteBan.IdEmpresa = item.IdEmpresa;
                            InfoCbteBan.IdTipocbte = item.IdTipocbte;
                            InfoCbteBan.IdCbteCble = item.IdCbteCble;

                            BusCbteBan.Modificar_estado_Cheq(InfoCbteBan, eEstado_Cheque.ESTCBCOB, ref msg);
                        }


                    }
                }


                return RES;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_Bus) };
            }
        }

        /// <summary>
        /// Se decidió eliminar por completo de la base para asegurar consistencia de registros aprobado por RICARDO YANZA
        /// </summary>
        public Boolean EliminarDB(ba_Conciliacion_Info info)
        {
            try
            {
                bool res = false;
                if(bus_det.EliminarDB(info.IdEmpresa,info.IdConciliacion))
                    res = data.EliminarDB(info);
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_Bus) };
            }
        }

        public Boolean AnularDB(ba_Conciliacion_Info info)
        {
            try
            {
                return data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_Bus) };
            }
        }

        public ba_Conciliacion_Info Get_Info_Conciliacion_x_Rpt(int IdEmpresa, int IdConciliacion)
        {
            try
            {
                return data.Get_Info_Conciliacion_x_Rpt(IdEmpresa, IdConciliacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Conciliacion_x_Rpt", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_Bus) };
            }
        }
        
        public Boolean VerificarPeriodoConciliado(int IdEmpresa, int IdPeriodo, int IdBanco)
        {
            try
            {
               return data.VerificarPeriodoConciliado(IdEmpresa, IdPeriodo, IdBanco);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarPeriodoConciliado", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_Bus) };
            }

        }

        public Boolean VerificarConciliacionPrimeraVez(int IdEmpresa, int Idbanco)
        {
            try
            {
                  return data.VerificarConciliacionPrimeraVez(IdEmpresa, Idbanco);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarConciliacionPrimeraVez", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_Bus) };
            }

        }
        
        public ba_Conciliacion_Bus(){
           
        }
    }
}
