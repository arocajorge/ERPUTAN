
create view [dbo].[vwCONTA_Rpt004]
as
SELECT        IdEmpresa, IdCtaCble, pc_Cuenta, IdCtaCblePadre, pc_Naturaleza, IdNivelCta, IdGrupoCble, IdTipoCtaCble, pc_Estado, pc_EsMovimiento, pc_es_flujo_efectivo, 
                         pc_clave_corta
FROM            dbo.ct_plancta