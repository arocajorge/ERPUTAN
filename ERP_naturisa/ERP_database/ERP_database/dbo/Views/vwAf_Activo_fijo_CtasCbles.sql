CREATE view [dbo].[vwAf_Activo_fijo_CtasCbles]
as
SELECT        dbo.Af_Activo_fijo_CtasCbles.IdEmpresa, dbo.Af_Activo_fijo_CtasCbles.IdActivoFijo, dbo.Af_Activo_fijo_CtasCbles.IdTipoCuenta, 
                         dbo.Af_Activo_fijo_CtasCbles.Secuencia, dbo.Af_Activo_fijo_CtasCbles.porc_distribucion, dbo.Af_Activo_fijo_CtasCbles.IdCtaCble, 
                         dbo.Af_Activo_fijo_CtasCbles.IdCentroCosto, dbo.Af_Activo_fijo_CtasCbles.Observacion, 0 IdActijoFijoTipo
FROM            dbo.Af_Activo_fijo_CtasCbles INNER JOIN
                         dbo.Af_Parametros ON dbo.Af_Activo_fijo_CtasCbles.IdEmpresa = dbo.Af_Parametros.IdEmpresa
where dbo.Af_Parametros.FormaContabiliza = 'Por_Activo'
UNION
SELECT        Af_Activo_fijo.IdEmpresa, Af_Activo_fijo.IdActivoFijo, Af_Activo_fijo_CtasCbles_Tipo.IdTipoCuenta, ROW_NUMBER() OVER (ORDER BY Af_Activo_fijo.IdEmpresa DESC)
 Secuencia, 100, NULL, NULL, '', Af_Activo_fijo.IdActijoFijoTipo
FROM            Af_Activo_fijo_CtasCbles_Tipo CROSS JOIN
                         Af_Activo_fijo INNER JOIN
                         dbo.Af_Parametros ON dbo.Af_Activo_fijo.IdEmpresa = dbo.Af_Parametros.IdEmpresa
WHERE        NOT EXISTS
                             (SELECT        A.IdEmpresa
                               FROM            Af_Activo_fijo_CtasCbles A
                               WHERE        A.IdEmpresa = Af_Activo_fijo.IdEmpresa AND A.IdActivoFijo = Af_Activo_fijo.IdActivoFijo AND 
                                                         A.IdTipoCuenta = Af_Activo_fijo_CtasCbles_Tipo.IdTipoCuenta)
														 and dbo.Af_Parametros.FormaContabiliza = 'Por_Activo'
union
SELECT        dbo.Af_Activo_fijo.IdEmpresa, dbo.Af_Activo_fijo.IdActivoFijo, dbo.Af_Activo_fijo_CtasCbles_Tipo.IdTipoCuenta, 
                         CASE WHEN dbo.Af_Activo_fijo_CtasCbles_Tipo.IdTipoCuenta = 'CTA_ACTIVO' THEN 1 WHEN .Af_Activo_fijo_CtasCbles_Tipo.IdTipoCuenta = 'CTA_DEPRE_ACUM' THEN
                          2 ELSE 3 END AS Secuencia, 100 AS Expr1, 
                         CASE WHEN dbo.Af_Activo_fijo_CtasCbles_Tipo.IdTipoCuenta = 'CTA_ACTIVO' THEN dbo.Af_Activo_fijo_tipo.IdCtaCble_Activo WHEN dbo.Af_Activo_fijo_CtasCbles_Tipo.IdTipoCuenta
                          = 'CTA_DEPRE_ACUM' THEN dbo.Af_Activo_fijo_tipo.IdCtaCble_Dep_Acum ELSE dbo.Af_Activo_fijo_tipo.IdCtaCble_Gastos_Depre END AS IdCtaCble, 
                         dbo.Af_Activo_fijo.IdCentroCosto, '' AS Observacion, Af_Activo_fijo.IdActijoFijoTipo
FROM            dbo.Af_Activo_fijo_tipo INNER JOIN
                         dbo.Af_Activo_fijo ON dbo.Af_Activo_fijo_tipo.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa AND 
                         dbo.Af_Activo_fijo_tipo.IdActijoFijoTipo = dbo.Af_Activo_fijo.IdActijoFijoTipo INNER JOIN
                         dbo.Af_Parametros ON dbo.Af_Activo_fijo_tipo.IdEmpresa = dbo.Af_Parametros.IdEmpresa CROSS JOIN
                         dbo.Af_Activo_fijo_CtasCbles_Tipo
where dbo.Af_Parametros.FormaContabiliza = 'Por_Tipo_CtaCble'