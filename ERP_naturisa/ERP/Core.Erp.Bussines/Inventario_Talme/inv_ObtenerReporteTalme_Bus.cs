using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Inventario_Talme;
using Core.Erp.Data.Inventario_Talme;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Inventario_Talme
{
    public class inv_ObtenerReporteTalme_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        inv_ObtenerReporteTalme_Data data = new inv_ObtenerReporteTalme_Data();
       
        public List<tbINV_TAL_Rpt001_Info> OptenerData_spINV_TAL_Rpt001(int IdEmpresa, int IdSucursal, 
            int IdBodega, string IdCategorias, int IdMovimiento, DateTime fechaIni, DateTime fechaFin, string IdUsuario, string nom_pc)
        {
            try
            {
            return data.OptenerData_spINV_TAL_Rpt001(IdEmpresa, IdSucursal,IdBodega,IdCategorias,IdMovimiento,fechaIni,fechaFin,IdUsuario,nom_pc);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spINV_TAL_Rpt001", ex.Message), ex) { EntityType = typeof(inv_ObtenerReporteTalme_Bus) };
                
            }
        }


        public List<tbINV_TAL_Rpt002_Info> OptenerData_spINV_TAL_Rpt002(int IdEmpresa, int IdSucursalini,
               int IdSucursalfin, int IdBodegaini, int IdBodegafin,
               string IdCategorias, DateTime fechaCorte, string IdUsuario, string nom_pc)
        {
            try
            {
             return data.OptenerData_spINV_TAL_Rpt002(IdEmpresa, IdSucursalini ,  IdSucursalfin, IdBodegaini , IdBodegafin , IdCategorias, fechaCorte, IdUsuario, nom_pc);

            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener Data Reporte 002.." + ex.Message;
                return new List<tbINV_TAL_Rpt002_Info>();
            }
        }
        
        public List<tbINV_TAL_Rpt003_Info> OptenerData_spINV_TAL_Rpt006(List<tb_Empresa_Info> empresas, List<tb_Sucursal_Info> sucursales,
            List<in_categorias_Info> categorias, DateTime fechaCorte, string IdUsuario, string nom_pc)
        {
            try
            {
            return data.OptenerData_spINV_TAL_Rpt006(empresas,sucursales,categorias,fechaCorte, IdUsuario, nom_pc);

            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener Data Reporte 006 .." + ex.Message;
                return new List<tbINV_TAL_Rpt003_Info>();
            }
        }

    }
}
