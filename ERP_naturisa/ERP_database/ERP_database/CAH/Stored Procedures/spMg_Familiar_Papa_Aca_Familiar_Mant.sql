CREATE proc [CAH].[spMg_Familiar_Papa_Aca_Familiar_Mant]
(
 @i_Operacion	varchar(20)                     
,@i_IdPersonaAcademico	numeric	
,@i_instruccion	varchar(50)	
,@i_lugar_trabajo varchar(250)
,@i_telefono_trabajo varchar(250)

,@i_adress varchar(250)
,@i_Calle_Principal varchar(150)
,@i_Calle_Secundaria varchar(150)
,@i_Sector_Urbanizacion varchar(150)
,@i_IdCiudad_Academico varchar(25)
,@i_TieneDiscapacidad bit
,@i_ViveFueraDelPais bit
,@i_Fallecido bit
,@i_Idioma varchar(35)
,@i_IdTipoSangre varchar(35)
,@i_IdReligion varchar(35)
,@i_ExAlumnoGraduado bit
,@i_fecha_transaccion	datetime	
,@i_fecha_modificacion	datetime	


)
as 
begin 

declare @w_IdInstitucion	int
declare @w_IdFamiliar	numeric
declare @w_IdPersona_Academico	numeric	
declare @w_codfamiliar varchar(50)
declare @w_IdPersona	numeric	
declare @w_IdNivelEducativo	varchar(35)	
declare @w_Titulo varchar(250)
declare @w_OcupacionLaboral varchar(250)
declare @w_empresa_donde_trabaja varchar(250)
declare @w_empresa_direccion varchar(250)
declare @w_empresa_telefono varchar(50)
declare @w_empresa_email varchar(150)
declare @w_direccion_domicilio varchar(250)
declare @w_Calle_Principal varchar(150)
declare @w_Calle_Secundaria varchar(150)
declare @w_Sector_Urbanizacion varchar(150)
declare @w_IdCiudad varchar(25)
declare @w_PoseeDiscapacidad bit
declare @w_ViveFueraDelPais bit
declare @w_Fallecido bit

declare @w_IdCatalogoIdiomaNativo varchar(35)
declare @w_IdCatalogoTipoSangre varchar(35)
declare @w_IdCatalogoReligion varchar(35)

declare @w_FueExAlumnoGraduado bit	
declare @w_FechaCreacion	datetime	
declare @w_FechaModificacion	datetime	
declare @w_UsuarioModificacion varchar(50)
declare @w_UsuarioCreacion varchar(50)


set @w_codfamiliar = convert(varchar(50),@i_IdPersonaAcademico)

set @w_IdPersona_Academico = @i_IdPersonaAcademico

if(@i_instruccion = 'INSTRUC_UNIVERSITARIA')
    set @w_IdNivelEducativo =  'UNIVE'
else if (@i_instruccion = 'INSTRUC_SECUNDARIA')
   set @w_IdNivelEducativo =  'SECU'
else if (@i_instruccion = 'INSTRUC_PRIMARIA')
   set @w_IdNivelEducativo =  'PRIM'
else if (@i_instruccion is null)
   set @w_IdNivelEducativo =  'SIN_EDU'

--set @w_IdNivelEducativo = 'PRIM'
set @w_Titulo = ''
set @w_OcupacionLaboral = ''
set @w_empresa_donde_trabaja = @i_lugar_trabajo
set @w_empresa_direccion = ''
set @w_empresa_telefono = @i_telefono_trabajo
set @w_empresa_email =  ''
set @w_direccion_domicilio = @i_adress
set @w_Calle_Principal = @i_Calle_Principal
set @w_Calle_Secundaria = @i_Calle_Secundaria
set @w_Sector_Urbanizacion = @i_Sector_Urbanizacion
--set @w_IdCiudad = null
set @w_PoseeDiscapacidad = @i_TieneDiscapacidad
set @w_ViveFueraDelPais = @i_ViveFueraDelPais
set @w_Fallecido  = @i_Fallecido

set @w_IdCatalogoIdiomaNativo = 'ESPA'
set @w_IdCatalogoTipoSangre = 'CATOL' 
set @w_IdCatalogoReligion = 'CATOL'

set @w_FueExAlumnoGraduado = @i_ExAlumnoGraduado
set @w_FechaModificacion	=@i_fecha_modificacion
set @w_FechaCreacion	=@i_fecha_transaccion
set @w_UsuarioModificacion	='sys_aca_mig'
set @w_UsuarioCreacion	='sys_aca_mig'

