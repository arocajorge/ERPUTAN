using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_Inversion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Inversion_Data data = new ba_Inversion_Data();

        public List<ba_Inversion_Info> Get_List_Inversion(int IdEmpresa, ref string msg) 
        {
            try
            {
                return data.Get_List_Inversion(IdEmpresa,ref msg); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Inversion", ex.Message), ex) { EntityType = typeof(ba_Inversion_Bus) };
            }

        }
       
        public Boolean GrabarDB(ba_Inversion_Info Info, ref string msg)
        {
            try
            {
                return data.GrabarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Inversion_Bus) };
            }
 
        }

        public Boolean ModificarDB(ba_Inversion_Info Info, ref string msg)
        {
            try
            {
              return data.ModificarDB (Info, ref msg); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_Inversion_Bus) };
            }

        }
       
        public Boolean AnularDB(ba_Inversion_Info Info, ref string msg) 
        {
            try
            {
                 return data.AnularDB(Info, ref msg); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ba_Inversion_Bus) };
            }

        }
    }
}
