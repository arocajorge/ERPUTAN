using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
    public class vwin_Ing_Egr_Inven_det_Data
    {
        string mensaje = "";

        public List<vwin_Ing_Egr_Inven_det_Info> Get_List_in_Ing_Egr_Inven_det(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, string IdEstadoAproba)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();

                List<vwin_Ing_Egr_Inven_det_Info> lM = new List<vwin_Ing_Egr_Inven_det_Info>();

                var select = from C in OEInventario.vwin_Ing_Egr_Inven_det
                             where C.IdEmpresa == IdEmpresa 
                             && C.IdSucursal == IdSucursal && C.IdBodega == IdBodega && C.IdMovi_inven_tipo == IdMovi_inven_tipo
                             && C.IdEstadoAproba == IdEstadoAproba
                             orderby C.Secuencia ascending
                             select C;

                foreach (var item in select)
                {
                    vwin_Ing_Egr_Inven_det_Info info = new vwin_Ing_Egr_Inven_det_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.IdNumMovi = item.IdNumMovi;
                    info.IdMovi_inven_tipo = Convert.ToInt32(item.IdMovi_inven_tipo);
                    info.secuencia = item.Secuencia;
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
                    
                    info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                    info.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                    info.mv_costo_sinConversion = item.mv_costo_sinConversion == null ? 0 : Convert.ToDouble(item.mv_costo_sinConversion);

                    info.nom_sucursal = item.nom_sucursal;
                    info.nom_bodega = item.nom_bodega;
                    info.nom_tipo_inv = item.nom_tipo_inv;
                    info.nom_producto = item.nom_producto;
                    info.nom_medida = item.nom_medida;
                    info.signo = item.signo;
                    info.nom_motivo = item.nom_motivo;
                    info.nom_punto_cargo = item.nom_punto_cargo;

                    info.mv_costo_AUX = item.mv_costo_sinConversion == null ? 0 : Convert.ToDouble(item.mv_costo_sinConversion);
                    info.IdEstadoAproba_AUX = item.IdEstadoAproba;
                    
                    info.subtotal = (item.dm_cantidad_sinConversion == null ? 0 : Convert.ToDouble(item.dm_cantidad_sinConversion)) * (item.mv_costo_sinConversion==null ? 0 : Convert.ToDouble(item.mv_costo_sinConversion));
                    info.subtotal_AUX = (item.dm_cantidad_sinConversion == null ? 0 : Convert.ToDouble(item.dm_cantidad_sinConversion)) * (item.mv_costo_sinConversion == null ? 0 : Convert.ToDouble(item.mv_costo_sinConversion));
                    info.cm_fecha = item.cm_fecha;
                    info.Motivo_Aprobacion = item.Motivo_Aprobacion;
                    info.IdPunto_cargo = Convert.ToInt32(item.IdPunto_cargo);
                    info.IdMotivo_Inv = item.IdMotivo_Inv;
                    info.Estado = item.Estado;
                    info.Fecha_registro = item.Fecha_registro;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public List<vwin_Ing_Egr_Inven_det_Info> Get_List_in_Ing_Egr_Inven_det(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, string IdEstadoAproba, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                List<vwin_Ing_Egr_Inven_det_Info> lM = new List<vwin_Ing_Egr_Inven_det_Info>();

                var select = from C in OEInventario.vwin_Ing_Egr_Inven_det
                             where C.IdEmpresa == IdEmpresa
                             && C.IdSucursal == IdSucursal && C.IdBodega == IdBodega && C.IdMovi_inven_tipo == IdMovi_inven_tipo
                             && C.IdEstadoAproba == IdEstadoAproba
                             && Fecha_ini <= C.cm_fecha && C.cm_fecha <= Fecha_fin
                             orderby C.Secuencia ascending
                             select C;

                foreach (var item in select)
                {
                    vwin_Ing_Egr_Inven_det_Info info = new vwin_Ing_Egr_Inven_det_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.IdNumMovi = item.IdNumMovi;
                    info.IdMovi_inven_tipo = Convert.ToInt32(item.IdMovi_inven_tipo);
                    info.secuencia = item.Secuencia;
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

                    info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                    info.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                    info.mv_costo_sinConversion = item.mv_costo_sinConversion == null ? 0 : Convert.ToDouble(item.mv_costo_sinConversion);

                    info.nom_sucursal = item.nom_sucursal;
                    info.nom_bodega = item.nom_bodega;
                    info.nom_tipo_inv = item.nom_tipo_inv;
                    info.nom_producto = item.nom_producto;
                    info.nom_medida = item.nom_medida;
                    info.signo = item.signo;
                    info.nom_motivo = item.nom_motivo;
                    info.nom_punto_cargo = item.nom_punto_cargo;

                    info.mv_costo_AUX = item.mv_costo_sinConversion == null ? 0 : Convert.ToDouble(item.mv_costo_sinConversion);
                    info.IdEstadoAproba_AUX = item.IdEstadoAproba;

                    info.subtotal = (item.dm_cantidad_sinConversion == null ? 0 : Convert.ToDouble(item.dm_cantidad_sinConversion)) * (item.mv_costo_sinConversion == null ? 0 : Convert.ToDouble(item.mv_costo_sinConversion));
                    info.subtotal_AUX = (item.dm_cantidad_sinConversion == null ? 0 : Convert.ToDouble(item.dm_cantidad_sinConversion)) * (item.mv_costo_sinConversion == null ? 0 : Convert.ToDouble(item.mv_costo_sinConversion));
                    info.cm_fecha = item.cm_fecha;
                    info.Motivo_Aprobacion = item.Motivo_Aprobacion;
                    info.IdPunto_cargo = Convert.ToInt32(item.IdPunto_cargo);
                    info.IdMotivo_Inv = item.IdMotivo_Inv;
                    info.Estado = item.Estado;
                    info.Fecha_registro = item.Fecha_registro;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public Boolean Modificar_Estado_IngEgr_Det(List<in_Ing_Egr_Inven_det_Info> lista, string tipo, ref string msgs)
        {
            try
            {                                          
               using (EntitiesInventario context = new EntitiesInventario())
                {
                    foreach (var item in lista)
                    {
                        var contact = context.in_Ing_Egr_Inven_det.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdNumMovi == item.IdNumMovi && q.Secuencia == item.Secuencia && item.IdMovi_inven_tipo == q.IdMovi_inven_tipo);
                        if (contact != null)
                        {
                            contact.mv_costo = item.mv_costo;
                            contact.IdEstadoAproba = item.IdEstadoAproba;
                            contact.Motivo_Aprobacion = item.Motivo_Aprobacion;
                            context.SaveChanges();
                            msgs = "El Estado se aprobo exitosamente";
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
                msgs = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
                throw new Exception(mensaje);
            }
        }

    }
}
