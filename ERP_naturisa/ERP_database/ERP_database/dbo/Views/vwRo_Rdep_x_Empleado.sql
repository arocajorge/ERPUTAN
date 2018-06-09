CREATE VIEW [dbo].[vwRo_Rdep_x_Empleado]
AS
SELECT        dbo.ro_rdep.IdEmpresa, dbo.ro_rdep.IdEmpleado, dbo.ro_rdep.AnioFiscal, dbo.ro_rdep.Observacion, dbo.ro_rdep.Estado, dbo.ro_rdep.suelSal, 
                         dbo.ro_rdep.sobSuelComRemu, dbo.ro_rdep.partUtil, dbo.ro_rdep.intGrabGen, dbo.ro_rdep.impRentEmpl, dbo.ro_rdep.decimTer, dbo.ro_rdep.fondoReserva, 
                         dbo.ro_rdep.salarioDigno, dbo.ro_rdep.otrosIngRenGrav, dbo.ro_rdep.ingGravConEsteEmpl, dbo.ro_rdep.sisSalNet, dbo.ro_rdep.apoPerIess, 
                         dbo.ro_rdep.aporPerIessConOtrosEmpls, dbo.ro_rdep.deducVivienda, dbo.ro_rdep.deducSalud, dbo.ro_rdep.deducEduca, dbo.ro_rdep.deducAliement, 
                         dbo.ro_rdep.deducVestim, dbo.ro_rdep.exoDiscap, dbo.ro_rdep.exoTerEd, dbo.ro_rdep.basImp, dbo.ro_rdep.impRentCaus, dbo.ro_rdep.valRetAsuOtrosEmpls, 
                         dbo.ro_rdep.valImpAsuEsteEmpl, dbo.ro_rdep.valRet, dbo.ro_rdep.FechaIngresa, dbo.ro_rdep.UsuarioIngresa, dbo.ro_rdep.FechaModifica, 
                         dbo.ro_rdep.UsuarioModifica, dbo.vwro_empleadoXdepXcargo.cargo, dbo.vwro_empleadoXdepXcargo.departamento, 
                         dbo.vwro_empleadoXdepXcargo.em_estado AS EstadoEmpleado, dbo.vwro_empleadoXdepXcargo.Apellido, dbo.vwro_empleadoXdepXcargo.Nombre, 
                         dbo.vwro_empleadoXdepXcargo.em_status AS StatusEmpleado, dbo.vwro_empleadoXdepXcargo.NomCompleto, 
                         dbo.vwro_empleadoXdepXcargo.pe_cedulaRuc AS CedulaRuc, dbo.ro_rdep.decimCuar, dbo.ro_rdep.IdUsuarioUltAnu, dbo.ro_rdep.Fecha_UltAnu, 
                         dbo.ro_rdep.MotiAnula
FROM            dbo.vwro_empleadoXdepXcargo INNER JOIN
                         dbo.ro_rdep ON dbo.vwro_empleadoXdepXcargo.IdEmpresa = dbo.ro_rdep.IdEmpresa AND dbo.vwro_empleadoXdepXcargo.IdEmpleado = dbo.ro_rdep.IdEmpleado
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Rdep_x_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'egin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2520
         Alias = 1695
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Rdep_x_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[49] 4[28] 2[3] 3) )"
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
         Left = -192
      End
      Begin Tables = 
         Begin Table = "vwro_empleadoXdepXcargo"
            Begin Extent = 
               Top = 0
               Left = 56
               Bottom = 286
               Right = 345
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_rdep"
            Begin Extent = 
               Top = 25
               Left = 647
               Bottom = 255
               Right = 879
            End
            DisplayFlags = 280
            TopColumn = 28
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 47
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1965
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
   B', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Rdep_x_Empleado';

