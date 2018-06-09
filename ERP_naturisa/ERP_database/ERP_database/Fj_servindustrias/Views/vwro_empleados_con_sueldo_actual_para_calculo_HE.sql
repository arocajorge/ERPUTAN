create view Fj_servindustrias.vwro_empleados_con_sueldo_actual_para_calculo_HE as 
SELECT        dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa, dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado, dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina, 
                         dbo.ro_empleado.IdPersona, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.ro_Nomina_Tipo.Descripcion, dbo.ro_empleado.em_status,
                             (SELECT        MAX(SueldoActual) AS SueldoActual
                               FROM            dbo.ro_empleado_historial_Sueldo AS Sactual
                               WHERE        (dbo.ro_empleado.IdEmpresa = IdEmpresa) AND (dbo.ro_empleado.IdEmpleado = IdEmpleado)) AS SueldoActual, dbo.ro_Nomina_Tipo.Estado, 
                         Fj_servindustrias.ro_Grupo_empleado.Nombre_Grupo, 
						 ISNULL( Fj_servindustrias.ro_Grupo_empleado.Calculo_Horas_extras_Sobre,0) Calculo_Horas_extras_Sobre, 
                        ISNULL( Fj_servindustrias.ro_Grupo_empleado.Max_num_horas_sab_dom,0) Max_num_horas_sab_dom
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_empleado ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         dbo.ro_Nomina_Tipo ON dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = dbo.ro_Nomina_Tipo.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = dbo.ro_Nomina_Tipo.IdNomina_Tipo LEFT OUTER JOIN
                         Fj_servindustrias.ro_Grupo_empleado ON dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_Grupo_empleado.IdEmpresa AND 
                         dbo.ro_empleado.IdGrupo = Fj_servindustrias.ro_Grupo_empleado.IdGrupo