CREATE PROCEDURE [mobileSCI].[sp_oc_x_aprobar]
AS
BEGIN

DELETE [mobileSCI].[tbl_oc_x_aprobar]

INSERT INTO [mobileSCI].[tbl_oc_x_aprobar]
           ([IdEmpresa]
           ,[IdSucursal]
           ,[IdOrdenCompra]
           ,[Secuencia]
           ,[IdProducto]
           ,[IdUnidadMedida]
           ,[IdProveedor]
           ,[cant_oc]
           ,[cant_in]
           ,[saldo]
           ,[pr_descripcion]
           ,[pr_codigo]
           ,[Descripcion]
           ,[pe_nombreCompleto]
           ,[oc_fecha]
           ,[oc_observacion]
           ,[IdUnidadMedida_Consumo])
		   
select det.IdEmpresa, det.IdSucursal, det.IdOrdenCompra, det.Secuencia,
det.IdProducto, det.IdUnidadMedida, cab.IdProveedor, det.do_Cantidad, 0, 0,
pro.pr_descripcion,pro.pr_codigo, uni.Descripcion, per.pe_nombreCompleto, cab.oc_fecha,
cab.oc_observacion, pro.IdUnidadMedida_Consumo
from com_ordencompra_local_det det
inner join com_ordencompra_local cab
on cab.IdEmpresa = det.IdEmpresa and cab.IdSucursal = det.IdSucursal
and cab.IdOrdenCompra = det.IdOrdenCompra inner join in_Producto as pro
on pro.IdEmpresa = det.IdEmpresa and pro.IdProducto = det.IdProducto
inner join in_UnidadMedida as uni on uni.IdUnidadMedida = det.IdUnidadMedida
inner join cp_proveedor as pr on pr.IdEmpresa = cab.IdEmpresa and pr.IdProveedor = cab.IdProveedor
inner join tb_persona as per on per.IdPersona = pr.IdPersona
inner join mobileSCI.tbl_producto as bod on bod.IdEmpresa = det.IdEmpresa and bod.IdProducto = det.IdProducto
where cab.IdEstado_cierre <> 'CERR' AND CAB.oc_fecha BETWEEN DATEADD(MONTH,-3, GETDATE()) AND GETDATE()

update [mobileSCI].[tbl_oc_x_aprobar] set cant_in = A.cantidad
from(
SELECT IdEmpresa_oc, IdSucursal_oc, IdOrdenCompra, Secuencia_oc, SUM(cantidad) cantidad
FROM(
select IdEmpresa_oc, IdSucursal_oc, IdOrdenCompra, Secuencia_oc, sum(dm_cantidad_sinConversion) cantidad
from in_Ing_Egr_Inven_det det inner join in_Ing_Egr_Inven cab
on cab.IdEmpresa = det.IdEmpresa and cab.IdSucursal = det.IdSucursal
and cab.IdMovi_inven_tipo = det.IdMovi_inven_tipo and cab.IdNumMovi = det.IdNumMovi
inner join mobileSCI.tbl_producto as bod on bod.IdEmpresa = det.IdEmpresa and bod.IdProducto = det.IdProducto
where det.IdEmpresa_oc is not null and cab.cm_fecha BETWEEN DATEADD(MONTH,-3, GETDATE()) AND GETDATE()
group by IdEmpresa_oc, IdSucursal_oc, IdOrdenCompra, Secuencia_oc
UNION ALL
select DET.IdEmpresa_oc, det.IdSucursal_oc, det.IdOrdenCompra, det.secuencia_oc, SUM(DET.cantidad)
from mobileSCI.tbl_movimientos_det as det
where det.Aprobado = 0 and det.Estado = 'A' AND DET.IdOrdenCompra IS NOT NULL
GROUP BY DET.IdEmpresa_oc, det.IdSucursal_oc, det.IdOrdenCompra, det.secuencia_oc
) OC
GROUP BY IdEmpresa_oc, IdSucursal_oc, IdOrdenCompra, Secuencia_oc
) A
where [mobileSCI].[tbl_oc_x_aprobar].IdEmpresa = a.IdEmpresa_oc
and [mobileSCI].[tbl_oc_x_aprobar].IdSucursal = a.IdSucursal_oc
and [mobileSCI].[tbl_oc_x_aprobar].IdOrdenCompra = a.IdOrdenCompra
and [mobileSCI].[tbl_oc_x_aprobar].Secuencia = a.Secuencia_oc

update [mobileSCI].[tbl_oc_x_aprobar] set saldo = cant_oc - cant_in

delete [mobileSCI].[tbl_oc_x_aprobar] where saldo <= 0

select * from [mobileSCI].[tbl_oc_x_aprobar]

END