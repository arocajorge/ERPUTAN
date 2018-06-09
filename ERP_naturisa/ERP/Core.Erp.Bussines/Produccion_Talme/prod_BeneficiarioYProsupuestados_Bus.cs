using Core.Erp.Info.Produccion_Talme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Talme
{
    public class prod_BeneficiarioYProsupuestados_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prod_BeneficiarioYProsupuestados_Data oData = new prod_BeneficiarioYProsupuestados_Data();
        public List<prod_BeneficiarioYProsupuestados_Info> Get_List_BeneficiarioYProsupuestados(int IdEmpresa)
        {
            try
            {
                 return oData.Get_List_BeneficiarioYProsupuestados(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(prod_BeneficiarioYProsupuestados_Bus) };

            }

        }
    }
}
