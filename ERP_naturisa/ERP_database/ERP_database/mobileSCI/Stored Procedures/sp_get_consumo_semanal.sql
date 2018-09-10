--[mobileSCI].[sp_get_consumo_semanal] 'josefinapp'
CREATE procedure [mobileSCI].[sp_get_consumo_semanal]
(
 @IdUsuario varchar(50)
 )
 AS
DELETE [mobileSCI].[tbl_consumo_semanal]

INSERT INTO [mobileSCI].[tbl_consumo_semanal]
           ([IdEmpresa]
           ,[IdSucursal]
           ,[IdBodega]
           ,[IdProducto]
           ,[IdCentroCosto]
           ,[IdCentroCosto_sub_centro_costo]
           ,[NomProducto]
           ,[NomSubCentro]
           ,[LUNES]
           ,[MARTES]
           ,[MIERCOLES]
           ,[JUEVES]
           ,[VIERNES]
           ,[SABADO]
           ,[DOMINGO]
		   ,[TOTAL])

SELECT        mobileSCI.tbl_usuario_x_bodega.IdEmpresa, mobileSCI.tbl_usuario_x_bodega.IdSucursal, mobileSCI.tbl_usuario_x_bodega.IdBodega, mobileSCI.tbl_producto.IdProducto, mobileSCI.tbl_usuario_x_subcentro.IdCentroCosto, 
                         mobileSCI.tbl_usuario_x_subcentro.IdCentroCosto_sub_centro_costo, in_Producto.pr_descripcion, ct_centro_costo_sub_centro_costo.Centro_costo, 0 AS Expr1, 0 AS Expr2, 0 AS Expr3, 0 AS Expr4, 0 AS Expr5, 0 AS Expr6, 
                         0 AS Expr7, 0
FROM            in_Producto INNER JOIN
                         mobileSCI.tbl_producto INNER JOIN
                         mobileSCI.tbl_usuario_x_bodega ON mobileSCI.tbl_producto.IdEmpresa = mobileSCI.tbl_usuario_x_bodega.IdEmpresa ON in_Producto.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND 
                         in_Producto.IdProducto = mobileSCI.tbl_producto.IdProducto AND in_Producto.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND in_Producto.IdProducto = mobileSCI.tbl_producto.IdProducto AND 
                         in_Producto.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND in_Producto.IdProducto = mobileSCI.tbl_producto.IdProducto INNER JOIN
                         ct_centro_costo_sub_centro_costo INNER JOIN
                         mobileSCI.tbl_usuario_x_subcentro ON ct_centro_costo_sub_centro_costo.IdEmpresa = mobileSCI.tbl_usuario_x_subcentro.IdEmpresa AND 
                         ct_centro_costo_sub_centro_costo.IdCentroCosto = mobileSCI.tbl_usuario_x_subcentro.IdCentroCosto AND 
                         ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = mobileSCI.tbl_usuario_x_subcentro.IdCentroCosto_sub_centro_costo ON 
                         mobileSCI.tbl_usuario_x_bodega.IdEmpresa = mobileSCI.tbl_usuario_x_subcentro.IdEmpresa
WHERE        (mobileSCI.tbl_usuario_x_subcentro.IdUsuarioSCI = @IdUsuario)
GROUP BY mobileSCI.tbl_usuario_x_bodega.IdEmpresa, mobileSCI.tbl_usuario_x_bodega.IdSucursal, mobileSCI.tbl_usuario_x_bodega.IdBodega, mobileSCI.tbl_producto.IdProducto, mobileSCI.tbl_usuario_x_subcentro.IdCentroCosto, 
                         mobileSCI.tbl_usuario_x_subcentro.IdCentroCosto_sub_centro_costo, in_Producto.pr_descripcion, ct_centro_costo_sub_centro_costo.Centro_costo


SET DATEFIRST 1;
DECLARE @DIASEMANA INT, @FECHAINI DATETIME, @FECHAFIN DATETIME, @DIASHASTASABADO INT, @DIASHASTAVIERNES INT

