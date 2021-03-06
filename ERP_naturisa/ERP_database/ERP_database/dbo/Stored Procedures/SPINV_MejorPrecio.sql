﻿CREATE PROCEDURE [dbo].[SPINV_MejorPrecio]
(
@IdEmpresa int,
@IdProducto numeric
)
as
SELECT com_ordencompra_local_det.IdEmpresa,com_ordencompra_local_det.IdProducto, MIN(com_ordencompra_local_det.do_precioFinal) MejorPrecio
FROM     com_ordencompra_local INNER JOIN
                  com_ordencompra_local_det ON com_ordencompra_local.IdEmpresa = com_ordencompra_local_det.IdEmpresa AND com_ordencompra_local.IdSucursal = com_ordencompra_local_det.IdSucursal AND 
                  com_ordencompra_local.IdOrdenCompra = com_ordencompra_local_det.IdOrdenCompra INNER JOIN
                  in_Producto ON com_ordencompra_local_det.IdEmpresa = in_Producto.IdEmpresa AND com_ordencompra_local_det.IdProducto = in_Producto.IdProducto INNER JOIN
                  cp_proveedor ON com_ordencompra_local.IdEmpresa = cp_proveedor.IdEmpresa AND com_ordencompra_local.IdProveedor = cp_proveedor.IdProveedor INNER JOIN
                  tb_persona ON cp_proveedor.IdPersona = tb_persona.IdPersona inner join 
				  tb_sucursal on tb_sucursal.IdEmpresa = com_ordencompra_local_det.IdEmpresa
				  and tb_sucursal.IdSucursal = com_ordencompra_local_det.IdSucursal inner join
				  in_unidadmedida on com_ordencompra_local_det.IdUnidadMedida = in_unidadmedida.IdUnidadMedida
where com_ordencompra_local_det.IdEmpresa = @IdEmpresa and com_ordencompra_local_det.IdProducto = @IdProducto and com_ordencompra_local.Estado = 'A' and
com_ordencompra_local.oc_fecha >= dateadd(month,-3, cast(getdate() as date)) and exists(
select f.IdEmpresa from in_Ing_Egr_Inven_det as f inner join in_Ing_Egr_Inven as fc
on f.IdEmpresa = fc.IdEmpresa and f.IdSucursal = fc.IdSucursal and f.IdMovi_inven_tipo= fc.IdMovi_inven_tipo and f.IdNumMovi = fc.IdNumMovi
where com_ordencompra_local_det.IdEmpresa = f.IdEmpresa_oc
and com_ordencompra_local_det.IdSucursal = f.IdSucursal_oc
and com_ordencompra_local_det.IdOrdenCompra = f.IdOrdenCompra
and com_ordencompra_local_det.Secuencia = f.Secuencia_oc
and fc.cm_fecha >= dateadd(month,-3, cast(getdate() as date))
)
group by com_ordencompra_local_det.IdEmpresa,com_ordencompra_local_det.IdProducto