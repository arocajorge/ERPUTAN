CREATE VIEW dbo.vwprd_Despacho
AS
SELECT     DESP.IdEmpresa, DESP.IdSucursal, DESP.CodObra, DESP.IdDespacho, DESP.IdCliente, DESP.NumDespacho, BOD.IdBodega, BOD.bo_Descripcion, DESP.FechaReg, 
                      DESP.PuntoPartida, DESP.PuntoLLegada, DESP.Chofer, DESP.Placa, DESP.Observacion, DESP.Estado, DESP.NumGuiaRemision, DESP.FechaIniTras, 
                      DESP.FechaFinTras, DESP.TipoTransporte, DESP.NumFactura, CLI.pe_nombreCompleto, SUC.Su_Descripcion, OB.Descripcion AS ob_descripcion, DESP.ruta
FROM         dbo.prd_Obra AS OB INNER JOIN
                      dbo.prd_Despacho AS DESP ON OB.IdEmpresa = DESP.IdEmpresa AND OB.CodObra = DESP.CodObra INNER JOIN
                      dbo.tb_sucursal AS SUC ON DESP.IdEmpresa = SUC.IdEmpresa AND DESP.IdSucursal = SUC.IdSucursal INNER JOIN
                      dbo.tb_bodega AS BOD ON DESP.IdEmpresa = BOD.IdEmpresa AND DESP.IdSucursal = BOD.IdSucursal AND DESP.IdBodega = BOD.IdBodega INNER JOIN
                      dbo.vwfa_cliente AS CLI ON OB.IdCliente = CLI.IdCliente AND DESP.IdEmpresa = CLI.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_Despacho';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_Despacho';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "OB"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DESP"
            Begin Extent = 
               Top = 3
               Left = 638
               Bottom = 252
               Right = 827
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SUC"
            Begin Extent = 
               Top = 114
               Left = 38
               Bottom = 222
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BOD"
            Begin Extent = 
               Top = 222
               Left = 38
               Bottom = 330
               Right = 286
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CLI"
            Begin Extent = 
               Top = 330
               Left = 38
               Bottom = 438
               Right = 256
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_Despacho';

