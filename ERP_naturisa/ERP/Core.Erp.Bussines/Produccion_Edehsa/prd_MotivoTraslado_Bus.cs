using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Produccion_Edehsa;
using Core.Erp.Info.Produccion_Edehsa;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Edehsa
{
    public class prd_MotivoTraslado_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
       pr_MotivoTraslado_Data data = new pr_MotivoTraslado_Data();

        public List<prd_MotivoTraslado_Info> ObtenerMotivoTraslado(int idempresa)
        {
            try
            {
                return data.ObtenerMotivoTraslado(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaOT_x_CentroCosto", ex.Message), ex) { EntityType = typeof(prd_MotivoTraslado_Bus) };
            }
        }
    }
}