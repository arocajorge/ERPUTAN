

create  view Fj_servindustrias.vwfa_Pre_Facturacion_Conciliacion_horas_No_facturadas as 
SELECT        Unidades_Facturadas.IdEmpresa, Unidades_Facturadas.IdPreFacturacion, Af.IdActivoFijo, Unidades_Facturadas.IdPeriodo,( MAX(UnidadesRegistradas.Valor)-fa_registro_unidades_x_equipo_det_ini_x_Af.Af_ValorUnidad_Actu) 
                         AS Num_horas_registradas, max(Unidades_Facturadas.Cantidad) AS Num_horas_facturadas, Af.Af_Nombre, dbo.ct_periodo.pe_FechaIni, 
                         dbo.ct_periodo.pe_FechaFin, max(Unidades_Facturadas.Cantidad) -( MAX(UnidadesRegistradas.Valor)-fa_registro_unidades_x_equipo_det_ini_x_Af.Af_ValorUnidad_Actu) AS Horas_no_Facturadas, 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdUnidadFact_cat, 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.Af_ValorUnidad_Actu
FROM            Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas AS Unidades_Facturadas INNER JOIN
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det AS UnidadesRegistradas ON Unidades_Facturadas.IdEmpresa = UnidadesRegistradas.IdEmpresa AND 
                         Unidades_Facturadas.IdPeriodo = UnidadesRegistradas.IdPeriodo INNER JOIN
                         dbo.Af_Activo_fijo AS Af ON UnidadesRegistradas.IdEmpresa = Af.IdEmpresa AND UnidadesRegistradas.IdActivoFijo = Af.IdActivoFijo INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion ON Unidades_Facturadas.IdEmpresa = Fj_servindustrias.fa_pre_facturacion.IdEmpresa AND 
                         Unidades_Facturadas.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion AND 
                         Unidades_Facturadas.IdPeriodo = Fj_servindustrias.fa_pre_facturacion.IdPeriodo INNER JOIN
                         dbo.ct_periodo ON Fj_servindustrias.fa_pre_facturacion.IdEmpresa = dbo.ct_periodo.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPeriodo = dbo.ct_periodo.IdPeriodo INNER JOIN
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af ON 
                         UnidadesRegistradas.IdEmpresa = Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdEmpresa AND 
                         UnidadesRegistradas.IdActivoFijo = Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdActivoFijo
GROUP BY Unidades_Facturadas.IdEmpresa, Unidades_Facturadas.IdPreFacturacion, Af.IdActivoFijo, Unidades_Facturadas.IdPeriodo, Af.Af_Nombre, 
                         dbo.ct_periodo.pe_FechaIni, dbo.ct_periodo.pe_FechaFin, Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdUnidadFact_cat, 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.Af_ValorUnidad_Actu

						  -- select * from  Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af