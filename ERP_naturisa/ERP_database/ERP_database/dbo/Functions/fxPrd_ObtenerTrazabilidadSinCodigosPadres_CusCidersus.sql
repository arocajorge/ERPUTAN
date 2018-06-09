CREATE FUNCTION [dbo].[fxPrd_ObtenerTrazabilidadSinCodigosPadres_CusCidersus] 
(@codBarra varchar(max)  )
RETURNS TABLE
AS
RETURN 
(
   
   select  * from 
(select * from in_movi_inve_detalle_x_Producto_CusCider where CodigoBarra = @codBarra
union
select * from in_movi_inve_detalle_x_Producto_CusCider where CodigoBarra 
in (select CodBarraProducto  from prd_Conversion_CusCidersus where CodBarraProducto = @codBarra )
union
select * from in_movi_inve_detalle_x_Producto_CusCider where CodigoBarra 
in(select CodBarra from prd_Conversion_det_CusCidersus 
where IdConversion = (select IdConversion from prd_Conversion_CusCidersus where CodBarraProducto = @codBarra ) or CodBarra = @codBarra)
union 
select * from in_movi_inve_detalle_x_Producto_CusCider where CodigoBarra 
in(select CodBarraProducto  from prd_Conversion_CusCidersus where IdConversion =
( select IdConversion from prd_Conversion_det_CusCidersus where CodBarra=@codBarra ) )
union
select * from in_movi_inve_detalle_x_Producto_CusCider where CodigoBarra in(
select CodigoBarra from (select * from vwprd_Ensamblado_CabDet_CusCider where CodigoBarra = @codBarra or CBMaestro = @codBarra
union
select * from vwprd_Ensamblado_CabDet_CusCider where IdEnsamblado in (select IdEnsamblado from vwprd_Ensamblado_CabDet_CusCider where CodigoBarra = @codBarra or CBMaestro = @codBarra))
as TEMPO)
or CodigoBarra 
in(
select CBMaestro from (select * from vwprd_Ensamblado_CabDet_CusCider where CodigoBarra = @codBarra or CBMaestro = @codBarra
union
select * from vwprd_Ensamblado_CabDet_CusCider where IdEnsamblado in (select IdEnsamblado from vwprd_Ensamblado_CabDet_CusCider where CodigoBarra = @codBarra or CBMaestro = @codBarra)
)
as TEMPO)) as TODO

   
);