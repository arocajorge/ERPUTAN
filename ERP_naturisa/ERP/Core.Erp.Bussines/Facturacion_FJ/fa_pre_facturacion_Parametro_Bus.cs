using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_pre_facturacion_Parametro_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus(); 
        fa_pre_facturacion_Parametro_Data oData = new fa_pre_facturacion_Parametro_Data();
        fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Bus bus_margen_ganacia = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Bus();
        public fa_pre_facturacion_Parametro_Info Get_Info(int IdEmpresa)
        {
            bool bandera=false;
            try
            {
                return oData.Get_Info_Parametro(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_Parametro_Bus) };
            }
        }

        public Boolean GuardarDB(fa_pre_facturacion_Parametro_Info Info, ref string mensaje)
        {
            bool bandera = false;

            try
            {
                if (oData.GuardarDB(Info, ref mensaje))
                {
                    bandera = true;
                  bandera=  bus_margen_ganacia.Guardar(Info.lis_param_x_fuerza);
                }
                return bandera;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_Parametro_Bus) };
            }
        }

        public Boolean ModificarDB(fa_pre_facturacion_Parametro_Info Info, ref string mensaje)
        {
            bool bandera = false;

            try
            {
                if (oData.ModificarDB(Info, ref mensaje))
                {
                    bandera = true;
                    bandera = bus_margen_ganacia.Guardar(Info.lis_param_x_fuerza);
                }
                return bandera;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_Parametro_Bus) };
            }
        }
    }
}
