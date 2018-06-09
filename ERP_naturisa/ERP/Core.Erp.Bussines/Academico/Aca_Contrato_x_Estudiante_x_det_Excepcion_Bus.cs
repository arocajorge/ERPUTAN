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
    public class Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus
    {
        Aca_Contrato_x_Estudiante_x_det_Excepcion_Data OData;
       tb_sis_Log_Error_Vzen_Bus oLog;


       public Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus()
        {
           oLog = new tb_sis_Log_Error_Vzen_Bus();
           OData = new Aca_Contrato_x_Estudiante_x_det_Excepcion_Data();
        }



        #region "Get"

        public int GetId()
        {
            int Id = 0;
            try
            {
                Id = OData.GetId();
                return Id;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }

        }

        public List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info> Get_List_Rubros_Contrato(Aca_Contrato_x_Estudiante_Info InfoContrato)
        {
            List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info> lstRubros = new List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info>();
            try
            {
                lstRubros = OData.Get_List_Rubros_Contrato(InfoContrato);
                return lstRubros;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Beca", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }

        }
        #endregion
    }
}
