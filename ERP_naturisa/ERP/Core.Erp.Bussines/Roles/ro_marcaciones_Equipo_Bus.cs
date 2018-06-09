using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_marcaciones_Equipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_marcaciones_Equipo_Data data = new ro_marcaciones_Equipo_Data();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public List<ro_marcaciones_Equipo_Info> Get_List_marcaciones_Equipo(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return data.Get_List_marcaciones_Equipo(IdEmpresa,IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_marcaciones_Equipo", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_Bus) };
            }
        }

        public Boolean GrabarDB(ro_marcaciones_Equipo_Info info)
        {
            try
            {
                info.IdUsuario = param.IdUsuario;
                info.Ip = param.ip;
                info.Fecha_Transac = param.Fecha_Transac;
                info.nom_pc = param.nom_pc;
                
                return data.GrabarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_Bus) };

            }

        }

        public ro_marcaciones_Equipo_Info Get_Info_marcaciones_Equipo(int id)
        {
            try
            {
                return data.Get_Info_marcaciones_Equipo(id);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_marcaciones_Equipo", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_Bus) };

            }
        }
        public Boolean ValidarIdMarcEqui(int id)
        {
            try
            {
                return data.ValidarIdMarcEqui(id);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarIdMarcEqui", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_Bus) };

            }

        }

        public int getId()
        {
            try
            {
                return data.getId();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_x_Empleado_x_Ingresos", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_Bus) };

            }

        }

        public Boolean ModificarDB(ro_marcaciones_Equipo_Info info)
        {
            try
            {
                info.IdUsuarioUltModi = param.IdUsuario;
                info.Fecha_UltMod = param.Fecha_Transac;

                return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_Bus) };

            }

        }
        public Boolean AnularDB(ro_marcaciones_Equipo_Info info)
        {
            try
            {
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_UltAnu = param.GetDateServer();

                return data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_marcaciones_Equipo_Bus) };

            }

        }

    }
}

