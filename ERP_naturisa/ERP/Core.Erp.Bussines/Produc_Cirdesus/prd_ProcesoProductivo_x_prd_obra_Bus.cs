using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_ProcesoProductivo_x_prd_obra_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_ProcesoProductivo_x_prd_obra_Data data = new prd_ProcesoProductivo_x_prd_obra_Data();
        
        public List<prd_ProcesoProductivo_x_prd_obra_Info> ObtenerProcesProductivo_x_CentroCosto(int idempresa, string IdCentroCosto)
        {
            try
            {
                return data.ObtenerProcesProductivo_x_CentroCosto(idempresa, IdCentroCosto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerProcesProductivo_x_CentroCosto", ex.Message), ex) { EntityType = typeof(prd_ProcesoProductivo_x_prd_obra_Bus) };
              
            }
        }

        public prd_ProcesoProductivo_x_prd_obra_Info Obtener1ProcesProductivo_x_CentroCosto(int idempresa, string IdCentroCosto)
        {
            try
            {
                return data.Obtener1ProcesProductivo_x_CentroCosto(idempresa, IdCentroCosto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener1ProcesProductivo_x_CentroCosto", ex.Message), ex) { EntityType = typeof(prd_ProcesoProductivo_x_prd_obra_Bus) };
              
            }
        }
    }
}
