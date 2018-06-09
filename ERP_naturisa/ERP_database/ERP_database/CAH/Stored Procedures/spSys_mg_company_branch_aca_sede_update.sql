
CREATE PROCEDURE  [CAH].[spSys_mg_company_branch_aca_sede_update]
(
@i_Operacion	varchar(20),
@i_IdInstitucion int ,
@i_IdSede int ,
@i_Nombre varchar(50),
@i_fecha_modificacion datetime
)
as
begin

declare @w_IdInstitucion int
declare @w_IdSede	int
declare @w_Nombre	varchar(50)
declare @w_CodSede	varchar	(25)
declare @w_CodAlterno	varchar	(25)
declare @w_estado	nchar	(1)
declare @w_FechaModificacion	datetime	
declare @w_UsuarioModificacion	varchar	(25)
declare @w_UsuarioCreacion	varchar	(25)

set @w_IdInstitucion = @i_IdInstitucion
set @w_IdSede = @i_IdSede
set @w_Nombre = @i_Nombre
set @w_CodSede	=@i_IdSede
set @w_CodAlterno	=@i_IdSede
set @w_estado	='A'
set @w_FechaModificacion = @i_fecha_modificacion
set @w_UsuarioModificacion	='sys_aca_mig'
set @w_UsuarioCreacion	='sys_aca_mig'

if (@i_Operacion='INSERT')
	begin
		
		INSERT INTO [dbo].Aca_Sede
					(
					 [IdSede]						,[IdInstitucion]			,[CodSede]					,[CodAlterno]
					,[Descripcion_sede]				,[estado]					--,[FechaCreacion]			,[FechaAnulacion]
					,[FechaModificacion]			,[UsuarioCreacion]			,[UsuarioModificacion]		--,[UsuarioAnulacion]
					--,[MotivoAnulacion]
					)
					values
					(
					 @w_IdSede						,@w_IdInstitucion			,@w_CodSede					,@w_CodAlterno
					,@w_Nombre						,@w_estado					--,null						,null
					,@w_FechaModificacion			,@w_UsuarioCreacion			,@w_UsuarioModificacion		--,null	
					--,@w_cod_alter					
					)


	end


if (@i_Operacion='UPDATE')
	begin

		update Aca_Sede
			set 
			
			--IdInstitucion = @i_IdInstitucion,
			--IdSede = @i_IdSede,
			Descripcion_sede = @w_Nombre,
			estado = @w_estado,
			FechaModificacion=@w_FechaModificacion
			where IdInstitucion=@w_IdInstitucion and IdSede=@w_IdSede

	end

			

end