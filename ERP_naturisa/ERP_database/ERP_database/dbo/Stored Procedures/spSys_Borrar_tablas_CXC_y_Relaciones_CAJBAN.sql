CREATE proc [dbo].[spSys_Borrar_tablas_CXC_y_Relaciones_CAJBAN]
(
@i_idempresa int
)
as

delete from cxc_cobro_x_ct_cbtecble where cxc_cobro_x_ct_cbtecble.cbr_IdEmpresa=@i_idempresa
delete from cxc_cobro_x_ct_cbtecble_x_Anulado where cxc_cobro_x_ct_cbtecble_x_Anulado.cbr_IdEmpresa=@i_idempresa
delete from cxc_cobro_x_caj_Caja_Movimiento  where cxc_cobro_x_caj_Caja_Movimiento.cbr_IdEmpresa=@i_idempresa
delete from cxc_cobro_x_EstadoCobro where cxc_cobro_x_EstadoCobro.IdEmpresa =@i_idempresa
delete from cxc_cobro_x_Anticipo_det where cxc_cobro_x_Anticipo_det.IdEmpresa=@i_idempresa
delete from cxc_cobro_x_Anticipo where cxc_cobro_x_Anticipo.IdEmpresa=@i_idempresa
delete from cxc_cobro_det where cxc_cobro_det.IdEmpresa=@i_idempresa
delete from cxc_cobro where cxc_cobro.IdEmpresa =@i_idempresa
delete from ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito  where ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mba_IdEmpresa=@i_idempresa
delete from caj_Caja_Movimiento_det_egre where caj_Caja_Movimiento_det_egre.IdEmpresa=@i_idempresa
delete from caj_Caja_Movimiento_det where caj_Caja_Movimiento_det.IdEmpresa=@i_idempresa
delete from caj_Caja_Movimiento where caj_Caja_Movimiento.IdEmpresa=@i_idempresa

declare @w_IdTipoCbteCble_MoviCaja_Ing int
declare @w_IdTipoCbteCble_MoviCaja_Egr int
declare @w_IdTipoCbteCble_MoviCaja_Egr_Anu int
declare @w_IdTipoCbteCble_MoviCaja_Ing_Anu int

select 
 @w_IdTipoCbteCble_MoviCaja_Ing=A.IdTipoCbteCble_MoviCaja_Ing
,@w_IdTipoCbteCble_MoviCaja_Egr=A.IdTipoCbteCble_MoviCaja_Egr 
,@w_IdTipoCbteCble_MoviCaja_Egr_Anu=A.IdTipoCbteCble_MoviCaja_Egr_Anu
,@w_IdTipoCbteCble_MoviCaja_Ing_Anu=A.IdTipoCbteCble_MoviCaja_Ing_Anu
from caj_parametro A
where A.IdEmpresa =@i_idempresa 
---================================================================================
---======================
delete from ct_cbtecble_det  
where IdEmpresa =@i_idempresa 
and IdTipoCbte in (@w_IdTipoCbteCble_MoviCaja_Ing,@w_IdTipoCbteCble_MoviCaja_Egr,@w_IdTipoCbteCble_MoviCaja_Egr_Anu,@w_IdTipoCbteCble_MoviCaja_Ing_Anu)

delete from ct_cbtecble 
where IdEmpresa =@i_idempresa 
and IdTipoCbte in (@w_IdTipoCbteCble_MoviCaja_Ing,@w_IdTipoCbteCble_MoviCaja_Egr,@w_IdTipoCbteCble_MoviCaja_Egr_Anu,@w_IdTipoCbteCble_MoviCaja_Ing_Anu)