using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using Core.Erp.Data.General;




namespace Core.Erp.Data.Compras
{
   public  class com_dev_compra_det_Data
    {
       string mensaje = "";

       public com_dev_compra_det_Data()
       {

       }

       public Boolean GuardarDB(List<com_dev_compra_det_Info> LstInfo, ref string msg)
       {
           try
           {
               int sec = 0;

               foreach (var item in LstInfo)
               {
                   using (EntitiesCompras Context = new EntitiesCompras())
                   {

                       sec = sec + 1;

                       var Address = new com_dev_compra_det();

                       Address.IdEmpresa = item.IdEmpresa;
                       Address.IdSucursal = item.IdSucursal;
                       Address.IdDevCompra = item.IdDevCompra;
                       Address.IdBodega = item.IdBodega;

                        Address.Secuencia= sec;
                        Address.IdProducto = item.IdProducto;
                        Address.dv_Cantidad = item.dv_Cantidad;
                        Address.dv_precioCompra = item.dv_precioCompra;
                        Address.dv_porc_des = item.dv_porc_des;
                        Address.dv_descuento = item.dv_descuento;
                        Address.dv_subtotal = item.dv_subtotal;
                        Address.dv_iva = item.dv_iva;
                        Address.dv_total = item.dv_total;
                        Address.dv_ManejaIva = (item.dv_iva>0)? true:false;
                        Address.dv_Costeado = "N";
                        Address.dv_peso = item.dv_peso;
                        Address.dv_observacion = (item.dv_observacion == null) ? "" : item.dv_observacion;
                        Address.ocdet_IdEmpresa = item.ocdet_IdEmpresa;
                        Address.ocdet_IdSucursal = item.ocdet_IdSucursal;
                        Address.ocdet_IdOrdenCompra = item.ocdet_IdOrdenCompra;
                        Address.ocdet_Secuencia = item.ocdet_Secuencia;


                       Context.com_dev_compra_det.Add(Address);
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
       
       public Boolean ModificarDB(com_dev_compra_Info Info, ref  string msg)
       {
           try
           {
               using (EntitiesCompras context = new EntitiesCompras())
               {
                   var contact = context.com_dev_compra.FirstOrDefault(obj => obj.IdDevCompra == Info.IdDevCompra &&
                        obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);


                   if (contact != null)
                   {
                       contact.IdProveedor = Info.IdProveedor;
                       contact.Tipo = Info.Tipo;
                       contact.dv_fecha = Info.dv_fecha;
                       contact.dv_flete = Info.dv_flete;
                       contact.dv_observacion = Info.dv_observacion;
                       contact.Estado = Info.Estado;
                       contact.AfectaCosto = Info.AfectaCosto;
                       context.SaveChanges();
                       msg = "Se ha procedido a modificar el registro de Dev de Compra  #: " + Info.IdDevCompra.ToString() + " exitosamente";
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

       public Boolean AnularDB(com_dev_compra_Info Info, ref  string msg)
       {
           try
           {
               using (EntitiesCompras context = new EntitiesCompras())
               {
                   var contact = context.com_dev_compra.FirstOrDefault(obj => obj.IdDevCompra == Info.IdDevCompra &&
                        obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);

                   if (contact != null)
                   {
                       contact.Estado = "I";
                       contact.FechaHoraAnul = Info.FechaHoraAnul;
                       contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                       contact.MotivoAnulacion = Info.MotivoAnulacion;
                       contact.dv_observacion = Info.dv_observacion;
                       context.SaveChanges();

                       msg = "Se ha procedido a anular el registro de Orden Compra #: " + Info.IdDevCompra.ToString() + " exitosamente";
                   }
               }

               using (EntitiesCompras context = new EntitiesCompras())
               {
                   var contact = context.com_dev_compra_det.FirstOrDefault(obj => obj.IdDevCompra == Info.IdDevCompra &&
                        obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);

                   if (contact != null)
                   {
                       contact.ocdet_IdEmpresa = null;
                       contact.ocdet_IdSucursal = null;
                       contact.ocdet_IdOrdenCompra = null;
                       contact.ocdet_Secuencia = null;
                       context.SaveChanges();

                       msg = "Se ha procedido a anular el registro de Orden Compra #: " + Info.IdDevCompra.ToString() + " exitosamente";
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

       public List<com_dev_compra_det_Info> Get_List_dev_compra_det(int IdEmpresa, int IdSucursal, decimal IdDevCompra)
       {
       
           try
           {
               List<com_dev_compra_det_Info> Lst = new List<com_dev_compra_det_Info>();

               EntitiesCompras oEnti = new EntitiesCompras();

               var Query = from q in oEnti.vwcom_dev_compra_con_det
                           where q.IdEmpresa == IdEmpresa 
                           && q.IdSucursal == IdSucursal &&
                           q.IdDevCompra == IdDevCompra
                           select q;


               foreach (var item in Query)
               {

                   com_dev_compra_det_Info Obj = new com_dev_compra_det_Info();
                   
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdSucursal = item.IdSucursal;
                   Obj.IdDevCompra = item.IdDevCompra;
                   Obj.IdBodega = item.IdBodega;
                   Obj.Secuencia = item.Secuencia;
                   Obj.IdProducto = item.IdProducto;
                   Obj.dv_Cantidad = item.dv_Cantidad;
                   Obj.dv_precioCompra = item.dv_precioCompra;
                   Obj.dv_porc_des = item.dv_porc_des;
                   Obj.dv_descuento = item.dv_descuento;
                   Obj.dv_subtotal = item.dv_subtotal;
                   Obj.dv_iva = item.dv_iva;
                   Obj.dv_total = item.dv_total;
                   Obj.dv_ManejaIva = item.dv_ManejaIva;
                   Obj.dv_Costeado = item.dv_Costeado;
                   Obj.dv_peso = item.dv_peso;
                   Obj.dv_observacion = item.dv_observacion;
                   Obj.Esta_en_base = "S";
                   Obj.nom_producto = item.nom_producto;
                   Obj.cod_producto = item.cod_producto;

                   Obj.ocdet_IdEmpresa = item.ocdet_IdEmpresa;
                   Obj.ocdet_IdSucursal =item.ocdet_IdSucursal;
                   Obj.ocdet_IdOrdenCompra = item.ocdet_IdOrdenCompra;
                   Obj.ocdet_Secuencia = item.ocdet_Secuencia;
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

       public Boolean EliminarDB(int IdEmpresa, int IdSucursal,int IdBodega, decimal IdDev_Compra, ref string msg)
       {
           try
           {
               using (EntitiesCompras Entity = new EntitiesCompras())
               {
                   int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete com_dev_compra_det where IdEmpresa = " + IdEmpresa
                       + " and IdSucursal = " + IdSucursal
                       + " and IdBodega = " + IdBodega
                       + " and IdDevCompra = " + IdDev_Compra
                       );
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
    }
}
