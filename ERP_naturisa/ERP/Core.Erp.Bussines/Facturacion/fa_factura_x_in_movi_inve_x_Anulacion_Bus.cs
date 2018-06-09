using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Facturacion
{
    public class fa_factura_x_in_movi_inve_x_Anulacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_factura_x_in_movi_inve_x_Anulacion_Data OData = new fa_factura_x_in_movi_inve_x_Anulacion_Data();

        public fa_factura_x_in_movi_inve_x_Anulacion_Info Get_Info_fa_factura_x_in_movi_inve_x_Anulacion(
           int idempresa, int idsucursal, int idbodega, decimal idCbteVta)
        {
            try
            {
             return   OData.Get_Info_fa_factura_x_in_movi_inve_x_Anulacion(idempresa, idsucursal, idbodega, idCbteVta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDetalle", ex.Message), ex) { EntityType = typeof(fa_factura_x_in_movi_inve_x_Anulacion_Bus) };
                
            }

        }


        public Boolean GuardarDB(fa_factura_x_in_movi_inve_x_Anulacion_Info info)
        {
            try
            {
               return OData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_factura_x_in_movi_inve_x_Anulacion_Bus) };
               
            }

        }





    }
}
