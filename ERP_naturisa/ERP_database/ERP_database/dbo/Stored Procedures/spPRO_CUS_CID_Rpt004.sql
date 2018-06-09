CREATE PROCEDURE [dbo].[spPRO_CUS_CID_Rpt004]  
(@i_IdEmpresa Int, 
@i_IdSucursal Int,
@i_IdOrdencompra Numeric(18,0),
 @i_IdUsuario varchar(20),
  @i_nom_pc varchar(50) ) 
 AS
 begin
  /*SP para reporteria del ERP creado desde la pantalla Administración de reporte*/ 
  delete tbPRO_CUS_CID_Rpt004 where IdUsuario = @i_IdUsuario and nom_pc = @i_nom_pc 
  
  insert into tbPRO_CUS_CID_Rpt004
  (IdEmpresa,IdUsuario,Fecha_Transac,nom_pc,IdSucursal,IdOrdenCompra,
   valorunitario,valortotal,ivaxreg,oc_fecha,pr_nombre,Solicitante,pr_descripcion,
  IdUnidadMedida ,  pesoxreg,   pr_peso,IdProducto,cantidad,Secuencia)
  select 
  cab.idempresa ,@i_IdUsuario ,GETDATE(),@i_nom_pc, cab.IdSucursal, cab.IdOrdenCompra , 
  (det.do_precioCompra -det.do_descuento) as valorunitario, det.do_subtotal as valortotal, 
  det.do_iva as ivaxreg,  cab.oc_fecha,cab.pr_nombre,cab.Solicitante,
   pro.pr_descripcion ,pro.IdUnidadMedida , (pro.pr_peso *det.do_Cantidad )as pesoxreg,
  pro.pr_peso, pro.IdProducto  , det.do_Cantidad as cantidad,det.Secuencia 
  from vwcom_ordencompra_local cab inner join com_ordencompra_local_det  det
on cab.IdEmpresa = det.IdEmpresa and cab.IdSucursal = det.IdSucursal 
and cab.IdOrdenCompra  = det.IdOrdenCompra 
inner join in_Producto pro
on pro.IdEmpresa = cab.IdEmpresa and det.IdProducto = pro.IdProducto  
where cab.IdEmpresa = @i_IdEmpresa and cab.IdSucursal = @i_IdSucursal and cab.IdOrdenCompra = @i_IdOrdencompra 
select * from tbPRO_CUS_CID_Rpt004 
 end