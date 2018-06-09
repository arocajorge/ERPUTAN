using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt006_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XCXC_Rpt006_Info> get_RptCobros(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni,
            decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta,List<string> ListIdTipoCobro, string TipoFecha)
        {
            try
            {
                List<XCXC_Rpt006_Info> lstRpt = new List<XCXC_Rpt006_Info>();
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaHasta = Convert.ToDateTime(FechaHasta.ToShortDateString());

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {

                    var select = from q in listado.vwCXC_Rpt006
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.IdCliente >= IdClienteIni && q.IdCliente <= IdClienteFin
                                 && ListIdTipoCobro.Contains(q.IdCobro_tipo)
                                 select q;


                    if (TipoFecha == "x_fechacanc")
                       select = select.Where(q => q.cr_fechaCobro >= FechaIni && q.cr_fechaCobro <= FechaHasta);
                    else
                       select = select.Where(q => q.cr_fecha >= FechaIni && q.cr_fecha <= FechaHasta);

                   


                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt006_Info infoRpt = new XCXC_Rpt006_Info();

                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdCobro = item.IdCobro;
                        infoRpt.IdCobro_tipo = item.IdCobro_tipo;
                        infoRpt.cr_Banco = item.cr_Banco;
                        infoRpt.cr_cuenta = item.cr_cuenta;
                        infoRpt.cr_NumDocumento = item.cr_NumDocumento;
                        infoRpt.cr_Tarjeta = item.cr_Tarjeta;
                        infoRpt.cr_propietarioCta = item.cr_propietarioCta;
                        infoRpt.cr_TotalCobro = item.cr_TotalCobro;
                        infoRpt.cr_fecha = item.cr_fecha;
                        infoRpt.cr_fechaDocu = item.cr_fechaDocu;
                        infoRpt.cr_fechaCobro = item.cr_fechaCobro;
                        infoRpt.cr_observacion = item.cr_observacion;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.IdUsuario = item.IdUsuario;
                        infoRpt.dc_TipoDocumento = item.dc_TipoDocumento;
                        infoRpt.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_Cbte);
                        infoRpt.IdCbte_vta_nota = Convert.ToDecimal(item.IdCbte_vta_nota);
                        infoRpt.dc_ValorPago = Convert.ToDouble(item.dc_ValorPago);
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.pe_telefonoCasa = item.pe_telefonoCasa;
                        infoRpt.pe_direccion = item.pe_direccion;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.IdBanco = Convert.ToInt32(item.IdBanco);
                        infoRpt.IdCaja = item.IdCaja;
                        infoRpt.Documento_Cobrado = item.Documento_Cobrado;
                        infoRpt.Logo = Cbt.em_logo_Image;

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
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new List<XCXC_Rpt006_Info>();
            }
        }

    }
}
