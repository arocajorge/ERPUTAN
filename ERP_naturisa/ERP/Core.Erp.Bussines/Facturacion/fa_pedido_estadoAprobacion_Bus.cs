using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Facturacion
{
    public class fa_pedido_estadoAprobacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<fa_pedido_estadoAprobacion_Info> Get_List_EstadoAprobacion()
        {
            try
            {
                fa_pedido_estadoAprobacion_Data data = new fa_pedido_estadoAprobacion_Data();
                return data.Get_List_EstadoAprobacion();

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Lista_EstadoAprobacion", ex.Message), ex) { EntityType = typeof(fa_pedido_estadoAprobacion_Bus) };
            }
        }

        public fa_pedido_estadoAprobacion_Bus() { }
    }
}
