CREATE view [dbo].[vwFa_Producto_x_Pedidos]  
as  
select A.IdEmpresa ,A.IdSucursal ,A.IdBodega ,B.IdProducto ,sum(B.dp_cantidad) as pr_Pedidos  
from fa_pedido A,  fa_pedido_det  B  
where A.IdEmpresa =B.IdEmpresa   
and A.IdSucursal =B.IdSucursal   
and A.IdBodega =B.IdBodega   
and A.IdPedido =B.IdPedido   
and A.Estado ='A'  
and Entregado = 'N'
group by A.IdEmpresa ,A.IdSucursal ,A.IdBodega ,B.IdProducto