using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Roles
{
    public class ro_empleado_x_titulos_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";



        ro_empleado_x_titulos_Data oRo_empleado_x_titulos_Data = new ro_empleado_x_titulos_Data();

        public Boolean GrabarDB(ro_empleado_x_titulos_Info info, ref string msg)
        {
            try
            {

                Boolean valorRetornar = false;

                if (oRo_empleado_x_titulos_Data.getExiste(info))
                {
                    valorRetornar = oRo_empleado_x_titulos_Data.ModificarDB(info, ref msg);
                }else{
                    valorRetornar = oRo_empleado_x_titulos_Data.GrabarDB(info, ref msg);
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_empleado_x_titulos_Bus) };
            }

        }

        public List<ro_empleado_x_titulos_Info> Get_List_empleado_x_titulos(int IdEmpresa)
        {
            try
            {
                return oRo_empleado_x_titulos_Data.Get_List_empleado_x_titulos(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_titulos", ex.Message), ex) { EntityType = typeof(ro_empleado_x_titulos_Bus) };
            }

        }

        public List<ro_empleado_x_titulos_Info> Get_List_empleado_x_titulos(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return oRo_empleado_x_titulos_Data.Get_List_empleado_x_titulos(IdEmpresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_titulos", ex.Message), ex) { EntityType = typeof(ro_empleado_x_titulos_Bus) };
            }

        }

        public Boolean ModificarDB(ro_empleado_x_titulos_Info info, ref string msg)
        {
            try
            {
                return oRo_empleado_x_titulos_Data.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_empleado_x_titulos_Bus) };
            }

        }

        public Boolean AnularDB(ro_empleado_x_titulos_Info info)
        {
            try
            {
                return oRo_empleado_x_titulos_Data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_empleado_x_titulos_Bus) };
            }

        }

        public int getId(int Idempresa, decimal idempleado)
        {
            try
            {
                return oRo_empleado_x_titulos_Data.getId(Idempresa, idempleado);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(ro_empleado_x_titulos_Bus) };
            }
        }

       public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, ref string msg)
        {
            try
            {
                return oRo_empleado_x_titulos_Data.EliminarBD(idEmpresa, idEmpleado, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_x_titulos_Bus) };
            }
        }


        
    }
}
