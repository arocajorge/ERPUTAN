using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Academico
{
   public class Aca_estudiante_x_Alergia_Bus
   {
       Aca_estudiante_x_Alergia_Data da;
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

       public Aca_estudiante_x_Alergia_Bus() {
           da = new Aca_estudiante_x_Alergia_Data();
       }


       public List<Aca_Estudiante_x_Alergia_Info> Get_List_estudiante_x_Alergia(int idEmpresa, decimal idEstudiante) {
           List<Aca_Estudiante_x_Alergia_Info> lstAlergia = new List<Aca_Estudiante_x_Alergia_Info>();
           try
           {
             
               da = new Aca_estudiante_x_Alergia_Data();
               if (idEstudiante==0)
               {
                   idEmpresa = 0;
               }

               lstAlergia = da.Get_List_estudiante_x_Alergia(idEmpresa, idEstudiante);
               return lstAlergia;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_estudiante_x_Alergia", ex.Message), ex) { EntityType = typeof(Aca_estudiante_x_Alergia_Bus) };
           }   
       }

       public bool GrabarDB(List<Aca_Estudiante_x_Alergia_Info> lstAlergia,decimal idEstudiante ,int idEmpresa,ref string msj) {
           try
           {
               da = new Aca_estudiante_x_Alergia_Data();
               bool resultado = da.GrabarDB(lstAlergia, idEstudiante, idEmpresa, ref msj);
               return resultado;        
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_estudiante_x_Alergia_Bus) };
           }
        
       }

       public bool ActualizarDB(List<Aca_Estudiante_x_Alergia_Info> lstAlergia,ref string msj) {
           try
           {
               da = new Aca_estudiante_x_Alergia_Data();
               bool resultado = da.ActualizarDB(lstAlergia, ref msj);
               return resultado;
       
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_estudiante_x_Alergia_Bus) };
           }          
       }

    }
}
