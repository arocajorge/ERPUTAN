
CREATE VIEW [dbo].[vwROL_Rpt007]
AS
SELECT        dbo.ro_Acta_Finiquito.IdEmpresa, dbo.ro_Acta_Finiquito.IdActaFiniquito, dbo.ro_Acta_Finiquito.IdEmpleado, dbo.ro_Acta_Finiquito.IdCausaTerminacion, 
                         dbo.ro_Acta_Finiquito.IdContrato, dbo.ro_Acta_Finiquito.FechaIngreso, dbo.ro_Acta_Finiquito.FechaSalida, dbo.ro_Acta_Finiquito.UltimaRemuneracion, 
                         dbo.ro_Acta_Finiquito.Observacion, dbo.ro_Acta_Finiquito.Ingresos, dbo.ro_Acta_Finiquito.Egresos, dbo.ro_Acta_Finiquito.EsMujerEmbarazada, 
                         dbo.ro_Acta_Finiquito.EsDirigenteSindical, dbo.ro_Acta_Finiquito.EsPorDiscapacidad, dbo.ro_Acta_Finiquito.EsPorEnfermedadNoProfesional, 
                         dbo.vwro_empleadoXdepXcargo.pe_cedulaRuc, dbo.vwro_empleadoXdepXcargo.NomCompleto, dbo.ro_Acta_Finiquito_Detalle.IdSecuencia, 
                         dbo.ro_Acta_Finiquito_Detalle.Observacion AS DescripcionDetalle, dbo.ro_Acta_Finiquito_Detalle.Signo, dbo.ro_Acta_Finiquito_Detalle.Valor, 
                         dbo.ro_Acta_Finiquito.IdCargo, dbo.ro_cargo.ca_descripcion AS DescripcionCargo, dbo.ro_contrato.NumDocumento, dbo.ro_empleado_x_centro_costo.IdCentroCosto,
                          dbo.ct_centro_costo.Centro_costo, dbo.vwro_empleadoXdepXcargo.em_codigo AS CodigoEmpleado
FROM            dbo.ct_centro_costo INNER JOIN
                         dbo.ro_empleado_x_centro_costo ON dbo.ct_centro_costo.IdEmpresa = dbo.ro_empleado_x_centro_costo.IdEmpresa AND 
                         dbo.ct_centro_costo.IdCentroCosto = dbo.ro_empleado_x_centro_costo.IdCentroCosto INNER JOIN
                         dbo.ro_Acta_Finiquito INNER JOIN
                         dbo.ro_Acta_Finiquito_Detalle ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.ro_Acta_Finiquito_Detalle.IdEmpresa AND 
                         dbo.ro_Acta_Finiquito.IdActaFiniquito = dbo.ro_Acta_Finiquito_Detalle.IdActaFiniquito AND 
                         dbo.ro_Acta_Finiquito.IdEmpleado = dbo.ro_Acta_Finiquito_Detalle.IdEmpleado INNER JOIN
                         dbo.vwro_empleadoXdepXcargo ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.vwro_empleadoXdepXcargo.IdEmpresa AND 
                         dbo.ro_Acta_Finiquito.IdEmpleado = dbo.vwro_empleadoXdepXcargo.IdEmpleado INNER JOIN
                         dbo.ro_cargo ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_Acta_Finiquito.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_contrato ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.ro_contrato.IdEmpresa AND dbo.ro_Acta_Finiquito.IdEmpleado = dbo.ro_contrato.IdEmpleado AND 
                         dbo.ro_Acta_Finiquito.IdContrato = dbo.ro_contrato.IdContrato ON dbo.ro_empleado_x_centro_costo.IdEmpresa = dbo.vwro_empleadoXdepXcargo.IdEmpresa AND 
                         dbo.ro_empleado_x_centro_costo.IdEmpleado = dbo.vwro_empleadoXdepXcargo.IdEmpleado
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt007';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'            Right = 1025
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
      Begin ColumnWidths = 27
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
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1845
         Alias = 3750
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt007';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[62] 4[7] 2[7] 3) )"
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
         Begin Table = "ro_Acta_Finiquito"
            Begin Extent = 
               Top = 0
               Left = 438
               Bottom = 197
               Right = 695
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ro_Acta_Finiquito_Detalle"
            Begin Extent = 
               Top = 231
               Left = 445
               Bottom = 428
               Right = 654
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "vwro_empleadoXdepXcargo"
            Begin Extent = 
               Top = 0
               Left = 745
               Bottom = 129
               Right = 1034
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 7
               Left = 0
               Bottom = 173
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_contrato"
            Begin Extent = 
               Top = 83
               Left = 225
               Bottom = 324
               Right = 434
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_centro_costo"
            Begin Extent = 
               Top = 2
               Left = 1052
               Bottom = 180
               Right = 1315
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 159
               Left = 816
               Bottom = 288
   ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt007';

