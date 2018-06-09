using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt001_Data
    {
        public List<XCAJ_Rpt001_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin)
        {

            try
            {

                List<XCAJ_Rpt001_Info> listadedatos = new List<XCAJ_Rpt001_Info>();
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());


                using (EntitiesCaja_General ListadoCaja = new EntitiesCaja_General())
                {


                    var select = from h in ListadoCaja.vwCAJ_Rpt001
                                 where h.IdEmpresa == idempresa
                                 && h.Fecha >= FechaIni && h.Fecha <= FechaFin
                                 select h;

                    foreach (var item in select)
                    {

                        XCAJ_Rpt001_Info itemInfo = new XCAJ_Rpt001_Info();


                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdCbteCble = item.IdCbteCble;
                        itemInfo.IdTipocbte = item.IdTipocbte;
                        itemInfo.Tipo_Cbte = item.Tipo_Cbte;
                        itemInfo.cod_caja = item.cod_caja;
                        itemInfo.Caja = item.Caja;
                        itemInfo.Sucursal = item.Sucursal;
                        itemInfo.Tipo = item.Tipo;
                        itemInfo.Beneficiario = item.Beneficiario;
                        itemInfo.Valor = item.Valor;
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.Tipo_Movi_Caja = item.Tipo_Movi_Caja;
                        itemInfo.IdCobro_tipo = item.IdCobro_tipo;
                        itemInfo.Banco = item.Banco;
                        itemInfo.Num_Documento = item.Num_Documento;
                        itemInfo.Observacion = item.Observacion;
                        itemInfo.IdCalendario = item.IdCalendario;
                        itemInfo.AnioFiscal = item.AnioFiscal;
                        itemInfo.IdMes = item.IdMes;
                        itemInfo.Mes = item.Mes;
                        itemInfo.Dia = item.Dia;


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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt001_Data) };
            }


        }
    }
}
