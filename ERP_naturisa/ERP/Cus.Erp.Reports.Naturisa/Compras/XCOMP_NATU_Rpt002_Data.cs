using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_NATU_Rpt002_Data
    {
        public List<XCOMP_NATU_Rpt002_Info> Consultar_Data(int IdEmpresa, int IdSucursal, Decimal IdProveedorIni, Decimal IdProveedorFin
            , DateTime Fecha_OC_Ini, DateTime Fecha_OC_Fin, ref String mensaje)
        {
            try
            {
                List<XCOMP_NATU_Rpt002_Info> Listadedatos = new List<XCOMP_NATU_Rpt002_Info>();

                DateTime FechaIni = Convert.ToDateTime(Fecha_OC_Ini.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(Fecha_OC_Fin.ToShortDateString());
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

                

                using (EntitiesCompras_natu_rpt SolicitudCompra = new EntitiesCompras_natu_rpt())
                {
                    var select = from k in SolicitudCompra.vwCOMP_NATU_Rpt002
                                 where k.IdEmpresa == IdEmpresa
                                 && k.IdSucursal == IdSucursal
                                 && k.IdProveedor >= ProveIni && k.IdProveedor <= ProveFin
                                 && k.fecha >= FechaIni && k.fecha <= FechaFin
                                 select k;

                    foreach (var item in select)
                    {
                        XCOMP_NATU_Rpt002_Info itemInfo = new XCOMP_NATU_Rpt002_Info();
                        itemInfo.do_Cantidad = item.do_Cantidad;
                        itemInfo.do_precioCompra = Convert.ToDouble(item.do_precioCompra);
                        itemInfo.do_subtotal = Convert.ToDouble(item.do_subtotal);
                        itemInfo.em_nombre = item.em_nombre;
                        itemInfo.fecha = Convert.ToDateTime(item.fecha.ToShortDateString());
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdOrdenCompra = Convert.ToDecimal(item.IdOrdenCompra);
                        itemInfo.IdProducto = Convert.ToDecimal(item.IdProducto);
                        itemInfo.IdProducto_OC = Convert.ToDecimal(item.IdProducto_OC);
                        itemInfo.IdSolicitudCompra = item.IdSolicitudCompra;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdSucursalOC = Convert.ToInt32(item.IdSucursalOC);
                        itemInfo.NomProducto = item.NomProducto;
                        itemInfo.NumDocumento = itemInfo.NumDocumento;
                        itemInfo.do_Cantidad_OC = Convert.ToDouble(item.do_Cantidad_OC);
                        itemInfo.Secuencia = item.Secuencia;
                        itemInfo.Secuencia_OC = Convert.ToInt32(item.Secuencia_OC);
                        itemInfo.IdProveedor = Convert.ToDecimal (item.IdProveedor);
                        itemInfo.Nom_proveedor = item.Nom_proveedor;
                        itemInfo.NombProveedorfin = SNombreProveedorFiltro;
                        itemInfo.NombProveedorIni = SNombreProveedorFiltro;
                        itemInfo.dm_cantidad_Inv = item.dm_cantidad_Inv;
                        itemInfo.Saldo_x_Ing_a_Inv = item.Saldo_x_Ing_a_Inv;
                        itemInfo.IdPunto_cargo = Convert.ToInt32(item.IdPunto_cargo);
                        itemInfo.nom_punto_cargo = item.nom_punto_cargo;

  

                        itemInfo.Su_Descripcion = item.Su_Descripcion;
        

                        Listadedatos.Add(itemInfo);


                    }

                }
                return Listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XCOMP_NATU_Rpt002_Info>();

            }

        }

                        

    }
}
