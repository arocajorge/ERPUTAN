--exec [dbo].[spSys_Inv_Recosteo_Inventario_x_producto] 3,3,6,2156,'15/03/2018',10

CREATE proc [dbo].[spSys_Inv_Recosteo_Inventario_x_producto] 
(
@IdEmpresa int,
@IdSucursal int,
@IdBodega int,
@IdProducto numeric,
@Fecha_ini datetime,
@cant_Decimales int
)
AS
BEGIN

 SET NOCOUNT ON;

--VARIABLES PARA CURSOR X SUCURSAL X BODEGA X PRODUCTO
	declare @C_IdEmpresa int 
	declare @C_IdSucursal int 
	declare @C_IdBodega int
	declare @C_IdProducto numeric

 --VARIABLES PARA CURSOR X MOVIMIENTO
	declare @C2_IdEmpresa int 
	declare @C2_IdSucursal int 
	declare @C2_IdBodega int 
	declare @C2_cm_fecha datetime
	declare @C2_IdProducto numeric	
	declare @C2_IdMovi_inven_tipo int 
	declare @C2_IdNumMovi numeric
	declare @C2_Secuencia int 
	declare @C2_dm_cantidad float
	declare @C2_mv_costo float

 -- VARIABLES PARA COSTEO
	DECLARE @W_Cantidad_compra float
	DECLARE @W_Costo_compra float
	DECLARE @W_Cantidad_a_la_fecha float
	DECLARE @W_Costo_total_a_la_fecha float
	DECLARE @W_Costo_promedio float
	DECLARE @W_Ult_Costo_promedio float
	DECLARE @W_IdFecha int
	DECLARE @W_Secuencia int

	DECLARE @IdFecha_eliminar int = CAST(CAST(YEAR(@Fecha_ini) AS VARCHAR) + (REPLICATE('0',2-LEN(MONTH(@Fecha_ini))) + CAST(MONTH(@Fecha_ini) AS VARCHAR)) + (REPLICATE('0',2-LEN(DAY(@Fecha_ini))) + CAST(DAY(@Fecha_ini) AS VARCHAR)) AS INT)

 --ELIMINO LA TABLA DE IN_PRODUCTO_X_TB_BODEGA_COSTO_HISTORICO LOS REGISTROS DE LA SUCURSAL Y BODEGA QUE VOY A RECOSTEAR
	DELETE in_producto_x_tb_bodega_Costo_Historico
	where IdEmpresa = @IdEmpresa
	and IdSucursal = @IdSucursal
	and IdBodega = @IdBodega
	and IdProducto = @IdProducto
	and IdFecha >= @IdFecha_eliminar

--LIMPIO LA TABLA DE RECOSTEO 
	delete in_Recosteo_Productos_x_movi_inve_detalle

--RESETEO CAMPOS DE RECOSTEO
UPDATE in_movi_inve_detalle set Costeado = 0
where exists(
	SELECT det.IdEmpresa,det.IdSucursal,det.IdBodega,det.IdProducto,cab.cm_fecha, det.dm_cantidad, det.mv_costo FROM in_movi_inve cab inner join in_movi_inve_detalle det
	on cab.IdEmpresa = det.IdEmpresa and cab.IdSucursal = det.IdSucursal and cab.IdBodega = det.IdBodega
	and cab.IdMovi_inven_tipo = det.IdMovi_inven_tipo and cab.IdNumMovi = det.IdNumMovi
	WHERE det.IdEmpresa = @IdEmpresa
	and det.IdSucursal = @IdSucursal
	and det.IdBodega = @IdBodega
	and det.IdProducto = @IdProducto
	and cab.cm_fecha >= @Fecha_ini
	and in_movi_inve_detalle.IdEmpresa = det.IdEmpresa
	and in_movi_inve_detalle.IdSucursal = det.IdSucursal
	and in_movi_inve_detalle.IdBodega = det.IdBodega
	and in_movi_inve_detalle.IdMovi_inven_tipo = det.IdMovi_inven_tipo
	and in_movi_inve_detalle.IdNumMovi = det.IdNumMovi
	and in_movi_inve_detalle.Secuencia = det.Secuencia
)

