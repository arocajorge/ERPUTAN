CREATE VIEW [dbo].[vwro_Ing_Egre_x_Empleado]
AS
SELECT     dbo.ro_Ing_Egre_x_Empleado.IdEmpresa, dbo.ro_Ing_Egre_x_Empleado.IdEmpleado, dbo.ro_Ing_Egre_x_Empleado.IdNomina_Tipo, 
                      dbo.ro_Ing_Egre_x_Empleado.IdNomina_TipoLiqui, dbo.ro_Ing_Egre_x_Empleado.IdPeriodo, dbo.ro_Ing_Egre_x_Empleado.IdRubro, 
                      dbo.ro_Ing_Egre_x_Empleado.IdNovedad, dbo.ro_Ing_Egre_x_Empleado.SecuenciaNovedad, dbo.ro_Ing_Egre_x_Empleado.IdPrestamo, 
                      dbo.ro_Ing_Egre_x_Empleado.NunCouta, dbo.ro_Ing_Egre_x_Empleado.IngEgr, dbo.ro_Ing_Egre_x_Empleado.Valor, dbo.ro_Ing_Egre_x_Empleado.iAnio, 
                      dbo.ro_Ing_Egre_x_Empleado.iMes, dbo.ro_Ing_Egre_x_Empleado.cerrado, dbo.ro_Ing_Egre_x_Empleado.observacionesSys, 
                      dbo.ro_Ing_Egre_x_Empleado.TipoRegistro, dbo.ro_Division.IdDivision, dbo.ro_Division.Descripcion, dbo.tb_persona.pe_nombreCompleto, 
                      dbo.ro_rubro_tipo.rub_codigo, dbo.ro_empleado.em_sueldoBasicoMen, dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_Departamento.de_descripcion, 
                      dbo.ro_Departamento.IdDepartamento
FROM         dbo.ro_Ing_Egre_x_Empleado INNER JOIN
                      dbo.ro_rubro_tipo ON dbo.ro_Ing_Egre_x_Empleado.IdRubro = dbo.ro_rubro_tipo.IdRubro INNER JOIN
                      dbo.ro_empleado ON dbo.ro_Ing_Egre_x_Empleado.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                      dbo.ro_Ing_Egre_x_Empleado.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                      dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                      dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                      dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento LEFT OUTER JOIN
                      dbo.ro_Division ON dbo.ro_empleado.IdDivision = dbo.ro_Division.IdDivision AND dbo.ro_empleado.IdEmpresa = dbo.ro_Division.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwro_Ing_Egre_x_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'Width = 1500
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
         Column = 2265
         Alias = 900
         Table = 2310
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwro_Ing_Egre_x_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[69] 4[6] 2[24] 3) )"
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
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ro_Ing_Egre_x_Empleado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 255
               Right = 219
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "ro_rubro_tipo"
            Begin Extent = 
               Top = 7
               Left = 238
               Bottom = 126
               Right = 409
            End
            DisplayFlags = 280
            TopColumn = 30
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 6
               Left = 440
               Bottom = 543
               Right = 652
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 31
               Left = 699
               Bottom = 150
               Right = 891
            End
            DisplayFlags = 280
            TopColumn = 22
         End
         Begin Table = "ro_Division"
            Begin Extent = 
               Top = 363
               Left = 159
               Bottom = 482
               Right = 319
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Departamento"
            Begin Extent = 
               Top = 294
               Left = 690
               Bottom = 425
               Right = 886
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
      Begin ColumnWidths = 24
         Width = 284
         ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwro_Ing_Egre_x_Empleado';

