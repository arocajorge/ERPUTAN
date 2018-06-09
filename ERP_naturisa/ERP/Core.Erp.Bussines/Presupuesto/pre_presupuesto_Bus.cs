using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Presupuesto;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Presupuesto
{
    public class pre_presupuesto_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
       
        pre_presupuesto_Data data = new pre_presupuesto_Data();
        public List<pre_presupuesto_Info> Get_List_pre_presupuesto(int IdEmpresa, string IdAnio, decimal IdPresupuesto)
        {
            try
            {
             return data.Get_List_pre_presupuesto(IdEmpresa, IdAnio, IdPresupuesto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "obtener", ex.Message), ex) { EntityType = typeof(pre_presupuesto_Bus) };

            }

        }
        public List<pre_presupuesto_Info> obtenerList(int IdEmpresa)
        {
            try
            {
                  return data.Get_List_pre_presupuesto(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "obtenerList", ex.Message), ex) { EntityType = typeof(pre_presupuesto_Bus) };

            }

        }
        public List<pre_presupuesto_Info> Get_List_pre_presupuest(int IdEmpresa, string IdAnio)
        {
            try
            {
                return data.Get_List_pre_presupuest(IdEmpresa, IdAnio);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "obtenerParaCombo", ex.Message), ex) { EntityType = typeof(pre_presupuesto_Bus) };

            }

        }
        public Boolean ModificarDB(int IdEmpresa, List<pre_presupuesto_Info> lista)
        {
            try
            {
              return data.ModificarDB(IdEmpresa, lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(pre_presupuesto_Bus) };

            }

        }
        public Boolean GuardarDB(int IdEmpresa, List<pre_presupuesto_Info> lista)
        {
            try
            {
                return data.GuardarDB(IdEmpresa, lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(pre_presupuesto_Bus) };

            }

        }
        public List<pre_presupuesto_Info> Get_List_pre_presupuesto_x_cta(int IdEmpresa, string IdAnio, decimal IdPresupuesto)
        {
            try
            {
             return data.Get_List_pre_presupuesto_x_cta(IdEmpresa, IdAnio, IdPresupuesto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "obtenerVistaPrexCta", ex.Message), ex) { EntityType = typeof(pre_presupuesto_Bus) };

            }

        }
    }
}
