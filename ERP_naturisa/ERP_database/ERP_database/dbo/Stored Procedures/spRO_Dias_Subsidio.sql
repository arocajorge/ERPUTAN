
create PROCEDURE [dbo].[spRO_Dias_Subsidio]
@IdEmpresa int,
@Idempleado int,
@FechaInicio_Periodo date,
@FechaFin_Periodo date

AS
BEGIN
	SET NOCOUNT ON;

   
	SELECT  IIF(FechaSalida<= @FechaInicio_Periodo and FechaEntrada<=@FechaFin_Periodo , datediff(DD,FechaSalida,FechaEntrada) , datediff(DD,FechaSalida,@FechaFin_Periodo)) as Dias_Sub,FechaEntrada,FechaSalida from ro_permiso_x_empleado as P
	where p.IdEmpresa=@IdEmpresa 
	and   p.IdEmpleado=@Idempleado
	and   p.FechaSalida between  @FechaInicio_Periodo and @FechaFin_Periodo
	or    p.FechaEntrada between @FechaFin_Periodo and @FechaInicio_Periodo
END