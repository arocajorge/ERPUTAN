using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_Balance_x_Estado_Resultado_x_Usuario_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        #region CJimenez

        ct_Balance_x_Estado_Resultado_x_Usuario_Data OD = new ct_Balance_x_Estado_Resultado_x_Usuario_Data();

        public Boolean Start_spCON_Obtener_Estado_Resultado(int IdEmpresa, DateTime i_FechaIni, DateTime i_FechaFin,string i_Considerar_Asiento_Cierre, string i_usuario, string i_pc)
        {
            try
            {
                return OD.Start_spCON_Obtener_Estado_Resultado(IdEmpresa, i_FechaIni, i_FechaFin, i_Considerar_Asiento_Cierre, i_usuario, i_pc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Start_spCON_Obtener_Estado_Resultado", ex.Message), ex) { EntityType = typeof(ct_Balance_x_Estado_Resultado_x_Usuario_Bus) };
            }
        }

        public List<ct_Balance_x_Estado_Resultado_x_Usuario_Info> ObtenerDatos_Reporte_Standar(int IdEmpresa, string i_usuario, string i_pc, int i_Nivel, List<ct_Plancta_nivel_Info> niveles)
        {
            try
            {
                return OD.ObtenerDatos_Reporte_Standar(IdEmpresa, i_usuario, i_pc, i_Nivel, niveles);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerDatos_Reporte_Standar", ex.Message), ex) { EntityType = typeof(ct_Balance_x_Estado_Resultado_x_Usuario_Bus) };
            }
        }

        public List<ct_Balance_x_Estado_Resultado_x_Usuario_Info> ObtenerDatos_Reporte_SL_Anterior(int IdEmpresa, string i_usuario, string i_pc, int i_Nivel, List<ct_Plancta_nivel_Info> niveles)
        {
            try
            {
                return OD.ObtenerDatos_Reporte_SL_Anterior(IdEmpresa, i_usuario, i_pc, i_Nivel, niveles);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerDatos_Reporte_SL_Anterior", ex.Message), ex) { EntityType = typeof(ct_Balance_x_Estado_Resultado_x_Usuario_Bus) };
            }
        }

        #endregion 
    }
}
