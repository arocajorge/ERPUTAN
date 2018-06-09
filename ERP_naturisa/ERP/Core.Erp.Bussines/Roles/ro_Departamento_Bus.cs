using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Departamento_Bus
    {
        ro_Departamento_Data oData = new ro_Departamento_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<ro_Departamento_Info> Get_List_Departamento(int IdEmpresa)
        {
            try
            {
                List<ro_Departamento_Info> lM = new List<ro_Departamento_Info>();
                ro_Departamento_Data data = new ro_Departamento_Data();
                lM = data.Get_List_Departamento(IdEmpresa);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Departamento", ex.Message), ex) { EntityType = typeof(ro_Departamento_Bus) };

            }
        }

        public List<ro_Departamento_Info> Get_List_Departamento(int IdEmpresa, int IdDivision, int IdArea)
        {
            try
            {
                List<ro_Departamento_Info> lM = new List<ro_Departamento_Info>();
                ro_Departamento_Data data = new ro_Departamento_Data();
                lM = data.Get_List_Departamento(IdEmpresa, IdDivision, IdArea);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Departamento", ex.Message), ex) { EntityType = typeof(ro_Departamento_Bus) };

            }
        }

        public Boolean ModificarDB(ro_Departamento_Info Info, ref string msg)
        {

            try
            {
                Info.IdUsuarioUltMod = param.IdUsuario;
                Info.Fecha_UltMod = param.GetDateServer();
                return oData.ModificarDB(Info, ref msg);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Departamento_Bus) };

            }
        }

        public Boolean GrabarDB(ro_Departamento_Info Info, ref int Id, ref string msg)
        {           
            try
            {
                if (oData.GetExiste(Info,ref msg))
                {//MODIFICA
                    Info.IdUsuarioUltMod = param.IdUsuario;
                    Info.Fecha_UltMod = param.Fecha_Transac;
                    Id = Info.IdDepartamento;
                    return oData.ModificarDB(Info, ref msg);
                }else{
                //NUEVO
                    Info.IdUsuario = param.IdUsuario;
                    Info.Fecha_Transac = param.Fecha_Transac;

                    return oData.GrabarDB(Info, ref Id, ref msg);
                }
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Departamento_Bus) };

            }
        }
   
        public Boolean AnularDB(ro_Departamento_Info Info, ref string msg)
        {
            try
            {
                Info.IdUsuarioUltAnu = param.IdUsuario;
                Info.Fecha_UltMod = param.GetDateServer();
                Info.Fecha_UltAnu = param.GetDateServer();

                return oData.AnularDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Departamento_Bus) };

            }

        }

        public ro_Departamento_Info Get_Info_Departamento(int IdEmpresa, int IdDepartamento)
        {
            try
            {               
                ro_Departamento_Data data = new ro_Departamento_Data();
                return data.Get_Info_Departamento(IdEmpresa, IdDepartamento);               
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Departamento", ex.Message), ex) { EntityType = typeof(ro_Departamento_Bus) };

            }
        
        }

        public ro_Departamento_Bus() { }
    }
}
