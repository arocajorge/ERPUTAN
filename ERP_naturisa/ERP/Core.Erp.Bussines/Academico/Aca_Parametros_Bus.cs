using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Academico
{
    public class Aca_Parametros_Bus
    {
        Aca_Parametros_Data oData = new Aca_Parametros_Data();

        public bool GuardarDB(Aca_Parametros_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Aca_Parametros_Bus) };
            }
        }

        public Aca_Parametros_Info Get_info_parametros(int IdEmpresa, int IdInstitucion)
        {
            try
            {
                return oData.Get_info_parametros(IdEmpresa, IdInstitucion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Aca_Parametros_Bus) };
            }
        }

    }
}
