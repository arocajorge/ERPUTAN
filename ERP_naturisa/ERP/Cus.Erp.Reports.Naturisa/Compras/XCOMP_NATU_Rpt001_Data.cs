using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_NATU_Rpt001_Data
    {
        public List<XCOMP_NATU_Rpt001_Info> consultar_data(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, decimal IdProveedor, decimal IdProducto,int IdGrupo, int IdPunto_cargo,  DateTime Fecha_ini, DateTime Fecha_fin, bool Mostrar_anuladas)
        {
            try
            {
                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                int IdGrupo_ini = IdGrupo;
                int IdGrupo_fin = IdGrupo == 0 ? 9999 : IdGrupo;

                int IdPunto_cargo_ini = IdPunto_cargo;
                int IdPunto_cargo_fin = IdPunto_cargo == 0 ? 9999 : IdPunto_cargo;

                decimal IdProducto_ini = IdProducto;
                decimal IdProducto_fin = IdProducto == 0 ? 99999 : IdProducto;

                decimal IdProveedor_ini = IdProveedor;
                decimal IdProveedor_fin = IdProveedor == 0 ? 99999 : IdProveedor;

                decimal IdOrdenCompra_ini = IdOrdenCompra;
                decimal IdOrdenCompra_fin = IdOrdenCompra == 0 ? 99999 : IdOrdenCompra;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                string Estado = Mostrar_anuladas ? "" : "ACTIVA";

                List<XCOMP_NATU_Rpt001_Info> listadedatos = new List<XCOMP_NATU_Rpt001_Info>();
                using (EntitiesCompras_natu_rpt ListadoOrdenCompra = new EntitiesCompras_natu_rpt())
                {
                    IQueryable<vwCOMP_NATU_Rpt001> lst;
                    if (IdGrupo != 0 && IdPunto_cargo != 0)
                    {
                        lst = from h in ListadoOrdenCompra.vwCOMP_NATU_Rpt001
                              where h.IdEmpresa == IdEmpresa
                              && IdSucursal_ini <= h.IdSucursal && h.IdSucursal <= IdSucursal_fin
                              && IdProducto_ini <= h.IdProducto && h.IdProducto <= IdProducto_fin
                              && IdGrupo_ini <= h.IdPunto_cargo_grupo && h.IdPunto_cargo_grupo <= IdGrupo_fin
                              && IdPunto_cargo_ini <= h.IdPunto_cargo && h.IdPunto_cargo <= IdPunto_cargo_fin
                              && IdProveedor_ini <= h.IdProveedor && h.IdProveedor <= IdProveedor_fin
                              && Fecha_ini <= h.Fecha_OC && h.Fecha_OC <= Fecha_fin
                              && IdOrdenCompra_ini <= h.IdOrdenCompra && h.IdOrdenCompra <= IdOrdenCompra_fin
                              && h.Estado_OC.Contains(Estado)
                              select h;
                    }
                    else
                        if (IdGrupo != 0 && IdPunto_cargo == 0)
                            lst = from h in ListadoOrdenCompra.vwCOMP_NATU_Rpt001
                                  where h.IdEmpresa == IdEmpresa
                                  && IdSucursal_ini <= h.IdSucursal && h.IdSucursal <= IdSucursal_fin
                                  && IdProducto_ini <= h.IdProducto && h.IdProducto <= IdProducto_fin
                                  && ((IdGrupo_ini <= h.IdPunto_cargo_grupo && h.IdPunto_cargo_grupo <= IdGrupo_fin))
                                  && ((IdPunto_cargo_ini <= h.IdPunto_cargo && h.IdPunto_cargo <= IdPunto_cargo_fin) || h.IdPunto_cargo == null)
                                  && IdProveedor_ini <= h.IdProveedor && h.IdProveedor <= IdProveedor_fin
                                  && Fecha_ini <= h.Fecha_OC && h.Fecha_OC <= Fecha_fin
                                  && IdOrdenCompra_ini <= h.IdOrdenCompra && h.IdOrdenCompra <= IdOrdenCompra_fin
                                  && h.Estado_OC.Contains(Estado)
                                  select h;
                        else
                            lst = from h in ListadoOrdenCompra.vwCOMP_NATU_Rpt001
                                  where h.IdEmpresa == IdEmpresa
                                  && IdSucursal_ini <= h.IdSucursal && h.IdSucursal <= IdSucursal_fin
                                  && IdProducto_ini <= h.IdProducto && h.IdProducto <= IdProducto_fin
                                  && ((IdGrupo_ini <= h.IdPunto_cargo_grupo && h.IdPunto_cargo_grupo <= IdGrupo_fin) || h.IdPunto_cargo_grupo == null)
                                  && ((IdPunto_cargo_ini <= h.IdPunto_cargo && h.IdPunto_cargo <= IdPunto_cargo_fin) || h.IdPunto_cargo == null)
                                  && IdProveedor_ini <= h.IdProveedor && h.IdProveedor <= IdProveedor_fin
                                  && Fecha_ini <= h.Fecha_OC && h.Fecha_OC <= Fecha_fin
                                  && IdOrdenCompra_ini <= h.IdOrdenCompra && h.IdOrdenCompra <= IdOrdenCompra_fin
                                  && h.Estado_OC.Contains(Estado)
                                  select h;





                    foreach (var item in lst)
                    {
                        XCOMP_NATU_Rpt001_Info info = new XCOMP_NATU_Rpt001_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdOrdenCompra = item.IdOrdenCompra;
                        info.IdProveedor = item.IdProveedor;
                        info.Fecha_OC = item.Fecha_OC;
                        info.Observacion_OC = item.Observacion_OC;
                        info.Estado_OC = item.Estado_OC;
                        info.Secuencia = item.Secuencia;
                        info.IdProducto = item.IdProducto;
                        info.cantidad_det = item.cantidad_det;
                        info.Precio_det = item.Precio_det;
                        info.Subtotal_det = item.Subtotal_det;
                        info.Iva_det = item.Iva_det;
                        info.Total_det = item.Total_det;
                        info.cod_proveedor = item.cod_proveedor;
                        info.nom_proveedor = item.nom_proveedor;
                        info.cod_producto = item.cod_producto;
                        info.nom_producto = item.nom_producto;
                        info.nom_sucursal = item.nom_sucursal;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.IdComprador = item.IdComprador;
                        info.nom_comprador = item.nom_comprador;
                        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                        info.cod_Punto_cargo_grupo = item.cod_Punto_cargo_grupo;
                        info.codPunto_cargo = item.codPunto_cargo;
                        info.IdUnidadMedida = item.IdUnidadMedida;
                        info.Por_Iva = item.Por_Iva;
                        info.do_observacion = item.do_observacion;
                        info.do_precioFinal = item.do_precioFinal;
                        info.do_porc_des = item.do_porc_des;
                        info.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                        info.nom_estado_aprobacion = item.nom_estado_aprobacion;
                        info.oc_plazo = item.oc_plazo;

                        listadedatos.Add(info);

                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XCOMP_NATU_Rpt001_Info>();
            }
        }
   
    
    
    }
}