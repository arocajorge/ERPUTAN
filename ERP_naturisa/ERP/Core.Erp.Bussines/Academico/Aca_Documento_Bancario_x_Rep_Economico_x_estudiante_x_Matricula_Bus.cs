using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;

namespace Core.Erp.Business.Academico
{
   public class Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Bus
   {
       string mensaje = "";
       Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Data data = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Data();
       public List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info> Get_List_Matricula_Tipo_Documento(int IdInstitucion, int idfamiliar)
       {
           try
           {
               return data.Get_List_Matricula_Tipo_Documento(IdInstitucion, idfamiliar);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };

           }
       }
       public List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info> Get_List_Matricula_Tipo_Documento(int IdInstitucion, int idfamiliar, decimal IdEstudiante)
       {
           try
           {
               return data.Get_List_Matricula_Tipo_Documento(IdInstitucion, idfamiliar, IdEstudiante);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };

           }
       }


       public bool GrabarDB(Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info info, ref string mensaje)
       {
           try
           {
               return data.GrabarDB(info, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };

           }
       }

    }
}
