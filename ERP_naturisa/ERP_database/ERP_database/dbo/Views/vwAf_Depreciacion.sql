CREATE VIEW [dbo].[vwAf_Depreciacion] AS 
SELECT        depre.IdEmpresa, depre.IdDepreciacion, depre.IdTipoDepreciacion, depre.Cod_Depreciacion, depre.IdPeriodo, depre.Descripcion, depre.Fecha_Depreciacion, 
                         depre.IdUsuario, tipo.nom_tipo_depreciacion, tipo.cod_tipo_depreciacion, sum(depre_Det.Valor_Depreciacion) AS Valor_Depreciacion , 
                         sum(depre_Det.Valor_Depre_Acum) as Valor_Depre_Acum, sum(depre_Det.Valor_Importe) as Valor_Importe, depre.Estado
FROM            dbo.Af_Depreciacion AS depre INNER JOIN
                         dbo.Af_Depreciacion_Det AS depre_Det ON depre.IdEmpresa = depre_Det.IdEmpresa AND depre.IdDepreciacion = depre_Det.IdDepreciacion AND 
                         depre.IdTipoDepreciacion = depre_Det.IdTipoDepreciacion INNER JOIN
                         dbo.Af_Tipo_Depreciacion AS tipo ON tipo.IdTipoDepreciacion = depre.IdTipoDepreciacion 
GROUP BY depre.IdEmpresa, depre.IdDepreciacion, depre.IdTipoDepreciacion, depre.Cod_Depreciacion, depre.IdPeriodo, depre.Descripcion, depre.Fecha_Depreciacion, 
                         depre.IdUsuario, tipo.nom_tipo_depreciacion, tipo.cod_tipo_depreciacion, depre.Estado