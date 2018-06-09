using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Compras;

namespace Core.Erp.Data.Produc_Cirdesus
{
   public class prd_GenerOCompraDet_Data
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
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }




       public List<com_ListadoMateriales_Det_Info> ConsultaDetalleGODxDetListMateriales(int idempresa, decimal idlistadoMat, int iddetalle)
       {

           try
           {

               List<com_ListadoMateriales_Det_Info> Lst = new List<com_ListadoMateriales_Det_Info>();
               EntitiesCompras oEnti = new EntitiesCompras();

               var Query = from q in oEnti.vwcom_GenerOCompra_Det
                           where q.IdEmpresa == idempresa
                           && q.IdListadoMateriales == idlistadoMat
                           && q.IdDetalle == iddetalle
                           select q;
               foreach (var item in Query)
               {

                   com_ListadoMateriales_Det_Info Obj = new com_ListadoMateriales_Det_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdTransaccion = item.IdTransaccion;
                   Obj.IdDetTrans = item.IdDetTrans;
                   Obj.IdProveedor = (item.IdProveedor == null) ? -1 : (decimal)item.IdProveedor;
                   Obj.CodObra = item.CodObra;
                   Obj.obra = item.ob_descripcion;
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
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }

       }

       public List<com_ListadoMateriales_Det_Info> ConsultaDetalleGOD(int idempresa, decimal idtrans)
       {
           List<com_ListadoMateriales_Det_Info> Lst = new List<com_ListadoMateriales_Det_Info>();
           EntitiesCompras oEnti = new EntitiesCompras();
           try
           {
               var Query = from q in oEnti.vwcom_GenerOCompra_Det
                           where q.IdEmpresa == idempresa && q.IdTransaccion == idtrans
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
                   Obj.obra = item.ob_descripcion;
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
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }


       // aprobacion de Ordenes de Compras

       public Boolean ModificarDB(List<prd_GenerOCompra_Info> LstInfo)
       {
           try
           {
               int IdDetalleTransacion = 0;

               foreach (var item in LstInfo)
               {
                   IdDetalleTransacion = IdDetalleTransacion + 1;

                   using (EntitiesCompras Context = new EntitiesCompras())
                   {
                       var contact = Context.com_GenerOCompra_Det.FirstOrDefault(A => A.IdEmpresa == item.IdEmpresa && A.IdTransaccion == item.IdTransaccion && A.IdDetalle==item.IdDetalle && A.IdProducto==item.IdProducto && A.IdDetTrans ==item.IdDetTrans);
                       if (contact != null)
                       {
                           contact.IdEstadoAprob = item.IdEstadoAprob;
                           Context.SaveChanges();
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
               throw new Exception(ex.ToString());
           }
       }
    }
}
