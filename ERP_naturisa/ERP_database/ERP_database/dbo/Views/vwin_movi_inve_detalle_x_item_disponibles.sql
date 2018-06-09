CREATE VIEW [dbo].[vwin_movi_inve_detalle_x_item_disponibles]
AS
SELECT        dbo.in_movi_inve_detalle_x_item.IdEmpresa, dbo.in_movi_inve_detalle_x_item.IdSucursal, dbo.in_movi_inve_detalle_x_item.IdBodega, 
                         in_movi_inve_detalle_x_item.codigo_reg, SUM(dbo.in_movi_inve_detalle_x_item.cantidad) AS cantidad, 
                         dbo.in_movi_inve_detalle.IdProducto, dbo.in_movi_inve.cm_fecha
FROM            dbo.in_movi_inve INNER JOIN
                         dbo.in_movi_inve_detalle ON dbo.in_movi_inve.IdEmpresa = dbo.in_movi_inve_detalle.IdEmpresa AND 
                         dbo.in_movi_inve.IdSucursal = dbo.in_movi_inve_detalle.IdSucursal AND dbo.in_movi_inve.IdBodega = dbo.in_movi_inve_detalle.IdBodega AND 
                         dbo.in_movi_inve.IdMovi_inven_tipo = dbo.in_movi_inve_detalle.IdMovi_inven_tipo AND 
                         dbo.in_movi_inve.IdNumMovi = dbo.in_movi_inve_detalle.IdNumMovi INNER JOIN
                         dbo.in_movi_inve_detalle_x_item ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_movi_inve_detalle_x_item.IdEmpresa AND 
                         dbo.in_movi_inve_detalle.IdSucursal = dbo.in_movi_inve_detalle_x_item.IdSucursal AND 
                         dbo.in_movi_inve_detalle.IdBodega = dbo.in_movi_inve_detalle_x_item.IdBodega AND 
                         dbo.in_movi_inve_detalle.IdMovi_inven_tipo = dbo.in_movi_inve_detalle_x_item.IdMovi_inven_tipo AND 
                         dbo.in_movi_inve_detalle.IdNumMovi = dbo.in_movi_inve_detalle_x_item.IdNumMovi AND 
                         dbo.in_movi_inve_detalle.Secuencia = dbo.in_movi_inve_detalle_x_item.Secuencia
WHERE        (dbo.in_movi_inve_detalle_x_item.codigo_reg NOT IN
                             (SELECT  codigo_reg AS cant_disponible
							 FROM            dbo.in_movi_inve_detalle_x_item AS i
                               GROUP BY codigo_reg
                               HAVING  sum(i.cantidad)=0))--(COUNT(codigo_reg) > 1)))
GROUP BY dbo.in_movi_inve_detalle_x_item.IdEmpresa, dbo.in_movi_inve_detalle_x_item.IdSucursal, dbo.in_movi_inve_detalle_x_item.IdBodega, 
                         in_movi_inve_detalle_x_item.codigo_reg, dbo.in_movi_inve_detalle.IdProducto,dbo.in_movi_inve.cm_fecha