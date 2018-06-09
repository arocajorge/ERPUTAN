CREATE PROCEDURE  [CAH].[spSys_mg_mecanismo_pago_Aca_Documento_Bancario_x_Rep_Economico_Mant]
(
@i_Operacion varchar(20),
@i_Id int ,
@i_numero varchar(200),
@i_id_persona int ,
@i_id_tipo_mecanismo_pago int,
@i_isActive int,
@i_tipo varchar(50),
@i_fecha_caducidad datetime,
@i_fecha_transaccion datetime,
@i_fecha_modificacion datetime
)
as
begin
declare @a_IdInstitucion int
declare @a_IdFamiliar numeric (18)
declare @a_IdParentesco_cat varchar	(35)
declare @a_IdDocumento_Bancario int
declare @a_Id_tipo_meca_pago int
declare @a_Id_tb_banco_x_mgbanco	int
declare @a_IdBanco int
declare @a_Tipo_documento_cat	varchar	(10)
declare @a_Numero_Documento varchar	(50)
declare @a_Fecha_Expiracion datetime
declare @a_Estado	bit
declare @a_Observacion varchar	(200)
declare @a_FechaCreacion	datetime
declare @a_FechaModificacion	datetime	
declare @a_UsuarioCreacion	varchar	(25)
declare @a_UsuarioModificacion	varchar	(25)
declare @a_idPersona_Erp numeric 

select @a_IdInstitucion = Ins.IdInstitucion from Aca_Institucion Ins where Ins.IdEmpresa=1

select @a_idPersona_Erp = IdPersona_Erp from CAH.tb_persona_x_mg_persona where IdPersona_Academico = @i_id_persona

select @a_IdFamiliar =  aca.IdFamiliar from Aca_Familiar as aca
where IdPersona = @a_idPersona_Erp

 
set @a_IdDocumento_Bancario =@i_Id

select @a_IdParentesco_cat = IdCatalogo from Aca_Catalogo where IdCatalogo =  'REP_ECO'

select @a_Id_tipo_meca_pago = Id_tipo_meca_pago from Aca_Tipo_Mecanismo_Pago where Id_tipo_meca_pago = @i_id_tipo_mecanismo_pago

set @a_Numero_Documento = @i_numero

if(@i_fecha_caducidad is null)
set @a_Fecha_Expiracion = NULL
else 
set @a_Fecha_Expiracion = @i_fecha_caducidad


select @a_Id_tb_banco_x_mgbanco = Id_tb_banco_x_mgbanco from Aca_Tipo_Mecanismo_Pago where Id_tipo_meca_pago = @i_id_tipo_mecanismo_pago

select @a_IdBanco = IdBanco_Erp  from CAH.tb_banco_x_mg_banco where Id_tb_banco_x_mgbanco = @a_Id_tb_banco_x_mgbanco

if (@i_isActive = 1)
set @a_estado= 'True'
else
set @a_estado= 'False'

set @a_Observacion = 'Migracion Academico'
set @a_FechaCreacion =@i_fecha_transaccion
set @a_FechaModificacion =@i_fecha_modificacion	
set @a_UsuarioCreacion='sys_aca_mig'
set @a_UsuarioModificacion='sys_aca_mig'
if(@a_IdFamiliar is not null)
begin
if (@i_Operacion='INSERT')
	begin
		if not exists( SELECT docu.IdFamiliar FROM Aca_Documento_Bancario_x_Rep_Economico docu where docu.IdFamiliar = @a_IdFamiliar and docu.IdDocumento_Bancario = @a_IdDocumento_Bancario )
		begin
		INSERT INTO dbo.Aca_Documento_Bancario_x_Rep_Economico
					(
					 [IdInstitucion]        ,[IdFamiliar]                   ,[IdParentesco_cat]    ,[IdDocumento_Bancario]
					,[Id_tipo_meca_pago]	,[Id_tb_banco_x_mgbanco]		,[IdBanco] 	     	   ,[Numero_Documento]     
					,[Observacion]          ,[Fecha_Expiracion]             ,[IdUsuario] 	       ,[Fecha_Transac]	   
					,[IdUsuarioUltMod]      ,[Fecha_UltMod]                 ,[Estado]
					  	    		
					
					)
					values
					(
					 @a_IdInstitucion           ,@a_IdFamiliar             ,@a_IdParentesco_cat    ,@a_IdDocumento_Bancario
					,@a_Id_tipo_meca_pago	    ,@a_Id_tb_banco_x_mgbanco  ,@a_IdBanco             ,@a_Numero_Documento 
					,@a_Observacion             ,@a_Fecha_Expiracion       ,@a_UsuarioCreacion	   ,@a_FechaCreacion      
				    ,@a_UsuarioModificacion     ,@a_FechaModificacion      ,@a_estado
						    	  	
										
					)

		end
	end


if (@i_Operacion='UPDATE')
	begin

		update Aca_Documento_Bancario_x_Rep_Economico
			set 
			Id_tipo_meca_pago = @a_Id_tipo_meca_pago,
			Id_tb_banco_x_mgbanco = @a_Id_tb_banco_x_mgbanco,
			Fecha_Expiracion = @a_Fecha_Expiracion,
			estado = @a_estado,
			Numero_Documento = @a_Numero_Documento,				
			Fecha_UltMod=@a_FechaModificacion,
			IdUsuarioUltMod=@a_UsuarioModificacion
			where IdDocumento_Bancario = @a_IdDocumento_Bancario

	end

	end		

end