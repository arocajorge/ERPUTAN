using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Compras
{
   public class XCOMP_NATU_Rpt004_Data
    {
       public List<XCOMP_NATU_Rpt004_Info> consultar_data
          (int IdEmpresa, int IdSucursal, decimal IdProveedorIni, decimal IdProveedorFin, DateTime FechaIni, DateTime FechaFin,decimal IdProductoIni, decimal IdProductoFin, ref string mensaje)
       {
           try
           {

               List<XCOMP_NATU_Rpt004_Info> listadatos = new List<XCOMP_NATU_Rpt004_Info>();

               using (EntitiesCompras_natu_rpt EIngresoCompras = new EntitiesCompras_natu_rpt())
               {
                   double tot = 0;

                   FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                   FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                   var select = from h in EIngresoCompras.vwCOMP_NATU_Rpt004
                                where
                                    //h.IdCentroCosto.Contains(IdCentroCosto)
                                    //&& h.IdCentroCosto_sub_centro_costo.Contains(IdCentroCosto_sub_centro_costo)
                                    //&& 
                                h.IdProducto >=IdProductoIni && h.IdProducto <= IdProductoFin &&
                                h.IdProveedor >= IdProveedorIni && h.IdProveedor <= IdProveedorFin
                                && h.Fecha_oc <= FechaFin
                                && h.Fecha_oc >= FechaIni
                                && h.IdEmpresa == IdEmpresa
                                && h.IdSucursal == IdSucursal
                                select h;
                   foreach (var item in select)
                   {
                       XCOMP_NATU_Rpt004_Info itemInfo = new XCOMP_NATU_Rpt004_Info();
                       itemInfo.IdEmpresa = item.IdEmpresa;
                       itemInfo.IdSucursal = item.IdSucursal;
                       itemInfo.IdOrdenCompra = item.IdOrdenCompra;
                       itemInfo.IdProveedor = item.IdProveedor;
                       itemInfo.Tipo = item.Tipo;
                       itemInfo.IdTerminoPago = item.IdTerminoPago;
                       itemInfo.Plazo = item.Plazo;
                       itemInfo.Fecha_oc = Convert.ToDateTime(item.Fecha_oc.ToShortDateString());
                       itemInfo.Observacion_oc = item.Observacion_oc;
                       itemInfo.Estado = item.Estado;
                       //itemInfo.EstadoRecepcion = item.EstadoRecepcion;
                     //  itemInfo.Total = Convert.ToDouble(item.Total);
                       itemInfo.nom_proveedor = item.nom_proveedor;
                       itemInfo.nom_sucursal = item.nom_sucursal;
                       itemInfo.Termino_pago = item.Termino_pago;
                       itemInfo.FechaDesde_Fil = FechaIni;
                       itemInfo.FechaHasta_Fil = FechaFin;

                       itemInfo.IdProducto=item.IdProducto;
                       itemInfo.Cantidad=item.Cantidad;
                       itemInfo.Precio=item.Precio;

                       itemInfo.Subtotal=item.Subtotal;
                       itemInfo.Iva=item.Iva;
                       itemInfo.nom_producto = item.nom_producto;
                       itemInfo.do_observacion = item.do_observacion;
                     
                       //tot = tot + Convert.ToDouble(item.Total);
                       itemInfo.total = item.Total;
                       listadatos.Add(itemInfo);
                   }
               }
               return listadatos;
           }
           catch (Exception ex)
           {
               return new List<XCOMP_NATU_Rpt004_Info>();
           }
       }
    }
}
