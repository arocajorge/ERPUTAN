using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
   public class vwIn_Motivo_traslado_bodega_Data
    {
       string mensaje = "";
       public List<vwIn_Motivo_traslado_bodega_Info> Get_List_Motivo_traslado_bodega()
       {
           List<vwIn_Motivo_traslado_bodega_Info> Lst = new List<vwIn_Motivo_traslado_bodega_Info>();
           try
           {            
               EntitiesInventario oEnti = new EntitiesInventario();
               var Query = from q in oEnti.vwin_Motivo_traslado_bodega
                         
                           select q;
               foreach (var item in Query)
               {
                   vwIn_Motivo_traslado_bodega_Info Obj = new vwIn_Motivo_traslado_bodega_Info();

                   Obj.IdMotivo_Traslado = item.IdMotivo_Traslado;
                   Obj.IdCatalogo_tipo = item.IdCatalogo_tipo;
                   Obj.Nombre = item.Nombre;
                   Obj.Estado = item.Estado;
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
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }
    }
}
