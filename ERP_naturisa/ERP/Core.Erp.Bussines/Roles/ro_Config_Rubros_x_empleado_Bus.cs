/*CLASE: ro_Config_Rubros_x_empleado_Bus
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 16-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Config_Rubros_x_empleado_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        ro_Config_Rubros_x_empleado_Data odata = new ro_Config_Rubros_x_empleado_Data();

        public Boolean GuardarDB(ro_Config_Rubros_x_empleado_Info Info, ref string msg)
        {
            try
            {
                return odata.GuardarDB(Info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }

        }

        public List<ro_Config_Rubros_x_empleado_Info> ConsultaGeneral( int IdEmpresa)
        {
            try
            {
                return odata.Get_List_Config_Rubros_x_empleado(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }

        }

        public ro_Config_Rubros_x_empleado_Info ObtenerObjeto(string IdRubro)
        {
            try
            {
                return odata.Get_Info_Config_Rubros(IdRubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }

        }

        public Boolean ModificarDB(ro_Config_Rubros_x_empleado_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }

        }

        public Boolean Borrar(ro_Config_Rubros_x_empleado_Info Info)
        {
            try
            {
              return odata.Borrar(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Borrar", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }

        }

        public int getId(int IdEmpresa)
        {
            try
            {
                ro_Config_Rubros_x_empleado_Data data = new ro_Config_Rubros_x_empleado_Data();
                return data.getId(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };


            }
        }

        public Boolean modificarRubrosxEmpleado(ro_Config_Rubros_x_empleado_Info Info, string msg)
        {
            try
            {
                ro_Config_Rubros_x_empleado_Data data = new ro_Config_Rubros_x_empleado_Data();

                return data.modificarRubrosxEmpleado(Info, msg);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "modificarRubrosxEmpleado", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }


        }

        //30/10/2013
        public Boolean GuardarConfigRubroxEmpleadoI(List<ro_Config_Rubros_x_empleado_Info> Info, ref string msg)
        {
            try
            {
                return odata.GuardarConfigRubroxEmpleadoI(Info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarConfigRubroxEmpleadoI", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }
        }

        public Boolean GuardarConfigRubroxEmpleadoE(List<ro_Config_Rubros_x_empleado_Info> Info, ref string msg)
        {
            try
            {
                return odata.GuardarConfigRubroxEmpleadoE(Info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarConfigRubroxEmpleadoE", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }
        }

        public Boolean ModificarConfigRubroxEmpleadoI(List<ro_Config_Rubros_x_empleado_Info> Info)
        {
            try
            {
                return odata.ModificarConfigRubroxEmpleadoI(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarConfigRubroxEmpleadoI", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }
        }

        public Boolean ModificarConfigRubroxEmpleadoE(List<ro_Config_Rubros_x_empleado_Info> Info)
        {
            try
            {
                return odata.ModificarConfigRubroxEmpleadoE(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarConfigRubroxEmpleadoE", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }
        }

        //

        public List<ro_Config_Rubros_x_empleado_Info> ConsultaGeneralIngreso(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_Config_Rubros_x_Ingreso(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralIngreso", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }

        }

        public List<ro_Config_Rubros_x_empleado_Info> ConsultaGeneralEgreso(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_Config_Rubros_x_Egreso(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralEgreso", ex.Message), ex) { EntityType = typeof(ro_Config_Rubros_x_empleado_Bus) };

            }

        }
       
    }

}
