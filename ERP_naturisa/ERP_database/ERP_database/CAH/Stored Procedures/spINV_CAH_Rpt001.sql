--exec [CAH].[spINV_CAH_Rpt001] 1,1,999,1,999,'01/12/2017'
CREATE PROCEDURE [CAH].[spINV_CAH_Rpt001]
(
@IdEmpresa int,
@IdSucursal_ini int,
@IdSucursal_fin int,
@IdBodega_ini int,
@IdBodega_fin int,
@fecha_corte datetime
)
as
begin
SELECT        in_producto_x_tb_bodega.IdEmpresa, in_producto_x_tb_bodega.IdSucursal, in_producto_x_tb_bodega.IdBodega,in_producto_x_tb_bodega.IdProducto, tb_bodega.bo_Descripcion AS nom_bodega, 
                         tb_sucursal.Su_Descripcion AS nom_sucursal, in_Producto.pr_codigo, in_Producto.pr_descripcion, in_Producto.pr_observacion, 
                         ISNULL(SUM(in_movi_inve_detalle.dm_cantidad), 0) AS Stock,  
						 ISNULL(SUM(in_movi_inve_detalle.dm_cantidad * in_movi_inve_detalle.mv_costo) / IIF(SUM(in_movi_inve_detalle.dm_cantidad) = 0, 1, SUM(in_movi_inve_detalle.dm_cantidad)) ,0) AS mv_costo, 
                         ISNULL(SUM(in_movi_inve_detalle.dm_cantidad * in_movi_inve_detalle.mv_costo),0) AS costo_total, in_Producto.IdCategoria, 
                         in_categorias.ca_Categoria, in_Producto.IdLinea, in_linea.nom_linea, in_UnidadMedida.Descripcion AS nom_UnidadMedida
FROM            in_UnidadMedida INNER JOIN
                         in_Producto INNER JOIN
                         in_categorias INNER JOIN
                         in_linea ON in_categorias.IdEmpresa = in_linea.IdEmpresa AND in_categorias.IdCategoria = in_linea.IdCategoria ON 
                         in_Producto.IdEmpresa = in_linea.IdEmpresa AND in_Producto.IdCategoria = in_linea.IdCategoria AND in_Producto.IdLinea = in_linea.IdLinea ON 
                         in_UnidadMedida.IdUnidadMedida = in_Producto.IdUnidadMedida_Consumo RIGHT OUTER JOIN
                         in_producto_x_tb_bodega LEFT OUTER JOIN
                         in_movi_inve_detalle INNER JOIN
                         in_movi_inve ON in_movi_inve.IdEmpresa = in_movi_inve_detalle.IdEmpresa AND in_movi_inve.IdSucursal = in_movi_inve_detalle.IdSucursal AND 
                         in_movi_inve.IdBodega = in_movi_inve_detalle.IdBodega AND in_movi_inve.IdMovi_inven_tipo = in_movi_inve_detalle.IdMovi_inven_tipo AND 
                         in_movi_inve.IdNumMovi = in_movi_inve_detalle.IdNumMovi ON in_producto_x_tb_bodega.IdEmpresa = in_movi_inve_detalle.IdEmpresa AND 
                         in_producto_x_tb_bodega.IdSucursal = in_movi_inve_detalle.IdSucursal AND in_producto_x_tb_bodega.IdBodega = in_movi_inve_detalle.IdBodega AND 
                         in_producto_x_tb_bodega.IdProducto = in_movi_inve_detalle.IdProducto LEFT OUTER JOIN
                         tb_bodega INNER JOIN
                         tb_sucursal ON tb_bodega.IdEmpresa = tb_sucursal.IdEmpresa AND tb_bodega.IdSucursal = tb_sucursal.IdSucursal ON 
                         in_producto_x_tb_bodega.IdEmpresa = tb_bodega.IdEmpresa AND in_producto_x_tb_bodega.IdSucursal = tb_bodega.IdSucursal AND 
                         in_producto_x_tb_bodega.IdBodega = tb_bodega.IdBodega ON in_Producto.IdEmpresa = in_producto_x_tb_bodega.IdEmpresa AND 
                         in_Producto.IdProducto = in_producto_x_tb_bodega.IdProducto
where (in_producto_x_tb_bodega.IdEmpresa = @IdEmpresa) and (in_producto_x_tb_bodega.IdSucursal between @IdSucursal_ini and @IdSucursal_fin) and (in_producto_x_tb_bodega.IdBodega between @IdBodega_ini and @IdBodega_fin)
and (isnull(in_movi_inve.cm_fecha, @fecha_corte) <= @fecha_corte)
GROUP BY in_producto_x_tb_bodega.IdEmpresa, in_producto_x_tb_bodega.IdSucursal, in_producto_x_tb_bodega.IdBodega, in_producto_x_tb_bodega.IdProducto,
						tb_bodega.bo_Descripcion, tb_sucursal.Su_Descripcion, 
                         in_Producto.pr_codigo, in_Producto.pr_descripcion, in_Producto.pr_observacion, 
                         in_Producto.IdCategoria, in_categorias.ca_Categoria, in_Producto.IdLinea, in_linea.nom_linea, in_UnidadMedida.Descripcion
end