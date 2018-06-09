using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_guia_remision_det_x_orden_despacho_det_bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_guia_remision_det_x_fa_orden_Desp_det_Data odata = new fa_guia_remision_det_x_fa_orden_Desp_det_Data();

        public decimal GetIdOrdenDespacho(fa_guia_remision_Info Info)
        {
            try
            {
                return odata.GetIdOrdenDespacho(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaIdOrdenDespacho", ex.Message), ex) { EntityType = typeof(fa_guia_remision_det_x_orden_despacho_det_bus) };
            }
            
        }

        public List<fa_guia_remision_det_x_fa_orden_Desp_det_Info> Get_List_fa_guia_remision_det_x_fa_orden_Desp_det(fa_orden_Desp_Info Info)
        {
            try
            {
                return odata.Get_List_fa_guia_remision_det_x_fa_orden_Desp_det(Info);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaListIdGuiaRemision", ex.Message), ex) { EntityType = typeof(fa_guia_remision_det_x_orden_despacho_det_bus) };
           
            }
            }

        public Boolean Eliminar_fa_guia_remision_det_x_fa_orden_Desp_det(fa_orden_Desp_Info info)
         {
             try
             {
                 return odata.Eliminar_fa_guia_remision_det_x_fa_orden_Desp_det(info);

             }
             catch (Exception ex)
             {

                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarGuiaTablaIntermedia", ex.Message), ex) { EntityType = typeof(fa_guia_remision_det_x_orden_despacho_det_bus) };
           
             }


         }
    }
}
