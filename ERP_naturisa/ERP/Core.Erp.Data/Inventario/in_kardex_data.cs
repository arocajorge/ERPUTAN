using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{


    public class in_kardex_data
    {
        string mensaje = "";
        List<in_movi_inve_detalle_Info> list_movi_inve_det = new List<in_movi_inve_detalle_Info>();
        List<in_kardex_det_info> listKardex_det = new List<in_kardex_det_info>();
        in_kardex_Info Kardex_i = new in_kardex_Info();



        public List<in_kardex_det_info> Get_list_kardex_det_info
           (int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin
           , DateTime FechaIni, DateTime FechaFin, int TipoMoviIni, int TipoMoviFin, decimal IdProductoIni, decimal IdProductoFin)
        {
            try
            {
               
                

                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from det in OECbtecble_Info.vwin_movi_inve_detalle
                                     where det.IdEmpresa == IdEmpresa
                                     && det.IdSucursal >= IdSucursalIni && det.IdSucursal <= IdSucursalFin
                                     && det.IdBodega >= IdBodegaIni && det.IdBodega <= IdBodegaFin
                                        && det.cm_fecha >= FechaIni && det.cm_fecha <= FechaFin
                                     && det.IdMovi_inven_tipo >= TipoMoviIni && det.IdMovi_inven_tipo <= TipoMoviFin
                                     && det.IdProducto >= IdProductoIni && det.IdProducto <= IdProductoFin
                                     select det;


                foreach (var item in selectCbtecble)
                {
                    in_movi_inve_detalle_Info moviI = new in_movi_inve_detalle_Info();

                    moviI.dm_cantidad = item.dm_cantidad;
                    moviI.dm_observacion = item.dm_observacion;
                    moviI.dm_stock_actu = item.dm_stock_actu;
                    moviI.dm_stock_ante = item.dm_stock_ante;
                    moviI.IdEmpresa = item.IdEmpresa;
                    moviI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    moviI.IdNumMovi = item.IdNumMovi;
                    moviI.IdProducto = item.IdProducto;
                    moviI.IdSucursal = item.IdSucursal;
                    moviI.mv_costo = item.mv_costo;
                    moviI.mv_tipo_movi = item.mv_tipo_movi;
                    moviI.Secuencia = item.Secuencia;


                   

                   //list_movi_inve_det.Add(moviI);



                    in_kardex_det_info Kardet_i = new in_kardex_det_info();


                    Kardet_i.IdEmpresa = moviI.IdEmpresa;
                    Kardet_i.IdSucursal = moviI.IdSucursal;
                    Kardet_i.IdBodega = moviI.IdBodega;
                    Kardet_i.IdProducto = moviI.IdProducto;
                    Kardet_i.kr_CostoUni = moviI.mv_costo == null ? 0 : Convert.ToDouble(moviI.mv_costo);
                //    Kardet_i.kr_fecha = moviI.Fecha;
                 //   Kardet_i.kr_Motivo = moviI.TipoMoviInven;
               
                    Kardet_i.kr_Tipo = moviI.mv_tipo_movi;
                    Kardet_i.Secuencia = moviI.Secuencia;
            //        Kardet_i.Transaccion = moviI.CodMoviInven + "\\" + moviI.IdNumMovi;

                    if (moviI.mv_tipo_movi == "+")
                    {
                        Kardet_i.kr_Ent_Cantidad = moviI.dm_cantidad;
                        Kardet_i.kr_Ent_valor = Kardet_i.kr_Ent_Cantidad * Kardet_i.kr_CostoUni;
                    }


                    if (moviI.mv_tipo_movi == "-")
                    {
                        Kardet_i.kr_Sali_Cantidad = moviI.dm_cantidad;
                        Kardet_i.kr_Sali_valor = Kardet_i.kr_Ent_Cantidad * Kardet_i.kr_CostoUni;
                    }


                    Kardet_i.categoria = item.RutaPadre + "\\" + item.ca_Categoria;
                    Kardet_i.Marca = item.Descripcion;
                    Kardet_i.peso = 0;
                    Kardet_i.CodProducto = item.pr_codigo;
                    Kardet_i.NomProducto = item.pr_descripcion;
                   // Kardet_i.Fecha = item.cm_fecha;
                    Kardet_i.kr_Observacion = moviI.dm_observacion;
                //    Kardet_i.CodMoviInven = moviI.CodMoviInven;
                    Kardet_i.TipoMoviInven = item.TipoMoviInvent;
                 //   Kardet_i.CodTipoMoviInven = moviI.CodTipoMoviInven;



                    listKardex_det.Add(Kardet_i);

                }
                return (listKardex_det);
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
