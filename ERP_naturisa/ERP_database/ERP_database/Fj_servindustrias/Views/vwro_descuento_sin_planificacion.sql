CREATE view Fj_servindustrias.vwro_descuento_sin_planificacion as
SELECT        Fj_servindustrias.ro_descuento_no_planificados.IdEmpresa, Fj_servindustrias.ro_descuento_no_planificados.IdNomina_Tipo, 
                         Fj_servindustrias.ro_descuento_no_planificados.IdEmpleado, Fj_servindustrias.ro_descuento_no_planificados.IdDescuento, 
                         Fj_servindustrias.ro_descuento_no_planificados.IdNovedad, Fj_servindustrias.ro_descuento_no_planificados.IdRubro, 
                         Fj_servindustrias.ro_descuento_no_planificados.Observacion, Fj_servindustrias.ro_descuento_no_planificados.Valor, 
                         Fj_servindustrias.ro_descuento_no_planificados.Fecha_Incidente, Fj_servindustrias.ro_descuento_no_planificados.Estado, dbo.ro_rubro_tipo.ru_descripcion, 
                         dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_razonSocial, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_cedulaRuc, 
                         CAST(Fj_servindustrias.ro_descuento_no_planificados.Fecha_Transaccion AS date) AS Fecha_Transaccion
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_empleado ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_descuento_no_planificados INNER JOIN
                         dbo.ro_rubro_tipo ON Fj_servindustrias.ro_descuento_no_planificados.IdRubro = dbo.ro_rubro_tipo.IdRubro AND 
                         Fj_servindustrias.ro_descuento_no_planificados.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa ON 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = Fj_servindustrias.ro_descuento_no_planificados.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = Fj_servindustrias.ro_descuento_no_planificados.IdEmpleado AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = Fj_servindustrias.ro_descuento_no_planificados.IdNomina_Tipo AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = Fj_servindustrias.ro_descuento_no_planificados.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = Fj_servindustrias.ro_descuento_no_planificados.IdEmpleado AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = Fj_servindustrias.ro_descuento_no_planificados.IdNomina_Tipo AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = Fj_servindustrias.ro_descuento_no_planificados.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = Fj_servindustrias.ro_descuento_no_planificados.IdEmpleado AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = Fj_servindustrias.ro_descuento_no_planificados.IdNomina_Tipo AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = Fj_servindustrias.ro_descuento_no_planificados.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = Fj_servindustrias.ro_descuento_no_planificados.IdEmpleado AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = Fj_servindustrias.ro_descuento_no_planificados.IdNomina_Tipo AND NOT EXISTS
                             (SELECT        IdEmpresa, IdNomina_Tipo, IdNomina_Tipo_Liq, IdEmpleado, IdDescuento, IdRubro, Secuencia, Observacion, Valor, Fecha_Descuento
                               FROM            Fj_servindustrias.ro_descuento_no_planificados_Det
                               WHERE        (IdEmpresa = Fj_servindustrias.ro_descuento_no_planificados.IdEmpresa) AND 
                                                         (IdNomina_Tipo = Fj_servindustrias.ro_descuento_no_planificados.IdNomina_Tipo) AND 
                                                         (IdEmpleado = Fj_servindustrias.ro_descuento_no_planificados.IdEmpleado) AND 
                                                         (IdDescuento = Fj_servindustrias.ro_descuento_no_planificados.IdDescuento))
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_descuento_sin_planificacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'n ColumnWidths = 11
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_descuento_sin_planificacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[72] 4[5] 2[9] 3) )"
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
         Top = -238
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_ro_tipoNomina"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 399
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_descuento_no_planificados (Fj_servindustrias)"
            Begin Extent = 
               Top = 248
               Left = 527
               Bottom = 542
               Right = 877
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ro_rubro_tipo"
            Begin Extent = 
               Top = 443
               Left = 33
               Bottom = 572
               Right = 286
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
      Begin ColumnWidths = 9
         Width = 284
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
      Begi', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_descuento_sin_planificacion';

