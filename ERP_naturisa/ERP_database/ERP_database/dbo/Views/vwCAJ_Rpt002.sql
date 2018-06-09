CREATE VIEW [dbo].[vwCAJ_Rpt002]
AS
SELECT        dbo.caj_Caja_Movimiento.IdEmpresa, dbo.caj_Caja_Movimiento.IdCbteCble, dbo.caj_Caja_Movimiento.IdTipocbte, dbo.ct_cbtecble_tipo.CodTipoCbte AS Tipo_Cbte, 
                         dbo.caj_Caja_Movimiento.cm_fecha, dbo.caj_Caja_Movimiento.cm_Signo, dbo.caj_Caja_Movimiento.cm_beneficiario, dbo.caj_Caja_Movimiento.cm_observacion, 
                         dbo.caj_Caja_Movimiento.Estado, dbo.caj_Caja.IdCaja, dbo.caj_Caja.ca_Descripcion AS nom_caja, dbo.tb_sucursal.IdSucursal, 
                         dbo.tb_sucursal.Su_Descripcion AS nom_sucursal, dbo.caj_Caja_Movimiento_Tipo.IdTipoMovi, dbo.caj_Caja_Movimiento_Tipo.tm_descripcion AS nom_TipoMovi, 
                         dbo.tb_empresa.em_nombre AS nom_empresa, dbo.caj_Caja_Movimiento_det.IdCobro_tipo, dbo.caj_Caja_Movimiento_det.cr_Valor, 
                         dbo.caj_Caja_Movimiento_det.cr_NumDocumento, dbo.ba_TipoFlujo.IdTipoFlujo, dbo.ba_TipoFlujo.Descricion AS nom_TipoFlujo, 
                         dbo.caj_Caja_Movimiento.IdPersona, dbo.caj_Caja_Movimiento.IdTipo_Persona, dbo.caj_Caja_Movimiento.IdEntidad
FROM            dbo.caj_Caja_Movimiento INNER JOIN
                         dbo.caj_Caja_Movimiento_det ON dbo.caj_Caja_Movimiento.IdEmpresa = dbo.caj_Caja_Movimiento_det.IdEmpresa AND 
                         dbo.caj_Caja_Movimiento.IdCbteCble = dbo.caj_Caja_Movimiento_det.IdCbteCble AND 
                         dbo.caj_Caja_Movimiento.IdTipocbte = dbo.caj_Caja_Movimiento_det.IdTipocbte INNER JOIN
                         dbo.tb_empresa ON dbo.caj_Caja_Movimiento.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                         dbo.caj_Caja ON dbo.caj_Caja_Movimiento.IdEmpresa = dbo.caj_Caja.IdEmpresa AND dbo.caj_Caja_Movimiento.IdCaja = dbo.caj_Caja.IdCaja INNER JOIN
                         dbo.caj_Caja_Movimiento_Tipo ON dbo.caj_Caja_Movimiento.IdTipoMovi = dbo.caj_Caja_Movimiento_Tipo.IdTipoMovi INNER JOIN
                         dbo.tb_sucursal ON dbo.caj_Caja_Movimiento.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                         dbo.caj_Caja_Movimiento.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         dbo.ba_TipoFlujo ON dbo.caj_Caja_Movimiento.IdEmpresa = dbo.ba_TipoFlujo.IdEmpresa AND 
                         dbo.caj_Caja_Movimiento.IdTipoFlujo = dbo.ba_TipoFlujo.IdTipoFlujo INNER JOIN
                         dbo.ct_cbtecble_tipo ON dbo.caj_Caja_Movimiento.IdTipocbte = dbo.ct_cbtecble_tipo.IdTipoCbte LEFT OUTER JOIN
                         dbo.vwtb_persona_beneficiario ON dbo.caj_Caja_Movimiento.IdEmpresa = dbo.vwtb_persona_beneficiario.IdEmpresa AND 
                         dbo.caj_Caja_Movimiento.IdTipo_Persona = dbo.vwtb_persona_beneficiario.IdTipo_Persona AND 
                         dbo.caj_Caja_Movimiento.IdEntidad = dbo.vwtb_persona_beneficiario.IdEntidad
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCAJ_Rpt002';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'     Right = 647
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ct_cbtecble_tipo"
            Begin Extent = 
               Top = 672
               Left = 113
               Bottom = 801
               Right = 322
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwtb_persona_beneficiario"
            Begin Extent = 
               Top = 0
               Left = 820
               Bottom = 267
               Right = 1029
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 25
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1935
         Table = 2100
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCAJ_Rpt002';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[47] 4[4] 2[4] 3) )"
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
         Begin Table = "caj_Caja_Movimiento"
            Begin Extent = 
               Top = 27
               Left = 13
               Bottom = 341
               Right = 222
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "caj_Caja_Movimiento_det"
            Begin Extent = 
               Top = 326
               Left = 1081
               Bottom = 455
               Right = 1290
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_empresa"
            Begin Extent = 
               Top = 376
               Left = 787
               Bottom = 505
               Right = 1006
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "caj_Caja"
            Begin Extent = 
               Top = 214
               Left = 972
               Bottom = 343
               Right = 1182
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "caj_Caja_Movimiento_Tipo"
            Begin Extent = 
               Top = 383
               Left = 697
               Bottom = 512
               Right = 906
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 677
               Left = 735
               Bottom = 806
               Right = 965
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_TipoFlujo"
            Begin Extent = 
               Top = 684
               Left = 438
               Bottom = 813
          ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCAJ_Rpt002';

