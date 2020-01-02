--EXEC [dbo].[SPCOM_SeguimientoEntrega] 1,'ADMIN',0,0,0,0,'12/01/2019','12/30/2019',0
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
DECLARE @t1 DATETIME = getdate();
DECLARE @t2 DATETIME;

SET @t2=getdate()
print DATEDIFF(millisecond,@t1,@t2);
PRINT 'DELETE INICIAL'
DELETE com_SPCOM_SeguimientoEntrega where IdUsuario = @IdUsuario
SET @t2=getdate()
print DATEDIFF(second,@t1,@t2);

DECLARE 
@IdSolicitanteFin int = CASE WHEN @IdSolicitante = 0 then 99999999 else @IdSolicitante END,
@IdProductoFin numeric = CASE WHEN @IdProducto = 0 then 99999999 else @IdProducto END





PRINT 'INSERT INICIAL'
IF(@IdOrdenPedido = 0)
BEGIN
	INSERT INTO [dbo].[com_SPCOM_SeguimientoEntrega]
			   ([IdEmpresa]           ,[IdUsuario]           ,[IdOrdenPedido]           ,[Secuencia]           ,[IdProducto]           ,[pr_descripcion]           ,[EstadoSolpe]
			   ,[IdSucursalOrigen]           ,[CodigoSucOrigen]           ,[NombreSucursalOrigen]           ,[IdSucursalDestino]           ,[CodigoSucDestino]           ,[NombreSucursalDestino]
			   ,[EstadoDetalle]           ,[nom_solicitante]           ,[op_Fecha]           ,[opd_Cantidad]           ,[opd_CantidadApro]           ,[IdUsuarioCantidad]           ,[FechaCantidad]
			   ,[NombreUsuarioCantidad]           ,[NomUnidadMedida]           ,[op_Observacion]           ,[ObservacionGA]           ,[opd_Detalle]	,[IB_Cantidad]	,[IB_Fecha])

	select a.IdEmpresa, @IdUsuario, a.IdOrdenPedido, a.Secuencia, a.IdProducto, a.pr_descripcion, c.Nombre, a.IdSucursalOrigen, d.codigo, d.Su_Descripcion, a.IdSucursalDestino, e.codigo, e.Su_Descripcion,
	CASE WHEN a.opd_EstadoProceso = 'P' THEN 'PENDIENTE' WHEN a.opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' WHEN a.opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' WHEN a.opd_EstadoProceso =
							  'AJC' THEN 'PRECIO APROBADO' WHEN a.opd_EstadoProceso = 'C' THEN 'OC GENERADA' WHEN a.opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' WHEN a.opd_EstadoProceso = 'AC' THEN 'COTIZADO' WHEN
							  a.opd_EstadoProceso = 'RGA' THEN 'COTIZACION RECHAZADA' WHEN a.opd_EstadoProceso = 'I' THEN 'INGRESADO EN BODEGA' 
							  WHEN a.opd_EstadoProceso = 'T' THEN 'TRANSFERIDO' WHEN a.opd_EstadoProceso = 'R' THEN 'RECIBIDO POR SOLICITANTE'
							  END AS EstadoDetalle, f.nom_solicitante, b.op_Fecha, a.opd_Cantidad, a.opd_CantidadApro,
							  a.IdUsuarioCantidad, a.FechaCantidad, a.IdUsuarioCantidad, g.Descripcion, b.op_Observacion, b.ObservacionGA, a.opd_Detalle, 0 ,cast(getdate() as date)
	from com_OrdenPedidoDet as a inner join
	com_OrdenPedido as b on a.IdEmpresa = b.IdEmpresa and a.IdOrdenPedido = b.IdOrdenPedido inner join
	com_catalogo as c on b.IdCatalogoEstado = c.IdCatalogocompra left join 
	tb_sucursal as d on d.IdEmpresa = a.IdEmpresa and d.IdSucursal = a.IdSucursalOrigen left join 
	tb_sucursal as e on e.IdEmpresa = a.IdEmpresa and e.IdSucursal = a.IdSucursalDestino left join
	com_solicitante as f on f.IdEmpresa = b.IdEmpresa and f.IdSolicitante = b.IdSolicitante left join
	in_UnidadMedida as g on g.IdUnidadMedida = a.IdUnidadMedida
	where a.IdEmpresa = @IdEmpresa and b.IdSolicitante between @IdSolicitante and @IdSolicitanteFin
	and isnull(a.IdProducto,0) between @IdProducto and @IdProductoFin
	and b.op_Fecha between @FechaIni and @FechaFin
