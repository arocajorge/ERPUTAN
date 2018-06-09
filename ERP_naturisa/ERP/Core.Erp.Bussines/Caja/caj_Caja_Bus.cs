using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Caja;
using Core.Erp.Data.Caja;

using Core.Erp.Business.General;


namespace Core.Erp.Business.Caja
{
    public class caj_Caja_Bus
    {
        caj_Caja_Data data = new caj_Caja_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";

        public List<caj_Caja_Info> Get_list_caja(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                return data.Get_list_caja(IdEmpresa, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_caja", ex.Message), ex) { EntityType = typeof(caj_Caja_Bus) };

               
            }
            
           
        }

        public caj_Caja_Info Get_Info_Caja(int IdEmpresa, int IdCaja, ref string MensajeError)
        {
            try
            {
                return data.Get_Info_Caja(IdEmpresa, IdCaja, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Caja", ex.Message), ex) { EntityType = typeof(caj_Caja_Bus) };
            }
        }
        
        public Boolean GrabarDB(caj_Caja_Info info, ref int idCaja, ref string MensajeError)
        {
            try
            {
                 return data.GrabarDB(info,ref idCaja, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(caj_Caja_Bus) };
            }

        }

        public Boolean ModificarDB(caj_Caja_Info info, ref string MensajeError)
        {
            try 
	        {	        
		        return data.ModificarDB(info, ref  MensajeError);
	        }
	        catch (Exception ex)
	        {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(caj_Caja_Bus) };
	        }

        }

        public Boolean Anular(caj_Caja_Info info, ref string MensajeError)
        {
            try 
	        {	        
	             return data.AnularDB(info, ref  MensajeError);	
	        }
	          catch (Exception ex)
	        {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(caj_Caja_Bus) };
	        }

        }

       

        public caj_Caja_Bus() {
           
        }
      
        
        }
}
