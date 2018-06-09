create VIEW [dbo].[vwin_movi_inve_detalle_x_item_ingresos]
as
SELECT        in_Ing_Egr_Inven_det.IdEmpresa_oc, in_Ing_Egr_Inven_det.IdSucursal_oc, in_Ing_Egr_Inven_det.IdOrdenCompra, in_Ing_Egr_Inven_det.Secuencia_oc, 
                         in_Ing_Egr_Inven_det.IdProducto, in_Ing_Egr_Inven_det.dm_cantidad, in_Ing_Egr_Inven_det.dm_precio, com_ordencompra_local.IdProveedor, 
                         com_ordencompra_local.oc_NumDocumento, in_movi_inve_detalle_x_item.codigo_reg, in_movi_inve_detalle_x_item.cantidad, 
                         in_movi_inve_detalle_x_item.IdEmpresa AS IdEmpresa_ing, in_movi_inve_detalle_x_item.IdSucursal AS IdSucursal_ing, 
                         in_movi_inve_detalle_x_item.IdBodega AS IdBodega_ing, in_movi_inve_detalle_x_item.IdMovi_inven_tipo AS IdMovi_inven_tipo_ing, 
                         in_movi_inve_detalle_x_item.IdNumMovi AS IdNumMovi_ing, in_movi_inve_detalle_x_item.Secuencia AS Secuencia_ing, com_ordencompra_local.oc_fecha
FROM            in_movi_inve_detalle INNER JOIN
                         in_Ing_Egr_Inven INNER JOIN
                         in_Ing_Egr_Inven_det ON in_Ing_Egr_Inven.IdEmpresa = in_Ing_Egr_Inven_det.IdEmpresa AND in_Ing_Egr_Inven.IdSucursal = in_Ing_Egr_Inven_det.IdSucursal AND
                          in_Ing_Egr_Inven.IdMovi_inven_tipo = in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND in_Ing_Egr_Inven.IdNumMovi = in_Ing_Egr_Inven_det.IdNumMovi ON 
                         in_movi_inve_detalle.IdEmpresa = in_Ing_Egr_Inven_det.IdEmpresa_inv AND in_movi_inve_detalle.IdSucursal = in_Ing_Egr_Inven_det.IdSucursal_inv AND 
                         in_movi_inve_detalle.IdBodega = in_Ing_Egr_Inven_det.IdBodega_inv AND 
                         in_movi_inve_detalle.IdMovi_inven_tipo = in_Ing_Egr_Inven_det.IdMovi_inven_tipo_inv AND 
                         in_movi_inve_detalle.IdNumMovi = in_Ing_Egr_Inven_det.IdNumMovi_inv AND in_movi_inve_detalle.Secuencia = in_Ing_Egr_Inven_det.secuencia_inv INNER JOIN
                         in_movi_inve_detalle_x_item ON in_movi_inve_detalle.IdEmpresa = in_movi_inve_detalle_x_item.IdEmpresa AND 
                         in_movi_inve_detalle.IdSucursal = in_movi_inve_detalle_x_item.IdSucursal AND in_movi_inve_detalle.IdBodega = in_movi_inve_detalle_x_item.IdBodega AND 
                         in_movi_inve_detalle.IdMovi_inven_tipo = in_movi_inve_detalle_x_item.IdMovi_inven_tipo AND 
                         in_movi_inve_detalle.IdNumMovi = in_movi_inve_detalle_x_item.IdNumMovi AND 
                         in_movi_inve_detalle.Secuencia = in_movi_inve_detalle_x_item.Secuencia LEFT OUTER JOIN
                         com_ordencompra_local INNER JOIN
                         com_ordencompra_local_det ON com_ordencompra_local.IdEmpresa = com_ordencompra_local_det.IdEmpresa AND 
                         com_ordencompra_local.IdSucursal = com_ordencompra_local_det.IdSucursal AND 
                         com_ordencompra_local.IdOrdenCompra = com_ordencompra_local_det.IdOrdenCompra ON 
                         in_Ing_Egr_Inven_det.IdEmpresa_oc = com_ordencompra_local_det.IdEmpresa AND 
                         in_Ing_Egr_Inven_det.IdSucursal_oc = com_ordencompra_local_det.IdSucursal AND 
                         in_Ing_Egr_Inven_det.IdOrdenCompra = com_ordencompra_local_det.IdOrdenCompra AND 
                         in_Ing_Egr_Inven_det.Secuencia_oc = com_ordencompra_local_det.Secuencia
WHERE        (in_movi_inve_detalle_x_item.cantidad > 0)