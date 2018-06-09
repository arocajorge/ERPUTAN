using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.Produccion_Edehsa;
using Core.Erp.Business.General;
using Core.Erp.Info.Produccion_Edehsa;


namespace Core.Erp.Business.Produccion_Edehsa
{
    public class vwprd_Guia_Remision_Electronica_Bus
    {

        vwprd_Guia_Remision_Electronica_Data odata = new vwprd_Guia_Remision_Electronica_Data();

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<vwprd_Guia_Remision_Electronica_Info> Get_List_vwprd_Guia_Remision_Electronica(string CodGuiaRemision)
        {
            try
            {
                return odata.Get_List_vwprd_Guia_Remision_Electronica(CodGuiaRemision);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_TerminoPago", ex.Message), ex) { EntityType = typeof(vwprd_Guia_Remision_Electronica_Bus) };

            }

        }

    }
}
