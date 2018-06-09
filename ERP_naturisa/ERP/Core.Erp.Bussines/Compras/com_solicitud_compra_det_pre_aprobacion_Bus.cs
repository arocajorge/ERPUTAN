using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
   public class com_solicitud_compra_det_pre_aprobacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        com_solicitud_compra_det_pre_aprobacion_Data odata = new com_solicitud_compra_det_pre_aprobacion_Data();
        com_solicitud_compra_det_aprobacion_Data dataAproba = new com_solicitud_compra_det_aprobacion_Data();
        string mensaje = "";


       public Boolean GuardarDB(List<com_solicitud_compra_det_pre_aprobacion_Info> LstInfo)
       {
           try
           {
               if (odata.GuardarDB(LstInfo))
               {
                   foreach (var item in LstInfo)
                   {
                       dataAproba.Actualizar_CantidadAprobada(item.IdEmpresa, item.IdSucursal_SC, item.IdSolicitudCompra, item.Secuencia_SC, item.Cantidad_aprobada);
                   }
                   return true;
               }
               else
                   return false;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_pre_aprobacion_Bus) };

           }
       }
    }
}
