using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Facturacion;


namespace Core.Erp.Data.Facturacion
{
   public class fa_factura_x_fa_cotizacion_Data
    {
       string mensaje = "";

       public fa_factura_x_fa_cotizacion_info Get_Info_fa_factura_x_fa_cotizacion(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
       {
           try
           {
               fa_factura_x_fa_cotizacion_info obj = new fa_factura_x_fa_cotizacion_info();
               EntitiesFacturacion OEFAC = new EntitiesFacturacion();

               var ent = OEFAC.fa_factura_x_fa_cotizacion.FirstOrDefault(var => var.fa_IdEmpresa == IdEmpresa
                   && var.fa_IdSucursal == IdSucursal && var.fa_IdBodega == IdBodega && var.fa_IdCbteVta == IdCbteVta);
               if (ent != null)
               {
                   obj.fa_IdEmpresa = ent.fa_IdEmpresa;
                   obj.fa_IdSucursal = ent.fa_IdSucursal;
                   obj.fa_IdBodega = ent.fa_IdBodega;
                   obj.fa_IdCbteVta = ent.fa_IdCbteVta;
                   obj.cc_IdEmpresa = ent.cc_IdEmpresa;
                   obj.cc_IdSucursal = ent.cc_IdSucursal;
                   obj.cc_IdBodega = ent.cc_IdBodega;
                   obj.cc_IdCotizacion = ent.cc_IdCotizacion;
                   obj.Observacion = ent.Observacion;
               }
               return obj;
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

       public Boolean GuardarFacxCot(fa_factura_x_fa_cotizacion_info info)
       {
           try
           {
               using (EntitiesFacturacion context = new EntitiesFacturacion())
               {
                   EntitiesFacturacion fact = new EntitiesFacturacion();


                   var addressG = new fa_factura_x_fa_cotizacion();
                   addressG.fa_IdEmpresa = info.fa_IdEmpresa;
                   addressG.fa_IdSucursal = info.fa_IdSucursal;
                   addressG.fa_IdBodega = info.fa_IdBodega;
                   addressG.fa_IdCbteVta = info.fa_IdCbteVta;
                   addressG.cc_IdEmpresa = info.cc_IdEmpresa;
                   addressG.cc_IdSucursal = info.cc_IdSucursal;
                   addressG.cc_IdBodega = info.cc_IdBodega;
                   addressG.cc_IdCotizacion = info.cc_IdCotizacion;

                   context.fa_factura_x_fa_cotizacion.Add(addressG);
                   context.SaveChanges();
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
               throw new Exception(ex.ToString());
           }
       }

       public Boolean EliminarFacxCot(fa_factura_x_fa_cotizacion_info info)
       {
           try
           {
               using (EntitiesFacturacion context = new EntitiesFacturacion())
               {
                   var contact = context.fa_factura_x_fa_cotizacion.FirstOrDefault
                       (cot => cot.fa_IdEmpresa == info.fa_IdEmpresa && cot.fa_IdCbteVta == info.fa_IdCbteVta && cot.fa_IdSucursal == info.fa_IdSucursal && cot.fa_IdBodega == info.fa_IdBodega && cot.cc_IdCotizacion == info.cc_IdCotizacion);
                   if (contact != null)
                   {
                       context.fa_factura_x_fa_cotizacion.Remove(contact);
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
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }
   
   }
}
