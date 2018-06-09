using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;

namespace Core.Erp.Business.Academico
{
 public  class vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Bus
    {
     private vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Data da;
     public vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Bus() {
         da = new vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Data();
     }

     public List<vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info> Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para(int IdEmpresa, int IdInstitucion) {
         try
         {
             return da.Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para(IdEmpresa,IdInstitucion);

         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para", ex.Message), ex) { EntityType = typeof(vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Bus) };

         }
         
     }


    }
}
