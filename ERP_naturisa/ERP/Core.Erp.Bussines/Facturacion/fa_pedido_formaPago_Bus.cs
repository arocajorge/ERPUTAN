using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_pedido_formaPago_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        

        public Boolean GuardarDB(List<fa_factura_x_fa_TerminoPago_Info> Lista)
        {
            try
            {
                    return false;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_pedido_formaPago_Bus) };
            }
        }

        public List<fa_factura_x_fa_TerminoPago_Info> ConsultaEspecifica(int IdEmpresa, int IdSucursal, int IdBodega, decimal Idtransaccion)
        {
            try
            {
                return new List<fa_factura_x_fa_TerminoPago_Info>();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaEspecifica", ex.Message), ex) { EntityType = typeof(fa_pedido_formaPago_Bus) };
          
            }
        }
    }
}
