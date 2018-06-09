using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Compras_Edehsa;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras_Edehsa
{
    public class com_ListadoDisenoTipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        com_ListadoDisenoTipo_Data data = new com_ListadoDisenoTipo_Data();

        public List<com_ListadoDisenoTipo_Info> ObtenerListadoDisenoTipo(int idempresa)
        {
            try
            {
                return data.ObtenerListaDisenoTipo(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaOT_x_CentroCosto", ex.Message), ex) { EntityType = typeof(com_ListadoDisenoTipo_Bus) };
            }
        }
    }
}
