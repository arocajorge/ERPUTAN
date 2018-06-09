using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_cobro_x_Anticipo_det_Bus
    {
        cxc_cobro_x_Anticipo_det_Data data = new cxc_cobro_x_Anticipo_det_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        public List<cxc_cobro_x_Anticipo_det_Info> Get_List_cobro_x_Anticipo_det(int IdEmpresa, int IdAnticipo, ref string mensaje)
        {
            try
            {
                return data.Get_List_cobro_x_Anticipo_det(IdEmpresa, IdAnticipo,ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_Anticipo_det", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_det_Bus) };
            }
        }

        public Boolean GuardarDB(List<cxc_cobro_x_Anticipo_det_Info> info, ref string mensaje)
        {
            try
            {
                return data.GuardarDB(info,ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_det_Bus) };
            }
        
        }

        public Boolean ModificarD(List<cxc_cobro_x_Anticipo_det_Info> info, ref string mensaje)
        {
            try
            {
                int numero = 0;
                return data.ModificarDB(info, ref numero,ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_Anticipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_det_Bus) };
            }
        
        }


        public Boolean modificar_datos_cobro(List<cxc_cobro_x_Anticipo_det_Info> info, ref string mensaje)
        {
            try
            {
                return data.Modificar_datos_cobro(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_Anticipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_det_Bus) };
            }
        }
    }
}
