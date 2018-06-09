CREATE proc [CAH].[spETL_Aca_Familiar_x_Estudiante_x_fa_cliente]
(
 @i_IdInstitucion	numeric
,@i_IdEstudiante	numeric
,@i_IdFamiliar		numeric
,@i_IdParentesco	varchar(35)
,@i_IdPersona		numeric
,@i_pe_correo varchar(100)
)
as 
begin

declare @w_IdEmpresa	numeric					-- NO NULL
declare @w_IdCliente	numeric					-- NO NULL
declare @w_Codigo	varchar(50)
declare @w_IdSucursal	int						-- NO NULL
declare @w_IdVendedor	int						-- NO NULL
declare @w_IdTipoCliente	int					-- NO NULL
declare @w_IdTipoCredido	varchar(3)
declare @w_cl_Cat_crediticia	char(1)			-- NO NULL
declare @w_cl_plazo		int
declare @w_cl_porcentaje_descuento	float
declare @w_IdCtaCble_cxc	varchar(20)
declare @w_IdCtaCble_Anti	varchar(20)
declare @w_cl_Cell_Garante	nvarchar(13)
declare @w_cl_Garante	varchar(100)
declare @w_cl_Mail_Garante	varchar(60)
declare @w_cl_observacion	varchar(130)
declare @w_IdCiudad		varchar(25)				-- NO NULL
declare @w_cl_Cupo		float					-- NO NULL
declare @w_IdClienteRelacionado		numeric
declare @w_cl_LocalComercial	nvarchar(500)
declare @w_cl_Rep_Legal		varchar(100)
declare @w_cl_Mail_Rep_Legal	varchar(60)
declare @w_cl_Cell_Rep_Legal	varchar(13)
declare @w_cl_Ger_Gen	varchar(100)
declare @w_cl_Mail_Ger_Gen		varchar(60)
declare @w_cl_Cell_Ger_Gen		varchar(13)
declare @w_cl_casilla	varchar(50)				--NO NULL
declare @w_cl_fax	varchar(50)					--NO NULL
declare @w_IdActividadComercial		varchar(15)
declare @w_IdUsuario	varchar(20)
declare @w_Fecha_Transac	datetime
declare @w_IdUsuarioUltMod	varchar(20)
declare @w_Fecha_UltMod		datetime
declare @w_IdUsuarioUltAnu	varchar(20)
declare @w_Fecha_UltAnu		datetime
declare @w_nom_pc		varchar(20)
declare @w_ip		varchar(25)
declare @w_Estado	char(1)
declare @w_Mail_Principal varchar(50)
declare @w_Mail_Secundario1 varchar(50)
declare @w_Mail_Secundario2 varchar(50)
declare @w_IdCentroCosto_CXC varchar(20)
declare @w_IdCentroCosto_Anticipo varchar(20)
declare @w_IdCentroCosto_CXC_Credito varchar(20)
declare @w_IdCtaCble_cxc_Credito varchar(20)
declare @w_IdParroquia varchar(25)
declare @w_es_empresa_relacionada bit

declare @w_observacion varchar(50)


select @w_IdEmpresa =
Ins.IdInstitucion from Aca_Institucion Ins where Ins.IdInstitucion=@i_IdInstitucion

