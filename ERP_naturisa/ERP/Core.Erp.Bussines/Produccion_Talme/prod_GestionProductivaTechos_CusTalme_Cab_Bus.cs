using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Produccion_Talme
{
    
    public class prod_GestionProductivaTechos_CusTalme_Cab_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prod_GestionProductivaTechos_CusTalme_Cab_Data Data = new prod_GestionProductivaTechos_CusTalme_Cab_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public Boolean GuardarDB(prod_GestionProductivaTechos_CusTalme_Cab_Info Info, ref decimal Id)
        {
            try
            {
                Info.Fecha_Transac = param.Fecha_Transac;
                Info.Fecha_UltMod = param.Fecha_Transac; ;
                Info.IdUsuario = param.IdUsuario;
                Info.IdUsuarioUltModi = param.IdUsuario;
                Info.nom_pc = param.nom_pc;
                Info.ip = param.ip;
                return Data.GuardarDB(Info, ref Id);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaTechos_CusTalme_Cab_Bus) };

            }

        }

        public Boolean AnularDB(prod_GestionProductivaTechos_CusTalme_Cab_Info Info)
        {
            try
            {
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                Info.IdusuarioUltAnu = param.IdUsuario;
                Info.Fecha_UltAnu = param.Fecha_Transac;
                Info.nom_pc = param.nom_pc;
                Info.ip = param.ip;
                return Data.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaTechos_CusTalme_Cab_Bus) };

            }

        }
        public List<prod_GestionProductivaTechos_CusTalme_Cab_Info> ConsultaGeneral(int IdEmpresa, DateTime FechaInicial, DateTime FechaFin)
        {
            try
            {
                return Data.Get_List_GestionProductivaTechos_CusTalme_Cab(IdEmpresa, FechaInicial, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaTechos_CusTalme_Cab_Bus) };

            }

        }
        public void EjecutarSpReporte(string IdUsuario, int IdEmpresa, string NomPc, decimal IdGestion)
        {
            try
            {
                   Data.EjecutarSpReporte(IdUsuario, IdEmpresa, NomPc, IdGestion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EjecutarSpReporte", ex.Message), ex) { EntityType = typeof(prod_GestionProductivaTechos_CusTalme_Cab_Bus) };

            }

        
        }


    }
}
