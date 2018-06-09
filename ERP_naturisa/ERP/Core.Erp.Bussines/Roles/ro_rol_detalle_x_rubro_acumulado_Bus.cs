
/*CLASE: ro_rol_detalle_x_rubro_acumulado_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 14-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_rol_detalle_x_rubro_acumulado_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        ro_rol_detalle_x_rubro_acumulado_Data oData = new ro_rol_detalle_x_rubro_acumulado_Data();


        public List<ro_rol_detalle_x_rubro_acumulado_Info> GetListConsultaPorEmpleado(int idEmpresa, decimal idEmpleado, string IdRubro)
        {

            try
            {
                return oData.GetListConsultaPorEmpleado(idEmpresa, idEmpleado, IdRubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorEmpleado", ex.Message), ex) { EntityType = typeof(ro_rol_detalle_x_rubro_acumulado_Bus) };
            }
        }




         public Boolean GuardarBD(ro_rol_detalle_x_rubro_acumulado_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                valorRetornar = oData.GuardarBD(info, ref mensaje);
                return valorRetornar;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_rol_detalle_x_rubro_acumulado_Bus) };
            }
        }  
  


      public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui, int idPeriodo, decimal idEmpleado, ref string msg)
       {
        try{
            return oData.EliminarBD(idEmpresa, idNomina, idNominaLiqui, idPeriodo, idEmpleado, ref mensaje);
   
       }catch (Exception ex){
           Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
           throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_rol_detalle_x_rubro_acumulado_Bus) };
            }
       }

      public List<ro_rol_detalle_x_rubro_acumulado_Info> GetListConsultaPorEmpleado(int idEmpresa,int IdNomina_Tipo, decimal idEmpleado)
      {

          try
          {
              return oData.GetListConsultaPorEmpleado(idEmpresa,IdNomina_Tipo, idEmpleado);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorEmpleado", ex.Message), ex) { EntityType = typeof(ro_rol_detalle_x_rubro_acumulado_Bus) };
          }
      }


    }
}
