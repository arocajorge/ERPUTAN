using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Produc_Cirdesus
{
   public class prd_GruposTrabajo_PorPP_Bus
   {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       prd_GruposTrabajo_PorPP_Data data = new prd_GruposTrabajo_PorPP_Data();
       public bool GrabaDB(List< prd_GruposTrabajo_PorPP_Info> Info, ref string Error)
       {
           try
           {
               return data.GrabaDB(Info, ref Error);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabaDB", ex.Message), ex) { EntityType = typeof(prd_GruposTrabajo_PorPP_Bus) };
               
           }
       }

       public List<prd_GruposTrabajo_PorPP_Info> GetListaGruposTrabajosEtapas(prd_GruposTrabajo_PorPP_Info Info)
       {
           try
           {
               return data.GetListaGruposTrabajosEtapas(Info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListaGruposTrabajosEtapas", ex.Message), ex) { EntityType = typeof(prd_GruposTrabajo_PorPP_Bus) };
               
           }

       }



       public List<prd_GruposTrabajo_PorPP_Info> GetListEtapasProceProductivo(int Idempresa)
       {
           try
           {
               return data.GetListEtapasProceProductivo(Idempresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListEtapasProceProductivo", ex.Message), ex) { EntityType = typeof(prd_GruposTrabajo_PorPP_Bus) };
               
           }
       }

    }
}
