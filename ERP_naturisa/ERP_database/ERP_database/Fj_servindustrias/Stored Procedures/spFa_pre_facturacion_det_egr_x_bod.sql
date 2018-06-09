
CREATE PROCEDURE [Fj_servindustrias].[spFa_pre_facturacion_det_egr_x_bod]
(
@i_IdEmpresa int,
@i_IdPrefacturacion numeric
)
AS

BEGIN
/*
declare @i_IdEmpresa int
declare @i_IdPrefacturacion numeric

set @i_IdEmpresa = 1
set @i_IdPrefacturacion = 1
*/
PRINT 'BORRO EGRESOS DE ESTA PREFACTURACION'
DELETE [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item]
WHERE IdEmpresa_egr = @i_IdEmpresa and
IdPrefacturacion = @i_IdPrefacturacion 

PRINT 'INSERTO EGRESOS'
INSERT INTO [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item]
           (
		   [IdEmpresa_egr]				           ,[IdPrefacturacion]				           ,[IdSucursal_egr]		
           ,[IdBodega_egr]				           ,[IdMovi_inven_tipo_egr]			           ,[IdNumMovi_egr]
           ,[Secuencia_egr]				           ,[codigo_reg_egr]				           ,[cantidad_egr]
           ,[dm_cantidad]				           ,[cm_fecha]						           ,[oc_NumDocumento]
           ,[IdProveedor]				           ,[IdProducto]					           ,[dm_precio]
           ,[IdCentro_Costo]			           ,[IdCentroCosto_sub_centro_costo]           ,[IdPunto_cargo]
           ,[Observacion_det]			           ,[Aplica_Iva]					           ,[Por_Iva]
           ,[Subtotal]					           ,[Valor_Iva]						           ,[Total]
		   ,[IdTarifario]						   ,[Porc_ganancia]							   ,[Facturar]
		   ,Secuencia							   
		   )
SELECT		IdEmpresa_mov_inv_egr,			IdPreFacturacion							,IdSucursal_mov_inv_egr,					
			IdBodega_mov_inv_egr,			IdMovi_inven_tipo_mov_inv_egr,				IdNumMovi_mov_inv_egr,
			Secuencia_det_egr,				codigo_reg,									cant_item_egr,							
			ISNULL(dm_cantidad,0),			cm_fecha,									0,
			null,							IdProducto,									null,
			IdCentro_Costo,					IdCentroCosto_sub_centro_costo,				IdPunto_cargo,
			observacion_det_egr,			isnull(Aplica_Iva,0),									Por_Iva
			,0								,0											,0
			,IdTarifario					,Porc_ganancia								,[Facturar]
			,sec_prefact
FROM					vwin_movi_inve_detalle_x_item_egresos 
WHERE					IdEmpresa_prefact = @i_IdEmpresa and IdPreFacturacion = @i_IdPrefacturacion

PRINT 'ACTUALIZO CAMPOS DE PRECIO, NUMERO DOCUMENTO, IDPRODUCTO, CODIGO'
UPDATE [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item]  SET
[oc_NumDocumento] = I.[oc_NumDocumento],
[IdProveedor]=I.[IdProveedor],
[IdProducto] = I.[IdProducto],
[dm_precio]=I.[dm_precio],
IdEmpresa_Oc=I.IdEmpresa_oc,
IdSucursal_Oc=I.IdSucursal_oc,
IdOrdenCompra_Oc=I.IdOrdenCompra
FROM(		
SELECT		[oc_NumDocumento],[IdProveedor],[IdProducto],[dm_precio],[codigo_reg],IdSucursal_oc,IdOrdenCompra,IdEmpresa_oc
FROM		vwin_movi_inve_detalle_x_item_ingresos 
WHERE					@i_IdEmpresa = IdEmpresa_ing ) I
WHERE [codigo_reg_egr] = I.[codigo_reg]

