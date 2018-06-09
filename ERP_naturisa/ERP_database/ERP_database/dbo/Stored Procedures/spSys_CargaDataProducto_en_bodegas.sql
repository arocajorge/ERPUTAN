CREATE proc [dbo].[spSys_CargaDataProducto_en_bodegas] as

declare @idEmpresa int
declare @idsucursal int

declare @idbodega int


set @idsucursal =1
set @idbodega =1
set @idEmpresa =6


INSERT INTO in_producto_x_tb_bodega
(IdEmpresa			, IdSucursal			, IdBodega				, IdProducto			,pr_precio_publico	, pr_precio_mayor	, pr_precio_minimo
--, pr_pedidos			
,pr_costo_fob		   , pr_costo_CIF		, pr_costo_promedio     ,pr_precio_puerta
,pr_Por_descuento	,pr_stock_maximo		, pr_stock_minimo		,Estado 
--,IdCtaCble_Inven	, IdCtaCble_CosBaseIva	, IdCtaCble_CosBase0, IdCtaCble_VenIva	, IdCtaCble_Ven0
--, IdCtaCble_DesIva	, IdCtaCble_Des0		, IdCtaCble_DevIva	, IdCtaCble_Dev0
)

SELECT     
IdEmpresa			, @idsucursal			,@idbodega			, IdProducto			, pr_precio_publico	,pr_precio_mayor	, pr_precio_minimo
--, pr_pedidos			
, pr_costo_fob		, pr_costo_CIF		, pr_costo_promedio		,0
,0					, 0						, 0					, Estado
--, IdCtaCble_Inven	, IdCtaCble_CosBaseIva	, IdCtaCble_CosBase0, IdCtaCble_VenIva	, IdCtaCble_Ven0
--, IdCtaCble_DesIva	, IdCtaCble_Des0		, IdCtaCble_DevIva	, IdCtaCble_Dev0
FROM         in_Producto 
where IdEmpresa =@idEmpresa