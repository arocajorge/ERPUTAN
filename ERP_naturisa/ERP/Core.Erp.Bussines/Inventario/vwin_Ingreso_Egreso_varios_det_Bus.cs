using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
   public class vwin_Ingreso_Egreso_varios_det_Bus
    {
       string mensaje = "";
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       vwin_Ingreso_Egreso_varios_det_Data odata = new vwin_Ingreso_Egreso_varios_det_Data();

       public List<vwin_Ingreso_Egreso_varios_det_Info> Consulta_IngEgrVariosDet(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo)
       {
           try
           {
               return odata.Consulta_IngEgrVariosDet(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo);
           }
           catch (Exception ex)
           {
               oLog.Log_Error(ex.ToString());
               mensaje = "Error al Consultar .." + ex.Message;
               return new List<vwin_Ingreso_Egreso_varios_det_Info>(); 
              
           }                   
       }

       public Boolean Modificar_Estado_IngEgr_Det(List<vwin_Ingreso_Egreso_varios_det_Info> lista, string tipo, ref string msgs)
       {
           try
           {
               Boolean res = true;
               if (Validar_objeto_IngEgr_Det(lista, ref  msgs))
               {
                   res= odata.Modificar_Estado_IngEgr_Det(lista, tipo, ref  msgs);
               }
               else
               {
                   res = false;                  
               }
               return res;
                             
           }
           catch (Exception ex)
           {
               
              oLog.Log_Error(ex.ToString());
               mensaje = "Error al Actualizar Estados .." + ex.Message;
               return false;
           }
      
       }

       public Boolean Validar_objeto_IngEgr_Det(List<vwin_Ingreso_Egreso_varios_det_Info> lista, ref string msg)
       {
           try
           {
               
               if (lista.Count == 0 || lista.Count == null)
               {
                   msg = "No existen detalles a Actualizar o No ha seleccionado algún item ";
                   return false;
               }
           
               return true;
           }
           catch (Exception ex)
           {
               oLog.Log_Error(ex.ToString());
               mensaje = "Error al Actualizar Estados .." + ex.Message;
               msg = mensaje;
               return false;

           }

       }
    }
}
