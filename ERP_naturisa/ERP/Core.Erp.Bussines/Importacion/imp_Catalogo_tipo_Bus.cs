using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Importacion;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_Catalogo_tipo_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        imp_Catalogo_tipo_Data oData = new imp_Catalogo_tipo_Data();

        public List<imp_Catalogo_tipo_info> Get_List_Catalogo_tipo()
        {
            List<imp_Catalogo_tipo_info> lm = new List<imp_Catalogo_tipo_info>();            
            try
            {
                lm = oData.Get_List_Catalogo_tipo();
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "listaTipoCatalogo", ex.Message), ex) { EntityType = typeof(imp_Catalogo_tipo_Bus) };
            
            }
        }

        public Boolean GrabarDB(imp_Catalogo_tipo_info inf)
        {
            try
            {                
                return oData.GrabarDB(inf);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar", ex.Message), ex) { EntityType = typeof(imp_Catalogo_tipo_Bus) };
            
            }
        }

        public int GetId(imp_Catalogo_tipo_info inf)
        {
            try
            {
                return oData.GetId(inf);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "cargarId", ex.Message), ex) { EntityType = typeof(imp_Catalogo_tipo_Bus) };
            
            }
        }

        public Boolean ModificarDB(imp_Catalogo_tipo_info inf)
        {
            try
            {
                return oData.ModificarDB(inf);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(imp_Catalogo_tipo_Bus) };
            
            }
        }



    }
}
