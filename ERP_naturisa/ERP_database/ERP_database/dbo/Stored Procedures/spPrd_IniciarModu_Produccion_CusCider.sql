

-- =============================================
-- Author:		Luis Yanza
-- Create date: 27-jun-2013
-- Description:	Iniciar modulo Produccion Cidersus
-- =============================================

-- exec spPrd_IniciarModu_Produccion 6

CREATE  PROCEDURE [dbo].[spPrd_IniciarModu_Produccion_CusCider] 
	@i_Empresa int 
AS
BEGIN
	
	delete from prd_DespachoDet where IdEmpresa =@i_Empresa
	delete from prd_Despacho where IdEmpresa =@i_Empresa

	delete from prd_MovPteGrua_Det  where IdEmpresa =@i_Empresa
	delete from prd_MovPteGrua  where IdEmpresa =@i_Empresa
	
	
	delete prd_ControlInventarioProd where IdEmpresa =@i_Empresa
	delete from prd_ControlProduccion_Obrero_x_in_movi_inve where cp_idempresa=@i_Empresa
	delete from prd_ControlProduccion_Obrero_Det where IdEmpresa =@i_Empresa
	delete from prd_ControlProduccion_Obrero where IdEmpresa =@i_Empresa
	
	delete from prd_conversion_cusCidersus_x_in_movi_inven where IdEmpresa =@i_Empresa
	delete from prd_Conversion_det_CusCidersus where IdEmpresa =@i_Empresa
	delete from prd_Conversion_CusCidersus where IdEmpresa =@i_Empresa
	
	
	delete from prd_ensamblado_cusCider_x_in_movi_inven where IdEmpresa =@i_Empresa
	delete from prd_Ensamblado_Det_CusCider where IdEmpresa =@i_Empresa
	delete from prd_Ensamblado_CusCider where IdEmpresa =@i_Empresa
	
	delete from dbo.in_movi_inve_detalle_x_com_ordencompra_local_det  where mi_IdEmpresa =@i_Empresa
	
	
	
	
	
	DELETE FROM in_movi_inven_x_in_movi_inven_CusCidersus  where idempresa1  =@i_Empresa

	delete from in_movi_inve_detalle_x_Producto_CusCider where IdEmpresa =@i_Empresa
	delete from in_movi_inve_detalle where IdEmpresa =@i_Empresa
	delete from in_movi_inve where IdEmpresa =@i_Empresa
	
	
	
	
	delete from dbo.com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider where goc_IdEmpresa =@i_Empresa
	delete from dbo.com_GenerOCompra_Det where IdEmpresa =@i_Empresa
	delete from dbo.com_GenerOCompra where IdEmpresa =@i_Empresa
		delete from com_ordencompra_local_det where IdEmpresa =@i_Empresa
	delete from com_ordencompra_local where IdEmpresa =@i_Empresa
	delete from dbo.com_ListadoMateriales_Det_x_com_GenerOCompra_Det where go_IdEmpresa  =@i_Empresa
	delete from dbo.com_ListadoMateriales_Det where IdEmpresa =@i_Empresa
	delete from dbo.com_ListadoMateriales where IdEmpresa =@i_Empresa
	
		
	delete from prd_GrupoTrabajo_Det where IdEmpresa =@i_Empresa
	delete from prd_GrupoTrabajo where IdEmpresa =@i_Empresa
		
		
	delete from prd_Orden_Taller where IdEmpresa =@i_Empresa
	delete from prd_EtapaProduccion where IdEmpresa =@i_Empresa
	delete from prd_ProcesoProductivo_x_prd_obra where IdEmpresa_Pr  =@i_Empresa
	delete from prd_ProcesoProductivo where IdEmpresa =@i_Empresa
	delete from prd_Obra where IdEmpresa = @i_Empresa 
	delete from in_movi_inven_tipo_x_tb_bodega where IdEmpresa = @i_Empresa 
	delete from in_producto_x_tb_bodega where IdEmpresa = @i_Empresa 
	delete from in_movi_inven_tipo where IdEmpresa = @i_Empresa 
	delete from tb_bodega where IdEmpresa = @i_Empresa 
	delete from tb_sucursal where IdEmpresa = @i_Empresa 
	delete from prd_parametros_CusCidersus where IdEmpresa = @i_Empresa 
	
	
	
	
	
	
	
END