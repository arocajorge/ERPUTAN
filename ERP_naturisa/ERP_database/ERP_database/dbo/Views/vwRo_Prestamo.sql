
CREATE view [dbo].[vwRo_Prestamo] as 

SELECT        A.IdEmpresa, A.IdPrestamo, K.IdNomina_Tipo, K.Descripcion AS nomi_descripcion, A.IdEmpleado, D.pe_nombre, D.pe_apellido, A.IdRubro, F.ru_descripcion, A.IdEmpleado_Aprueba, 
                         H.pe_nombre AS pe_nombre_apru, H.pe_apellido AS pe_apellido_apru, I.Codigo, I.ca_descripcion, A.Estado, A.Fecha, A.MontoSol, A.TasaInteres, A.NumCuotas, J.Codigo AS cod_pago, 
                         J.ca_descripcion AS peri_pago, A.Fecha_PriPago, A.Observacion, SUM(E.TotalCuota) AS TotalPrestamo, ISNULL(AVG(C.TotalCobrado), 0) AS TotalCobrado, ISNULL(SUM(E.TotalCuota) - AVG(C.TotalCobrado), 0) 
                         AS SaldoPrestamo, A.Tipo_Calculo, A.MotiAnula, D.pe_cedulaRuc, A.IdNominaTipoLiqui, D.IdTipoPersona, D.IdPersona
FROM            dbo.ro_prestamo AS A INNER JOIN
                         dbo.ro_prestamo_detalle AS E ON A.IdEmpresa = E.IdEmpresa AND A.IdPrestamo = E.IdPrestamo INNER JOIN
                         dbo.ro_empleado AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdEmpleado = B.IdEmpleado INNER JOIN
                         dbo.tb_persona AS D ON B.IdPersona = D.IdPersona INNER JOIN
                         dbo.ro_rubro_tipo AS F ON A.IdRubro = F.IdRubro INNER JOIN
                         dbo.ro_empleado AS G ON A.IdEmpleado_Aprueba = G.IdEmpleado AND A.IdEmpresa = G.IdEmpresa INNER JOIN
                         dbo.tb_persona AS H ON G.IdPersona = H.IdPersona INNER JOIN
                         dbo.vwRo_MotivoPrestamo AS I ON A.IdMotivo_Prestamo = I.Codigo INNER JOIN
                         dbo.vwRo_PeriocidadPago AS J ON A.IdTipo_Pago = J.Codigo INNER JOIN
                         dbo.ro_Nomina_Tipo AS K ON A.IdNomina_Tipo = K.IdNomina_Tipo AND A.IdEmpresa = K.IdEmpresa LEFT OUTER JOIN
                         dbo.vwRo_Prestamo_TotalCobrado AS C ON A.IdEmpresa = C.IdEmpresa AND A.IdPrestamo = C.IdPrestamo
GROUP BY A.IdEmpresa, A.IdPrestamo, K.IdNomina_Tipo, K.Descripcion, A.IdEmpleado, D.pe_nombre, D.pe_apellido, A.IdRubro, F.ru_descripcion, A.IdEmpleado_Aprueba, H.pe_nombre, H.pe_apellido, I.Codigo, 
                         I.ca_descripcion, A.Estado, A.Fecha, A.MontoSol, A.TasaInteres, A.NumCuotas, J.Codigo, J.ca_descripcion, A.Fecha_PriPago, A.Observacion, A.Tipo_Calculo, A.MotiAnula, D.pe_cedulaRuc, A.IdNominaTipoLiqui, 
                         D.IdTipoPersona, D.IdPersona
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Prestamo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       Begin Table = "I"
            Begin Extent = 
               Top = 486
               Left = 284
               Bottom = 605
               Right = 462
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "J"
            Begin Extent = 
               Top = 606
               Left = 38
               Bottom = 725
               Right = 216
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "K"
            Begin Extent = 
               Top = 606
               Left = 254
               Bottom = 725
               Right = 440
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 726
               Left = 38
               Bottom = 830
               Right = 214
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
      Begin ColumnWidths = 28
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
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Prestamo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[65] 4[4] 2[12] 3) )"
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
               Bottom = 343
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "E"
            Begin Extent = 
               Top = 0
               Left = 500
               Bottom = 119
               Right = 687
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 49
               Left = 317
               Bottom = 168
               Right = 545
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 133
               Left = 357
               Bottom = 252
               Right = 565
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "F"
            Begin Extent = 
               Top = 93
               Left = 528
               Bottom = 212
               Right = 715
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "G"
            Begin Extent = 
               Top = 366
               Left = 38
               Bottom = 485
               Right = 266
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "H"
            Begin Extent = 
               Top = 486
               Left = 38
               Bottom = 605
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
  ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Prestamo';

