using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Produc_Cirdesus;
namespace Core.Erp.Data.Compras
{
    public class com_GenerOCompraDet_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(List<prd_GenerOCompra_Info> LstInfo)
        {
            try
            {
                int IdDetalleTransacion = 0;
                
                foreach (var item in LstInfo)
                {
                    IdDetalleTransacion = IdDetalleTransacion + 1;

                    using (EntitiesCompras Context = new EntitiesCompras())
                    {
                        var Address = new com_GenerOCompra_Det();
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdTransaccion = item.IdTransaccion;
                        Address.IdProveedor = (item.IdProveedor == 0 || item.IdProveedor == null) ? null : item.IdProveedor;
                        Address.CodObra = item.CodObra;
                        Address.IdOrdenTaller = item.IdOrdenTaller;
                        Address.Motivo = item.Motivo;
                        Address.IdProducto = item.IdProducto;
                        Address.Cantidad = item.Cantidad;
                        Address.Kg = item.Kg;
                        Address.precio = item.precio;
                        Address.FechaRequer = item.FechaRequer;
                        Address.IdEstadoAprob = item.IdEstadoAprob;
                        Address.IdDetalle = item.IdDetalle;
                        Address.IdListadoMateriales = item.IdListadoMateriales;
                        Address.oc_IdEmpresa = item.oc_IdEmpresa;
                        Address.oc_IdOrdenCompra = item.oc_IdOrdenCompra;
                        Address.usuariosolicitante = item.usuariosolicitante;
                        Address.IdDetTrans = IdDetalleTransacion;
                        Context.com_GenerOCompra_Det.Add(Address);
                        Context.SaveChanges();

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString()); 
            }
        }

