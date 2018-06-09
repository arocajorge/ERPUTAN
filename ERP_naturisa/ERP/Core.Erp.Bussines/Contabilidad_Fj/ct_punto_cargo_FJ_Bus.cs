using Core.Erp.Data.Contabilidad_Fj;
using Core.Erp.Info.Contabilidad_Fj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Contabilidad_Fj
{
    public class ct_punto_cargo_FJ_Bus
    {
        ct_punto_cargo_FJ_Data oData = new ct_punto_cargo_FJ_Data();

        public ct_punto_cargo_FJ_Info Get_info_punto_cargo(int IdEmpresa, int IdPunto_cargo)
        {
            try
            {
                return oData.Get_info_punto_cargo(IdEmpresa, IdPunto_cargo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_FJ_Bus) };
            }
        }

        public bool GuardarDB(ct_punto_cargo_FJ_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_FJ_Bus) };
            }
        }

        public bool ModificarDB(ct_punto_cargo_FJ_Info info)
        {
            try
            {
                return oData.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_FJ_Bus) };
            }
        }
    }
}
