using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Empleado_estudios_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        ro_Empleado_estudios_Data oRo_Empleado_estudios_Data = new ro_Empleado_estudios_Data();


        public Boolean GrabarDB(ro_Empleado_estudios_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                if (oRo_Empleado_estudios_Data.getExiste(info))
                {
                    valorRetornar = oRo_Empleado_estudios_Data.ModificarDB(info, ref msg);             
                }else
                {
                    valorRetornar = oRo_Empleado_estudios_Data.GrabarDB(info, ref msg);
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_estudios_Bus) };
            }

        }

        public List<ro_Empleado_estudios_Info> Get_List_Empleado_estudios(int IdEmpresa)
        {
            try
            {
                return oRo_Empleado_estudios_Data.Get_List_Empleado_estudios(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_estudios", ex.Message), ex) { EntityType = typeof(ro_Empleado_estudios_Bus) };
            }

        }

        public List<ro_Empleado_estudios_Info> Get_List_Empleado_estudios(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return oRo_Empleado_estudios_Data.Get_List_Empleado_estudios(IdEmpresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_estudios", ex.Message), ex) { EntityType = typeof(ro_Empleado_estudios_Bus) };
            }

        }

        public Boolean ModificarDB(ro_Empleado_estudios_Info info, ref string msg)
        {
            try
            {
                return oRo_Empleado_estudios_Data.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_estudios_Bus) };
            }

        }

        public Boolean AnularDB(ro_Empleado_estudios_Info info)
        {
            try
            {
                return oRo_Empleado_estudios_Data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_estudios_Bus) };
            }

        }

        public int getId(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return oRo_Empleado_estudios_Data.getId(IdEmpresa, IdEmpleado);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(ro_Empleado_estudios_Bus) };
            }
        }

        public Boolean EliminarBD(int IdEmpresa, decimal IdEmpleado, ref string msg)
        {
            try
            {
                return oRo_Empleado_estudios_Data.EliminarBD(IdEmpresa, IdEmpleado, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Empleado_estudios_Bus) };
            }
        }



    }
}
