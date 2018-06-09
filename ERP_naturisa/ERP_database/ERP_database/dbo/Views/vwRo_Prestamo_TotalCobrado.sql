CREATE VIEW vwRo_Prestamo_TotalCobrado AS
SELECT        IdEmpresa, IdPrestamo, SUM(TotalCuota) AS TotalCobrado
FROM            dbo.ro_prestamo_detalle
WHERE        (Estado = 'A')
GROUP BY IdEmpresa, IdPrestamo, EstadoPago
HAVING        (EstadoPago = 'CAN') OR
                         (EstadoPago = 'ABO')