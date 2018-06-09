using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_liquidaciones_tipo_proceso_Bus
    {
        fa_liquidaciones_tipo_proceso_Data oData = new fa_liquidaciones_tipo_proceso_Data();
        public List<fa_liquidaciones_tipo_proceso_Info> Get_List_Liqui_Tipo_Proceso(ref string mensaje)
        {
            try
            {
                return oData.Get_List_Liqui_Tipo_Proceso(ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Liqui_Tipo_Proceso", ex.Message), ex) { EntityType = typeof(fa_liquidaciones_tipo_proceso_Bus) };
            }
        }

 

        public bool GuardarDB(fa_liquidaciones_tipo_proceso_Info Info, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_liquidaciones_tipo_proceso_Bus) };
            }
        }

        public bool ModificiarDB(fa_liquidaciones_tipo_proceso_Info Info, ref string mensaje)
        {
            try
            {
                return oData.ModificiarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_liquidaciones_tipo_proceso_Bus) };
            }
        }

        public Boolean TipoProcesoExiste(string IdTipoProceso, ref string mensaje)
        {
            try
            {
                return oData.TipoProcesoExiste(IdTipoProceso, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TipoProcesoExiste", ex.Message), ex) { EntityType = typeof(fa_liquidaciones_tipo_proceso_Bus) };
            }
        }
    }
}
