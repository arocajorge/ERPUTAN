using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_pedido_estadoAprobacion_Data
    {
        string mensaje = "";

        public List<fa_pedido_estadoAprobacion_Info> Get_List_EstadoAprobacion()
        {
            try
            {
                List<fa_pedido_estadoAprobacion_Info> lm = new List<fa_pedido_estadoAprobacion_Info>();
                EntitiesFacturacion OEFacturacion = new EntitiesFacturacion();
                var select = from A in OEFacturacion.fa_pedido_estadoAprobacion
                             where A.Estado=="A" 
                             orderby A.posicion
                             select A;
                foreach (var item in select)
                {
                    fa_pedido_estadoAprobacion_Info info = new fa_pedido_estadoAprobacion_Info();
                    info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    info.Descripcion = item.Descripcion.Trim();
                    lm.Add(info);
                }
                return lm;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public fa_pedido_estadoAprobacion_Data() { }
    
    }
}
