using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_factura_TerminoPago_Bus
    {
        #region CJimenez
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        fa_factura_TerminoPago_Data odata = new fa_factura_TerminoPago_Data();

        public List<fa_factura_TerminoPago_Info> obtenerList()
        {
            try
            {
                return odata.obtenerList();
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener Lista .." + ex.Message;
                return new List<fa_factura_TerminoPago_Info>();
            }
        }

        public Boolean Guardar(fa_factura_TerminoPago_Info _Info)
        {
            try
            {
                return odata.Guardar(_Info);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return false;
            }
        }

        public Boolean Modificacion(fa_factura_TerminoPago_Info _Info)
        {
            try
            {
                return odata.Modificacion(_Info);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Modificar .." + ex.Message;
                return false;
            }
        }
        #endregion
    }
}
