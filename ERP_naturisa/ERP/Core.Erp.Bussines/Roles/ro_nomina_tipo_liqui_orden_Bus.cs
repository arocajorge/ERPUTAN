/*CLASE: ro_nomina_tipo_liqui_orden_Bus
 *CREADA POR: ALBERTO MENA
 *FECHA: 17-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;


namespace Core.Erp.Business.Roles
{
    public class ro_nomina_tipo_liqui_orden_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_nomina_tipo_liqui_orden_Data oData=new ro_nomina_tipo_liqui_orden_Data();

        public List<ro_nomina_tipo_liqui_orden_Info> Get_List_nomina_tipo_liqui_orden(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui)
        {
            try
            {
                return oData.Get_List_nomina_tipo_liqui_orden(idEmpresa, idNominaTipo, idNominaTipoLiqui, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_nomina_tipo_liqui_orden", ex.Message), ex) { EntityType = typeof(ro_nomina_tipo_liqui_orden_Bus) };
            }

        }

    }
}
