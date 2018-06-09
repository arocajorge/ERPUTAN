using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxPagar;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
   public class cp_Autorizacion_x_Doc_x_Pag_Data
    {

       string mensaje = "";
       public Boolean GuardarDB(cp_Autorizacion_x_Doc_x_Pag_Info Info, ref string msg)
       {
           try
           {
               using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
               {

                   var Address = new cp_Autorizacion_x_Doc_x_Pag();

                   Address.Id_Num_Autorizacion = Info.Id_Num_Autorizacion;

                   Address.Serie1 = Info.Serie1;
                   Address.Serie2 = Info.Serie2;
                   Address.Valido_Hasta = Convert.ToDateTime(Info.Valido_Hasta.ToShortDateString());
                   Address.factura_inicial = Info.factura_inicial;
                   Address.factura_final = Info.factura_final;
                   Address.NumAutorizacionImprenta = Info.NumAutorizacionImprenta;
                 
                   CxP.cp_Autorizacion_x_Doc_x_Pag.Add(Address);
                   CxP.SaveChanges();
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
               throw new Exception(ex.InnerException.ToString());
           }
       }


       public Boolean Verificar_NumAutorizacion_Ogiro(string NumAutorizacion, ref string msg)
       {
           try
           {
               using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
               {

                   Boolean Existe;
                   Existe = false;
               
                  var info = CxP.cp_Autorizacion_x_Doc_x_Pag.Count(q => q.Id_Num_Autorizacion == NumAutorizacion);
             
                   if (info > 0)
                   {
                       Existe = true;
                   }
                              
                   return Existe;                  
               }
              
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }
    }
}
