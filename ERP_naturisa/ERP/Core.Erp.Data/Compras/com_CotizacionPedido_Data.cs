using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
namespace Core.Erp.Data.Compras
{
    public class com_CotizacionPedido_Data
    {
        tb_sis_impuesto_Data odataImp = new tb_sis_impuesto_Data();
        private decimal GetID(int IdEmpresa)
        {
            try
            {
                decimal ID = 1;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var lst = db.com_CotizacionPedido.Where(q => q.IdEmpresa == IdEmpresa).Select(q=> q.IdCotizacion).ToList();
                    if (lst.Count != 0)
                        ID = lst.Max() + 1;
                }

                return ID;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(com_CotizacionPedido_Info info)
        {
            try
            {
                EntitiesInventario dbi = new EntitiesInventario();
                EntitiesGeneral dbg = new EntitiesGeneral();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    db.com_CotizacionPedido.Add(new com_CotizacionPedido
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdCotizacion = info.IdCotizacion = GetID(info.IdEmpresa),
                        IdSucursal = info.IdSucursal,
                        IdProveedor = info.IdProveedor,
                        IdTerminoPago = info.IdTerminoPago,
                        cp_Fecha = info.cp_Fecha,
                        cp_Plazo = info.cp_Plazo,
                        IdOrdenPedido = info.IdOrdenPedido,
                        cp_Observacion = info.cp_Observacion,
                        IdComprador = info.IdComprador,
                        IdDepartamento = info.IdDepartamento,
                        IdSolicitante = Convert.ToInt32(info.IdSolicitante),
                        EstadoGA = "P",
                        EstadoJC = "P",
                        cp_PlazoEntrega = info.cp_PlazoEntrega,
                        cp_ObservacionAdicional = info.cp_ObservacionAdicional
                    });

                    int Secuencia = 1;

                    foreach (var item in info.ListaDetalle)
                    {
                        db.com_CotizacionPedidoDet.Add(new com_CotizacionPedidoDet
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdCotizacion = info.IdCotizacion,
                            Secuencia = Secuencia++,
                            opd_IdEmpresa = item.opd_IdEmpresa,
                            opd_IdOrdenPedido = item.opd_IdOrdenPedido,
                            opd_Secuencia = item.opd_Secuencia,
                            cd_Cantidad = item.cd_Cantidad,
                            cd_precioCompra = item.cd_precioCompra,
                            cd_porc_des = item.cd_porc_des,
                            cd_descuento = item.cd_descuento,
                            cd_precioFinal = item.cd_precioFinal,
                            cd_subtotal = item.cd_subtotal,
                            IdCod_Impuesto = item.IdCod_Impuesto,
                            Por_Iva = item.Por_Iva,
                            cd_iva = item.cd_iva,
                            cd_total = item.cd_total,                            
                            IdProducto = item.IdProducto ?? 0,
                            IdPunto_cargo = item.IdPunto_cargo ,
                            IdUnidadMedida = item.IdUnidadMedida,
                            cd_DetallePorItem = item.cd_DetallePorItem
                        });

                        var det_op = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == item.opd_IdEmpresa && q.IdOrdenPedido == item.opd_IdOrdenPedido && q.Secuencia == item.opd_Secuencia && q.opd_EstadoProceso == "A").FirstOrDefault();
                        if (det_op != null)
                        {
                            det_op.opd_EstadoProceso = "AC";
                            if (det_op.IdProducto == null)
                            {
                                det_op.pr_descripcion = dbi.in_Producto.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdProducto == item.IdProducto).FirstOrDefault().pr_descripcion;
                                det_op.IdUnidadMedida = item.IdUnidadMedida;
                                det_op.IdProducto = item.IdProducto;
                            }
                            det_op.FechaCotizacion = DateTime.Now;
                            det_op.IdUsuarioCotizacion = info.IdUsuario;
                        }
                    }
                    var persona = dbg.tb_persona.Where(q => q.IdPersona == info.IdPersona).FirstOrDefault();
                    if (persona != null)
                        persona.pe_correo_secundario1 = info.pe_correo;
                    db.SaveChanges();
                    dbg.SaveChanges();

                    
                }

                com_OrdenPedido_Data data_ped = new com_OrdenPedido_Data();
                if (data_ped.SaltarPaso4(info.IdEmpresa, info.IdOrdenPedido ?? 0, info.IdUsuario))
                {

                }

                if (data_ped.ValidarProceso(info.IdEmpresa, info.IdOrdenPedido ?? 0))
                {

                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool AprobarDB(com_CotizacionPedido_Info info, string Cargo)
        {
            try
            {
                try
                {
                    
                    using (EntitiesCompras db = new EntitiesCompras())
                    {
                        var Entity = db.com_CotizacionPedido.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdCotizacion == info.IdCotizacion).FirstOrDefault();
                        if (Entity == null)
                            return false;

                        if (Cargo == "JC")
                        {
                            Entity.EstadoJC = info.EstadoJC;
                            Entity.IdUsuarioJC = info.IdUsuario;
                            Entity.FechaJC = DateTime.Now;
                            Entity.cp_Observacion = info.cp_Observacion;
                        }
                        else
                            Entity.EstadoGA = info.EstadoGA;


                        foreach (var item in info.ListaDetalle)
                        {
                            var det = db.com_CotizacionPedidoDet.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdCotizacion == item.IdCotizacion && q.Secuencia == item.Secuencia).FirstOrDefault();
                            if (det != null)
                            {
                                if (Cargo == "JC")
                                    det.EstadoJC = item.A;
                                else
                                    det.EstadoGA = item.A;
                            }
                            var detped = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdOrdenPedido == item.opd_IdOrdenPedido && q.Secuencia == item.opd_Secuencia).FirstOrDefault();
                            if (detped != null)
                            {
                                if (Cargo == "JC")
                                    detped.opd_EstadoProceso = item.A == true ? "AJC" : "A";
                                else
                                    detped.opd_EstadoProceso = item.A == true ? "C" : "RGA";
                            }
                        }

                        var lstPedido = info.ListaDetalle.GroupBy(q => q.opd_IdOrdenPedido).ToList();
                        foreach (var item in lstPedido)
                        {
                            var Pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenPedido == item.Key).FirstOrDefault();
                            if (Pedido != null)
                            {
                                Pedido.IdUsuarioAprobacion = info.IdUsuario;
                                Pedido.FechaAprobacion = DateTime.Now;
                                Pedido.ObservacionGA = info.ObservacionAprobador;
                            }
                        }

                        if (Cargo == "GA" && info.ListaDetalle.Where(q => q.EstadoGA).Count() > 0)
                        {
                            com_ordencompra_local_Data odataCom = new com_ordencompra_local_Data();
                            int workDays = info.cp_PlazoEntrega;
                            DateTime tmpDate = DateTime.Now.Date;
                            while (workDays > 0)
                            {
                                tmpDate = tmpDate.AddDays(1);
                                if (tmpDate.DayOfWeek < DayOfWeek.Saturday &&
                                    tmpDate.DayOfWeek > DayOfWeek.Sunday)
                                    workDays--;
                            }

                            db.com_ordencompra_local.Add(new com_ordencompra_local
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdSucursal = info.IdSucursal,
                                IdOrdenCompra = info.oc_IdOrdenCompra = odataCom.GetId(info.IdEmpresa, info.IdSucursal),
                                IdProveedor = info.IdProveedor,
                                oc_NumDocumento = "COT" + info.IdCotizacion.ToString("0000000000"),
                                Tipo = "",
                                IdTerminoPago = info.IdTerminoPago,
                                oc_plazo = info.cp_Plazo,
                                oc_fecha = DateTime.Now.Date,
                                oc_flete = 0,
                                oc_observacion = info.cp_Observacion,
                                Estado = "A",
                                IdEstadoAprobacion_cat = "APRO",
                                Fecha_Transac = DateTime.Now,
                                IdEstadoRecepcion_cat = "PEN",
                                AfectaCosto = "S",
                                IdDepartamento = info.IdDepartamento,
                                IdMotivo = null,
                                oc_fechaVencimiento = tmpDate,
                                IdEstado_cierre = "ABI",
                                IdComprador = info.IdComprador,
                                IdUsuario = info.IdUsuario,
                                co_fecha_aprobacion = DateTime.Now,
                                IdUsuario_Aprueba = info.IdUsuario
                            });
                            int Secuencia = 1;
                            var lstGeneracion = info.ListaDetalle.Where(q=> q.A && q.cd_Cantidad > 0).ToList();
                            foreach (var item in lstGeneracion)
                            {
                                var impuesto = odataImp.Get_Info_impuesto(item.IdCod_Impuesto);
                                if (impuesto != null)
                                {
                                    item.Por_Iva = impuesto.porcentaje;
                                    item.cd_iva = item.cd_subtotal * (impuesto.porcentaje / 100);
                                    item.cd_total = item.cd_subtotal + item.cd_iva;
                                }
                                db.com_ordencompra_local_det.Add(new com_ordencompra_local_det
                                {
                                    IdEmpresa = info.IdEmpresa,
                                    IdSucursal = info.IdSucursal,
                                    IdOrdenCompra = info.oc_IdOrdenCompra,
                                    Secuencia = Secuencia++,
                                    IdProducto = item.IdProducto ?? 0,
                                    do_Cantidad = item.cd_Cantidad,
                                    do_precioCompra = item.cd_precioCompra,
                                    do_porc_des = item.cd_porc_des,
                                    do_descuento = item.cd_descuento,
                                    do_precioFinal = item.cd_precioFinal,
                                    do_subtotal = item.cd_subtotal,
                                    do_iva = item.cd_iva,
                                    do_total = item.cd_total,
                                    do_ManejaIva = true,
                                    do_Costeado = "N",
                                    do_peso = 0,
                                    IdCentroCosto = null,
                                    IdCentroCosto_sub_centro_costo = null,
                                    IdPunto_cargo = item.IdPunto_cargo,
                                    IdPunto_cargo_grupo = null,
                                    IdUnidadMedida = item.IdUnidadMedida,
                                    Por_Iva = item.Por_Iva,
                                    IdCod_Impuesto = item.IdCod_Impuesto,
                                    do_observacion = (string.IsNullOrEmpty(item.cd_DetallePorItem) ? "" : item.cd_DetallePorItem+" ") + (string.IsNullOrEmpty(item.opd_Detalle) ? "" : item.opd_Detalle),
                                    IdSucursalDestino = item.IdSucursalDestino
                                });
                            }

                            Entity.oc_IdOrdenCompra = Convert.ToInt32(info.oc_IdOrdenCompra);
                            db.com_ordencompra_local_correo.Add(new com_ordencompra_local_correo
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdSucursal = info.IdSucursal,
                                IdOrdenCompra = info.oc_IdOrdenCompra,
                                Correo = ""
                            });
                        }
                        db.SaveChanges();
                    }

                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    throw;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool PasarDB(int IdEmpresa, decimal IdCotizacion, string IdUsuario)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    if (db.com_CotizacionPedidoSaltar.Where(q => q.IdEmpresa == IdEmpresa && q.IdCotizacion == IdCotizacion && q.IdUsuario == IdUsuario).Count() == 0)
                        db.com_CotizacionPedidoSaltar.Add(new com_CotizacionPedidoSaltar
                        {
                            IdEmpresa = IdEmpresa,
                            IdCotizacion = IdCotizacion,
                            IdUsuario = IdUsuario
                        });
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public com_CotizacionPedido_Info GetInfoAprobar(int IdEmpresa, string IdUsuario, string Cargo)
        {
            try
            {
                com_CotizacionPedido_Info info = new com_CotizacionPedido_Info();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    if(Cargo == "JC")
                    info = db.vwcom_CotizacionPedido.Where(q=> q.IdEmpresa == IdEmpresa && q.EstadoJC == "P" && q.Pasado == false).Select(q=> new com_CotizacionPedido_Info{
                        IdEmpresa = q.IdEmpresa,
                        IdCotizacion = q.IdCotizacion,
                        IdSucursal = q.IdSucursal,
                        IdProveedor = q.IdProveedor,
                        IdTerminoPago = q.IdTerminoPago,
                        cp_Fecha = q.cp_Fecha,
                        cp_Plazo = q.cp_Plazo,
                        cp_Observacion = q.cp_Observacion,
                        IdComprador = q.IdComprador,
                        IdSolicitante = q.IdSolicitante,
                        IdDepartamento = q.IdDepartamento,
                        EstadoJC = q.EstadoJC,
                        EstadoGA = q.EstadoGA,

                        Su_Descripcion = q.Su_Descripcion,
                        pe_nombreCompleto = q.pe_nombreCompleto,
                        TerminoPago = q.TerminoPago,
                        Comprador= q.Comprador,
                        nom_solicitante = q.nom_solicitante,
                        nom_departamento = q.nom_departamento,
                        cp_PlazoEntrega = q.cp_PlazoEntrega,
                        Pasado = q.Pasado,
                        cp_ObservacionAdicional = q.cp_ObservacionAdicional
                    }).OrderBy(q=> q.IdCotizacion).FirstOrDefault();
                        else
                        info = db.vwcom_CotizacionPedido.Where(q => q.IdEmpresa == IdEmpresa && q.EstadoJC == "A" && q.EstadoGA == "P" && q.Pasado == false).Select(q => new com_CotizacionPedido_Info
                        {
                            IdEmpresa = q.IdEmpresa,
                            IdCotizacion = q.IdCotizacion,
                            IdSucursal = q.IdSucursal,
                            IdProveedor = q.IdProveedor,
                            IdTerminoPago = q.IdTerminoPago,
                            cp_Fecha = q.cp_Fecha,
                            cp_Plazo = q.cp_Plazo,
                            cp_Observacion = q.cp_Observacion,
                            IdComprador = q.IdComprador,
                            IdSolicitante = q.IdSolicitante,
                            IdDepartamento = q.IdDepartamento,
                            EstadoJC = q.EstadoJC,
                            EstadoGA = q.EstadoGA,

                            Su_Descripcion = q.Su_Descripcion,
                            pe_nombreCompleto = q.pe_nombreCompleto,
                            TerminoPago = q.TerminoPago,
                            Comprador = q.Comprador,
                            nom_solicitante = q.nom_solicitante,
                            nom_departamento = q.nom_departamento,
                            cp_PlazoEntrega = q.cp_PlazoEntrega,
                            Pasado = q.Pasado,
                            cp_ObservacionAdicional = q.cp_ObservacionAdicional
                        }).OrderBy(q => q.IdCotizacion).FirstOrDefault();
                    if (info == null)
                    {
                        var lst = db.com_CotizacionPedidoSaltar.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario).ToList();
                        foreach (var item in lst)
                        {
                            db.com_CotizacionPedidoSaltar.Remove(item);
                        }
                        db.SaveChanges();

                        if (Cargo == "JC")
                            info = db.vwcom_CotizacionPedido.Where(q => q.IdEmpresa == IdEmpresa && q.EstadoJC == "P" && q.Pasado == false).Select(q => new com_CotizacionPedido_Info
                            {
                                IdEmpresa = q.IdEmpresa,
                                IdCotizacion = q.IdCotizacion,
                                IdSucursal = q.IdSucursal,
                                IdProveedor = q.IdProveedor,
                                IdTerminoPago = q.IdTerminoPago,
                                cp_Fecha = q.cp_Fecha,
                                cp_Plazo = q.cp_Plazo,
                                cp_Observacion = q.cp_Observacion,
                                IdComprador = q.IdComprador,
                                IdSolicitante = q.IdSolicitante,
                                IdDepartamento = q.IdDepartamento,
                                EstadoJC = q.EstadoJC,
                                EstadoGA = q.EstadoGA,

                                Su_Descripcion = q.Su_Descripcion,
                                pe_nombreCompleto = q.pe_nombreCompleto,
                                TerminoPago = q.TerminoPago,
                                Comprador = q.Comprador,
                                nom_solicitante = q.nom_solicitante,
                                nom_departamento = q.nom_departamento,
                                cp_PlazoEntrega = q.cp_PlazoEntrega,
                                Pasado = q.Pasado,
                                cp_ObservacionAdicional = q.cp_ObservacionAdicional
                            }).OrderBy(q => q.IdCotizacion).FirstOrDefault();
                        else
                            info = db.vwcom_CotizacionPedido.Where(q => q.IdEmpresa == IdEmpresa && q.EstadoJC == "A" && q.EstadoGA == "P" && q.Pasado == false).Select(q => new com_CotizacionPedido_Info
                            {
                                IdEmpresa = q.IdEmpresa,
                                IdCotizacion = q.IdCotizacion,
                                IdSucursal = q.IdSucursal,
                                IdProveedor = q.IdProveedor,
                                IdTerminoPago = q.IdTerminoPago,
                                cp_Fecha = q.cp_Fecha,
                                cp_Plazo = q.cp_Plazo,
                                cp_Observacion = q.cp_Observacion,
                                IdComprador = q.IdComprador,
                                IdSolicitante = q.IdSolicitante,
                                IdDepartamento = q.IdDepartamento,
                                EstadoJC = q.EstadoJC,
                                EstadoGA = q.EstadoGA,

                                Su_Descripcion = q.Su_Descripcion,
                                pe_nombreCompleto = q.pe_nombreCompleto,
                                TerminoPago = q.TerminoPago,
                                Comprador = q.Comprador,
                                nom_solicitante = q.nom_solicitante,
                                nom_departamento = q.nom_departamento,
                                cp_PlazoEntrega = q.cp_PlazoEntrega,
                                Pasado = q.Pasado,
                                cp_ObservacionAdicional = q.cp_ObservacionAdicional
                            }).OrderBy(q => q.IdCotizacion).FirstOrDefault();
                    }
                }

                return info;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public com_CotizacionPedido_Info GetInfoAprobar(int IdEmpresa, decimal IdCotizacion)
        {
            try
            {
                com_CotizacionPedido_Info info = new com_CotizacionPedido_Info();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    info = db.com_CotizacionPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdCotizacion == IdCotizacion).Select(q => new com_CotizacionPedido_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdCotizacion = q.IdCotizacion,
                        IdSucursal = q.IdSucursal,
                        IdProveedor = q.IdProveedor,
                        IdTerminoPago = q.IdTerminoPago,
                        cp_Fecha = q.cp_Fecha,
                        cp_Plazo = q.cp_Plazo,
                        cp_Observacion = q.cp_Observacion,
                        IdComprador = q.IdComprador,
                        IdSolicitante = q.IdSolicitante,
                        IdDepartamento = q.IdDepartamento,
                        EstadoJC = q.EstadoJC,
                        EstadoGA = q.EstadoGA,
                        cp_PlazoEntrega = q.cp_PlazoEntrega,
                        cp_ObservacionAdicional = q.cp_ObservacionAdicional
                    }).FirstOrDefault();
                }

                return info;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<com_CotizacionPedido_Info> GetListAprobar(int IdEmpresa, string IdUsuario, string Cargo)
        {
            try
            {
                List<com_CotizacionPedido_Info> Lista;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.vwcom_CotizacionPedido.Where(q => q.IdEmpresa == IdEmpresa && q.EstadoJC == "P" && q.EstadoGA == "P").Select(q => new com_CotizacionPedido_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdCotizacion = q.IdCotizacion,
                        IdSucursal = q.IdSucursal,
                        IdProveedor = q.IdProveedor,
                        IdTerminoPago = q.IdTerminoPago,
                        cp_Fecha = q.cp_Fecha,
                        cp_Plazo = q.cp_Plazo,
                        cp_Observacion = q.cp_Observacion,
                        IdComprador = q.IdComprador,
                        IdSolicitante = q.IdSolicitante,
                        IdDepartamento = q.IdDepartamento,
                        EstadoJC = q.EstadoJC,
                        EstadoGA = q.EstadoGA,

                        Su_Descripcion = q.Su_Descripcion,
                        pe_nombreCompleto = q.pe_nombreCompleto,
                        TerminoPago = q.TerminoPago,
                        Comprador = q.Comprador,
                        nom_solicitante = q.nom_solicitante,
                        nom_departamento = q.nom_departamento,
                        cp_PlazoEntrega = q.cp_PlazoEntrega,
                        Pasado = q.Pasado,
                        IdOrdenPedido = q.opd_IdOrdenPedido,
                        Cargo = "JC",
                        EsCompraUrgente = q.EsCompraUrgente
                    }).ToList();

                    if (Cargo == "HIS")
                    {
                        Lista.AddRange(db.vwcom_CotizacionPedido.Where(q => q.IdEmpresa == IdEmpresa && q.EstadoJC != "P").Select(q => new com_CotizacionPedido_Info
                       {
                           IdEmpresa = q.IdEmpresa,
                           IdCotizacion = q.IdCotizacion,
                           IdSucursal = q.IdSucursal,
                           IdProveedor = q.IdProveedor,
                           IdTerminoPago = q.IdTerminoPago,
                           cp_Fecha = q.cp_Fecha,
                           cp_Plazo = q.cp_Plazo,
                           cp_Observacion = q.cp_Observacion,
                           IdComprador = q.IdComprador,
                           IdSolicitante = q.IdSolicitante,
                           IdDepartamento = q.IdDepartamento,
                           EstadoJC = q.EstadoJC,
                           EstadoGA = q.EstadoGA,

                           Su_Descripcion = q.Su_Descripcion,
                           pe_nombreCompleto = q.pe_nombreCompleto,
                           TerminoPago = q.TerminoPago,
                           Comprador = q.Comprador,
                           nom_solicitante = q.nom_solicitante,
                           nom_departamento = q.nom_departamento,
                           cp_PlazoEntrega = q.cp_PlazoEntrega,
                           Pasado = q.Pasado,
                           IdOrdenPedido = q.opd_IdOrdenPedido,
                           Cargo = "HIS",
                           EsCompraUrgente = q.EsCompraUrgente
                       }).ToList());   
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
