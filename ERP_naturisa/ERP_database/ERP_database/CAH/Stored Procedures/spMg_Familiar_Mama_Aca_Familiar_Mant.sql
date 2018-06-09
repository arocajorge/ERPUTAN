CREATE proc [CAH].[spMg_Familiar_Mama_Aca_Familiar_Mant]
(
 @i_Operacion	varchar(20)
,@i_IdPersonaAcademico	numeric	
,@i_instruccion	varchar(50)	
--,@i_Titulo varchar(250)
--,@i_OcupacionLaboral varchar(250)
,@i_lugar_trabajo varchar(250)
--,@i_empresa_direccion varchar(250)
,@i_telefono_trabajo varchar(250)
--,@i_empresa_email varchar(150)
,@i_adress varchar(250)
,@i_Calle_Principal varchar(150)
,@i_Calle_Secundaria varchar(150)
,@i_Sector_Urbanizacion varchar(150)
,@i_IdCiudad varchar(25)
,@i_IdDiscapacidad bit
,@i_ViveFueraDelPais bit
,@i_Fallecido bit

,@i_Idioma varchar(35)
,@i_IdTipoSangre varchar(35)
,@i_IdReligion varchar(35)
,@i_ExAlumnoGraduado bit

--,@i_fecha_ingreso	datetime	
,@i_fecha_transaccion	datetime	
,@i_fecha_modificacion	datetime	
--,@o_w_IdEstudiante varchar(250) output

)
as 
begin 

declare @w_IdInstitucion	int
declare @w_IdFamiliar	numeric
declare @w_codfamiliar varchar(50)

declare @w_IdPersona	numeric	
declare @w_Id_NivelEducativo	varchar(35)	
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

declare @w_fecha_ingreso	datetime	
declare @w_FechaCreacion	datetime	
declare @w_FechaModificacion	datetime	
declare @w_UsuarioModificacion varchar(50)
declare @w_UsuarioCreacion varchar(50)

declare @w_estado varchar(1)
declare @w_cod_familiar varchar(50)


set @w_estado	='A'
--set @w_cod_familiar =''
set @w_cod_familiar = convert(varchar(50),@i_IdPersonaAcademico)
----set @w_Id_NivelEducativo =  @i_instruccion
set @w_Id_NivelEducativo =  'PRIM'
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
set @w_IdCiudad = null

if(@i_IdDiscapacidad != null)
begin
	set @w_PoseeDiscapacidad = 0
end
else
begin
	set @w_PoseeDiscapacidad = 1
end

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

----select @w_IdPais_Nacionalidad=IdPais from tb_pais where Nombre like '%ECUADOR%'

select @w_IdPersona = IdPersona_Erp from CAH.tb_persona_x_mg_persona where IdPersona_Academico=@i_IdPersonaAcademico


select @w_IdInstitucion=
Ins.IdInstitucion from Aca_Institucion Ins where Ins.IdEmpresa=1

	--set @o_w_IdEstudiante = @i_Operacion;
	if (@i_Operacion='INSERT')
	begin
		--set @o_w_IdEstudiante = 'HOLA';
		--return 'INSERT';
		--set @o_w_IdEstudiante = 'SELECT id_alumno_academico FROM CAH.mg_alumno_x_Aca_estudiante estu where estu.id_alumno_academico = ' + Convert(varchar(10),@i_id);
		
		--if not exists( SELECT IdFamiliar FROM dbo.Aca_Familiar fami where fami.idPersona =@i_IdPersonaAcademico )
		if not exists( SELECT IdFamiliar FROM dbo.Aca_Familiar fami where fami.idPersona =@w_IdPersona )
		--begin
		--	set @o_w_IdEstudiante = Convert(varchar(10),@i_id);
		--end
		--set @o_w_IdEstudiante = Convert(varchar(10),@i_id);
		begin


				select  @w_IdFamiliar=ISNULL(MAX(fami.IdFamiliar),0)+1 from Aca_Familiar fami where fami.IdInstitucion=@w_IdInstitucion
				
				--set @w_cod_F=@w_IdEstudiante
				--set @o_w_IdEstudiante = 10000;


					INSERT INTO [dbo].[Aca_Familiar]
					(
					 [IdInstitucion]				,[IdFamiliar]				,[cod_familiar]				,[IdPersona]
					,[IdNivelEducativo_cat]			,[Titulo]					,[OcupacionLaboral]			,[empresa_donde_trabaja]
					,[empresa_direccion]			,[empresa_telefono]			,[empresa_email]			,[direccion_domicilio]
					,[Calle_Principal]				,[Calle_Secundaria]			,[Sector_Urbanizacion]		,[IdCiudad]
					,[PoseeDiscapacidad]			,[ViveFueraDelPais]			,[Fallecido]				,[IdCatalogoIdiomaNativo]
					,[IdCatalogoTipoSangre]			,[IdCatalogoReligion]		,[FueExAlumnoGraduado]		
					,[FechaModificacion]			,[FechaCreacion]
					)
					values
					(
					 @w_IdInstitucion				,@w_IdFamiliar				,@w_cod_familiar			,@w_IdPersona	
					,@w_Id_NivelEducativo			,@w_Titulo					,@w_OcupacionLaboral		,@w_empresa_donde_trabaja	
					,@w_empresa_direccion			,@w_empresa_telefono		,@w_empresa_email			,@w_direccion_domicilio		
					,@w_Calle_Principal				,@w_Calle_Secundaria		,@w_Sector_Urbanizacion		,@w_IdCiudad			
					,@w_PoseeDiscapacidad			,@w_ViveFueraDelPais		,@w_Fallecido				,@w_IdCatalogoIdiomaNativo
					,@w_IdCatalogoTipoSangre		,@w_IdCatalogoReligion		,@w_FueExAlumnoGraduado
					,@w_FechaModificacion			,@w_FechaCreacion	
					)
		


					--INSERT INTO [CAH].[mg_alumno_x_Aca_estudiante]
					--   ([id_alumno_academico]				,[IdInstitucion]	,[IdEstudiante]
					--   ,[nota1]								,[nota2]
					--   )
					-- values
					-- (@i_id									,@w_IdInstitucion	,@w_IdEstudiante
					-- ,'INSERT - if (@i_Operacion=INSERT)'	,null
					-- )

					 
		end 

	end

	if (@i_Operacion='UPDATE')
	begin


		update Aca_Familiar
			set 

			cod_familiar = @w_codfamiliar,
			IdPersona=@w_IdPersona,
			IdNivelEducativo_cat = @w_Id_NivelEducativo,
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
			where IdFamiliar = @w_IdFamiliar   
	end 
		
end