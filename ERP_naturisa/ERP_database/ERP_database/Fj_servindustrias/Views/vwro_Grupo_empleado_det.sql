CREATE VIEW [Fj_servindustrias].[vwro_Grupo_empleado_det]
AS
SELECT        Fj_servindustrias.ro_Grupo_empleado_det.IdEmpresa, Fj_servindustrias.ro_Grupo_empleado_det.IdGrupo, 
                         Fj_servindustrias.ro_Grupo_empleado_det.cod_Pago_Variable, Fj_servindustrias.ro_Grupo_empleado_det.Porcentaje_calculo, 
                         Fj_servindustrias.ro_parametro_x_pago_variable_tipo.IdRubro, Fj_servindustrias.ro_Grupo_empleado.Valor_bono
FROM            Fj_servindustrias.ro_Grupo_empleado_det INNER JOIN
                         Fj_servindustrias.ro_parametro_x_pago_variable_tipo ON 
                         Fj_servindustrias.ro_Grupo_empleado_det.IdEmpresa = Fj_servindustrias.ro_parametro_x_pago_variable_tipo.IdEmpresa AND 
                         Fj_servindustrias.ro_Grupo_empleado_det.cod_Pago_Variable = Fj_servindustrias.ro_parametro_x_pago_variable_tipo.cod_Pago_Variable INNER JOIN
                         Fj_servindustrias.ro_Grupo_empleado ON Fj_servindustrias.ro_Grupo_empleado_det.IdEmpresa = Fj_servindustrias.ro_Grupo_empleado.IdEmpresa AND 
                         Fj_servindustrias.ro_Grupo_empleado_det.IdGrupo = Fj_servindustrias.ro_Grupo_empleado.IdGrupo