using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{ 
    public class fa_factura_x_ct_cbtecble_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(fa_factura_x_ct_cbtecble_Info info ) {
            try
            {
                using (EntitiesFacturacion context=new EntitiesFacturacion())
                {
                    
                    var addressG = new fa_factura_x_ct_cbtecble();
                    addressG.vt_IdEmpresa = info.vt_IdEmpresa;
                    addressG.vt_IdSucursal = info.vt_IdSucursal;
                    addressG.vt_IdBodega = info.vt_IdBodega;
                    addressG.vt_IdCbteVta = info.vt_IdCbteVta;
                    addressG.ct_IdEmpresa = info.ct_IdEmpresa;
                    addressG.ct_IdTipoCbte = info.ct_IdTipoCbte;
                    addressG.ct_IdCbteCble = info.ct_IdCbteCble;
                    addressG.Motivo = info.Motivo;

                    context.fa_factura_x_ct_cbtecble.Add(addressG);
                    context.SaveChanges();
                }
                return true;
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


       

        public fa_factura_x_ct_cbtecble_Info Get_info_fa_factura_x_ct_cbtecble(int IdEmpresa, int IdSucuersal, int IdBodega, decimal IdCbteVta, Cl_Enumeradores.eMotivo_Diario_x_Vta Motivo)
        {
            try
            {
                fa_factura_x_ct_cbtecble_Info Info = new fa_factura_x_ct_cbtecble_Info();

                string SMotivo = Motivo.ToString() ;


                EntitiesFacturacion fac = new EntitiesFacturacion();


                var select = from q in fac.fa_factura_x_ct_cbtecble 
                             where q.vt_IdEmpresa == IdEmpresa && q.vt_IdSucursal == IdSucuersal 
                             && q.vt_IdBodega == IdBodega && q.vt_IdCbteVta == IdCbteVta
                             && q.Motivo == SMotivo // obligatorio porq hay dos tipos de diario por ventas y por costo
                             select q;
                foreach (var item in select)
                {

                    Info.vt_IdBodega = item.vt_IdBodega;
                    Info.vt_IdCbteVta = item.vt_IdCbteVta;
                    Info.vt_IdEmpresa = item.vt_IdEmpresa;
                    Info.vt_IdSucursal = item.vt_IdSucursal;

                    Info.ct_IdCbteCble=item.ct_IdCbteCble;
                    Info.ct_IdEmpresa=item.ct_IdEmpresa;
                    Info.ct_IdTipoCbte=item.ct_IdTipoCbte;

                    Info.Motivo = item.Motivo;
                }
                return Info;
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

        public fa_factura_x_ct_cbtecble_Data() { }
    }
}
