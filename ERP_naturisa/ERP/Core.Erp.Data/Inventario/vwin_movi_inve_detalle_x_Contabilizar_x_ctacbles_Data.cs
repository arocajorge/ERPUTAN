using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Inventario;



namespace Core.Erp.Data.Inventario
{
   public class vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Data
    {

        string mensaje = "";

        public List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info> Get_List_movi_inve_detalle_x_Contabilizar_x_ctacbles
       (int IdEmpresa, int IdSucursal , int IdBodega,  string tipoMovi, int IdMovi_inven_tipo, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                int IdSucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
                int IdSucursalFin = (IdSucursal == 0) ? 99999 : IdSucursal;
                int IdBodegaIni = (IdBodega == 0) ? 1 : IdBodega;
                int IdBodegaFin = (IdBodega == 0) ? 999999 : IdBodega;
                int IdMovi_inven_tipoIni = (IdMovi_inven_tipo == 0) ? 1 : IdMovi_inven_tipo;
                int IdMovi_inven_tipoFin = (IdMovi_inven_tipo == 0) ? 999999 : IdMovi_inven_tipo;

                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info> lista = new List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info>();


                using (EntitiesInventario Entity = new EntitiesInventario())
                {
                    FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                    FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                    var Consulta = from q in Entity.vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles
                                   where q.IdEmpresa == IdEmpresa
                                   && q.IdSucursal >= IdSucursalIni && q.IdSucursal <=IdSucursalFin
                                   && q.IdBodega>=IdBodegaIni && q.IdBodega<=IdBodegaFin
                                   && q.IdMovi_inven_tipo >= IdMovi_inven_tipoIni && q.IdMovi_inven_tipo <=IdMovi_inven_tipoFin
                                   && q.cm_fecha >= FechaIni && q.cm_fecha <= FechaFin
                                   //&& tipoMovi.Contains(q.mv_tipo_movi)
                                   select q;

                    foreach (var item in Consulta)
                    {
                        vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info info = new vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info();

                            info.IdEmpresa=item.IdEmpresa;
                            info.IdSucursal=item.IdSucursal;
                            info.IdBodega=item.IdBodega;
                            info.IdMovi_inven_tipo=item.IdMovi_inven_tipo;
                            info.IdNumMovi=item.IdNumMovi;
                            info.Secuencia=item.Secuencia;
                            info.mv_tipo_movi=item.mv_tipo_movi;
                            info.IdProducto=item.IdProducto;
                            info.cod_producto=item.cod_producto;
                            info.nom_producto=item.nom_producto;
                            info.dm_cantidad=item.dm_cantidad;
                            info.mv_costo = item.mv_costo;
                            info.subtotal = item.dm_cantidad * item.mv_costo;


                            info.dm_stock_ante=item.dm_stock_ante;
                            info.dm_stock_actu=item.dm_stock_actu;
                            info.dm_observacion=item.dm_observacion;
                            
                            info.dm_peso = (item.dm_peso == null) ? 0 : Convert.ToDouble(item.dm_peso);
                            info.cm_fecha=item.cm_fecha;
                            info.IdTipoCbte = (item.IdTipoCbte == null) ? 1 : Convert.ToInt32(item.IdTipoCbte);
                            info.nom_tipo_mov_inv=item.nom_tipo_mov_inv;
                            info.nom_TipoCbte=item.nom_TipoCbte;
                            info.nom_bodega=item.nom_bodega;
                            info.nom_sucursal=item.nom_sucursal;
                            info.IdPunto_cargo=item.IdPunto_cargo;
                            info.IdPunto_cargo_grupo=item.IdPunto_cargo_grupo;
                            info.IdMotivo_Inv=item.IdMotivo_Inv;
                            info.IdMotivo_Inv_det = item.IdMotivo_Inv_det;

                            info.IdCentro_Costo_x_MoviInv=item.IdCentro_Costo_x_MoviInv;
                            info.IdSubCentro_Costo_x_MoviInv=item.IdSubCentro_Costo_x_MoviInv;
                            info.IdCategoria=item.IdCategoria;
                            info.IdLinea=item.IdLinea;
                            info.IdGrupo=item.IdGrupo;
                            info.IdSubGrupo=item.IdSubGrupo;

                            info.IdCtaCtble_Inve_x_Bod=item.IdCtaCtble_Inve_x_Bod;
                            info.IdCtaCtble_Costo_x_Bod=item.IdCtaCtble_Costo_x_Bod;

                            info.IdCtaCble_Inven_x_Motivo=item.IdCtaCble_Inven_x_Motivo;
                            info.IdCtaCble_Costo_x_Motivo = item.IdCtaCble_Costo_x_Motivo;

                            info.IdCtaCble_Inven_x_Motivo_det = item.IdCtaCble_Inven_x_Motivo_det;
                            info.IdCtaCble_Costo_x_Motivo_det = item.IdCtaCble_Costo_x_Motivo_det;


                            info.IdCtaCble_Inven_x_Prod=item.IdCtaCble_Inven_x_Prod;
                            info.IdCtaCble_Costo_x_Prod=item.IdCtaCble_Costo_x_Prod;
                            info.IdCtaCtble_Inve_x_SubGrupo = item.IdCtaCtble_Inve_x_SubGrupo;
                            info.IdCtaCtble_Costo_x_SubGrupo = item.IdCtaCtble_Costo_x_SubGrupo;

                            info.es_Inven_o_Consumo =(string.IsNullOrEmpty(item.es_Inven_o_Consumo)==true) ? ein_Inventario_O_Consumo.TIC_INVEN:(ein_Inventario_O_Consumo) Enum.Parse(typeof(ein_Inventario_O_Consumo), item.es_Inven_o_Consumo); 
                            info.es_Inven_o_Consumo_det = (string.IsNullOrEmpty(item.es_Inven_o_Consumo_det)==true) ? ein_Inventario_O_Consumo.TIC_INVEN:(ein_Inventario_O_Consumo) Enum.Parse(typeof(ein_Inventario_O_Consumo), item.es_Inven_o_Consumo_det);
                            info.Fecha_Transac = item.Fecha_Transac;

                            lista.Add(info);
                    }

                    return lista;
                }
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


        public List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info> Get_List_movi_inve_detalle_x_Contabilizar_x_ctacbles
        (int IdEmpresa, int idSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {


                List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info> lista = new List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info>();


                using (EntitiesInventario Entity = new EntitiesInventario())
                {

                    var Consulta = from q in Entity.vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles
                                   where q.IdEmpresa == IdEmpresa 
                                   && q.IdSucursal == idSucursal 
                                   && q.IdBodega==IdBodega
                                   && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                                   && q.IdNumMovi == IdNumMovi
                                   select q;

                    foreach (var item in Consulta)
                    {
                        vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info info = new vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        info.IdNumMovi = item.IdNumMovi;
                        info.Secuencia = item.Secuencia;
                        info.mv_tipo_movi = item.mv_tipo_movi;
                        info.IdProducto = item.IdProducto;
                        info.cod_producto = item.cod_producto;
                        info.nom_producto = item.nom_producto;
                        info.dm_cantidad = item.dm_cantidad;
                        info.dm_stock_ante = item.dm_stock_ante;
                        info.dm_stock_actu = item.dm_stock_actu;
                        info.dm_observacion = item.dm_observacion;
                        info.mv_costo = item.mv_costo;
                        info.dm_peso = (item.dm_peso == null) ? 0 : Convert.ToDouble(item.dm_peso);
                        info.cm_fecha = item.cm_fecha;
                        info.IdTipoCbte = (item.IdTipoCbte == null) ? 1 : Convert.ToInt32(item.IdTipoCbte);
                        info.nom_tipo_mov_inv = item.nom_tipo_mov_inv;
                        info.nom_TipoCbte = item.nom_TipoCbte;
                        info.nom_bodega = item.nom_bodega;
                        info.nom_sucursal = item.nom_sucursal;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info.IdMotivo_Inv = item.IdMotivo_Inv;
                        info.IdMotivo_Inv_det = item.IdMotivo_Inv_det;

                        info.IdCentro_Costo_x_MoviInv = item.IdCentro_Costo_x_MoviInv;
                        info.IdSubCentro_Costo_x_MoviInv = item.IdSubCentro_Costo_x_MoviInv;
                        info.IdCategoria = item.IdCategoria;
                        info.IdLinea = item.IdLinea;
                        info.IdGrupo = item.IdGrupo;
                        info.IdSubGrupo = item.IdSubGrupo;
                        info.IdCtaCtble_Inve_x_Bod = item.IdCtaCtble_Inve_x_Bod;
                        info.IdCtaCtble_Costo_x_Bod = item.IdCtaCtble_Costo_x_Bod;

                        info.IdCtaCble_Inven_x_Motivo = item.IdCtaCble_Inven_x_Motivo;
                        info.IdCtaCble_Costo_x_Motivo = item.IdCtaCble_Costo_x_Motivo;

                        info.IdCtaCble_Inven_x_Motivo_det = item.IdCtaCble_Inven_x_Motivo_det;
                        info.IdCtaCble_Costo_x_Motivo_det = item.IdCtaCble_Costo_x_Motivo_det;

                        info.IdCtaCble_Inven_x_Prod = item.IdCtaCble_Inven_x_Prod;
                        info.IdCtaCble_Costo_x_Prod = item.IdCtaCble_Costo_x_Prod;
                        info.IdCtaCtble_Inve_x_SubGrupo = item.IdCtaCtble_Inve_x_SubGrupo;
                        info.IdCtaCtble_Costo_x_SubGrupo = item.IdCtaCtble_Costo_x_SubGrupo;
                        
                        info.es_Inven_o_Consumo =(string.IsNullOrEmpty(item.es_Inven_o_Consumo)==true) ? ein_Inventario_O_Consumo.TIC_INVEN:(ein_Inventario_O_Consumo) Enum.Parse(typeof(ein_Inventario_O_Consumo), item.es_Inven_o_Consumo); 
                        info.es_Inven_o_Consumo_det = (string.IsNullOrEmpty(item.es_Inven_o_Consumo_det)==true) ? ein_Inventario_O_Consumo.TIC_INVEN:(ein_Inventario_O_Consumo) Enum.Parse(typeof(ein_Inventario_O_Consumo), item.es_Inven_o_Consumo_det);

                        info.Fecha_Transac = item.Fecha_Transac;

                        lista.Add(info);

                    }


                    return lista;
                }

               
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }


    }
}
