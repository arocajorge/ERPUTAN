using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Bancos
{
    public  class XBAN_Rpt011_Data
    {

       public List<XBAN_Rpt011_Info> Get_Data_Reporte(int IdEmpresa, int IdBanco,int IdConciliacion, ref string MensajeError)
       {
           try
           {
               List<XBAN_Rpt011_Info> lstRpt = new List<XBAN_Rpt011_Info>();

               double? Saldo = 0;
               Boolean PrimerRegistro = true;


               using (EntitiesBancos_Reporte_Ge listado = new EntitiesBancos_Reporte_Ge())
               {
                   var select = from q in listado.spBAN_Rpt011(IdEmpresa, IdBanco, IdConciliacion)
                                select q;

                   foreach (var item in select)
                   {
                       if (PrimerRegistro)
                       {
                           Saldo = (item.SaldoInicial == null) ? 0 : Convert.ToDouble(item.SaldoInicial);
                           PrimerRegistro = false;
                       }
                       XBAN_Rpt011_Info infoRpt = new XBAN_Rpt011_Info();                       
                       infoRpt.IdEmpresa=item.IdEmpresa;
                       infoRpt.IdConciliacion=item.IdConciliacion;
                       infoRpt.IdBanco=item.IdBanco;
                       infoRpt.IdPeriodo = Convert.ToInt32(item.IdPeriodo);
                       infoRpt.nom_banco=item.nom_banco;
                       infoRpt.ba_Num_Cuenta=item.ba_Num_Cuenta;
                       infoRpt.IdCtaCble=item.IdCtaCble;
                       infoRpt.Fecha=item.Fecha == null ? DateTime.Now : (DateTime)item.Fecha;
                       infoRpt.CodTipoCbte=item.CodTipoCbte;
                       infoRpt.Tipo_Cbte=item.Tipo_Cbte;
                       infoRpt.IdCbteCble=item.IdCbteCble;
                       infoRpt.IdTipocbte=item.IdTipoCbte;
                       infoRpt.SecuenciaCbte=item.SecuenciaCbte;
                       infoRpt.Valor=item.Valor;
                       infoRpt.Observacion=item.Observacion;
                       infoRpt.Cheque=item.Cheque;
                       infoRpt.Titulo_grupo=item.Titulo_grupo;
                       infoRpt.referencia=item.referencia;
                       infoRpt.ruc_empresa=item.ruc_empresa;
                       infoRpt.nom_empresa = item.nom_empresa;
                       infoRpt.GiradoA = item.GiradoA;
                       infoRpt.Total_Conciliado = item.Total_Conciliado;
                       infoRpt.IdTipoFlujo = item.IdTipoFlujo;
                       infoRpt.nom_tipo_flujo = item.nom_tipo_flujo;
                       infoRpt.SaldoBanco_EstCta = item.SaldoBanco_EstCta;
                       infoRpt.FechaIni = item.FechaIni;
                       infoRpt.FechaFin = item.FechaFin;
                       infoRpt.SaldoFinal = item.SaldoFinal;
                       infoRpt.SaldoInicial = item.SaldoInicial;
                       lstRpt.Add(infoRpt);
                   }
               }
               return lstRpt;
           }
           catch (Exception ex)
           {
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
