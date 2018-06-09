-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE  PROCEDURE [dbo].[spPrd_IniciarInven_xPruebasxProduccion_CusCider] 
	@i_Empresa int
AS
BEGIN
	delete from prd_Despacho_cusCidersus_x_in_movi_inven  where IdEmpresa = @i_Empresa 
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
	
END