-- set @w_IdCliente = 			-- NO NULL
set @w_Codigo = ''
set @w_IdSucursal = 1			-- NO NULL
set @w_IdVendedor = 1			-- NO NULL
set @w_IdTipoCliente = 1		-- NO NULL
set @w_IdTipoCredido = 'CRE'			-- NO NULL
set @w_cl_Cat_crediticia = 'A'			-- NO NULL
set @w_cl_plazo = 0 -- NO NULL
set @w_cl_porcentaje_descuento	= 0 
set @w_IdCtaCble_cxc = NULL
set @w_IdCtaCble_Anti = NULL
set @w_cl_Cell_Garante	=  ''
set @w_cl_Garante = ''
set @w_cl_Mail_Garante = ''
set @w_cl_observacion = ''		-- NO NULL
set @w_IdCiudad = '09'		-- NO NULL
set @w_cl_Cupo = 0			-- NO NULL
set @w_IdClienteRelacionado = 0
set @w_cl_LocalComercial = NULL
set @w_cl_Rep_Legal = ''
set @w_cl_Mail_Rep_Legal = ''
set @w_cl_Cell_Rep_Legal = ''
set @w_cl_Ger_Gen = ''
set @w_cl_Mail_Ger_Gen = ''
set @w_cl_Cell_Ger_Gen = ''
set @w_cl_casilla = ''								--NO NULL
set @w_cl_fax = ''									--NO NULL
set @w_IdActividadComercial	 = 'NORM'
set	@w_IdUsuario ='sys_mig_aca'						--NO NULL
set @w_Fecha_Transac = GETDATE()					--NO NULL
set @w_IdUsuarioUltMod ='sys_mig_aca'	
set @w_Fecha_UltMod = GETDATE()	
set @w_IdUsuarioUltAnu = NULL
set @w_Fecha_UltAnu = NULL
set @w_nom_pc = 'Desarrollo-ITCORP'					--NO NULL
set @w_ip =		'0.0.0.0'							--NO NULL
set @w_Estado	= 'A'					--NO NULL

----set @w_Mail_Principal = @i_pe_correo_secundario1	--NO NULL
set @w_Mail_Principal=isnull(@i_pe_correo,'')

set @w_Mail_Secundario2  = ''
set @w_IdCentroCosto_CXC = NULL
set @w_IdCentroCosto_Anticipo =  NULL
set @w_IdCentroCosto_CXC_Credito =  NULL
set @w_IdCtaCble_cxc_Credito =  NULL
set @w_IdParroquia  =  NULL
set @w_es_empresa_relacionada = 0