select @DIASEMANA =  DATEPART ( dw , getdate() ) 
IF(@DIASEMANA = 6)
BEGIN
	SET @FECHAINI = CAST( DATEADD(DAY,- (0),GETDATE()) AS DATE)
	SET @FECHAFIN = CAST( DATEADD(DAY, (6),GETDATE()) AS DATE)
END
ELSE
IF(@DIASEMANA = 7)
BEGIN
	SET @FECHAINI = CAST( DATEADD(DAY,- (1),GETDATE()) AS DATE)
	SET @FECHAFIN = CAST( DATEADD(DAY, (5),GETDATE()) AS DATE)
END
ELSE
IF(@DIASEMANA = 1)
BEGIN
	SET @FECHAINI = CAST( DATEADD(DAY,- (2),GETDATE()) AS DATE)
	SET @FECHAFIN = CAST( DATEADD(DAY, (4),GETDATE()) AS DATE)
END
ELSE
IF(@DIASEMANA = 2)
BEGIN
	SET @FECHAINI = CAST( DATEADD(DAY,- (3),GETDATE()) AS DATE)
	SET @FECHAFIN = CAST( DATEADD(DAY, (3),GETDATE()) AS DATE)
END
ELSE
IF(@DIASEMANA = 3)
BEGIN
	SET @FECHAINI = CAST( DATEADD(DAY,- (4),GETDATE()) AS DATE)
	SET @FECHAFIN = CAST( DATEADD(DAY, (2),GETDATE()) AS DATE)
END
ELSE
IF(@DIASEMANA = 4)
BEGIN
	SET @FECHAINI = CAST( DATEADD(DAY,- (5),GETDATE()) AS DATE)
	SET @FECHAFIN = CAST( DATEADD(DAY, (1),GETDATE()) AS DATE)
END
ELSE
IF(@DIASEMANA = 5)
BEGIN
	SET @FECHAINI = CAST( DATEADD(DAY,- (6),GETDATE()) AS DATE)
	SET @FECHAFIN = CAST( DATEADD(DAY, (0),GETDATE()) AS DATE)
END

--SELECT @FECHAINI, @FECHAFIN, @DIASEMANA

