
create view  Fj_servindustrias.vwFAC_FJ_Rpt005 as 
SELECT        a.IdEmpresa, a.IdEmpleado, a.IdActivoFijo, a.IdTipoDepreciacion, a.CodActivoFijo, a.Af_Nombre, a.Af_ValorUnidad_Actu, a.Valor, a.Horas_Trabajada_x_Af, 
                         a.IdPeriodo, b.pe_nombreCompleto, b.hora_trabajada,A.Centro_costo




FROM						  (SELECT        af.IdEmpresa, ro_hist_em_x_af.IdEmpleado, af.IdActivoFijo, af.IdTipoDepreciacion, af.CodActivoFijo, af.Af_Nombre, af_unidad_act.Af_ValorUnidad_Actu, 
                         MAX(af_reg_uni.Valor) AS Valor, MAX(af_reg_uni.Valor) - af_unidad_act.Af_ValorUnidad_Actu AS Horas_Trabajada_x_Af, ro_hist_em_x_af.IdPeriodo, 
                         dbo.ct_centro_costo_sub_centro_costo.Centro_costo
FROM            Fj_servindustrias.ro_empleado_x_Activo_Fijo_Historico AS ro_hist_em_x_af INNER JOIN
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det AS af_reg_uni ON ro_hist_em_x_af.IdEmpresa = af_reg_uni.IdEmpresa AND 
                         ro_hist_em_x_af.IdPeriodo = af_reg_uni.IdPeriodo INNER JOIN
                         dbo.Af_Activo_fijo AS af ON af_reg_uni.IdEmpresa = af.IdEmpresa AND af_reg_uni.IdActivoFijo = af.IdActivoFijo INNER JOIN
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af AS af_unidad_act ON af.IdEmpresa = af_unidad_act.IdEmpresa AND 
                         af.IdActivoFijo = af_unidad_act.IdActivoFijo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON af.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         af.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo AND 
                         af.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa
GROUP BY af.IdEmpresa, ro_hist_em_x_af.IdEmpleado, af.IdActivoFijo, af.IdTipoDepreciacion, af.CodActivoFijo, af.Af_Nombre, af_unidad_act.Af_ValorUnidad_Actu, 
                         ro_hist_em_x_af.IdPeriodo, dbo.ct_centro_costo_sub_centro_costo.Centro_costo) AS a INNER JOIN


                             (SELECT        ro_nom_HE.IdEmpresa, ro_nom_HE.IdEmpleado, ro_nom_HE.IdNominaTipo, ro_nom_HE.IdPeriodo, ro_nom_HE.IdNominaTipoLiqui, 
                                                         ro_nom_HE.IdTurno, tb_perso.pe_nombreCompleto, SUM(ro_nom_HE.hora_trabajada) AS hora_trabajada
                               FROM            dbo.ro_nomina_x_horas_extras AS ro_nom_HE INNER JOIN
                                                         dbo.ro_empleado AS ro_e ON ro_nom_HE.IdEmpresa = ro_e.IdEmpresa AND ro_nom_HE.IdEmpleado = ro_e.IdEmpleado AND 
                                                         ro_nom_HE.IdEmpresa = ro_e.IdEmpresa AND ro_nom_HE.IdEmpleado = ro_e.IdEmpleado AND ro_nom_HE.IdEmpresa = ro_e.IdEmpresa AND 
                                                         ro_nom_HE.IdEmpleado = ro_e.IdEmpleado INNER JOIN
                                                         dbo.tb_persona AS tb_perso ON ro_e.IdPersona = tb_perso.IdPersona AND ro_e.IdPersona = tb_perso.IdPersona AND 
                                                         ro_e.IdPersona = tb_perso.IdPersona AND ro_e.IdPersona = tb_perso.IdPersona AND ro_e.IdPersona = tb_perso.IdPersona
                               GROUP BY ro_nom_HE.IdEmpresa, ro_nom_HE.IdEmpleado, ro_nom_HE.IdNominaTipo, ro_nom_HE.IdPeriodo, ro_nom_HE.IdNominaTipoLiqui, 
                                                         ro_nom_HE.IdTurno, tb_perso.pe_nombreCompleto) AS b
														  ON b.IdEmpresa = a.IdEmpresa AND b.IdPeriodo = a.IdPeriodo AND 
                         b.IdEmpleado = a.IdEmpleado