END
ELSE
BEGIN
	INSERT INTO [dbo].[com_SPCOM_SeguimientoEntrega]
			   ([IdEmpresa]           ,[IdUsuario]           ,[IdOrdenPedido]           ,[Secuencia]           ,[IdProducto]           ,[pr_descripcion]           ,[EstadoSolpe]
			   ,[IdSucursalOrigen]           ,[CodigoSucOrigen]           ,[NombreSucursalOrigen]           ,[IdSucursalDestino]           ,[CodigoSucDestino]           ,[NombreSucursalDestino]
			   ,[EstadoDetalle]           ,[nom_solicitante]           ,[op_Fecha]           ,[opd_Cantidad]           ,[opd_CantidadApro]           ,[IdUsuarioCantidad]           ,[FechaCantidad]
			   ,[NombreUsuarioCantidad]           ,[NomUnidadMedida]           ,[op_Observacion]           ,[ObservacionGA]           ,[opd_Detalle],[IB_Cantidad]	,[IB_Fecha])

	select a.IdEmpresa, @IdUsuario, a.IdOrdenPedido, a.Secuencia, a.IdProducto, a.pr_descripcion, c.Nombre, a.IdSucursalOrigen, d.codigo, d.Su_Descripcion, a.IdSucursalDestino, e.codigo, e.Su_Descripcion,
	CASE WHEN a.opd_EstadoProceso = 'P' THEN 'PENDIENTE' WHEN a.opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' WHEN a.opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' WHEN a.opd_EstadoProceso =
							  'AJC' THEN 'PRECIO APROBADO' WHEN a.opd_EstadoProceso = 'C' THEN 'OC GENERADA' WHEN a.opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' WHEN a.opd_EstadoProceso = 'AC' THEN 'COTIZADO' WHEN
							  a.opd_EstadoProceso = 'RGA' THEN 'COTIZACION RECHAZADA' WHEN a.opd_EstadoProceso = 'I' THEN 'INGRESADO EN BODEGA' 
							  WHEN a.opd_EstadoProceso = 'T' THEN 'TRANSFERIDO' WHEN a.opd_EstadoProceso = 'R' THEN 'RECIBIDO POR SOLICITANTE'
							  END AS EstadoDetalle, f.nom_solicitante, b.op_Fecha, a.opd_Cantidad, a.opd_CantidadApro,
							  a.IdUsuarioCantidad, a.FechaCantidad, a.IdUsuarioCantidad, g.Descripcion, b.op_Observacion, b.ObservacionGA, a.opd_Detalle, 0, cast(getdate() as date)
	from com_OrdenPedidoDet as a inner join
	com_OrdenPedido as b on a.IdEmpresa = b.IdEmpresa and a.IdOrdenPedido = b.IdOrdenPedido inner join
	com_catalogo as c on b.IdCatalogoEstado = c.IdCatalogocompra left join 
	tb_sucursal as d on d.IdEmpresa = a.IdEmpresa and d.IdSucursal = a.IdSucursalOrigen left join 
	tb_sucursal as e on e.IdEmpresa = a.IdEmpresa and e.IdSucursal = a.IdSucursalDestino left join
	com_solicitante as f on f.IdEmpresa = b.IdEmpresa and f.IdSolicitante = b.IdSolicitante left join
	in_UnidadMedida as g on g.IdUnidadMedida = a.IdUnidadMedida
	where a.IdEmpresa = @IdEmpresa and B.IdOrdenPedido = @IdOrdenPedido
END

SET @t2=getdate()
print DATEDIFF(second,@t1,@t2);

