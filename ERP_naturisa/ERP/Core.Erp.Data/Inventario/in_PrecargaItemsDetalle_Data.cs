using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
    public class in_PrecargaItemsDetalle_Data
    {
        string mensaje = "";
        public List<in_PrecargaItemsDetalle_Info> Get_List_PrecargaItemsDetalle(int IdPrecarga, int IdEmpresa)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();

                List<in_PrecargaItemsDetalle_Info> lM = new List<in_PrecargaItemsDetalle_Info>();
                var select = from C in OEInventario.in_PrecargaItemsOrdenCompra_det
                             where C.IdEmpresa == IdEmpresa && C.IdPrecarga == IdPrecarga
                             orderby C.Secuencia ascending
                             select C;

                foreach (var item in select)
                {
                    in_PrecargaItemsDetalle_Info info = new in_PrecargaItemsDetalle_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdPrecarga = item.IdPrecarga;
                    info.Secuencia = item.Secuencia;
                    info.IdProducto = item.IdProducto;
                    info.dpr_Cantidad = item.dpr_Cantidad;
                    info.dpr_costo = item.dpr_costo;
                    info.dpr_porc_des = item.dpr_porc_des;
                    info.dpr_descuento = item.dpr_descuento;
                    info.dpr_subtotal = item.dpr_subtotal;
                    info.dpr_iva = item.dpr_iva;
                    info.dpr_total = item.dpr_total;
                    info.dpr_ManejaIva = item.dpr_ManejaIva;
                    info.dpr_Costeado = item.dpr_Costeado;
                    info.dpr_costo_promedio_hist = item.dpr_costo_promedio_hist;
                    info.dpr_peso = item.dpr_peso;
                    info.dpr_observacion = item.dpr_observacion;
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

        public List<in_PrecargaItemsDetalle_Info> Get_List_PrecargaItemsDetalle_x_sucursal(int IdEmpresa, int IdSucursal)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();

                List<in_PrecargaItemsDetalle_Info> lM = new List<in_PrecargaItemsDetalle_Info>();

                var select = from det in OEInventario.vwin_PrecargaItemsOrdenCompra_det
                             join cab in OEInventario.vwin_PrecargaItemsOrdenCompra
                             on new { det.IdPrecarga } equals new { cab.IdPrecarga }
                             where det.IdEmpresa == IdEmpresa && det.IdSucursal == IdSucursal
                             orderby det.Secuencia ascending
                             select new
                             {
                                 cab.IdEmpresa,
                                 cab.IdSucursal,
                                 cab.IdCentroCosto,
                                 cab.IdOrdenTaller,
                                 cab.IdProveedor,
                                 cab.IdPrecarga,
                                 cab.CodCentroCosto,
                                 cab.Centro_costo,
                                 cab.NumeroOT,
                                 cab.CodOrdenTaller,
                                 det.Secuencia,
                                 det.IdProducto,
                                 det.dpr_observacion,
                                 det.dpr_Cantidad,
                                 det.dpr_peso,
                                 det.dpr_costo,
                                 det.dpr_porc_des,
                                 det.dpr_descuento,
                                 det.dpr_subtotal,
                                 det.dpr_iva,
                                 det.dpr_total,
                                 det.pr_codigo,
                                 det.pr_descripcion,
                                 det.dpr_ManejaIva,
                                 det.dpr_Costeado,
                                 det.dpr_costo_promedio_hist,
                                 det.EstadoProcesado,
                             };

                foreach (var item in select)
                {
                    in_PrecargaItemsDetalle_Info info = new in_PrecargaItemsDetalle_Info();
                    //cabecera
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdOrdenTaller = item.IdOrdenTaller;
                    info.IdProveedor = item.IdProveedor;
                    info.IdPrecarga = item.IdPrecarga;
                    info.CodCentroCosto = item.CodCentroCosto;
                    info.NomCentroCosto = item.Centro_costo;
                    info.Referencia = "[" + item.CodCentroCosto.Trim() + "] - " + item.Centro_costo.Trim();
                    info.NumeroOT = item.NumeroOT;
                    info.CodOrdenTaller = item.CodOrdenTaller;
                    //detalle
                    info.Secuencia = item.Secuencia;
                    info.IdProducto = item.IdProducto;
                    info.dpr_Cantidad = item.dpr_Cantidad;
                    info.dpr_costo = item.dpr_costo;
                    info.dpr_porc_des = item.dpr_porc_des;
                    info.dpr_descuento = item.dpr_descuento;
                    info.dpr_subtotal = item.dpr_subtotal;
                    info.dpr_iva = item.dpr_iva;
                    info.dpr_total = item.dpr_total;
                    info.dpr_ManejaIva = item.dpr_ManejaIva;
                    info.dpr_Costeado = item.dpr_Costeado;
                    info.dpr_costo_promedio_hist = item.dpr_costo_promedio_hist;
                    info.dpr_peso = item.dpr_peso;
                    info.dpr_observacion = item.dpr_observacion;
                    info.EstadoProcesado = item.EstadoProcesado;
                    info.pr_codigo = item.pr_codigo;
                    info.pr_descripcion = item.pr_descripcion;
                    //Con false no ha sido procesado
                    info.EstadoProcesadoBool = (item.EstadoProcesado == "N") ? false : true;
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

        public Boolean GrabarDB(List<in_PrecargaItemsDetalle_Info> lmDetalleInfo, int IdEmpresa, int IdPrecarga, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    foreach (var item in lmDetalleInfo)
                    {
                        var address = new in_PrecargaItemsOrdenCompra_det();
                        address.IdEmpresa = IdEmpresa;
                        address.IdSucursal = item.IdSucursal;
                        address.IdPrecarga = IdPrecarga;
                        address.Secuencia = item.Secuencia;
                        address.IdProducto = item.IdProducto;
                        address.dpr_Cantidad = item.dpr_Cantidad;
                        address.dpr_costo = item.dpr_costo;
                        address.dpr_porc_des = item.dpr_porc_des;
                        address.dpr_descuento = item.dpr_descuento;
                        address.dpr_subtotal = item.dpr_subtotal;
                        address.dpr_iva = item.dpr_iva;
                        address.dpr_total = item.dpr_total;
                        address.dpr_ManejaIva = item.dpr_ManejaIva;
                        address.dpr_Costeado = item.dpr_Costeado;
                        address.dpr_costo_promedio_hist = item.dpr_costo_promedio_hist;
                        address.dpr_peso = item.dpr_peso;
                        address.dpr_observacion = item.dpr_observacion;
                        address.EstadoProcesado = item.Estado;
                        context.in_PrecargaItemsOrdenCompra_det.Add(address);
                        context.SaveChanges();
                    }
                    context.Dispose();
                }
                msg = "Guardado con exito";
                return true;
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

        public Boolean EliminarDB(List<in_PrecargaItemsDetalle_Info> lmDetalleInfo, int IdEmpresa, int IdPrecarga, ref string msg)
        {
            try
            {
                using (EntitiesInventario contex1 = new EntitiesInventario())
                {

                    foreach (var item in lmDetalleInfo)
                    {
                        var address = contex1.in_PrecargaItemsOrdenCompra_det.FirstOrDefault(A => A.IdEmpresa == IdEmpresa && A.IdSucursal == item.IdSucursal && A.IdPrecarga == IdPrecarga && A.Secuencia == item.Secuencia);
                        if (address != null)
                        {
                            contex1.in_PrecargaItemsOrdenCompra_det.Remove(address);
                            contex1.SaveChanges();
                            msg = "Guardado con exito";
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Error no se guardó " + ex.Message + " ";
                throw new Exception(mensaje);
            }
        }

        public Boolean CambiaEstadoProcesado(List<in_PrecargaItemsDetalle_Info> lmDetalleInfo, int IdEmpresa)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    foreach (var item in lmDetalleInfo)
                    {
                        var contact = context.in_PrecargaItemsOrdenCompra_det.FirstOrDefault(A => A.IdEmpresa == IdEmpresa && A.IdSucursal == item.IdSucursal && A.IdPrecarga == item.IdPrecarga && A.Secuencia==item.Secuencia);
                        if (contact != null)
                        {
                            contact.EstadoProcesado = "S";
                            context.SaveChanges();
                        }
                    }
                    context.Dispose();
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
                throw new Exception(mensaje);
            }
        }
    }
}
