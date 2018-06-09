CREATE PROC [CAH].[spMg_Familiar_x_Alunmo_Mant]
(
 @i_Operacion	varchar(20)                   
,@i_IdEstudiante numeric	
,@i_IdPersonaFamiliarAcademico numeric
,@i_tipofamiliar varchar(9)
,@i_fecha_transaccion	datetime	
,@i_fecha_modificacion	datetime	


)
as 
begin 

declare @w_IdInstitucion int 
declare @w_IdEstudiante numeric
declare @w_IdFamiliar numeric

declare @w_IdPersonaFamliar numeric

declare @w_IdParentesco varchar(35)	
declare @w_porcentaje_dual int
declare @w_estado bit

declare @w_esta_autorizado_ret_alum bit
declare @w_esta_autorizado_recibir_not_mail bit
declare @w_Vive_con_el_estudiante bit

declare @w_FechaCreacion	datetime	
declare @w_FechaModificacion	datetime	
declare @w_UsuarioModificacion varchar(50)
declare @w_UsuarioCreacion varchar(50)


select @w_IdInstitucion=Ins.IdInstitucion from Aca_Institucion Ins where Ins.IdEmpresa=1
----set @w_IdEstudiante = @i_IdEstudiante   --Se debe buscar el id en la tabla intermedia

if(@i_tipofamiliar = 'REP_ECO')
begin
set @w_IdParentesco = 'REP_ECO'
set @w_porcentaje_dual = 100
end
else if(@i_tipofamiliar = 'REP_LEGAL')
set @w_IdParentesco = 'REP_LEGAL'
else if(@i_tipofamiliar = 'PADR')
set @w_IdParentesco = 'PADR'
else if(@i_tipofamiliar = 'MADR')
set @w_IdParentesco = 'MADR'

set @w_estado = 1
set @w_esta_autorizado_recibir_not_mail = 0
set @w_esta_autorizado_ret_alum = 0
set @w_Vive_con_el_estudiante = 1

set @w_FechaModificacion	=@i_fecha_modificacion
set @w_FechaCreacion	=@i_fecha_transaccion
set @w_UsuarioModificacion	='sys_aca_mig'
set @w_UsuarioCreacion	='sys_aca_mig'



select @w_IdPersonaFamliar = IdPersona_Erp from CAH.tb_persona_x_mg_persona where IdPersona_Academico=@i_IdPersonaFamiliarAcademico

select  @w_IdFamiliar=IdFamiliar from Aca_Familiar fami where fami.IdPersona=  @w_IdPersonaFamliar

Select @w_IdEstudiante = IdEstudiante FROM CAH.mg_alumno_x_Aca_estudiante where id_alumno_academico = @i_IdEstudiante

	if (@i_Operacion='INSERT')
	begin
			if exists( SELECT IdFamiliar FROM dbo.Aca_Familiar fami where fami.idPersona = @w_IdPersonaFamliar )
			begin
				if not exists (Select * from dbo.Aca_Familiar_x_Estudiante fami_est where fami_est.IdInstitucion = @w_IdInstitucion and fami_est.IdEstudiante = @w_IdEstudiante and fami_est.IdFamiliar = @w_IdFamiliar and fami_est.IdParentesco_cat = @w_IdParentesco)
					begin
						if exists( SELECT IdEstudiante FROM CAH.mg_alumno_x_Aca_estudiante where id_alumno_academico = @i_IdEstudiante )
						begin


							INSERT INTO [dbo].[Aca_Familiar_x_Estudiante]
							(
							 [IdInstitucion]				,[IdEstudiante]				  ,[IdFamiliar]				            ,[IdParentesco_cat]
							,[activo]			            ,[esta_autorizado_ret_alum]   ,[esta_autorizado_recibir_not_mail]	,[Vive_con_el_estudiante]
							,[FechaCreacion]                ,[FechaModificacion]          ,[UsuarioCreacion]					,[porcentaje_dual]   
							)
							values
							(
							 @w_IdInstitucion				,@w_IdEstudiante			  ,@w_IdFamiliar			                ,@w_IdParentesco	
							,@w_estado			            ,@w_esta_autorizado_ret_alum  ,@w_esta_autorizado_recibir_not_mail		,@w_Vive_con_el_estudiante	
							,@w_FechaCreacion	            ,@w_FechaModificacion		  ,@w_UsuarioCreacion						,@w_porcentaje_dual
							)

						end



					end
			end


	end

	if (@i_Operacion='UPDATE')
	begin


	update Aca_Familiar_x_Estudiante
			set 
					
			 --IdFamiliar	= @w_IdFamiliar,			            
			 --IdParentesco_cat = @w_IdParentesco,
			 activo	= @w_estado,		            
			 esta_autorizado_ret_alum  = @w_esta_autorizado_ret_alum,
			 esta_autorizado_recibir_not_mail	= @w_esta_autorizado_recibir_not_mail,
			 Vive_con_el_estudiante = @w_Vive_con_el_estudiante,			 		
			 FechaModificacion=@w_FechaModificacion,
			 UsuarioModificacion=@w_UsuarioModificacion
			where IdEstudiante = @w_IdEstudiante and IdFamiliar	= @w_IdFamiliar and IdParentesco_cat = @w_IdParentesco
	end
		
end