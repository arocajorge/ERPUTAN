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
   public class XBAN_Rpt015_Data
    {
       public List<XBAN_Rpt015_Info> Get_Data_Reporte(int IdEmpresa, int IdTipocbte, decimal IdCbteCble, ref string MensajeError)
       {
           try
           {
               List<XBAN_Rpt015_Info> lstRpt = new List<XBAN_Rpt015_Info>();




               using (EntitiesBancos_Reporte_Ge listado = new EntitiesBancos_Reporte_Ge())
               {
                   var select = from q in listado.vwBAN_Rpt015
                                where q.mba_IdEmpresa == IdEmpresa
                                && q.mba_IdTipocbte == IdTipocbte
                                && q.mba_IdCbteCble == IdCbteCble
                                select q;

                   foreach (var item in select)
                   {

                       XBAN_Rpt015_Info infoRpt = new XBAN_Rpt015_Info();

                       
                       infoRpt.mba_IdEmpresa = item.mba_IdEmpresa;
                       infoRpt.mba_IdCbteCble = item.mba_IdCbteCble;
                       infoRpt.mba_IdTipocbte = item.mba_IdTipocbte;
                       infoRpt.IdEmpresa = item.IdEmpresa;
                       infoRpt.nom_sucursal = item.nom_sucursal;
                       infoRpt.IdCbteCble = item.IdCbteCble;
                       infoRpt.IdTipocbte = item.IdTipocbte;
                       infoRpt.nom_Tipocbte = item.nom_Tipocbte;
                       infoRpt.Beneficiario = item.Beneficiario;
                       infoRpt.IdCobro_tipo = item.IdCobro_tipo;
                       infoRpt.Fecha_Cobro = item.Fecha_Cobro;
                       infoRpt.cr_Valor = item.cr_Valor;

                       infoRpt.cm_observacion = item.cm_observacion;
                       infoRpt.mcj_Secuencia = item.mcj_Secuencia;
                                              

                       lstRpt.Add(infoRpt);
                   }

               }

               return lstRpt;
           }
           catch (Exception ex)
           {
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "","", "", "", "", "", "", DateTime.Now);
               MensajeError = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_Rpt015_Data) };


           }
       }


    }
}