--INSERTO EN UNA TABLA TEMPORAL LOS REGISTROS QUE VOY A RECOSTEAR
	insert into in_Recosteo_Productos_x_movi_inve_detalle
	(IdEmpresa,IdSucursal,IdBodega,IdProducto)
	select cab.IdEmpresa,cab.IdSucursal,cab.IdBodega,det.IdProducto 
	from in_movi_inve_detalle det inner join
	in_movi_inve cab on 
	cab.IdEmpresa = det.IdEmpresa 
	and cab.IdSucursal = det.IdSucursal 
	and cab.IdBodega = det.IdBodega 
	and cab.IdMovi_inven_tipo = det.IdMovi_inven_tipo 
	and cab.IdNumMovi = det.IdNumMovi
	where cab.IdEmpresa = @IdEmpresa
	and cab.IdSucursal = @IdSucursal
	and cab.IdBodega = @IdBodega
	and det.IdProducto = @IdProducto
	and cab.cm_fecha >= @Fecha_ini
	group by cab.IdEmpresa,cab.IdSucursal,cab.IdBodega,det.IdProducto


--DECLARO CURSOR POR PRODUCTO
		DECLARE product_cursor CURSOR FOR   
		SELECT  IdEmpresa, IdSucursal, IdBodega, IdProducto
		FROM    in_Recosteo_Productos_x_movi_inve_detalle
		
		OPEN			product_cursor  --ABRO CURSOR
		FETCH NEXT FROM product_cursor 
		INTO			@C_IdEmpresa, @C_IdSucursal, @C_IdBodega, @C_IdProducto

		IF @@FETCH_STATUS <> 0   
		PRINT 'NO HAY DATOS PARA CONTINUAR'       
  
		WHILE @@FETCH_STATUS = 0  
		BEGIN  --DECLARO CURSOR POR MOVIMIENTO DE EL PRODUCTO EN EL PRIMER CURSOR
				DECLARE Movi_Inven_x_product_cursor CURSOR FOR   
					select cab.IdEmpresa,cab.IdSucursal,cab.IdBodega,cab.cm_fecha,det.IdProducto,
					cab.IdMovi_inven_tipo,cab.IdNumMovi,det.Secuencia,dm_cantidad,mv_costo
					from in_movi_inve_detalle det inner join
					in_movi_inve cab on cab.IdEmpresa = det.IdEmpresa and cab.IdSucursal = det.IdSucursal 
					and cab.IdBodega = det.IdBodega and cab.IdMovi_inven_tipo = det.IdMovi_inven_tipo and cab.IdNumMovi = det.IdNumMovi 
					where cab.IdEmpresa = @C_IdEmpresa and cab.IdSucursal = @C_IdSucursal and cab.IdBodega = @C_IdBodega 
					and det.IdProducto = @C_IdProducto and cab.cm_fecha >= @Fecha_ini
					ORDER BY cab.IdEmpresa,cab.IdSucursal,cab.IdBodega,det.IdProducto,cab.cm_fecha asc, det.dm_cantidad desc, det.IdNumMovi asc, det.Secuencia asc
				OPEN Movi_Inven_x_product_cursor  
				FETCH NEXT FROM Movi_Inven_x_product_cursor 
				into @C2_IdEmpresa			,@C2_IdSucursal			,@C2_IdBodega		,@C2_cm_fecha			,@C2_IdProducto 
					,@C2_IdMovi_inven_tipo	,@C2_IdNumMovi			,@C2_Secuencia		,@C2_dm_cantidad		,@C2_mv_costo 

				IF @@FETCH_STATUS <> 0   
				PRINT 'NO EXISTE MOVIMIENTO PARA EL PRODUCTO'

				WHILE @@FETCH_STATUS = 0  
				BEGIN 
					SET @W_Cantidad_compra = 0
							SET @W_Costo_compra = 0
							SET @W_Cantidad_a_la_fecha = 0
							SET @W_Ult_Costo_promedio = 0
							SET @W_Secuencia = 0
							SET @W_Costo_promedio = 0
							SET @W_Costo_total_a_la_fecha = 0

					IF(@C2_dm_cantidad > 0) -- SI MOVIMIENTO ES POSITIVO INSERTO EN TABLA DE COSTO HISTORICO
					BEGIN
						--ACTUALIZO CAMPO DE PROCESO DE RECOSTEO
							UPDATE in_movi_inve_detalle set Costeado = 1
							where IdEmpresa = @C2_IdEmpresa
							and IdSucursal = @C2_IdSucursal
							and IdBodega = @C2_IdBodega
							and IdMovi_inven_tipo = @C2_IdMovi_inven_tipo
							and IdNumMovi = @C2_IdNumMovi
							and Secuencia = @C2_Secuencia
						--CANTIDAD COMPRA
							set @W_Cantidad_compra = @C2_dm_cantidad 
						--COSTO COMPRA
							set @W_Costo_compra = @C2_mv_costo 
						--CANTIDAD Y COSTO A LA FECHA
							SELECT @W_Cantidad_a_la_fecha = SUM(det.dm_cantidad)
							, @W_Costo_total_a_la_fecha = SUM(det.dm_cantidad * det.mv_costo)
							FROM in_movi_inve cab inner join in_movi_inve_detalle det
							on cab.IdEmpresa = det.IdEmpresa and cab.IdSucursal = det.IdSucursal and cab.IdBodega = det.IdBodega
							and cab.IdMovi_inven_tipo = det.IdMovi_inven_tipo and cab.IdNumMovi = det.IdNumMovi
							WHERE det.IdEmpresa = @C2_IdEmpresa and det.IdSucursal = @C2_IdSucursal and det.IdBodega = @C2_IdBodega
							and det.IdProducto = @C2_IdProducto and cab.cm_fecha <= @C2_cm_fecha and Costeado = 1 
							and not exists(
							select f.IdEmpresa from in_movi_inve_detalle as f
							where f.IdEmpresa = @C2_IdEmpresa
							and f.IdSucursal = @C2_IdSucursal
							and f.IdBodega = @C2_IdBodega
							and f.IdMovi_inven_tipo = @C2_IdMovi_inven_tipo
							and f.IdNumMovi = @C2_IdNumMovi
							and f.Secuencia = @C2_Secuencia
							and det.IdEmpresa = f.IdEmpresa
							and det.IdSucursal = f.IdSucursal
							and det.IdBodega = f.IdBodega
							and det.IdMovi_inven_tipo = f.IdMovi_inven_tipo
							and det.IdNumMovi = f.IdNumMovi
							and det.Secuencia = f.Secuencia
							)
							GROUP BY det.IdEmpresa, det.IdSucursal, det.IdBodega, det.IdProducto													
						--CREAR IDFECHA
							SET @W_IdFecha = CAST(CAST(YEAR(@C2_cm_fecha) AS VARCHAR) + (REPLICATE('0',2-LEN(MONTH(@C2_cm_fecha))) + CAST(MONTH(@C2_cm_fecha) AS VARCHAR)) + (REPLICATE('0',2-LEN(DAY(@C2_cm_fecha))) + CAST(DAY(@C2_cm_fecha) AS VARCHAR)) AS INT)
						--OBTENER SECUENCIA
							SELECT @W_Secuencia = max(Secuencia)+1 FROM in_producto_x_tb_bodega_Costo_Historico
							WHERE IdEmpresa = @C2_IdEmpresa
								and IdSucursal = @C2_IdSucursal
								and IdBodega = @C2_IdBodega
								and IdProducto = @C2_IdProducto
								and fecha = @C2_cm_fecha															
						--CORRECCION DE DATA Y CALCULO DE COSTO PROMEDIO
							SET @W_Cantidad_compra = ISNULL(@W_Cantidad_compra,0)
							SET @W_Costo_compra = ISNULL(@W_Costo_compra,0)
							SET @W_Cantidad_a_la_fecha = isnull(@W_Cantidad_a_la_fecha,0)
							SET @W_Ult_Costo_promedio = ISNULL(@W_Ult_Costo_promedio,0)
							SET @W_Secuencia = isnull(@W_Secuencia,1)

								BEGIN TRY
							SET @W_Costo_promedio = ((@W_Cantidad_compra * @W_Costo_compra) + @W_Costo_total_a_la_fecha)/ (@w_cantidad_compra + @W_Cantidad_a_la_fecha)
								END TRY
								BEGIN CATCH
							SET @W_Costo_promedio = @W_Ult_Costo_promedio
								END CATCH

							SET @W_Costo_promedio = abs(@W_Costo_promedio)
						--INSERTO NUEVO COSTO 
							INSERT INTO [dbo].[in_producto_x_tb_bodega_Costo_Historico]
							([IdEmpresa]            ,[IdSucursal]           ,[IdBodega]           ,[IdProducto]
							,[IdFecha]	            ,[Secuencia]	     ,[fecha]		
							,[costo]				,[Stock_a_la_fecha]     
							,[Observacion]			,[fecha_trans])
							VALUES
							(
							@C2_IdEmpresa			,@C2_IdSucursal			,@C2_IdBodega			,@C2_IdProducto
							,@W_IdFecha				,@W_Secuencia			,@C2_cm_fecha			
							,@W_Costo_promedio		,@W_Cantidad_a_la_fecha + @C2_dm_cantidad
							,'SU '+CAST(@C2_IdSucursal AS VARCHAR) + ' BO '+CAST( @C2_IdBodega AS VARCHAR) + 'TM '+CAST(@C2_IdMovi_inven_tipo AS VARCHAR)+ 'NM '+CAST(@C2_IdNumMovi AS VARCHAR)
							,GETDATE()
							)						
					END
					ELSE
					BEGIN							
						--COSTO PROMEDIO
							SET @W_Ult_Costo_promedio = 
							(
								SELECT top 1 costo FROM in_producto_x_tb_bodega_Costo_Historico
								WHERE IdEmpresa = @C2_IdEmpresa
								and IdSucursal = @C2_IdSucursal
								and IdBodega = @C2_IdBodega
								and IdProducto = @C2_IdProducto
								and fecha <= @C2_cm_fecha
								ORDER BY IdEmpresa,IdSucursal,IdBodega,IdProducto,fecha DESC, Secuencia desc
							)
						--CORRECCION DE DATA Y CALCULO DE COSTO PROMEDIO
								SET @W_Cantidad_compra = ISNULL(@W_Cantidad_compra,0)
								SET @W_Costo_compra = ISNULL(@W_Costo_compra,0)
								SET @W_Cantidad_a_la_fecha = isnull(@W_Cantidad_a_la_fecha,0)
								SET @W_Ult_Costo_promedio = ISNULL(@W_Ult_Costo_promedio,0)		
						--ACTUALIZO CAMPO DE PROCESO DE RECOSTEO
								
								UPDATE in_movi_inve_detalle  set mv_costo = @W_Ult_Costo_promedio, Costeado = 1
								where IdEmpresa = @C2_IdEmpresa
								and IdSucursal = @C2_IdSucursal
								and IdBodega = @C2_IdBodega
								and IdMovi_inven_tipo = @C2_IdMovi_inven_tipo
								and IdNumMovi = @C2_IdNumMovi
								and Secuencia = @C2_Secuencia



								UPDATE in_Ing_Egr_Inven_det set mv_costo = @W_Ult_Costo_promedio
								where IdEmpresa_inv = @C2_IdEmpresa
								and IdSucursal_inv = @C2_IdSucursal
								and IdBodega_inv = @C2_IdBodega
								and IdMovi_inven_tipo_inv = @C2_IdMovi_inven_tipo
								and IdNumMovi_inv = @C2_IdNumMovi
								and secuencia_inv = @C2_Secuencia
					END
				FETCH NEXT FROM Movi_Inven_x_product_cursor 
					into @C2_IdEmpresa		,@C2_IdSucursal			,@C2_IdBodega	,@C2_cm_fecha		,@C2_IdProducto 
					,@C2_IdMovi_inven_tipo	,@C2_IdNumMovi	,@C2_Secuencia		,@C2_dm_cantidad 
					,@C2_mv_costo 
				END  
				CLOSE Movi_Inven_x_product_cursor  
				DEALLOCATE Movi_Inven_x_product_cursor
				
		FETCH NEXT FROM product_cursor 
		INTO @C_IdEmpresa, @C_IdSucursal, @C_IdBodega, @C_IdProducto
		END  
		CLOSE product_cursor  --CIERRO CURSOR
		DEALLOCATE product_cursor  


		SELECT  *
		FROM    vwin_producto_x_tb_bodega_Costo_Historico
		WHERE IdEmpresa = @IdEmpresa
		AND IdSucursal = @IdSucursal
		AND IdBodega = @IdBodega
		AND IdProducto = @IdProducto

END