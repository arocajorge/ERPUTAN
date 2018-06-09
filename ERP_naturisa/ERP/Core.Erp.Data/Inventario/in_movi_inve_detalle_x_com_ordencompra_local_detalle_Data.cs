using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Inventario
{
   public class in_movi_inve_detalle_x_com_ordencompra_local_detalle_Data
    {

       public Boolean GrabarDB(List<in_movi_inve_detalle_x_com_ordencompra_local_detalle_Info> lista, ref string mensaje)
       {
           try
           {
               using (EntitiesInventario context = new EntitiesInventario())
               {
                   EntitiesInventario EDB = new EntitiesInventario();

                   foreach (var item in lista)
                   {
                       in_movi_inve_detalle_x_com_ordencompra_local_det address = new in_movi_inve_detalle_x_com_ordencompra_local_det();

                       address.mi_IdEmpresa = item.mi_IdEmpresa;
                       address.mi_IdSucursal = item.mi_IdSucursal;
                       address.mi_IdBodega = item.mi_IdBodega;
                       address.mi_IdMovi_inven_tipo = item.mi_IdMovi_inven_tipo;
                       address.mi_IdNumMovi = item.mi_IdNumMovi;
                       address.mi_Secuencia = item.mi_Secuencia;
                       address.ocd_IdEmpresa = item.ocd_IdEmpresa;
                       address.ocd_IdSucursal = item.ocd_IdSucursal;
                       address.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                       address.ocd_Secuencia = item.ocd_Secuencia;

                       if(item.observacion==null)
                       {
                           item.observacion = "";
                       }
                       address.observacion = item.observacion;

                       context.in_movi_inve_detalle_x_com_ordencompra_local_det.Add(address);
                       context.SaveChanges();

                       mensaje = "Grabacion ok..";
                  }

                   return true;
               }
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

       public Boolean AnularDB(in_movi_inve_Info Info, ref string mensaje)
       {
           try
           {

               using (EntitiesInventario context = new EntitiesInventario())
               {

                   string Query = "delete from in_movi_inve_detalle_x_com_ordencompra_local_det where mi_IdEmpresa = " + Info.IdEmpresa + " and mi_IdBodega =" + Info.IdBodega + " and mi_IdSucursal =" + Info.IdSucursal + " and mi_IdMovi_inven_tipo= " + Info.IdMovi_inven_tipo + " and mi_IdNumMovi="+ Info.IdNumMovi +"";

                   var Consulta = context.Database.SqlQuery<in_movi_inve_Info>(Query);
                   return true;
               }
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
