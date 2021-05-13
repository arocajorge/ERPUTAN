using Core.Erp.Data.Inventario;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_CotizacionPedidoDet_Data
    {
        public List<com_CotizacionPedidoDet_Info> GetList(int IdEmpresa, decimal IdCotizacion, string Cargo)
        {
            try
            {
                List<com_CotizacionPedidoDet_Info> Lista = new List<com_CotizacionPedidoDet_Info>();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    db.SetCommandTimeOut(3000);
                    Lista = db.vwcom_CotizacionPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdCotizacion == IdCotizacion).Select(q => new com_CotizacionPedidoDet_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdCotizacion = q.IdCotizacion,
                        Secuencia = q.Secuencia,
                        opd_IdEmpresa = q.opd_IdEmpresa,
                        opd_IdOrdenPedido = q.opd_IdOrdenPedido,
                        opd_Secuencia = q.opd_Secuencia,
                        IdProducto = q.IdProducto,
                        cd_Cantidad = q.cd_Cantidad,
                        cd_precioCompra = q.cd_precioCompra,
                        cd_porc_des = q.cd_porc_des,
                        cd_descuento = q.cd_descuento,
                        cd_precioFinal = q.cd_precioFinal,
                        cd_subtotal = q.cd_subtotal,
                        IdCod_Impuesto = q.IdCod_Impuesto,
                        Por_Iva = q.Por_Iva,
                        cd_iva = q.cd_iva,
                        cd_total = q.cd_total,
                        IdUnidadMedida = q.IdUnidadMedida,
                        IdPunto_cargo = q.IdPunto_cargo,
                        EstadoGA = q.EstadoGA,
                        EstadoJC = q.EstadoJC,
                        pr_descripcion = q.pr_descripcion,
                        NomUnidadMedida = q.NomUnidadMedida,
                        nom_impuesto = q.nom_impuesto,
                        nom_punto_cargo = q.nom_punto_cargo,
                        A = true,
                        cd_DetallePorItem = q.cd_DetallePorItem,
                        op_Observacion = q.op_Observacion,
                        opd_Detalle = q.opd_Detalle,
                        FechaCantidad = q.FechaCantidad,
                        Adjunto = q.Adjunto ?? false,
                        NombreArchivo = q.NombreArchivo
                    }).ToList();
                }

                using (EntitiesInventario db = new EntitiesInventario())
                {
                    db.SetCommandTimeOut(3000);
                    foreach (var item in Lista)
                    {
                        var MejorPrecio = db.SPINV_MejorPrecio(IdEmpresa, item.IdProducto).FirstOrDefault();
                        if (MejorPrecio != null)
                            item.MejorPrecio = MejorPrecio.MejorPrecio ?? 0;

                        double Diferencia = item.cd_precioFinal - item.MejorPrecio;
                        item.Color = Diferencia > 0 ? System.Drawing.Color.Red : System.Drawing.Color.Green;
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_CotizacionPedidoDet_Info> GetListCotizacion(int IdEmpresa, string IdUsuario_com, DateTime FechaIni, DateTime FechaFin, bool MostrarAR)
        {
            try
            {
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;

                List<com_CotizacionPedidoDet_Info> Lista = new List<com_CotizacionPedidoDet_Info>();
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT d.IdEmpresa, d.IdOrdenPedido, d.Secuencia, ISNULL(p.pr_descripcion, d.pr_descripcion) AS pr_descripcion, d.IdUnidadMedida, d.IdSucursalOrigen, d.IdSucursalDestino, ISNULL(d.IdPunto_cargo, Cod.IdPunto_cargo) AS IdPunto_cargo, "
                                +" d.opd_Cantidad, d.opd_CantidadApro, d.opd_EstadoProceso, d.opd_Detalle, p.IdUnidadMedida_Consumo, CAST(0 AS float) AS Stock, s.nom_solicitante, d.IdProducto, dbo.com_comprador.IdUsuario_com, ISNULL(Cod.IdCod_Impuesto, "
                                +" p.IdCod_Impuesto_Iva) AS IdCod_Impuesto_Iva, c.IdSolicitante, c.IdDepartamento, isnull(dbo.com_comprador_familia.IdComprador,0) IdComprador, c.EsCompraUrgente, d.Adjunto, c.op_Fecha, c.op_Observacion, d.NombreArchivo, "
                                +" CASE WHEN d .opd_EstadoProceso = 'AC' OR d .opd_EstadoProceso = 'AJC' OR d .opd_EstadoProceso = 'C' OR d .opd_EstadoProceso = 'T' OR"
                                +" d .opd_EstadoProceso IN ('RGA', 'I') THEN '4. APROBADOS' WHEN d .opd_EstadoProceso = 'RC' THEN '5. RECHAZADO' WHEN c.EsCompraUrgente = 1 THEN '1. URGENTE' WHEN d .IdProducto IS NULL "
                                + " THEN '3. NO CREADOS' ELSE '2. NORMALES' END AS Grupo, d.FechaCantidad, coc.IdProveedor, isnull(Cod.cd_precioCompra,0) cd_precioCompra, isnull(Cod.cd_porc_des,0) cd_porc_des, isnull(Cod.cd_descuento,0) cd_descuento, "
                                +" isnull(Cod.cd_precioFinal,0) cd_precioFinal, isnull(Cod.cd_subtotal,0) cd_subtotal, isnull(Cod.Por_Iva,0) Por_Iva, isnull(Cod.cd_iva,0) cd_iva, isnull(Cod.cd_total,0)cd_total, "
                                +" Cod.cd_DetallePorItem, CASE WHEN d .opd_EstadoProceso = 'P' THEN 'PENDIENTE' WHEN d .opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' WHEN d .opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' WHEN d .opd_EstadoProceso = 'AJC' THEN"
                                +" 'PRECIO APROBADO' WHEN d .opd_EstadoProceso = 'C' THEN 'OC GENERADA' WHEN d .opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' WHEN d .opd_EstadoProceso = 'AC' THEN 'COTIZADO' WHEN d .opd_EstadoProceso"
                                +" = 'RGA' THEN 'COTIZACION RECHAZADA' WHEN d .opd_EstadoProceso = 'I' THEN 'INGRESADO A BODEGA' WHEN d .opd_EstadoProceso = 'T' THEN 'TRANSFERIDO' END AS EstadoDetalle, c.ObservacionGA, su.Su_Descripcion, "
                                + " su.codigo + '-' + CAST(coc.oc_IdOrdenCompra AS varchar(20)) AS CodigoOC, case when  d.IdProducto is null then cast(1 as bit) else cast(0 as bit) end Agregar, case when  d.IdProducto is null then cast(1 as bit) else cast(0 as bit) end Selec, "
                                + " d.IdOrdenPedidoReg, case when d.IdOrdenPedidoReg is null then cast(0 as bit) else cast(1 as bit) end as EsRegularizacion, d.SecuenciaReg, f.fa_Descripcion"
                                +" FROM     dbo.com_comprador with (nolock) INNER JOIN"
                                + " dbo.com_comprador_familia with (nolock) ON dbo.com_comprador.IdEmpresa = dbo.com_comprador_familia.IdEmpresa AND dbo.com_comprador.IdComprador = dbo.com_comprador_familia.IdComprador INNER JOIN"
                                + " dbo.in_Producto AS p with (nolock) ON dbo.com_comprador_familia.IdEmpresa = p.IdEmpresa AND dbo.com_comprador_familia.IdFamilia = p.IdFamilia RIGHT OUTER JOIN"
                                + " dbo.com_OrdenPedidoDet AS d with (nolock) INNER JOIN"
                                + " dbo.com_OrdenPedido AS c with (nolock) ON c.IdEmpresa = d.IdEmpresa AND c.IdOrdenPedido = d.IdOrdenPedido INNER JOIN"
                                + " dbo.com_solicitante AS s with (nolock) ON s.IdEmpresa = c.IdEmpresa AND s.IdSolicitante = c.IdSolicitante ON p.IdEmpresa = d.IdEmpresa AND p.IdProducto = d.IdProducto LEFT OUTER JOIN"
                                + " dbo.com_CotizacionPedidoDet AS Cod with (nolock) ON d.IdEmpresa = Cod.opd_IdEmpresa AND d.IdOrdenPedido = Cod.opd_IdOrdenPedido AND d.Secuencia = Cod.opd_Secuencia AND Cod.EstadoJC = 1 LEFT OUTER JOIN"
                                + " dbo.com_CotizacionPedido AS coc with (nolock) ON coc.IdEmpresa = Cod.IdEmpresa AND coc.IdCotizacion = Cod.IdCotizacion AND coc.EstadoJC <> 'R' LEFT OUTER JOIN"
                                + " dbo.tb_sucursal AS su with (nolock) ON coc.IdEmpresa = su.IdEmpresa AND coc.IdSucursal = su.IdSucursal"
                                + " left join in_familia as f with (nolock) on p.IdEmpresa = f.IdEmpresa and p.IdFamilia = f.IdFamilia"
                                +" WHERE  (c.Estado = 1) AND (d.opd_EstadoProceso NOT IN ('RA', 'P')) and d.opd_EstadoProceso = "+(MostrarAR ? "d.opd_EstadoProceso" : "'A'")+" "
                                + " and c.IdEmpresa = " + IdEmpresa.ToString() + " and isnull(com_comprador.IdUsuario_com,'" + IdUsuario_com + "') = '" + IdUsuario_com + "' and c.op_Fecha between DATEFROMPARTS("+FechaIni.Year.ToString()+","+FechaIni.Month.ToString()+","+FechaIni.Day.ToString()+") and DATEFROMPARTS("+FechaFin.Year.ToString()+","+FechaFin.Month.ToString()+","+FechaFin.Day.ToString()+")";

                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new com_CotizacionPedidoDet_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            opd_IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            opd_IdOrdenPedido = Convert.ToDecimal(reader["IdOrdenPedido"]),
                            opd_Secuencia = Convert.ToInt32(reader["Secuencia"]),
                            IdUnidadMedida = Convert.ToString(reader["IdUnidadMedida"]),
                            IdPunto_cargo = string.IsNullOrEmpty(reader["IdPunto_cargo"].ToString()) ? null : (int?)(reader["IdPunto_cargo"]),
                            EsRegularizacion = Convert.ToBoolean(reader["EsRegularizacion"]),

                            IdOrdenPedidoReg = string.IsNullOrEmpty((reader["IdOrdenPedidoReg"]).ToString()) ? null : (decimal?)(reader["IdOrdenPedidoReg"]),
                            SecuenciaReg = string.IsNullOrEmpty((reader["SecuenciaReg"]).ToString()) ? null : (int?)(reader["SecuenciaReg"]),
                            
                            IdSucursalOrigen = Convert.ToInt32(reader["IdSucursalOrigen"]),
                            IdSucursalDestino = Convert.ToInt32(reader["IdSucursalDestino"]),                            
                            cd_Cantidad = Convert.ToDouble(reader["opd_CantidadApro"]),
                            IdCod_Impuesto = Convert.ToString(reader["IdCod_Impuesto_Iva"]),
                            pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                            opd_Detalle = Convert.ToString(reader["opd_Detalle"]),
                            IdProducto = string.IsNullOrEmpty(reader["IdProducto"].ToString()) ? null : (decimal?)(reader["IdProducto"]),
                            IdUnidadMedida_Consumo = Convert.ToString(reader["IdUnidadMedida_Consumo"]),
                            Stock = Convert.ToInt32(reader["Stock"]),
                            nom_solicitante = Convert.ToString(reader["nom_solicitante"]),

                            IdDepartamento = Convert.ToDecimal(reader["IdDepartamento"]),
                            IdSolicitante = Convert.ToDecimal(reader["IdSolicitante"]),
                            IdComprador = string.IsNullOrEmpty(reader["IdComprador"].ToString()) ? 0 : Convert.ToDecimal(reader["IdComprador"]),

                            Add = Convert.ToBoolean(reader["Agregar"]),
                            Selec = Convert.ToBoolean(reader["Selec"]),
                            Grupo = Convert.ToString(reader["Grupo"]),
                            Adjunto = Convert.ToBoolean(reader["Adjunto"]),

                            op_Observacion = Convert.ToString(reader["op_Observacion"]),
                            op_Fecha = Convert.ToDateTime(reader["op_Fecha"]),
                            NombreArchivo = Convert.ToString(reader["NombreArchivo"]),
                            opd_EstadoProceso = Convert.ToString(reader["opd_EstadoProceso"]),
                            FechaCantidad = Convert.ToDateTime(reader["FechaCantidad"]),

                            IdProveedor = string.IsNullOrEmpty(reader["IdProveedor"].ToString()) ? null : (decimal?)(reader["IdProveedor"]),
                            cd_precioCompra = Convert.ToDouble(reader["cd_precioCompra"]),
                            cd_porc_des = Convert.ToDouble(reader["cd_porc_des"]),
                            cd_descuento = Convert.ToDouble(reader["cd_descuento"]),
                            cd_precioFinal = Convert.ToDouble(reader["cd_precioFinal"]),
                            cd_subtotal = Convert.ToDouble(reader["cd_subtotal"]),
                            Por_Iva = Convert.ToDouble(reader["Por_Iva"]),
                            cd_iva = Convert.ToDouble(reader["cd_iva"]),
                            cd_total = Convert.ToDouble(reader["cd_total"]),
                            cd_DetallePorItem = Convert.ToString(reader["cd_DetallePorItem"]),

                            EstadoDetalle = Convert.ToString(reader["EstadoDetalle"]),
                            CodigoOC = Convert.ToString(reader["CodigoOC"]),
                            su_Descripcion = Convert.ToString(reader["su_Descripcion"]),
                            ObservacionGA = Convert.ToString(reader["ObservacionGA"]),

                            fa_Descripcion = reader["fa_Descripcion"].ToString()
                        });
                    }
                    reader.Close();
                }
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Comprador = db.com_comprador.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario_com == IdUsuario_com).FirstOrDefault();
                    Lista.ForEach(q => { q.op_Observacion = "Pedido #" + q.opd_IdOrdenPedido.ToString() + " " + q.op_Fecha.ToString("dd/MM/yyyy") + " " + q.op_Observacion; q.IdComprador = q.IdComprador == 0 ? Comprador.IdComprador : q.IdComprador; });    
                }
                
                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_CotizacionPedidoDet_Info> GetListPedido(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                List<com_CotizacionPedidoDet_Info> Lista = new List<com_CotizacionPedidoDet_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string QueryConsulta = "SELECT d.IdEmpresa, d.IdOrdenPedido, d.Secuencia, c.IdProducto, ISNULL(p.pr_descripcion, d.pr_descripcion) AS pr_descripcion, c.IdCotizacion, ISNULL(c.cd_Cantidad, d.opd_CantidadApro) AS cd_cantidad, isnull(c.cd_precioCompra,0) cd_precioCompra, isnull(c.cd_porc_des,0) cd_porc_des, "
                                        + " isnull(c.cd_descuento,0) cd_descuento, isnull(c.cd_precioFinal,0) cd_precioFinal, isnull(c.cd_subtotal,0) cd_subtotal, c.IdCod_Impuesto, isnull(c.Por_Iva,0) Por_Iva, isnull(c.cd_iva,0) cd_iva, isnull(c.cd_total,0) cd_total, c.IdUnidadMedida, ISNULL(c.IdPunto_cargo, d.IdPunto_cargo) AS IdPunto_cargo, pc.nom_punto_cargo, dc.IdSolicitante, "
                                        + " dc.IdDepartamento, sol.nom_solicitante, u.Descripcion AS nomUnidadMedida, "
                                        + " CASE WHEN d .opd_EstadoProceso = 'P' THEN 'PENDIENTE' WHEN d .opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' WHEN d .opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' WHEN d .opd_EstadoProceso = 'AJC' THEN"
                                        + " 'PRECIO APROBADO' WHEN d .opd_EstadoProceso = 'C' THEN 'COMPRADO' WHEN d .opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' WHEN d .opd_EstadoProceso = 'AC' THEN 'COTIZADO' WHEN d .opd_EstadoProceso"
                                        + " = 'RGA' THEN 'COTIZACION RECHAZADA' END AS EstadoDetalle, d.opd_EstadoProceso, d.IdSucursalDestino, d.IdSucursalOrigen, c.Secuencia AS SecuenciaCot, c.cd_DetallePorItem, dbo.com_CotizacionPedido.cp_Observacion, "
                                        + " dbo.com_CotizacionPedido.cp_ObservacionAdicional, ISNULL(dbo.com_CotizacionPedido.cp_Fecha, CAST(GETDATE() AS date)) AS cp_Fecha, dbo.com_comprador.Descripcion AS Comprador, d.opd_Detalle"
                                        + " FROM     dbo.com_comprador INNER JOIN"
                                        + " dbo.com_CotizacionPedido ON dbo.com_comprador.IdEmpresa = dbo.com_CotizacionPedido.IdEmpresa AND dbo.com_comprador.IdComprador = dbo.com_CotizacionPedido.IdComprador RIGHT OUTER JOIN"
                                        + " dbo.com_OrdenPedidoDet AS d LEFT OUTER JOIN"
                                        + " dbo.com_CotizacionPedidoDet AS c ON d.IdEmpresa = c.opd_IdEmpresa AND d.IdOrdenPedido = c.opd_IdOrdenPedido AND d.Secuencia = c.opd_Secuencia AND c.EstadoJC = 1 LEFT OUTER JOIN"
                                        + " dbo.in_Producto AS p ON c.IdEmpresa = p.IdEmpresa AND c.IdProducto = p.IdProducto LEFT OUTER JOIN"
                                        + " dbo.ct_punto_cargo AS pc ON d.IdEmpresa = pc.IdEmpresa AND ISNULL(c.IdPunto_cargo, d.IdPunto_cargo) = pc.IdPunto_cargo INNER JOIN"
                                        + " dbo.com_OrdenPedido AS dc ON dc.IdEmpresa = d.IdEmpresa AND dc.IdOrdenPedido = d.IdOrdenPedido INNER JOIN"
                                        + " dbo.com_solicitante AS sol ON dc.IdEmpresa = sol.IdEmpresa AND dc.IdSolicitante = sol.IdSolicitante ON dbo.com_CotizacionPedido.IdEmpresa = c.IdEmpresa AND "
                                        + " dbo.com_CotizacionPedido.IdCotizacion = c.IdCotizacion LEFT OUTER JOIN"
                                        + " dbo.in_UnidadMedida AS u ON d.IdUnidadMedida = u.IdUnidadMedida"
                                        + " WHERE d.IdEmpresa = "+IdEmpresa.ToString()+" and d.IdOrdenPedido = "+IdOrdenPedido.ToString()+" and (d.opd_EstadoProceso NOT IN ('RA', 'RC', 'RGA', 'C')) ";

                    SqlCommand command = new SqlCommand(QueryConsulta, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new com_CotizacionPedidoDet_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            opd_IdOrdenPedido = Convert.ToDecimal(reader["IdOrdenPedido"]),
                            Secuencia = string.IsNullOrEmpty(reader["SecuenciaCot"].ToString()) ? 0 : Convert.ToInt32(reader["SecuenciaCot"]), 
                            opd_Secuencia = Convert.ToInt32(reader["Secuencia"]),
                            IdProducto = string.IsNullOrEmpty(reader["IdProducto"].ToString()) ? 0 : (decimal)reader["IdProducto"],
                            pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                            IdCotizacion = string.IsNullOrEmpty(reader["IdCotizacion"].ToString()) ? 0 : (decimal)reader["IdCotizacion"],
                            cd_Cantidad = Convert.ToDouble(reader["cd_cantidad"]),
                            cd_precioCompra = Convert.ToDouble(reader["cd_precioCompra"]),
                            cd_porc_des = Convert.ToDouble(reader["cd_porc_des"]),
                            cd_descuento = Convert.ToDouble(reader["cd_descuento"]),
                            cd_precioFinal = Convert.ToDouble(reader["cd_precioFinal"]),
                            cd_subtotal = Convert.ToDouble(reader["cd_subtotal"]),
                            IdCod_Impuesto = Convert.ToString(reader["IdCod_Impuesto"]),
                            Por_Iva = Convert.ToDouble(reader["Por_Iva"]),
                            cd_iva = Convert.ToDouble(reader["cd_iva"]),
                            cd_total = Convert.ToDouble(reader["cd_total"]),
                            IdUnidadMedida = Convert.ToString(reader["IdUnidadMedida"]),
                            IdPunto_cargo = string.IsNullOrEmpty(reader["IdPunto_cargo"].ToString()) ? null : (int?)reader["IdPunto_cargo"],
                            nom_punto_cargo = Convert.ToString(reader["nom_punto_cargo"]),
                            IdDepartamento = Convert.ToInt32(reader["IdDepartamento"]),
                            nom_solicitante = Convert.ToString(reader["nom_solicitante"]),
                            NomUnidadMedida = Convert.ToString(reader["nomUnidadMedida"]),
                            EstadoDetalle = Convert.ToString(reader["EstadoDetalle"]),
                            opd_EstadoProceso = Convert.ToString(reader["opd_EstadoProceso"]),
                            IdSucursalDestino = Convert.ToInt32(reader["IdSucursalDestino"]),
                            IdSucursalOrigen = Convert.ToInt32(reader["IdSucursalOrigen"]),
                            cd_DetallePorItem = Convert.ToString(reader["cd_DetallePorItem"]),
                            cp_Observacion = Convert.ToString(reader["cp_Observacion"]),
                            cp_ObservacionAdicional = Convert.ToString(reader["cp_ObservacionAdicional"]),
                            cp_Fecha = Convert.ToDateTime(reader["cp_Fecha"]),
                            Comprador = Convert.ToString(reader["Comprador"]),
                            opd_Detalle = Convert.ToString(reader["opd_Detalle"]),
                            A = true
                        });
                    }
                    reader.Close();
                }
                /*
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.vwcom_CotizacionPedidoDetAprobacion.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && q.IdUsuario == IdUsuario).Select(q => new com_CotizacionPedidoDet_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        opd_IdEmpresa = q.IdEmpresa,
                        opd_IdOrdenPedido = q.IdOrdenPedido,
                        opd_Secuencia = q.Secuencia,
                        IdUnidadMedida = q.IdUnidadMedida,
                        IdPunto_cargo = q.IdPunto_cargo,

                        IdSucursalOrigen = q.IdSucursalOrigen,
                        IdSucursalDestino = q.IdSucursalDestino,

                        cd_Cantidad = q.cd_cantidad,
                        IdCod_Impuesto = q.IdCod_Impuesto,
                        pr_descripcion = q.pr_descripcion,
                        IdProducto = q.IdProducto,
                        nom_solicitante = q.nom_solicitante,

                        IdDepartamento = q.IdDepartamento,
                        IdSolicitante = q.IdSolicitante,
                        EstadoDetalle = q.EstadoDetalle,

                        cd_precioCompra = q.cd_precioCompra ?? 0,
                        cd_descuento = q.cd_descuento ?? 0,
                        cd_porc_des = q.cd_porc_des ?? 0,
                        Por_Iva = q.Por_Iva ?? 0,
                        cd_iva = q.cd_iva ?? 0,
                        cd_subtotal = q.cd_subtotal ?? 0,
                        cd_total = q.cd_total ?? 0,
                        nom_punto_cargo = q.nom_punto_cargo,
                        NomUnidadMedida = q.nomUnidadMedida,

                        IdCotizacion = q.IdCotizacion ?? 0,
                        Secuencia = q.SecuenciaCot ?? 0,
                        cd_precioFinal = q.cd_precioFinal ?? 0,
                        opd_EstadoProceso = q.opd_EstadoProceso,
                        cd_DetallePorItem = q.cd_DetallePorItem,
                        A = true,
                        cp_ObservacionAdicional = q.cp_ObservacionAdicional,
                        opd_Detalle = q.opd_Detalle,
                        Comprador = q.Comprador,
                        cp_Fecha = q.cp_Fecha,
                        cp_Observacion = q.cp_Observacion,
                        
                    }).ToList();
                
                }*/
                Lista.ForEach(q => q.cp_Observacion = "Comprador: "+q.Comprador + " Fecha cotización: " + q.cp_Fecha.ToString("dd/MM/yyyy") + " Observación: " + q.cp_Observacion);
                /*
                in_Producto_data odata = new in_Producto_data();
                foreach (var item in Lista.Where(q => q.IdProducto != null).ToList())
                {
                    item.Stock = odata.GetStockProductoPorEmpresa(item.IdEmpresa, item.IdProducto ?? 0);
                }*/

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public com_CotizacionPedidoDet_Info GetInfoDetRegularizacion(int IdEmpresa, decimal IdOrdenPedidoReg, decimal SecuenciaReg)
        {
            try
            {
                com_CotizacionPedidoDet_Info info = new com_CotizacionPedidoDet_Info();
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "select TOP 1 A.IdEmpresa, A.IdOrdenPedido, A.Secuencia, b.cd_precioCompra, b.cd_porc_des, b.cd_descuento, b.cd_precioFinal, c.IdProveedor, b.IdCod_Impuesto "
                                +" from com_OrdenPedidoDet as a inner join"
                                +" com_CotizacionPedidoDet as b on a.IdEmpresa = b.opd_IdEmpresa and a.IdOrdenPedido = b.opd_IdOrdenPedido and a.Secuencia = b.opd_Secuencia inner join"
                                +" com_CotizacionPedido as c on b.IdEmpresa = c.IdEmpresa and b.IdCotizacion = c.IdCotizacion "
                                +" where a.IdEmpresa = "+IdEmpresa.ToString()+" and a.IdOrdenPedido = "+IdOrdenPedidoReg.ToString()+" and a.Secuencia = "+SecuenciaReg.ToString()+" and "
                                +" c.oc_IdOrdenCompra is not null and c.EstadoGA = 'A' AND C.EstadoJC = 'A'";
                    SqlCommand command = new SqlCommand(query,connection);
                    var ValidateValue = command.ExecuteScalar();
                    if (ValidateValue == null)
                        return null;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        info = new com_CotizacionPedidoDet_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            opd_IdOrdenPedido = Convert.ToDecimal(reader["IdOrdenPedido"]),
                            opd_Secuencia = Convert.ToInt32(reader["Secuencia"]),
                            cd_precioCompra = Convert.ToDouble(reader["cd_precioCompra"]),
                            cd_porc_des = Convert.ToDouble(reader["cd_porc_des"]),
                            cd_descuento = Convert.ToDouble(reader["cd_descuento"]),
                            cd_precioFinal = Convert.ToDouble(reader["cd_precioFinal"]),
                            IdProveedor = Convert.ToDecimal(reader["IdProveedor"]),
                            IdCod_Impuesto = Convert.ToString(reader["IdCod_Impuesto"])
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
    }
}