set @w_observacion = ''


			if not exists( SELECT IdCliente_cli FROM Aca_Familiar_x_Estudiante_x_fa_cliente estu where IdFamiliar_fa = @i_IdFamiliar )
			
			begin


					SELECT @w_IdCliente=isnull(max(cli.IdCliente),0)+1 
					FROM [dbo].[fa_cliente] cli where cli.IdEmpresa=@w_IdEmpresa
					set @w_Codigo = Convert(varchar(50),@w_IdCliente)

		
					INSERT INTO [dbo].[fa_cliente]
					(
						 [IdEmpresa]				,[IdCliente]				,[Codigo]						,[IdPersona]					,[IdSucursal]		
						,[IdVendedor]				,[Idtipo_cliente]			,[IdTipoCredito]				,[cl_Cat_crediticia]			,[cl_plazo]		
						,[cl_porcentaje_descuento]	,[IdCtaCble_cxc]			,[IdCtaCble_Anti]				,[cl_Cell_Garante]				,[cl_Garante]									
						,[cl_Mail_Garante]			,[cl_observacion]			,[IdCiudad]						,[cl_Cupo]						,[IdClienteRelacionado]	
						,[cl_LocalComercial]		,[cl_Rep_Legal]				,[cl_Mail_Rep_Legal]			,[cl_Cell_Rep_Legal]			,[cl_Ger_Gen]
						,[cl_Mail_Ger_Gen]			,[cl_Cell_Ger_Gen]			,[cl_casilla]					,[cl_fax]						,[IdActividadComercial]	
						,[IdUsuario]				,[Fecha_Transac]			,[IdUsuarioUltMod]				,[Fecha_UltAnu]					,[nom_pc] 
						,[ip]						,[Estado]					,[Mail_Principal]				,[Mail_Secundario1]				,[Mail_Secundario2]	
						,[IdCentroCosto_CXC]		,[IdCentroCosto_Anticipo]	,[IdCentroCosto_CXC_Credito]	,[IdCtaCble_cxc_Credito]		,[IdParroquia]				
						,[es_empresa_relacionada]  
					)
					VALUES
					(
						@w_IdEmpresa				,@w_IdCliente				,@w_Codigo						,@i_IdPersona					,@w_IdSucursal		
						,@w_IdVendedor				,@w_IdTipoCliente			,@w_IdTipoCredido				,@w_cl_Cat_crediticia			,@w_cl_plazo		
						,@w_cl_porcentaje_descuento	,@w_IdCtaCble_cxc			,@w_IdCtaCble_Anti				,@w_cl_Cell_Garante				,@w_cl_Garante								
						,@w_cl_Mail_Garante			,@w_cl_observacion			,@w_IdCiudad					,@w_cl_Cupo						,@w_IdClienteRelacionado	
						,@w_cl_LocalComercial		,@w_cl_Rep_Legal			,@w_cl_Mail_Rep_Legal			,@w_cl_Cell_Rep_Legal			,@w_cl_Ger_Gen
						,@w_cl_Mail_Ger_Gen			,@w_cl_Cell_Ger_Gen			,@w_cl_casilla					,@w_cl_fax						,@w_IdActividadComercial	
						,@w_IdUsuario				,@w_Fecha_Transac			,@w_IdUsuarioUltMod				,@w_Fecha_UltAnu				,@w_nom_pc 
						,@w_ip						,@w_Estado					,@w_Mail_Principal				,@w_Mail_Secundario1			,@w_Mail_Secundario2	
						,@w_IdCentroCosto_CXC		,@w_IdCentroCosto_Anticipo	,@w_IdCentroCosto_CXC_Credito	,@w_IdCtaCble_cxc_Credito		,@w_IdParroquia				
						,@w_es_empresa_relacionada  
					)


				 INSERT INTO [dbo].[Aca_Familiar_x_Estudiante_x_fa_cliente]
				   (
					[IdInstitucion_fa]				,[IdFamiliar_fa]	           ,[IdParentesco_cat_fa]
				   ,[IdEmpresa_cli]					,[IdCliente_cli]				,[observacion]
				   )
					VALUES
				   (
					@i_IdInstitucion				,@i_IdFamiliar					,@i_IdParentesco
					,@w_IdEmpresa					,@w_IdCliente					,'cliente nuevo '
				   ----,'INSERT - INSERT  SELECT @w_IdPersona=isnull(max(PER.IdPersona),0)+1 '
				   )


				   INSERT INTO CAH.[Aca_Familiar_x_Estudiante_x_fa_cliente_Auditoria]
				   (
					[IdInstitucion_fa]				,[IdFamiliar_fa]	           ,[IdParentesco_cat_fa]
				   ,[IdEmpresa_cli]					,[IdCliente_cli]				,[observacion]
				   )
					VALUES
				   (
					@i_IdInstitucion				,@i_IdFamiliar					,@i_IdParentesco
					,@w_IdEmpresa					,@w_IdCliente					,'cliente Nuevo con ID '+ Convert(varchar(50),@w_IdCliente)
				   )


					update fa_cliente 
					set IdCtaCble_cxc=fa_cliente_tipo.IdCtaCble_CXC_Con
					,IdCtaCble_Anti=fa_cliente_tipo.IdCtaCble_CXC_Anticipo
					,IdCtaCble_cxc_Credito=fa_cliente_tipo.IdCtaCble_CXC_Cred
					FROM            fa_cliente INNER JOIN
					fa_cliente_tipo ON fa_cliente.IdEmpresa = fa_cliente_tipo.IdEmpresa AND fa_cliente.Idtipo_cliente = fa_cliente_tipo.Idtipo_cliente
					where fa_cliente.IdEmpresa=@w_IdEmpresa
					and fa_cliente.IdCliente=@w_IdCliente


			 end


			else
				begin

				select @w_IdCliente = cli.IdCliente
						FROM fa_cliente cli where  IdPersona = @i_IdPersona


					INSERT INTO CAH.[Aca_Familiar_x_Estudiante_x_fa_cliente_Auditoria]
				   (
					[IdInstitucion_fa]				,[IdFamiliar_fa]	           ,[IdParentesco_cat_fa]
				   ,[IdEmpresa_cli]					,[IdCliente_cli]				,[observacion]
				   )
					VALUES
				   (
					@i_IdInstitucion				,@i_IdFamiliar					,@i_IdParentesco
					,@w_IdEmpresa					,@w_IdCliente					,'cliente con el ID '+ Convert(varchar(50),@w_IdCliente) + ' YA EXISTE'
				   ----,'INSERT - INSERT  SELECT @w_IdPersona=isnull(max(PER.IdPersona),0)+1 '
				   )
					
				end
end