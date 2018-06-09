using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Core.Erp.Reportes.Bancos
{
  public  class XBAN_Rpt007_saldos_Data
  {
      
      public List<XBAN_Rpt007_saldos_Info> Get_List(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, String IdUsuario)
      {
          try
          {
              FechaIni = FechaIni.Date;
              FechaFin = FechaFin.Date;
              List<XBAN_Rpt007_saldos_Info> list = new List<XBAN_Rpt007_saldos_Info>();
              using (EntitiesBancos_Reporte_Ge context = new EntitiesBancos_Reporte_Ge())
              {
                  var lst= from q in context.spBAN_Rpt007_saldos( IdEmpresa,  FechaIni,  FechaFin,  IdUsuario)
                      select q;
                  foreach (var info in lst)
                  {
                      XBAN_Rpt007_saldos_Info entity = new XBAN_Rpt007_saldos_Info();
                      entity.IdEmpresa = info.IdEmpresa;
                      entity.IdBanco = info.IdBanco;
                      entity.IdUsuario = info.IdUsuario;
                      entity.nom_cuenta_banco = info.nom_cuenta_banco;
                      entity.Saldo_inicial = info.Saldo_inicial;
                      entity.Saldo_final = info.Saldo_final;
                      list.Add(entity);
                  }
              }

              return list;
          }

          catch (Exception ex)
          {
              string MensajeError = "";
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
              MensajeError = ex.ToString();
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_Rpt014_Data) };
          }
      }

  }
}
