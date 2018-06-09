using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

using Core.Erp.Business.General;


namespace Core.Erp.Business.CuentasxPagar
{
   public class cp_Autorizacion_x_Doc_x_Pag_Bus
    {
       string mensaje = "";
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

       cp_Autorizacion_x_Doc_x_Pag_Data odata = new cp_Autorizacion_x_Doc_x_Pag_Data();

        public Boolean GuardarDB(cp_Autorizacion_x_Doc_x_Pag_Info Info, ref string msg)
        {
            try
            {
                return odata.GuardarDB(Info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_Autorizacion_x_Doc_x_Pag_Bus) };
            }
        }


        public Boolean Verificar_NumAutorizacion_Ogiro(string NumAutorizacion, ref string msg)
        {
            try
            {

                return odata.Verificar_NumAutorizacion_Ogiro(NumAutorizacion, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Verificar_NumAutorizacion_Ogiro", ex.Message), ex) { EntityType = typeof(cp_Autorizacion_x_Doc_x_Pag_Bus) };
            }
        }
    }
}
