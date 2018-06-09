using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_factura_x_in_Ing_Egr_Inven_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(fa_factura_x_in_Ing_Egr_Inven_Info info, ref string mensajeR)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    fa_factura_x_in_Ing_Egr_Inven address = new fa_factura_x_in_Ing_Egr_Inven();

                    address.IdEmpresa_fa = info.IdEmpresa_fa;
                    address.IdSucursal_fa = info.IdSucursal_fa;
                    address.IdBodega_fa = info.IdBodega_fa;
                    address.IdCbteVta_fa = info.IdCbteVta_fa;
                    address.IdEmpresa_in_eg_x_inv = info.IdEmpresa_in_eg_x_inv;
                    address.IdSucursal_in_eg_x_inv = info.IdSucursal_in_eg_x_inv;
                    address.IdMovi_inven_tipo_in_eg_x_inv = info.IdMovi_inven_tipo_in_eg_x_inv;
                    address.IdNumMovi_in_eg_x_inv = info.IdNumMovi_in_eg_x_inv;
                    address.observacion = (info.observacion == null) ? "" : info.observacion;

                    Context.fa_factura_x_in_Ing_Egr_Inven.Add(address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensajeR = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeR);
                throw new Exception(ex.ToString());
            }
        }

        public fa_factura_x_in_Ing_Egr_Inven_Info Get_Info_fa_factura_x_in_Ing_Egr_Inven_Relacion(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                fa_factura_x_in_Ing_Egr_Inven_Info address = new fa_factura_x_in_Ing_Egr_Inven_Info();
                EntitiesFacturacion OEFAC = new EntitiesFacturacion();

                var contact = OEFAC.fa_factura_x_in_Ing_Egr_Inven.FirstOrDefault(var => var.IdEmpresa_fa == IdEmpresa
                    && var.IdSucursal_fa == IdSucursal && var.IdBodega_fa == IdBodega && var.IdCbteVta_fa == IdCbteVta);
                if (contact != null)
                {
                    address.IdEmpresa_fa = contact.IdEmpresa_fa;
                    address.IdSucursal_fa = contact.IdSucursal_fa;
                    address.IdBodega_fa = contact.IdBodega_fa;
                    address.IdCbteVta_fa = contact.IdCbteVta_fa;
                    address.IdEmpresa_in_eg_x_inv = contact.IdEmpresa_in_eg_x_inv;
                    address.IdSucursal_in_eg_x_inv = contact.IdSucursal_in_eg_x_inv;
                    address.IdMovi_inven_tipo_in_eg_x_inv = contact.IdMovi_inven_tipo_in_eg_x_inv;
                    address.IdNumMovi_in_eg_x_inv = contact.IdNumMovi_in_eg_x_inv;
                    address.observacion = (contact.observacion == null) ? "" : contact.observacion;
                }
                return address;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
