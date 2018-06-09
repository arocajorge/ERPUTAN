CREATE VIEW Edehsa.vwcom_AllListDetMateriales_PreAsignado_a_Obra
AS
SELECT Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.IdEmpresa, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.IdSucursal, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.IdBodega, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.IdProducto, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.IdMovi_inven_tipo, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.CodigoBarra, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.dm_cantidad, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.mv_tipo_movi, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.Fecha_Transac, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.cm_fecha, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.pr_codigo, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.pr_descripcion, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.bodega, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.observacion, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.dm_precio, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.mv_costo, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.longitud, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.espesor, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.ancho, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.alto, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.ceja, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.diametro, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.descripcion_corta, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.densidad, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.Secuencia, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.mv_Secuencia, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.dm_observacion, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.IdNumMovi, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.ot_CodObra, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.ot_IdOrdenTaller, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.pr_peso, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.PesoEspecifico, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.secmax, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.largo_conversion, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.alto_conversion, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.cantidad, 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.CodObra_preasignada, Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.IdOrdenTaller_preasignada, 
                  dbo.prd_Obra.Descripcion AS Obra
FROM     Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov INNER JOIN
                  dbo.prd_Obra ON Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.IdEmpresa = dbo.prd_Obra.IdEmpresa AND 
                  Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.CodObra_preasignada = dbo.prd_Obra.CodObra
WHERE  (Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.CodObra_preasignada IS NOT NULL) AND (Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.mv_tipo_movi = N'+') AND 
                  (Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov.ot_CodObra IS NULL)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetMateriales_PreAsignado_a_Obra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'   Append = 1400
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
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetMateriales_PreAsignado_a_Obra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[11] 2[30] 3) )"
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
         Begin Table = "vwin_movi_inve_detalle_x_Producto_CusCider_UltMov (Edehsa)"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 317
               Right = 479
            End
            DisplayFlags = 280
            TopColumn = 19
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 0
               Left = 549
               Bottom = 317
               Right = 793
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
      Begin ColumnWidths = 39
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 3336
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
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
         Table = 1170
         Output = 720
      ', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetMateriales_PreAsignado_a_Obra';

