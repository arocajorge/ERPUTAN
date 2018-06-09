
CREATE VIEW [dbo].[vwACTF_Rpt003]
AS
SELECT        act.IdEmpresa, act.IdActivoFijo, act.IdSucursal, act.IdActijoFijoTipo, act.IdTipoDepreciacion, act.Af_Codigo_Barra, dep.nom_tipo_depreciacion, tip.Af_Descripcion, 
                         cat.Descripcion, suc.Su_Descripcion, act.Af_Nombre, act.IdDepartamento, mar.Descripcion AS Af_Marca, dis.Descripcion AS Af_Modelo, act.Af_NumSerie, 
                         col.Descripcion AS Af_Color, ubi.Descripcion AS Af_Ubicacion, emp.nom_encargado AS NomCompleto, act.Af_observacion, act.Af_NumPlaca, act.Af_Anio_fabrica, 
                         act.Af_DescripcionCorta, act.Af_fecha_compra, act.Af_costo_compra, act.Af_Costo_historico, act.Af_Vida_Util, act.Af_Meses_depreciar, 
                         ISNULL(act.Af_ValorSalvamento, 0) AS Af_ValorSalvamento, ISNULL(act.Af_ValorResidual, 0) AS Af_ValorResidual, act.Estado_Proceso, per.IdPeriodoDeprec, 
                         per.Descripcion AS Descri_Periodo, ISNULL(vaDepre.Valor_Depreciacion, 0) AS Valor_Depreciacion, ISNULL(vaDepre.Valor_Depre_Acum, 0) AS Valor_Depre_Acum, 
                         ISNULL(vaDepre.Valor_Importe, 0) AS Valor_Importe
FROM            dbo.Af_Activo_fijo AS act INNER JOIN
                         dbo.Af_Activo_fijo_tipo AS tip ON tip.IdEmpresa = act.IdEmpresa AND tip.IdActijoFijoTipo = act.IdActijoFijoTipo INNER JOIN
                         dbo.Af_Tipo_Depreciacion AS dep ON dep.IdTipoDepreciacion = act.IdTipoDepreciacion INNER JOIN
                         dbo.tb_sucursal AS suc ON suc.IdEmpresa = act.IdEmpresa AND suc.IdSucursal = act.IdSucursal INNER JOIN
                         dbo.Af_Catalogo AS cat ON cat.IdCatalogo = act.Estado_Proceso AND cat.IdTipoCatalogo = 'TIP_ESTADO_AF' INNER JOIN
                         dbo.Af_PeriodoDepreciacion AS per ON act.IdPeriodoDeprec = per.IdPeriodoDeprec INNER JOIN
                         dbo.Af_Catalogo AS mar ON mar.IdCatalogo = act.IdCatalogo_Marca INNER JOIN
                         dbo.Af_Catalogo AS col ON col.IdCatalogo = act.IdCatalogo_Color INNER JOIN
                         dbo.Af_Catalogo AS ubi ON ubi.IdCatalogo = act.IdTipoCatalogo_Ubicacion INNER JOIN
                         dbo.Af_Catalogo AS dis ON dis.IdCatalogo = act.IdCatalogo_Modelo LEFT OUTER JOIN
                         dbo.Af_Encargado AS emp ON emp.IdEmpresa = act.IdEmpresa AND emp.IdEncargado = act.IdEncargado LEFT OUTER JOIN
                         dbo.vwAf_ValoresDepre_x_AF AS vaDepre ON vaDepre.IdEmpresa = act.IdEmpresa AND vaDepre.IdActivoFijo = act.IdActivoFijo AND 
                         vaDepre.IdTipoDepreciacion = act.IdTipoDepreciacion