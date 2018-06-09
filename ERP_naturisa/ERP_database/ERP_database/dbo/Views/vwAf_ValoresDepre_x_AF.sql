CREATE VIEW [dbo].[vwAf_ValoresDepre_x_AF] AS
SELECT depreAf.IdEmpresa, depreAf.IdActivoFijo, depreAf.IdTipoDepreciacion,
MAX(depreAf.Valor_Depreciacion) AS Valor_Depreciacion , MAX(depreAf.Valor_Depre_Acum) AS Valor_Depre_Acum, MAX(depreAf.Valor_Importe) AS Valor_Importe
 FROM vwACTF_Rpt004 depreAf 
GROUP BY depreAf.IdEmpresa, depreAf.IdActivoFijo, depreAf.IdTipoDepreciacion