using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Facturacion
{
   public class fa_factura_x_formaPago_Data
    {
       string mensaje = "";
       
       public Boolean GuardarDB(List<fa_factura_x_formaPago_Info> Lista,ref string mensajeE)
       {
           try
           {
            
               foreach (fa_factura_x_formaPago_Info Info in Lista)
               {
                   using (EntitiesFacturacion Context = new EntitiesFacturacion())
                   {
                  
                       fa_factura_x_formaPago Address = new fa_factura_x_formaPago();

                       Address.IdEmpresa = Info.IdEmpresa;
                       Address.IdSucursal = Info.IdSucursal;
                       Address.IdBodega = Info.IdBodega;
                       Address.IdCbteVta = Info.IdCbteVta;                   
                       Address.IdFormaPago = Info.IdFormaPago;
                       Address.observacion = " ";
                                                                                
                            
                       Context.fa_factura_x_formaPago.Add(Address);
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
               mensaje = ex.ToString();
               mensajeE=mensaje ;
               throw new Exception(ex.ToString());
           }
       }

       public List<fa_factura_x_formaPago_Info> Get_List_fa_factura_x_formaPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
       {
           try
           {
               List<fa_factura_x_formaPago_Info> Lst = new List<fa_factura_x_formaPago_Info>();
               EntitiesFacturacion oEnti = new EntitiesFacturacion();
               var Query = from q in oEnti.fa_factura_x_formaPago
                           where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdCbteVta == IdCbteVta
                           select q;

               foreach (var item in Query)
               {
                   fa_factura_x_formaPago_Info Obj = new fa_factura_x_formaPago_Info();
                 
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdSucursal = item.IdSucursal;
                   Obj.IdBodega = item.IdBodega;
                   Obj.IdCbteVta = item.IdCbteVta;
                   Obj.IdFormaPago = item.IdFormaPago;
                   Obj.observacion = "";

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
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }

       public Boolean EliminarDB(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, ref string msg)
       {
           try
           {
               using (EntitiesCompras Entity = new EntitiesCompras())
               {
                   int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete fa_factura_x_formaPago where IdEmpresa = " + IdEmpresa
                       + " and IdSucursal = " + IdSucursal
                       + " and IdBodega = " + IdBodega
                       + " and IdCbteVta = " + IdCbteVta
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
