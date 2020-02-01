CREATE VIEW dbo.vwba_Cbte_Ban
AS
SELECT B.tc_TipoCbte, C.ba_descripcion, '' AS NombreProveedor, Ba.IdEmpresa, Ba.IdCbteCble, Ba.IdTipocbte, Ba.Cod_Cbtecble, Ba.IdPeriodo, Ba.IdBanco, Ba.IdProveedor, Ba.cb_Fecha, Ba.cb_Observacion, Ba.cb_secuencia, Ba.cb_Valor, 
                  Ba.cb_Cheque, Ba.cb_ChequeImpreso, Ba.cb_FechaCheque, Ba.IdUsuario, Ba.IdUsuario_Anu, Ba.FechaAnulacion, Ba.Fecha_Transac, Ba.Fecha_UltMod, Ba.IdUsuarioUltMod, Ba.Estado, Ba.MotivoAnulacion, Ba.ip, Ba.nom_pc, 
                  Ba.cb_giradoA, Ba.cb_ciudadChq, Ba.IdCbteCble_Anulacion, Ba.IdTipoCbte_Anulacion, Ba.IdTipoFlujo, Ba.IdTipoNota, dbo.ba_tipo_nota.Descripcion AS NomTipoNota, Ba.Por_Anticipo, Ba.PosFechado, Ba.IdPersona_Girado_a, 
                  Ba.ValorEnLetras, Ba.IdSucursal, ISNULL(Ba.IdEstado_Cbte_Ban_cat, '') AS IdEstado_Cbte_Ban_cat, dbo.vwba_Estado_cbte_ban.ca_descripcion AS nom_Estado_Cbte_Ban, 
                  MAX(CASE WHEN dbo.tb_persona.pe_nombreCompleto IS NULL AND tb_persona_1.pe_nombreCompleto IS NULL THEN tb_persona_2.pe_nombreCompleto WHEN dbo.tb_persona.pe_nombreCompleto IS NULL AND 
                  tb_persona_1.pe_nombreCompleto IS NOT NULL THEN tb_persona_1.pe_nombreCompleto ELSE dbo.tb_persona.pe_nombreCompleto END) AS Beneficiario, tb_persona_2.IdTipoDocumento, 
                  MAX(CASE WHEN dbo.tb_persona.pe_nombreCompleto IS NULL AND tb_persona_1.pe_nombreCompleto IS NULL THEN tb_persona_2.pe_cedulaRuc WHEN dbo.tb_persona.pe_nombreCompleto IS NULL AND 
                  tb_persona_1.pe_nombreCompleto IS NOT NULL THEN tb_persona_1.pe_cedulaRuc ELSE dbo.tb_persona.pe_cedulaRuc END) AS pe_cedulaRuc, dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.CodTipoCbteBan, 
                  MIN(ISNULL(dbo.vwba_Banco_Estado_Cheques.Estado_Conciliacion, 'NO CONCILIADO')) AS Estado_Conciliacion, CASE WHEN Ba.IdEstado_Preaviso_ch_cat = '' THEN 'ES_CH_XPREAVISO_CH' ELSE isnull(Ba.IdEstado_Preaviso_ch_cat, 
                  'ES_CH_XPREAVISO_CH') END AS IdEstado_Preaviso_ch_cat, Ba.IdEstado_cheque_cat
FROM     dbo.caj_Caja_Movimiento INNER JOIN
                  dbo.tb_persona ON dbo.caj_Caja_Movimiento.IdPersona = dbo.tb_persona.IdPersona RIGHT OUTER JOIN
                  dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito ON dbo.caj_Caja_Movimiento.IdTipocbte = dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdTipocbte AND 
                  dbo.caj_Caja_Movimiento.IdCbteCble = dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdCbteCble AND 
                  dbo.caj_Caja_Movimiento.IdEmpresa = dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdEmpresa RIGHT OUTER JOIN
                  dbo.ba_Banco_Cuenta AS C RIGHT OUTER JOIN
                  dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo INNER JOIN
                  dbo.ba_Cbte_Ban AS Ba ON dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdEmpresa = Ba.IdEmpresa AND dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdTipoCbteCble = Ba.IdTipocbte INNER JOIN
                  dbo.ct_cbtecble_tipo AS B ON Ba.IdTipocbte = B.IdTipoCbte AND Ba.IdEmpresa = B.IdEmpresa LEFT OUTER JOIN
                  dbo.tb_persona AS tb_persona_1 INNER JOIN
                  dbo.cp_orden_pago INNER JOIN
                  dbo.cp_orden_pago_cancelaciones ON dbo.cp_orden_pago.IdEmpresa = dbo.cp_orden_pago_cancelaciones.IdEmpresa_op AND dbo.cp_orden_pago.IdOrdenPago = dbo.cp_orden_pago_cancelaciones.IdOrdenPago_op ON 
                  tb_persona_1.IdPersona = dbo.cp_orden_pago.IdPersona ON Ba.IdEmpresa = dbo.cp_orden_pago_cancelaciones.IdEmpresa_pago AND Ba.IdCbteCble = dbo.cp_orden_pago_cancelaciones.IdCbteCble_pago AND 
                  Ba.IdTipocbte = dbo.cp_orden_pago_cancelaciones.IdTipoCbte_pago LEFT OUTER JOIN
                  dbo.tb_persona AS tb_persona_2 ON Ba.IdPersona_Girado_a = tb_persona_2.IdPersona ON C.IdEmpresa = Ba.IdEmpresa AND C.IdBanco = Ba.IdBanco LEFT OUTER JOIN
                  dbo.vwba_Banco_Estado_Cheques ON Ba.IdEmpresa = dbo.vwba_Banco_Estado_Cheques.IdEmpresa AND Ba.IdCbteCble = dbo.vwba_Banco_Estado_Cheques.IdCbteCble AND 
                  Ba.IdTipocbte = dbo.vwba_Banco_Estado_Cheques.IdTipocbte LEFT OUTER JOIN
                  dbo.vwba_Estado_cbte_ban ON Ba.IdEstado_Cbte_Ban_cat = dbo.vwba_Estado_cbte_ban.IdEstado_cbte_ban LEFT OUTER JOIN
                  dbo.ba_tipo_nota ON Ba.IdEmpresa = dbo.ba_tipo_nota.IdEmpresa AND Ba.IdTipoNota = dbo.ba_tipo_nota.IdTipoNota ON dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mba_IdEmpresa = Ba.IdEmpresa AND 
                  dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mba_IdCbteCble = Ba.IdCbteCble AND dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mba_IdTipocbte = Ba.IdTipocbte
