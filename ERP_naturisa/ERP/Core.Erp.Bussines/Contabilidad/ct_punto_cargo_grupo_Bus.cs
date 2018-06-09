using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Facturacion_FJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_punto_cargo_grupo_Bus
    {
        ct_punto_cargo_grupo_Data oData = new ct_punto_cargo_grupo_Data();

        public List<ct_punto_cargo_grupo_Info> Get_List_punto_cargo_grupo(int IdEmpresa, ref string mensaje)
        {
         try
            {
                return oData.Get_List_punto_cargo_grupo(IdEmpresa, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_punto_cargo_grupo", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_grupo_Bus) };
            }
        }

        public int GetId(int IdEmpresa)
        {
            try
            {
                return oData.getId(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_grupo_Bus) };
            }
        }

        public bool GuardarDB(ct_punto_cargo_grupo_Info Info, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_grupo_Bus) };
            }
        }

        public bool ModificarDB(ct_punto_cargo_grupo_Info Info, ref string mensaje)
        {
            try
            {
                return oData.ModificiarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_grupo_Bus) };
            }
        }

        public bool AnularDB(ct_punto_cargo_grupo_Info Info, ref string mensaje)
        {
            try
            {
                return oData.AnularDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_grupo_Bus) };
            }
        }
    }
}
