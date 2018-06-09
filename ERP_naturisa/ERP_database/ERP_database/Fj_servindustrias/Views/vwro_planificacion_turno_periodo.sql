CREATE VIEW [Fj_servindustrias].[vwro_planificacion_turno_periodo]


as

SELECT        Pl.IdEmpresa, Pl.IdNomina_Tipo, Pl.IdEmpleado, Pl.IdPeriodo, Pl.IdMes, Pl.IdAnio, Pl.IdTurno, Pl.Observacion, Pl.Estado, PE.pe_FechaIni, PE.pe_FechaFin, 
                         TU.es_jornada_desfasada, TU.tu_descripcion
FROM            Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado AS Pl INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON Pl.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         Pl.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado AND Pl.IdNomina_Tipo = dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina INNER JOIN
                         dbo.ro_turno AS TU ON Pl.IdEmpresa = TU.IdEmpresa AND Pl.IdTurno = TU.IdTurno INNER JOIN
                         dbo.ro_periodo AS PE ON Pl.IdEmpresa = PE.IdEmpresa AND Pl.IdPeriodo = PE.IdPeriodo
GROUP BY Pl.IdEmpresa, Pl.IdNomina_Tipo, Pl.IdEmpleado, Pl.IdPeriodo, Pl.IdMes, Pl.IdAnio, Pl.IdTurno, Pl.Observacion, Pl.Estado, PE.pe_FechaIni, PE.pe_FechaFin, 
                         TU.es_jornada_desfasada, TU.tu_descripcion