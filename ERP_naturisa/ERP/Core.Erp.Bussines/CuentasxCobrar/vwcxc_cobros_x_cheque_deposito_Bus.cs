using Core.Erp.Business.General;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Erp.Business.CuentasxCobrar
{
    public class vwcxc_cobros_x_cheque_deposito_Bus
    {

        vwcxc_cobros_x_cheque_deposito_Data OPD = new vwcxc_cobros_x_cheque_deposito_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<vwcxc_cobros_x_cheque_deposito_Info> Get_List_cobros_x_cheque_deposito_x_Depositar(int IdEmpresa)
        {
            try
            {
                List<vwcxc_cobros_x_cheque_deposito_Info> ListD = new List<vwcxc_cobros_x_cheque_deposito_Info>();
                ListD = OPD.Get_List_cobros_x_cheque_deposito_x_Depositar(IdEmpresa);

                return ListD;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobros_x_cheque_deposito_x_Depositar", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_Pendientes_x_conciliar_Bus) };
            }
        }

        public List<vwcxc_cobros_x_cheque_deposito_Info> Get_List_cobros_x_cheque_deposito_x_Depositados(int IdEmpresa)
        {
            try
            {
                List<vwcxc_cobros_x_cheque_deposito_Info> ListD = new List<vwcxc_cobros_x_cheque_deposito_Info>();
                ListD = OPD.Get_List_cobros_x_cheque_deposito_x_Depositados(IdEmpresa);

                return ListD;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobros_x_cheque_deposito_x_Depositados", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_Pendientes_x_conciliar_Bus) };
            }
        }

        public List<vwcxc_cobros_x_cheque_deposito_Info> Get_List_cobros_x_cheque_deposito_x_Depositar(int IdEmpresa, DateTime FechaInicio, DateTime FechaFin, string IDCobro, int IDSucursal)
        {
            try
            {
                List<vwcxc_cobros_x_cheque_deposito_Info> ListD = new List<vwcxc_cobros_x_cheque_deposito_Info>();
                ListD = OPD.Get_List_cobros_x_cheque_deposito_x_Depositar(IdEmpresa, FechaInicio, FechaFin, IDCobro, IDSucursal);

                return ListD;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobros_x_cheque_deposito_x_Depositar", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_x_cheque_deposito_Bus) };
            }
        }


    }
}
