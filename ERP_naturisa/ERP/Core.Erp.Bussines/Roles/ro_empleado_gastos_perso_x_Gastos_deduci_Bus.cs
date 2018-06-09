using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_empleado_gastos_perso_x_Gastos_deduci_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_empleado_gastos_perso_x_Gastos_deduci_Data Data = new ro_empleado_gastos_perso_x_Gastos_deduci_Data();

        public List<ro_empleado_gastos_perso_x_Gastos_deduci_Info> Get_List_empleado_gastos_perso_x_Gastos_dedu(int IdEmpresa, decimal IdEmpleado, int anio)
        {
            try
            {
                return Data.Get_List_empleado_gastos_perso_x_Gastos_deduc(IdEmpresa, IdEmpleado, anio);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_Bus) };
            }

        }

        public Boolean GrabarEGPXGD(List<ro_empleado_gastos_perso_x_Gastos_deduci_Info> info)
        {
            try
            {
                return Data.GrabarDB_EGPXGD(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB_EGPXGD", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_Bus) };
            }
        }

        public Boolean GrabarBD(ro_empleado_gastos_perso_x_Gastos_deduci_Info info, ref string msg)
        {
            try
            {
                return Data.GrabarBD(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_Bus) };
            }
        }

        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, int AnioFiscal, ref string msg)
        {
            try
            {
                return Data.EliminarBD(idEmpresa, idEmpleado, AnioFiscal, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_Bus) };
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "consultarAnio", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_Bus) };
            }

        }

        public Boolean Eliminar_EGPXGD(ro_empleado_gastos_perso_x_Gastos_deduci_Info info)
        {
            try
            {
              return Data.Eliminar_EGPXGD(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar_EGPXGD", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_Bus) };
            }

        }        
    }
}
