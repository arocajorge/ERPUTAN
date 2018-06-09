using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt001_Data
    {
        string mensaje = "";
        public List<XCXC_Rpt001_Info> getDatosCobros(int IdEmpresa, int IdSucursal, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                List<XCXC_Rpt001_Info> lstReport = new List<XCXC_Rpt001_Info>();
                fechaIni = Convert.ToDateTime(fechaIni.ToShortDateString());
                fechaFin = Convert.ToDateTime(fechaFin.ToShortDateString());

                int IdSucursalIni = (IdSucursal == 0) ? 0 : IdSucursal;
                int IdSucursalFin = (IdSucursal == 0) ? 9999999 : IdSucursal;


                using (Entities_CuentasxCobrar ListadoCobro = new Entities_CuentasxCobrar())
                {
                    var select = from q in ListadoCobro.vwCXC_Rpt001
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.cr_fecha >= fechaIni && q.cr_fecha <= fechaFin 
                                 select q;

                    foreach (var item in select)
                    {

                        XCXC_Rpt001_Info itemInfo = new XCXC_Rpt001_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdCobro = item.IdCobro;
                        itemInfo.IdCobro_a_aplicar = Convert.ToDecimal(item.IdCobro_a_aplicar);
                        itemInfo.cr_Codigo = item.cr_Codigo;
                        itemInfo.IdCobro_tipo = item.IdCobro_tipo;
                        itemInfo.IdCliente = item.IdCliente;
                        itemInfo.nombreCliente = item.nombreCliente;
                        itemInfo.cr_fecha = item.cr_fecha;
                        itemInfo.IdCalendario = item.IdCalendario;
                        itemInfo.NombreMes = item.NombreMes;
                        itemInfo.NombreCortoFecha = item.NombreCortoFecha;
                        itemInfo.AnioFiscal = Convert.ToInt32(item.AnioFiscal);
                        itemInfo.cr_TotalCobro = item.cr_TotalCobro;
                        itemInfo.cr_fechaDocu = item.cr_fechaDocu;
                        itemInfo.cr_fechaCobro = item.cr_fechaCobro;
                        itemInfo.cr_observacion = item.cr_observacion;
                        itemInfo.Referencia = item.Referencia;
                        itemInfo.numDocumento = item.numDocumento;
                        itemInfo.IdTipoNotaCredito = item.IdTipoNotaCredito.ToString();


                        lstReport.Add(itemInfo);

                    }
                }
                return lstReport;


            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);    
                return new List<XCXC_Rpt001_Info>();
            }
        }

    }
}
