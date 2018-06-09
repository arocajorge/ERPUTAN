using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.FJ.Facturacion
{
  public  class XFAC_FJ_Rpt012_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XFAC_FJ_Rpt012_Info> Get_List_Conciliacion(int idEmpresa, int IdPeriodo)
      {
          try
          {
              List<XFAC_FJ_Rpt012_Info> Lista = new List<XFAC_FJ_Rpt012_Info>();
              Cbt = empresaData.Get_Info_Empresa(idEmpresa);

              using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
              {
                  var lst = from q in Context.vwFAC_FJ_Rpt012
                            where q.IdEmpresa == idEmpresa
                            && q.IdPeriodo == IdPeriodo
                            select q;

                  foreach (var item in lst)
                  {
                      XFAC_FJ_Rpt012_Info Info = new XFAC_FJ_Rpt012_Info();
                      Info.IdEmpresa = item.IdEmpresa;
                      Info.IdPrestamo = item.IdPrestamo;
                      Info.NumCuota = item.NumCuota;
                      Info.SaldoInicial = item.SaldoInicial;
                      Info.Interes = item.Interes;
                      Info.AbonoCapital = item.AbonoCapital;
                      Info.TotalCuota = item.TotalCuota;
                      Info.Saldo = item.Saldo;
                      Info.FechaPago = item.FechaPago;
                      Info.IdPeriodo = item.IdPeriodo;
                      Info.IdCentroCosto_cc = item.IdCentroCosto_cc;
                      Info.Valor = item.Valor;
                      Info.em_nombre = Cbt.em_nombre;
                      Info.em_logo = Cbt.em_logo;
                      Lista.Add(Info);

      
                  }
              }
              return Lista;
          }
          catch (Exception ex)
          {
              string mensaje = "";
              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
          }
      }
   
    }
}
