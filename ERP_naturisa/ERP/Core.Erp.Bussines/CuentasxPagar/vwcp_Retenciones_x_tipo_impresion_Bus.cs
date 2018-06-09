using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;
//DEREK MEJIA 21/31/2014
namespace Core.Erp.Business.CuentasxPagar
{
    public class vwcp_Retenciones_x_tipo_impresion_Bus
    {
        vwcp_Retenciones_x_tipo_impresion_Data oData = new vwcp_Retenciones_x_tipo_impresion_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<vwcp_Retenciones_x_tipo_impresion_Info> Get_List_Retenciones_x_tipo_impresion(int IdEmpresa, int IdProveedor, DateTime Desde, DateTime Hasta, string Impresion)
        {
            try
            {
                return oData.Get_List_Retenciones_x_tipo_impresion(IdEmpresa, IdProveedor, Desde, Hasta, Impresion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Retenciones_x_tipo_impresion", ex.Message), ex) { EntityType = typeof(vwcp_Retenciones_x_tipo_impresion_Bus) };
            }
        
        }

        public List<vwcp_Retenciones_x_tipo_impresion_Info> Get_List_Retenciones_x_tipo_impresion(int IdEmpresa, DateTime Desde, DateTime Hasta, string Impresion)
        {
            try
            {
                return oData.Get_List_Retenciones_x_tipo_impresion(IdEmpresa, Desde, Hasta, Impresion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Retenciones_x_tipo_impresion", ex.Message), ex) { EntityType = typeof(vwcp_Retenciones_x_tipo_impresion_Bus) };
            }
        }

        public List<vwcp_Retenciones_x_tipo_impresion_Info> Get_List_Retenciones_x_tipo_impresion(int IdEmpresa, string Impresion)
        {
            try
            {
                return oData.Get_List_Retenciones_x_tipo_impresion(IdEmpresa,Impresion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Retenciones_x_tipo_impresion", ex.Message), ex) { EntityType = typeof(vwcp_Retenciones_x_tipo_impresion_Bus) };
            }
        }
    }
}
