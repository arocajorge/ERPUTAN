using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
  public  class vwfa_creditos_debitos_con_saldo_Bus
     
    {
      vwfa_creditos_debitos_con_saldo_Data oData = new vwfa_creditos_debitos_con_saldo_Data();
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      public List<vwfa_creditos_debitos_con_saldo_Info> Get_List_CreDeb_Saldo(int IdEmpresa, int IdSucursal, decimal IdCliente, ref string mensaje)
      {
          try
          {
              return oData.Get_List_CreDeb_Saldo(IdEmpresa, IdSucursal, IdCliente, ref mensaje);
          }
          catch (Exception ex)
          {


              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLista_CreDeb_Saldo", ex.Message), ex) { EntityType = typeof(vwfa_creditos_debitos_con_saldo_Bus) };
          }
              
      }
    }
}
