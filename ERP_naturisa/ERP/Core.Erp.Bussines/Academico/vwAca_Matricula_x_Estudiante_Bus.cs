using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;
using System.ComponentModel;

namespace Core.Erp.Business.Academico
{
    public class vwAca_Matricula_x_Estudiante_Bus
    {
        private vwAca_Matricula_x_Estudiante_Data Odata = new vwAca_Matricula_x_Estudiante_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<vwAca_Matricula_x_Estudiante_Info> Get_List_Matricula_x_Estudiante(int IdInstitucion)
        {
            try
            {
                List<vwAca_Matricula_x_Estudiante_Info> lista = new List<vwAca_Matricula_x_Estudiante_Info>();
                lista = Odata.Get_List_Matricula_x_Estudiante(IdInstitucion);
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Beca", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }
        }
    }
}
