
CREATE PROCEDURE spIn_Carga_en_lote_Productos_a_Producto_x_Bodega
(
 @IdEmpresa int
)
as
begin

INSERT INTO in_producto_x_tb_bodega
( IdEmpresa						, IdSucursal			, IdBodega			, IdProducto		, pr_precio_publico	, pr_precio_mayor	, pr_precio_puerta	, pr_precio_minimo
, pr_Por_descuento				, pr_stock_maximo		, pr_stock_minimo	, pr_costo_fob		, pr_costo_CIF		,pr_costo_promedio	
, IdCtaCble_Inven				, IdCtaCble_Costo		
, IdCtaCble_Vta					, IdCtaCble_VenIva				, IdCtaCble_Ven0		
, IdCtaCble_DesIva				, IdCtaCble_Des0	
, IdCtaCble_DevIva				, IdCtaCble_Dev0				
, IdCtaCble_Gasto_x_cxp
,Estado
 )

SELECT        
in_Producto.IdEmpresa				,tb_bodega.IdSucursal	,tb_bodega.IdBodega	, IdProducto		,pr_precio_publico	, pr_precio_mayor, pr_precio_puerta			,pr_precio_minimo
,0									,0						,0					,0					,0					,0				
, in_subgrupo.IdCtaCtble_Inve		, in_subgrupo.IdCtaCtble_Costo	
, in_subgrupo.IdCtaCble_Vta			,in_subgrupo.IdCtaCble_Vta		,in_subgrupo.IdCtaCble_Vta
, in_subgrupo.IdCtaCble_Des0		,in_subgrupo.IdCtaCble_Des0		
, in_subgrupo.IdCtaCble_Dev0			,in_subgrupo.IdCtaCble_Dev0
, in_subgrupo.IdCtaCtble_Gasto_x_cxp
,'A'
FROM            in_Producto INNER JOIN
                         in_subgrupo ON in_Producto.IdEmpresa = in_subgrupo.IdEmpresa AND in_Producto.IdCategoria = in_subgrupo.IdCategoria AND in_Producto.IdLinea = in_subgrupo.IdLinea AND 
                         in_Producto.IdGrupo = in_subgrupo.IdGrupo AND in_Producto.IdSubGrupo = in_subgrupo.IdSubgrupo INNER JOIN
                         tb_bodega ON in_Producto.IdEmpresa = tb_bodega.IdEmpresa
where not exists
			(

					select A.IdEmpresa 
					from in_producto_x_tb_bodega A
					where A.IdEmpresa=in_Producto.IdEmpresa
					and A.IdProducto=in_Producto.IdProducto
					and A.IdSucursal=tb_bodega.IdSucursal
					and A.IdBodega=tb_bodega.IdBodega

			)
and in_Producto.IdEmpresa=@IdEmpresa


end