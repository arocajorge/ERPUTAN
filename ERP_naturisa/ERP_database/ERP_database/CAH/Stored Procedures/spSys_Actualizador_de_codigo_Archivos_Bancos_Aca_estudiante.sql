CREATE PROCEDURE  [CAH].[spSys_Actualizador_de_codigo_Archivos_Bancos_Aca_estudiante]
(
@i_Operacion varchar(20),
@i_Pe_Cedula varchar(50) ,
@i_Codigo_alumno	varchar(50)

)
as
begin


declare @a_Codigo_alumno	varchar	(50)
declare @a_IdPersona int 

select @a_IdPersona =  IdPersona from tb_persona where ltrim(rtrim(pe_cedulaRuc)) = ltrim(rtrim(@i_Pe_Cedula));

set @a_Codigo_alumno =@i_Codigo_alumno
if (@i_Operacion='UPDATE')
	begin

		update Aca_estudiante
			set 
			cod_estudiante2 = @a_Codigo_alumno
			where IdPersona=@a_IdPersona 

	end

			

end