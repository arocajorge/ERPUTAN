using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_parametros_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cp_parametros_Data oDat = new cp_parametros_Data();
        cp_parametros_Info info = new cp_parametros_Info();

        public Boolean ModificarDB(cp_parametros_Info inf)
        {
            try
            {
                return oDat.ModificarDB(inf);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_parametros_Bus) };
            }
        }


        public Boolean Modificar_Diseño_reporte(cp_parametros_Info info)
        {

            try
            {
                return oDat.Modificar_Diseño_reporte(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_tipo_x_empresa", ex.Message), ex) { EntityType = typeof(cp_parametros_Bus) };
            }

        }

       

        public cp_parametros_Info Get_Info_parametros(int IdEmpresa)
        {
            try
            {
                 return oDat.Get_Info_parametros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_parametros", ex.Message), ex) { EntityType = typeof(cp_parametros_Bus) };
            }
        }

    }
}
