using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt002_Data
    {
        public List<XCXP_Rpt002_Info> consultar_data
            (int IdEmpresa, Decimal IdProveedor, DateTime Fecha_Ini, DateTime Fecha_Fin, int IdClaseProveedorIni, int IdClaseProveedorFin, ref String mensaje)
        {
            try
            {
                List<XCXP_Rpt002_Info> listadedatos = new List<XCXP_Rpt002_Info>();

                DateTime FechaIni = Convert.ToDateTime(Fecha_Ini.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(Fecha_Fin.ToShortDateString());

                string SNombreProveedorFiltro = "";
                int IdClaseIni = 0;
                int IdClaseFin = 0;

                if (IdClaseProveedorIni == 0 && IdClaseProveedorFin == 0)
                {
                    IdClaseIni = 1;
                    IdClaseFin = 900000;
                    SNombreProveedorFiltro = "TODOS";
                }
                else
                {
                    IdClaseIni = IdClaseProveedorIni;
                    IdClaseFin = IdClaseProveedorFin;
                    SNombreProveedorFiltro = "POR CLASE DE PROVEEDOR";
                }
                using (EntitiesCXP_General EstadoResumido = new EntitiesCXP_General())
                {


                    var select = from h in EstadoResumido.vwCXP_Rpt002
                                 where h.IdEmpresa == IdEmpresa
                                 && h.Fecha >= FechaIni && h.Fecha <= FechaFin
                                 && h.IdClaseProveedor >= IdClaseIni && h.IdClaseProveedor <= IdClaseFin
                                 group h by new { h.IdEmpresa, h.IdProveedor,h.nom_proveedor,h.Ruc_Proveedor, h.IdClaseProveedor, h.nom_clase_proveedor}
                                     into grouping
                                     select new { grouping.Key, totaldebito = grouping.Sum(p => p.Valor_debe), totalcredito = grouping.Sum(p => p.Valor_Haber) };
                                
                                //select h;

                    foreach (var item in select)
                    {
                        XCXP_Rpt002_Info itemInfo = new XCXP_Rpt002_Info();
                        itemInfo.IdEmpresa = item.Key.IdEmpresa;
                        itemInfo.IdClaseProveedor = item.Key.IdClaseProveedor;
                        itemInfo.nom_clase_proveedor = item.Key.nom_clase_proveedor;
                        itemInfo.IdProveedor = item.Key.IdProveedor;
                        itemInfo.nom_proveedor = item.Key.nom_proveedor.Trim();
                        itemInfo.Ruc_Proveedor = item.Key.Ruc_Proveedor;
                        itemInfo.Valor_debe = item.totaldebito;
                        itemInfo.Valor_Haber = item.totalcredito;
                        listadedatos.Add(itemInfo);
                    }
                }
                
                return listadedatos.OrderBy(q=>q.nom_proveedor).ToList();
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt002_Info>();
            }
        }
    }
}
