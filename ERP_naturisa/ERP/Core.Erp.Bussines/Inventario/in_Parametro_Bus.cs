using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_Parametro_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_Parametro_Data oData = new in_Parametro_Data();

        public Boolean ModificarDB(in_Parametro_Info inf, int IdEmpresa)
        {
            try
            {
                return oData.ModificarDB(inf, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(in_Parametro_Bus) };

            }
        }
        
        public in_Parametro_Info Get_Info_Parametro(int IdEmpresa)
        {
            try
            {
                in_Parametro_Info oinfo = new in_Parametro_Info();


               oinfo= oData.Get_Info_Parametro(IdEmpresa);
               return oinfo;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerParametros", ex.Message), ex) { EntityType = typeof(in_Parametro_Bus) };
            }
        }
    }
}
