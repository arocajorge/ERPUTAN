using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{


    public class ro_permiso_x_empleado_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";
        ro_historico_vacaciones_x_empleado_Bus Bus_Historico_vacaciones = new ro_historico_vacaciones_x_empleado_Bus();
        ro_Empleado_Bus Bus_empleado = new ro_Empleado_Bus();
        ro_permiso_x_empleado_Data oData = new ro_permiso_x_empleado_Data();
        public List<ro_permiso_x_empleado_Info> ConsultaGeneral(int IdEmpresa, DateTime Fecha_inicio, DateTime Fecha_Fin)
        {
            try
            {
                return oData.ConsultaGeneral(IdEmpresa, Fecha_inicio, Fecha_Fin);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_permiso_x_empleado_Bus) };
            }
        }


        public List<ro_permiso_x_empleado_Info> GetListLicenciaPorEmpleado(int IdEmpresa, int idEmpleado, DateTime fecha_I, DateTime fecha_F)
        {
            try
            {
                return oData.GetListLicenciaPorEmpleado(IdEmpresa, idEmpleado,fecha_I,fecha_F);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListLicenciaPorEmpleado", ex.Message), ex) { EntityType = typeof(ro_permiso_x_empleado_Bus) };
            }
        }





           public Boolean GuardarDB(ro_permiso_x_empleado_Info info, ref decimal id, ref string msg)
               {
            try
            {
                ro_Empleado_Info info_empleado = new ro_Empleado_Info();
                Boolean valorRetornar = false;
       
                info.ip = param.ip;
                info.nom_pc = param.nom_pc;

                //MODIFICA
                if(oData.GetExiste(info, ref msg))
                {
                    info.Fecha_UltMod = param.Fecha_Transac;
                    info.IdUsuarioUltMod = param.IdUsuario;

                    valorRetornar = oData.ModificarDB(info, ref msg);
                    id = info.IdPermiso;
        
        }
        else
        {
            //GRABA
            info.Fecha_Transac=param.Fecha_Transac;
            info.IdUsuario = param.IdUsuario;
            info.Estado = "A";
            info.IdUsuario_Anu = "";
            info.FechaAnulacion = null;
            info.IdUsuarioUltMod = "";
            info.MotivoAnulacion = "";

            if(oData.GuardarDB(info, ref id,ref msg))
            {
                if (info.Id_Forma_descuento_permiso_Cat == "219")
                {
                    info_empleado = Bus_empleado.Get_Info_Empleado(info.IdEmpresa, info.IdEmpleado);
                    valorRetornar = Bus_Historico_vacaciones.GenerarVacacionesPorEmpleado(info_empleado, ref msg);
                    int dias_tomados = Convert.ToInt32(((TimeSpan)(info.FechaEntrada - Convert.ToDateTime(info.FechaSalida).AddDays(-1))).TotalDays);
                    valorRetornar = Bus_Historico_vacaciones.ModificarBD(info.IdEmpresa, info.IdEmpleado, dias_tomados);
                }
                else
                    valorRetornar = true;


            }
        }

        return valorRetornar;

    }    catch (Exception ex)    {
        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_permiso_x_empleado_Bus) };
    }
}

            public Boolean ModificarDB(ro_permiso_x_empleado_Info info, ref string msg)
{
    try{
        info.Fecha_UltMod = param.Fecha_Transac;
        info.IdUsuarioUltMod = param.IdUsuario;
        return oData.ModificarDB(info, ref msg);
    }catch (Exception ex){
        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_permiso_x_empleado_Bus) };
    }
}





        public Boolean EliminarPermiso(ro_permiso_x_empleado_Info info)
        {
            try
            {
                return oData.EliminarPermiso(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Parametros", ex.Message), ex) { EntityType = typeof(ro_permiso_x_empleado_Bus) };
            }

        }

        public int MaxPermiso(int IdEmpresa)
        {
            try
            {
                return oData.MaxPermiso(IdEmpresa);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "MaxPermiso", ex.Message), ex) { EntityType = typeof(ro_permiso_x_empleado_Bus) };                
            }
        }

        public ro_permiso_x_empleado_Info Get_Dias_Permiso(int idempresa, int IdNomina_Tipo, int idempleado, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return oData.Get_Dias_Permiso(idempresa, IdNomina_Tipo, idempleado, fechaIni, fechaFin);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "MaxPermiso", ex.Message), ex) { EntityType = typeof(ro_permiso_x_empleado_Bus) };
            }
        }




    
    }
}
