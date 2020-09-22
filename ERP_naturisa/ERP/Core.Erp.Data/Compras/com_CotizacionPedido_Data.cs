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

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT TOP 1 c.IdEmpresa, c.IdCotizacion, c.IdSucursal, c.IdProveedor, c.IdTerminoPago, c.cp_Fecha, c.cp_Plazo, c.cp_Observacion, "
                                + " c.IdComprador, c.IdSolicitante, c.IdDepartamento, c.EstadoJC, c.EstadoGA, suc.Su_Descripcion, "
                                + " per.pe_nombreCompleto, tp.Descripcion AS TerminoPago, com.Descripcion AS Comprador, sol.nom_solicitante, dep.nom_departamento, CASE WHEN saltar.IdEmpresa IS NULL THEN CAST(0 AS bit) "
                                + " ELSE CAST(1 AS bit) END AS Pasado, c.cp_PlazoEntrega, d.opd_IdOrdenPedido, c.cp_ObservacionAdicional, dbo.com_OrdenPedido.EsCompraUrgente, com_OrdenPedido.IdOrdenPedidoReg"
                                + " FROM     dbo.com_OrdenPedido RIGHT OUTER JOIN"
                                + " (SELECT IdEmpresa, IdCotizacion, MAX(opd_IdOrdenPedido) AS opd_IdOrdenPedido"
                                + " FROM      dbo.com_CotizacionPedidoDet"
                                + " GROUP BY IdEmpresa, IdCotizacion) AS d ON dbo.com_OrdenPedido.IdEmpresa = d.IdEmpresa AND dbo.com_OrdenPedido.IdOrdenPedido = d.opd_IdOrdenPedido RIGHT OUTER JOIN"
                                + " dbo.com_departamento AS dep INNER JOIN"
                                + " dbo.tb_persona AS per INNER JOIN"
                                + " dbo.tb_sucursal AS suc INNER JOIN"
                                + " dbo.com_CotizacionPedido AS c ON suc.IdEmpresa = c.IdEmpresa AND suc.IdSucursal = c.IdSucursal INNER JOIN"
                                + " dbo.cp_proveedor AS pro ON c.IdEmpresa = pro.IdEmpresa AND c.IdProveedor = pro.IdProveedor ON per.IdPersona = pro.IdPersona INNER JOIN"
                                + " dbo.com_TerminoPago AS tp ON c.IdTerminoPago = tp.IdTerminoPago INNER JOIN"
                                + " dbo.com_comprador AS com ON c.IdEmpresa = com.IdEmpresa AND c.IdComprador = com.IdComprador INNER JOIN"
                                + " dbo.com_solicitante AS sol ON c.IdSolicitante = sol.IdSolicitante AND c.IdEmpresa = sol.IdEmpresa ON dep.IdEmpresa = c.IdEmpresa AND dep.IdDepartamento = c.IdDepartamento LEFT OUTER JOIN"
                                + " dbo.com_CotizacionPedidoSaltar AS saltar ON c.IdEmpresa = saltar.IdEmpresa AND c.IdCotizacion = saltar.IdCotizacion ON d.IdEmpresa = c.IdEmpresa AND d.IdCotizacion = c.IdCotizacion"
                                + " WHERE  (c.EstadoJC = 'P') and c.IdEmpresa = " + IdEmpresa.ToString() + " AND NOT EXISTS"
                                + " ("
                                + " SELECT f.IdEmpresa FROM com_CotizacionPedidoSaltar AS F"
                                + " WHERE c.IdEmpresa = f.IdEmpresa and c.IdCotizacion = f.IdCotizacion and f.IdUsuario = '"+IdUsuario+"'"
                                + " )";
                    SqlCommand command = new SqlCommand(query, connection);
                    int EjecutarReader = 0;
                    var Validation = command.ExecuteScalar();
                    if (Validation == null)
                    {
                        string queryDelete = "DELETE com_CotizacionPedidoSaltar WHERE IdEmpresa = " + IdEmpresa.ToString() + " and IdUsuario = '" + IdUsuario + "'";
                        SqlCommand commandDelete = new SqlCommand(queryDelete, connection);
                        commandDelete.ExecuteNonQuery();

                        var ValidationAfterDelete = command.ExecuteScalar();
                        if (ValidationAfterDelete != null)
                            EjecutarReader = 1;
                        else
                            return null;
                    }
                    else
                        EjecutarReader = 1;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        info = new com_CotizacionPedido_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdCotizacion = Convert.ToDecimal(reader["IdCotizacion"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdProveedor = Convert.ToDecimal(reader["IdProveedor"]),
                            IdTerminoPago = Convert.ToString(reader["IdTerminoPago"]),
                            cp_Fecha = Convert.ToDateTime(reader["cp_Fecha"]),
                            cp_Plazo = Convert.ToInt32(reader["cp_Plazo"]),
                            cp_Observacion = Convert.ToString(reader["cp_Observacion"]),
                            IdComprador = Convert.ToDecimal(reader["IdComprador"]),
                            IdSolicitante = Convert.ToDecimal(reader["IdSolicitante"]),
                            IdDepartamento = Convert.ToDecimal(reader["IdDepartamento"]),
                            EstadoJC = Convert.ToString(reader["EstadoJC"]),
                            EstadoGA = Convert.ToString(reader["EstadoGA"]),
                            Su_Descripcion = Convert.ToString(reader["Su_Descripcion"]),
                            pe_nombreCompleto = Convert.ToString(reader["pe_nombreCompleto"]),
                            TerminoPago = Convert.ToString(reader["TerminoPago"]),
                            Comprador = Convert.ToString(reader["Comprador"]),
                            nom_solicitante = Convert.ToString(reader["nom_solicitante"]),
                            nom_departamento = Convert.ToString(reader["nom_departamento"]),
                            Pasado = Convert.ToBoolean(reader["Pasado"]),
                            cp_PlazoEntrega = Convert.ToInt32(reader["cp_PlazoEntrega"]),
                            IdOrdenPedido = Convert.ToDecimal(reader["opd_IdOrdenPedido"]),
                            cp_ObservacionAdicional = Convert.ToString(reader["cp_ObservacionAdicional"]),
                            EsCompraUrgente = Convert.ToBoolean(reader["EsCompraUrgente"]),
                            IdOrdenPedidoReg = string.IsNullOrEmpty(reader["IdOrdenPedidoReg"].ToString()) ? null : (decimal?)reader["IdOrdenPedidoReg"]
                        };
                    }
                    reader.Close();
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

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    string query = "select a.IdEmpresa,a.IdCotizacion, a.IdSucursal, a.IdProveedor, a.IdTerminoPago, a.cp_Fecha, a.cp_Plazo, "
                                +" a.cp_Observacion, a.IdComprador,a.IdSolicitante, a.IdDepartamento, a.EstadoJC, a.EstadoGA, a.cp_PlazoEntrega, "
                                +" a.cp_ObservacionAdicional, b.IdOrdenPedidoReg"
                                +" from com_CotizacionPedido as a inner join "
                                +" com_OrdenPedido as b on a.IdEmpresa = b.IdEmpresa and a.IdOrdenPedido = b.IdOrdenPedido"
                                +" where a.IdEmpresa  = "+IdEmpresa.ToString()+" and a.IdCotizacion = "+IdCotizacion.ToString();
                    SqlCommand command = new SqlCommand(query, connection);
                    var Validate = command.ExecuteScalar();
                    if (Validate == null)
                        return null;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        info = new com_CotizacionPedido_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdCotizacion = Convert.ToDecimal(reader["IdCotizacion"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdProveedor = Convert.ToDecimal(reader["IdProveedor"]),
                            IdTerminoPago = Convert.ToString(reader["IdTerminoPago"]),
                            cp_Fecha = Convert.ToDateTime(reader["cp_Fecha"]),
                            cp_Plazo = Convert.ToInt32(reader["cp_Plazo"]),
                            cp_Observacion = Convert.ToString(reader["cp_Observacion"]),
                            IdComprador = Convert.ToInt32(reader["IdComprador"]),
                            IdSolicitante = Convert.ToInt32(reader["IdSolicitante"]),
                            IdDepartamento = Convert.ToInt32(reader["IdDepartamento"]),
                            EstadoJC = Convert.ToString(reader["EstadoJC"]),
                            EstadoGA = Convert.ToString(reader["EstadoGA"]),
                            cp_PlazoEntrega = Convert.ToInt32(reader["cp_PlazoEntrega"]),
                            cp_ObservacionAdicional = Convert.ToString(reader["cp_ObservacionAdicional"]),
                            IdOrdenPedidoReg = string.IsNullOrEmpty(reader["IdOrdenPedidoReg"].ToString()) ? null : (decimal?)reader["IdOrdenPedidoReg"]
                        };
                    }
                    reader.Close();
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
                List<com_CotizacionPedido_Info> Lista = new List<com_CotizacionPedido_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT c.IdEmpresa, c.IdCotizacion, c.IdSucursal, c.IdProveedor, c.IdTerminoPago, c.cp_Fecha, c.cp_Plazo, c.cp_Observacion, "
                                + " c.IdComprador, c.IdSolicitante, c.IdDepartamento, c.EstadoJC, c.EstadoGA, suc.Su_Descripcion, "
                                + " per.pe_nombreCompleto, tp.Descripcion AS TerminoPago, com.Descripcion AS Comprador, sol.nom_solicitante, dep.nom_departamento, CASE WHEN saltar.IdEmpresa IS NULL THEN CAST(0 AS bit) "
                                + " ELSE CAST(1 AS bit) END AS Pasado, c.cp_PlazoEntrega, d.opd_IdOrdenPedido, c.cp_ObservacionAdicional, dbo.com_OrdenPedido.EsCompraUrgente, com_OrdenPedido.IdOrdenPedidoReg"
                                + " FROM     dbo.com_OrdenPedido RIGHT OUTER JOIN"
                                + " (SELECT IdEmpresa, IdCotizacion, MAX(opd_IdOrdenPedido) AS opd_IdOrdenPedido"
                                + " FROM      dbo.com_CotizacionPedidoDet"
                                + " GROUP BY IdEmpresa, IdCotizacion) AS d ON dbo.com_OrdenPedido.IdEmpresa = d.IdEmpresa AND dbo.com_OrdenPedido.IdOrdenPedido = d.opd_IdOrdenPedido RIGHT OUTER JOIN"
                                + " dbo.com_departamento AS dep INNER JOIN"
                                + " dbo.tb_persona AS per INNER JOIN"
                                + " dbo.tb_sucursal AS suc INNER JOIN"
                                + " dbo.com_CotizacionPedido AS c ON suc.IdEmpresa = c.IdEmpresa AND suc.IdSucursal = c.IdSucursal INNER JOIN"
                                + " dbo.cp_proveedor AS pro ON c.IdEmpresa = pro.IdEmpresa AND c.IdProveedor = pro.IdProveedor ON per.IdPersona = pro.IdPersona INNER JOIN"
                                + " dbo.com_TerminoPago AS tp ON c.IdTerminoPago = tp.IdTerminoPago INNER JOIN"
                                + " dbo.com_comprador AS com ON c.IdEmpresa = com.IdEmpresa AND c.IdComprador = com.IdComprador INNER JOIN"
                                + " dbo.com_solicitante AS sol ON c.IdSolicitante = sol.IdSolicitante AND c.IdEmpresa = sol.IdEmpresa ON dep.IdEmpresa = c.IdEmpresa AND dep.IdDepartamento = c.IdDepartamento LEFT OUTER JOIN"
                                + " dbo.com_CotizacionPedidoSaltar AS saltar ON c.IdEmpresa = saltar.IdEmpresa AND c.IdCotizacion = saltar.IdCotizacion ON d.IdEmpresa = c.IdEmpresa AND d.IdCotizacion = c.IdCotizacion"
                                + " WHERE  (c.EstadoJC  "+(Cargo == "HIS" ? " <> 'P'" :  "='P'")+") and c.IdEmpresa = " + IdEmpresa.ToString();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new com_CotizacionPedido_Info
                        {
                            Cargo = Cargo,
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdCotizacion = Convert.ToDecimal(reader["IdCotizacion"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdProveedor = Convert.ToDecimal(reader["IdProveedor"]),
                            IdTerminoPago = Convert.ToString(reader["IdTerminoPago"]),
                            cp_Fecha = Convert.ToDateTime(reader["cp_Fecha"]),
                            cp_Plazo = Convert.ToInt32(reader["cp_Plazo"]),
                            cp_Observacion = Convert.ToString(reader["cp_Observacion"]),
                            IdComprador = Convert.ToDecimal(reader["IdComprador"]),
                            IdSolicitante = Convert.ToDecimal(reader["IdSolicitante"]),
                            IdDepartamento = Convert.ToDecimal(reader["IdDepartamento"]),
                            EstadoJC = Convert.ToString(reader["EstadoJC"]),
                            EstadoGA = Convert.ToString(reader["EstadoGA"]),
                            Su_Descripcion = Convert.ToString(reader["Su_Descripcion"]),
                            pe_nombreCompleto = Convert.ToString(reader["pe_nombreCompleto"]),
                            TerminoPago = Convert.ToString(reader["TerminoPago"]),
                            Comprador = Convert.ToString(reader["Comprador"]),
                            nom_solicitante = Convert.ToString(reader["nom_solicitante"]),
                            nom_departamento = Convert.ToString(reader["nom_departamento"]),
                            Pasado = Convert.ToBoolean(reader["Pasado"]),
                            cp_PlazoEntrega = Convert.ToInt32(reader["cp_PlazoEntrega"]),
                            IdOrdenPedido = string.IsNullOrEmpty(reader["opd_IdOrdenPedido"].ToString()) ? null : (decimal?)reader["opd_IdOrdenPedido"],
                            cp_ObservacionAdicional = Convert.ToString(reader["cp_ObservacionAdicional"]),
                            EsCompraUrgente = string.IsNullOrEmpty(reader["EsCompraUrgente"].ToString()) ? null : (bool?)reader["EsCompraUrgente"],
                            IdOrdenPedidoReg = string.IsNullOrEmpty(reader["IdOrdenPedidoReg"].ToString()) ? null : (decimal?)reader["IdOrdenPedidoReg"]
                        });
                    }
                    reader.Close();
                
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
