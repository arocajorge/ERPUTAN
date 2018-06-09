CREATE VIEW Fj_servindustrias.vwro_fectividad_x_empleado_Adm_x_periodo_Det
AS
SELECT        Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa, Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo, 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo_Liq, Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdPeriodo, 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpleado, Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.Meta, 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.Real, Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.Cumplimiento, 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.Variable_porcentaje_prorrateado, 
                         Fj_servindustrias.ro_parametro_x_pago_variable_tipo.cod_Pago_Variable, Fj_servindustrias.ro_parametro_x_pago_variable_tipo.nom_Pago_Variable, 
                         dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_nombreCompleto, Fj_servindustrias.ro_Grupo_empleado.Valor_bono, 
                         dbo.ro_rubro_tipo.ru_descripcion
FROM            dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona AND dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona AND 
                         dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det INNER JOIN
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo ON 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdEmpresa AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdNomina_Tipo AND
                          Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo_Liq = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdNomina_Tipo_Liq
                          AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdPeriodo = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdPeriodo INNER JOIN
                         Fj_servindustrias.ro_parametro_x_pago_variable_tipo ON 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa = Fj_servindustrias.ro_parametro_x_pago_variable_tipo.IdEmpresa AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.cod_Pago_Variable = Fj_servindustrias.ro_parametro_x_pago_variable_tipo.cod_Pago_Variable ON
                          dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_Grupo_empleado ON dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_Grupo_empleado.IdEmpresa AND 
                         dbo.ro_empleado.IdGrupo = Fj_servindustrias.ro_Grupo_empleado.IdGrupo INNER JOIN
                         dbo.ro_rubro_tipo ON Fj_servindustrias.ro_parametro_x_pago_variable_tipo.IdRubro = dbo.ro_rubro_tipo.IdRubro
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_fectividad_x_empleado_Adm_x_periodo_Det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'j_servindustrias)"
            Begin Extent = 
               Top = 178
               Left = 93
               Bottom = 378
               Right = 328
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "ro_rubro_tipo"
            Begin Extent = 
               Top = 232
               Left = 508
               Bottom = 361
               Right = 752
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
      Begin ColumnWidths = 17
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 3375
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_fectividad_x_empleado_Adm_x_periodo_Det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[84] 4[5] 2[5] 3) )"
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
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 245
               Left = 233
               Bottom = 374
               Right = 522
            End
            DisplayFlags = 280
            TopColumn = 70
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 97
               Left = 83
               Bottom = 319
               Right = 315
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "ro_empleado_x_ro_tipoNomina"
            Begin Extent = 
               Top = 17
               Left = 758
               Bottom = 174
               Right = 967
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_fectividad_x_empleado_Adm_x_periodo_Det (Fj_servindustrias)"
            Begin Extent = 
               Top = 0
               Left = 249
               Bottom = 311
               Right = 720
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_fectividad_x_empleado_Adm_x_periodo (Fj_servindustrias)"
            Begin Extent = 
               Top = 177
               Left = 716
               Bottom = 323
               Right = 983
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_parametro_x_pago_variable_tipo (Fj_servindustrias)"
            Begin Extent = 
               Top = 10
               Left = 0
               Bottom = 196
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Grupo_empleado (F', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_fectividad_x_empleado_Adm_x_periodo_Det';

