using Core.Erp.Data.Contabilidad_Fj;
using Core.Erp.Info.Contabilidad_Fj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Contabilidad_Fj
{
    public class ct_distribucion_gastos_x_periodo_Bus
    {
        ct_distribucion_gastos_x_periodo_Data oData = new ct_distribucion_gastos_x_periodo_Data();
        ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Data oData_pc = new ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Data();
        ct_distribucion_gastos_x_periodo_det_gastos_Data oData_gastos = new ct_distribucion_gastos_x_periodo_det_gastos_Data();

        public List<ct_distribucion_gastos_x_periodo_Info> get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.get_list(IdEmpresa, Fecha_ini, Fecha_fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_Bus) };
            }
        }

        public bool GuardarDB(ct_distribucion_gastos_x_periodo_Info info)
        {
            try
            {
                if (oData.GuardarDB(info))
                {
                    foreach (var item in info.lst_x_punto_cargo)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdDistribucion = info.IdDistribucion;
                    }
                    foreach (var item in info.lst_x_gastos)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdDistribucion = info.IdDistribucion;
                    }
                    oData_gastos.GuardarDB(info.lst_x_gastos);
                    oData_pc.GuardarDB(info.lst_x_punto_cargo);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_Bus) };
            }
        }

        public bool ModificarDB(ct_distribucion_gastos_x_periodo_Info info)
        {
            try
            {
                if (oData.ModificarDB(info))
                {
                    foreach (var item in info.lst_x_punto_cargo)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdDistribucion = info.IdDistribucion;
                    }
                    foreach (var item in info.lst_x_gastos)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdDistribucion = info.IdDistribucion;
                    }
                    oData_gastos.GuardarDB(info.lst_x_gastos);
                    oData_pc.GuardarDB(info.lst_x_punto_cargo);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_Bus) };
            }
        }

        public bool AnularDB(int IdEmpresa, decimal IdDistribucion)
        {
            try
            {
                return oData.AnularDB(IdEmpresa,IdDistribucion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_Bus) };
            }
        }
    }
}
