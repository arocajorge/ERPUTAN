using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_Embarcador_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        imp_Embarcador_Data oDat = new imp_Embarcador_Data();

        public List<imp_Embarcador_Info> ListaEmbarcadores()
        {
            try
            {
                return oDat.Get_List_Embarcador();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaEmbarcadores", ex.Message), ex) { EntityType = typeof(imp_DatosEmbarque_bus) };
            }

        
        }


        public Boolean GuardarDB(ref imp_Embarcador_Info Info)
        {
            try
            {
                 return oDat.GuardarDB(ref Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(imp_DatosEmbarque_bus) };
            
            }

        }

        public Boolean ModificarDB(imp_Embarcador_Info Info)
        {
            try
            {
                return oDat.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(imp_DatosEmbarque_bus) };
            
            }

        }

        public Boolean AnularDB(imp_Embarcador_Info Info)
        {
            try
            {
                  return oDat.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(imp_DatosEmbarque_bus) };
            
            }

        }
    }
}
