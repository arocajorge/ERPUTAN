CREATE PROCEDURE  [CAH].[spSys_mg_mecanismo_pago_x_rep_eco_x_matricula_x_alumno]
(
@i_Operacion varchar(20),
@i_Id int ,
@i_id_persona int ,
@i_id_alumno numeric (18),
@i_id_matricula numeric (18),
@i_id_tipo_mecanismo_pago int,
@i_numero_documento_bancario nvarchar(200)
--@i_fecha_transaccion datetime,
--@i_fecha_modificacion datetime
)
as
begin
declare @a_IdInstitucion int
declare @a_IdFamiliar numeric (18)
declare @a_IdParentesco_cat varchar	(35)
declare @a_IdDocumento_Bancario int
declare @a_Id_tipo_meca_pago int
declare @a_Id_tb_banco_x_mgbanco	int
declare @a_IdEstudiante numeric (18)
declare @a_IdMatricula numeric (18)
declare @a_Observacion varchar	(200)
--declare @a_FechaCreacion	datetime
--declare @a_FechaModificacion	datetime	
--declare @a_UsuarioCreacion	varchar	(25)
--declare @a_UsuarioModificacion	varchar	(25)
declare @a_idPersona_Erp numeric 

select @a_IdInstitucion = Ins.IdInstitucion from Aca_Institucion Ins where Ins.IdEmpresa=1

select @a_idPersona_Erp = IdPersona_Erp from CAH.tb_persona_x_mg_persona where IdPersona_Academico = @i_id_persona

select @a_IdFamiliar =  aca.IdFamiliar from Aca_Familiar as aca
where IdPersona = @a_idPersona_Erp

if(@i_numero_documento_bancario != '')
begin
select @a_IdDocumento_Bancario = @i_Id;
--select @a_IdDocumento_Bancario = IdDocumento_Bancario  from Aca_Documento_Bancario_x_Rep_Economico where Numero_Documento = @i_numero_documento_bancario and IdFamiliar = @a_IdFamiliar
	--print 'IdDocus: is not null' + Convert(varchar (255),@a_IdDocumento_Bancario)
end
else
begin

select @a_IdDocumento_Bancario = @i_Id;
--select @a_IdDocumento_Bancario = IdDocumento_Bancario  from Aca_Documento_Bancario_x_Rep_Economico where IdDocumento_Bancario = @i_Id--IdFamiliar = @a_IdFamiliar 
--print 'IdDocus is null: ' + Convert(varchar (255),@a_IdDocumento_Bancario)
end


select @a_IdParentesco_cat = IdCatalogo from Aca_Catalogo where IdCatalogo =  'REP_ECO'
set @a_IdMatricula = @i_id_matricula
select @a_IdEstudiante = IdEstudiante from mg_alumno_x_Aca_estudiante where id_alumno_academico = @i_id_alumno

select @a_Id_tipo_meca_pago = Id_tipo_meca_pago from Aca_Tipo_Mecanismo_Pago where Id_tipo_meca_pago = @i_id_tipo_mecanismo_pago


select @a_Id_tb_banco_x_mgbanco = Id_tb_banco_x_mgbanco from Aca_Tipo_Mecanismo_Pago where Id_tipo_meca_pago = @i_id_tipo_mecanismo_pago


set @a_Observacion = 'Migracion Academico'
--set @a_FechaCreacion =@i_fecha_transaccion
--set @a_FechaModificacion =@i_fecha_modificacion	
--set @a_UsuarioCreacion='sys_aca_mig'
--set @a_UsuarioModificacion='sys_aca_mig'

print 'IdInstitucion: ' + Convert(varchar (255),@a_IdInstitucion) 
print 'IdFamliar: ' + Convert(varchar (255),@a_IdFamiliar) 
print 'IdParentesco: ' + @a_IdParentesco_cat
print 'IdDocus: ' + Convert(varchar (255),@a_IdDocumento_Bancario)
print 'IdEstudiante: ' + Convert(varchar (255),@a_IdEstudiante)
print 'IdMatricula: ' + Convert(varchar (255),@a_IdMatricula) 
print 'IdMecanismoPago: ' + Convert(varchar (255),@a_Id_tipo_meca_pago) 
print '[Id_tb_banco_x_mgbanco]: ' + Convert(varchar (255),@a_Id_tb_banco_x_mgbanco) 

if(@a_IdDocumento_Bancario is not null)
begin
if (@i_Operacion='INSERT')
	begin
		if not exists( SELECT docu.IdDocumento_Bancario FROM Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula docu where docu.IdDocumento_Bancario = @a_IdDocumento_Bancario )
		begin
		INSERT INTO dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula
					(
					 [IdInstitucion]        ,[IdFamiliar]                   ,[IdParentesco_cat]    ,[IdDocumento_Bancario]
					,[IdEstudiante]         ,[IdMatricula]                  ,[Id_tipo_meca_pago]   ,[Id_tb_banco_x_mgbanco]	
					,[Observacion]         
					  	    		
					
					)
					values
					(
					 @a_IdInstitucion           ,@a_IdFamiliar             ,@a_IdParentesco_cat    ,@a_IdDocumento_Bancario
					,@a_IdEstudiante               ,@a_IdMatricula            ,@a_Id_tipo_meca_pago	    ,@a_Id_tb_banco_x_mgbanco           
					,@a_Observacion                      
						    	  	
										
					)


	end
	
		--update Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula
		--	set 
		--	IdFamiliar = @a_IdFamiliar,
		--	IdEstudiante = @a_IdEstudiante,
		--	IdMatricula = @a_IdMatricula,
		--	Id_tipo_meca_pago = @a_Id_tipo_meca_pago,
		--	Id_tb_banco_x_mgbanco = @a_Id_tb_banco_x_mgbanco
			
		--	where IdDocumento_Bancario = @a_IdDocumento_Bancario

	end


	end
			

end