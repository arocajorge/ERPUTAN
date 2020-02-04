using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Compras
{
  public  class XCOMP_NATU_Rpt003_Data
    {
      public List<XCOMP_NATU_Rpt003_Info> consultar_data(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, decimal IdProveedor, decimal IdProducto, DateTime Fecha_ini, DateTime Fecha_fin, bool Mostrar_anuladas)
      {
          try
          {
              int IdSucursal_ini = IdSucursal;
              int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

              decimal IdProducto_ini = IdProducto;
              decimal IdProducto_fin = IdProducto == 0 ? 99999 : IdProducto;

              decimal IdProveedor_ini = IdProveedor;
              decimal IdProveedor_fin = IdProveedor == 0 ? 99999 : IdProveedor;

              decimal IdOrdenCompra_ini = IdOrdenCompra;
              decimal IdOrdenCompra_fin = IdOrdenCompra == 0 ? 99999 : IdOrdenCompra;

              Fecha_ini = Fecha_ini.Date;
              Fecha_fin = Fecha_fin.Date;

              string Estado = Mostrar_anuladas ? "" : "A";

              List<XCOMP_NATU_Rpt003_Info> listadedatos = new List<XCOMP_NATU_Rpt003_Info>();
              using (EntitiesCompras_natu_rpt ListadoOrdenCompra = new EntitiesCompras_natu_rpt())
              {
                  IQueryable<vwCOMP_NATU_Rpt003> lst;
                  
                      lst = from h in ListadoOrdenCompra.vwCOMP_NATU_Rpt003
                            where h.IdEmpresa == IdEmpresa
                            && IdSucursal_ini <= h.IdSucursal && h.IdSucursal <= IdSucursal_fin
                            && IdProducto_ini <= h.IdProducto && h.IdProducto <= IdProducto_fin
                            && IdProveedor_ini <= h.IdProveedor && h.IdProveedor <= IdProveedor_fin
                            && Fecha_ini <= h.oc_fecha && h.oc_fecha <= Fecha_fin
                            && IdOrdenCompra_ini <= h.IdOrdenCompra && h.IdOrdenCompra <= IdOrdenCompra_fin
                            && h.Estado.Contains(Estado)
                            select h;

                  foreach (var item in lst)
                  {
                      XCOMP_NATU_Rpt003_Info info = new XCOMP_NATU_Rpt003_Info();

                      info.IdEmpresa = item.IdEmpresa;
                      info.IdSucursal = item.IdSucursal;
                      info.IdOrdenCompra = item.IdOrdenCompra;
                      info.Secuencia = item.Secuencia;
                      info.IdEmpresa_ing = item.IdEmpresa_ing;
                      info.IdSucursal_ing = item.IdSucursal_ing;
                      info.IdMovi_inven_tipo_ing = item.IdMovi_inven_tipo_ing;
                      info.IdNumMovi_ing = item.IdNumMovi_ing;
                      info.Secuencia_ing = item.Secuencia_ing;
                      info.IdProducto = item.IdProducto;
                      info.cant_oc = item.cant_oc;
                      info.cant_ing = item.cant_ing;
                      info.cant = item.cant;
                      info.do_precioFinal = item.do_precioFinal;
                      info.total = item.total;
                      info.pr_codigo = item.pr_codigo;
                      info.pr_descripcion = item.pr_descripcion;
                      info.co_factura = item.co_factura;
                      info.oc_fecha = item.oc_fecha;
                      info.Estado = item.Estado;
                      info.IdProveedor = item.IdProveedor;
                      info.cod_proveedor = item.cod_proveedor;
                      info.nom_proveedor = item.nom_proveedor;
                      info.fecha_ing = item.fecha_ing;
                      info.Su_Descripcion = item.Su_Descripcion;
                      listadedatos.Add(info);

                  }
              }
              return listadedatos;
          }
          catch (Exception ex)
          {
              return new List<XCOMP_NATU_Rpt003_Info>();
          }
      }
    }
}
