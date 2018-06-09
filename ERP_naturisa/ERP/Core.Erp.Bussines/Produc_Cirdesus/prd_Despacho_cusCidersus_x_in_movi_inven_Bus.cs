using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_Despacho_cusCidersus_x_in_movi_inven_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_Despacho_cusCidersus_x_in_movi_inven_Data data = new prd_Despacho_cusCidersus_x_in_movi_inven_Data();

        public Boolean GuardarDB(prd_Despacho_cusCidersus_x_in_movi_inven_Info Info, ref string msg)
        {
            try
            {

                return data.GuardarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_Despacho_cusCidersus_x_in_movi_inven_Bus) };
                
            }
        
        }

        public List<prd_Despacho_cusCidersus_x_in_movi_inven_Info> ConsultaGeneral(int idempresa, ref string msg)
        {
            try
            {

                return data.ConsultaGeneral(idempresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prd_Despacho_cusCidersus_x_in_movi_inven_Bus) };
                
            }
        
        
        
        }

        public prd_Despacho_cusCidersus_x_in_movi_inven_Info TI_x_Despacho(prd_Despacho_Info Desp, ref string msg)
        {
            try
            {

                return data.TI_x_Despacho (Desp, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TI_x_Despacho", ex.Message), ex) { EntityType = typeof(prd_Despacho_cusCidersus_x_in_movi_inven_Bus) };
                
            }



        }

    }
}
