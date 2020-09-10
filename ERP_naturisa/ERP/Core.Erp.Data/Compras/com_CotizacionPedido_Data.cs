using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using System.Data.SqlClient;
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
                    decimal IdOrdenPedido = 0;
                    List<CotizacionesParaActualizar> Lista = new List<CotizacionesParaActualizar>();
                    using (EntitiesCompras db = new EntitiesCompras())
                    {
                        var Entity = db.com_CotizacionPedido.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdCotizacion == info.IdCotizacion).FirstOrDefault();
                        if (Entity == null)
                            return false;

                        #region Update estado JC o GA
                        if (Cargo == "JC")
                        {
                            Entity.EstadoJC = info.EstadoJC;
                            Entity.IdUsuarioJC = info.IdUsuario;
                            Entity.FechaJC = DateTime.Now;
                            Entity.cp_Observacion = info.cp_Observacion;
                        }
                        else
                            Entity.EstadoGA = info.EstadoGA;
                        #endregion

                        #region Update de estado de proceso en el detalle de la cotizacion y pedido
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
                        #endregion

                        #region Update cabecera de orden de pedido con la auditoria del aprobador GA
                        if (Cargo == "GA")
                        {
                            var lstPedido = info.ListaDetalle.GroupBy(q => q.opd_IdOrdenPedido).ToList();
                            foreach (var item in lstPedido)
                            {
                                var Pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenPedido == item.Key).FirstOrDefault();
                                if (Pedido != null)
                                {
                                    Pedido.IdUsuarioAprobacion = info.IdUsuario;
                                    Pedido.FechaAprobacion = DateTime.Now;
                                    Pedido.ObservacionGA = info.ObservacionAprobador;
                                    IdOrdenPedido = Pedido.IdOrdenPedidoReg ?? 0;
                                }
                            }
                        }
                        #endregion
                        
                        if (Cargo == "GA" && info.ListaDetalle.Where(q => q.EstadoGA).Count() > 0)
                        {
                            #region Cabecera OC
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
                            #endregion
                            
                            #region Detalle OC
                            int Secuencia = 1;
                            var lstGeneracion = info.ListaDetalle.Where(q => q.A && q.cd_Cantidad > 0).ToList();
                            foreach (var item in lstGeneracion)
                            {
                                var impuesto = odataImp.Get_Info_impuesto(item.IdCod_Impuesto);
                                if (impuesto != null)
                                {
                                    item.Por_Iva = impuesto.porcentaje;
                                    item.cd_iva = item.cd_subtotal * (impuesto.porcentaje / 100);
                                    item.cd_total = item.cd_subtotal + item.cd_iva;
                                }

                                Lista.Add(new CotizacionesParaActualizar
                                {
                                    SecuenciaPedido = item.opd_Secuencia,

                                    IdSucursal = info.IdSucursal,
                                    IdOrdenCompra = info.oc_IdOrdenCompra,
                                    SecuenciaOC = item.Secuencia,
                                    CostouniFinal = item.cd_precioFinal
                                });

                                db.com_ordencompra_local_det.Add(new com_ordencompra_local_det
                                {
                                    IdEmpresa = info.IdEmpresa,
                                    IdSucursal = info.IdSucursal,
                                    IdOrdenCompra = info.oc_IdOrdenCompra,
                                    Secuencia = item.Secuencia,
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
                                    do_observacion = (string.IsNullOrEmpty(item.cd_DetallePorItem) ? "" : item.cd_DetallePorItem + " ") + (string.IsNullOrEmpty(item.opd_Detalle) ? "" : item.opd_Detalle),
                                    IdSucursalDestino = item.IdSucursalDestino
                                });
                            }
                            #endregion
                            
                            Entity.oc_IdOrdenCompra = Convert.ToInt32(info.oc_IdOrdenCompra);
                        }
                        db.SaveChanges();

                        if (Cargo == "JC")
                        {
                            com_OrdenPedido_Data odataPedido = new com_OrdenPedido_Data();
                            odataPedido.SaltarPaso5(info.IdEmpresa, info.IdOrdenPedido ?? 0, info.IdUsuario);
                        }
                        else
                        {
                            if (IdOrdenPedido > 0)
                            {
                                foreach (var item in Lista)
                                {
                                    ReemplazarCotizacionesIngresadas(info.IdEmpresa, IdOrdenPedido, item.SecuenciaPedido, item.IdSucursal, item.IdOrdenCompra, item.SecuenciaOC, item.CostouniFinal);
                                }
                            }
                        }
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

        public bool ReemplazarCotizacionesIngresadas(int IdEmpresa, decimal IdOrdenPedido, int Secuencia, int IdSucursal, decimal IdOrdenCompra, int SecuenciaOC, double CostoUniFinal)
        {
            try
            {
                string query = "update in_Ing_Egr_Inven_det set IdSucursal_oc = " + IdSucursal.ToString() + ", IdOrdenCompra = " + IdOrdenCompra.ToString() + ", Secuencia_oc = " + SecuenciaOC.ToString() + ", mv_costo_sinConversion =" + CostoUniFinal.ToString() + ", mv_costo = (dm_cantidad_sinConversion * " + CostoUniFinal.ToString() + ") / dm_cantidad"
                            + " FROM("
                            + " select a.IdEmpresa, a.IdOrdenPedido, a.Secuencia, e.IdSucursal, e.IdMovi_inven_tipo, e.IdNumMovi, e.Secuencia SecuenciaInv"
                            + " from com_OrdenPedidoDet as a inner join"
                            + " com_CotizacionPedidoDet as b on a.IdEmpresa = b.opd_IdEmpresa and a.IdOrdenPedido = b.opd_IdOrdenPedido and a.Secuencia = b.opd_Secuencia inner join"
                            + " com_CotizacionPedido as c on b.IdEmpresa = c.IdEmpresa and b.IdCotizacion = c.IdCotizacion inner join"
                            + " com_ordencompra_local_det as d on d.IdEmpresa = c.IdEmpresa and d.IdSucursal = c.IdSucursal and c.oc_IdOrdenCompra = d.IdOrdenCompra and d.Secuencia = b.Secuencia left join"
                            + " in_Ing_Egr_Inven_det as e on d.IdEmpresa = e.IdEmpresa_oc and d.IdOrdenCompra = e.IdOrdenCompra and d.Secuencia = e.Secuencia_oc and d.IdSucursal = e.IdSucursal_oc and d.Secuencia = e.Secuencia_oc"
                            + " where a.IdEmpresa = "+IdEmpresa.ToString()+" and a.IdOrdenPedido = "+IdOrdenPedido.ToString()+" and a.Secuencia = "+Secuencia.ToString()
                            + " ) A"
                            + " WHERE in_Ing_Egr_Inven_det.IdEmpresa = A.IdEmpresa"
                            + " AND in_Ing_Egr_Inven_det.IdSucursal = A.IdSucursal"
                            + " AND in_Ing_Egr_Inven_det.IdMovi_inven_tipo = A.IdMovi_inven_tipo"
                            + " AND in_Ing_Egr_Inven_det.IdNumMovi = A.IdNumMovi"
                            + " AND in_Ing_Egr_Inven_det.Secuencia = A.SecuenciaInv";

                string queryAprobado = "update in_movi_inve_detalle set mv_costo_sinConversion =" + CostoUniFinal.ToString() + ", mv_costo = (dm_cantidad_sinConversion * " + CostoUniFinal.ToString() + ") / dm_cantidad"
                            + " FROM("
                            + " select a.IdEmpresa, a.IdOrdenPedido, a.Secuencia, e.IdSucursal_inv, e.IdBodega_inv, e.IdMovi_inven_tipo_inv, e.IdNumMovi_inv, e.secuencia_inv"
                            + " from com_OrdenPedidoDet as a inner join"
                            + " com_CotizacionPedidoDet as b on a.IdEmpresa = b.opd_IdEmpresa and a.IdOrdenPedido = b.opd_IdOrdenPedido and a.Secuencia = b.opd_Secuencia inner join"
                            + " com_CotizacionPedido as c on b.IdEmpresa = c.IdEmpresa and b.IdCotizacion = c.IdCotizacion inner join"
                            + " com_ordencompra_local_det as d on d.IdEmpresa = c.IdEmpresa and d.IdSucursal = c.IdSucursal and c.oc_IdOrdenCompra = d.IdOrdenCompra and d.Secuencia = b.Secuencia left join"
                            + " in_Ing_Egr_Inven_det as e on d.IdEmpresa = e.IdEmpresa_oc and d.IdOrdenCompra = e.IdOrdenCompra and d.Secuencia = e.Secuencia_oc and d.IdSucursal = e.IdSucursal_oc and d.Secuencia = e.Secuencia_oc"
                            + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.IdOrdenPedido = " + IdOrdenPedido.ToString() + " and a.Secuencia = " + Secuencia.ToString()
                            + " ) A"
                            + " WHERE in_movi_inve_detalle.IdEmpresa = A.IdEmpresa"
                            + " AND in_movi_inve_detalle.IdSucursal = A.IdSucursal_inv"
                            + " AND in_movi_inve_detalle.IdBodega = A.IdBodega_inv"
                            + " AND in_movi_inve_detalle.IdMovi_inven_tipo = A.IdMovi_inven_tipo_inv"
                            + " AND in_movi_inve_detalle.IdNumMovi = A.IdNumMovi_inv"
                            + " AND in_movi_inve_detalle.Secuencia = A.secuencia_inv";

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand commandAprobado = new SqlCommand(queryAprobado,connection);
                    commandAprobado.ExecuteNonQuery();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
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

    public class CotizacionesParaActualizar
    {
        public int SecuenciaPedido { get; set; }

        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int SecuenciaOC { get; set; }

        public double CostouniFinal { get; set; }
    }
}
