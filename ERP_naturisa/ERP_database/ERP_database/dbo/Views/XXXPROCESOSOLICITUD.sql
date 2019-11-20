CREATE VIEW [dbo].[XXXPROCESOSOLICITUD]
AS
SELECT d.IdEmpresa, d.IdOrdenPedido, d.Secuencia, d.IdProducto, ISNULL(p.pr_descripcion, d.pr_descripcion) AS Pr_descripcion, c.op_Fecha, cant.Nombre IdUsuarioCantidad, CAST(d.FechaCantidad AS DATE) AS FechaCantidad, 
                  ISNULL(dbo.com_comprador.Descripcion, om.Comprador) AS Comprador, cd.IdCotizacion, CAST(cc.cp_Fecha AS DATE) AS cp_Fecha, jc.Nombre IdUsuarioJC, CAST(cc.FechaJC AS DATE) AS FechaJC, ga.Nombre IdUsuarioAprobacion, 
                  CAST(c.FechaAprobacion AS DATE) AS FechaAprobacion, oc.IdOrdenCompra, oc.oc_fecha, 
                  CASE WHEN d .opd_EstadoProceso = 'P' THEN 'PENDIENTE' WHEN d .opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' WHEN d .opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' WHEN d .opd_EstadoProceso = 'AJC' THEN
                   'PRECIO APROBADO' WHEN d .opd_EstadoProceso = 'C' THEN 'OC GENERADA' WHEN d .opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' WHEN d .opd_EstadoProceso = 'AC' THEN 'COTIZADO' WHEN d .opd_EstadoProceso
                   = 'RGA' THEN 'COTIZACION RECHAZADA' END AS EstadoDetalle, dbo.com_departamento.nom_departamento, f.fa_Descripcion AS Familia, CASE WHEN c.EsCompraUrgente = 1 THEN 'SI' ELSE 'NO' END AS EsCompraUrgente
FROM     dbo.com_ordencompra_local AS oc RIGHT OUTER JOIN
                  dbo.com_CotizacionPedido AS cc INNER JOIN
                  dbo.com_CotizacionPedidoDet AS cd ON cc.IdEmpresa = cd.IdEmpresa AND cc.IdCotizacion = cd.IdCotizacion LEFT OUTER JOIN
                  dbo.com_comprador ON cc.IdEmpresa = dbo.com_comprador.IdEmpresa AND cc.IdComprador = dbo.com_comprador.IdComprador ON oc.IdEmpresa = cc.IdEmpresa AND oc.IdSucursal = cc.IdSucursal AND 
                  oc.IdOrdenCompra = cc.oc_IdOrdenCompra RIGHT OUTER JOIN
                  dbo.in_Producto AS p RIGHT OUTER JOIN
                  dbo.com_OrdenPedidoDet AS d INNER JOIN
                  dbo.com_OrdenPedido AS c ON d.IdEmpresa = c.IdEmpresa AND d.IdOrdenPedido = c.IdOrdenPedido INNER JOIN
                  dbo.com_departamento ON c.IdEmpresa = dbo.com_departamento.IdEmpresa AND c.IdDepartamento = dbo.com_departamento.IdDepartamento ON p.IdEmpresa = d.IdEmpresa AND p.IdProducto = d.IdProducto ON 
                  cd.opd_IdEmpresa = d.IdEmpresa AND cd.opd_IdOrdenPedido = d.IdOrdenPedido AND cd.opd_Secuencia = d.Secuencia LEFT OUTER JOIN
                  dbo.in_Familia AS f ON f.IdEmpresa = p.IdEmpresa AND f.IdFamilia = p.IdFamilia LEFT OUTER JOIN
                      (SELECT a.IdEmpresa, a.IdOrdenPedido, a.Secuencia, MAX(z.Descripcion) AS Comprador
                       FROM      dbo.com_OrdenPedidoDet AS a INNER JOIN
                                         dbo.in_Producto AS b ON a.IdEmpresa = b.IdEmpresa AND a.IdProducto = b.IdProducto INNER JOIN
                                         dbo.com_comprador_familia AS c ON b.IdEmpresa = c.IdEmpresa AND b.IdFamilia = c.IdFamilia INNER JOIN
                                         dbo.com_comprador AS z ON c.IdEmpresa = z.IdEmpresa AND c.IdComprador = z.IdComprador
                       WHERE   (LOWER(z.Descripcion) NOT IN ('no definido', 'marjorie ortiz'))
                       GROUP BY a.IdEmpresa, a.IdOrdenPedido, a.Secuencia) AS om ON d.IdEmpresa = om.IdEmpresa AND d.IdOrdenPedido = om.IdOrdenPedido AND d.Secuencia = om.Secuencia
					   LEFT JOIN SEG_USUARIO AS cant on cant.IdUsuario = d.IdUsuarioCantidad
					   LEFT JOIN SEG_USUARIO AS jc on jc.IdUsuario = CC.IdUsuarioJC
					   LEFT JOIN SEG_USUARIO AS ga on ga.IdUsuario = c.IdUsuarioAprobacion
