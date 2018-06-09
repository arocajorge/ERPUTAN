using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_EficienciaPiezas_Rpt_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_EficienciaPiezas_Rpt_Data data = new prd_EficienciaPiezas_Rpt_Data();

        public prd_EficienciaPiezas_Rpt_Info ObtenerReporte(int idempresa, int idsucursal, string IdCentroCosto)
        {
            try
            {
                return data.ObtenerReporte(idempresa, idsucursal, IdCentroCosto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerReporte", ex.Message), ex) { EntityType = typeof(prd_EficienciaPiezas_Rpt_Bus) };
                
            }
        }
    }
}
