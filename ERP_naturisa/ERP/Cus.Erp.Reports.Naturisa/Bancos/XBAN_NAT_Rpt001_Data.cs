using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.Naturisa.Bancos
{
   public class XBAN_NAT_Rpt001_Data
    {

       public List<XBAN_NAT_Rpt001_Info> Get_Data_Reporte(int IdEmpresa, int IdTipocbte, decimal IdCbteCble, ref string MensajeError)
       {
           try
           {
               List<XBAN_NAT_Rpt001_Info> lstRpt = new List<XBAN_NAT_Rpt001_Info>();

               using (EntitiesBancos_naturisa_rpt listado = new EntitiesBancos_naturisa_rpt())
               {
                   var lst_select = from q in listado.vwBAN_NAT_Rpt001
                                where q.IdEmpresa == IdEmpresa
                                && q.IdCbteCble == IdCbteCble
                                && q.IdTipocbte == IdTipocbte
                                select q;

                   

                   foreach (var item in lst_select)
                   {

                       XBAN_NAT_Rpt001_Info infoRpt = new XBAN_NAT_Rpt001_Info();

                       infoRpt.IdEmpresa = item.IdEmpresa;
                       infoRpt.nom_empresa = item.nom_empresa;
                       infoRpt.ruc_empresa = item.ruc_empresa;
                       infoRpt.IdCbteCble = item.IdCbteCble;
                       infoRpt.IdTipocbte = item.IdTipocbte;
                       infoRpt.IdBanco = item.IdBanco;
                       infoRpt.nom_banco = item.nom_banco;
                       infoRpt.ba_Num_Cuenta = item.ba_Num_Cuenta;
                       infoRpt.IdCtaCble_ban = item.IdCtaCble_ban;
                       infoRpt.cb_Fecha = item.cb_Fecha;
                       infoRpt.IdPeriodo = item.IdPeriodo;
                       infoRpt.cb_Observacion = item.cb_Observacion;
                       infoRpt.cb_Valor = item.cb_Valor;
                       infoRpt.Estado = item.Estado;
                       infoRpt.ValorEnLetras = item.ValorEnLetras;                       
                       infoRpt.IdCtaCble = item.IdCtaCble;
                       infoRpt.nom_cuenta = item.nom_cuenta;
                       infoRpt.debito = item.debito;
                       infoRpt.cb_Cheque = item.cb_Cheque;
                       infoRpt.credito = item.credito;
                       infoRpt.dc_Observacion = item.dc_Observacion;
                       infoRpt.nom_punto_cargo = item.nom_punto_cargo;
                       infoRpt.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                       infoRpt.clave_cta = item.clave_cta;
                       infoRpt.cb_giradoA = item.cb_giradoA;
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
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_NAT_Rpt001_Data) };
           }
       }



    }
}
