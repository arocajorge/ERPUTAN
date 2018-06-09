using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Business.General;

namespace Core.Erp.Business.ActivoFijo
{
    public class Af_PeriodoDepreciacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<Af_PeriodoDepreciacion_Info> Get_List_PeriodoDepreciacion()
        {
            List<Af_PeriodoDepreciacion_Info> lM = new List<Af_PeriodoDepreciacion_Info>();
            Af_PeriodoDepreciacion_Data data = new Af_PeriodoDepreciacion_Data();
            try
            {
                lM = data.Get_List_PeriodoDepreciacion();
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PeriodoDepreciacion", ex.Message), ex) { EntityType = typeof(Af_PeriodoDepreciacion_Bus) };
            }
        }

    }
}
