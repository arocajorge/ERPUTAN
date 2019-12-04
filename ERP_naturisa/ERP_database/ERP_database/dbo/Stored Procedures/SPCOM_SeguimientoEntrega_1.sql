--[dbo].[SPCOM_SeguimientoEntrega] 1,'ADMIN',0,0,0,0,'01/01/2019','12/01/2019',0
CREATE PROCEDURE [dbo].[SPCOM_SeguimientoEntrega]
(
@IdEmpresa int,
@IdUsuario varchar(50),
@IdSolicitante int,
@IdComprador int,
@IdProducto numeric,
@IdProveedor numeric,
@FechaIni date,
@FechaFin date,
@IdOrdenPedido decimal
)
AS

DELETE com_SPCOM_SeguimientoEntrega where IdUsuario = @IdUsuario

DECLARE 
@IdSolicitanteFin int = CASE WHEN @IdSolicitante = 0 then 99999999 else @IdSolicitante END,
@IdCompradorFin int = CASE WHEN @IdComprador = 0 then 99999999 else @IdComprador END,
@IdProductoFin numeric = CASE WHEN @IdProducto = 0 then 99999999 else @IdProducto END,
@IdProveedorFin numeric = CASE WHEN @IdProveedor = 0 then 99999999 else @IdProveedor END

IF(@IdOrdenPedido = 0)
BEGIN
	insert into com_SPCOM_SeguimientoEntrega (IdEmpresa,IdUsuario,IdOrdenPedido,Secuencia,IdProducto,pr_descripcion,EstadoSolpe,IdSucursalOrigen,CodigoSucOrigen,
	NombreSucursalOrigen,IdSucursalDestino,CodigoSucDestino,NombreSucursalDestino,EstadoDetalle,nom_solicitante,op_Fecha,opd_Cantidad,opd_CantidadApro,IdUsuarioCantidad,
	FechaCantidad,NombreUsuarioCantidad,NomUnidadMedida,op_Observacion,ObservacionGA,opd_Detalle,IdProveedor,pe_nombreCompleto,CantidadOC,FechaOC,FechaEntrega,NombreComprador,
	IB_UltIdNumMovi,IB_Cantidad,IB_Fecha,AlertaEntrega,CantidadPendiente,DiasPendiente)
	select B.IdEmpresa,@IdUsuario, B.IdOrdenPedido, B.Secuencia, B.IdProducto, B.pr_descripcion, C.Nombre AS EstadoSolpe, B.IdSucursalOrigen, D.codigo CodigoSucOrigen, 
	d.Su_Descripcion as NombreSucursalOrigen,B.IdSucursalDestino, E.codigo CodigoSucDestino, E.Su_Descripcion as NombreSucursalDestino,
	CASE WHEN B.opd_EstadoProceso = 'P' THEN 'PENDIENTE' 
		WHEN B.opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' 
		WHEN B.opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' 
		WHEN B.opd_EstadoProceso = 'AJC' THEN 'PRECIO APROBADO' 
		WHEN B.opd_EstadoProceso = 'C' THEN 'OC GENERADA' 
		WHEN B.opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' 
		WHEN B.opd_EstadoProceso = 'AC' THEN 'COTIZADO' 
		WHEN B.opd_EstadoProceso = 'RGA' THEN 'COTIZACION RECHAZADA'
		WHEN B.opd_EstadoProceso = 'I' THEN 'INGRESADO EN BODEGA' END AS EstadoDetalle,
		F.nom_solicitante, A.op_Fecha, B.opd_Cantidad, B.opd_CantidadApro, B.IdUsuarioCantidad, B.FechaCantidad, G.Nombre AS NombreUsuarioCantidad,
		ISNULL(K.Descripcion, H.Descripcion) AS NomUnidadMedida, a.op_Observacion, a.ObservacionGA, b.opd_Detalle, J.IdProveedor, M.pe_nombreCompleto,
		N.do_Cantidad AS CantidadOC, l.oc_fecha FechaOC, l.oc_fechaVencimiento  as FechaEntrega, O.Descripcion NombreComprador,
		NULL IB_UltIdNumMovi,0 IB_Cantidad, NULL IB_Fecha, NULL AlertaEntrega, n.do_Cantidad CantidadPendiente,0 DiasPendiente
	from com_OrdenPedido as A INNER JOIN 
	com_OrdenPedidoDet AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdOrdenPedido = B.IdOrdenPedido INNER JOIN
	dbo.com_catalogo  C ON A.IdCatalogoEstado = C.IdCatalogocompra LEFT JOIN
	tb_sucursal AS D ON B.IdEmpresa = D.IdEmpresa AND B.IdSucursalOrigen = D.IdSucursal LEFT JOIN
	tb_sucursal AS E ON B.IdEmpresa = E.IdEmpresa AND B.IdSucursalDestino = E.IdSucursal INNER JOIN 
	com_solicitante AS F ON A.IdEmpresa = F.IdEmpresa AND A.IdSolicitante = F.IdSolicitante LEFT JOIN
	seg_usuario AS G ON B.IdUsuarioCantidad = G.IdUsuario LEFT JOIN
	in_UnidadMedida AS H ON B.IdUnidadMedida = H.IdUnidadMedida LEFT JOIN
	com_CotizacionPedidoDet as I on B.IdEmpresa = I.opd_IdEmpresa AND B.IdOrdenPedido = I.opd_IdOrdenPedido AND B.Secuencia = I.opd_Secuencia LEFT JOIN
	com_CotizacionPedido AS J ON J.IdEmpresa = I.IdEmpresa AND J.IdCotizacion = I.IdCotizacion LEFT JOIN
	in_UnidadMedida AS K ON I.IdUnidadMedida = K.IdUnidadMedida LEFT JOIN
	com_ordencompra_local AS L ON J.IdEmpresa = L.IdEmpresa AND J.IdSucursal = L.IdSucursal AND J.oc_IdOrdenCompra = L.IdOrdenCompra LEFT JOIN
	cp_proveedor AS P ON P.IdEmpresa = J.IdEmpresa AND P.IdProveedor = J.IdProveedor LEFT JOIN
	tb_persona AS M ON P.IdPersona = M.IdPersona LEFT JOIN
	com_ordencompra_local_det AS N ON L.IdEmpresa = N.IdEmpresa AND L.IdSucursal = N.IdSucursal AND L.IdOrdenCompra = N.IdOrdenCompra AND I.Secuencia = N.Secuencia LEFT JOIN
	com_comprador AS O ON L.IdEmpresa = O.IdEmpresa AND L.IdComprador = O.IdComprador
	WHERE A.IdEmpresa = @IdEmpresa AND A.op_Fecha between @FechaIni and @FechaFin 
	AND A.IdSolicitante BETWEEN @IdSolicitante AND @IdSolicitanteFin
	AND CASE WHEN @IdProveedor = 0 THEN @IdProveedor ELSE J.IdProveedor END BETWEEN @IdProveedor AND @IdProveedor
	AND CASE WHEN @IdComprador = 0 THEN @IdComprador ELSE J.IdComprador END BETWEEN @IdComprador AND @IdCompradorFin
	AND ISNULL(J.EstadoJC,'P') IN ('A','P') AND case when ISNULL(j.EstadoJC,'P') = 'A' THEN I.EstadoJC WHEN ISNULL(J.EstadoJC,'P') = 'P' THEN 1 END = 1 
