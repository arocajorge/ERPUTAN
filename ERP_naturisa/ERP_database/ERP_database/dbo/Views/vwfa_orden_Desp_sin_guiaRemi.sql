CREATE VIEW [dbo].[vwfa_orden_Desp_sin_guiaRemi]
AS
SELECT     A.IdEmpresa, A.IdSucursal, A.IdBodega, A.IdOrdenDespacho, A.CodOrdenDespacho, A.IdCliente, A.IdVendedor, A.IdTransportista, A.od_fecha, A.od_plazo, 
                      A.od_fech_venc, A.od_Observacion, A.od_TotalKilos, A.od_TotalQuintales, A.IdUsuario, A.Fecha_Transac, A.IdUsuarioUltMod, A.Fecha_UltMod, A.IdUsuarioUltAnu, 
                      A.Fecha_UltAnu, A.MotivoAnu, A.nom_pc, A.ip, A.Estado, A.od_DespAbierto
FROM         dbo.fa_orden_Desp AS A INNER JOIN
                      dbo.fa_orden_Desp_det AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdSucursal = B.IdSucursal AND A.IdBodega = B.IdBodega AND 
                      A.IdOrdenDespacho = B.IdOrdenDespacho
WHERE     ((CAST(B.IdEmpresa AS varchar(20)) + CAST(B.IdSucursal AS varchar(20)) + CAST(B.IdBodega AS varchar(20)) + CAST(B.IdOrdenDespacho AS varchar(20)) 
                      + CAST(B.Secuencia AS varchar(20))) NOT IN
                          (SELECT     CAST(od_IdEmpresa AS varchar(20)) + CAST(od_IdSucursal AS varchar(20)) + CAST(od_IdBodega AS varchar(20)) 
                                                   + CAST(od_IdOrdenDespacho AS varchar(20)) + CAST(od_Secuencia AS varchar(20)) AS Expr1
                            FROM          dbo.fa_guia_remision_det_x_fa_orden_Desp_det))
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_orden_Desp_sin_guiaRemi';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[16] 4[4] 2[62] 3) )"
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
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 219
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 6
               Left = 252
               Bottom = 114
               Right = 426
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
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_orden_Desp_sin_guiaRemi';

