
CREATE VIEW [dbo].[vwACTF_Rpt007]
AS
SELECT        af.IdEmpresa, af.IdVtaActivo, af.Cod_VtaActivo, act.IdActivoFijo, act.Af_Nombre, emp.nom_encargado AS NomCompleto, af.ValorActivo, af.Valor_Tot_Bajas, 
                         af.Valor_Tot_Mejora, af.Valor_Depre_Acu, af.Valor_Neto, af.Valor_Venta, af.Valor_Perdi_Gana, af.NumComprobante, af.Concepto_Vta, af.Estado, af.Fecha_Venta
FROM            dbo.Af_Venta_Activo AS af INNER JOIN
                         dbo.Af_Activo_fijo AS act ON af.IdEmpresa = act.IdEmpresa AND af.IdActivoFijo = act.IdActivoFijo LEFT OUTER JOIN
                         dbo.Af_Encargado AS emp ON emp.IdEmpresa = act.IdEmpresa AND emp.IdEncargado = act.IdEncargado