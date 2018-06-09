using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Business.General;

namespace Core.Erp.Business.ActivoFijo
{
    public class Af_Parametros_Bus
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        Af_Parametros_Data oDat = new Af_Parametros_Data();
        Af_Parametros_Info info = new Af_Parametros_Info();
        #endregion

        public Boolean ModificarDB(Af_Parametros_Info info)
        {
            try
            {
                return oDat.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(Af_Parametros_Bus) };
            }
        }

        public Af_Parametros_Info Get_Info_Parametros(int IdEmpresa)
        {
            try
            {
                return oDat.Get_Info_Parametros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Parametros", ex.Message), ex) { EntityType = typeof(Af_Parametros_Bus) };
            }
        }

    }
}
