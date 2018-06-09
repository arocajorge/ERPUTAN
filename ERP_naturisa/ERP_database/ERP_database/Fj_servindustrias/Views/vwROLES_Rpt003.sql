create view Fj_servindustrias.vwROLES_Rpt003 as 
SELECT        
 dbo.ro_nomina_x_horas_extras.IdEmpresa,
 dbo.ro_nomina_x_horas_extras.IdEmpleado,
 dbo.ro_nomina_x_horas_extras.IdNominaTipo, 
 dbo.ro_nomina_x_horas_extras.IdNominaTipoLiqui,
 dbo.ro_nomina_x_horas_extras.IdPeriodo, 
 SUM( dbo.ro_nomina_x_horas_extras.hora_extra25)hora_extra25, 
 SUM(dbo.ro_nomina_x_horas_extras.hora_extra50)hora_extra50,
 SUM( dbo.ro_nomina_x_horas_extras.hora_extra100)hora_extra100,
 SUM(dbo.ro_nomina_x_horas_extras.hora_extra25+dbo.ro_nomina_x_horas_extras.hora_extra50+dbo.ro_nomina_x_horas_extras.hora_extra100) TotalHorasExtras,
 SUM(dbo.ro_nomina_x_horas_extras.hora_trabajada) hora_trabajada,
 (select count(DISTINCT es_fechaRegistro) from ro_marcaciones_x_empleado where dbo.ro_nomina_x_horas_extras.IdEmpresa=IdEmpresa and dbo.ro_nomina_x_horas_extras.IdEmpleado=IdEmpleado and dbo.ro_nomina_x_horas_extras.IdPeriodo= IdPeriodo  ) as Dias_Efectivos,
 dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombre, 
 dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombreCompleto

FROM            dbo.ro_nomina_x_horas_extras INNER JOIN
                         dbo.ro_empleado ON dbo.ro_nomina_x_horas_extras.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_nomina_x_horas_extras.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona
GROUP BY dbo.ro_nomina_x_horas_extras.IdEmpresa, dbo.ro_nomina_x_horas_extras.IdEmpleado, dbo.ro_nomina_x_horas_extras.IdNominaTipo, 
                         dbo.ro_nomina_x_horas_extras.IdNominaTipoLiqui, dbo.ro_nomina_x_horas_extras.IdPeriodo,
                          dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombre, 
                         dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombreCompleto