/*CLASE: ro_Area_X_Departamento_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 07-07-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Area_X_Departamento_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Area_X_Departamento_Data oData = new ro_Area_X_Departamento_Data();


        public List<ro_Area_X_Departamento_Info> getListPorArea(int idEmpresa, ref string msg)
        {
            try
            {
                return oData.Get_List_Area_X_Departamento(idEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getListPorArea", ex.Message), ex) { EntityType = typeof(ro_Area_X_Departamento_Bus) };

            }
        }


      public Boolean GrabarBD(ro_Area_X_Departamento_Info info, ref string msg){
            try
            {
                return oData.GrabarBD(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_Area_X_Departamento_Bus) };

            }
        }

      public Boolean EliminarBD(int idEmpresa, ref string msg)
      {
            try
            {
                return oData.EliminarBD(idEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Area_X_Departamento_Bus) };

            }
        }





    }
}
