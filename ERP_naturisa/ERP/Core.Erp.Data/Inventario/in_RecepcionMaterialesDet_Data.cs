using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.Inventario
{
    public class in_RecepcionMaterialesDet_Data
    {
        string mensaje = "";

        public List<in_RecepcionMaterialesDet_Info> Get_List_RecepcionMaterialesDet(int idempresa, int idsucursal, decimal IdRecepcionMaterial)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                List<in_RecepcionMaterialesDet_Info> lM = new List<in_RecepcionMaterialesDet_Info>();
                var select = from C in OEInventario.in_recepcion_material_det
                             where C.IdEmpresa == idempresa 
                             && C.IdSucursal == idsucursal 
                             && C.IdRecepcionMaterial == IdRecepcionMaterial
                             orderby C.Secuencia ascending
                             select C;

                foreach (var item in select)
                {
                    in_RecepcionMaterialesDet_Info info = new in_RecepcionMaterialesDet_Info();
                    info.IdEmpresa = idempresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdRecepcionMaterial = item.IdRecepcionMaterial;
                    info.IdOrdenCompra = item.IdOrdenCompra;
                    info.IdProducto = item.IdProducto;
                    info.do_Cantidad = item.do_Cantidad;
                    info.re_CantRecibida = item.re_CantRecibida;
                    info.re_Saldo = item.re_Saldo;
                    info.Secuencia = item.Secuencia;

                    //info.pr_codigo = item.pr_codigo;
                    //info.pr_descripcion = item.pr_descripcion;

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

        public List<in_RecepcionMaterialesDet_Info> Get_List_RecepcionMaterialesDet_x_OC(int idempresa, int idsucursal, decimal IdOC)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                List<in_RecepcionMaterialesDet_Info> lM = new List<in_RecepcionMaterialesDet_Info>();
                var select = from C in OEInventario.in_recepcion_material_det
                             where C.IdEmpresa == idempresa 
                             && C.IdSucursal == idsucursal 
                             && C.IdOrdenCompra == IdOC
                             orderby C.Secuencia ascending
                             select C;

                foreach (var item in select)
                {
                    in_RecepcionMaterialesDet_Info info = new in_RecepcionMaterialesDet_Info();
                    info.IdEmpresa = idempresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdRecepcionMaterial = item.IdRecepcionMaterial;
                    info.IdOrdenCompra = item.IdOrdenCompra;
                    info.IdProducto = item.IdProducto;
                    info.do_Cantidad = item.do_Cantidad;
                    info.re_CantRecibida = item.re_CantRecibida;
                    info.re_Saldo = item.re_Saldo;
                    info.Secuencia = item.Secuencia;

                    //info.pr_codigo = item.pr_codigo;
                    //info.pr_descripcion = item.pr_descripcion;

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

        public Boolean GrabarDB(List<in_RecepcionMaterialesDet_Info> lmDetalleInfo, int idempresa, decimal IdRecepcionMaterial, ref string msgd)
        {
            try
            {

                using (EntitiesInventario context = new EntitiesInventario())
                {
                    foreach (var item in lmDetalleInfo)
                    {
                        var address = new in_recepcion_material_det();

                        address.IdEmpresa = idempresa;
                        address.IdSucursal = item.IdSucursal;
                        address.IdRecepcionMaterial = IdRecepcionMaterial;
                        address.Secuencia = item.Secuencia;
                        address.IdProducto = item.IdProducto;
                        address.do_Cantidad = item.do_Cantidad;
                        address.IdOrdenCompra = item.IdOrdenCompra;
                        address.Secuencia = item.Secuencia;
                        address.re_CantRecibida = item.re_CantRecibida;
                        address.re_Saldo = item.re_Saldo;

                        context.in_recepcion_material_det.Add(address);
                        context.SaveChanges();
                    }
                    context.Dispose();

                }
                msgd = "Guardado con exito";
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

        public Boolean EliminarDB(List<in_RecepcionMaterialesDet_Info> lmDetalleInfo, int idempresa, decimal IdRecepcionMaterial, ref string msg)
        {
            try
            {
                using (EntitiesInventario contex1 = new EntitiesInventario())
                {
                    foreach (var item in lmDetalleInfo)
                    {
                        var address = contex1.in_recepcion_material_det.FirstOrDefault(A => A.IdEmpresa == idempresa && A.IdRecepcionMaterial == IdRecepcionMaterial && A.Secuencia == item.Secuencia);
                        if (address != null)
                        {
                            //contac1 = address;
                            contex1.in_recepcion_material_det.Remove(address);
                            contex1.SaveChanges();
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Error no se guardó " + ex.Message + " ";
                throw new Exception(mensaje);
            }
        }

        public in_RecepcionMaterialesDet_Data() { }
    }
}
