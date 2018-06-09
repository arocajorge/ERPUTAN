using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Inventario
{
    public class in_RecepcionMaterialesCab_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_RecepcionMaterialesCab_Data data = new in_RecepcionMaterialesCab_Data();

      

        public Boolean GrabarDB(int idempresa, in_RecepcionMaterialesCab_Info info, List<in_RecepcionMaterialesDet_Info> lmDetalleInfo, ref string msg, ref int idgenerada)
        {
            try
            {
                return data.GrabarDB(idempresa, info, lmDetalleInfo, ref msg, ref idgenerada);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_RecepcionMaterialesCab_Bus) };

            }
        }

        public Boolean ModificarDB(int idempresa, in_RecepcionMaterialesCab_Info info, ref string msg)
        {
            try
            {
                return data.ModificarDB(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_RecepcionMaterialesCab_Bus) };

            }
        }

        public Boolean Anular(int idempresa, in_RecepcionMaterialesCab_Info info, ref string msg)
        {
            try
            {
                return data.AnularDB(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(in_RecepcionMaterialesCab_Bus) };

            }
        }

      

        public in_RecepcionMaterialesCab_Bus() { }
    }
}
