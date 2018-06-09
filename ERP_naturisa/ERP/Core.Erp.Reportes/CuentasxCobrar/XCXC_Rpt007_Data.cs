using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt007_Data
    {
        string mensaje = "";
        tb_Empresa_Data empresaData = new tb_Empresa_Data();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();

        public List<XCXC_Rpt007_Info> get_ReporteCarteraVencida(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdCliente, DateTime FechaCorte, bool solo_cbtes_con_saldo)
        {
            try
            {
                List<XCXC_Rpt007_Info> lstRpt = new List<XCXC_Rpt007_Info>();

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.spCXC_Rpt007(IdEmpresa, IdSucursalIni, IdSucursalFin, IdCliente, FechaCorte, solo_cbtes_con_saldo)
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt007_Info infoRpt = new XCXC_Rpt007_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdBodega = Convert.ToInt32(item.IdBodega);
                        infoRpt.IdCbteVta = item.IdCbteVta;
                        infoRpt.vt_tipoDoc = item.vt_tipoDoc;
                        infoRpt.IdCobro_tipo = item.IdCobro_tipo;
                        infoRpt.DiasVencidos = Convert.ToInt32(item.DiasVencidos);
                        infoRpt.IdEstadoCobro = item.IdEstadoCobro;
                        infoRpt.numDocumento = item.numDocumento;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.vt_fecha = item.vt_fecha;
                        infoRpt.vt_fech_venc = Convert.ToDateTime(item.vt_fech_venc);
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.Monto = Convert.ToDouble(item.Monto);
                        infoRpt.TotalCobrado = Convert.ToDouble(item.TotalCobrado);
                        infoRpt.Valor_Vencido = Convert.ToDouble(item.Valor_Vencido);
                        infoRpt.Valor_x_Vencer = Convert.ToDouble(item.Valor_x_Vencer);
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.Tipo = item.Tipo;

                        infoRpt.Logo = Cbt.em_logo_Image;

                        infoRpt.Documento_Grupo = item.Documento_Grupo;

                        lstRpt.Add(infoRpt);
                    }

                }

                return lstRpt;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

            

        }


    }
}
