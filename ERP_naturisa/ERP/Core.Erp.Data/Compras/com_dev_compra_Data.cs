using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;

using Core.Erp.Data.General;

namespace Core.Erp.Data.Compras
{
   public class com_dev_compra_Data
    {
       string mensaje = "";

       public com_dev_compra_Data()
       {       }

       public List<com_dev_compra_Info> Get_List_dev_compra(int IdEmpresa, int IdSucursal, DateTime fechaIni, DateTime fechaFin)
       {
           try
           {

               List<com_dev_compra_Info> lista = new List<com_dev_compra_Info>();
               com_dev_compra_Info oItem = new com_dev_compra_Info();
           

               EntitiesCompras oEnti = new EntitiesCompras();


               var Query = from q in oEnti.vwcom_dev_compra
                           where q.IdEmpresa == IdEmpresa
                           && q.IdSucursal == IdSucursal
                           && q.dv_fecha >= fechaIni && q.dv_fecha <= fechaFin
                           select q;


               foreach (var item in Query)
               {

                       oItem = new com_dev_compra_Info();
                       oItem.IdEmpresa = item.IdEmpresa;
                       oItem.IdSucursal = item.IdSucursal;
                       oItem.IdBodega = item.IdBodega;
                       oItem.IdDevCompra = item.IdDevCompra;
                       oItem.IdProveedor = item.IdProveedor;
                       oItem.Tipo = item.Tipo;
                       oItem.dv_fecha = item.dv_fecha;
                       oItem.dv_flete = item.dv_flete;
                       oItem.dv_observacion = item.dv_observacion;
                       oItem.Estado = item.Estado;
                       oItem.nom_sucursal = item.nom_sucursal;
                       oItem.nom_Proveedor = item.nom_proveedor;
                       oItem.nom_bodega = item.nom_bodega;
                       oItem.cod_proveedor = item.cod_proveedor;

                       lista.Add(oItem);
               }
               return lista;
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

       public com_dev_compra_Info Get_Info_dev_compra(int IdEmpresa, int IdSucursal, decimal IdDevCompra)
       {
           try
           {
               int CCabecera = 1;

               com_dev_compra_Info oItem = new com_dev_compra_Info();
               com_dev_compra_det_Info oItem_det = new com_dev_compra_det_Info();
               EntitiesCompras oEnti = new EntitiesCompras();

               var Query = from q in oEnti.vwcom_dev_compra_con_det
                           where q.IdEmpresa == IdEmpresa
                           && q.IdSucursal == IdSucursal
                           && q.IdDevCompra == IdDevCompra
                           select q;

               foreach (var item in Query)
               {

                   oItem = new com_dev_compra_Info();
                   oItem_det = new com_dev_compra_det_Info();

                   if (CCabecera == 1)
                   {
                       oItem.IdEmpresa = item.IdEmpresa;
                       oItem.IdSucursal = item.IdSucursal;
                       oItem.IdBodega = item.IdBodega;
                       oItem.IdDevCompra = item.IdDevCompra;
                       oItem.IdProveedor = item.IdProveedor;
                       oItem.Tipo = item.Tipo;
                       oItem.dv_fecha = item.dv_fecha;
                       oItem.dv_flete = item.dv_flete;
                       oItem.dv_observacion = item.dv_observacion;
                       oItem.Estado = item.Estado;
                       oItem.nom_bodega = item.nom_bodega;
                       oItem.nom_Proveedor = item.nom_proveedor;
                       oItem.nom_sucursal = item.nom_sucursal;
                       oItem.cod_proveedor = item.cod_proveedor;

                       CCabecera = CCabecera + 1;
                   }

                   oItem_det.IdEmpresa = item.IdEmpresa;
                   oItem_det.IdSucursal = item.IdSucursal;
                   oItem_det.IdBodega = item.IdBodega;
                   oItem_det.IdDevCompra = item.IdDevCompra;
                   oItem_det.Secuencia = item.Secuencia;
                   oItem_det.IdProducto = item.IdProducto;
                   oItem_det.dv_Cantidad = item.dv_Cantidad;
                   oItem_det.dv_precioCompra = item.dv_precioCompra;
                   oItem_det.dv_porc_des = item.dv_porc_des;
                   oItem_det.dv_descuento = item.dv_descuento;
                   oItem_det.dv_subtotal = item.dv_subtotal;
                   oItem_det.dv_iva = item.dv_iva;
                   oItem_det.dv_total = item.dv_total;
                   oItem_det.dv_ManejaIva = item.dv_ManejaIva;
                   oItem_det.dv_Costeado = item.dv_Costeado;
                   oItem_det.dv_peso = item.dv_peso;
                   oItem_det.dv_observacion = item.dvt_observacion;
                   oItem_det.nom_producto = item.nom_producto;
                   oItem_det.cod_producto = item.cod_producto;

                    oItem.lista_detalle.Add(oItem_det);
               }
               return oItem;
           }
           catch (Exception ex)
           {
           
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean GuardarDB(com_dev_compra_Info  Info, ref decimal id,ref string mensaje1 )
       {
           try
           {
               decimal idoc = 0;

               using (EntitiesCompras Context = new EntitiesCompras())
               {
                   var Address = new com_dev_compra();
                   idoc = GetId(Info.IdEmpresa, Info.IdSucursal);
                   id = idoc;

                   Info.IdDevCompra = idoc;
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdBodega = Info.IdBodega;
                    Address.IdDevCompra = Info.IdDevCompra;
                    Address.IdProveedor = Info.IdProveedor;
                    Address.Tipo = (Info.Tipo == null) ? "LOCAL" : Info.Tipo;
                    Address.dv_fecha = Info.dv_fecha;
                    Address.dv_flete = Info.dv_flete;
                    Address.dv_observacion = Info.dv_observacion;
                    Address.Estado = (Info.Estado == null) ? "A" : Info.Estado; 
                   
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    Address.Fecha_UltMod = Info.Fecha_UltMod;
                    Address.IdUsuarioUltMod = Info.IdUsuarioUltMod;

                    Address.FechaHoraAnul = Info.Fecha_Transac;
                    Address.IdUsuarioUltAnu = Info.IdUsuarioUltMod;

                    Address.AfectaCosto = (Info.AfectaCosto == null) ? "N" : Info.AfectaCosto; 
                    Address.MotivoAnulacion = Info.MotivoAnulacion;
                    Context.com_dev_compra.Add(Address);
                    Context.SaveChanges();
               }
               foreach (var item in Info.lista_detalle)
               {
                   item.IdDevCompra = idoc;
                   item.IdEmpresa = Info.IdEmpresa;
                   item.IdSucursal = Info.IdSucursal;
                   item.IdBodega = Info.IdBodega;
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
                       contact.Tipo = (Info.Tipo == null) ? "LOCAL" : Info.Tipo;
                       contact.dv_fecha = Info.dv_fecha;
                       contact.dv_flete = Info.dv_flete;
                       contact.dv_observacion = Info.dv_observacion;
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

       public decimal GetId(int IdEmpresa, int idsucursal)
       {
           try
           {
               int Id;
               EntitiesCompras OECompras = new EntitiesCompras();
               var select = from q in OECompras.com_dev_compra
                            where q.IdEmpresa == IdEmpresa &&
                                    q.IdSucursal == idsucursal
                            select q;

               if (select.ToList().Count < 1)
               {
                   Id = 1;
               }
               else
               {
                   var select_pv = (from q in OECompras.com_dev_compra
                                    where q.IdEmpresa == IdEmpresa &&
                                        q.IdSucursal == idsucursal
                                    select q.IdDevCompra).Max();
                   Id = Convert.ToInt32(select_pv.ToString()) + 1;
                   Id = (Id == 0) ? 1 : Id;
               }
               return Id;
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
    }
}
