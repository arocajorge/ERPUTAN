using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Importacion
{
   public class imp_ordencompra_ext_det_Data
    {
       string mensaje ="";
       public Boolean GuardarDB(List<imp_ordencompra_ext_det_Info> lstInfo) 
       {
           try
           {
               int c = 1;
               foreach (var item in lstInfo)
               {
                   using (EntitiesImportacion Context = new EntitiesImportacion())
                   {
                       var address = new imp_ordencompra_ext_det();
                       address.IdEmpresa = item.IdEmpresa;
                       address.IdSucursal = item.IdSucursal;
                       address.IdOrdenCompraExt = item.IdOrdenCompraExt;
                       address.Secuencia = c;
                       c++;
                       address.IdProducto = item.IdProducto;
                       address.di_cantidad = item.di_cantidad;
                       address.di_costo = item.di_costo;
                       address.di_pordesc = item.di_pordesc;
                       address.di_desc = item.di_desc;
                       address.di_subtotal = item.di_subtotal;
                       address.di_costoPromedio = item.di_costoPromedio;
                       address.di_cambio = item.di_cambio;
                       address.di_prec_cam = item.di_prec_cam;
                       address.IdCategoria = item.IdCategoria;
                       Context.imp_ordencompra_ext_det.Add(address);
                       Context.SaveChanges();
                       Context.Dispose();                  
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
       public List<imp_ordencompra_ext_det_Info> Get_List_ordencompra_ext_det(imp_ordencompra_ext_Info Info) 
       {
               List<imp_ordencompra_ext_det_Info> Lst = new List<imp_ordencompra_ext_det_Info>();
           try
           {
               EntitiesImportacion oEnti = new EntitiesImportacion();

               var Detalle = from q in oEnti.imp_ordencompra_ext_det
                             where q.IdEmpresa == Info.IdEmpresa && q.IdSucursal == Info.IdSucusal &&
                             q.IdOrdenCompraExt == Info.IdOrdenCompraExt
                             select q;

               foreach (var item in Detalle)
               {
                   imp_ordencompra_ext_det_Info Aux = new imp_ordencompra_ext_det_Info();

                   Aux.IdEmpresa = item.IdEmpresa;
                   Aux.IdSucursal = item.IdSucursal;
                   Aux.IdOrdenCompraExt = item.IdOrdenCompraExt;
                   Aux.Secuencia = item.Secuencia;
                   Aux.IdProducto = (decimal)item.IdProducto;
                   Aux.di_cantidad = (double)item.di_cantidad;
                   Aux.di_costo = (double)item.di_costo;
                   Aux.di_pordesc = (double)item.di_pordesc;
                   Aux.di_desc = (double)item.di_desc;
                   Aux.di_subtotal = (double)item.di_subtotal;
                   Aux.di_costoPromedio = (double)item.di_costoPromedio;
                   Aux.di_cambio = (double)item.di_cambio;
                   Aux.di_prec_cam = (double)item.di_prec_cam;

                   Lst.Add(Aux);
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

       public Boolean EliminarDB(imp_ordencompra_ext_Info Info) 
       {
           try
           {
               List<imp_ordencompra_ext_det_Info> ListaEliminar = new List<imp_ordencompra_ext_det_Info>();

               ListaEliminar = Get_List_ordencompra_ext_det(Info);

               foreach (var item in ListaEliminar)
               {
                   using (EntitiesImportacion context = new EntitiesImportacion())
                   {
                       var contact = context.imp_ordencompra_ext_det.FirstOrDefault(obj => obj.IdEmpresa == item.IdEmpresa && obj.IdSucursal == item.IdSucursal && obj.IdOrdenCompraExt == item.IdOrdenCompraExt && obj.Secuencia == item.Secuencia);
                       if (contact != null)
                       {
                           context.imp_ordencompra_ext_det.Remove(contact);
                           context.SaveChanges();
                           context.Dispose();
                       }
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
    }
}
