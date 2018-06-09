using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Facturacion
{
    public class fa_factura_x_in_movi_inve_x_Anulacion_Data
    {
        string mensaje = "";

        
        public fa_factura_x_in_movi_inve_x_Anulacion_Data(){}

        public fa_factura_x_in_movi_inve_x_Anulacion_Info Get_Info_fa_factura_x_in_movi_inve_x_Anulacion(
            int idempresa ,int idsucursal,int idbodega ,decimal idCbteVta)
        {

            try 
            {	        
		
                 fa_factura_x_in_movi_inve_x_Anulacion_Info item2= new fa_factura_x_in_movi_inve_x_Anulacion_Info();

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                { 
                
                var select_ = from T in Context.fa_factura_x_in_movi_inve_x_Anulacion 
                                        where T.fa_IdEmpresa==idempresa && T.fa_IdSucursal==idsucursal && T.fa_IdBodega==idbodega && T.fa_IdCbteVta==idCbteVta
                                        select T;

                foreach (var item in select_)
                {

                    item2.fa_IdEmpresa=item.fa_IdEmpresa;
                    item2.fa_IdSucursal=item.fa_IdSucursal;
                    item2.fa_IdBodega=item.fa_IdBodega;
                    item2.fa_IdCbteVta=item.fa_IdCbteVta;
                    item2.inv_IdEmpresa=item.inv_IdEmpresa;
                    item2.inv_IdSucursal=item.inv_IdSucursal;
                    item2.inv_IdBodega=item.inv_IdBodega;
                    item2.inv_IdMovi_inven_tipo=item.inv_IdMovi_inven_tipo;
                    item2.inv_IdNumMovi=item.inv_IdNumMovi;
                    item2.Observacion=item.Observacion;
                    
                }

                    return item2;
                }
            
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

        public Boolean GuardarDB(fa_factura_x_in_movi_inve_x_Anulacion_Info info)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    fa_factura_x_in_movi_inve_x_Anulacion address = new fa_factura_x_in_movi_inve_x_Anulacion();
                    address.fa_IdBodega = info.fa_IdBodega;
                    address.fa_IdCbteVta = info.fa_IdCbteVta;
                    address.fa_IdEmpresa = info.fa_IdEmpresa;
                    address.fa_IdSucursal = info.fa_IdSucursal;
                    address.inv_IdBodega = info.inv_IdBodega;
                    address.inv_IdEmpresa = info.inv_IdEmpresa;
                    address.inv_IdMovi_inven_tipo = info.inv_IdMovi_inven_tipo;
                    address.inv_IdNumMovi = info.inv_IdNumMovi;
                    address.inv_IdSucursal = info.inv_IdSucursal;
                    address.Observacion= info.Observacion;

                    Context.fa_factura_x_in_movi_inve_x_Anulacion.Add(address);
                    Context.SaveChanges();

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
    }
}