PRINT 'AGRUPAR EGRESOS Y LOS INSERTO'
INSERT INTO [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item]
           (
		   [IdEmpresa_egr]				           ,[IdPrefacturacion]				           ,[IdSucursal_egr]	,[Secuencia]
           ,[IdBodega_egr]				           ,[IdMovi_inven_tipo_egr]			           ,[IdNumMovi_egr]
           ,[Secuencia_egr]				           ,[codigo_reg_egr]				           ,[cantidad_egr]
           ,[dm_cantidad]				           ,[cm_fecha]						           ,[oc_NumDocumento]
           ,[IdProveedor]				           ,[IdProducto]					           ,[dm_precio]
           ,[IdCentro_Costo]			           ,[IdCentroCosto_sub_centro_costo]           ,[IdPunto_cargo]
           ,[Observacion_det]			           ,[Aplica_Iva]					           ,[Por_Iva]
           ,[Subtotal]					           ,[Valor_Iva]						           ,[Total]
		   ,[IdTarifario]						   ,[Porc_ganancia]							   ,[Facturar]	
		   , IdEmpresa_Oc							,IdSucursal_Oc								,IdOrdenCompra_Oc	   
		   )

SELECT				IdEmpresa_egr,				@i_IdPrefacturacion						,IdSucursal_egr,			ROW_NUMBER() OVER (ORDER BY IdEmpresa_egr) AS IdFila,
					IdBodega_egr,				IdMovi_inven_tipo_egr					,IdNumMovi_egr,
					Secuencia_egr,				NULL,									SUM(cantidad_egr)*-1 AS cantidad_egr,	
					dm_cantidad*-1,				cm_fecha,								oc_NumDocumento,						
					IdProveedor,				IdProducto,								dm_precio,
					[IdCentro_Costo]		    ,[IdCentroCosto_sub_centro_costo]	    ,[IdPunto_cargo],
					[Observacion_det]		    ,[Aplica_Iva]				            ,[Por_Iva],
					0,							0										,0
					,[IdTarifario]				,[Porc_ganancia]						,[Facturar]
					,IdEmpresa_Oc				,IdSucursal_Oc							,IdOrdenCompra_Oc
					
FROM [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item] 
WHERE @i_IdEmpresa = [IdEmpresa_egr] 
and @i_IdPrefacturacion = [IdPrefacturacion]
GROUP BY			IdEmpresa_egr								,IdSucursal_egr,
					IdBodega_egr,				IdMovi_inven_tipo_egr					,IdNumMovi_egr,
					Secuencia_egr,													
					dm_cantidad*-1,				cm_fecha,								oc_NumDocumento,						
					IdProveedor,				IdProducto,								dm_precio,
					[IdCentro_Costo]		    ,[IdCentroCosto_sub_centro_costo]	    ,[IdPunto_cargo],
					[Observacion_det]		    ,[Aplica_Iva]				            ,[Por_Iva],
					[Subtotal]					,[Valor_Iva]						    ,[Total],
					[IdTarifario]				,[Porc_ganancia]						,[Facturar]
					,IdEmpresa_Oc				,IdSucursal_Oc							,IdOrdenCompra_Oc

PRINT 'BORRO EGRESOS POR ITEM'
DELETE [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item] 
WHERE @i_IdEmpresa = [IdEmpresa_egr] 
and @i_IdPrefacturacion = [IdPrefacturacion]
and codigo_reg_egr is not null


PRINT 'RESTO LAS DEVOLUCIONES'

