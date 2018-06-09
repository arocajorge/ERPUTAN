using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt012_Data
    {
        public List<XCXP_Rpt012_Info> consultar_data(int IdEmpresa, decimal ProveedorIni, decimal ProveedorFin, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                List<XCXP_Rpt012_Info> listadedatos = new List<XCXP_Rpt012_Info>();

                using (EntitiesCXP_General facturaProvee = new EntitiesCXP_General())
                {
                    var select = from h in facturaProvee.vwCXP_Rpt012
                                 where h.IdEmpresa == IdEmpresa
                                 && h.Fecha >= FechaIni && h.Fecha <= FechaFin
                                 && h.IdProveedor >= ProveedorIni && h.IdProveedor <= ProveedorFin
                                 select h;

                    foreach (var item in select)
                    {
                        XCXP_Rpt012_Info itemInfo = new XCXP_Rpt012_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        itemInfo.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        itemInfo.Documento = item.Documento.ToString();
                        itemInfo.nom_tipo_doc = item.nom_tipo_doc.ToString();
                        itemInfo.cod_tipo_doc = item.cod_tipo_doc.ToString();
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.IdProveedor = item.IdProveedor;
                        itemInfo.nom_proveedor = item.nom_proveedor;
                        itemInfo.Observacion = item.Observacion;
                        itemInfo.ValorAPagar = item.ValorAPagar == null ? 0 : (double)item.ValorAPagar;
                        itemInfo.TotalPagado = item.TotalPagado == null ? 0 : (double)item.TotalPagado;
                        itemInfo.Saldo = item.Saldo == null ? 0 : (double)item.Saldo;
                        itemInfo.TipoRegistro = item.TipoRegistro;
                        itemInfo.IdCalendario = item.IdCalendario;
                        itemInfo.NombreCortoFecha = item.NombreCortoFecha;
                        itemInfo.NombreMes = item.NombreMes;
                        itemInfo.IdMes = item.IdMes;
                        itemInfo.AnioFiscal = item.AnioFiscal;

                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;

            }
            catch (Exception ex)
            {

                return new List<XCXP_Rpt012_Info>();
            }
        }
    }
}
