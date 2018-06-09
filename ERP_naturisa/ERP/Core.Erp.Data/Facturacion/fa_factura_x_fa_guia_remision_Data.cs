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
   public class fa_factura_x_fa_guia_remision_Data
    {
       string mensaje = "";

       public fa_factura_x_fa_guia_remision_info Get_Info_fa_factura_x_fa_guia_remision(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
       {
           try
           {
               fa_factura_x_fa_guia_remision_info obj = new fa_factura_x_fa_guia_remision_info();
               EntitiesFacturacion OEFAC = new EntitiesFacturacion();

               var ent = OEFAC.fa_factura_x_fa_guia_remision.FirstOrDefault(var => var.gi_IdEmpresa == IdEmpresa
                   && var.gi_IdSucursal == IdSucursal && var.gi_IdBodega == IdBodega && var.fa_IdCbteVta == IdCbteVta);

               if (ent != null)
               {
                   obj.fa_IdEmpresa = ent.fa_IdEmpresa;
                   obj.fa_IdSucursal = ent.fa_IdSucursal;
                   obj.fa_IdBodega = ent.fa_IdBodega;
                   obj.fa_IdCbteVta = ent.fa_IdCbteVta;
                   obj.gi_IdEmpresa = ent.gi_IdEmpresa;
                   obj.gi_IdSucursal = ent.gi_IdSucursal;
                   obj.gi_IdBodega = ent.gi_IdBodega;
                   obj.gi_IdGuiaRemision = ent.gi_IdGuiaRemision;
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

       public Boolean GuardarFacxGuir(fa_factura_x_fa_guia_remision_info info)
       {
           try
           {
               using (EntitiesFacturacion context = new EntitiesFacturacion())
               {
                   EntitiesFacturacion fact = new EntitiesFacturacion();


                   var addressG = new fa_factura_x_fa_guia_remision();
                   addressG.fa_IdEmpresa = info.fa_IdEmpresa;
                   addressG.fa_IdSucursal = info.fa_IdSucursal;
                   addressG.fa_IdBodega = info.fa_IdBodega;
                   addressG.fa_IdCbteVta = info.fa_IdCbteVta;
                   addressG.gi_IdEmpresa = info.gi_IdEmpresa;
                   addressG.gi_IdSucursal = info.gi_IdSucursal;
                   addressG.gi_IdBodega = info.gi_IdBodega;
                   addressG.gi_IdGuiaRemision = info.gi_IdGuiaRemision;
                   context.fa_factura_x_fa_guia_remision.Add(addressG);
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

       public Boolean EliminarFacxGuir(fa_factura_x_fa_guia_remision_info info)
       {
           try
           {
               using (EntitiesFacturacion context = new EntitiesFacturacion())
               {
                   var contact = context.fa_factura_x_fa_guia_remision.FirstOrDefault(cot => cot.fa_IdEmpresa == info.fa_IdEmpresa && cot.fa_IdCbteVta == info.fa_IdCbteVta && cot.fa_IdSucursal == info.fa_IdSucursal && cot.fa_IdBodega == info.fa_IdBodega && cot.gi_IdGuiaRemision == info.gi_IdGuiaRemision);

                   if (contact != null)
                   {
                       context.fa_factura_x_fa_guia_remision.Remove(contact);
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