UPDATE [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item]
set cantidad_egr  = ISNULL(cantidad_egr,0) - ISNULL(Dev.cantidad_devuelta,0)
from vwin_devolucion_inven_det_cantidad_devuelta AS Dev
where Dev.IdEmpresa_movi_inv = [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdEmpresa_egr
and Dev.IdSucursal_movi_inv = [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdSucursal_egr
and Dev.IdBodega_movi_inv = [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdBodega_egr
and Dev.IdMovi_inven_tipo_movi_inv = [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdMovi_inven_tipo_egr
and Dev.IdNumMovi_movi_inv = [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdNumMovi_egr
and Dev.Secuencia_movi_inv = [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].Secuencia_egr
and [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdEmpresa_egr = @i_IdEmpresa
and [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdPreFacturacion = @i_IdPrefacturacion

PRINT 'CALCULO TOTALES'
		update [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item]
		set Subtotal=ISNULL(cantidad_egr,0)*ISNULL(dm_precio,0)
		,Valor_Iva=(ISNULL(cantidad_egr,0)*ISNULL(dm_precio,0))*Por_Iva/100
		,Total=(ISNULL(cantidad_egr,0)*ISNULL(dm_precio,0))+(ISNULL(cantidad_egr,0)*ISNULL(dm_precio,0))*Por_Iva/100
		where [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].Aplica_Iva=1
		and [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdEmpresa_egr = @i_IdEmpresa
		and [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdPrefacturacion = @i_IdPrefacturacion

		update [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item]
		set Subtotal=ISNULL(cantidad_egr,0)*ISNULL(dm_precio,0)
		,Valor_Iva=0
		,Total=(ISNULL(cantidad_egr,0)*ISNULL(dm_precio,0))
		where [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].Aplica_Iva=0
		and [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdEmpresa_egr = @i_IdEmpresa
		and [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdPrefacturacion = @i_IdPrefacturacion

PRINT 'BORRO DE LA TABLA DE PRE FACTURACION E INSERTO LO QUE TENGO EN LA TEMPORAL'
		delete Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod 
		where IdEmpresa = @i_IdEmpresa and
		IdPreFacturacion = @i_IdPrefacturacion

		INSERT INTO [Fj_servindustrias].[fa_pre_facturacion_det_egr_x_bod]
           ([IdEmpresa]								,[IdPreFacturacion]							       ,[secuencia]
           ,[IdCentro_Costo]						,[IdCentroCosto_sub_centro_costo]				   ,[IdPunto_cargo]
           ,[IdEmpresa_mov_inv]						,[IdSucursal_mov_inv]					           ,[IdBodega_mov_inv]
           ,[IdMovi_inven_tipo_mov_inv]				,[IdNumMovi_mov_inv]						       ,[Secuencia_det]
		   ,[observacion_det]						,[Cantidad]								           ,[Costo_Uni]
           ,[Aplica_Iva]				            ,[Por_Iva]									       ,[Facturar]
		   ,[Subtotal]								,[Valor_Iva]									   ,[Total]
		   ,[Porc_ganancia]							,[IdTarifario])

		SELECT	IdEmpresa_egr						,IdPrefacturacion									,ROW_NUMBER() OVER (ORDER BY IdEmpresa_egr)
				,[IdCentro_Costo]					,[IdCentroCosto_sub_centro_costo]					,[IdPunto_cargo]
				,IdEmpresa_egr						,IdSucursal_egr										,IdBodega_egr
				,IdMovi_inven_tipo_egr				,IdNumMovi_egr										,Secuencia_egr
				,Observacion_det					,cantidad_egr										,dm_precio
				,Aplica_Iva							,[Por_Iva]									        ,1
				,[Subtotal]						    ,[Valor_Iva]									,[Total]
				,[Porc_ganancia]					,[IdTarifario]
		FROM [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item]
		WHERE IdEmpresa_egr = @i_IdEmpresa and IdPrefacturacion = @i_IdPrefacturacion
		--=====================================================================

		

		
select * 
from [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item]
WHERE @i_IdEmpresa = [IdEmpresa_egr] 
and @i_IdPrefacturacion = [IdPrefacturacion]
END


--select * from Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod
--select * from Fj_servindustrias.vwfa_pre_facturacion_det_egr_x_bod
-- select * from vwin_movi_inve_detalle_x_item_ingresos

  select * from [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item]
  select * from vwin_movi_inve_detalle_x_item_egresos