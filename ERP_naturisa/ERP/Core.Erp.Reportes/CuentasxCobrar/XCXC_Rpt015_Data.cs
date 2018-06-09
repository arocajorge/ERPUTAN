using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt015_Data
    {
        string mensaje = "";
        tb_Empresa_Data empresaData = new tb_Empresa_Data();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();

        public List<XCXC_Rpt015_Info> get_DetalleCarteraVencida(int IdEmpresa, int IdCliente, int IdSucursalIni, 
            int IdSucursalFin,DateTime fechaIni, DateTime fechaFin, int IdTipocliente)
        {
            try
            {
                int IdTipoclienteIni = (IdTipocliente == 0) ? 1 : IdTipocliente;
                int IdTipoclienteFin = (IdTipocliente == 0) ? 99999 : IdTipocliente;

                int IdClienteIni, IdClienteFin;

                IdClienteIni = (IdCliente == 0) ? 0 : IdCliente;
                IdClienteFin = (IdCliente == 0) ? 999999999 : IdCliente;

                List<XCXC_Rpt015_Info> lstRpt = new List<XCXC_Rpt015_Info>();

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.spCXC_Rpt015(IdEmpresa,IdSucursalIni,IdSucursalFin, fechaIni, fechaFin)
                                 where q.Idtipo_cliente >= IdTipoclienteIni && q.Idtipo_cliente <= IdTipoclienteFin
                                 && q.IdCliente >= IdClienteIni
                                 && q.IdCliente <= IdClienteFin
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt015_Info infoRpt = new XCXC_Rpt015_Info();

                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdBodega = item.IdBodega;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.CodCbteVta = item.CodCbteVta;
                        infoRpt.IdCbteVta = item.IdCbteVta;
                        infoRpt.CodCbteVta = item.CodCbteVta;
                        infoRpt.vt_tipoDoc = item.vt_tipoDoc;
                        infoRpt.vt_serie1 = item.vt_serie1;
                        infoRpt.vt_serie2 = item.vt_serie2;
                        infoRpt.vt_NumFactura = item.vt_NumFactura.ToString().PadLeft(9, '0');
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.Valor_Original = item.Valor_Original;
                        infoRpt.Total_Pagado = item.Total_Pagado;

                        infoRpt.Valor_x_Vencer = item.Valor_x_Vencer;
                        infoRpt.x_Vencer_1_30_Dias = item.x_Vencer_1_30_Dias;
                        infoRpt.x_Vencer_31_90_Dias = item.x_Vencer_31_90_Dias;
                        infoRpt.x_Vencer_91_180_Dias = item.x_Vencer_91_180_Dias;
                        infoRpt.x_Vencer_181_360_Dias = item.x_Vencer_181_360_Dias;
                        infoRpt.x_Vencer_Mayor_a_360Dias = item.x_Vencer_Mayor_a_360Dias;

                        infoRpt.Valor_Vencido = item.Valor_Vencido;
                        infoRpt.Vencido_1_30_Dias = item.Vencido_1_30_Dias;
                        infoRpt.Vencido_31_90_Dias = item.Vencido_31_90_Dias;
                        infoRpt.Vencido_91_180_Dias = item.Vencido_91_180_Dias;
                        infoRpt.Vencido_181_360_Dias = item.Vencido_181_360_Dias;
                        infoRpt.Vencido_Mayor_a_360Dias = item.Vencido_Mayor_a_360Dias;
                        infoRpt.Dias_Vencidos = item.Dias_Vencidos;
                        infoRpt.cr_fechaCobro = item.cr_fechaCobro;
                        infoRpt.Valor_cobrado = item.Valor_cobrado == null ? 0 : item.Valor_cobrado;
                        infoRpt.vt_fech_venc = item.vt_fech_venc;
                        infoRpt.vt_fecha = item.vt_fecha;
                        infoRpt.RazonSocial = Cbt.RazonSocial;
                        infoRpt.em_logo = Cbt.em_logo;
                        infoRpt.Total = (double)item.Total;
                        infoRpt.Telefono = item.pe_telefonoOfic;
                        infoRpt.Plazo = Convert.ToDecimal(item.Plazo);
                        infoRpt.Cod_Ciudad = item.Cod_Ciudad;
                        infoRpt.Cod_Parroquia = item.cod_parroquia;
                        infoRpt.Cod_Provincia = item.Cod_Provincia;

                        infoRpt.cod_entidad_dinardap= item.cod_entidad_dinardap;
                        infoRpt.Naturaleza = item.pe_Naturaleza;
                        infoRpt.IdTipoDocumento = item.IdTipoDocumento;
                        

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
                return new List<XCXC_Rpt015_Info>();
            }
        }        
    }
}
