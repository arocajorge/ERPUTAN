using Core.Erp.Business.General;
using Core.Erp.Data.CuentasxCobrar_Grafinpren;
using Core.Erp.Info.CuentasxCobrar_Grafinpren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.CuentasxCobrar_Grafinpren
{
    public class cxc_Comisiones_x_vendedor_Bus
    {
        cxc_Comisiones_x_vendedor_Data oData = new cxc_Comisiones_x_vendedor_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<cxc_Comisiones_x_vendedor_Info> Get_list_x_empresa(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, List<string> lst_TipoCobro, int IdVendedor)
        {
            try
            {
                return oData.Get_list_x_empresa(IdEmpresa, Fecha_ini, Fecha_fin,lst_TipoCobro,IdVendedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_x_empresa", ex.Message), ex) { EntityType = typeof(cxc_Comisiones_x_vendedor_Bus) };
            }
        }

        public bool GuardarDB(cxc_Comisiones_x_vendedor_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_Comisiones_x_vendedor_Bus) };
            }
        }

        public bool ModificarDB(cxc_Comisiones_x_vendedor_Info info)
        {
            try
            {
                return oData.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cxc_Comisiones_x_vendedor_Bus) };
            }
        }

        public bool GuardarDB(List<cxc_Comisiones_x_vendedor_Info> Lista)
        {
            try
            {
                return oData.GuardarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_Comisiones_x_vendedor_Bus) };
            }
        }
    }
}
