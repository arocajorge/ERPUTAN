using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Importacion
{
    public class imp_OrdenCompraExterna_Liquidacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        imp_OrdenCompraExterna_Liquidacion_Data Odata = new imp_OrdenCompraExterna_Liquidacion_Data();

        public List<vwImp_LiquidacionImportacion_Info> Get_List_LiquidacionImportacion(int IdEmpresa, int IdSucursal, decimal IdOrdenCompraExterna)
        {
            try
            {
                 return Odata.Get_List_LiquidacionImportacion(IdEmpresa, IdSucursal, IdOrdenCompraExterna);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(imp_OrdenCompraExterna_Liquidacion_Bus) };
            
            }

        }
    }
}
