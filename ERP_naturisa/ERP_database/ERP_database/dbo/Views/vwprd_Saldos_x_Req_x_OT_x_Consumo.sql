
CREATE VIEW [dbo].[vwprd_Saldos_x_Req_x_OT_x_Consumo]
AS
SELECT     Ped.IdTransaccion, Ped.IdDetTrans, Ped.IdProveedor, Ped.Codigo, Ped.IdEmpresa AS ped_IdEmp, Ped.IdSucursal AS ped_IdSuc, Ped.CodObra AS ped_codobra, 
                      Ped.IdOrdenTaller AS ped_IdOT, Ped.IdProducto AS ped_IdProducto, Ped.IdListadoMateriales, Ped.IdDetalle, Ped.oc_IdEmpresa, Ped.oc_IdOrdenCompra, 
                      Ped.IdEstadoAprob, Ped.oc_NumDocumento, Ped.EstadoRecepcion, Ent.IdEmpresa, Ent.IdBodega, Ent.IdMovi_inven_tipo, Ent.IdSucursal, Ent.IdNumMovi, 
                      Ent.Secuencia, Ent.mv_tipo_movi, Ent.IdProducto, Ent.ot_IdEmpresa, Ent.ot_IdSucursal, Ent.ot_CodObra, Ent.ot_IdOrdenTaller, Ped.Cantidad + Ent.cantidad AS saldo, 
                      Ped.Cantidad AS ped_saldo, Ent.cantidad AS ent_saldo
FROM         dbo.vwprd_Saldos_Requerimientos_x_OT AS Ped LEFT OUTER JOIN
                      dbo.vwIn_Movi_Inven_Asig_Saldo_x_OT_CusCider AS Ent ON Ped.CodObra = Ent.ot_CodObra AND Ped.IdOrdenTaller = Ent.ot_IdOrdenTaller AND 
                      Ped.IdSucursal = Ent.ot_IdSucursal AND Ped.IdEmpresa = Ent.ot_IdEmpresa AND Ped.IdProducto = Ent.IdProducto