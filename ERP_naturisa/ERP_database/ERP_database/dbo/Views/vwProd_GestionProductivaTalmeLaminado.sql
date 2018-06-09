CREATE VIEW [dbo].[vwProd_GestionProductivaTalmeLaminado]
AS
SELECT     dbo.prod_GestionProductivaLaminado_CusTalme.IdEmpresa, dbo.prod_GestionProductivaLaminado_CusTalme.IdGestionProductiva, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.IdTurno, dbo.prod_GestionProductivaLaminado_CusTalme.IdEmpleado_JefeTurno, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.IdProducto_MateriaPrima, dbo.prod_GestionProductivaLaminado_CusTalme.Id_Bobina, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.Num_Orden, dbo.prod_GestionProductivaLaminado_CusTalme.kg_Cargados, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.kg_producidos, dbo.prod_GestionProductivaLaminado_CusTalme.IdProducto_Producido1, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.unidades_prd_1, dbo.prod_GestionProductivaLaminado_CusTalme.pesokg_prd_1, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.IdProducto_Producido2, dbo.prod_GestionProductivaLaminado_CusTalme.unidades_prd_2, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.pesokg_prd_2, dbo.prod_GestionProductivaLaminado_CusTalme.kg_retazo_porcen, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.kg_retazo_valor, dbo.prod_GestionProductivaLaminado_CusTalme.kg_chatarra_porcen, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.kg_chatarra_valor, dbo.prod_GestionProductivaLaminado_CusTalme.kg_oxidacion_porcen, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.kg_oxidacion_valor, dbo.prod_GestionProductivaLaminado_CusTalme.rendi_metal_historico, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.rendi_metal_real, dbo.prod_GestionProductivaLaminado_CusTalme.rendi_metal_Diferencia, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.consumo_kilowatios, dbo.prod_GestionProductivaLaminado_CusTalme.consumo_galones, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.cambio_prue_programado, dbo.prod_GestionProductivaLaminado_CusTalme.cambio_prue_real, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.cambio_prue_porcentaje, dbo.prod_GestionProductivaLaminado_CusTalme.hora_turno_ini, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.hora_turno_fin, dbo.prod_GestionProductivaLaminado_CusTalme.hora_jornada, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.hora_productiva, dbo.prod_GestionProductivaLaminado_CusTalme.hora_Paros, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.hora_Neta, dbo.prod_GestionProductivaLaminado_CusTalme.hora_Hrs_Maquina, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.Ton_Programada, dbo.prod_GestionProductivaLaminado_CusTalme.Ton_real, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.Ton_Eficiencia, dbo.prod_GestionProductivaLaminado_CusTalme.Ton_TnHrNeta, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.Ton_kwTon, dbo.prod_GestionProductivaLaminado_CusTalme.Ton_GlsTon, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.EficienciaProduccion, dbo.prod_GestionProductivaLaminado_CusTalme.Estado, 
                      dbo.prod_GestionProductivaLaminado_CusTalme.Fecha, dbo.prod_Turno.Descripcion, 
                      dbo.vwro_empleado.pe_nombre + ' ' + dbo.vwro_empleado.pe_apellido AS Nombre_JefeTurno
FROM         dbo.prod_GestionProductivaLaminado_CusTalme INNER JOIN
                      dbo.prod_Turno ON dbo.prod_GestionProductivaLaminado_CusTalme.IdEmpresa = dbo.prod_Turno.IdEmpresa AND 
                      dbo.prod_GestionProductivaLaminado_CusTalme.IdTurno = dbo.prod_Turno.IdTurno INNER JOIN
                      dbo.vwro_empleado ON dbo.prod_GestionProductivaLaminado_CusTalme.IdEmpresa = dbo.vwro_empleado.IdEmpresa AND 
                      dbo.prod_GestionProductivaLaminado_CusTalme.IdEmpleado_JefeTurno = dbo.vwro_empleado.IdEmpleado
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_GestionProductivaTalmeLaminado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'h = 1500
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_GestionProductivaTalmeLaminado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[36] 4[4] 2[33] 3) )"
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
         Begin Table = "prod_Turno"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 125
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "prod_GestionProductivaLaminado_CusTalme"
            Begin Extent = 
               Top = 21
               Left = 597
               Bottom = 274
               Right = 811
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwro_empleados"
            Begin Extent = 
               Top = 98
               Left = 947
               Bottom = 363
               Right = 1159
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
      Begin ColumnWidths = 48
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
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Widt', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_GestionProductivaTalmeLaminado';

