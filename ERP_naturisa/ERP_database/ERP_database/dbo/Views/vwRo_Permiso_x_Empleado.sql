CREATE VIEW dbo.vwRo_Permiso_x_Empleado
AS
SELECT        A.IdEmpresa, A.IdPermiso, A.Fecha, A.IdEmpleado, A.MotivoAusencia, A.FormaRecuperacion, A.IdEmpleado_Soli, A.IdEstadoAprob, A.IdEmpleado_Apro, 
                         A.MotivoAproba, A.Observacion, A.Estado, d.pe_nombreCompleto AS NomEmpleado, dbo.tb_persona.pe_nombreCompleto AS NomEmpleado_Aprobo, 
                         A.IdTipoLicencia, A.EsLicencia, A.EsPermiso, A.FechaSalida, A.FechaEntrada, A.TiempoAusencia, A.HoraRegreso, A.HoraSalida, A.HorasAtraso, A.LLegoAtrasado, 
                         A.MotivoAnulacion, dbo.tb_persona.pe_cedulaRuc, dbo.ro_cargo.ca_descripcion, dbo.ro_Departamento.de_descripcion, dbo.tb_persona.pe_apellido, 
                         dbo.tb_persona.pe_nombre, c.em_codigo, A.Id_Forma_descuento_permiso_Cat, A.Dias_tomados, A.IdNomina_Tipo
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_empleado AS B ON dbo.tb_persona.IdPersona = B.IdPersona INNER JOIN
                         dbo.ro_Departamento ON B.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND B.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_cargo ON B.IdCargo = dbo.ro_cargo.IdCargo AND B.IdEmpresa = dbo.ro_cargo.IdEmpresa RIGHT OUTER JOIN
                         dbo.ro_permiso_x_empleado AS A INNER JOIN
                         dbo.ro_empleado AS c INNER JOIN
                         dbo.tb_persona AS d ON c.IdPersona = d.IdPersona ON A.IdEmpleado = c.IdEmpleado AND A.IdEmpresa = c.IdEmpresa ON B.IdEmpleado = A.IdEmpleado AND 
                         B.IdEmpresa = A.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Permiso_x_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'    TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 31
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Permiso_x_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[29] 4[4] 2[4] 3) )"
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
         Left = -288
      End
      Begin Tables = 
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 99
               Left = 286
               Bottom = 326
               Right = 478
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 37
               Left = 1265
               Bottom = 286
               Right = 1530
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Departamento"
            Begin Extent = 
               Top = 150
               Left = 708
               Bottom = 382
               Right = 917
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 0
               Left = 496
               Bottom = 203
               Right = 705
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "A"
            Begin Extent = 
               Top = 0
               Left = 861
               Bottom = 342
               Right = 1045
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 74
               Left = 364
               Bottom = 442
               Right = 576
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 28
               Left = 423
               Bottom = 340
               Right = 615
            End
            DisplayFlags = 280
        ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Permiso_x_Empleado';