select @w_IdPersona = IdPersona_Erp from CAH.tb_persona_x_mg_persona where IdPersona_Academico=@w_IdPersona_Academico

select @w_IdInstitucion=Ins.IdInstitucion from Aca_Institucion Ins where Ins.IdEmpresa=1


	if (@i_Operacion='INSERT')
	begin

		if not exists( SELECT IdPersona FROM dbo.Aca_Familiar fami where fami.IdPersona =@w_IdPersona)
	
		begin


				select  @w_IdFamiliar=ISNULL(MAX(fami.IdFamiliar),0)+1 from Aca_Familiar fami where fami.IdInstitucion=@w_IdInstitucion
				select  @w_IdCiudad=tb.IdCiudad_Erp from  tb_ciudad_x_mg_ciudad tb where tb.IdCiudad_Academico=@i_IdCiudad_Academico


					INSERT INTO [dbo].[Aca_Familiar]
					(
					 [IdInstitucion]				,[IdFamiliar]				,[cod_familiar]				,[IdPersona]
					,[IdNivelEducativo_cat]			,[Titulo]					,[OcupacionLaboral]			,[empresa_donde_trabaja]
					,[empresa_direccion]			,[empresa_telefono]			,[empresa_email]			,[direccion_domicilio]
					,[Calle_Principal]				,[Calle_Secundaria]			,[Sector_Urbanizacion]		,[IdCiudad]
					,[PoseeDiscapacidad]			,[ViveFueraDelPais]			,[Fallecido]				,[IdCatalogoIdiomaNativo]
					,[IdCatalogoTipoSangre]			,[IdCatalogoReligion]		,[FueExAlumnoGraduado]		,[FechaModificacion]
					,[FechaCreacion]                ,[UsuarioCreacion]       
					)
					values
					(
					 @w_IdInstitucion				,@w_IdFamiliar				,@w_codfamiliar			   ,@w_IdPersona	
					,@w_IdNivelEducativo			,@w_Titulo					,@w_OcupacionLaboral		,@w_empresa_donde_trabaja	
					,@w_empresa_direccion			,@w_empresa_telefono		,@w_empresa_email			,@w_direccion_domicilio		
					,@w_Calle_Principal				,@w_Calle_Secundaria		,@w_Sector_Urbanizacion		,@w_IdCiudad			
					,@w_PoseeDiscapacidad			,@w_ViveFueraDelPais		,@w_Fallecido				,@w_IdCatalogoIdiomaNativo
					,@w_IdCatalogoTipoSangre		,@w_IdCatalogoReligion		,@w_FueExAlumnoGraduado     ,@w_FechaModificacion
					,@w_FechaCreacion	            ,@w_UsuarioCreacion
					)
		end 

	end

	if (@i_Operacion='UPDATE')
	begin


	update Aca_Familiar
			set 
			
			
			cod_familiar = @w_codfamiliar,
			IdPersona=@w_IdPersona,
			IdNivelEducativo_cat = @w_IdNivelEducativo,
			Titulo = @w_Titulo,
			OcupacionLaboral = @w_OcupacionLaboral,
			empresa_donde_trabaja = @w_empresa_donde_trabaja,		
			empresa_direccion = @w_empresa_direccion,
			empresa_telefono = @w_empresa_telefono,
			empresa_email = @w_empresa_email,
			direccion_domicilio = @w_direccion_domicilio,
            Calle_Principal = @w_Calle_Principal,
            Calle_Secundaria = @w_Calle_Secundaria,
            Sector_Urbanizacion = @w_Sector_Urbanizacion,
            IdCiudad = @w_IdCiudad,
            PoseeDiscapacidad = @w_PoseeDiscapacidad,
            ViveFueraDelPais = @w_ViveFueraDelPais,
            Fallecido  = @w_Fallecido,
			IdCatalogoIdiomaNativo = @w_IdCatalogoIdiomaNativo,			
			IdCatalogoTipoSangre = @w_IdCatalogoTipoSangre,
			IdCatalogoReligion =@w_IdCatalogoReligion,
            FueExAlumnoGraduado = @w_FueExAlumnoGraduado,		
			FechaModificacion=@w_FechaModificacion,
			UsuarioModificacion=@w_UsuarioModificacion
			--where IdInstitucion = @w_IdInstitucion  
			where IdFamiliar = @w_IdFamiliar    
	end
		
end