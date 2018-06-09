CREATE VIEW [dbo].[vwFa_Pedido_det_x_orden_desp_conSaldo]
AS
SELECT     IdEmpresa, IdSucursal, IdBodega, IdPedido, Secuencial, IdProducto, dp_cantidad, 0 AS od_cantidad, dp_cantidad AS pd_saldo, 
                      'pedidos sin orden de despacho' AS detelleSys
FROM         fa_pedido_det
WHERE     (CAST(IdEmpresa AS varchar(20)) + CAST(IdSucursal AS varchar(20)) + cast(IdBodega AS varchar(20)) + CAST(IdPedido AS varchar(20)) 
                      + CAST(Secuencial AS varchar(20)) + CAST(IdProducto AS varchar(20))) NOT IN
                          (SELECT     cast(A.pe_IdEmpresa AS varchar(20)) + cast(A.pe_IdSucursal AS varchar(20)) + cast(A.pe_IdBodega AS varchar(20)) + cast(A.pe_IdPedido AS varchar(20)) 
                                                   + CAST(A.pe_Secuencia AS varchar(20)) + CAST(A.pe_IdProducto AS varchar(20))
                            FROM          fa_orden_Desp_det_x_fa_pedido_det A)

UNION

SELECT     B.IdEmpresa, B.IdSucursal, B.IdBodega, B.IdPedido, B.Secuencial, B.IdProducto
, AVG(B.dp_cantidad) AS dp_cantidad, SUM(C.od_cantidad) AS od_cantidad, 
AVG(B.dp_cantidad) - SUM(C.od_cantidad) AS pd_saldo, 'pedidos con OD y Saldo ' AS detalle
FROM         fa_orden_Desp_det_x_fa_pedido_det AS A ,
                      fa_pedido_det AS B ,fa_orden_Desp_det AS C 
where  A.pe_IdEmpresa = B.IdEmpresa 
AND A.pe_IdSucursal = B.IdSucursal 
AND A.pe_IdBodega = B.IdBodega 
AND A.pe_IdPedido = B.IdPedido 
AND A.pe_Secuencia =B.Secuencial
and A.pe_IdProducto =B.IdProducto 
and A.od_IdEmpresa = C.IdEmpresa 
AND A.od_IdSucursal = C.IdSucursal 
AND A.od_IdBodega = C.IdBodega 
AND A.od_IdOrdenDespacho = C.IdOrdenDespacho 
AND A.od_Secuencia = C.Secuencia
and A.od_IdProducto =C.IdProducto 
GROUP BY B.IdEmpresa, B.IdSucursal, B.IdBodega, B.IdPedido, B.Secuencial, B.IdProducto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwFa_Pedido_det_x_orden_desp_conSaldo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[25] 4[5] 2[52] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwFa_Pedido_det_x_orden_desp_conSaldo';

