using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_empleado_x_ro_rubro_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog=new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_empleado_x_ro_rubro_Data odata = new ro_empleado_x_ro_rubro_Data();



        public Boolean GrabarBD(ro_empleado_x_ro_rubro_Info Info, ref string msg)
        {
            try
            {
                return odata.GrabarBD(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
            }

        }

        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro_(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_empleado_x_ro_rubro_(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_ro_rubro_", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
            }

        }



        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro_x_Empleado(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return odata.Get_List_empleado_x_ro_rubro_x_Empleado(IdEmpresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_ro_rubro_x_Empleado", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
            }

        }




        public ro_empleado_x_ro_rubro_Info Get_Info_empleado_x_ro_rubro(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return odata.Get_Info_empleado_x_ro_rubro(IdEmpresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_empleado_x_ro_rubro", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
            }

        }

        public Boolean ModificarDB(ro_empleado_x_ro_rubro_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
            }

        }



        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, int idNominaTipo, int idNominaTipoLiqui, ref string msg)
        {
            try
            {
                return odata.EliminarBD(idEmpresa, idEmpleado, idNominaTipo, idNominaTipoLiqui, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
            }

        }




        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return odata.Get_List_empleado_x_ro_rubro(IdEmpresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_ro_rubro", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
            }

        }


        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro(int IdEmpresa, decimal IdEmpleado, int idNomina)
        {
            try
            {
                return odata.Get_List_empleado_x_ro_rubro(IdEmpresa, IdEmpleado, idNomina);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_ro_rubro", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
            }

        }


        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro(int IdEmpresa, decimal IdEmpleado, int idNomina, int idNominaLiqui)
        {
            try
            {
                return odata.Get_List_empleado_x_ro_rubro(IdEmpresa, IdEmpleado, idNomina,idNominaLiqui);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_ro_rubro", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
            }
        }

        public List<ro_empleado_x_ro_rubro_Info> Get_Info_empleado_x_ro_rubro(int IdEmpresa, decimal IdEmpleado, int idNomina, int idNominaLiqui)
        {
            try
            {
                return odata.Get_Info_empleado_x_ro_rubro(IdEmpresa, IdEmpleado, idNomina, idNominaLiqui);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_empleado_x_ro_rubro", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
            }
       
        }



        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro_x_Conf_Rubros(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_empleado_x_ro_rubro_x_Conf_Rubros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_ro_rubro_x_Conf_Rubros", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };

            }

        }

        public Boolean ExisteRubro(int idempresa, decimal idempleado, string IdRubro, int IdNomina_Tipo,int IdNomina_TipoLiqui,string idCentroCosto )
        {

            try
            {

                ro_empleado_x_ro_rubro_Data data = new ro_empleado_x_ro_rubro_Data();
                return data.ExisteRubro(idempresa, idempleado, IdRubro, IdNomina_Tipo, IdNomina_TipoLiqui, idCentroCosto);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteRubro", ex.Message), ex) { EntityType = typeof(ro_empleado_x_ro_rubro_Bus) };
            }

        }



    }
}
