using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.General
{
   public class tb_Mes_Data
    {
       string mensaje = "";
       public List<tb_Mes_info> Get_List_Mes()
       {
          
           try
           {
               List<tb_Mes_info> lm = new List<tb_Mes_info>();
               EntitiesGeneral Otabla = new EntitiesGeneral();

               var selectmes = from A in Otabla.tb_mes
                                 select A;

               foreach (var item in selectmes)
               {
                   tb_Mes_info mes_info = new tb_Mes_info();
                   mes_info.idMes = item.idMes;
                   mes_info.smes = item.smes;
                   mes_info.nemonico = item.Nemonico;

                   lm.Add(mes_info);
               }
               return (lm);
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

       public string Get_Nombre_mes(int idmes)
       {
           try
           {
               EntitiesGeneral Otabla = new EntitiesGeneral();

               var selectmes = from A in Otabla.tb_mes
                               where A.idMes==idmes
                               select A.smes.Trim();
               return selectmes.ToString();
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

       public tb_Mes_Data() 
       {

       }
    }
}
