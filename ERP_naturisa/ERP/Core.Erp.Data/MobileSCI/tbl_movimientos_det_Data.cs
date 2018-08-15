using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Erp.Data.MobileSCI
{
    public class tbl_movimientos_det_Data
    {
        public List<tbl_movimientos_det_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<tbl_movimientos_det_Info> Lista;
                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;
                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 9999 : IdBodega;
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    Lista = (from q in Context.vw_movimientos_det
                             where q.IdEmpresa == IdEmpresa
                             && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                             && IdBodega_ini <= q.IdBodega && q.IdBodega <= IdBodega_fin
                             && Fecha_ini <= q.Fecha && q.Fecha <= Fecha_fin
                             && q.Estado != "I"
                             select new tbl_movimientos_det_Info
                             {
                                 IdSincronizacion = q.IdSincronizacion,
                                 IdSecuencia = q.IdSecuencia,
                                 IdUsuarioSCI = q.IdUsuarioSCI,
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 IdProducto = q.IdProducto,
                                 IdUnidadMedida = q.IdUnidadMedida,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 Fecha = q.Fecha,
                                 cantidad = q.cantidad,
                                 IdEmpresa_oc = q.IdEmpresa_oc,
                                 IdSucursal_oc = q.IdSucursal_oc,
                                 IdOrdenCompra = q.IdOrdenCompra,
                                 secuencia_oc = q.secuencia_oc,
                                 pr_descripcion = q.pr_descripcion,
                                 nom_unidad_medida = q.nom_unidad_medida,
                                 Aprobado = q.Aprobado,
                                 Estado = q.Estado,
                                 Su_Descripcion = q.Su_Descripcion,
                                 bo_Descripcion = q.bo_Descripcion,
                                 nom_centro = q.nom_centro,
                                 nom_subcentro = q.nom_subcentro,
                                 Fecha_sincronizacion = q.Fecha_sincronizacion,
                                 do_precioFinal = q.do_precioFinal
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool Modificar_estado(List<tbl_movimientos_det_Info> Lista, string Estado)
        {
            try
            {
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    foreach (var item in Lista)
                    {
                        var Entity = Context.tbl_movimientos_det.Where(q => q.IdSincronizacion == item.IdSincronizacion && q.IdSecuencia == item.IdSecuencia).FirstOrDefault();
                        if(Entity != null)
                            Entity.Estado = Estado;
                    }
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public bool Aprobar(int IdEmpresa, List<tbl_movimientos_det_Info> Lista)
        {
            Entities_mobileSCI db_mobile = new Entities_mobileSCI();
            EntitiesInventario db_inv = new EntitiesInventario();
            try
            {
                var Entity_p = db_inv.in_parametro.Where(q => q.IdEmpresa == IdEmpresa).FirstOrDefault();
                if (Entity_p == null || Entity_p.IdMovi_inven_tipo_mobile_ing == null || Entity_p.IdMovi_inven_tipo_mobile_egr == null)
                    return false;

                var Entity_motivo_ing = db_inv.in_Motivo_Inven.Where(q => q.IdEmpresa == IdEmpresa && q.Tipo_Ing_Egr == "ING" && q.Genera_Movi_Inven == "S").FirstOrDefault();
                if (Entity_motivo_ing == null)
                    return false;

                var Entity_motivo_egr = db_inv.in_Motivo_Inven.Where(q => q.IdEmpresa == IdEmpresa && q.Tipo_Ing_Egr == "EGR" && q.Genera_Movi_Inven == "S" && q.es_Inven_o_Consumo == "TIC_CONSU").FirstOrDefault();
                if (Entity_motivo_egr == null)
                    return false;

                #region Ingresos
                var lst_mov_agrupada = (from q in Lista
                                        where q.cantidad > 0
                                        group new { q.IdEmpresa, q.IdSucursal, q.IdBodega, q.Fecha, q.IdSucursal_oc, q.IdOrdenCompra } by new { q.IdEmpresa, q.IdSucursal, q.IdBodega, q.Fecha, q.IdSucursal_oc, q.IdOrdenCompra } into g
                                        select new tbl_movimientos_det_Info
                                        {
                                            IdEmpresa = g.Key.IdEmpresa,
                                            IdSucursal = g.Key.IdSucursal,
                                            IdBodega = g.Key.IdBodega,
                                            Fecha = g.Key.Fecha,
                                            IdSucursal_oc = g.Key.IdSucursal_oc,
                                            IdOrdenCompra = g.Key.IdOrdenCompra,                                            
                                        }).ToList();
                
                foreach (var item in lst_mov_agrupada)
                {
                    #region Cabecera
                    in_Ing_Egr_Inven Entity_cab = new in_Ing_Egr_Inven
                    {
                        IdEmpresa = item.IdEmpresa,
                        IdSucursal = item.IdSucursal,
                        IdMovi_inven_tipo = Convert.ToInt32(Entity_p.IdMovi_inven_tipo_mobile_ing),
                        IdNumMovi = get_id(item.IdEmpresa,item.IdSucursal,Convert.ToInt32(Entity_p.IdMovi_inven_tipo_mobile_ing)),
                        IdBodega = item.IdBodega,
                        signo = "+",
                        CodMoviInven = "MOBILE",
                        cm_observacion = "Aprobación móvil "+DateTime.Now.ToString("dd/MM/yyyy"),
                        cm_fecha = item.Fecha,
                        Estado = "A",
                        IdMotivo_Inv = Entity_motivo_ing.IdMotivo_Inv
                    };
                    db_inv.in_Ing_Egr_Inven.Add(Entity_cab);
                    #endregion
                    #region Detalle
                    int sec = 1;
                    foreach (var mov in Lista.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.Fecha == item.Fecha && q.IdSucursal_oc == item.IdSucursal_oc && q.IdOrdenCompra == item.IdOrdenCompra && q.cantidad > 0).ToList())
                    {
                        in_Ing_Egr_Inven_det Entity_det = new in_Ing_Egr_Inven_det
                        {
                            IdEmpresa = Entity_cab.IdEmpresa,
                            IdSucursal = Entity_cab.IdSucursal,
                            IdMovi_inven_tipo = Entity_cab.IdMovi_inven_tipo,
                            IdNumMovi = Entity_cab.IdNumMovi,
                            Secuencia = sec++,
                            IdBodega = mov.IdBodega,
                            IdProducto = mov.IdProducto,
                            dm_cantidad = mov.cantidad,
                            dm_stock_actu = 0,
                            dm_stock_ante = 0,
                            dm_observacion = "",
                            dm_precio = 0,
                            mv_costo = mov.do_precioFinal,
                            dm_peso = 0,
                            IdCentroCosto = null,
                            IdCentroCosto_sub_centro_costo = null,
                            IdEstadoAproba = "PEND",
                            IdUnidadMedida = mov.IdUnidadMedida,
                            IdEmpresa_oc = mov.IdEmpresa_oc,
                            IdSucursal_inv = mov.IdSucursal_oc,
                            IdOrdenCompra = mov.IdOrdenCompra,
                            Secuencia_oc = mov.secuencia_oc,
                            Motivo_Aprobacion = "Aprobación movil",
                            dm_cantidad_sinConversion = mov.cantidad,
                            IdUnidadMedida_sinConversion = mov.IdUnidadMedida,
                            mv_costo_sinConversion = mov.do_precioFinal,
                            IdMotivo_Inv = null
                        };
                        db_inv.in_Ing_Egr_Inven_det.Add(Entity_det);

                        tbl_movimientos_det_apro Entity_apro = new tbl_movimientos_det_apro
                        {
                            IdSincronizacion = mov.IdSincronizacion,
                            IdSecuencia = mov.IdSecuencia,
                            IdEmpresa = mov.IdEmpresa,
                            IdSucursal = mov.IdSucursal,
                            IdMovi_inven_tipo = Entity_cab.IdMovi_inven_tipo,
                            IdNumMovi = Entity_cab.IdNumMovi,
                            Secuencia = Entity_det.Secuencia
                        };
                        db_mobile.tbl_movimientos_det_apro.Add(Entity_apro);

                        var Entity_sinc = db_mobile.tbl_movimientos_det.Where(q => q.IdSincronizacion == mov.IdSincronizacion && q.IdSecuencia == mov.IdSecuencia).FirstOrDefault().Aprobado = true;
                    }                    
                    #endregion                                       
                    db_inv.SaveChanges();
                    db_mobile.SaveChanges();
                    db_inv.spINV_aprobacion_movimiento(Entity_cab.IdEmpresa, Entity_cab.IdSucursal, Entity_cab.IdMovi_inven_tipo, Entity_cab.IdBodega, Entity_cab.IdNumMovi);
                }
                #endregion

                #region Egresos
                lst_mov_agrupada = (from q in Lista
                                        where q.cantidad < 0
                                        group new { q.IdEmpresa, q.IdSucursal, q.IdBodega, q.Fecha } by new { q.IdEmpresa, q.IdSucursal, q.IdBodega, q.Fecha } into g
                                        select new tbl_movimientos_det_Info
                                        {
                                            IdEmpresa = g.Key.IdEmpresa,
                                            IdSucursal = g.Key.IdSucursal,
                                            IdBodega = g.Key.IdBodega,
                                            Fecha = g.Key.Fecha
                                        }).ToList();

                foreach (var item in lst_mov_agrupada)
                {
                    #region Cabecera
                    in_Ing_Egr_Inven Entity_cab = new in_Ing_Egr_Inven
                    {
                        IdEmpresa = item.IdEmpresa,
                        IdSucursal = item.IdSucursal,
                        IdMovi_inven_tipo = Convert.ToInt32(Entity_p.IdMovi_inven_tipo_mobile_egr),
                        IdNumMovi = get_id(item.IdEmpresa, item.IdSucursal, Convert.ToInt32(Entity_p.IdMovi_inven_tipo_mobile_egr)),
                        IdBodega = item.IdBodega,
                        signo = "-",
                        CodMoviInven = "MOBILE",
                        cm_observacion = "Aprobación móvil " + DateTime.Now.ToString("dd/MM/yyyy"),
                        cm_fecha = item.Fecha,
                        Estado = "A",
                        IdMotivo_Inv = Entity_motivo_egr.IdMotivo_Inv
                    };
                    db_inv.in_Ing_Egr_Inven.Add(Entity_cab);
                    #endregion
                    #region Detalle
                    int sec = 1;
                    foreach (var mov in Lista.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.Fecha == item.Fecha && q.cantidad < 0).ToList())
                    {
                        in_Ing_Egr_Inven_det Entity_det = new in_Ing_Egr_Inven_det
                        {
                            IdEmpresa = Entity_cab.IdEmpresa,
                            IdSucursal = Entity_cab.IdSucursal,
                            IdMovi_inven_tipo = Entity_cab.IdMovi_inven_tipo,
                            IdNumMovi = Entity_cab.IdNumMovi,
                            Secuencia = sec++,
                            IdBodega = mov.IdBodega,
                            IdProducto = mov.IdProducto,
                            dm_cantidad = mov.cantidad,
                            dm_stock_actu = 0,
                            dm_stock_ante = 0,
                            dm_observacion = "",
                            dm_precio = 0,
                            mv_costo = mov.do_precioFinal,
                            dm_peso = 0,
                            IdCentroCosto = mov.IdCentroCosto,
                            IdCentroCosto_sub_centro_costo = mov.IdCentroCosto_sub_centro_costo,
                            IdEstadoAproba = "PEND",
                            IdUnidadMedida = mov.IdUnidadMedida,
                            IdEmpresa_oc = mov.IdEmpresa_oc,
                            IdSucursal_inv = mov.IdSucursal_oc,
                            IdOrdenCompra = mov.IdOrdenCompra,
                            Secuencia_oc = mov.secuencia_oc,
                            Motivo_Aprobacion = "Aprobación movil",
                            dm_cantidad_sinConversion = mov.cantidad,
                            IdUnidadMedida_sinConversion = mov.IdUnidadMedida,
                            mv_costo_sinConversion = mov.do_precioFinal,
                            IdMotivo_Inv = null
                        };
                        db_inv.in_Ing_Egr_Inven_det.Add(Entity_det);

                        tbl_movimientos_det_apro Entity_apro = new tbl_movimientos_det_apro
                        {
                            IdSincronizacion = mov.IdSincronizacion,
                            IdSecuencia = mov.IdSecuencia,
                            IdEmpresa = mov.IdEmpresa,
                            IdSucursal = mov.IdSucursal,
                            IdMovi_inven_tipo = Entity_cab.IdMovi_inven_tipo,
                            IdNumMovi = Entity_cab.IdNumMovi,
                            Secuencia = Entity_det.Secuencia
                        };
                        db_mobile.tbl_movimientos_det_apro.Add(Entity_apro);

                        var Entity_sinc = db_mobile.tbl_movimientos_det.Where(q => q.IdSincronizacion == mov.IdSincronizacion && q.IdSecuencia == mov.IdSecuencia).FirstOrDefault().Aprobado = true;
                    }                    
                    #endregion
                    db_inv.SaveChanges();
                    db_mobile.SaveChanges();
                    db_inv.spINV_aprobacion_movimiento(Entity_cab.IdEmpresa, Entity_cab.IdSucursal, Entity_cab.IdMovi_inven_tipo, Entity_cab.IdBodega, Entity_cab.IdNumMovi);
                }
                #endregion            

                return true;
            }
            catch (Exception)
            {
                db_inv.Dispose();
                db_mobile.Dispose();
                throw;
            }
        }

        private decimal get_id(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo)
        {
            decimal ID = 1;
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.in_Ing_Egr_Inven
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                              select q;

                    if (lst.Count() > 0)
                        ID = lst.Max(q => q.IdNumMovi) + 1;
                }
                return ID;
            }
            catch (Exception)
            {
                throw;   
            }
        }

        public List<tbl_movimientos_det_Info> get_list_csv(int IdEmpresa, int IdSucursal, int IdBodega, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<tbl_movimientos_det_Info> Lista;
                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;
                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 9999 : IdBodega;
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    Lista = (from q in Context.vw_movimientos_csv
                             where q.IdEmpresa == IdEmpresa
                             && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                             && IdBodega_ini <= q.IdBodega && q.IdBodega <= IdBodega_fin
                             && Fecha_ini <= q.Fecha && q.Fecha <= Fecha_fin
                             select new tbl_movimientos_det_Info
                             {
                                 Checked_A = true,
                                 IdSincronizacion = q.IdSincronizacion,
                                 IdSecuencia = q.IdSecuencia,
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                                 IdNumMovi = q.IdNumMovi,
                                 Secuencia = q.Secuencia,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 nom_centro = q.NomCentroCosto,
                                 nom_subcentro = q.NomSubCentro,
                                 CodProduccionSC = q.CodProduccionSC,
                                 pr_descripcion = q.pr_descripcion,
                                 CodProduccionPro = q.CodProduccionPro,
                                 Su_Descripcion = q.Su_Descripcion,
                                 bo_Descripcion = q.bo_Descripcion,
                                 cantidad = q.Cantidad,
                                 IdProducto = q.IdProducto,
                                 Fecha = q.Fecha,
                                 IdUnidadMedida = q.IdUnidadMedida,
                             }).ToList();
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
