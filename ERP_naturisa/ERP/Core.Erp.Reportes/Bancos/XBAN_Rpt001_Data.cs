using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Core.Erp.Reportes.Bancos
{
   public  class XBAN_Rpt001_Data
    {

       public List<XBAN_Rpt001_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin)
       {

           try
           {

               List<XBAN_Rpt001_Info> listadedatos = new List<XBAN_Rpt001_Info>();
               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());


               using (EntitiesBancos_Reporte_Ge ListadoCbte = new EntitiesBancos_Reporte_Ge())
               {


                   var select = from h in ListadoCbte.vwBAN_Rpt001
                                where h.IdEmpresa == idempresa
                                && h.Fch_Cbte >= FechaIni && h.Fch_Cbte <= FechaFin
                                select h;

                   foreach (var item in select)
                   {

                       XBAN_Rpt001_Info itemInfo = new XBAN_Rpt001_Info();


                       itemInfo.IdEmpresa = item.IdEmpresa;
                       itemInfo.Tipo_Cbte = item.Tipo_Cbte;
                       itemInfo.Num_Cbte = item.Num_Cbte;
                       itemInfo.IdBanco = item.IdBanco;
                       itemInfo.Banco = item.Banco;
                       itemInfo.Fch_Cbte = item.Fch_Cbte;
                       itemInfo.Observacion = item.Observacion;
                       itemInfo.Valor = item.Valor;
                       itemInfo.Cheque = item.Cheque;
                       itemInfo.Chq_Girado_A = item.Chq_Girado_A;
                       itemInfo.IdTipoFlujo = item.IdTipoFlujo;
                       itemInfo.Tipo_Flujo = item.Tipo_Flujo;
                       itemInfo.IdTipoNota = item.IdTipoNota;
                       itemInfo.Tipo_Nota = item.Tipo_Nota;
                       itemInfo.Fch_PostFechado = item.Fch_PostFechado;
                       itemInfo.Es_Chq_Impreso = item.Es_Chq_Impreso;
                       itemInfo.Fch_Chq = item.Fch_Chq;
                       itemInfo.Cta_Cble_Banco = item.Cta_Cble_Banco;
                       itemInfo.IdCalendario = item.IdCalendario;
                       itemInfo.AnioFiscal = item.AnioFiscal;
                       itemInfo.NombreMes = item.NombreMes;
                       itemInfo.NombreCortoFecha = item.NombreCortoFecha;
                       itemInfo.IdMes = item.IdMes;
                       itemInfo.pc_Cuenta = item.pc_Cuenta;


                       listadedatos.Add(itemInfo);

                   }
               }
               return listadedatos;
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
