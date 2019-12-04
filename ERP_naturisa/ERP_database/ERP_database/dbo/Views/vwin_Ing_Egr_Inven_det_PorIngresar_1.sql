CREATE VIEW vwin_Ing_Egr_Inven_det_PorIngresar
AS
select b.IdEmpresa,b.IdSucursal, b.IdOrdenCompra, b.Secuencia, d.codigo+'-'+cast(b.IdOrdenCompra as varchar(20)) oc_NumDocumento, d.Su_Descripcion, a.IdProveedor, f.pe_nombreCompleto,
a.oc_fecha, a.oc_observacion, b.IdProducto, g.pr_codigo, g.pr_descripcion, b.do_precioFinal, b.do_Cantidad, isnull(c.dm_cantidad,0) as CantidadIngresada, b.do_Cantidad - isnull(c.dm_cantidad,0) as Saldo,
b.IdCentroCosto, b.IdCentroCosto_sub_centro_costo, b.IdPunto_cargo, b.IdPunto_cargo_grupo, b.IdUnidadMedida, a.IdEstado_cierre,'OC# '+d.codigo+'-'+cast(b.IdOrdenCompra as varchar(20))+' Fecha: '+convert(varchar, a.oc_fecha, 103)+' Proveedor: '+ltrim(rtrim(f.pe_nombreCompleto)) as RefOC,
g.IdUnidadMedida_Consumo, h.codigo as CodSucDestino, h.Su_Descripcion as SucursalDestino
from com_ordencompra_local as a inner join
com_ordencompra_local_det as b on a.IdEmpresa = b.IdEmpresa and a.IdSucursal = b.IdSucursal and a.IdOrdenCompra = b.IdOrdenCompra LEFT JOIN
(
	SELECT d.IdEmpresa_oc, d.IdSucursal_oc, d.IdOrdenCompra, d.Secuencia_oc, sum(d.dm_cantidad) dm_cantidad
	FROM in_Ing_Egr_Inven_det AS d
	where d.IdOrdenCompra is not null
	group by d.IdEmpresa_oc, d.IdSucursal_oc, d.IdOrdenCompra, d.Secuencia_oc
) as c on b.IdEmpresa = c.IdEmpresa_oc and b.IdSucursal = c.IdSucursal_oc and b.IdOrdenCompra = c.IdOrdenCompra and b.Secuencia = c.Secuencia_oc left join
tb_sucursal as d on b.IdEmpresa = d.IdEmpresa and b.IdSucursal = d.IdSucursal left join
cp_proveedor as e on a.IdEmpresa = e.IdEmpresa and a.IdProveedor = e.IdProveedor left join
tb_persona as f on e.IdPersona = f.IdPersona inner join
in_Producto as g on b.IdEmpresa = g.IdEmpresa and b.IdProducto = g.IdProducto left join
tb_sucursal as h on b.IdEmpresa = h.IdEmpresa and b.IdSucursalDestino = h.IdSucursal
where a.Estado = 'A' AND A.IdEstado_cierre <> 'CERR' AND A.IdEstadoAprobacion_cat = 'APRO' and round(b.do_Cantidad - isnull(c.dm_cantidad,0),2) > 0