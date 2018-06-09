CREATE view vwfa_factura_subtotal_iva_0_totales
as
select  A.IdEmpresa,A.IdSucursal,A.IdBodega,A.IdCbteVta,sum(A.SubTotal_0) as SubTotal_0,sum(A.SubTotal_Iva)  as SubTotal_Iva
 from 
(
select A.IdEmpresa,A.IdSucursal,A.IdBodega,A.IdCbteVta,sum(A.vt_Subtotal) as SubTotal_Iva,null as SubTotal_0
from fa_factura_det A 
where vt_iva>0 group by  A.IdEmpresa,A.IdSucursal,A.IdBodega,A.IdCbteVta
union 
select A.IdEmpresa,A.IdSucursal,A.IdBodega,A.IdCbteVta,null as SubTotal_Iva,sum(A.vt_Subtotal) as SubTotal_0
from fa_factura_det A 
where vt_iva=0 and vt_Subtotal!=0 group by  A.IdEmpresa,A.IdSucursal,A.IdBodega,A.IdCbteVta
) A
group by  A.IdEmpresa,A.IdSucursal,A.IdBodega,A.IdCbteVta