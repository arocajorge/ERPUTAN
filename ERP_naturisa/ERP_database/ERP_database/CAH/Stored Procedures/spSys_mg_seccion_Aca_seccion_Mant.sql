CREATE PROCEDURE  [CAH].[spSys_mg_seccion_Aca_seccion_Mant]
(
@i_Operacion	varchar(20),
@i_IdJornada int ,
@i_IdSeccion int ,
@i_isActive int,
@i_descripcion varchar	(250),
@i_fecha_transaccion datetime,
@i_fecha_modificacion datetime
)
as
begin
declare @a_IdSeccion	int
declare @a_IdJornada int
declare @a_CodSeccion	varchar	(50)
declare @a_CodAlterno	varchar	(50)
declare @a_descripcion_secc	varchar(50)
declare @a_estado	nchar	(1)
declare @a_FechaCreacion	datetime
declare @a_FechaModificacion	datetime	
declare @a_UsuarioCreacion	varchar	(25)
declare @a_UsuarioModificacion	varchar	(25)


set @a_IdSeccion = @i_IdSeccion
set @a_IdJornada =@i_IdJornada
set @a_CodSeccion = ''
set @a_CodAlterno = ''
set @a_descripcion_secc = @i_descripcion
if (@i_isActive = 1)
set @a_estado= 'A'
else
set @a_estado= 'I'
set @a_FechaCreacion =@i_fecha_transaccion
set @a_FechaModificacion =@i_fecha_modificacion	
set @a_UsuarioCreacion='sys_aca_mig'
set @a_UsuarioModificacion='sys_aca_mig'


if (@i_Operacion='INSERT')
	begin
		
		INSERT INTO [dbo].Aca_Seccion
					(
					 [IdSeccion]					,[IdJornada]			,[CodSeccion]          ,[CodAlterno_Sec]
					,[Descripcion_secc]				,[estado]				,[FechaCreacion]	
					,[FechaModificacion]			,[UsuarioCreacion]			,[UsuarioModificacion]		
					
					)
					values
					(
					 @a_IdSeccion					,@a_IdJornada			  ,@a_CodSeccion        ,@a_CodAlterno
					,@a_descripcion_secc			,@a_estado				  ,@a_FechaCreacion
					, @a_FechaModificacion			,@a_UsuarioCreacion			,@a_UsuarioModificacion	
										
					)


	end


if (@i_Operacion='UPDATE')
	begin

		update Aca_Seccion
			set 
			
			
			Descripcion_secc = @a_descripcion_secc,
			estado = @a_estado,
			FechaCreacion = @a_FechaCreacion,
			FechaModificacion=@a_FechaModificacion
			where IdSeccion=@a_IdSeccion and IdJornada=@a_IdJornada

	end

			

end