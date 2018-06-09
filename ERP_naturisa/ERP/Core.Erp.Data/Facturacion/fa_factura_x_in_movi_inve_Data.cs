using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_factura_x_in_movi_inve_Data
    {
        string mensaje = "";

        public List<fa_factura_x_in_movi_inve_Info> Get_List_fa_factura_x_in_movi_inve(fa_factura_x_in_movi_inve_Info inf)
        {
            List<fa_factura_x_in_movi_inve_Info> inforesult = new List<fa_factura_x_in_movi_inve_Info>();
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {

                    string query = "select * from  dbo.fa_factura_x_in_movi_inve "
                        + "where (fa_IdEmpresa  = " + inf.fa_IdEmpresa + " and fa_IdSucursal = " + inf.fa_IdSucursal
                        + "and fa_IdBodega= " + inf.fa_IdBodega + " and fa_IdCbteVta= " + inf.fa_IdCbteVta + ")or"
                        + "( inv_IdEmpresa= " + inf.inv_IdEmpresa + " and inv_IdSucursal= " + inf.inv_IdSucursal
                        + "and inv_IdBodega= " + inf.inv_IdBodega + " and inv_IdMovi_inven_tipo= " + inf.inv_IdMovi_inven_tipo
                        + "and inv_IdNumMovi= " + inf.inv_IdNumMovi + ")";
                    inforesult = Context.Database.SqlQuery<fa_factura_x_in_movi_inve_Info>(query).ToList();


                }
                return inforesult;
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

        public Boolean GuardarDB(fa_factura_x_in_movi_inve_Info info,ref string mensajeR)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    fa_factura_x_in_movi_inve address = new fa_factura_x_in_movi_inve();
                    address.fa_IdBodega = info.fa_IdBodega;
                    address.fa_IdCbteVta = info.fa_IdCbteVta;
                    address.fa_IdEmpresa = info.fa_IdEmpresa;
                    address.fa_IdSucursal = info.fa_IdSucursal;
                    address.inv_IdBodega = info.inv_IdBodega;
                    address.inv_IdEmpresa = info.inv_IdEmpresa;
                    address.inv_IdMovi_inven_tipo = info.inv_IdMovi_inven_tipo;
                    address.inv_IdNumMovi = info.inv_IdNumMovi;
                    address.inv_IdSucursal = info.inv_IdSucursal;
                    address.Observacion = (info.Observacion == null) ? "" : info.Observacion;

                    Context.fa_factura_x_in_movi_inve.Add(address);
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

        public fa_factura_x_in_movi_inve_Info Get_Info_fa_factura_x_in_movi_inve_x_Factura_(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                fa_factura_x_in_movi_inve_Info obj = new fa_factura_x_in_movi_inve_Info();
                EntitiesFacturacion OEFAC = new EntitiesFacturacion();

                var ent = OEFAC.fa_factura_x_in_movi_inve.FirstOrDefault(var => var.fa_IdEmpresa == IdEmpresa
                    && var.fa_IdSucursal == IdSucursal && var.fa_IdBodega == IdBodega && var.fa_IdCbteVta == IdCbteVta);
                if (ent != null)
                {
                    obj.fa_IdEmpresa = ent.fa_IdEmpresa;
                    obj.fa_IdSucursal = ent.fa_IdSucursal;
                    obj.fa_IdBodega = ent.fa_IdBodega;
                    obj.fa_IdCbteVta = ent.fa_IdCbteVta;
                    obj.inv_IdEmpresa = ent.inv_IdEmpresa;
                    obj.inv_IdSucursal = ent.inv_IdSucursal;
                    obj.inv_IdBodega = ent.inv_IdBodega;
                    obj.inv_IdMovi_inven_tipo = ent.inv_IdMovi_inven_tipo;
                    obj.inv_IdNumMovi = ent.inv_IdNumMovi;
                    obj.Observacion = ent.Observacion;
                }
                return obj;

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
