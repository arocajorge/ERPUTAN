using Core.Erp.Business.General;
using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Academico
{
    public class vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Bus
    {
        public List<vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Info> Get_List_Estudiante_con_Matricula_Sin_Contrato(int IdInstitucion)
        {
            vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Data Odata = new vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Data();
            tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
            try
            {
                List<vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Info> lista = new List<vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Info>();
                lista = Odata.Get_List_Estudiante_con_Matricula_Sin_Contrato_Detalle(IdInstitucion);
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiante_con_Matricula_Sin_Contrato", ex.Message), ex) { EntityType = typeof(vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Bus) };
            }
        }
    }
}
