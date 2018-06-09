using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Bancos
{
   public  class XBAN_Rpt010_Data
    {

       public List<XBAN_Rpt010_Info> Get_Data_Reporte(int IdEmpresa, int IdBanco, DateTime FechaIni, DateTime FechaFin, ref string MensajeError)
       {
           try
           {
               List<XBAN_Rpt010_Info> lstRpt = new List<XBAN_Rpt010_Info>();

               using (EntitiesBancos_Reporte_Ge listado = new EntitiesBancos_Reporte_Ge())
               {
                   var select = from q in listado.spBAN_Rpt010(IdEmpresa,IdBanco,FechaIni,FechaFin)
                                select q;


                   foreach (var item in select)
                   {
                       XBAN_Rpt010_Info info = new XBAN_Rpt010_Info();

                       info.IdEmpresa = item.IdEmpresa;
                       info.IdTipoCbte = item.IdTipoCbte;
                       info.IdCbteCble = item.IdCbteCble;
                       info.secuencia = item.secuencia;
                       info.cb_Fecha = item.cb_Fecha;
                       info.cb_Observacion = item.cb_Observacion;
                       info.dc_Observacion = item.dc_Observacion;
                       info.Observacion_girado_a = item.Observacion_girado_a;
                       info.Referencia = item.Referencia;
                       info.cb_giradoA = item.cb_giradoA;
                       info.CodTipoCbte = item.CodTipoCbte;
                       info.tc_TipoCbte = item.tc_TipoCbte;
                       info.IdCtaCble = item.IdCtaCble;
                       info.pc_Cuenta = item.pc_Cuenta;
                       info.Saldo_inicial = item.Saldo_inicial;
                       info.Debe = item.Debe;
                       info.Haber = item.Haber;
                       info.Saldo = item.Saldo;
                       
                       
                       info.Origen = item.Origen;

                       lstRpt.Add(info);
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
