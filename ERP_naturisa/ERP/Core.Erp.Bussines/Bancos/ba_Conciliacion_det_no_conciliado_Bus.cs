using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_Conciliacion_det_no_conciliado_Bus
    {/*
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Conciliacion_det_no_conciliado_Data data = new ba_Conciliacion_det_no_conciliado_Data();


        public List<ba_Conciliacion_det_no_conciliado_Info> Get_List_Conciliacion_det_no_conciliado(int IdEmpresa, int IdConciliacion, int Secuencia)
        {
            try
            {
                return data.Get_List_Conciliacion_det_no_conciliado(IdEmpresa, IdConciliacion, Secuencia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Conciliacion_det_no_conciliado", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_no_conciliado_Bus) };
            }
        }

        public List<vwba_TransaccionesAConciliar_Info> Get_List_TransaccionesAConciliar(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                return data.Get_List_TransaccionesAConciliar(IdEmpresa, IdConciliacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_TransaccionesAConciliar", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_no_conciliado_Bus) };
            }
        }

        public Boolean GrabarDB(ba_Conciliacion_det_no_conciliado_Info info)
        {
            try
            {
                return data.GrabarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_no_conciliado_Bus) };
            }
        }

        public Boolean ModificarDB(ba_Conciliacion_det_no_conciliado_Info info)
        {
            try
            {
                return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_no_conciliado_Bus) };
            }
        }

        public Boolean AnularDB(ba_Conciliacion_det_no_conciliado_Info info)
        {
            try
            {
                return data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_no_conciliado_Bus) };
            }
        }

        public Boolean EliminarDB(int IdEmpresa, int IdConciliacion)
        {
            try
            {
                return data.EliminarDB(IdEmpresa, IdConciliacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ba_Conciliacion_det_no_conciliado_Bus) };
            }
        }


        public ba_Conciliacion_det_no_conciliado_Bus()
        {
           
        }
  * */
    }
}
