using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
   public class fa_factura_x_fa_TerminoPago_Bus
    {

       fa_factura_x_fa_TerminoPago_Data oData = new fa_factura_x_fa_TerminoPago_Data();

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";


        public Boolean validar_objeto_lista(List<fa_factura_x_fa_TerminoPago_Info> Lista, ref string mensajeE)
        {
            try
            {

                Boolean res = true;

                foreach (var item in Lista)
                {
                    if (item.IdEmpresa == 0 || item.IdSucursal == 0 || item.IdBodega == 0 || item.IdTerminoPago == "" || item.Secuencia == 0)
                    {
                        mensajeE = "el idempresa o idsucursal o IdTipoFormaPago o Secuencia esta en cero no puede darse son PK";
                        res = false;
                    }

                    if (item.Valor == 0 || item.Por_Distribucion == 0)
                    {
                        mensajeE = "el uno de los registros el valor es Cero";
                        res = false;
                    }

                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validar_objeto_lista", ex.Message), ex) { EntityType = typeof(fa_factura_x_fa_TerminoPago_Bus) };

            }
        }

        public Boolean GuardarDB(List<fa_factura_x_fa_TerminoPago_Info> Lista, ref string mensajeE)
        {
            try
            {
                Boolean res = true;

                if (validar_objeto_lista(Lista, ref mensajeE))
                { res = oData.GuardarDB(Lista, ref mensajeE); }
                else
                { res = false; }

                return res;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_factura_x_fa_TerminoPago_Bus) };
            }
        }


        public List<fa_factura_x_fa_TerminoPago_Info> Get_List_fa_factura_x_formaPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                return oData.Get_List_fa_factura_x_formaPago(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaLista_FormaPago", ex.Message), ex) { EntityType = typeof(fa_factura_x_fa_TerminoPago_Bus) };
            }
        }
    
  
    }
}