PRINT 'ACTUALIZO CAMPOS DE OC'
BEGIN -- ACTUALIZO CAMPOS DE OC
UPDATE com_SPCOM_SeguimientoEntrega SET IdProveedor = A.IdProveedor, pe_nombreCompleto = A.pe_nombreCompleto, CodigoOC = A.Codigo, CantidadOC = a.do_Cantidad, FechaOC = a.oc_fecha, FechaEntrega = a.oc_fechaVencimiento, NombreComprador = a.NomComprador, IdComprador = a.IdComprador,
IdSucursalOC = a.IdSucursal, IdOrdenCompra = a.IdOrdenCompra, SecuenciaOC = a.SecuenciaOC
FROM(
	SELECT A.IdEmpresa, A.IdOrdenPedido, A.Secuencia, D.IdSucursal, D.IdOrdenCompra, e.Secuencia SecuenciaOC, D.IdProveedor, P.pe_nombreCompleto, S.codigo+'-'+CASt(D.IdOrdenCompra AS VARCHAR) Codigo,e.do_Cantidad, d.oc_fecha, d.oc_fechaVencimiento, f.Descripcion NomComprador, D.IdComprador
	FROM com_SPCOM_SeguimientoEntrega AS A INNER JOIN
	com_CotizacionPedidoDet AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdOrdenPedido = B.opd_IdOrdenPedido AND A.Secuencia = B.opd_Secuencia INNER JOIN
	com_CotizacionPedido AS C ON C.IdEmpresa = B.IdEmpresa AND C.IdCotizacion = B.IdCotizacion INNER JOIN
	com_ordencompra_local AS D ON C.IdEmpresa = D.IdEmpresa AND C.oc_IdOrdenCompra = D.IdOrdenCompra AND C.IdSucursal = D.IdSucursal INNER JOIN
	com_ordencompra_local_det AS E ON C.IdEmpresa = E.IdEmpresa AND C.IdSucursal = E.IdSucursal AND C.oc_IdOrdenCompra = E.IdOrdenCompra AND B.Secuencia = E.Secuencia INNER JOIN
	tb_sucursal AS S ON S.IdEmpresa = E.IdEmpresa AND S.IdSucursal = E.IdSucursal INNER JOIN
	cp_proveedor AS PRO ON PRO.IdEmpresa = D.IdEmpresa AND PRO.IdProveedor = D.IdProveedor INNER JOIN
	tb_persona AS P ON P.IdPersona = PRO.IdPersona inner join 
	com_comprador as f on d.IdEmpresa = f.IdEmpresa and d.IdComprador = f.IdComprador
	WHERE A.IdEmpresa = @IdEmpresa AND A.IdUsuario = @IdUsuario
) A
WHERE com_SPCOM_SeguimientoEntrega.IdEmpresa = A.IdEmpresa
AND com_SPCOM_SeguimientoEntrega.IdOrdenPedido = A.IdOrdenPedido
AND com_SPCOM_SeguimientoEntrega.Secuencia = A.Secuencia
AND com_SPCOM_SeguimientoEntrega.IdUsuario = @IdUsuario
END

SET @t2=getdate()
print DATEDIFF(second,@t1,@t2);

PRINT 'ELIMINO PROVEEDORES'
IF(@IdProveedor != 0)
BEGIN
	DELETE com_SPCOM_SeguimientoEntrega 
	WHERE IdEmpresa = @IdEmpresa AND isnull(IdProveedor,0) != @IdProveedor and IdUsuario = @IdUsuario
END
SET @t2=getdate()
print DATEDIFF(second,@t1,@t2);

PRINT 'ELIMINO COMPRADORES'
IF(@IdComprador != 0)
BEGIN
	DELETE com_SPCOM_SeguimientoEntrega 
	WHERE IdEmpresa = @IdEmpresa AND isnull(IdComprador,0) != @IdComprador and IdUsuario = @IdUsuario
END
SET @t2=getdate()
print DATEDIFF(second,@t1,@t2);

