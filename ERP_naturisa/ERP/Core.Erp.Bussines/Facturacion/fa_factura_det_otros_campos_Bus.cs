using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
  public  class fa_factura_det_otros_campos_Bus
    {
      fa_factura_det_otros_campos_Data oData = new fa_factura_det_otros_campos_Data();

      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      string mensaje = "";

      public Boolean GuardarDetalleOtrosCampos(List<fa_factura_det_otros_campos_Info> Lst)
      {
          try
          {
              return oData.GuardarDB(Lst);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDetalleOtrosCampos", ex.Message), ex) { EntityType = typeof(fa_factura_det_otros_campos_Bus) };

          }



      }  
    }
}
