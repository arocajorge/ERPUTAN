using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_Cobro_Tipo_x_Anticipo_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cxc_Cobro_Tipo_x_Anticipo_Data data = new cxc_Cobro_Tipo_x_Anticipo_Data();

        public List<cxc_Cobro_Tipo_x_Anticipo_Info> Get_List_Cobro_Tipo_x_Anticipo(int IdEmpresa)
        {
            try
            {
                return data.Get_List_Cobro_Tipo_x_Anticipo(IdEmpresa); ;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo_x_Anticipo", ex.Message), ex) { EntityType = typeof(cxc_Cobro_Tipo_x_Anticipo_Bus) };
            }
        }

        public Boolean GuardarDB(List<cxc_Cobro_Tipo_x_Anticipo_Info> lst)
        {
            try
            {
                return data.GuardarDB(lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_Cobro_Tipo_x_Anticipo_Bus) };
            }
        }


        public Boolean GuardarDB(cxc_Cobro_Tipo_x_Anticipo_Info Info)
        {
            try
            {
                return data.GuardarDB(Info); ;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_Cobro_Tipo_x_Anticipo_Bus) };
            }
        }

        public Boolean ValidarSiExiste(string IdCobro_tipo, int IdEmpresa)
        {
            try
            {
                return data.ValidarSiExiste(IdCobro_tipo, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarSiExiste", ex.Message), ex) { EntityType = typeof(cxc_Cobro_Tipo_x_Anticipo_Bus) };
            }

        }


        public Boolean EliminarDB(cxc_Cobro_Tipo_x_Anticipo_Info Info)
        {
            try
            {
                return data.EliminarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cxc_Cobro_Tipo_x_Anticipo_Bus) };
            }
        }

        public Boolean EliminarLista(int IdEmpresa, int Count)
        {
            try
            {
                return data.EliminarDB(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cxc_Cobro_Tipo_x_Anticipo_Bus) };
            }
        }

        public Boolean ModificarDB(cxc_Cobro_Tipo_x_Anticipo_Info Info)
        {
            try
            {
                data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cxc_Cobro_Tipo_x_Anticipo_Bus) };
            }
            return false;
        }
    }
}
