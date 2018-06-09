using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_cbtecble_Plantilla_det_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_cbtecble_Plantilla_det_Data Data = new ct_cbtecble_Plantilla_det_Data();

        public List<ct_cbtecble_Plantilla_det_Info> Get_list_Cbtecble_det(int IdEmpresa)
        {
            try
            {
                return Data.Get_list_Planilla_det(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Planilla_det", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_det_Bus) };
            }

        }

        public List<ct_cbtecble_Plantilla_det_Info> Get_list_Cbtecble_det(int IdEmpresa, int IdTipoCbte, decimal IdPlantilla)
        {
            try
            {
                 return Data.Get_list_Planilla_det(IdEmpresa, IdTipoCbte, IdPlantilla);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Planilla_det", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_det_Bus) };
            }

        }

        public Boolean ModificarDB(ct_cbtecble_Plantilla_det_Info Info)
        {
            try
            {
                 return Data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_det_Bus) };
            }

        }

        public Boolean GrabarDB(ct_cbtecble_Plantilla_det_Info Info)
        {
            try
            {
                 return Data.GrabarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_det_Bus) };
            }

        }

        public Boolean GrabarDB(List<ct_cbtecble_Plantilla_det_Info> lista)
        {
            try
            {
                    return Data.GrabarDB(lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_det_Bus) };
            }

        }

        public Boolean EliminarDB(ct_cbtecble_Plantilla_det_Info Info)
        {
            try
            {
                return Data.EliminarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_det_Bus) };
            }

        }

        public Boolean EliminarDB(List<ct_cbtecble_Plantilla_det_Info> lm)
        {
            try
            {
               return Data.EliminarDB(lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_det_Bus) };
            }

        }

        public ct_cbtecble_Plantilla_det_Bus()
        {
           
        }
    }
}
