CREATE VIEW [dbo].[vwin_Ing_Egr_Inven_det_PorIngresar]
AS
SELECT b.IdEmpresa, b.IdSucursal, b.IdOrdenCompra, b.Secuencia, d.codigo + '-' + CAST(b.IdOrdenCompra AS varchar(20)) AS oc_NumDocumento, d.Su_Descripcion, a.IdProveedor, f.pe_nombreCompleto, a.oc_fecha, a.oc_observacion, 
                  b.IdProducto, g.pr_codigo, g.pr_descripcion, b.do_precioFinal, b.do_Cantidad, ISNULL(c.dm_cantidad, 0) AS CantidadIngresada, b.do_Cantidad - ISNULL(c.dm_cantidad, 0) AS Saldo, b.IdCentroCosto, b.IdCentroCosto_sub_centro_costo, 
                  b.IdPunto_cargo, b.IdPunto_cargo_grupo, b.IdUnidadMedida, a.IdEstado_cierre, 'OC# ' + d.codigo + '-' + CAST(b.IdOrdenCompra AS varchar(20)) + ' Fecha: ' + CONVERT(varchar, a.oc_fecha, 103) 
                  + ' Proveedor: ' + LTRIM(RTRIM(f.pe_nombreCompleto)) AS RefOC, g.IdUnidadMedida_Consumo, h.codigo AS CodSucDestino, h.Su_Descripcion AS SucursalDestino
FROM     dbo.com_ordencompra_local AS a INNER JOIN
                  dbo.com_ordencompra_local_det AS b ON a.IdEmpresa = b.IdEmpresa AND a.IdSucursal = b.IdSucursal AND a.IdOrdenCompra = b.IdOrdenCompra LEFT OUTER JOIN
                      (SELECT IdEmpresa_oc, IdSucursal_oc, IdOrdenCompra, Secuencia_oc, SUM(dm_cantidad_sinConversion) AS dm_cantidad
                       FROM      dbo.in_Ing_Egr_Inven_det AS d
                       WHERE   (IdOrdenCompra IS NOT NULL)
                       GROUP BY IdEmpresa_oc, IdSucursal_oc, IdOrdenCompra, Secuencia_oc) AS c ON b.IdEmpresa = c.IdEmpresa_oc AND b.IdSucursal = c.IdSucursal_oc AND b.IdOrdenCompra = c.IdOrdenCompra AND 
                  b.Secuencia = c.Secuencia_oc LEFT OUTER JOIN
                  dbo.tb_sucursal AS d ON b.IdEmpresa = d.IdEmpresa AND b.IdSucursal = d.IdSucursal LEFT OUTER JOIN
                  dbo.cp_proveedor AS e ON a.IdEmpresa = e.IdEmpresa AND a.IdProveedor = e.IdProveedor LEFT OUTER JOIN
                  dbo.tb_persona AS f ON e.IdPersona = f.IdPersona INNER JOIN
                  dbo.in_Producto AS g ON b.IdEmpresa = g.IdEmpresa AND b.IdProducto = g.IdProducto LEFT OUTER JOIN
                  dbo.tb_sucursal AS h ON b.IdEmpresa = h.IdEmpresa AND b.IdSucursalDestino = h.IdSucursal
WHERE  (a.Estado = 'A') AND (a.IdEstado_cierre <> 'CERR') AND (a.IdEstadoAprobacion_cat = 'APRO') AND (ROUND(b.do_Cantidad - ISNULL(c.dm_cantidad, 0), 2) > 0)