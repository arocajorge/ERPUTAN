using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_conversion_cusCidersus_x_in_movi_inven_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_conversion_cusCidersus_x_in_movi_inven_Data Data = new prd_conversion_cusCidersus_x_in_movi_inven_Data();
     
        public Boolean GuardarDB(prd_conversion_cusCidersus_x_in_movi_inven_Info Info)
        {
            try
            {
               return Data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_conversion_cusCidersus_x_in_movi_inven_Bus) };
                
            }

        }

        public List<prd_conversion_cusCidersus_x_in_movi_inven_Info> Get_List_conversion_cusCidersus_x_in_movi_inve(int IdEmpresa, decimal IdConversion)
        {
            try
            {
                return Data.Get_List_conversion_cusCidersus_x_in_movi_inven(IdEmpresa, IdConversion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consultar", ex.Message), ex) { EntityType = typeof(prd_conversion_cusCidersus_x_in_movi_inven_Bus) };
                
            }

        }
    }
}
