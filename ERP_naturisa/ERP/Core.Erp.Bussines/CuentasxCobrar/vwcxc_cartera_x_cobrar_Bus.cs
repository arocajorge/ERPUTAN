using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class vwcxc_cartera_x_cobrar_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwcxc_cartera_x_cobrar_Data data = new vwcxc_cartera_x_cobrar_Data();

        public List<vwcxc_cartera_x_cobrar_Info> Get_List_cartera_x_cobrar(int IdEmpresa, int IdSucursal, DateTime FInicio, DateTime FFin)
        {
            try
            {
                 return data.Get_List_cartera_x_cobrar(IdEmpresa, IdSucursal, FInicio, FFin);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_anticipos_x_cruzar", ex.Message), ex) { EntityType = typeof(vwcxc_cartera_x_cobrar_Bus) };
            }
        }

        public List<vwcxc_cartera_x_cobrar_Info> Get_List_cartera_x_cobrar(int IdEmpresa, int IdSucursalI, decimal IdCliente)
        {
            try
            {
                 return data.Get_List_cartera_x_cobrar(IdEmpresa, IdSucursalI, IdCliente);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_anticipos_x_cruzar", ex.Message), ex) { EntityType = typeof(vwcxc_cartera_x_cobrar_Bus) };
            }

        }

        public vwcxc_cartera_x_cobrar_Info Get_Info_cartera_x_cobrar(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble, string TipoDoc)
        {
            try
            {
                return data.Get_Info_cartera_x_cobrar(IdEmpresa, IdSucursal, IdBodega, IdCbteCble, TipoDoc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_anticipos_x_cruzar", ex.Message), ex) { EntityType = typeof(vwcxc_cartera_x_cobrar_Bus) };
            }

        }

        public vwcxc_cartera_x_cobrar_Bus(){}
    }
}