END
ELSE
BEGIN
	insert into com_SPCOM_SeguimientoEntrega (IdEmpresa,IdUsuario,IdOrdenPedido,Secuencia,IdProducto,pr_descripcion,EstadoSolpe,IdSucursalOrigen,CodigoSucOrigen,
	NombreSucursalOrigen,IdSucursalDestino,CodigoSucDestino,NombreSucursalDestino,EstadoDetalle,nom_solicitante,op_Fecha,opd_Cantidad,opd_CantidadApro,IdUsuarioCantidad,
	FechaCantidad,NombreUsuarioCantidad,NomUnidadMedida,op_Observacion,ObservacionGA,opd_Detalle,IdProveedor,pe_nombreCompleto,CantidadOC,FechaOC,FechaEntrega,NombreComprador,
	IB_UltIdNumMovi,IB_Cantidad,IB_Fecha,AlertaEntrega,CantidadPendiente,DiasPendiente)
	select B.IdEmpresa,@IdUsuario, B.IdOrdenPedido, B.Secuencia, B.IdProducto, B.pr_descripcion, C.Nombre AS EstadoSolpe, B.IdSucursalOrigen, D.codigo CodigoSucOrigen, 
	d.Su_Descripcion as NombreSucursalOrigen,B.IdSucursalDestino, E.codigo CodigoSucDestino, E.Su_Descripcion as NombreSucursalDestino,
	CASE WHEN B.opd_EstadoProceso = 'P' THEN 'PENDIENTE' 
		WHEN B.opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' 
		WHEN B.opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' 
		WHEN B.opd_EstadoProceso = 'AJC' THEN 'PRECIO APROBADO' 
		WHEN B.opd_EstadoProceso = 'C' THEN 'OC GENERADA' 
		WHEN B.opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' 
		WHEN B.opd_EstadoProceso = 'AC' THEN 'COTIZADO' 
		WHEN B.opd_EstadoProceso = 'RGA' THEN 'COTIZACION RECHAZADA' END AS EstadoDetalle,
		F.nom_solicitante, A.op_Fecha, B.opd_Cantidad, B.opd_CantidadApro, B.IdUsuarioCantidad, B.FechaCantidad, G.Nombre AS NombreUsuarioCantidad,
		ISNULL(K.Descripcion, H.Descripcion) AS NomUnidadMedida, a.op_Observacion, a.ObservacionGA, b.opd_Detalle, J.IdProveedor, M.pe_nombreCompleto,
		N.do_Cantidad AS CantidadOC, l.oc_fecha FechaOC, l.oc_fechaVencimiento  as FechaEntrega, O.Descripcion NombreComprador,
		NULL IB_UltIdNumMovi,0 IB_Cantidad, NULL IB_Fecha, NULL AlertaEntrega, n.do_Cantidad CantidadPendiente,0 DiasPendiente
	from com_OrdenPedido as A INNER JOIN 
	com_OrdenPedidoDet AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdOrdenPedido = B.IdOrdenPedido INNER JOIN
	dbo.com_catalogo  C ON A.IdCatalogoEstado = C.IdCatalogocompra LEFT JOIN
	tb_sucursal AS D ON B.IdEmpresa = D.IdEmpresa AND B.IdSucursalOrigen = D.IdSucursal LEFT JOIN
	tb_sucursal AS E ON B.IdEmpresa = E.IdEmpresa AND B.IdSucursalDestino = E.IdSucursal INNER JOIN 
	com_solicitante AS F ON A.IdEmpresa = F.IdEmpresa AND A.IdSolicitante = F.IdSolicitante LEFT JOIN
	seg_usuario AS G ON B.IdUsuarioCantidad = G.IdUsuario LEFT JOIN
	in_UnidadMedida AS H ON B.IdUnidadMedida = H.IdUnidadMedida LEFT JOIN
	com_CotizacionPedidoDet as I on B.IdEmpresa = I.opd_IdEmpresa AND B.IdOrdenPedido = I.opd_IdOrdenPedido AND B.Secuencia = I.opd_Secuencia LEFT JOIN
	com_CotizacionPedido AS J ON J.IdEmpresa = I.IdEmpresa AND J.IdCotizacion = I.IdCotizacion LEFT JOIN
	in_UnidadMedida AS K ON I.IdUnidadMedida = K.IdUnidadMedida LEFT JOIN
	com_ordencompra_local AS L ON J.IdEmpresa = L.IdEmpresa AND J.IdSucursal = L.IdSucursal AND J.oc_IdOrdenCompra = L.IdOrdenCompra LEFT JOIN
	cp_proveedor AS P ON P.IdEmpresa = J.IdEmpresa AND P.IdProveedor = J.IdProveedor LEFT JOIN
	tb_persona AS M ON P.IdPersona = M.IdPersona LEFT JOIN
	com_ordencompra_local_det AS N ON L.IdEmpresa = N.IdEmpresa AND L.IdSucursal = N.IdSucursal AND L.IdOrdenCompra = N.IdOrdenCompra AND I.Secuencia = N.Secuencia LEFT JOIN
	com_comprador AS O ON L.IdEmpresa = O.IdEmpresa AND L.IdComprador = O.IdComprador
	WHERE A.IdEmpresa = @IdEmpresa AND A.IdOrdenPedido = @IdOrdenPedido
	AND ISNULL(J.EstadoJC,'P') IN ('A','P') AND case when ISNULL(j.EstadoJC,'P') = 'A' THEN I.EstadoJC WHEN ISNULL(J.EstadoJC,'P') = 'P' THEN 1 END = 1 
