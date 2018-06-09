CREATE VIEW [Fj_servindustrias].[vwaf_Activo_fijo_x_Af_Activo_fijo]
	AS 
	SELECT        Af_Cabezal.IdEmpresa AS IdEmpresa_Cabezal, Af_Cabezal.IdActivoFijo AS IdActivoFijo_Cabezal, Af_Cabezal.CodActivoFijo AS CodActivoFijo_Cabezal, 
                         Af_Cabezal.Af_Nombre AS Af_Nombre_Cabezal, Af_Cabezal.Af_fecha_compra AS Af_fecha_compra_Cabezal, 
                         Af_Cabezal.Af_costo_compra AS Af_costo_compra_Cabezal, Af_Cabezal.IdEmpresa_oc AS IdEmpresa_oc_Cabezal, 
                         Af_Cabezal.IdSucursal_oc AS IdSucursal_oc_Cabezal, Af_Cabezal.IdOrdenCompra AS IdOrdenCompra_Cabezal, 
                         Af_Cabezal.Secuencia_oc AS Secuencia_oc_Cabezal, dbo.tb_persona.pe_nombreCompleto AS Proveedor, dbo.cp_orden_giro.co_serie, 
                         dbo.cp_orden_giro.co_factura, Af_Cabezal.Af_ValorSalvamento AS Af_ValorSalvamento_Cab, Af_Carrocerias.Af_costo_compra AS Af_costo_compra_Carroseria, 
                         Af_Carrocerias.Es_carroceria, Af_Carrocerias.Af_ValorSalvamento AS Af_ValorSalvamento_Carroseria, Af_Carrocerias.IdActivoFijo AS IdActivoFijo_Carroceria
FROM            dbo.tb_persona INNER JOIN
                         dbo.cp_proveedor ON dbo.tb_persona.IdPersona = dbo.cp_proveedor.IdPersona RIGHT OUTER JOIN
                         dbo.Af_Activo_fijo_x_Af_Activo_fijo INNER JOIN
                         dbo.Af_Activo_fijo AS Af_Carrocerias ON dbo.Af_Activo_fijo_x_Af_Activo_fijo.IdEmpresa = Af_Carrocerias.IdEmpresa AND 
                         dbo.Af_Activo_fijo_x_Af_Activo_fijo.IdActivoFijo_hijo = Af_Carrocerias.IdActivoFijo INNER JOIN
                         dbo.Af_Activo_fijo AS Af_Cabezal ON dbo.Af_Activo_fijo_x_Af_Activo_fijo.IdEmpresa = Af_Cabezal.IdEmpresa AND 
                         dbo.Af_Activo_fijo_x_Af_Activo_fijo.IdActivoFijo_padre = Af_Cabezal.IdActivoFijo INNER JOIN
                         dbo.Af_Activo_fijo_Categoria ON Af_Cabezal.IdEmpresa = dbo.Af_Activo_fijo_Categoria.IdEmpresa AND 
                         Af_Cabezal.IdCategoriaAF = dbo.Af_Activo_fijo_Categoria.IdCategoriaAF ON dbo.cp_proveedor.IdProveedor = Af_Cabezal.IdProveedor AND 
                         dbo.cp_proveedor.IdEmpresa = Af_Cabezal.IdEmpresa AND dbo.cp_proveedor.IdProveedor = Af_Carrocerias.IdProveedor AND 
                         dbo.cp_proveedor.IdEmpresa = Af_Carrocerias.IdEmpresa LEFT OUTER JOIN
                         dbo.cp_orden_giro_x_com_ordencompra_local_det INNER JOIN
                         dbo.cp_orden_giro ON dbo.cp_orden_giro_x_com_ordencompra_local_det.IdEmpresa_Ogiro = dbo.cp_orden_giro.IdEmpresa AND 
                         dbo.cp_orden_giro_x_com_ordencompra_local_det.IdCbteCble_Ogiro = dbo.cp_orden_giro.IdCbteCble_Ogiro AND 
                         dbo.cp_orden_giro_x_com_ordencompra_local_det.IdTipoCbte_Ogiro = dbo.cp_orden_giro.IdTipoCbte_Ogiro ON 
                         Af_Cabezal.IdEmpresa_oc = dbo.cp_orden_giro_x_com_ordencompra_local_det.IdEmpresa_OC AND 
                         Af_Cabezal.IdSucursal_oc = dbo.cp_orden_giro_x_com_ordencompra_local_det.IdSucursal_OC AND 
                         Af_Cabezal.IdOrdenCompra = dbo.cp_orden_giro_x_com_ordencompra_local_det.IdOrdenCompra AND 
                         Af_Cabezal.Secuencia_oc = dbo.cp_orden_giro_x_com_ordencompra_local_det.Secuencia_OC