using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt017_Data
    {
        public List<XCXC_Rpt017_Info> Get_lst_reporte(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XCXC_Rpt017_Info> Lista = new List<XCXC_Rpt017_Info>();

                using (Entities_CuentasxCobrar Context = new Entities_CuentasxCobrar())
                {
                    var lst = from q in Context.spCXC_Rpt017(IdEmpresa,FechaIni,FechaFin)
                                  select q;

                    foreach (var item in lst)
                    {
                        XCXC_Rpt017_Info info = new XCXC_Rpt017_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdCbte_vta_nota = item.IdCbte_vta_nota;
                        info.dc_TipoDocumento = item.dc_TipoDocumento;
                        info.vt_total = item.vt_total;
                        info.dc_ValorPago = item.dc_ValorPago;
                        info.Saldo = item.Saldo;
                        info.IdCliente = item.IdCliente;
                        info.IdPersona = item.IdPersona;
                        info.nom_Cliente = item.nom_Cliente;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.IdProvincia = item.IdProvincia;
                        info.IdCiudad = item.IdCiudad;
                        info.IdParroquia = item.IdParroquia;
                        info.pe_Naturaleza = item.pe_Naturaleza;
                        info.vt_NumFactura = item.vt_NumFactura;
                        info.vt_fecha = item.vt_fecha;
                        info.vt_fech_venc = item.vt_fech_venc;
                        info.ValorPago_mes = item.ValorPago_mes;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
