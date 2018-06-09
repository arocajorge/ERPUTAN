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
    public class vwAca_curso_Bus
    {
        private vwAca_curso_Data Odata = new vwAca_curso_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<vwAca_curso_Info> Get_List_Curso(ref string mensaje)
        {
            try
            {
                List<vwAca_curso_Info> lista = new List<vwAca_curso_Info>();
                lista = Odata.Get_List_Curso(ref mensaje);
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Admision_Bus) };
            }
        }
    }
}
