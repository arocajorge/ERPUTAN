using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Academico
{
    public class vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Bus
    {
        vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Data da;
        public List<vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info> Get_List_Contrato_x_Estudiante_x_Rubro_y_Beca(int IdInstitucion, decimal IdContrato, int IdAnioLectivo, int IdPeriodo)
        {
            da = new vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Data();
            List<vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info> lista = new List<vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info>();
            try
            {
                lista = da.Get_List_Contrato_x_Estudiante_x_Rubro_y_Beca(IdInstitucion, IdContrato, IdAnioLectivo, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Curso", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };
            }
            return lista;
        }

    }
}
