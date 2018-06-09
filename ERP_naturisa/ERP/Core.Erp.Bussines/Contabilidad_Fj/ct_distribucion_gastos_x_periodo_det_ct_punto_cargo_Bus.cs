using Core.Erp.Data.Contabilidad_Fj;
using Core.Erp.Info.Contabilidad_Fj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Contabilidad_Fj
{
    public class ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Bus
    {
        ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Data oData = new ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Data();

        public List<ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info> get_list(int IdEmpresa, decimal IdDistribucion)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdDistribucion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Bus) };
            }
        }

        public bool GuardarDB(ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Bus) };
            }
        }

        public bool GuardarDB(List<ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info> Lista)
        {
            try
            {
                return oData.GuardarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Bus) };
            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdDistribucion)
        {
            try
            {
                return oData.EliminarDB(IdEmpresa,IdDistribucion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Bus) };
            }
        }

    }
}