END


update com_SPCOM_SeguimientoEntrega set IB_Cantidad = A.TotalIngresado
from(
SELECT a.IdEmpresa, a.IdOrdenPedido, a.Secuencia, SUM(f.dm_cantidad_sinConversion) AS TotalIngresado
FROM     com_ordencompra_local_det AS e INNER JOIN
                  com_ordencompra_local AS d ON e.IdEmpresa = d.IdEmpresa AND e.IdSucursal = d.IdSucursal AND e.IdOrdenCompra = d.IdOrdenCompra INNER JOIN
                  in_Ing_Egr_Inven_det AS f ON e.IdEmpresa = f.IdEmpresa_oc AND e.IdSucursal = f.IdSucursal_oc AND e.IdOrdenCompra = f.IdOrdenCompra AND e.Secuencia = f.Secuencia_oc INNER JOIN
                  com_OrdenPedidoDet AS a INNER JOIN
                  com_CotizacionPedidoDet AS b ON a.IdEmpresa = b.opd_IdEmpresa AND a.IdOrdenPedido = b.opd_IdOrdenPedido AND a.Secuencia = b.opd_Secuencia INNER JOIN
                  com_CotizacionPedido AS c ON b.IdEmpresa = c.IdEmpresa AND b.IdCotizacion = c.IdCotizacion ON d.IdEmpresa = c.IdEmpresa AND d.IdSucursal = c.IdSucursal AND d.IdOrdenCompra = c.oc_IdOrdenCompra AND 
                  e.Secuencia = b.Secuencia
GROUP BY a.IdEmpresa, a.IdOrdenPedido, a.Secuencia
)A WHERE 
com_SPCOM_SeguimientoEntrega.IdEmpresa = A.IdEmpresa
AND com_SPCOM_SeguimientoEntrega.IdOrdenPedido = A.IdOrdenPedido
AND com_SPCOM_SeguimientoEntrega.Secuencia = A.Secuencia
AND com_SPCOM_SeguimientoEntrega.IdUsuario = @IdUsuario
AND com_SPCOM_SeguimientoEntrega.IdEmpresa = @IdEmpresa

