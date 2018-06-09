using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt005_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XCXC_Rpt005_Info> get_ImpresionCobro_x_Venta(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble, string IdTipoDoc)
        {
            try
            {
                List<XCXC_Rpt005_Info> lstRprt = new List<XCXC_Rpt005_Info>();

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.vwCXC_Rpt005
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal == IdSucursal && q.IdBodega_Cbte == IdBodega
                                 && q.IdCbte_vta_nota == IdCbteCble && q.dc_TipoDocumento == IdTipoDoc
                                 select q;
                    
                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt005_Info infoRpt = new XCXC_Rpt005_Info();

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
                        infoRpt.cr_fechaCobro = item.cr_fechaCobro;
                        infoRpt.cr_observacion = item.cr_observacion;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.IdUsuario = item.IdUsuario;
                        infoRpt.dc_TipoDocumento = item.dc_TipoDocumento;
                        infoRpt.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_Cbte);
                        infoRpt.IdCbte_vta_nota = item.IdCbte_vta_nota;
                        infoRpt.dc_ValorPago = item.dc_ValorPago;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.pe_telefonoCasa = item.pe_telefonoCasa;
                        infoRpt.pe_direccion = item.pe_direccion;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.IdBanco = Convert.ToInt32(item.IdBanco);
                        infoRpt.IdCaja = item.IdCaja;
                        infoRpt.Documento_Cobrado = item.Documento_Cobrado;
                        infoRpt.Logo = Cbt.em_logo_Image;

                        lstRprt.Add(infoRpt);
                    }
                }
                return lstRprt;
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt005_Info>();
            }
        }
    }
}
