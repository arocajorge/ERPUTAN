--exec spINV_relaciones_no_parametrizadas 1, '2018/05/01', '2018/05/31'
CREATE PROCEDURE [dbo].[spINV_relaciones_no_parametrizadas](
@IdEmpresa int, 
@Fecha_ini datetime, 
@Fecha_fin datetime
)
AS
delete in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble where IdCtaCble is null

SELECT det.IdEmpresa, pro.IdCategoria,'['+pro.IdCategoria+'] '+ c.ca_Categoria ca_Categoria, 
pro.IdLinea, '['+cast(pro.IdLinea as varchar(10)) +'] '+c.nom_linea nom_linea,  
pro.IdGrupo, '['+cast(pro.IdGrupo as varchar(10))+'] '+c.nom_grupo nom_grupo, 
pro.IdSubGrupo, '['+cast(pro.IdSubGrupo as varchar(10))+'] '+c.nom_subgrupo nom_subgrupo, 
det.IdCentroCosto, '['+det.IdCentroCosto+'] '+cen.Centro_costo Centro_costo, 
det.IdCentroCosto_sub_centro_costo, '['+det.IdCentroCosto_sub_centro_costo+'] '+sub.Centro_costo AS NomSubcentro
FROM     dbo.in_movi_inve_detalle AS det LEFT OUTER JOIN
                  dbo.in_Producto AS pro ON det.IdEmpresa = pro.IdEmpresa AND det.IdProducto = pro.IdProducto LEFT OUTER JOIN
                  dbo.vwin_Cate_Lin_Grup_SubGrup AS c ON c.IdEmpresa = pro.IdEmpresa AND c.IdCategoria = pro.IdCategoria AND c.IdLinea = pro.IdLinea AND c.IdGrupo = pro.IdGrupo AND c.IdSubgrupo = pro.IdSubGrupo INNER JOIN
                  dbo.ct_centro_costo AS cen ON cen.IdEmpresa = det.IdEmpresa AND cen.IdCentroCosto = det.IdCentroCosto INNER JOIN
                  dbo.ct_centro_costo_sub_centro_costo AS sub ON sub.IdEmpresa = det.IdEmpresa AND sub.IdCentroCosto = det.IdCentroCosto AND sub.IdCentroCosto_sub_centro_costo = det.IdCentroCosto_sub_centro_costo INNER JOIN
                  dbo.in_movi_inve AS cab ON cab.IdEmpresa = det.IdEmpresa AND cab.IdSucursal = det.IdSucursal AND cab.IdMovi_inven_tipo = det.IdMovi_inven_tipo AND cab.IdNumMovi = det.IdNumMovi AND det.IdBodega = cab.IdBodega
where --det.dm_cantidad < 0 and 
det.IdEmpresa = @IdEmpresa and det.IdCentroCosto_sub_centro_costo is not null
and cab.cm_fecha between @Fecha_ini and @Fecha_fin
and not exists(
select f.IdEmpresa from in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble f
where f.IdEmpresa = det.IdEmpresa
and f.IdCategoria = pro.IdCategoria
and f.IdLinea = pro.IdLinea
and f.IdGrupo = pro.IdGrupo
and f.IdSubgrupo = pro.IdSubGrupo
and f.IdCentroCosto = det.IdCentroCosto
and f.IdSub_centro_costo = det.IdCentroCosto_sub_centro_costo
)
group by det.IdEmpresa, pro.IdCategoria, c.ca_Categoria, pro.IdLinea, c.nom_linea,  pro.IdGrupo, c.nom_grupo, pro.IdSubGrupo, c.nom_subgrupo, det.IdCentroCosto, cen.Centro_costo, det.IdCentroCosto_sub_centro_costo, sub.Centro_costo
order by det.IdEmpresa, pro.IdCategoria, pro.IdLinea, pro.IdGrupo, pro.IdSubGrupo, det.IdCentroCosto, det.IdCentroCosto_sub_centro_costo