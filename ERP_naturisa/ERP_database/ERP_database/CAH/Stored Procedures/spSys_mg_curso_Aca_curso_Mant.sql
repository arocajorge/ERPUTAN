CREATE PROCEDURE  [CAH].[spSys_mg_curso_Aca_curso_Mant]
(
@i_Operacion varchar(20),
@i_Idcurso int ,
@i_Idseccion int ,
@i_Descripcion	varchar(50),
@i_isActive nchar,
@i_fecha_transaccion datetime,
@i_fecha_modificacion datetime
)
as
begin

declare @a_IdCurso int
declare @a_IdSeccion	int
declare @a_CodCurso	varchar	(50)
declare @a_CodAlternoCur	varchar	(50)
declare @a_Descripcion_cur	varchar(50)
declare @a_estado	nchar	(1)
declare @a_FechaCreacion	datetime
declare @a_FechaModificacion	datetime	
declare @a_UsuarioCreacion	varchar	(25)
declare @a_UsuarioModificacion	varchar	(25)

set @a_IdCurso =@i_Idcurso
set @a_IdSeccion =@i_Idseccion
set @a_CodCurso =''
set @a_CodAlternoCur =''
set @a_Descripcion_cur =@i_Descripcion
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
		
		INSERT INTO [dbo].Aca_curso
					(
					 [IdCurso]					,[IdSeccion]			,[CodCurso]          ,[CodAlternoCur]
					,[Descripcion_cur]			,[estado]               ,[FechaCreacion]	
					,[FechaModificacion]		,[UsuarioCreacion]	    ,[UsuarioModificacion]		
					
					)
					values
					(
					 @a_IdCurso					,@a_IdSeccion			  ,@a_CodCurso        ,@a_CodAlternoCur
					,@a_Descripcion_cur			,@a_estado				  ,@a_FechaCreacion
					, @a_FechaModificacion	    ,@a_UsuarioCreacion		  ,@a_UsuarioModificacion	
										
					)


	end


if (@i_Operacion='UPDATE')
	begin

		update Aca_curso
			set 
			
			
			Descripcion_cur = @a_Descripcion_cur,
			estado = @a_estado,			
			FechaModificacion=@a_FechaModificacion,
			UsuarioModificacion=@a_UsuarioModificacion
			where IdCurso=@a_Idcurso  and IdSeccion=@a_IdSeccion

	end

			

end