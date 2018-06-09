using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_factura_TerminoPago_Distribucion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_factura_TerminoPago_Distribucion_Data data = new fa_factura_TerminoPago_Distribucion_Data();

        public List<fa_factura_TerminoPago_Distribucion_Info> obtenerLista(string IdTipoFormaPago)
        {
            try
            {
                return data.obtenerLista(IdTipoFormaPago);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener Lista .." + ex.Message;
                return new List<fa_factura_TerminoPago_Distribucion_Info>();
            }
        }

        public Boolean Guardar(List<fa_factura_TerminoPago_Distribucion_Info> lst)
        {
            try
            {
                return data.Guardar(lst);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return false;
            }
        }

        public Boolean Modificar(List<fa_factura_TerminoPago_Distribucion_Info> lst)
        {
            try
            {
                return data.Modificar(lst); 
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Modificar .." + ex.Message;
                return false;
            }
        }

        public Boolean eliminar(string IdTipoFormaPago, int count)
        {
            try
            {
                return data.eliminar(IdTipoFormaPago, count);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Eliminar .." + ex.Message;
                return false;
            }
        }
    }
}
