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
   public class XBAN_Rpt019_Data
    {


       public List<XBAN_Rpt019_Info> GetData(int IdEmpresa, int IdTipocbte ,decimal IdCbteCble,  ref string MensajeError)
       {
           try
           {
               List<XBAN_Rpt019_Info> Result = new List<XBAN_Rpt019_Info>();
               using (EntitiesBancos_Reporte_Ge conexion = new EntitiesBancos_Reporte_Ge())
               {
                   var Select = from q in conexion.vwBAN_Rpt019
                                where q.IdEmpresa == IdEmpresa
                                && q.IdCbteCble == IdCbteCble
                                && q.IdTipocbte == IdTipocbte
                                select q;
                   foreach (var item in Select)
                   {
                       XBAN_Rpt019_Info infoRpt = new XBAN_Rpt019_Info();

                       infoRpt.IdEmpresa = item.IdEmpresa;
                       infoRpt.IdTipocbte = item.IdTipocbte;
                       infoRpt.IdCbteCble = item.IdCbteCble;
                       infoRpt.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                       infoRpt.Referencia = item.Referencia;
                       infoRpt.MontoAplicado = item.MontoAplicado;
                       infoRpt.co_observacion = item.co_observacion;
                       infoRpt.co_fecha = item.co_fecha;
                       
                       Result.Add(infoRpt);
                   }
                   return Result;
               }
           }
           catch (Exception ex)
           {
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
               MensajeError = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_Rpt005_Data) };
           }
       }

    }
}
