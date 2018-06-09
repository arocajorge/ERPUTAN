--**********************************************************************************************************************************************************************************
create view vwROL_Rpt017 as 
SELECT        dbo.ro_Comprobantes_Contables.IdEmpresa, dbo.ro_Comprobantes_Contables.IdTipoCbte, dbo.ro_Comprobantes_Contables.IdCbteCble, 
                         dbo.ro_Comprobantes_Contables.CodCtbteCble, dbo.ro_Comprobantes_Contables.IdPeriodo, dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo, 
                         dbo.ct_cbtecble_det.secuencia, dbo.ct_cbtecble_det.IdCtaCble, dbo.ct_cbtecble_det.dc_Valor, dbo.ct_plancta.pc_Cuenta, dbo.ct_cbtecble_det.dc_Observacion, 
                         dbo.ro_periodo.pe_FechaIni, dbo.ro_periodo.pe_FechaFin
FROM            dbo.ct_cbtecble INNER JOIN
                         dbo.ct_cbtecble_det ON dbo.ct_cbtecble.IdEmpresa = dbo.ct_cbtecble_det.IdEmpresa AND dbo.ct_cbtecble.IdTipoCbte = dbo.ct_cbtecble_det.IdTipoCbte AND 
                         dbo.ct_cbtecble.IdCbteCble = dbo.ct_cbtecble_det.IdCbteCble INNER JOIN
                         dbo.ro_Comprobantes_Contables ON dbo.ct_cbtecble.IdEmpresa = dbo.ro_Comprobantes_Contables.IdEmpresa AND 
                         dbo.ct_cbtecble.IdTipoCbte = dbo.ro_Comprobantes_Contables.IdTipoCbte AND dbo.ct_cbtecble.IdCbteCble = dbo.ro_Comprobantes_Contables.IdCbteCble AND 
                         dbo.ct_cbtecble.IdPeriodo = dbo.ro_Comprobantes_Contables.IdPeriodo INNER JOIN
                         dbo.ct_plancta ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_plancta.IdEmpresa AND dbo.ct_cbtecble_det.IdCtaCble = dbo.ct_plancta.IdCtaCble INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui ON dbo.ro_Comprobantes_Contables.IdEmpresa = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa AND 
                         dbo.ro_Comprobantes_Contables.IdPeriodo = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo INNER JOIN
                         dbo.ro_periodo ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_periodo.IdPeriodo