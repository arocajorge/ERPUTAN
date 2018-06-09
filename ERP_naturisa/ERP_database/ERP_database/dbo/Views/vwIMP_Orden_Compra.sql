CREATE VIEW [dbo].[vwIMP_Orden_Compra]
AS
SELECT     dbo.imp_ordencompra_ext.CodOrdenCompraExt AS Codigo, dbo.imp_ordencompra_ext.IdOrdenCompraExt AS [# Orden Compra], 
                      dbo.tb_sucursal.Su_Descripcion AS Sucursal, dbo.tb_persona.pe_nombreCompleto AS Proveedor, dbo.imp_ordencompra_ext.ci_Observacion AS Observacion, 
                      dbo.imp_ordencompra_ext.Fecha_Transac AS Fecha, dbo.imp_ordencompra_ext.IdEmpresa, dbo.imp_ordencompra_ext.IdSucusal, dbo.imp_ordencompra_ext.Estado, 
                      dbo.imp_ordencompra_ext.ci_plazo, dbo.imp_ordencompra_ext.ci_fecha, dbo.imp_ordencompra_ext.IdProveedor, dbo.imp_ordencompra_ext.IdUsuario, 
                      dbo.imp_ordencompra_ext.ci_costo_Flete_externo, dbo.imp_ordencompra_ext.ci_costo_Flete_interno, dbo.imp_ordencompra_ext.ci_costoSeguro, 
                      dbo.imp_ordencompra_ext.ci_costoCif, dbo.imp_ordencompra_ext.ci_GastosTotales, dbo.imp_ordencompra_ext.IdVia, 
                      dbo.imp_ordencompra_ext.ci_fecha_aprobacion, dbo.imp_ordencompra_ext.ci_fechaFactProv, dbo.imp_ordencompra_ext.ci_fechVenciFact, 
                      dbo.imp_ordencompra_ext.ci_fechaDespProv, dbo.imp_ordencompra_ext.ci_fechaRecEmb, dbo.imp_ordencompra_ext.ci_fechaAproxSal, 
                      dbo.imp_ordencompra_ext.ci_fec_est_llegada, dbo.imp_ordencompra_ext.ci_fecha_llegada_Bodega, dbo.imp_ordencompra_ext.ci_fechaRealArri, 
                      dbo.imp_ordencompra_ext.ci_fechaDocAAA, dbo.imp_ordencompra_ext.ci_fecha_liquidacion, dbo.imp_ordencompra_ext.ci_fecha_sal_aduana, 
                      dbo.imp_ordencompra_ext.ci_diasFecFacProv, dbo.imp_ordencompra_ext.ci_diasFecDespProv, dbo.imp_ordencompra_ext.ci_diasFecAproxSal, 
                      dbo.imp_ordencompra_ext.ci_diasFecAproxLleg, dbo.imp_ordencompra_ext.ci_diasNaciona, dbo.imp_ordencompra_ext.ci_fecha_pago, 
                      dbo.imp_ordencompra_ext.ci_fecha_salida, dbo.imp_ordencompra_ext.ci_fecha_llegada, dbo.imp_ordencompra_ext.ci_fecha_despacho, 
                      dbo.imp_ordencompra_ext.ci_dias_estimados, dbo.imp_ordencompra_ext.ci_valor_derecho, dbo.imp_ordencompra_ext.IdMonedaOrigen, 
                      dbo.imp_ordencompra_ext.IdMonedaCambiaria, dbo.imp_ordencompra_ext.ci_EquivalenciaMoneda, dbo.imp_ordencompra_ext.IdCicloImportacion, 
                      dbo.imp_ordencompra_ext.IdCtaCble_Inven, dbo.imp_ordencompra_ext.IdCtaCble_import, dbo.imp_ordencompra_ext.IdEmbarcador, 
                      dbo.imp_ordencompra_ext.ci_contabilizada, dbo.imp_ordencompra_ext.ci_Idfecha_Bodega, dbo.imp_ordencompra_ext.ci_fechaRegsis, 
                      dbo.imp_ordencompra_ext.ci_ultFechaModi, dbo.imp_ordencompra_ext.ci_ultUserModi, dbo.imp_ordencompra_ext.IdPaisOrgCarga, 
                      dbo.imp_ordencompra_ext.IdPaisProceCarga, dbo.imp_ordencompra_ext.ci_dui, dbo.imp_ordencompra_ext.ci_fechaHoraAnul, dbo.imp_ordencompra_ext.ci_userAnul, 
                      dbo.imp_ordencompra_ext.ci_anio, dbo.imp_ordencompra_ext.ci_mes, dbo.imp_ordencompra_ext.ci_FechaCosteo, dbo.imp_ordencompra_ext.IdUsuarioUltMod, 
                      dbo.imp_ordencompra_ext.Fecha_UltMod, dbo.imp_ordencompra_ext.IdUsuarioUltAnu, dbo.imp_ordencompra_ext.Fecha_UltAnu, dbo.imp_ordencompra_ext.nom_pc, 
                      dbo.imp_ordencompra_ext.ip, dbo.imp_ordencompra_ext.MotiAnula, dbo.imp_ordencompra_ext.ci_tonelaje, dbo.imp_ordencompra_ext.ci_lugarEmbarque, 
                      dbo.imp_ordencompra_ext.Buque, dbo.imp_ordencompra_ext.Naviera, dbo.imp_ordencompra_ext.CFR, dbo.imp_ordencompra_ext.IdCategoria, 
                      dbo.imp_ordencompra_ext.ci_Total, dbo.imp_ordencompra_ext.IdEstadoLiquidacion, dbo.imp_ordencompra_ext.NumFacturaProvedor, 
                      dbo.imp_ordencompra_ext.ci_diasEmbarque, dbo.imp_ordencompra_ext.ci_fechaFirmaContrato, dbo.imp_ordencompra_ext.Tipo_Importacion, 
                      dbo.imp_ordencompra_ext.Fecha_Maximo_Despacho
FROM         dbo.imp_ordencompra_ext INNER JOIN
                      dbo.cp_proveedor ON dbo.imp_ordencompra_ext.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND 
                      dbo.imp_ordencompra_ext.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                      dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                      dbo.tb_sucursal ON dbo.imp_ordencompra_ext.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.imp_ordencompra_ext.IdSucusal = dbo.tb_sucursal.IdSucursal
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwIMP_Orden_Compra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'         Width = 1500
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
         Alias = 3435
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwIMP_Orden_Compra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[32] 2[8] 3) )"
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
         Begin Table = "imp_ordencompra_ext"
            Begin Extent = 
               Top = 0
               Left = 373
               Bottom = 268
               Right = 584
            End
            DisplayFlags = 280
            TopColumn = 66
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 30
               Left = 717
               Bottom = 272
               Right = 917
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 34
               Left = 961
               Bottom = 201
               Right = 1153
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 252
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
      Begin ColumnWidths = 75
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwIMP_Orden_Compra';

