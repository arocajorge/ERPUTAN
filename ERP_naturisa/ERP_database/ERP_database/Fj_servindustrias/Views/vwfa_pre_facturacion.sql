create view Fj_servindustrias.vwfa_pre_facturacion
as
SELECT        Fj_servindustrias.fa_pre_facturacion.IdEmpresa, Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion, Fj_servindustrias.fa_pre_facturacion.IdPeriodo, 
                         Fj_servindustrias.fa_pre_facturacion.Observacion, Fj_servindustrias.fa_pre_facturacion.IdEstado_Proceso, Fj_servindustrias.fa_pre_facturacion.fecha, 
                         Fj_servindustrias.fa_pre_facturacion.estado, ct_periodo.pe_mes, ct_periodo.pe_FechaIni, ct_periodo.pe_FechaFin, 
                         fa_catalogo.Nombre AS nom_EstadoProceso
FROM            Fj_servindustrias.fa_pre_facturacion INNER JOIN
                         ct_periodo ON Fj_servindustrias.fa_pre_facturacion.IdEmpresa = ct_periodo.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPeriodo = ct_periodo.IdPeriodo INNER JOIN
                         fa_catalogo ON Fj_servindustrias.fa_pre_facturacion.IdEstado_Proceso = fa_catalogo.IdCatalogo