using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Academico
{
   public class Aca_Aspirante_Bus
    {
       Aca_Aspirante_Data da;
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

       public Aca_Aspirante_Bus() {
           
           da = new Aca_Aspirante_Data();
       }

       public bool ExisteCedula(int idEmpresa, decimal idAspirante, string cedulaRuc, ref string mensaje)
       {
           try
           {
               Aca_Aspirante_Data  da = new Aca_Aspirante_Data();
               return da.ExisteCedula(idEmpresa, idAspirante, cedulaRuc, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteCedula", ex.Message), ex) { EntityType = typeof(Aca_Aspirante_Bus) };
           }
       }

       public List<Aca_Aspirante_Info> Get_List_Aspirante(int idEmpresa) {
           List<Aca_Aspirante_Info> lstAspirante=new List<Aca_Aspirante_Info>();
           try
           {               
               lstAspirante = da.Get_List_Aspirante(idEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aspirante", ex.Message), ex) { EntityType = typeof(Aca_Aspirante_Bus) };
           }
           return lstAspirante;
       }

       public bool GrabarDB(Aca_Aspirante_Info info,ref decimal idAspirante,ref string msj) {
           bool resultado = false;
           try
           {
               
               resultado= da.GrabarDB(info,ref idAspirante,ref msj);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Aspirante_Bus) };
           }
           return resultado;
       }

       public bool ActualizarDB(Aca_Aspirante_Info info, ref string msj) {
           bool resultado = false;
           try
           {               
               resultado= da.ActualizarDB(info,ref msj);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Aspirante_Bus) };
           }
           return resultado;
       }

       public bool DeleteDB(Aca_Aspirante_Info info, ref string msj) {
           bool resultado = false;
           try
           {               
               resultado = da.AnularDB(info, ref msj);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "DeleteDB", ex.Message), ex) { EntityType = typeof(Aca_Aspirante_Bus) };
           }
           return resultado;
       }

       public Aca_Aspirante_Info Get_Info_Aspirante(decimal IdPersona, ref string msj)
       {
           try
           {
               return da.Get_Info_Aspirante(IdPersona, ref msj);

           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerDatoPersona", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };

           }
       }
    }
}
