

CREATE PROCEDURE [dbo].[spRo_Cierre_Rol]
	@IdEmpresa int,
	@IdPeriodo int,
	@IdNomina_Tipo int,
	@IdNomina_TipoLiqui int
	
AS
BEGIN
update ro_Ing_Egre_x_Empleado set cerrado='S'
where IdEmpresa=@IdEmpresa and IdNomina_Tipo=@IdNomina_Tipo and IdNomina_TipoLiqui=@IdNomina_TipoLiqui
 and IdPeriodo=@IdPeriodo
END