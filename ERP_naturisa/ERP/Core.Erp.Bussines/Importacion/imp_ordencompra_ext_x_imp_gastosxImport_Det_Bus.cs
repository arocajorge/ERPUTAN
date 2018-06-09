using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Importacion;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        imp_ordencompra_ext_x_imp_gastosxImport_Det_Data data = new imp_ordencompra_ext_x_imp_gastosxImport_Det_Data();

        public List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> Get_List_ordencompra_ext_x_imp_gastosxImport_Det(imp_ordencompra_ext_x_imp_gastosxImport_Info Info)
        {
            try
            {
                return data.Get_List_ordencompra_ext_x_imp_gastosxImport_Det(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus) };
            
            }


        }
        
        public List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> Get_List_ordencompra_ext_x_imp_gastosxImport_Det_x_OC(imp_ordencompra_ext_Info Info)
        {
            try
            {
                return data.Get_List_ordencompra_ext_x_imp_gastosxImport_Det_x_OC(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus) };
            
            }

        }

        public Boolean EliminarDB(imp_ordencompra_ext_x_imp_gastosxImport_Info Info, ref string msg)
        {
            try
            {
                return data.EliminarDB(Info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarLista", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus) };
            
            }
        }

    }
}