PRINT 'ACTUALIZO CANTIDAD INGRESADA'
BEGIN --ACTUALIZO CANTIDAD INGRESADA
	update com_SPCOM_SeguimientoEntrega set IB_Cantidad = A.TotalIngresado
	from(
	SELECT x.IdEmpresa, x.IdOrdenPedido, x.Secuencia, SUM(f.dm_cantidad_sinConversion) AS TotalIngresado
	FROM     com_ordencompra_local_det AS e INNER JOIN
					  com_ordencompra_local AS d ON e.IdEmpresa = d.IdEmpresa AND e.IdSucursal = d.IdSucursal AND e.IdOrdenCompra = d.IdOrdenCompra INNER JOIN
					  in_Ing_Egr_Inven_det AS f ON e.IdEmpresa = f.IdEmpresa_oc AND e.IdSucursal = f.IdSucursal_oc AND e.IdOrdenCompra = f.IdOrdenCompra AND e.Secuencia = f.Secuencia_oc INNER JOIN
					com_SPCOM_SeguimientoEntrega AS X ON e.IdEmpresa = x.IdEmpresa and e.IdSucursal = x.IdSucursalOC and e.IdOrdenCompra = x.IdOrdenCompra and e.Secuencia = x.SecuenciaOC
				where x.IdEmpresa = @IdEmpresa and x.IdUsuario = @IdUsuario
	GROUP BY x.IdEmpresa, x.IdOrdenPedido, x.Secuencia
	)A WHERE 
	com_SPCOM_SeguimientoEntrega.IdEmpresa = A.IdEmpresa
	AND com_SPCOM_SeguimientoEntrega.IdOrdenPedido = A.IdOrdenPedido
	AND com_SPCOM_SeguimientoEntrega.Secuencia = A.Secuencia
	AND com_SPCOM_SeguimientoEntrega.IdUsuario = @IdUsuario
	AND com_SPCOM_SeguimientoEntrega.IdEmpresa = @IdEmpresa
END

SET @t2=getdate()
print DATEDIFF(second,@t1,@t2);

PRINT 'ACTUALIZO ULT INGRESO'
BEGIN --ACTUALIZO ULT ING
	update com_SPCOM_SeguimientoEntrega set IB_Fecha = A.cm_fecha, IB_UltIdNumMovi = a.IdNumMovi
	from(
	Select * from (
	SELECT ROW_NUMBER() OVER(PARTITION BY x.IdEmpresa, x.IdOrdenPedido, x.Secuencia ORDER BY in_Ing_Egr_Inven.cm_fecha DESC)IdRow, x.IdEmpresa, x.IdOrdenPedido, x.Secuencia, in_Ing_Egr_Inven.IdNumMovi, in_Ing_Egr_Inven.cm_fecha
	FROM     com_ordencompra_local_det AS e INNER JOIN
					com_ordencompra_local AS d ON e.IdEmpresa = d.IdEmpresa AND e.IdSucursal = d.IdSucursal AND e.IdOrdenCompra = d.IdOrdenCompra INNER JOIN
					in_Ing_Egr_Inven_det AS f ON e.IdEmpresa = f.IdEmpresa_oc AND e.IdSucursal = f.IdSucursal_oc AND e.IdOrdenCompra = f.IdOrdenCompra AND e.Secuencia = f.Secuencia_oc INNER JOIN
					in_Ing_Egr_Inven ON f.IdEmpresa = in_Ing_Egr_Inven.IdEmpresa AND f.IdSucursal = in_Ing_Egr_Inven.IdSucursal AND f.IdMovi_inven_tipo = in_Ing_Egr_Inven.IdMovi_inven_tipo AND f.IdNumMovi = in_Ing_Egr_Inven.IdNumMovi 
					INNER JOIN com_SPCOM_SeguimientoEntrega AS X ON e.IdEmpresa = x.IdEmpresa and e.IdSucursal = x.IdSucursalOC and e.IdOrdenCompra = x.IdOrdenCompra and e.Secuencia = x.SecuenciaOC
	where x.IdEmpresa = @IdEmpresa and x.IdUsuario = @IdUsuario
	) B where b.IdRow= 1
	)A WHERE 
	com_SPCOM_SeguimientoEntrega.IdEmpresa = A.IdEmpresa
	AND com_SPCOM_SeguimientoEntrega.IdOrdenPedido = A.IdOrdenPedido
	AND com_SPCOM_SeguimientoEntrega.Secuencia = A.Secuencia
	AND com_SPCOM_SeguimientoEntrega.IdUsuario = @IdUsuario
	AND com_SPCOM_SeguimientoEntrega.IdEmpresa = @IdEmpresa
END

SET @t2=getdate()
print DATEDIFF(second,@t1,@t2);

