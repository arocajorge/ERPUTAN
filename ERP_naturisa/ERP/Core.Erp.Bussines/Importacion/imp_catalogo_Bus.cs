using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_catalogo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        imp_catalogo_Data oDat = new imp_catalogo_Data();

        public List<imp_catalogo_Info> Get_List_catalogo()
        {
            try
            {
                   return oDat.Get_List_catalogo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLista", ex.Message), ex) { EntityType = typeof(imp_catalogo_Bus) };
         
            }

        }
       
        public Boolean AnularDB(imp_catalogo_Info info)
        {
            try
            {
                return oDat.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar", ex.Message), ex) { EntityType = typeof(imp_catalogo_Bus) };
         
            }
        }

        public Boolean ModificarDB(imp_catalogo_Info inf)
        {
            try
            {
                return oDat.ModificarDB(inf);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(imp_catalogo_Bus) };
            }
        }

        public Boolean GrabarDB(imp_catalogo_Info inf, ref string Mensaje)
        {
            try
            {
                return oDat.GrabarDB(inf, ref Mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar", ex.Message), ex) { EntityType = typeof(imp_catalogo_Bus) };
            
            }
        }
    }
}
