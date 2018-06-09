

CREATE PROCEDURE [dbo].[spROL_Rpt003]  
(

@IdEmpresa Int, 
@IdPrestamo numeric(18,0),
@IdNomina_Tipo int ,
@IdRubro varchar(10),
@IdEmpleado numeric(18,0),
@i_IdUsuario varchar(20),
@i_nom_pc varchar(50) 



 ) 
 AS 
 BEGIN 
 delete from tbROL_Rpt003 where IdUsuario = @i_IdUsuario and nom_pc = @i_nom_pc 
 
Insert into tbROL_Rpt003
--SELECT     
--dbo.vwRo_Prestamo.IdEmpresa,
-- dbo.vwRo_Prestamo.IdPrestamo, 
-- dbo.vwRo_Prestamo.IdNomina_Tipo, 
-- dbo.vwRo_Prestamo.nomi_descripcion, 
-- dbo.vwRo_Prestamo.IdEmpleado,
-- dbo.vwRo_Prestamo.pe_nombre,
-- dbo.vwRo_Prestamo.pe_apellido, 
-- dbo.vwRo_Prestamo.IdRubro, 
-- dbo.vwRo_Prestamo.ru_descripcion,
-- dbo.vwRo_Prestamo.IdEmpleado_Aprueba,
-- dbo.vwRo_Prestamo.pe_nombre_apru, 
-- dbo.vwRo_Prestamo.pe_apellido_apru, 
-- dbo.vwRo_Prestamo.Codigo, 
-- dbo.vwRo_Prestamo.ca_descripcion, 
-- dbo.vwRo_Prestamo.Estado, 
-- dbo.vwRo_Prestamo.Fecha, 
-- dbo.vwRo_Prestamo.MontoSol, 
-- dbo.vwRo_Prestamo.TasaInteres, 
-- dbo.vwRo_Prestamo.NumCuotas, 
-- dbo.vwRo_Prestamo.cod_pago, 
-- dbo.vwRo_Prestamo.peri_pago, 
-- dbo.vwRo_Prestamo.Fecha_PriPago,
-- dbo.vwRo_Prestamo.Observacion, 
-- dbo.vwRo_Prestamo.TotalPrestamo, 
-- dbo.vwRo_Prestamo.TotalCobrado, 
-- dbo.vwRo_Prestamo.SaldoPrestamo, 
 
-- dbo.ro_prestamo_detalle.NumCuota,
-- dbo.ro_prestamo_detalle.SaldoInicial, 
-- dbo.ro_prestamo_detalle.Interes, 
-- dbo.ro_prestamo_detalle.AbonoCapital,
-- dbo.ro_prestamo_detalle.TotalCuota, 
-- dbo.ro_prestamo_detalle.Saldo,
-- dbo.ro_prestamo_detalle.FechaPago, 
-- dbo.ro_prestamo_detalle.EstadoPago, 
-- dbo.ro_prestamo_detalle.Observacion_det, 
-- dbo.ro_prestamo_detalle.Estado AS Estado_Detalle, 
-- dbo.ro_prestamo_detalle.Fecha_Transac,
                      
--@i_IdUsuario,
--@i_nom_pc                        
                      
                      
--FROM         dbo.ro_prestamo_detalle INNER JOIN
-- dbo.vwRo_Prestamo ON dbo.ro_prestamo_detalle.IdEmpresa = dbo.vwRo_Prestamo.IdEmpresa AND 
-- dbo.ro_prestamo_detalle.IdPrestamo = dbo.vwRo_Prestamo.IdPrestamo 
 
-- where dbo.vwRo_Prestamo.IdEmpresa=@IdEmpresa 
-- and dbo.vwRo_Prestamo.IdPrestamo=@IdPrestamo
-- and dbo.vwRo_Prestamo.IdNomina_Tipo=@IdNomina_Tipo
-- and  dbo.vwRo_Prestamo.IdRubro=@IdRubro
-- and dbo.vwRo_Prestamo.IdEmpleado=@IdEmpleado
--order by ro_prestamo_detalle.NumCuota
SELECT     
cab.IdEmpresa,
 cab.IdPrestamo, 
 cab.IdNomina_Tipo, 
 cab.nomi_descripcion, 
 cab.IdEmpleado,
 cab.pe_nombre,
 cab.pe_apellido, 
 cab.IdRubro, 
 cab.ru_descripcion,
 cab.IdEmpleado_Aprueba,
 cab.pe_nombre_apru, 
 cab.pe_apellido_apru, 
 cab.Codigo, 
 cab.ca_descripcion, 
 cab.Estado, 
 cab.Fecha, 
 cab.MontoSol, 
 cab.TasaInteres, 
 cab.NumCuotas, 
 cab.cod_pago, 
 cab.peri_pago, 
 cab.Fecha_PriPago,
 cab.Observacion, 
 cab.TotalPrestamo, 
 cab.TotalCobrado, 
 cab.SaldoPrestamo, 
 
 det.NumCuota,
 det.SaldoInicial, 
 det.Interes, 
 det.AbonoCapital,
 det.TotalCuota, 
 det.Saldo,
 det.FechaPago, 
 det.EstadoPago, 
 det.Observacion_det, 
 det.Estado AS Estado_Detalle, 
 det.Fecha_Transac,
      
                      
@i_IdUsuario,
@i_nom_pc                   
  from vwRo_Prestamo cab inner join
  ro_prestamo_detalle det on
  cab.IdEmpresa = det.IdEmpresa 
  and cab.IdPrestamo = det.IdPrestamo  
where cab.IdEmpresa=@IdEmpresa 
 and cab.IdPrestamo=@IdPrestamo
 and cab.IdNomina_Tipo=@IdNomina_Tipo
 and  cab.IdRubro=@IdRubro
 and cab.IdEmpleado=@IdEmpleado
order by det.NumCuota

select * from tbROL_Rpt003 
 END