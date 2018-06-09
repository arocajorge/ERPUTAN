using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
    public class in_movi_inve_x_ct_cbteCble_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(in_movi_inve_x_ct_cbteCble_Info Info) 
        {
            try
            {
                using (EntitiesInventario entity = new EntitiesInventario())
                {
                    in_movi_inve_x_ct_cbteCble item = new in_movi_inve_x_ct_cbteCble();
                    item.IdEmpresa = Info.IdEmpresa;
                    item.IdSucursal = Info.IdSucursal;
                    item.IdBodega = Info.IdBodega;
                    item.IdMovi_inven_tipo = Info.IdMovi_inven_tipo;
                    item.IdNumMovi = Info.IdNumMovi;

                    item.IdEmpresa_ct = Info.IdEmpresa_ct;
                    item.IdTipoCbte = Info.IdTipoCbte;
                    item.IdCbteCble = Info.IdCbteCble;
                    item.Observacion = (Info.Observacion == null) ? "" : Info.Observacion;
                    entity.in_movi_inve_x_ct_cbteCble.Add(item);
                    entity.SaveChanges();
                 }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_movi_inve_x_ct_cbteCble_Info Get_Info_x_Movi_Inven(int IdEmpresa,int idsucursal,int idbodega ,int idmovi_inven_tipo,decimal idNum_Movi )
        {
            try
            {
                EntitiesInventario entity = new EntitiesInventario();

                in_movi_inve_x_ct_cbteCble_Info Info_Movi = new in_movi_inve_x_ct_cbteCble_Info();
                
                var Select  = from q in entity.in_movi_inve_x_ct_cbteCble
                              where q.IdEmpresa_ct==IdEmpresa && q.IdSucursal==idsucursal
                              && q.IdBodega==idbodega && q.IdMovi_inven_tipo==idmovi_inven_tipo 
                              && q.IdNumMovi==idNum_Movi
                               select q;

                    foreach (var item in Select)
                    {
                        Info_Movi.IdEmpresa = item.IdEmpresa;
                        Info_Movi.IdSucursal= item.IdSucursal;
                        Info_Movi.IdBodega= item.IdBodega;
                        Info_Movi.IdMovi_inven_tipo= item.IdMovi_inven_tipo;
                        Info_Movi.IdNumMovi= item.IdNumMovi;
                        Info_Movi.IdEmpresa_ct = item.IdEmpresa_ct;
                        Info_Movi.IdTipoCbte= item.IdTipoCbte;
                        Info_Movi.IdCbteCble= item.IdCbteCble;
                        Info_Movi.Observacion = item.Observacion;
                    }

                    return Info_Movi;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString().ToString());
            }
        }

        public in_movi_inve_x_ct_cbteCble_Info Anular_reversar_Diario_x_Movi_Inven
            (int IdEmpresa, int idsucursal, int idbodega, int idmovi_inven_tipo, decimal idNum_Movi ,int IdTipoCbteCble_x_anulacion
            , ref decimal IdCbteCble_Reverso )
        {
            try
            {
                EntitiesInventario entity = new EntitiesInventario();
                in_movi_inve_x_ct_cbteCble_Info Info_Movi = new in_movi_inve_x_ct_cbteCble_Info();

                var Select = from q in entity.in_movi_inve_x_ct_cbteCble
                             where q.IdEmpresa_ct == IdEmpresa && q.IdSucursal == idsucursal
                             && q.IdBodega == idbodega && q.IdMovi_inven_tipo == idmovi_inven_tipo
                             && q.IdNumMovi == idNum_Movi
                             select q;


                foreach (var item in Select)
                {
                    Info_Movi.IdEmpresa = item.IdEmpresa;
                    Info_Movi.IdSucursal = item.IdSucursal;
                    Info_Movi.IdBodega = item.IdBodega;
                    Info_Movi.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Info_Movi.IdNumMovi = item.IdNumMovi;

                    Info_Movi.IdEmpresa_ct = item.IdEmpresa_ct;
                    Info_Movi.IdTipoCbte = item.IdTipoCbte;
                    Info_Movi.IdCbteCble = item.IdCbteCble;
                    Info_Movi.Observacion = item.Observacion;
                }

                string mensaje="";

                ct_Cbtecble_Data Cbte_Data = new ct_Cbtecble_Data();
                Cbte_Data.ReversoCbteCble(Info_Movi.IdEmpresa_ct, Info_Movi.IdCbteCble, Info_Movi.IdTipoCbte
                    , IdTipoCbteCble_x_anulacion, ref IdCbteCble_Reverso, ref mensaje, "sys");




                return Info_Movi;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
