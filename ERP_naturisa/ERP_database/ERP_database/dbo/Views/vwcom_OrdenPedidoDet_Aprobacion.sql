CREATE VIEW [dbo].[vwcom_OrdenPedidoDet_Aprobacion]
AS
SELECT d.IdEmpresa, d.IdOrdenPedido, d.Secuencia, d.pr_descripcion, d.IdUnidadMedida, d.IdSucursalOrigen, d.IdSucursalDestino, d.IdPunto_cargo, d.opd_Cantidad, d.opd_CantidadApro, d.opd_EstadoProceso, d.opd_Detalle, 
                  p.IdUnidadMedida_Consumo, ISNULL(CAST(0 AS FLOAT), 0) AS Stock, s.nom_solicitante, d.IdProducto, dbo.com_solicitante_aprobador.IdUsuario, d.Adjunto, c.op_Observacion, c.op_Fecha, d.NombreArchivo
FROM     dbo.com_OrdenPedidoDet AS d INNER JOIN
                  dbo.com_OrdenPedido AS c ON c.IdEmpresa = d.IdEmpresa AND c.IdOrdenPedido = d.IdOrdenPedido INNER JOIN
                  dbo.com_solicitante AS s ON s.IdEmpresa = c.IdEmpresa AND s.IdSolicitante = c.IdSolicitante INNER JOIN
                  dbo.com_solicitante_aprobador ON c.IdEmpresa = dbo.com_solicitante_aprobador.IdEmpresa AND c.IdSolicitante = dbo.com_solicitante_aprobador.IdSolicitante AND 
                  c.IdDepartamento = dbo.com_solicitante_aprobador.IdDepartamento LEFT OUTER JOIN
                  dbo.in_Producto AS p ON p.IdEmpresa = d.IdEmpresa AND p.IdProducto = d.IdProducto
WHERE  (c.Estado = 1) and d.OPD_ESTADOPROCESO = 'P'
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDet_Aprobacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'le = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDet_Aprobacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[43] 4[18] 2[16] 3) )"
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
         Top = -360
         Left = 0
      End
      Begin Tables = 
         Begin Table = "d"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 410
               Right = 289
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 0
               Left = 447
               Bottom = 369
               Right = 679
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 272
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_solicitante_aprobador"
            Begin Extent = 
               Top = 0
               Left = 784
               Bottom = 227
               Right = 1005
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 377
               Left = 542
               Bottom = 540
               Right = 833
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Tab', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDet_Aprobacion';

