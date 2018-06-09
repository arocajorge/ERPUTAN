using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_notaCreDeb_x_ct_cbtecble_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(fa_notaCreDeb_x_ct_cbtecble_Info info)
        {           
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var addressG = new fa_notaCreDeb_x_ct_cbtecble();
                    addressG.no_IdEmpresa = info.no_IdEmpresa;
                    addressG.no_IdSucursal = info.no_IdSucursal;
                    addressG.no_IdBodega = info.no_IdBodega;
                    addressG.no_IdNota = info.no_IdNota;
                    addressG.ct_IdEmpresa = info.ct_IdEmpresa;
                    addressG.ct_IdTipoCbte = info.ct_IdTipoCbte;
                    addressG.ct_IdCbteCble = info.ct_IdCbteCble;

                    context.fa_notaCreDeb_x_ct_cbtecble.Add(addressG);
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

        public fa_notaCreDeb_x_ct_cbtecble_Info Get_Info_fa_notaCreDeb_x_ct_cbtecble(int IdEmpresa, int IdSucuersal, int IdBodega, decimal IdNota)
        {
            try
            {
                fa_notaCreDeb_x_ct_cbtecble_Info Info = new fa_notaCreDeb_x_ct_cbtecble_Info();
                EntitiesFacturacion fac = new EntitiesFacturacion();
                var select = from q in fac.fa_notaCreDeb_x_ct_cbtecble where q.no_IdEmpresa == IdEmpresa && q.no_IdSucursal == IdSucuersal && q.no_IdBodega == IdBodega && q.no_IdNota == IdNota select q;
                foreach (var item in select)
                {

                    Info.no_IdBodega = item.no_IdBodega;
                    Info.no_IdNota = item.no_IdNota;
                    Info.no_IdEmpresa = item.no_IdEmpresa;
                    Info.no_IdSucursal = item.no_IdSucursal;

                    Info.ct_IdCbteCble = item.ct_IdCbteCble;
                    Info.ct_IdEmpresa = item.ct_IdEmpresa;
                    Info.ct_IdTipoCbte = item.ct_IdTipoCbte;
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
    }
}
