--exec SPINV_Stock 1,1644
CREATE PROCEDURE SPINV_Stock
(
@IdEmpresa int,
@IdProducto decimal
)
as
SELECT d.idempresa,d.idsucursal,d.idbodega,d.idproducto,s.Su_Descripcion, b.bo_Descripcion, round(sum(d.dm_Cantidad),2) Stock
FROM in_producto as p inner join 
in_movi_inve_detalle as d on p.idempresa = d.idempresa and p.idproducto = d.idproducto left join 
tb_bodega as b on d.IdEmpresa = b.IdEmpresa and d.IdSucursal = b.IdSucursal and d.IdBodega = b.IdBodega left join
tb_sucursal as s on b.idempresa = s.idempresa and b.idsucursal = s.idsucursal
where d.idempresa = @IdEmpresa and d.IdProducto = @IdProducto
group by d.idempresa,d.idsucursal,d.idbodega,d.idproducto,s.Su_Descripcion, b.bo_Descripcion
having round(sum(d.dm_Cantidad),2) != 0