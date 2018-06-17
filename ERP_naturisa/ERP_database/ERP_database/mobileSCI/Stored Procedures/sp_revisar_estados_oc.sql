CREATE PROCEDURE mobileSCI.sp_revisar_estados_oc
AS
BEGIN

UPDATE mobileSCI.tbl_movimientos_det SET Estado = 'P'
FROM(
SELECT det.IdEmpresa_oc, det.IdSucursal_oc, det.IdOrdenCompra, det.secuencia_oc, count(*) as cont
FROM mobileSCI.tbl_movimientos_det as det
where det.Estado = 'A' and det.Aprobado = 0 and IdEmpresa_oc is not null
group by det.IdEmpresa_oc, det.IdSucursal_oc, det.IdOrdenCompra, det.secuencia_oc
having count(*) > 1
) A
WHERE mobileSCI.tbl_movimientos_det.IdEmpresa_oc = A.IdEmpresa_oc
and mobileSCI.tbl_movimientos_det.IdSucursal_oc = a.IdSucursal_oc
and mobileSCI.tbl_movimientos_det.IdOrdenCompra = a.IdOrdenCompra
and mobileSCI.tbl_movimientos_det.secuencia_oc = a.secuencia_oc
and mobileSCI.tbl_movimientos_det.Estado = 'A' AND mobileSCI.tbl_movimientos_det.Aprobado = 0 
AND mobileSCI.tbl_movimientos_det.IdEmpresa_oc IS NOT NULL
END