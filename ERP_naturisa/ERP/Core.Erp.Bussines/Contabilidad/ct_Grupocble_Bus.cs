using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_Grupocble_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<ct_Grupocble_Info> Get_list_Grupocble()
        {
            List<ct_Grupocble_Info> lm = new List<ct_Grupocble_Info>();
            ct_Grupocble_Data data = new ct_Grupocble_Data();


            try
            {
                lm = data.Get_list_Grupocble();
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Grupocble", ex.Message), ex) { EntityType = typeof(ct_Grupocble_Bus) };
            }
        }

        public Boolean ModificarDB(ct_Grupocble_Info info, ref string mensaje)
        {
            try
            {
                ct_Grupocble_Data data = new ct_Grupocble_Data();
                return data.ModificarDB(info, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_Grupocble_Bus) };
            }
        }


        public Boolean EliminarDB(ct_Grupocble_Info info, ref string mensaje)
        {
            try
            {
                ct_Grupocble_Data data = new ct_Grupocble_Data();
                return data.EliminarDB(info, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_Grupocble_Bus) };
            }
        }


        public Boolean GrabarDB(ct_Grupocble_Info info, ref string mensaje)
        {
            try
            {
                ct_Grupocble_Data data = new ct_Grupocble_Data();
                return data.GrabarDB(info, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Grupocble_Bus) };
            }
        }
    }
}
