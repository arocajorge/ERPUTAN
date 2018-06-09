
CREATE FUNCTION [dbo].[fxAf_Optener_Depreciacion_x_activo_x_periodo]
(
 @IdEmpresa AS INT, 
 @IdTipoDepreciacion AS INT, 
 @IdActivoFijo AS INT, 
 @Ciclo AS INT,
 @Es_Activo_x_Mejora AS bit
)
RETURNS float
AS
BEGIN
	-- Declare the return variable here
	DECLARE @ResultVar float


	select @ResultVar=A.Valor_Depreciacion
	from Af_Depreciacion_Det A INNER JOIN Af_Depreciacion B ON 
			A.IdEmpresa = B.IdEmpresa AND A.IdDepreciacion = B.IdDepreciacion
			AND A.IdTipoDepreciacion = B.IdTipoDepreciacion
	where 
	    A.IdEmpresa= @IdEmpresa
	and A.IdTipoDepreciacion=@IdTipoDepreciacion
	and A.IdActivoFijo=@IdActivoFijo
	and A.Ciclo=@Ciclo
	and B.Estado='A'
	AND A.Es_Activo_x_Mejora = @Es_Activo_x_Mejora
	
	set @ResultVar=ISNULL(@ResultVar,0)
	
	RETURN @ResultVar 

END