UPDATE [mobileSCI].[tbl_consumo_semanal] SET LUNES = GRUPO.LUNES, MARTES = GRUPO.MARTES, MIERCOLES = GRUPO.MIERCOLES, JUEVES = GRUPO.JUEVES, VIERNES = GRUPO.VIERNES, SABADO = GRUPO.SABADO, DOMINGO = GRUPO.DOMINGO
FROM(
select A.IdEmpresa, A.IdSucursal, A.IdBodega, A.IdProducto, A.IdCentroCosto, A.IdCentroCosto_sub_centro_costo,
SUM(LUNES) LUNES, SUM(MARTES) MARTES, SUM(MIERCOLES) MIERCOLES, SUM(JUEVES) JUEVES, SUM(VIERNES) VIERNES, SUM(SABADO) SABADO, SUM(DOMINGO) DOMINGO
from (
		SELECT        d.IdEmpresa, D.IdSucursal, d.IdBodega, d.IdProducto, d.IdCentroCosto, d.IdCentroCosto_sub_centro_costo, 
						CASE WHEN DATEPART(dw, C.cm_fecha) = 1 THEN d .dm_cantidad ELSE 0 END AS LUNES, 
						CASE WHEN DATEPART(dw, C.cm_fecha) = 2 THEN d .dm_cantidad ELSE 0 END AS MARTES, 
						CASE WHEN DATEPART(dw, C.cm_fecha) = 3 THEN d .dm_cantidad ELSE 0 END AS MIERCOLES, 
						CASE WHEN DATEPART(dw, C.cm_fecha) = 4 THEN d .dm_cantidad ELSE 0 END AS JUEVES, 
						CASE WHEN DATEPART(dw, C.cm_fecha) = 5 THEN d .dm_cantidad ELSE 0 END AS VIERNES, 
						CASE WHEN DATEPART(dw, C.cm_fecha) = 6 THEN d .dm_cantidad ELSE 0 END AS SABADO, 
						CASE WHEN DATEPART(dw, C.cm_fecha) = 7 THEN d .dm_cantidad ELSE 0 END AS DOMINGO
		FROM            in_Ing_Egr_Inven_det AS d INNER JOIN
								 in_Ing_Egr_Inven AS c ON c.IdEmpresa = d.IdEmpresa AND c.IdSucursal = d.IdSucursal AND c.IdMovi_inven_tipo = d.IdMovi_inven_tipo AND c.IdNumMovi = d.IdNumMovi
		WHERE        (c.cm_fecha BETWEEN @FECHAINI AND @FECHAFIN) AND (d.IdCentroCosto_sub_centro_costo IS NOT NULL) AND (d.dm_cantidad < 0) AND (c.Estado = 'A')
		and exists(
		select f.IdEmpresa
		from [mobileSCI].[tbl_consumo_semanal] as f
		where f.IdEmpresa = d.IdEmpresa and f.IdSucursal = d.IdSucursal and f.IdBodega = d.IdBodega and f.IdProducto = d.IdProducto and f.IdCentroCosto = d.IdCentroCosto and f.IdCentroCosto_sub_centro_costo = d.IdCentroCosto_sub_centro_costo
		)
		UNION ALL

		SELECT        IdEmpresa, IdSucursal, IdBodega, IdProducto, IdCentroCosto, IdCentroCosto_sub_centro_costo, 
						CASE WHEN DATEPART(dw, FECHA) = 1 THEN cantidad ELSE 0 END AS LUNES, 
						CASE WHEN DATEPART(dw, FECHA) = 2 THEN cantidad ELSE 0 END AS MARTES, 
						CASE WHEN DATEPART(dw, FECHA) = 3 THEN cantidad ELSE 0 END AS MIERCOLES, 
						CASE WHEN DATEPART(dw, FECHA) = 4 THEN cantidad ELSE 0 END AS JUEVES, 
						CASE WHEN DATEPART(dw, FECHA) = 5 THEN cantidad ELSE 0 END AS VIERNES, 
						CASE WHEN DATEPART(dw, FECHA) = 6 THEN cantidad ELSE 0 END AS SABADO, 
						CASE WHEN DATEPART(dw, FECHA) = 7 THEN cantidad ELSE 0 END AS DOMINGO
		FROM            mobileSCI.tbl_movimientos_det
		WHERE        (IdCentroCosto_sub_centro_costo IS NOT NULL) AND FECHA BETWEEN @FECHAINI AND @FECHAFIN 
		and Estado = 'A' AND exists(
		select f.IdEmpresa
		from [mobileSCI].[tbl_consumo_semanal] as f
		where f.IdEmpresa = IdEmpresa and f.IdSucursal = IdSucursal and f.IdBodega = IdBodega and f.IdProducto = IdProducto and f.IdCentroCosto = IdCentroCosto and f.IdCentroCosto_sub_centro_costo = IdCentroCosto_sub_centro_costo
		)
		and not exists(
		select f.IdEmpresa from mobileSCI.tbl_movimientos_det_apro as f
		where f.IdSincronizacion = mobileSCI.tbl_movimientos_det.IdSincronizacion
		and f.IdSecuencia = mobileSCI.tbl_movimientos_det.IdSecuencia
		)
) A GROUP BY A.IdEmpresa, A.IdSucursal, A.IdBodega, A.IdProducto, A.IdCentroCosto, A.IdCentroCosto_sub_centro_costo
) GRUPO
WHERE [mobileSCI].[tbl_consumo_semanal].IdEmpresa = GRUPO.IdEmpresa and [mobileSCI].[tbl_consumo_semanal].IdSucursal = grupo.IdSucursal
and [mobileSCI].[tbl_consumo_semanal].IdBodega = grupo.IdBodega and [mobileSCI].[tbl_consumo_semanal].IdProducto = grupo.IdProducto
and [mobileSCI].[tbl_consumo_semanal].IdCentroCosto = grupo.IdCentroCosto and [mobileSCI].[tbl_consumo_semanal].IdCentroCosto_sub_centro_costo = grupo.IdCentroCosto_sub_centro_costo

UPDATE [mobileSCI].[tbl_consumo_semanal] SET TOTAL = LUNES + MARTES + MIERCOLES + JUEVES + VIERNES + SABADO + DOMINGO

select * from [mobileSCI].[tbl_consumo_semanal]