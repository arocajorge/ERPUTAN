using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.Roles;

namespace Core.Erp.Business.Roles
{
  public  class ro_Capacitaciones_x_Empleado_Bus
    {

        string mensaje = "";
        ro_Capacitaciones_x_Empleado_Data Data = new ro_Capacitaciones_x_Empleado_Data();

        public Boolean GuardarDB(List<ro_Capacitaciones_x_Empleado_Info> LstInfo)
        {
            try
            {
                return Data.GuardarDB(LstInfo);
             }
                
            
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_Capacitaciones_x_Empleado_Bus) };

            }
        }

        public List<ro_Capacitaciones_x_Empleado_Info> ConsultaXEmpleado(int idempresa, decimal idempleado)
        {
          try
            {
                return Data.Get_List_Capacitaciones_x_Empleado(idempresa, idempleado);

               
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaXEmpleado", ex.Message), ex) { EntityType = typeof(ro_Capacitaciones_x_Empleado_Bus) };

            }
        }


        public Boolean EliminarDB(List<ro_Capacitaciones_x_Empleado_Info> List)
        {
            try
            {
                
                return Data.EliminarDB(List);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_Capacitaciones_x_Empleado_Bus) };

            }

        }

    }
}
