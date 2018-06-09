using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
  public  class XBAN_Rpt009_Data
    {
        string mensaje = "";
        string MensajeError = "";


        public List<XBAN_Rpt009_Info> get_ReporteSaldoBancos(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<XBAN_Rpt009_Info> lstRpt = new List<XBAN_Rpt009_Info>();

                using (EntitiesBancos_Reporte_Ge listado = new EntitiesBancos_Reporte_Ge())
                {
                    var select = from q in listado.spBAN_Rpt009(IdEmpresa, Fecha_ini, Fecha_fin)
                                 select q;

                    foreach (var item in select)
                    {
                        XBAN_Rpt009_Info infoRpt = new XBAN_Rpt009_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdCtaCble = item.IdCtaCble;
                        infoRpt.Saldo_anterior = item.Saldo_anterior;
                        infoRpt.Ingreso = item.Ingreso;
                        infoRpt.Egreso = item.Egreso;
                        infoRpt.Saldo_final = item.Saldo_final;
                        infoRpt.fecha_ini = item.fecha_ini;
                        infoRpt.fecha_fin = item.fecha_fin;
                        infoRpt.nom_Banco = item.nom_Banco;
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
