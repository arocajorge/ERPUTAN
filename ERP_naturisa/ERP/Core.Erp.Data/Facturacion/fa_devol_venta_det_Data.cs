using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
   public class fa_devol_venta_det_Data
    {
       string mensaje = "";

       public Boolean GuardarDB(List<fa_devol_venta_det_Info> Lista, ref string msg)
       {
           try
           {
               using (EntitiesFacturacion Contex = new EntitiesFacturacion())
               {
                  
                   foreach (var item in Lista)
                   {
                       
                       var address = new fa_devol_venta_det();
                     
                       address.IdEmpresa = item.IdEmpresa;
                       address.IdSucursal = item.IdSucursal;
                       address.IdBodega = item.IdBodega;                    
                       address.IdDevolucion = Convert.ToDecimal(msg);
                       address.Secuencia = item.Secuencia;                    
                       address.IdProducto = item.IdProducto;
                       address.dv_cantidad = item.dv_cantidad;
                       address.dv_valor = item.dv_valor;
                       address.dv_PorDescUni = item.dv_PorDescUni;
                       address.dv_descUni = item.dv_descUni;
                       address.dv_PrecioFinal = item.dv_PrecioFinal;
                       address.dv_subtotal = item.dv_subtotal;
                       address.dv_iva = item.dv_iva;
                       address.dv_total = item.dv_total;
                       address.dv_costo = item.dv_costo;

                       Contex.fa_devol_venta_det.Add(address);
                       Contex.SaveChanges();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               msg = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
               throw new Exception(ex.ToString());
           }
       }

       public List<fa_devol_venta_det_Info> Get_List_devol_venta_det(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdDevolucion)
       {
           try
           {
               List<fa_devol_venta_det_Info> lista = new List<fa_devol_venta_det_Info>();

               EntitiesFacturacion oEnt = new EntitiesFacturacion();
               var select = from q in oEnt.fa_devol_venta_det
                            where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdDevolucion == IdDevolucion
                            select q;

               foreach (var item in select)
               {
                   fa_devol_venta_det_Info info = new fa_devol_venta_det_Info();
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdSucursal = item.IdSucursal;
                   info.IdBodega = item.IdBodega;

                   info.IdProducto = Convert.ToDecimal(item.IdProducto);
                   info.dv_cantidad = Convert.ToDouble(item.dv_cantidad);
                   info.dv_PrecioFinal = Convert.ToDouble(item.dv_PrecioFinal);
                   info.dv_PorDescUni = Convert.ToDouble(item.dv_PorDescUni);
                   info.dv_descUni = Convert.ToDouble(item.dv_descUni);
                   info.dv_subtotal = Convert.ToDouble(item.dv_subtotal);
                   info.Secuencia = (item.Secuencia);
                   info.dv_iva = Convert.ToDouble(item.dv_iva);
                   info.dv_total = Convert.ToDouble(item.dv_total);
                   lista.Add(info);
               }
               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(List<fa_devol_venta_det_Info> Lista, fa_devol_venta_Info info)
       {
           try
           {
                   List<fa_devol_venta_det_Info> listaAux = new List<fa_devol_venta_det_Info>();
                   listaAux = Get_List_devol_venta_det(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdDevolucion);

                   using (EntitiesFacturacion context = new EntitiesFacturacion())
                   {
                       foreach (var item in listaAux)
                       {
                           var contact = context.fa_devol_venta_det.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdDevolucion == info.IdDevolucion && cot.IdSucursal == info.IdSucursal && cot.IdBodega == info.IdBodega);
                           if (contact != null)
                           {
                               context.fa_devol_venta_det.Remove(contact);
                               context.SaveChanges();
                           }
                       }

                               foreach (var item in Lista)
                               {

                                   var address = new fa_devol_venta_det();
                                   address.IdEmpresa = item.IdEmpresa;
                                   address.IdSucursal = item.IdSucursal;
                                   address.IdBodega = item.IdBodega;
                                   address.IdDevolucion = info.IdDevolucion;
                                   address.Secuencia = item.Secuencia;
                                   address.IdProducto = item.IdProducto;
                                   address.dv_cantidad = item.dv_cantidad;
                                   address.dv_valor = item.dv_valor;
                                   address.dv_PorDescUni = item.dv_PorDescUni;
                                   address.dv_descUni = item.dv_descUni;
                                   address.dv_PrecioFinal = item.dv_PrecioFinal;
                                   address.dv_subtotal = item.dv_subtotal;
                                   address.dv_iva = item.dv_iva;
                                   address.dv_total = item.dv_total;
                                   address.dv_costo = item.dv_costo;
                                   context.fa_devol_venta_det.Add(address);
                                   context.SaveChanges();
                               }
                   }

               
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }
    
   }
}
