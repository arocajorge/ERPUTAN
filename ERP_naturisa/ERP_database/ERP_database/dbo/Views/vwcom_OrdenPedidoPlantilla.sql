CREATE VIEW vwcom_OrdenPedidoPlantilla
AS
SELECT dbo.com_OrdenPedidoPlantilla.IdEmpresa, dbo.com_OrdenPedidoPlantilla.IdPlantilla, dbo.com_OrdenPedidoPlantilla.op_Codigo, dbo.com_OrdenPedidoPlantilla.op_Observacion,  
                  dbo.com_OrdenPedidoPlantilla.Estado, dbo.com_OrdenPedidoPlantilla.EsCompraUrgente, dbo.ct_punto_cargo.nom_punto_cargo
FROM     dbo.com_OrdenPedidoPlantilla INNER JOIN
                  dbo.ct_punto_cargo ON dbo.com_OrdenPedidoPlantilla.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND dbo.com_OrdenPedidoPlantilla.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo