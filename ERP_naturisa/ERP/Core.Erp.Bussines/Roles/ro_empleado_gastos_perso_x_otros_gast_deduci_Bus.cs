using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_empleado_gastos_perso_x_otros_gast_deduci_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_empleado_gastos_perso_x_otros_gast_deduci_Data Data = new ro_empleado_gastos_perso_x_otros_gast_deduci_Data();

        public List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info> Get_List_empleado_gastos_perso_x_otros_gast_deduc(int IdEmpresa, decimal IdEmpleado, int anio)
        {
            try
            {
                return Data.Get_List_empleado_gastos_perso_x_otros_gast_deduci(IdEmpresa, IdEmpleado, anio);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_gastos_perso_x_otros_gast_deduci", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_x_otros_gast_deduci_Bus) };
            }

        }


        public Boolean GrabarDB(List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info> info)
        {
            try
            {
                return Data.GrabarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_x_otros_gast_deduci_Bus) };
            }

        }

        public Boolean consultarAnio(int IdEmpresa, int IdEmpleado, int anio)
        {
            try
            {
                return Data.consultarAnio(IdEmpresa, IdEmpleado, anio);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "consultarAnio", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_x_otros_gast_deduci_Bus) };
            }

        }

        public Boolean EliminarDB(ro_empleado_gastos_perso_x_otros_gast_deduci_Info info)
        {
            try
            {
                 return Data.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_x_otros_gast_deduci_Bus) };
            }

        }


         public Boolean GrabarBD(ro_empleado_gastos_perso_x_otros_gast_deduci_Info info, ref string msg)
         {
           try
            {
                return Data.GrabarBD(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_x_otros_gast_deduci_Bus) };
            }

        }

         public Boolean EliminarBD(int IdEmpresa, decimal IdEmpleado, int anioFiscal, ref string msg)
         {
             try
             {
                 return Data.EliminarBD(IdEmpresa, IdEmpleado, anioFiscal, ref msg);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_x_otros_gast_deduci_Bus) };
             }

         }






    }
}