PRINT 'ACTUALIZO ANALISIS DE DATOS'
BEGIN --ACTUALIZO ANALISIS DE DIAS
	update com_SPCOM_SeguimientoEntrega set CantidadPendiente = ROUND(CantidadOC - IB_Cantidad,2), DiasPendiente = 
	case when ROUND(CantidadOC - IB_Cantidad,2) > 0 then DATEDIFF(DAY,cast(getdate() as date),FechaEntrega) 
	when ROUND(CantidadOC - IB_Cantidad,2)= 0 then DATEDIFF(DAY,IB_Fecha,FechaEntrega) end
	WHERE com_SPCOM_SeguimientoEntrega.IdUsuario = @IdUsuario
	AND com_SPCOM_SeguimientoEntrega.IdEmpresa = @IdEmpresa

	update com_SPCOM_SeguimientoEntrega set AlertaEntrega = case when DiasPendiente is null then 1/*White*/ when DiasPendiente > 1 then /*'Green'*/2 when DiasPendiente between 0 and 1 then /*'Yellow'*/3 when DiasPendiente < 0 then /*'Red'*/ 4 end
	WHERE com_SPCOM_SeguimientoEntrega.IdUsuario = @IdUsuario
	AND com_SPCOM_SeguimientoEntrega.IdEmpresa = @IdEmpresa
END

SET @t2=getdate()
print DATEDIFF(second,@t1,@t2);
BEGIN --ACTUALIZO DATOS DE TRANSFERENCIA
	update com_SPCOM_SeguimientoEntrega set NombreSucursalTransferencia = A.Su_Descripcion, NombreBodegaTransferencia = a.bo_Descripcion, FechaTransferencia = a.tr_fecha, FechaRecepcionTransferencia = a.cm_fecha
	FROM(
		SELECT a.IdEmpresa, a.IdOrdenPedido, a.Secuencia, f.Su_Descripcion, e.bo_Descripcion, c.tr_fecha, d.cm_fecha
		FROM com_SPCOM_SeguimientoEntrega AS A INNER JOIN
		in_transferencia_det AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdSucursalOC = B.IdSucursal_oc AND A.IdOrdenCompra = B.IdOrdenCompra and A.SecuenciaOC = b.Secuencia_oc inner join
		in_transferencia as c on b.IdEmpresa = c.IdEmpresa and b.IdSucursalOrigen = c.IdSucursalOrigen and b.IdBodegaOrigen = c.IdBodegaOrigen and b.IdTransferencia = c.IdTransferencia left join
		in_Ing_Egr_Inven as d on c.IdEmpresa_Ing_Egr_Inven_Destino = d.IdEmpresa and c.IdSucursal_Ing_Egr_Inven_Destino = d.IdSucursal and d.IdMovi_inven_tipo = c.IdMovi_inven_tipo_SucuDest and d.IdNumMovi = c.IdNumMovi_Ing_Egr_Inven_Destino left join
		tb_bodega as e on c.IdEmpresa = e.IdEmpresa and c.IdSucursal_Ing_Egr_Inven_Destino = e.IdSucursal and c.IdBodegaDest = e.IdBodega left join
		tb_sucursal as f on e.IdEmpresa = f.IdEmpresa and e.IdSucursal = e.IdSucursal
		where a.IdEmpresa = @IdEmpresa
		and a.IdUsuario = @IdUsuario
		group by a.IdEmpresa, a.IdOrdenPedido, a.Secuencia, f.Su_Descripcion, e.bo_Descripcion, c.tr_fecha, d.cm_fecha
	)a
	where com_SPCOM_SeguimientoEntrega.IdEmpresa = a.IdEmpresa
	and com_SPCOM_SeguimientoEntrega.IdOrdenPedido = a.IdOrdenPedido
	and com_SPCOM_SeguimientoEntrega.Secuencia = a.Secuencia
	AND com_SPCOM_SeguimientoEntrega.IdUsuario = @IdUsuario
	AND com_SPCOM_SeguimientoEntrega.IdEmpresa = @IdEmpresa
END

SET @t2=getdate()
print DATEDIFF(second,@t1,@t2);

select * from com_SPCOM_SeguimientoEntrega where IdEmpresa = @IdEmpresa AND IdUsuario = @IdUsuario