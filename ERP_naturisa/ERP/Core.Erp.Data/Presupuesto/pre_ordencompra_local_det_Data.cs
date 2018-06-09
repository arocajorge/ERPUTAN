using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Presupuesto
{
   public class pre_ordencompra_local_det_Data
    {
       string mensaje = "";
       public Boolean GrabarDB(pre_ordencompra_local_det_Info Info)
       {
           try
           {
               List<pre_ordencompra_local_det_Info> Lst = new List<pre_ordencompra_local_det_Info>();
               using (EntitiesPresupuesto Context = new EntitiesPresupuesto())
               {
                   var Address = new pre_ordencompra_local_det();

                   Address.IdEmpresa = Info.IdEmpresa;
                   Address.IdSucursal = Info.IdSucursal;
                   Address.IdOrdenCompra = Info.IdOrdenCompra;
                   Address.Secuencia = Info.Secuencia;
                   Address.IdPedidoXPre = Info.IdPedidoXPre;
                   Address.Secuencia_reg_ped = Info.Secuencia_reg_ped;
                   Address.IdPresupuesto_pre = Info.IdPresupuesto_pre;
                   Address.IdAnio_pre = Info.IdAnio_pre;
                   Address.Secuencia_pre = Info.Secuencia_pre;
                   Address.Producto = Info.Producto;
                   Address.do_Cantidad = Info.do_Cantidad;
                   Address.do_precioCompra = Info.do_precioCompra;
                   Address.do_porc_des = Info.do_porc_des;
                   Address.do_descuento = Info.do_descuento;
                   Address.do_subtotal = Info.do_subtotal;
                   Address.do_iva = Info.do_iva;
                   Address.do_total = Info.do_total;
                   Address.do_ManejaIva = (Info.do_iva > 0.0) ? "S" : "N";
                   Address.do_observacion = (Info.do_observacion == null) ? "" : Info.do_observacion;
                   Address.do_NumDocumento = Info.do_NumDocumento;

                   Context.pre_ordencompra_local_det.Add(Address);
                   Context.SaveChanges();
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

       public Boolean GrabarLstDB(List<pre_ordencompra_local_det_Info> Lst)
       {
           try
           {
               int secu = 0;
               foreach (var item in Lst)
               {
                   secu = secu + 1;
                   item.Secuencia = secu;
                   GrabarDB(item);
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

       public List<pre_ordencompra_local_det_Info> ObtenerLst(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
       {
           try
           {
               string query="";
               List<pre_ordencompra_local_det_Info> Lst = new List<pre_ordencompra_local_det_Info>();
               EntitiesPresupuesto oEnti = new EntitiesPresupuesto();
               //var Query = from q in oEnti.pre_ordencompra_local_det
               //            where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdOrdenCompra == IdOrdenCompra
               //            select q;
               
               query = " SELECT a.IdEmpresa,a.IdSucursal,a.IdOrdenCompra,a.Secuencia,a.IdPedidoXPre,a.Secuencia_reg_ped,a.IdPresupuesto_pre,a.IdAnio_pre,a.Secuencia_pre,a.Producto,a.do_Cantidad,a.do_precioCompra,a.do_porc_des,a.do_descuento,a.do_subtotal,a.do_iva,a.do_total,a.do_ManejaIva,a.do_observacion,a.do_NumDocumento,b.NPresupuesto_pre   FROM pre_ordencompra_local_det as a  inner join vwpre_PedidoXPresupuesto_det as b on a.IdPresupuesto_pre=b.IdPresupuesto_pre and a.IdAnio_pre=b.IdAnio_pre and a.Secuencia_pre=b.Secuencia_pre  and  b.IdEmpresa=a.IdEmpresa where a.IdEmpresa =" + IdEmpresa + " and a.IdSucursal =" + IdSucursal + " and a.IdOrdenCompra =" + IdOrdenCompra + " group by a.IdEmpresa,a.IdSucursal,a.IdOrdenCompra,a.Secuencia,a.IdPedidoXPre,a.Secuencia_reg_ped,a.IdPresupuesto_pre,a.IdAnio_pre,a.Secuencia_pre,a.Producto,a.do_Cantidad,a.do_precioCompra,a.do_porc_des,a.do_descuento,a.do_subtotal,a.do_iva,a.do_total,a.do_ManejaIva,a.do_observacion,a.do_NumDocumento,b.NPresupuesto_pre   ";
               var Query = oEnti.Database.SqlQuery<pre_ordencompra_local_det_Info>(query).ToList();
               foreach (var item in Query)
               {
                   pre_ordencompra_local_det_Info Obj = new pre_ordencompra_local_det_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdSucursal = item.IdSucursal;
                   Obj.IdOrdenCompra = item.IdOrdenCompra;
                   Obj.Secuencia = item.Secuencia;
                   Obj.IdPedidoXPre = item.IdPedidoXPre;
                   Obj.Secuencia_reg_ped = item.Secuencia_reg_ped;
                   Obj.IdPresupuesto_pre = item.IdPresupuesto_pre;
                   Obj.IdAnio_pre = item.IdAnio_pre;
                   Obj.Secuencia_pre = item.Secuencia_pre;
                   Obj.Producto = item.Producto;
                   Obj.do_Cantidad = item.do_Cantidad;
                   Obj.do_precioCompra = item.do_precioCompra;
                   Obj.do_porc_des = item.do_porc_des;
                   Obj.do_descuento = item.do_descuento;
                   Obj.do_subtotal = item.do_subtotal;
                   Obj.do_iva = item.do_iva;
                   Obj.do_total = item.do_total;
                   Obj.do_ManejaIva = item.do_ManejaIva;
                   Obj.do_observacion = item.do_observacion;
                   Obj.NPresupuesto_pre = item.NPresupuesto_pre;
                   Obj.do_NumDocumento = item.do_NumDocumento;
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
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(pre_ordencompra_local_det_Info Info)
       {
           try
           {
               using (EntitiesPresupuesto context = new EntitiesPresupuesto())
               {
                   var Address = context.pre_ordencompra_local_det.FirstOrDefault(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdSucursal == Info.IdSucursal && minfo.IdOrdenCompra == Info.IdOrdenCompra && minfo.Secuencia==Info.Secuencia );
                   if (Address != null)
                   {
                       Address.do_NumDocumento = Info.do_NumDocumento;
                       Address.do_precioCompra = Info.do_precioCompra;
                       Address.do_porc_des = Info.do_porc_des;
                       Address.do_descuento = Info.do_descuento;
                       Address.do_subtotal = Info.do_subtotal;
                       Address.do_iva = Info.do_iva;
                       Address.do_total = Info.do_total;
                       Address.do_ManejaIva = (Info.do_iva > 0.0) ? "S" : "N";
                       Address.do_observacion = (Info.do_observacion == null) ? "" : Info.do_observacion;

                       context.SaveChanges();
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
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarLstDB(List<pre_ordencompra_local_det_Info> Lst)
       {
           try
           {
               foreach (var item in Lst)
               {
                   ModificarDB(item);
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
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString().ToString());
           }
       }


       public Boolean EliminarDB(pre_ordencompra_local_det_Info Info)
       {
           try
           {
               using (EntitiesPresupuesto context = new EntitiesPresupuesto())
               {
                   var contact = context.pre_ordencompra_local_det.FirstOrDefault(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdSucursal == Info.IdSucursal && minfo.IdOrdenCompra == Info.IdOrdenCompra && minfo.Secuencia == Info.Secuencia);
                   if (contact != null)
                   {
                       context.pre_ordencompra_local_det.Add(contact);
                       context.SaveChanges();
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
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean EliminarLstDB(List<pre_ordencompra_local_det_Info> Lst)
       {
           try
           {
               foreach (var item in Lst)
               {
                   EliminarDB(item);
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
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }


       public pre_ordencompra_local_det_Data()
       {
           
       }
    }
}
