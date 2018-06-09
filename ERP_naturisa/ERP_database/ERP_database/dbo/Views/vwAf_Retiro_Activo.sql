

CREATE VIEW [dbo].[vwAf_Retiro_Activo]
AS
SELECT        af.IdEmpresa, af.IdRetiroActivo, af.Cod_Ret_Activo, act.IdActivoFijo, act.Af_Nombre, emp.nom_encargado AS NomCompleto, af.ValorActivo, af.Valor_Tot_Bajas, 
                         af.Valor_Tot_Mejora, af.Valor_Depre_Acu, af.Valor_Neto, af.NumComprobante, af.Concepto_Retiro, af.Estado, af.Fecha_Retiro
FROM            dbo.Af_Retiro_Activo AS af INNER JOIN
                         dbo.Af_Activo_fijo AS act ON af.IdEmpresa = act.IdEmpresa AND af.IdActivoFijo = act.IdActivoFijo LEFT OUTER JOIN
                         dbo.Af_Encargado AS emp ON emp.IdEmpresa = act.IdEmpresa AND emp.IdEncargado = act.IdEncargado