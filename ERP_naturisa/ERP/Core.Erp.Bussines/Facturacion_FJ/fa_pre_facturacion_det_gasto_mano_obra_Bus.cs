using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Business.Facturacion_FJ
{
  public  class fa_pre_facturacion_det_gasto_mano_obra_Bus
    {
      string ensaje = "";
      string mensaje="";
      fa_pre_facturacion_det_gasto_mano_obra_Data data = new fa_pre_facturacion_det_gasto_mano_obra_Data();
      public List<fa_pre_facturacion_det_gasto_mano_obra_Info> Get_List(int IdEmpresa, decimal IdPrefacturacion, DateTime Fecha)
      {

          try
          {
              return data.Get_List(IdEmpresa, IdPrefacturacion, Fecha);
          }
          catch (Exception ex)
          {
                ensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
          }
      }
    }
}
