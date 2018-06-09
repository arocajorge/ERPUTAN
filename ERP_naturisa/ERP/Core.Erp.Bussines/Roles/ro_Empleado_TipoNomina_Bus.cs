/*CLASE: ro_Empleado_TipoNomina_Bus
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 26-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.Roles;
using Core.Erp.Data.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Empleado_TipoNomina_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Empleado_TipoNomina_Data odata = new ro_Empleado_TipoNomina_Data();

        public Boolean GrabarDB(ro_Empleado_TipoNomina_Info Info, ref string msg)
        {
            try
            {
                return odata.GrabarDB(Info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_TipoNomina_Bus) };
            }

        }

        public List<ro_Empleado_TipoNomina_Info> Get_List_Empleado_TipoNomina(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_Empleado_TipoNomina(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_TipoNomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_TipoNomina_Bus) };
            }

        }


        public List<ro_Empleado_TipoNomina_Info> Get_List_Empleado_TipoNomina_x_IdEmpleado(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return odata.Get_List_Empleado_TipoNomina_x_IdEmpleado(IdEmpresa,IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_TipoNomina_x_IdEmpleado", ex.Message), ex) { EntityType = typeof(ro_Empleado_TipoNomina_Bus) };
            }            
        }

        public ro_Empleado_TipoNomina_Info Get_Info_Empleado_TipoNomina(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return odata.Get_Info_Empleado_TipoNomina(IdEmpresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Empleado_TipoNomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_TipoNomina_Bus) };
            }

        }

        public Boolean ModificarDB(ro_Empleado_TipoNomina_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_TipoNomina_Bus) };
            }

        }

        public Boolean ExisteNomina(int idempresa, decimal idempleado, int IdNomina)
        {

            try
            {
                ro_Empleado_TipoNomina_Data data = new ro_Empleado_TipoNomina_Data();
                return data.ExisteNomina(idempresa, idempleado, IdNomina);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteNomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_TipoNomina_Bus) };
            }

        }

        public Boolean EliminarDB(ro_Empleado_TipoNomina_Info info)
        {
            try
            {
                return odata.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_TipoNomina_Bus) };
            }

        }


        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, ref string msg)
        {
            try
            {
                return odata.EliminarBD(idEmpresa, idEmpleado, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Empleado_TipoNomina_Bus) };
            }

        }




    }
}
