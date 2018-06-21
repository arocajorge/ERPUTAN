CREATE PROCEDURE mobileSCI.sp_stock
(
@IdUsuario varchar(50)
)
AS
BEGIN
DELETE [mobileSCI].[tbl_stock]

INSERT INTO [mobileSCI].[tbl_stock]
           ([IdEmpresa]
           ,[IdSucursal]
           ,[IdBodega]
           ,[IdProducto]
           ,[CodProducto]
           ,[NomProducto]
           ,[IdUnidadMedida_Consumo]
           ,[Stock]
           ,[NomUnidadMedida])

SELECT in_producto_x_tb_bodega.IdEmpresa, in_producto_x_tb_bodega.IdSucursal, in_producto_x_tb_bodega.IdBodega, in_producto_x_tb_bodega.IdProducto, in_Producto.pr_codigo, in_Producto.pr_descripcion, 
                  in_Producto.IdUnidadMedida_Consumo, 0, in_UnidadMedida.Descripcion
FROM     mobileSCI.tbl_producto INNER JOIN
                  in_Producto ON mobileSCI.tbl_producto.IdEmpresa = in_Producto.IdEmpresa AND mobileSCI.tbl_producto.IdProducto = in_Producto.IdProducto INNER JOIN
                  in_producto_x_tb_bodega ON in_Producto.IdEmpresa = in_producto_x_tb_bodega.IdEmpresa AND in_Producto.IdProducto = in_producto_x_tb_bodega.IdProducto AND in_Producto.IdEmpresa = in_producto_x_tb_bodega.IdEmpresa AND 
                  in_Producto.IdProducto = in_producto_x_tb_bodega.IdProducto INNER JOIN
                  in_UnidadMedida ON in_Producto.IdUnidadMedida_Consumo = in_UnidadMedida.IdUnidadMedida RIGHT OUTER JOIN
                  mobileSCI.tbl_usuario_x_bodega ON in_producto_x_tb_bodega.IdEmpresa = mobileSCI.tbl_usuario_x_bodega.IdEmpresa AND in_producto_x_tb_bodega.IdSucursal = mobileSCI.tbl_usuario_x_bodega.IdSucursal AND 
                  in_producto_x_tb_bodega.IdBodega = mobileSCI.tbl_usuario_x_bodega.IdBodega
where mobileSCI.tbl_usuario_x_bodega.IdUsuarioSCI = @IdUsuario

UPDATE [mobileSCI].[tbl_stock] SET Stock = a.stock
FROM(
SELECT F.IdEmpresa, F.IdSucursal, F.IdBodega, F.IdProducto, sum(F.stock) stock
FROM(
SELECT in_Ing_Egr_Inven_det.IdEmpresa, in_Ing_Egr_Inven_det.IdSucursal, in_Ing_Egr_Inven_det.IdBodega, in_Ing_Egr_Inven_det.IdProducto, SUM(in_Ing_Egr_Inven_det.dm_cantidad) AS stock
FROM     in_Ing_Egr_Inven_det INNER JOIN
                  in_movi_inven_tipo ON in_Ing_Egr_Inven_det.IdEmpresa = in_movi_inven_tipo.IdEmpresa AND in_Ing_Egr_Inven_det.IdMovi_inven_tipo = in_movi_inven_tipo.IdMovi_inven_tipo INNER JOIN
                  mobileSCI.tbl_producto ON in_Ing_Egr_Inven_det.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND in_Ing_Egr_Inven_det.IdProducto = mobileSCI.tbl_producto.IdProducto INNER JOIN
                  in_Ing_Egr_Inven ON in_Ing_Egr_Inven_det.IdEmpresa = in_Ing_Egr_Inven.IdEmpresa AND in_Ing_Egr_Inven_det.IdSucursal = in_Ing_Egr_Inven.IdSucursal AND 
                  in_Ing_Egr_Inven_det.IdMovi_inven_tipo = in_Ing_Egr_Inven.IdMovi_inven_tipo AND in_Ing_Egr_Inven_det.IdNumMovi = in_Ing_Egr_Inven.IdNumMovi INNER JOIN
                  in_Motivo_Inven ON in_Ing_Egr_Inven.IdEmpresa = in_Motivo_Inven.IdEmpresa AND in_Ing_Egr_Inven.IdMotivo_Inv = in_Motivo_Inven.IdMotivo_Inv
WHERE  (in_Motivo_Inven.Genera_Movi_Inven = 'S') AND (in_movi_inven_tipo.Genera_Movi_Inven = 1) AND (in_Ing_Egr_Inven.Estado = 'A')
GROUP BY in_Ing_Egr_Inven_det.IdEmpresa, in_Ing_Egr_Inven_det.IdSucursal, in_Ing_Egr_Inven_det.IdBodega, in_Ing_Egr_Inven_det.IdProducto
union all
SELECT IdEmpresa, IdSucursal, IdBodega, IdProducto, SUM(cantidad) AS CANTIDAD
FROM     mobileSCI.tbl_movimientos_det
WHERE  (Aprobado = 0) AND (Estado = 'A')
GROUP BY IdEmpresa, IdSucursal, IdBodega, IdProducto
) F
group by F.IdEmpresa, F.IdSucursal, F.IdBodega, F.IdProducto 
) A
WHERE 
[mobileSCI].[tbl_stock].IdEmpresa = a.IdEmpresa
AND [mobileSCI].[tbl_stock].IdSucursal = A.IdSucursal
AND [mobileSCI].[tbl_stock].IdBodega = A.IdBodega
AND [mobileSCI].[tbl_stock].IdProducto = A.IdProducto

SELECT * FROM [mobileSCI].[tbl_stock]
END