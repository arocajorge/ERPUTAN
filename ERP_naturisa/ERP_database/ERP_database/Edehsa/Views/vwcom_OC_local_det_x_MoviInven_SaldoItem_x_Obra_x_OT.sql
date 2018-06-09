CREATE VIEW Edehsa.vwcom_OC_local_det_x_MoviInven_SaldoItem_x_Obra_x_OT
AS
SELECT     dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.IdEmpresa, dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.IdSucursal, 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.IdOrdenCompra, dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.Secuencia, 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.IdProducto, dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.do_CantidadOC, 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.dm_cantidad_Inv, dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.SaldoxRecibir, 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.pr_nombre, dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.IdProveedor, 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.Estado, dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.oc_fecha, 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.oc_NumDocumento, dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.oc_observacion, 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.Solicitante, dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.MotivoAnulacion, 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.MotivoReprobacion, dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.co_fechaReproba, 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.IdUsuario_Reprue, dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.IdUsuario_Aprueba, 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.co_fecha_aprobacion, 
                      Edehsa.vwcom_ListadoMateriales_x_OC_x_Obra_x_OT.CodObra AS CodObra_preasignada, 
                      Edehsa.vwcom_ListadoMateriales_x_OC_x_Obra_x_OT.IdOrdenTaller AS IdOrdenTaller_preasignada
FROM         dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem INNER JOIN
                      Edehsa.vwcom_ListadoMateriales_x_OC_x_Obra_x_OT ON 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.IdEmpresa = Edehsa.vwcom_ListadoMateriales_x_OC_x_Obra_x_OT.IdEmpresa AND 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.IdSucursal = Edehsa.vwcom_ListadoMateriales_x_OC_x_Obra_x_OT.IdSucursal AND 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.IdOrdenCompra = Edehsa.vwcom_ListadoMateriales_x_OC_x_Obra_x_OT.IdOrdenCompra AND 
                      dbo.vwcom_ordencompra_local_det_x_MoviInven_SaldoItem.IdProducto = Edehsa.vwcom_ListadoMateriales_x_OC_x_Obra_x_OT.Idproducto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_OC_local_det_x_MoviInven_SaldoItem_x_Obra_x_OT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[14] 2[13] 3) )"
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
         Begin Table = "vwcom_ordencompra_local_det_x_MoviInven_SaldoItem"
            Begin Extent = 
               Top = 0
               Left = 1
               Bottom = 198
               Right = 386
            End
            DisplayFlags = 280
            TopColumn = 11
         End
         Begin Table = "vwcom_ListadoMateriales_x_OC_x_Obra_x_OT (Edehsa)"
            Begin Extent = 
               Top = 8
               Left = 665
               Bottom = 209
               Right = 854
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
      Begin ColumnWidths = 25
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_OC_local_det_x_MoviInven_SaldoItem_x_Obra_x_OT';

