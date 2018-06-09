using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using Core.Erp.Info.Inventario;

using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Data.Inventario
{
    public class vwin_Ingreso_Egreso_varios_det_Data
    {
        string mensaje = "";

        public List<vwin_Ingreso_Egreso_varios_det_Info> Consulta_IngEgrVariosDet(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();

                List<vwin_Ingreso_Egreso_varios_det_Info> lM = new List<vwin_Ingreso_Egreso_varios_det_Info>();

                var select = from C in OEInventario.vwin_Ingreso_Egreso_varios_det
                             where C.IdEmpresa == IdEmpresa 
                             && C.IdSucursal == IdSucursal && C.IdBodega == IdBodega && C.IdMovi_inven_tipo == IdMovi_inven_tipo
                             orderby C.secuencia ascending
                             select C;

                foreach (var item in select)
                {
                    vwin_Ingreso_Egreso_varios_det_Info info = new vwin_Ingreso_Egreso_varios_det_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.IdNumMovi = item.IdNumMovi;
                    info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    info.secuencia = item.secuencia;
                    info.IdProducto = item.IdProducto;
                    info.dm_cantidad = item.dm_cantidad;
                    info.dm_stock_ante = item.dm_stock_ante;
                    info.dm_stock_actu = item.dm_stock_actu;
                    info.dm_observacion = item.dm_observacion;
                    info.dm_precio = item.dm_precio;
                    info.mv_costo = item.mv_costo;
                    info.dm_peso = Convert.ToDouble(item.dm_peso);
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.IdEstadoAproba = item.IdEstadoAproba;
                    info.IdUnidadMedida = item.IdUnidadMedida;

                    info.Su_Descripcion = item.Su_Descripcion;
                    info.bo_Descripcion = item.bo_Descripcion;
                    info.tm_descripcion = item.tm_descripcion;
                    info.pr_descripcion = item.pr_descripcion;
                    info.nom_Medida = item.nom_Medida;
                    info.cm_tipo_movi = item.cm_tipo_movi;


                    info.mv_costo_AUX = item.mv_costo;
                    info.IdEstadoAproba_AUX = item.IdEstadoAproba;

                    info.subtotal = item.dm_cantidad * item.mv_costo;
                    info.subtotal_AUX = item.dm_cantidad * item.mv_costo;

                    lM.Add(info);
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<vwin_Ingreso_Egreso_varios_det_Info>();
            }
        }

        public Boolean Modificar_Estado_IngEgr_Det(List<vwin_Ingreso_Egreso_varios_det_Info> lista, string tipo, ref string msgs)
        {
            try
            {                                          
               using (EntitiesInventario context = new EntitiesInventario())
                {
                    if (tipo == "+")
                    {
                        foreach (var item in lista)
                        {
                         //   var contact = context.in_Ingreso_varios_det.First(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi && q.Secuencia == item.secuencia && q.IdProducto == item.IdProducto);

                            var contact = context.in_Ing_Egr_Inven_det.First(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega &&  q.IdNumMovi == item.IdNumMovi && q.Secuencia == item.secuencia && q.IdProducto == item.IdProducto);

                            contact.mv_costo = item.mv_costo;
                            contact.IdEstadoAproba = item.IdEstadoAproba;

                            context.SaveChanges();

                            msgs = "Actualización Ingresos ok...";
                        }
                    }
                    else 
                    {
                        foreach (var item in lista)
                        {
                            var contact = context.in_Ing_Egr_Inven_det.First(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega &&  q.IdNumMovi == item.IdNumMovi && q.Secuencia == item.secuencia && q.IdProducto == item.IdProducto);

                            contact.mv_costo = item.mv_costo;
                            contact.IdEstadoAproba = item.IdEstadoAproba;

                            context.SaveChanges();

                            msgs = "Actualización Egresos ok...";
                        }                   
                    }                                                           
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msgs = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
                return false;
            }
        }

    }
}
