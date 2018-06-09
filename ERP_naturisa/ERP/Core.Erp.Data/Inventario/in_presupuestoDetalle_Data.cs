using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Inventario
{
    public class in_presupuestoDetalle_Data
    {
        string mensaje = "";
        public List<in_presupuestoDetalle_Info> Get_List_presupuestoDetalle(int IdPresupuesto, int IdEmpresa)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                
                List<in_presupuestoDetalle_Info> lM = new List<in_presupuestoDetalle_Info>();
                var select= from C in OEInventario.vwin_presupuesto_detalle
                             where C.IdEmpresa == IdEmpresa && C.IdPresupuesto == IdPresupuesto
                             orderby C.Secuencia ascending
                             select C;

                foreach (var item in select)
                {
                    in_presupuestoDetalle_Info info = new in_presupuestoDetalle_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdPresupuesto = item.IdPresupuesto;
                    info.Secuencia = item.Secuencia;
                    info.IdProducto = item.IdProducto;
                    info.dp_Cantidad = item.dp_Cantidad;
                    info.dp_costo = item.dp_costo;
                    info.dp_porc_des = item.dp_porc_des;
                    info.dp_descuento = item.dp_descuento;
                    info.dp_subtotal = item.dp_subtotal;
                    info.dp_iva = item.dp_iva;
                    info.dp_total = item.dp_total;
                    info.dp_ManejaIva = item.dp_ManejaIva;
                    info.dp_Costeado = item.dp_Costeado;
                    info.dp_costo_promedio_hist = item.dp_costo_promedio_hist;
                    info.dp_peso = item.dp_peso;
                    info.dp_observacion = item.dp_observacion;

                    info.pr_codigo = item.pr_codigo;
                    info.pr_descripcion = item.pr_descripcion;


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

        public Boolean GrabarDB(List<in_presupuestoDetalle_Info> lmDetalleInfo, int IdEmpresa, int IdPresupuesto, ref string msg)
        {
            try
            {
               
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    foreach (var item in lmDetalleInfo)
                    {
                        
                        var address = new in_presupuesto_det();

                        address.IdEmpresa = IdEmpresa;
                        address.IdSucursal = item.IdSucursal;
                        address.IdPresupuesto = IdPresupuesto;
                        address.Secuencia = item.Secuencia;
                        address.IdProducto = item.IdProducto;
                        address.dp_Cantidad = item.dp_Cantidad;
                        address.dp_costo = item.dp_costo;
                        address.dp_porc_des = item.dp_porc_des;
                        address.dp_descuento = item.dp_descuento;
                        address.dp_subtotal = item.dp_subtotal;
                        address.dp_iva = item.dp_iva;
                        address.dp_total = item.dp_total;
                        address.dp_ManejaIva = item.dp_ManejaIva;
                        address.dp_Costeado = item.dp_Costeado;
                        address.dp_costo_promedio_hist = item.dp_costo_promedio_hist;
                        address.dp_peso = item.dp_peso;
                        address.dp_observacion = item.dp_observacion;

                        context.in_presupuesto_det.Add(address);
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

        public Boolean eliminarregistrotabla(List<in_presupuestoDetalle_Info> lmDetalleInfo, int IdEmpresa, int IdPresupuesto, ref string msg)
        {
            try
            {

                
                using (EntitiesInventario contex1 = new EntitiesInventario())
                {

                    foreach (var item in lmDetalleInfo)
                    {
                        var address = contex1.in_presupuesto_det.FirstOrDefault(A => A.IdEmpresa == IdEmpresa && A.IdSucursal == item.IdSucursal && A.IdPresupuesto == IdPresupuesto && A.Secuencia == item.Secuencia);
                        if (address != null)
                        {
                            contex1.in_presupuesto_det.Remove(address);
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

        public in_presupuestoDetalle_Data() { }
    }
}
