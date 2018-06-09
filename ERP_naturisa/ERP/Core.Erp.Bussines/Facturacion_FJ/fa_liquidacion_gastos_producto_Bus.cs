using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_liquidacion_gastos_producto_Bus
    {
        fa_liquidacion_gastos_producto_Data oData = new fa_liquidacion_gastos_producto_Data();
        string MensajeError = string.Empty;
        public List<fa_liquidacion_gastos_producto_Info> Get_List_Liqui_Gas_Producto(int IdEmpresa, ref string mensaje)
        {
            try
            {
                return oData.Get_List_Liqui_Gas_Producto(IdEmpresa, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Liqui_Gas_Producto", ex.Message), ex) { EntityType = typeof(fa_liquidacion_gastos_producto_Bus) };
            }
        }

        public int getId(int IdEmpresa)
        {
            try
            {
                return oData.getId(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(fa_liquidacion_gastos_producto_Bus) };
            }
        }

        public bool GuardarDB(fa_liquidacion_gastos_producto_Info Info, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_liquidacion_gastos_producto_Bus) };
            }
        }

        public bool ModificiarDB(fa_liquidacion_gastos_producto_Info Info, ref string mensaje)
        {
            try
            {
                return oData.ModificiarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_liquidacion_gastos_producto_Bus) };
            }
        }

        public bool AnularDB(fa_liquidacion_gastos_producto_Info Info, ref string mensaje)
        {
            try
            {
                return oData.AnularDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(fa_liquidacion_gastos_producto_Bus) };
            }
        }
    }
}
