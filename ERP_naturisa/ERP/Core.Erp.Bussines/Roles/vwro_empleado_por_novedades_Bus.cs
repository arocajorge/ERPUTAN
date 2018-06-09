/*CLASE: vwro_empleado_por_novedades_Bus
 *CREADA POR: ALBERTO MENA
 *FECHA: 09-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;

namespace Core.Erp.Business.Roles
{
     public class vwro_empleado_por_novedades_Bus
    {
      string mensaje = "";
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      vwro_empleado_por_novedades_Data oData = new vwro_empleado_por_novedades_Data();

       public List<vwro_empleado_por_novedades_Info> ConsultaGeneral(int idEmpresa) {
             try{
                 return oData.ConsultaGeneral(idEmpresa);
             }
             catch (Exception ex){
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(vwro_empleado_por_novedades_Bus) };
             }
         }


    }
}
