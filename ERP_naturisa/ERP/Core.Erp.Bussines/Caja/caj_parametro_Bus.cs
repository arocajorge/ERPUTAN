using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Caja;
using Core.Erp.Data.Caja;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Caja
{
    public class caj_parametro_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        caj_parametro_Data data = new caj_parametro_Data();
        public caj_parametro_Info Get_Info_Parametro(int IdEmpresa)
        {
            try
            {
                 return data.Get_Info_Parametro(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener", ex.Message), ex) { EntityType = typeof(caj_parametro_Bus) };
            }

        }

        public Boolean ModificarDB(caj_parametro_Info info, List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info> LstTipoxCta)
        {
            try
            {
             return data.ModificarDB(info,  LstTipoxCta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(caj_parametro_Bus) };
            }

        }
    }
}
