using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Business.General;



namespace Core.Erp.Business.CuentasxCobrar
{
    public class vwcxc_cobros_Pendientes_x_conciliar_Bus
    {
      vwcxc_cobros_Pendientes_x_conciliar_Data oData = new vwcxc_cobros_Pendientes_x_conciliar_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<vwcxc_cobros_Pendientes_x_conciliar_Info> Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo(int IdEmpresa, int IdSucursal, decimal IdCliente, Cl_Enumeradores.TipoConciliacion IdTipoConciliacion, ref string mensaje)
        {
            try
            {
                return oData.Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo(IdEmpresa, IdSucursal, IdCliente,IdTipoConciliacion, ref mensaje);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_x_cheque_deposito_Bus) };
            }

        }
    }
}
