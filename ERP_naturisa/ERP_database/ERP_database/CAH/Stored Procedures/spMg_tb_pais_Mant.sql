CREATE proc [CAH].[spMg_tb_pais_Mant]
(
 @i_Operacion	varchar(20)
,@i_IdPais_Academico	int	
,@i_nombre_pais	varchar(255)
,@i_ISO3	varchar(255)	
--,@i_fecha_ingreso	datetime	
--,@i_fecha_transaccion	datetime	
--,@i_fecha_modificacion	datetime	
--,@o_w_IdEstudiante varchar(250) output

)
as 
begin 

declare @w_IdPais_Academico	int
declare @w_nombre_pais	varchar	(255)
declare @w_IdPais_Erp	varchar	(10)
declare @w_Nacionalidad varchar(50)

declare @w_FechaModificacion	datetime	
declare @w_FechaCreacion	datetime	
declare @w_UsuarioModificacion	varchar	(25)
declare @w_UsuarioCreacion	varchar	(25)
declare @w_estado char(1)
declare @w_CodPais varchar(50)


set @w_FechaModificacion	= GETDATE()
set @w_FechaCreacion	= GETDATE()
set @w_UsuarioModificacion	='sys_aca_mig'
set @w_UsuarioCreacion	='sys_aca_mig'
set @w_nombre_pais = upper(@i_nombre_pais)
set @w_Nacionalidad = ''
set @w_estado = 'A'
set @w_CodPais = @i_ISO3

--select @w_IdPais_Nacionalidad=IdPais from tb_pais where Nombre like '%ECUADOR%'

--select @w_IdPersona = IdPersona_Erp from CAH.tb_persona_x_mg_persona where IdPersona_Academico=@i_id_persona


--select @w_IdInstitucion=
--Ins.IdInstitucion from Aca_Institucion Ins where Ins.IdEmpresa=1

	--set @o_w_IdEstudiante = @i_Operacion;
	if (@i_Operacion='INSERT')
	begin
		--set @o_w_IdEstudiante = 'HOLA';
		--return 'INSERT';
		--set @o_w_IdEstudiante = 'SELECT id_alumno_academico FROM CAH.mg_alumno_x_Aca_estudiante estu where estu.id_alumno_academico = ' + Convert(varchar(10),@i_id);
		print 'IdPais_Academico ' + Convert(varchar(100), @w_nombre_pais);
		--if not exists( select IdPais from tb_pais where Nombre like @w_nombre_pais or Nombre != 'BIRMANIA' or Nombre != 'SAMOA')
		--begin
		--	set @o_w_IdEstudiante = Convert(varchar(10),@i_id);
		--end
		--set @o_w_IdEstudiante = Convert(varchar(10),@i_id);
		
		--begin
			
			if not exists (Select IdPais_Erp from CAH.tb_pais_x_mg_pais where IdPais_Academico = @i_IdPais_Academico)
			begin
				--print 'NO EXISTE PAIS EN TABLA INTERMEDIA'
				
				select  @w_IdPais_Erp=ISNULL(MAX(Convert(int,p.IdPais)),0)+1 from tb_pais p --where p.IdInstitucion=@w_IdInstitucion
				

				--print @w_CodPais

					INSERT INTO [dbo].tb_pais
					(
					 [IdPais]						,[CodPais]					,[Nombre]					,[Nacionalidad]
					,[estado]						,[IdUsuario]				,[Fecha_Transac]			,[IdUsuarioUltMod]
					,[Fecha_UltMod]					
					)
					values
					(
					 @w_IdPais_Erp					,@w_CodPais					,@w_nombre_pais				,@w_Nacionalidad	
					,@w_estado						,@w_UsuarioCreacion			,@w_FechaCreacion			,@w_UsuarioModificacion	
					,@w_FechaModificacion				
					)
		


					INSERT INTO [CAH].[tb_pais_x_mg_pais]
					   ([IdPais_Erp]				,[IdPais_Academico]			
					   ,[nota1]								,[nota2]
					   )
					 values
					 (@w_IdPais_Erp									,@i_IdPais_Academico	
					 ,'INSERT - if (@i_Operacion=INSERT)'	,null
					 )

				end	 
				--print 'No existe'
		--end 

	end

	--if (@i_Operacion='UPDATE')
	--begin


	--	SELECT @w_IdInstitucion=IdInstitucion,@w_IdEstudiante=IdEstudiante 
	--	FROM [CAH].[mg_alumno_x_Aca_estudiante] 
	--	WHERE id_alumno_academico=@i_id


	--	UPDATE [dbo].[Aca_estudiante]
	--	SET 
	--		IdPais_Nacionalidad=@w_IdPais_Nacionalidad
	--		,FechaModificacion=@i_fecha_modificacion	
	--	WHERE 		
	--		IdInstitucion=@w_IdInstitucion
	--	AND IdEstudiante=@w_IdEstudiante


	--	update [CAH].[mg_alumno_x_Aca_estudiante]
	--	set 
	--	   nota2='UDPATE - if (@i_Operacion=UPDATE)'
	--	where 
	--		id_alumno_academico=@i_id
	--	and IdInstitucion=@w_IdInstitucion
	--	and IdEstudiante=@w_IdEstudiante
	--end 
		
end