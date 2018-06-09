using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
   public class prd_GrupoTrabajo_Bus
   {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       prd_GrupoTrabajo_Data data = new prd_GrupoTrabajo_Data();

       public List<prd_GrupoTrabajo_Info> ObtenerGrupoTrabajoCab(int Idempresa)
       {
           try
           {
               return data.ObtenerGrupoTrabajoCab(Idempresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerGrupoTrabajoCab", ex.Message), ex) { EntityType = typeof(prd_GrupoTrabajo_Bus) };
               
           }
       }




       public Boolean GrabarCabeceraDB(prd_GrupoTrabajo_Info info)
       {
           try
           {
               return data.GrabarCabeceraDB(info);
           }
           catch (Exception ex)
           {
               oLog.Log_Error(ex.ToString());
               mensaje = "Error al Grabar .." + ex.Message;
               return false;
           }
       }

       public Boolean ModificarDB(prd_GrupoTrabajo_Info info)
       {
           try
           {
               return data.ModificarDB(info);
           }
           catch (Exception ex)
           {
               oLog.Log_Error(ex.ToString());
               mensaje = "Error al Mmodificar .." + ex.Message;
               return false;
           }
       }
    }
}
