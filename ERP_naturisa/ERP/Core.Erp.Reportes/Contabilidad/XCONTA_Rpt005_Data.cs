using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt005_Data
    {
        public List<XCONTA_Rpt005_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin)
        {

            try
            {

                List<XCONTA_Rpt005_Info> listadedatos = new List<XCONTA_Rpt005_Info>();
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());


                using (EntitiesContabilidadRptGeneral OEnti = new EntitiesContabilidadRptGeneral())
                {


                    var select = from h in OEnti.vwCONTA_Rpt005
                                 where h.IdEmpresa == idempresa
                                 && h.Fecha >= FechaIni && h.Fecha <= FechaFin
                                 select h;

                    foreach (var item in select)
                    {

                        XCONTA_Rpt005_Info itemInfo = new XCONTA_Rpt005_Info();


                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdTipoCbte = item.IdTipoCbte;
                        itemInfo.IdCbteCble = item.IdCbteCble;
                        itemInfo.IdPeriodo = item.IdPeriodo;
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.IdCtaCble = item.IdCtaCble;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.Valor = item.Valor;
                        itemInfo.Centro_costo = item.Centro_costo;
                        itemInfo.TipoCbte = item.TipoCbte;
                        itemInfo.nom_Cuenta = item.nom_Cuenta;
                        itemInfo.Naturaleza_cta = item.Naturaleza_cta;
                        itemInfo.IdCtaCblePadre = item.IdCtaCblePadre;
                        itemInfo.AnioFiscal = item.AnioFiscal;
                        itemInfo.IdMes = item.IdMes;
                        itemInfo.Mes = item.Mes;

                        listadedatos.Add(itemInfo);

                    }
                }

                return listadedatos;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }


        }
    }
}
