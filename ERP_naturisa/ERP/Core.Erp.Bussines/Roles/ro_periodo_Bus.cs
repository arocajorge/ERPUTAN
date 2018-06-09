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
    public class ro_periodo_Bus
    {
        #region
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";
        ro_periodo_Data Odata = new ro_periodo_Data();
        public ro_periodo_Info _PeriodoInfo = new ro_periodo_Info();
        #endregion
        
        public List<ro_periodo_Info> Get_periodos(int idcompany)
        {
                        
            try
            {
                return  Odata.Get_periodos(idcompany);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPeriodo", ex.Message), ex) { EntityType = typeof(ro_periodo_Bus) };
            }
        }
        public List<ro_periodo_Info> Get_periodos_disponibles(int idcompany)
        {

            try
            {
                return Odata.Get_periodos_disponibles(idcompany);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPeriodo", ex.Message), ex) { EntityType = typeof(ro_periodo_Bus) };
            }
        }
        public List<ro_periodo_Info> ObtenerPeriodo(int idcompany,int IdPeriodo)
        {
            List<ro_periodo_Info> lm = new List<ro_periodo_Info>();

            ro_periodo_Data data = new ro_periodo_Data();

            try
            {
                lm = data.ObtenerPeriodo(idcompany, IdPeriodo);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPeriodo", ex.Message), ex) { EntityType = typeof(ro_periodo_Bus) };
            }
        }

       

        public Boolean Modificar(ro_periodo_Info Info, ref string msg)
        {
            try
            {
                Info.IdUsuarioUltMod = param.IdUsuario;
                Info.Fecha_UltMod = param.GetDateServer();
                return Odata.ModificarDB(Info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(ro_periodo_Bus) };
            }
        }

        

        public Boolean Anular(ro_periodo_Info Info, ref string msg)
        {
            try
            {
                Info.IdUsuarioUltAnu = param.IdUsuario;
                Info.Fecha_UltMod = param.GetDateServer();
                Info.FechaHoraAnul = param.GetDateServer();

                return Odata.AnularDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(ro_periodo_Bus) };
            }

        }

        public Boolean Grabar(ro_periodo_Info Info, ref string msg)
        {
            try
            {
                Info.IdUsuarioUltMod = param.IdUsuario;
                Info.Fecha_Transac = param.GetDateServer();

                return Odata.GrabarDB(Info,ref msg );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar", ex.Message), ex) { EntityType = typeof(ro_periodo_Bus) };
            }
        }

        public int getId(int IdPeriodo)
        {
            try
            {
                ro_periodo_Data data = new ro_periodo_Data();
                return data.getId(IdPeriodo);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(ro_periodo_Bus) };
                return 0;
            }
        }

        public Boolean ExistePeriodo(int idempresa, DateTime Finicia, DateTime Ffin)
        {
            try
            {
                ro_periodo_Data data = new ro_periodo_Data();
                return data.ExistePeriodo(idempresa, Finicia, Ffin);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExistePeriodo", ex.Message), ex) { EntityType = typeof(ro_periodo_Bus) };                
            }

        }

        public Boolean GuardarPeriodos(List<ro_periodo_Info> Lst,  ref string mensaje)
        {

            try
            {
                ro_periodo_Data data = new ro_periodo_Data();

                return data.GuardarPeriodos(Lst, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarPeriodos", ex.Message), ex) { EntityType = typeof(ro_periodo_Bus) };
            }
           
        }
        
        public ro_periodo_Bus() { }

    }
}