        public List<com_ListadoMateriales_Det_Info> Get_List_ListadoMateriales_Det(int IdEmpresa, decimal IdListadoMat, int IdDetalle)
        {
               
            try
            {

                List<com_ListadoMateriales_Det_Info> Lst = new List<com_ListadoMateriales_Det_Info>();
                EntitiesCompras oEnti = new EntitiesCompras();

                var Query = from q in oEnti.vwcom_GenerOCompra_Det
                            where q.IdEmpresa == IdEmpresa 
                            && q.IdListadoMateriales  == IdListadoMat 
                            && q.IdDetalle == IdDetalle 
                            select q;
                foreach (var item in Query)
                {
                    com_ListadoMateriales_Det_Info Obj = new com_ListadoMateriales_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdTransaccion = item.IdTransaccion;
                    Obj.IdDetTrans = item.IdDetTrans;
                    Obj.IdProveedor = (item.IdProveedor == null)? -1:(decimal)item.IdProveedor;
                    Obj.CodObra = item.CodObra;
                    Obj.obra =  item.ob_descripcion;
                    Obj.IdOrdenTaller = item.IdOrdenTaller;
                    Obj.Motivo = item.Motivo;
                    Obj.IdProducto = item.IdProducto;
                    Obj.Unidades = item.Cantidad;
                    Obj.Det_Kg = item.Kg;
                    Obj.go_IdEstadoAprob = item.IdEstadoAprob;
                    Obj.mr_codigo = item.mr_codigo;
                    Obj.mr_descripcion = item.mr_descripcion;
                    Obj.ea_codigo = item.ea_codigo;
                    Obj.ea_descripcion = item.ea_descripcion;
                    Obj.ot_codigo = item.ot_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.ob_descripcion = item.ob_descripcion;
                    Obj.prov_descripcion = item.prov_descripcion;
                    Obj.FechaRequer = item.FechaRequer;
                    Obj.IdListadoMateriales = (decimal)item.IdListadoMateriales;
                    Obj.IdDetalle = (int)item.IdDetalle;
                    Obj.IdOrdencompra = item.oc_IdOrdenCompra;
                    Obj.oc_idempresa = item.oc_IdEmpresa;
                    Obj.producto = item.pr_descripcion + "[" + item.pr_codigo + "/" + item.IdProducto + "] ";
                    Obj.solicitante = item.usuariosolicitante;
                    Obj.precio = (double)item.precio;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ListadoMateriales_Det_Info> Get_List_ListadoMateriales_Det(int IdEmpresa, decimal IdTrans)
        {
                List<com_ListadoMateriales_Det_Info> Lst = new List<com_ListadoMateriales_Det_Info>();
                EntitiesCompras oEnti = new EntitiesCompras();
            try
            {
                var Query = from q in oEnti.vwcom_GenerOCompra_Det
                            where q.IdEmpresa == IdEmpresa && q.IdTransaccion == IdTrans 
                            select q;
                foreach (var item in Query)
                {
                    com_ListadoMateriales_Det_Info Obj = new com_ListadoMateriales_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdTransaccion = item.IdTransaccion;
                    Obj.IdDetTrans = item.IdDetTrans;
                    Obj.IdProveedor = (item.IdProveedor == null) ? -1 : (decimal)item.IdProveedor;
                    Obj.CodObra = item.CodObra;
                    Obj.IdListadoMateriales = (decimal)item.IdListadoMateriales;
                    Obj.IdDetalle = (int)item.IdDetalle;
                    Obj.obra =  item.ob_descripcion;
                    Obj.IdOrdenTaller = item.IdOrdenTaller;
                    Obj.Motivo = item.Motivo;
                    Obj.IdProducto = item.IdProducto;
                    Obj.Unidades = item.Cantidad;
                    Obj.Det_Kg = item.Kg;
                    Obj.go_IdEstadoAprob = item.IdEstadoAprob;
                    Obj.mr_codigo = item.mr_codigo;
                    Obj.mr_descripcion = item.mr_descripcion;
                    Obj.ea_codigo = item.ea_codigo;
                    Obj.ea_descripcion = item.ea_descripcion;
                    Obj.ot_codigo = item.ot_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.ob_descripcion = item.ob_descripcion;
                    Obj.prov_descripcion = item.prov_descripcion;
                    Obj.FechaRequer = item.FechaRequer;
                    Obj.IdOrdencompra = item.oc_IdOrdenCompra;
                    Obj.oc_idempresa = item.oc_IdEmpresa;
                    Obj.producto = item.pr_descripcion + "[" + item.pr_codigo + "/" + item.IdProducto + "] ";
                    Obj.solicitante = item.usuariosolicitante;
                    Obj.precio = (double)item.precio;

                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(List<com_GenerOCompraDet_Info> LstInfo, ref string msg)
        {
            try
            {

                using (EntitiesCompras context = new EntitiesCompras())
                {
                    foreach (var item in LstInfo)
                    {
                        var address = context.com_GenerOCompra_Det.FirstOrDefault
                            (A => A.IdEmpresa == item.IdEmpresa &&
                                A.IdDetTrans == item.IdDetTrans);

                        if (address != null)
                        {
                            context.com_GenerOCompra_Det.Remove(address);
                            context.SaveChanges();
                        }
                    }
                }
                msg = "Guardado con exito";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;

                msg = "Error no se guardó " + ex.Message + " ";
                throw new Exception(ex.ToString());
            }
        }

        public com_ListadoMateriales_Det_Info Get_Info_ListadoMateriales_Det(int IdEmpresa, decimal IdTransacion, int IdDetTrans)
        {
                com_ListadoMateriales_Det_Info obj = new com_ListadoMateriales_Det_Info();
                EntitiesCompras oEnti = new EntitiesCompras();
            try
            {
                var det = oEnti.com_GenerOCompra_Det.FirstOrDefault(
                    var => var.IdEmpresa == IdEmpresa
                        && var.IdTransaccion == IdTransacion
                        && var.IdDetTrans == IdDetTrans);

                if (det != null)
                {
                    obj.IdEmpresa = det.IdEmpresa;
                    obj.IdTransaccion = det.IdTransaccion;
                    obj.IdDetTrans = det.IdDetTrans;
                    obj.IdProveedor = Convert.ToDecimal(det.IdProveedor);
                    obj.CodObra = det.CodObra;
                    obj.IdOrdenTaller = det.IdOrdenTaller;
                    obj.Motivo = det.Motivo;
                    obj.IdProducto = det.IdProducto;
                    obj.Unidades = det.Cantidad;
                    obj.Det_Kg = det.Kg;
                    obj.go_IdEstadoAprob = det.IdEstadoAprob;
                    obj.FechaRequer = det.FechaRequer;
                    obj.IdListadoMateriales = Convert.ToDecimal(det.IdListadoMateriales);
                    obj.IdDetalle = Convert.ToInt32(det.IdDetalle);
                    obj.precio = Convert.ToDouble(det.precio);
                    obj.oc_idempresa = det.oc_IdEmpresa;
                    obj.IdOrdencompra = det.oc_IdOrdenCompra;
                    obj.solicitante = det.usuariosolicitante;
                }
                return obj;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarEstadoGOCDet(com_ListadoMateriales_Det_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_GenerOCompra_Det.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa

                        && obj.IdTransaccion == Info.IdTransaccion && obj.IdDetTrans == Info.IdDetTrans);

                    if (contact != null)
                    {
                        contact.IdEstadoAprob = Info.go_IdEstadoAprob;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar la Generación de O/C #: " + Info.IdTransaccion.ToString() + " exitosamente.";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
       
        
    }
}
