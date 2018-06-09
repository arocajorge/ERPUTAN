using Core.Erp.Reportes.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt005_Data
    {
        public List<XBAN_Rpt005_Info> GetData(int IdEmpresa, decimal IdComprobante, int IdTipoComprobante, ref string MensajeError)
        {
            try
            {

                List<XBAN_Rpt005_Info> Result = new List<XBAN_Rpt005_Info>();
                using (EntitiesBancos_Reporte_Ge conexion = new EntitiesBancos_Reporte_Ge())
                {

                    var Select = from q in conexion.vwBAN_Rpt005
                              where q.IdEmpresa == IdEmpresa && q.IdCbteCble == IdComprobante && q.IdTipocbte == IdTipoComprobante
                              select q;
                    foreach (var item in Select)
                        {
                        XBAN_Rpt005_Info infoRpt = new XBAN_Rpt005_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdCbteCble = item.IdCbteCble;
                        infoRpt.IdTipocbte = item.IdTipocbte;
                        infoRpt.Cod_Cbtecble = item.Cod_Cbtecble;
                        infoRpt.cb_Observacion = item.cb_Observacion;
                        infoRpt.cb_secuencia = item.cb_secuencia;
                        infoRpt.cb_Valor = item.cb_Valor;
                        infoRpt.cb_Cheque = item.cb_Cheque;
                        infoRpt.cb_ChequeImpreso = item.cb_ChequeImpreso;
                        infoRpt.cb_FechaCheque = item.cb_FechaCheque;
                        infoRpt.Fecha_Transac = item.Fecha_Transac;
                        infoRpt.Estado = item.Estado;
                        infoRpt.cb_giradoA = item.cb_giradoA;
                        infoRpt.cb_ciudadChq = item.cb_ciudadChq;
                        infoRpt.CodTipoCbteBan = item.CodTipoCbteBan;
                        infoRpt.cb_Fecha = item.cb_Fecha;
                        infoRpt.con_Fecha = item.con_Fecha;
                        infoRpt.con_Valor = item.con_Valor;
                        infoRpt.con_Observacion = item.con_Observacion;
                        infoRpt.con_IdCbteCble = item.con_IdCbteCble;
                        infoRpt.IdCtaCble = item.IdCtaCble;
                        infoRpt.pc_Cuenta = item.pc_Cuenta	;
                        infoRpt.ValorEnLetras=item.ValorEnLetras;
                        infoRpt.dc_Valor = item.dc_Valor;
                        infoRpt.nom_ciudad = item.nom_ciudad;
                        if (infoRpt.dc_Valor < 0)
                        {
                            infoRpt.dc_ValorHaber = infoRpt.dc_Valor * -1;
                        }
                        else
                        {
                            infoRpt.dc_ValorDebe = infoRpt.dc_Valor;
                        }

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
