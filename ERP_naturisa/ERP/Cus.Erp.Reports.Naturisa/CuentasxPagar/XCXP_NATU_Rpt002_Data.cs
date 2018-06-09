using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt002_Data
    {
        public List<XCXP_NATU_Rpt002_Info> consultar_data
            (int IdEmpresa, Decimal IdProveedorIni, Decimal IdProveedorFin, DateTime Fecha_Ini, DateTime Fecha_Fin, int IdClaseProveedorIni, int IdClaseProveedorFin, bool Filtrar_fecha_emi, ref String mensaje)
        {
            try
            {
                List<XCXP_NATU_Rpt002_Info> listadedatos = new List<XCXP_NATU_Rpt002_Info>();


                DateTime FechaIni = Convert.ToDateTime(Fecha_Ini.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(Fecha_Fin.ToShortDateString());


                string SNombreProveedorFiltro = "";
                decimal ProveIni = 0;
                decimal ProveFin = 0;

                if (IdProveedorIni == 0 && IdProveedorFin == 0)
                {
                    ProveIni = 1;
                    ProveFin = 900000;
                    SNombreProveedorFiltro = "TODOS";
                }
                else
                {
                    ProveIni = IdProveedorIni;
                    ProveFin = IdProveedorFin;
                    SNombreProveedorFiltro = "POR RANGO DE PROVEEDOR";
                }


                using (EntitiesCXP_Rpt_Naturisa saldosdeproveedor = new EntitiesCXP_Rpt_Naturisa())
                {
                    IQueryable<vwCXP_NATU_Rpt002> select;


                    if (Filtrar_fecha_emi)
                    {
                        select = from h in saldosdeproveedor.vwCXP_NATU_Rpt002
                                                               where h.IdEmpresa == IdEmpresa
                                                               && h.IdProveedor >= ProveIni && h.IdProveedor <= ProveFin
                                                               && h.Fecha >= FechaIni && h.Fecha <= FechaFin
                                                               && IdClaseProveedorIni <= h.IdClaseProveedor && h.IdClaseProveedor <= IdClaseProveedorFin
                                                               && (h.Saldo_x_pagar > 0 || h.Saldo_x_pagar < 0)
                                                               select h;    
                    }else
                        select = from h in saldosdeproveedor.vwCXP_NATU_Rpt002
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdProveedor >= ProveIni && h.IdProveedor <= ProveFin
                                 && h.co_FechaFactura_vct >= FechaIni && h.co_FechaFactura_vct <= FechaFin
                                 && IdClaseProveedorIni <= h.IdClaseProveedor && h.IdClaseProveedor <= IdClaseProveedorFin
                                 && (h.Saldo_x_pagar > 0 || h.Saldo_x_pagar < 0)
                                 select h;    
                    


                    foreach (var item in select)
                    {
                        XCXP_NATU_Rpt002_Info itemInfo = new XCXP_NATU_Rpt002_Info();
                        itemInfo.co_FechaFactura_vct = item.co_FechaFactura_vct;
                        itemInfo.cod_tipo_doc = item.cod_tipo_doc;
                        itemInfo.Documento = item.Documento;
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        itemInfo.IdProveedor = item.IdProveedor;
                        itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        itemInfo.Iva = item.Iva;
                        itemInfo.Nom_Proveedor = item.Nom_Proveedor;
                        itemInfo.Observacion = item.Observacion;
                        itemInfo.Saldo_x_pagar = item.Saldo_x_pagar;
                        itemInfo.SubTotal = item.SubTotal;
                        itemInfo.tipo_doc = item.tipo_doc;
                        itemInfo.Total = item.Total;
                        itemInfo.Total_a_Pagar = item.Total_a_Pagar;
                        itemInfo.IdClaseProveedor = item.IdClaseProveedor;
                        itemInfo.descripcion_clas_prove = item.descripcion_clas_prove;
                        item.IdOrdenPago = item.IdOrdenPago;
                        itemInfo.IdPersona = item.IdPersona;


                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }

            catch (Exception ex)
            {
                return new List<XCXP_NATU_Rpt002_Info>();
            }
        }

        public enum eEstadosFiltro
        {
            Todos = 0,
            Pendiente = 1,
            Cancelado
        }
    }
}
