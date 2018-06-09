using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
   public class in_Ingreso_x_OrdenCompra_Data
    {

       string mensaje = "";


       public List<in_Ingreso_x_OrdenCompra_Info> Get_List_Ingreso_x_OrdenCompra(int IdEmpresa, int IdSucursal, int IdBodega, DateTime FechaIni, DateTime FechaFin)
       {
           List<in_Ingreso_x_OrdenCompra_Info> Lst = new List<in_Ingreso_x_OrdenCompra_Info>();
           try
           {
               //FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               //FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
               //EntitiesInventario oEnti = new EntitiesInventario();

               //if (IdSucursal==0)
               //{

               //    var Query = from q in oEnti.vwin_Ingreso_x_OrdenCompra
               //                where q.IdEmpresa == IdEmpresa
                         
               //                select q;

               //    foreach (var item in Query)
               //    {
               //        in_Ingreso_x_OrdenCompra_Info Obj = new in_Ingreso_x_OrdenCompra_Info();

               //        Obj.IdEmpresa = item.IdEmpresa;
               //        Obj.IdIngreso_x_oc = item.IdIngreso_x_oc;
               //        Obj.IdSucursal = item.IdSucursal;
               //        Obj.IdBodega = item.IdBodega;
               //        Obj.codigo = item.codigo;
               //        Obj.Referencia = item.Referencia;
               //        Obj.Fecha_ing_bod = item.Fecha_ing_bod;
               //        Obj.IdProveedor = item.IdProveedor;
               //        Obj.IdMotivo = item.IdMotivo;
               //        Obj.Observacion = item.Observacion;
               //        Obj.Tipo_local_ext = item.Tipo_local_ext;
               //        Obj.IdEmpresa_mIinv = Convert.ToInt32(item.IdEmpresa_mIinv);
               //        Obj.IdSucursal_mInv = Convert.ToInt32(item.IdSucursal_mInv);
               //        Obj.IdBodega_mInv = Convert.ToInt32(item.IdBodega_mInv);
               //        Obj.IdMovi_inven_tipo_mInv = Convert.ToInt32(item.IdMovi_inven_tipo_mInv);
               //        Obj.IdNumMovi_mInv = Convert.ToDecimal(item.IdNumMovi_mInv);
               //        Obj.Estado = item.Estado;

               //        Obj.nom_bodega = item.nom_bodega;
               //        Obj.nom_sucursal = item.nom_sucursal;
               //        Obj.nom_proveedor = item.nom_proveedor;
               //        Obj.nom_motivo = item.nom_motivo;

               //        Obj.tm_descripcion = item.tm_descripcion;

               //        Lst.Add(Obj);
               //    }
               
               //}
               //else
               //{

               //    var Query = from q in oEnti.vwin_Ingreso_x_OrdenCompra
               //                where q.IdEmpresa == IdEmpresa
               //                && q.IdSucursal == IdSucursal
               //                && q.IdBodega == IdBodega
               //                  && q.Fecha_ing_bod >= FechaIni
               //                  && q.Fecha_ing_bod <= FechaFin
               //                select q;
               //    foreach (var item in Query)
               //    {
               //        in_Ingreso_x_OrdenCompra_Info Obj = new in_Ingreso_x_OrdenCompra_Info();

               //        Obj.IdEmpresa = item.IdEmpresa;
               //        Obj.IdIngreso_x_oc = item.IdIngreso_x_oc;
               //        Obj.IdSucursal = item.IdSucursal;
               //        Obj.IdBodega = item.IdBodega;
               //        Obj.codigo = item.codigo;
               //        Obj.Referencia = item.Referencia;
               //        Obj.Fecha_ing_bod = item.Fecha_ing_bod;
               //        Obj.IdProveedor = item.IdProveedor;
               //        Obj.IdMotivo = item.IdMotivo;
               //        Obj.Observacion = item.Observacion;
               //        Obj.Tipo_local_ext = item.Tipo_local_ext;
               //        Obj.IdEmpresa_mIinv = Convert.ToInt32(item.IdEmpresa_mIinv);
               //        Obj.IdSucursal_mInv = Convert.ToInt32(item.IdSucursal_mInv);
               //        Obj.IdBodega_mInv = Convert.ToInt32(item.IdBodega_mInv);
               //        Obj.IdMovi_inven_tipo_mInv = Convert.ToInt32(item.IdMovi_inven_tipo_mInv);
               //        Obj.IdNumMovi_mInv = Convert.ToDecimal(item.IdNumMovi_mInv);
               //        Obj.Estado = item.Estado;

               //        Obj.nom_bodega = item.nom_bodega;
               //        Obj.nom_sucursal = item.nom_sucursal;
               //        Obj.nom_proveedor = item.nom_proveedor;
               //        Obj.nom_motivo = item.nom_motivo;
               //        Obj.tm_descripcion = item.tm_descripcion;

               //        Lst.Add(Obj);
               //    }
               
               //}
              
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


       public in_Ingreso_x_OrdenCompra_Info Get_Info_Ingreso_x_OrdenCompra(int IdEmpresa, decimal IdIngreso_x_oc)
       {
           in_Ingreso_x_OrdenCompra_Info Obj = new in_Ingreso_x_OrdenCompra_Info();
           try
           {
              
               //EntitiesInventario oEnti = new EntitiesInventario();
               //var Query = from q in oEnti.vwin_Ingreso_x_OrdenCompra
               //            where q.IdEmpresa == IdEmpresa
                          
               //            && q.IdIngreso_x_oc == IdIngreso_x_oc
                           
               //            select q;
               //foreach (var item in Query)
               //{
                   

               //    Obj.IdEmpresa = item.IdEmpresa;
               //    Obj.IdIngreso_x_oc = item.IdIngreso_x_oc;
               //    Obj.IdSucursal = item.IdSucursal;
               //    Obj.IdBodega = item.IdBodega;
               //    Obj.codigo = item.codigo;
               //    Obj.Referencia = item.Referencia;
               //    Obj.Fecha_ing_bod = item.Fecha_ing_bod;
               //    Obj.IdProveedor = item.IdProveedor;
               //    Obj.IdMotivo = item.IdMotivo;
               //    Obj.Observacion = item.Observacion;
               //    Obj.Tipo_local_ext = item.Tipo_local_ext;
               //    Obj.IdEmpresa_mIinv = Convert.ToInt32(item.IdEmpresa_mIinv);
               //    Obj.IdSucursal_mInv = Convert.ToInt32(item.IdSucursal_mInv);
               //    Obj.IdBodega_mInv = Convert.ToInt32(item.IdBodega_mInv);
               //    Obj.IdMovi_inven_tipo_mInv = Convert.ToInt32(item.IdMovi_inven_tipo_mInv);
               //    Obj.IdNumMovi_mInv = Convert.ToDecimal(item.IdNumMovi_mInv);
               //    Obj.Estado = item.Estado;

               //    Obj.nom_bodega = item.nom_bodega;
               //    Obj.nom_sucursal = item.nom_sucursal;
               //    Obj.nom_proveedor = item.nom_proveedor;
               //    Obj.nom_motivo = item.nom_motivo;

               //    Obj.tm_descripcion = item.tm_descripcion;

               //   // Lst.Add(Obj);
               //}
               return Obj;
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
