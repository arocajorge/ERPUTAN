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
    public class Aca_Contrato_x_Estudiante_det_Bus
    {
        Aca_Contrato_x_Estudiante_det_Data data = new Aca_Contrato_x_Estudiante_det_Data();

        public Boolean GuardarDB(List<Aca_Contrato_x_Estudiante_det_Info> LstInfo)
        {
            try
            {
                return data.GrabarDB(LstInfo);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_det_Bus) };


            }
        }

        public List<Aca_Contrato_x_Estudiante_det_Info> Get_Lista_Contrato_x_Estudiante_det(int IdInstitucion, decimal IdContrato)
        {
            try
            {
                return data.Get_Lista_Contrato_x_Estudiante_det(IdInstitucion, IdContrato);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Contrato_x_Estudiante_det", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_det_Bus) };


            }
        }

        public bool ActualizarDB(Aca_Contrato_x_Estudiante_det_Info info, ref string mensaje)
        {
            try
            {
                return data.ActualizarDB(info, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB_Contrato_x_Estudiante_det", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_det_Bus) };


            }
        }

    }
}
