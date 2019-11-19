--EXEC SPCOM_ComprasPorPuntoCargo 1,258
CREATE PROCEDURE SPCOM_ComprasPorPuntoCargo
(
@IdEmpresa int,
@IdPuntoCargo int
)
AS
SELECT com_ordencompra_local_det.IdEmpresa, com_ordencompra_local_det.IdSucursal, com_ordencompra_local_det.IdOrdenCompra, com_ordencompra_local_det.Secuencia, in_Producto.pr_descripcion, 
                  in_UnidadMedida.Descripcion AS NomUnidadMedida, cp_proveedor.pr_nombre, tb_persona.pe_nombreCompleto, RTRIM(tb_sucursal.codigo) + '-' + CAST(com_ordencompra_local_det.IdOrdenCompra AS varchar(20)) AS OC, 
                  ct_punto_cargo.nom_punto_cargo, com_ordencompra_local_det.IdPunto_cargo, com_ordencompra_local.oc_fecha, coti.IdOrdenPedido,com_ordencompra_local_det.do_cantidad, com_ordencompra_local_det.do_precioCompra,
				  com_ordencompra_local_det.do_porc_des, com_ordencompra_local_det.do_subtotal
FROM     cp_proveedor INNER JOIN
                  com_ordencompra_local_det INNER JOIN
                  in_Producto ON com_ordencompra_local_det.IdEmpresa = in_Producto.IdEmpresa AND com_ordencompra_local_det.IdProducto = in_Producto.IdProducto INNER JOIN
                  com_ordencompra_local ON com_ordencompra_local_det.IdEmpresa = com_ordencompra_local.IdEmpresa AND com_ordencompra_local_det.IdSucursal = com_ordencompra_local.IdSucursal AND 
                  com_ordencompra_local_det.IdOrdenCompra = com_ordencompra_local.IdOrdenCompra ON cp_proveedor.IdEmpresa = com_ordencompra_local.IdEmpresa AND 
                  cp_proveedor.IdProveedor = com_ordencompra_local.IdProveedor INNER JOIN
                  tb_persona ON cp_proveedor.IdPersona = tb_persona.IdPersona INNER JOIN
                  in_UnidadMedida ON com_ordencompra_local_det.IdUnidadMedida = in_UnidadMedida.IdUnidadMedida INNER JOIN
                  com_CotizacionPedido ON com_ordencompra_local.IdEmpresa = com_CotizacionPedido.IdEmpresa AND com_ordencompra_local.IdOrdenCompra = com_CotizacionPedido.oc_IdOrdenCompra LEFT OUTER JOIN
                  tb_sucursal ON com_ordencompra_local.IdEmpresa = tb_sucursal.IdEmpresa AND com_ordencompra_local.IdSucursal = tb_sucursal.IdSucursal INNER JOIN
                  ct_punto_cargo ON com_ordencompra_local_det.IdPunto_cargo = ct_punto_cargo.IdPunto_cargo AND com_ordencompra_local_det.IdEmpresa = ct_punto_cargo.IdEmpresa LEFT OUTER JOIN
                      (SELECT IdEmpresa, IdCotizacion, MAX(opd_IdOrdenPedido) AS IdOrdenPedido
                       FROM      com_CotizacionPedidoDet AS d
                       GROUP BY IdEmpresa, IdCotizacion) AS coti ON coti.IdEmpresa = com_CotizacionPedido.IdEmpresa AND coti.IdCotizacion = com_CotizacionPedido.IdCotizacion
				where com_ordencompra_local_det.IdEmpresa  =@IdEmpresa AND com_ordencompra_local_det.IdPunto_cargo = @IdPuntoCargo AND com_ordencompra_local.oc_Fecha >= dateadd(year,-1,cast(getdate() as date))