update com_SPCOM_SeguimientoEntrega set IB_Fecha = A.cm_fecha, IB_UltIdNumMovi = a.IdNumMovi
from(
Select * from (
SELECT ROW_NUMBER() OVER(PARTITION BY a.IdEmpresa, a.IdOrdenPedido, a.Secuencia ORDER BY in_Ing_Egr_Inven.cm_fecha DESC)IdRow, a.IdEmpresa, a.IdOrdenPedido, a.Secuencia, in_Ing_Egr_Inven.IdNumMovi, in_Ing_Egr_Inven.cm_fecha
FROM     com_ordencompra_local_det AS e INNER JOIN
                  com_ordencompra_local AS d ON e.IdEmpresa = d.IdEmpresa AND e.IdSucursal = d.IdSucursal AND e.IdOrdenCompra = d.IdOrdenCompra INNER JOIN
                  in_Ing_Egr_Inven_det AS f ON e.IdEmpresa = f.IdEmpresa_oc AND e.IdSucursal = f.IdSucursal_oc AND e.IdOrdenCompra = f.IdOrdenCompra AND e.Secuencia = f.Secuencia_oc INNER JOIN
                  com_OrdenPedidoDet AS a INNER JOIN
                  com_CotizacionPedidoDet AS b ON a.IdEmpresa = b.opd_IdEmpresa AND a.IdOrdenPedido = b.opd_IdOrdenPedido AND a.Secuencia = b.opd_Secuencia INNER JOIN
                  com_CotizacionPedido AS c ON b.IdEmpresa = c.IdEmpresa AND b.IdCotizacion = c.IdCotizacion ON d.IdEmpresa = c.IdEmpresa AND d.IdSucursal = c.IdSucursal AND d.IdOrdenCompra = c.oc_IdOrdenCompra AND 
                  e.Secuencia = b.Secuencia INNER JOIN
                  in_Ing_Egr_Inven ON f.IdEmpresa = in_Ing_Egr_Inven.IdEmpresa AND f.IdSucursal = in_Ing_Egr_Inven.IdSucursal AND f.IdMovi_inven_tipo = in_Ing_Egr_Inven.IdMovi_inven_tipo AND f.IdNumMovi = in_Ing_Egr_Inven.IdNumMovi
where a.IdEmpresa = @IdEmpresa
) B where b.IdRow= 1
)A WHERE 
com_SPCOM_SeguimientoEntrega.IdEmpresa = A.IdEmpresa
AND com_SPCOM_SeguimientoEntrega.IdOrdenPedido = A.IdOrdenPedido
AND com_SPCOM_SeguimientoEntrega.Secuencia = A.Secuencia
AND com_SPCOM_SeguimientoEntrega.IdUsuario = @IdUsuario
AND com_SPCOM_SeguimientoEntrega.IdEmpresa = @IdEmpresa

update com_SPCOM_SeguimientoEntrega set CantidadPendiente = ROUND(CantidadOC - IB_Cantidad,2), DiasPendiente = 
case when ROUND(CantidadOC - IB_Cantidad,2) > 0 then DATEDIFF(DAY,cast(getdate() as date),FechaEntrega) 
when ROUND(CantidadOC - IB_Cantidad,2)= 0 then DATEDIFF(DAY,IB_Fecha,FechaEntrega) end
WHERE com_SPCOM_SeguimientoEntrega.IdUsuario = @IdUsuario
AND com_SPCOM_SeguimientoEntrega.IdEmpresa = @IdEmpresa

select * from com_SPCOM_SeguimientoEntrega where IdEmpresa = @IdEmpresa AND IdUsuario = @IdUsuario