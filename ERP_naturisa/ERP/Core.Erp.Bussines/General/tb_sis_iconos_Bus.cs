using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Data.General;



namespace Core.Erp.Business.General
{
    public class tb_sis_iconos_Bus
    {

        
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";


        tb_sis_iconos_Data OData = new tb_sis_iconos_Data();


        public List<tb_sis_iconos_Info> Get_List_iconos()
        {
            try
            {
                return OData.Get_List_iconos();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLista_Iconos", ex.Message), ex) { EntityType = typeof(tb_sis_iconos_Bus) };
         
                
            }

        }


        public Boolean GrabarDB(tb_sis_iconos_Info info,ref string msgError)
        {

            try
            {
                return OData.GrabarDB(info,ref  msgError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(tb_sis_iconos_Bus) };
         
                
            }

              
        }


        public tb_sis_iconos_Bus()
        {

        }
    }
}
