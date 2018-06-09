using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_Plancta_nivel_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<ct_Plancta_nivel_Info> Get_list_Plancta_nivel(int IdEmpresa)
        {
            List<ct_Plancta_nivel_Info> lm = new List<ct_Plancta_nivel_Info>();
            ct_Plancta_nivel_Data data = new ct_Plancta_nivel_Data();
            try
            {
                lm = data.Get_list_Plancta_nivel(IdEmpresa);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Plancta_nivel", ex.Message), ex) { EntityType = typeof(ct_Plancta_nivel_Bus) };
            }
        }

        public ct_Plancta_nivel_Info Get_info_plancta_nivel(int IdEmpresa, int IdNivelCta)
        {
            try
            {
                ct_Plancta_nivel_Data data = new ct_Plancta_nivel_Data();
                return  data.Get_info_plancta_nivel(IdEmpresa, IdNivelCta);                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_info_plancta_nivel", ex.Message), ex) { EntityType = typeof(ct_Plancta_nivel_Bus) };
            }
        }

        public Boolean ModificarDB(ct_Plancta_nivel_Info _PlanCtaNivelInfo)
        {
            try
            {
                ct_Plancta_nivel_Data data = new ct_Plancta_nivel_Data();
                return data.ModificarDB(_PlanCtaNivelInfo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_Plancta_nivel_Bus) };
            }
        }

        public Boolean EliminarDB(int IdEmpresa)
        {
            try
            {
                ct_Plancta_nivel_Data data = new ct_Plancta_nivel_Data();
                return data.EliminarDB(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_Plancta_nivel_Bus) };
            }
        
        }

        public Boolean AnularDB(ct_Plancta_nivel_Info _PlanCtaNivelInfo)
        {
            try
            {
                ct_Plancta_nivel_Data data = new ct_Plancta_nivel_Data();
                return data.AnularDB(_PlanCtaNivelInfo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_Plancta_nivel_Bus) };
            }
        }

        public Boolean GrabarDB(ct_Plancta_nivel_Info _PlanCtaNivelInfo)
        {
            try
            {
                ct_Plancta_nivel_Data data = new ct_Plancta_nivel_Data();
                return data.GrabarDB(_PlanCtaNivelInfo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Plancta_nivel_Bus) };
            }
        }

        public Boolean GrabarDB(List<ct_Plancta_nivel_Info> _ListPlanCtaNivelInfo)
        {
            try
            {
                ct_Plancta_nivel_Data data = new ct_Plancta_nivel_Data();
                return data.GrabarDB(_ListPlanCtaNivelInfo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Plancta_nivel_Bus) };
            }
        }

        public ct_Plancta_nivel_Bus()
        {
            
        }
    }
}
