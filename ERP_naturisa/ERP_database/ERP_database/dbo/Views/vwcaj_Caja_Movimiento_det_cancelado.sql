CREATE VIEW [dbo].[vwcaj_Caja_Movimiento_det_cancelado]
AS
SELECT        dbo.caj_Caja_Movimiento_det.IdEmpresa, dbo.caj_Caja_Movimiento_det.IdCbteCble, dbo.caj_Caja_Movimiento_det.IdTipocbte, 
                         dbo.caj_Caja_Movimiento_det.Secuencia, dbo.caj_Caja_Movimiento_det.IdCobro_tipo, dbo.caj_Caja_Movimiento_det.cr_fecha, 
                         dbo.caj_Caja_Movimiento_det.cr_Valor, dbo.caj_Caja_Movimiento_det.cr_Banco, dbo.caj_Caja_Movimiento_det.cr_cuenta, 
                         dbo.caj_Caja_Movimiento_det.cr_NumDocumento, dbo.caj_Caja_Movimiento_det.cr_fechaDocu, dbo.caj_Caja_Movimiento_det.IdEmpresa_OP, 
                         dbo.caj_Caja_Movimiento_det.IdOrdenPago_OP, dbo.vwcp_orden_pago_con_cancelacion.IdTipo_op, dbo.vwcp_orden_pago_con_cancelacion.Referencia, 
                         dbo.vwcp_orden_pago_con_cancelacion.IdOrdenPago, dbo.vwcp_orden_pago_con_cancelacion.Secuencia_OP, 
                         dbo.vwcp_orden_pago_con_cancelacion.IdTipoPersona, dbo.vwcp_orden_pago_con_cancelacion.IdPersona, dbo.vwcp_orden_pago_con_cancelacion.IdEntidad, 
                         dbo.vwcp_orden_pago_con_cancelacion.Fecha_OP, dbo.vwcp_orden_pago_con_cancelacion.Fecha_Fa_Prov, 
                         dbo.vwcp_orden_pago_con_cancelacion.Fecha_Venc_Fac_Prov, dbo.vwcp_orden_pago_con_cancelacion.Observacion, 
                         dbo.vwcp_orden_pago_con_cancelacion.Nom_Beneficiario, dbo.vwcp_orden_pago_con_cancelacion.Girar_Cheque_a, 
                         dbo.vwcp_orden_pago_con_cancelacion.Valor_a_pagar, dbo.vwcp_orden_pago_con_cancelacion.Valor_estimado_a_pagar_OP, 
                         dbo.vwcp_orden_pago_con_cancelacion.Total_cancelado_OP, dbo.vwcp_orden_pago_con_cancelacion.Saldo_x_Pagar_OP, 
                         dbo.vwcp_orden_pago_con_cancelacion.IdEstadoAprobacion, dbo.vwcp_orden_pago_con_cancelacion.IdFormaPago, 
                         dbo.vwcp_orden_pago_con_cancelacion.Fecha_Pago, dbo.vwcp_orden_pago_con_cancelacion.IdCtaCble, dbo.vwcp_orden_pago_con_cancelacion.Cbte_cxp, 
                         dbo.vwcp_orden_pago_con_cancelacion.Estado, dbo.vwcp_orden_pago_con_cancelacion.Nom_Beneficiario_2, 
                         dbo.caj_Caja_Movimiento_det.IdCentroCosto_sub_centro_costo, dbo.caj_Caja_Movimiento_det.IdTipoFlujo, dbo.caj_Caja_Movimiento_det.IdCentroCosto, 
                         dbo.vwcp_orden_pago_con_cancelacion.IdSubCentro_Costo
FROM            dbo.caj_Caja_Movimiento_det INNER JOIN
                         dbo.vwcp_orden_pago_con_cancelacion ON dbo.caj_Caja_Movimiento_det.IdEmpresa_OP = dbo.vwcp_orden_pago_con_cancelacion.IdEmpresa AND 
                         dbo.caj_Caja_Movimiento_det.IdOrdenPago_OP = dbo.vwcp_orden_pago_con_cancelacion.IdOrdenPago
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcaj_Caja_Movimiento_det_cancelado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[85] 4[4] 2[3] 3) )"
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
         Begin Table = "caj_Caja_Movimiento_det"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 357
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwcp_orden_pago_con_cancelacion"
            Begin Extent = 
               Top = 0
               Left = 396
               Bottom = 453
               Right = 747
            End
            DisplayFlags = 280
            TopColumn = 8
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcaj_Caja_Movimiento_det_cancelado';

