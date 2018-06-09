using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_Conversion_det_CusCidersus_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_Conversion_det_CusCidersus_Data data = new prd_Conversion_det_CusCidersus_Data();

        public List<prd_Conversion_det_CusCidersus_Info> Counsultar(int IdEmpresa, decimal IdConversion)
        {
            try
            {
               return data.Counsultar(IdEmpresa,IdConversion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Counsultar", ex.Message), ex) { EntityType = typeof(prd_Conversion_det_CusCidersus_Bus) };
                
            }

        }
    }
}
