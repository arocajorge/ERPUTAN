/*CLASE: ro_Empleado_Novedad_Cab_Bus
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 18-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
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
    public class ro_Empleado_Novedad_Cab_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Empleado_Novedad_Cab_Data oData = new ro_Empleado_Novedad_Cab_Data();

        public List<ro_Empleado_Novedad_Info> Get_List_Empleado_Novedad_Cab(int IdEmpresa,DateTime fi,DateTime ff)
        {
            try
            {
                return oData.Get_List_Empleado_Novedad_Cab(IdEmpresa,fi,ff);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }
        }



        public List<ro_Empleado_Novedad_Info> Get_List_Empleado_Novedad_Cab(int IdEmpresa)
        {
            try
            {
                return oData.Get_List_Empleado_Novedad_Cab(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }
        }

        public List<ro_Empleado_Novedad_Info> Get_List_Novedades_Cambiar_estado_Canceladas(int IdEmpresa, int idnomina, int idnomina_tipo, DateTime fecha_incion, DateTime fecha_fin)
        {
            try
            {
                return oData.Get_List_Novedades_Cambiar_estado_Canceladas(IdEmpresa, idnomina, idnomina_tipo, fecha_incion, fecha_fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }
        }

        public List<ro_Empleado_Novedad_Info> Get_List_Empleado_Novedad_Cab(int IdEmpresa, string IdCalendario, string IdRubro)
        {
            try
            {
                return oData.Get_List_Empleado_Novedad_Cab(IdEmpresa  ,IdCalendario ,IdRubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }
        }

        public ro_Empleado_Novedad_Info Get_Info_Empleado_Novedad_Cab_x_Rubro(int IdEmpresa, decimal idNovedades, string idrubro, decimal IdEmpleado)
        {
            try
            {
                return oData.Get_Info_Empleado_Novedad_Cab_x_Rubro(IdEmpresa, idNovedades, idrubro,IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Empleado_Novedad_Cab_x_Rubro", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }
        }

        public ro_Empleado_Novedad_Info Get_Info_Empleado_Novedad_Cab(int IdEmpresa, decimal idNovedades, string idrubro)
        {
            try
            {
                return oData.Get_Info_Empleado_Novedad_Cab(IdEmpresa, idNovedades, idrubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }
        }

        public Boolean GrabarDB(ro_Empleado_Novedad_Info info,ref decimal id, ref string mensaje)
        {
            try
            {
                return oData.GrabarDB(info,ref id, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }
        }

        public Boolean ModificarDB(ro_Empleado_Novedad_Info ro_info, ref string mensaje, decimal idTransaccion)
        {
            try
            {
                return oData.ModificarDB(ro_info, ref mensaje, idTransaccion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }
        }
        public Boolean GrabarDB(ro_Empleado_Novedad_Info ro_info, ref string mensaje, ref decimal idNovedad,ref decimal idTransaccion)
        {
            try
            {
                return oData.GrabarDB(ro_info, ref mensaje, ref  idNovedad, ref idTransaccion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }
        }
           
        public Boolean AnularDB(ro_Empleado_Novedad_Info info)
        {
            try
            {
                return oData.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }
        }

        public Boolean Modificar_Nov(ro_Empleado_Novedad_Info info)
        {
            try
            {
                return oData.Modificar_Nov(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarSueldo", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }
        }
        

      

       public Boolean EliminarDB(int IdEmpresa, decimal IdNovedad,decimal IdEmpleado ,int IdNominaTipo, int IdNominaTipoLiqui, ref string msg)
       {
          try{
                 return oData.EliminarBD(IdEmpresa, IdNovedad, IdEmpleado, IdNominaTipo, IdNominaTipoLiqui, ref msg);
            }catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Cab_Bus) };
            }

        }


       public ro_Empleado_Novedad_Cab_Bus() { }


    }
}
