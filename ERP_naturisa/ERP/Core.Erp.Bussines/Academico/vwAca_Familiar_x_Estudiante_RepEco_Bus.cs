using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Academico
{
    public class vwAca_Familiar_x_Estudiante_RepEco_Bus
    {
        vwAca_Familiar_x_Estudiante_RepEco_Data da = new vwAca_Familiar_x_Estudiante_RepEco_Data();
        public List<vwAca_Familiar_x_Estudiante_RepEco_Info> Get_List_RepresentateEconomico_x_Estudiante(int IdInstitucion, decimal IdEstudiente)
        {
            List<vwAca_Familiar_x_Estudiante_RepEco_Info> lM = new List<vwAca_Familiar_x_Estudiante_RepEco_Info>();
            try
            {
                lM = da.Get_List_RepresentateEconomico_x_Estudiante(IdInstitucion, IdEstudiente);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_RepresentateEconomico_x_Estudiante", ex.Message), ex) { EntityType = typeof(vwAca_Familiar_x_Estudiante_RepEco_Bus) };
            }

        }
    }
}