GROUP BY B.tc_TipoCbte, C.ba_descripcion, Ba.IdEmpresa, Ba.IdCbteCble, Ba.IdTipocbte, Ba.Cod_Cbtecble, Ba.IdPeriodo, Ba.IdBanco, Ba.IdProveedor, Ba.cb_Fecha, Ba.cb_Observacion, Ba.cb_secuencia, Ba.cb_Valor, Ba.cb_Cheque, 
                  Ba.cb_ChequeImpreso, Ba.cb_FechaCheque, Ba.IdUsuario, Ba.IdUsuario_Anu, Ba.FechaAnulacion, Ba.Fecha_Transac, Ba.Fecha_UltMod, Ba.IdUsuarioUltMod, Ba.Estado, Ba.MotivoAnulacion, Ba.ip, Ba.nom_pc, Ba.cb_giradoA, 
                  Ba.cb_ciudadChq, Ba.IdCbteCble_Anulacion, Ba.IdTipoCbte_Anulacion, Ba.IdTipoFlujo, Ba.IdTipoNota, dbo.ba_tipo_nota.Descripcion, Ba.Por_Anticipo, Ba.PosFechado, Ba.IdPersona_Girado_a, Ba.ValorEnLetras, Ba.IdSucursal, 
                  ISNULL(Ba.IdEstado_Cbte_Ban_cat, ''), dbo.vwba_Estado_cbte_ban.ca_descripcion, tb_persona_2.IdTipoDocumento, tb_persona_2.pe_cedulaRuc, dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.CodTipoCbteBan, Ba.IdEstado_cheque_cat, 
                  Ba.IdEstado_Preaviso_ch_cat
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwba_Cbte_Ban';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       Right = 327
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona_1"
            Begin Extent = 
               Top = 1359
               Left = 1593
               Bottom = 1522
               Right = 1883
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_orden_pago"
            Begin Extent = 
               Top = 1353
               Left = 1249
               Bottom = 1516
               Right = 1496
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_orden_pago_cancelaciones"
            Begin Extent = 
               Top = 1220
               Left = 718
               Bottom = 1651
               Right = 986
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona_2"
            Begin Extent = 
               Top = 1687
               Left = 48
               Bottom = 1850
               Right = 338
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwba_Banco_Estado_Cheques"
            Begin Extent = 
               Top = 1871
               Left = 20
               Bottom = 2162
               Right = 264
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwba_Estado_cbte_ban"
            Begin Extent = 
               Top = 1736
               Left = 1119
               Bottom = 1899
               Right = 1354
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_tipo_nota"
            Begin Extent = 
               Top = 2191
               Left = 48
               Bottom = 2354
               Right = 258
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
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 4836
         Alias = 1632
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwba_Cbte_Ban';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[6] 4[85] 2[3] 3) )"
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
         Top = -1560
         Left = 0
      End
      Begin Tables = 
         Begin Table = "caj_Caja_Movimiento"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 285
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 0
               Left = 587
               Bottom = 163
               Right = 877
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito"
            Begin Extent = 
               Top = 203
               Left = 903
               Bottom = 366
               Right = 1124
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 534
               Left = 1356
               Bottom = 697
               Right = 1640
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo"
            Begin Extent = 
               Top = 485
               Left = 232
               Bottom = 648
               Right = 479
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ba"
            Begin Extent = 
               Top = 498
               Left = 1005
               Bottom = 661
               Right = 1282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 737
               Left = 103
               Bottom = 900
        ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwba_Cbte_Ban';

