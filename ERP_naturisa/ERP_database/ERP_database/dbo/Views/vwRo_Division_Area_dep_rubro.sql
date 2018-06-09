/*ORDER BY A.IdEmpresa, A.IdDivision, B.IdArea, C.IdDepartamento, D.ru_orden*/
CREATE VIEW dbo.vwRo_Division_Area_dep_rubro
AS
SELECT       ROW_NUMBER() OVER (ORDER BY dbo.ro_rubro_tipo.idempresa) AS IdFila, dbo.ro_Division.IdEmpresa, dbo.ro_Division.IdDivision, dbo.ro_Division.Descripcion AS DescripcionDiv, dbo.ro_area.IdArea, 
                         dbo.ro_area.Descripcion AS DescripcionArea, dbo.ro_Departamento.IdDepartamento, dbo.ro_Departamento.de_descripcion, dbo.ro_rubro_tipo.IdRubro, 
                         dbo.ro_rubro_tipo.rub_codigo, dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_rubro_tipo.ru_estado, dbo.ro_rubro_tipo.ru_tipo, dbo.ro_rubro_tipo.rub_concep, 
                         dbo.ro_rubro_tipo.rub_tipcal, dbo.ro_rubro_tipo.rub_ctacon, dbo.ro_rubro_tipo.rub_nocontab, dbo.ro_rubro_tipo.rub_guarda_rol, dbo.ro_rubro_tipo.rub_provision, 
                         dbo.ro_Config_Param_contable.IdCtaCble, dbo.ro_Config_Param_contable.IdCtaCble_Haber, dbo.ro_Config_Param_contable.DebCre, 
                         dbo.ro_Config_Param_contable.IdCentroCosto, dbo.ro_rubro_tipo.rub_acumula, dbo.ro_rubro_tipo.rub_noafecta, dbo.ro_rubro_tipo.rub_prorrateo, 
                         dbo.ro_rubro_tipo.rub_Acuerdo_Descuento, dbo.ro_rubro_tipo.rub_mustra_liquidacion_cliente, dbo.ro_rubro_tipo.rub_Contabiliza_x_empleado, 
                         dbo.ro_rubro_tipo.ru_aplica_empleado_Subsidio, dbo.ro_rubro_tipo.rub_AplicaEmpleado_Vac, dbo.ro_rubro_tipo.rub_aplica_IESS, dbo.ro_rubro_tipo.rub_utilid, 
                         dbo.ro_rubro_tipo.rub_liquida, dbo.ro_rubro_tipo.rub_grupo, dbo.ro_rubro_tipo.rub_antici, dbo.ro_rubro_tipo.rub_fornom, dbo.ro_rubro_tipo.rub_gencon, 
                         dbo.ro_rubro_tipo.rub_formul, dbo.ro_rubro_tipo.rub_valfij, dbo.ro_rubro_tipo.rub_legal, dbo.ro_rubro_tipo.rub_foract
FROM            dbo.ro_Config_Param_contable FULL OUTER JOIN
                         dbo.ro_area RIGHT OUTER JOIN
                         dbo.ro_Departamento INNER JOIN
                         dbo.ro_Division INNER JOIN
                         dbo.ro_area_x_departamento ON dbo.ro_Division.IdEmpresa = dbo.ro_area_x_departamento.IdEmpresa AND 
                         dbo.ro_Division.IdDivision = dbo.ro_area_x_departamento.IdDivision ON dbo.ro_Departamento.IdEmpresa = dbo.ro_area_x_departamento.IdEmpresa AND 
                         dbo.ro_Departamento.IdDepartamento = dbo.ro_area_x_departamento.IdDepartamento LEFT OUTER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_area_x_departamento.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa ON 
                         dbo.ro_area.IdEmpresa = dbo.ro_area_x_departamento.IdEmpresa AND dbo.ro_area.IdDivision = dbo.ro_area_x_departamento.IdDivision AND 
                         dbo.ro_area.IdArea = dbo.ro_area_x_departamento.IdArea ON dbo.ro_Config_Param_contable.IdRubro = dbo.ro_rubro_tipo.IdRubro AND 
                         dbo.ro_Config_Param_contable.IdEmpresa = dbo.ro_area_x_departamento.IdEmpresa AND 
                         dbo.ro_Config_Param_contable.IdDivision = dbo.ro_area_x_departamento.IdDivision AND 
                         dbo.ro_Config_Param_contable.IdArea = dbo.ro_area_x_departamento.IdArea AND 
                         dbo.ro_Config_Param_contable.IdDepartamento = dbo.ro_area_x_departamento.IdDepartamento
WHERE        (dbo.ro_rubro_tipo.rub_nocontab = 1)