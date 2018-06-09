using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;
using Core.Erp.Data;

namespace Core.Erp.Business.Academico
{
    public class vwAca_AnioPeriodo_Activo_Bus
    {
        private vwAca_AnioPeriodo_Activo_Data Odata = new vwAca_AnioPeriodo_Activo_Data();

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public vwAca_AnioPeriodo_Activo_Info Get_vwAca_AnioPeriodo_Activo_Info(ref string mensaje)
        {
            try
            {
                vwAca_AnioPeriodo_Activo_Info info = new vwAca_AnioPeriodo_Activo_Info();
                info = Odata.Get_List_vwAca_AnioPeriodo_Activo(ref mensaje);
                return info;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "GrabarDB", ex.Message), ex) { EntityType = typeof(vwAca_AnioPeriodo_Activo_Bus) };
            }
        }
    }
}
