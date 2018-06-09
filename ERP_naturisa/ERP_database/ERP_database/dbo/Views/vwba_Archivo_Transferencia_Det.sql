CREATE VIEW [dbo].[vwba_Archivo_Transferencia_Det]
AS
SELECT        dbo.ba_Archivo_Transferencia_Det.IdEmpresa, dbo.ba_Archivo_Transferencia_Det.IdArchivo, dbo.ba_Archivo_Transferencia_Det.Secuencia, 
                         dbo.ba_Archivo_Transferencia_Det.IdProceso_bancario, dbo.ba_Archivo_Transferencia.Origen_Archivo, 
                         CASE WHEN ba_Archivo_Transferencia.Origen_Archivo = 'CXP' THEN per_op.pe_cedulaRuc WHEN ba_Archivo_Transferencia.Origen_Archivo = 'RRHH' THEN per_rol.pe_cedulaRuc
                          WHEN ba_Archivo_Transferencia.Origen_Archivo = 'COL' THEN per_col.pe_cedulaRuc END AS pe_cedulaRuc, 
                         CASE WHEN ba_Archivo_Transferencia.Origen_Archivo = 'CXP' THEN per_op.num_cta_acreditacion WHEN ba_Archivo_Transferencia.Origen_Archivo = 'RRHH' THEN
                          ro_empleado.em_NumCta WHEN ba_Archivo_Transferencia.Origen_Archivo = 'COL' THEN Aca_Documento_Bancario_x_Rep_Economico.Numero_Documento END AS
                          num_cta_acreditacion, 
                         CASE WHEN ba_Archivo_Transferencia.Origen_Archivo = 'CXP' THEN per_op.pe_nombreCompleto WHEN ba_Archivo_Transferencia.Origen_Archivo = 'COL' THEN per_col.pe_nombreCompleto
                          WHEN ba_Archivo_Transferencia.Origen_Archivo = 'RRHH' THEN per_rol.pe_nombreCompleto END AS pe_nombreCompleto, 
                         dbo.ba_Archivo_Transferencia_Det.Valor, dbo.ba_Archivo_Transferencia_Det.Valor_cobrado, 
                         ISNULL(dbo.ba_Archivo_Transferencia_Det.Valor - dbo.ba_Archivo_Transferencia_Det.Valor_cobrado, 0) AS Saldo, 
                         dbo.ba_Archivo_Transferencia_Det.IdEstadoRegistro_cat, dbo.ba_Catalogo.ca_descripcion AS nom_EstadoRegistro_cat, dbo.ba_Archivo_Transferencia_Det.Id_Item, 
                         dbo.ba_Archivo_Transferencia.IdOrden_Bancaria, dbo.ba_Archivo_Transferencia.Fecha, dbo.ba_Archivo_Transferencia.IdBanco, 
                         dbo.ba_Archivo_Transferencia_Det.Secuencial_reg_x_proceso, dbo.ba_Archivo_Transferencia_Det.IdEmpresa_pago, 
                         dbo.ba_Archivo_Transferencia_Det.IdTipoCbte_pago, dbo.ba_Archivo_Transferencia_Det.IdCbteCble_pago, dbo.ct_cbtecble.cb_Estado, 
                         dbo.Aca_Pre_Facturacion_det.IdEmpresa_fac, dbo.Aca_Pre_Facturacion_det.IdSucursal_fac, dbo.Aca_Pre_Facturacion_det.IdBodega_fac, 
                         dbo.Aca_Pre_Facturacion_det.IdCbteVta_fac
FROM            dbo.tb_persona AS per_col INNER JOIN
                         dbo.Aca_Pre_Facturacion_det INNER JOIN
                         dbo.Aca_Familiar_x_Estudiante ON dbo.Aca_Pre_Facturacion_det.IdInstitucion = dbo.Aca_Familiar_x_Estudiante.IdInstitucion AND 
                         dbo.Aca_Pre_Facturacion_det.IdEstudiante = dbo.Aca_Familiar_x_Estudiante.IdEstudiante AND 
                         dbo.Aca_Pre_Facturacion_det.IdFamiliar = dbo.Aca_Familiar_x_Estudiante.IdFamiliar AND 
                         dbo.Aca_Pre_Facturacion_det.IdParentesco_cat = dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat INNER JOIN
                         dbo.Aca_Familiar ON dbo.Aca_Familiar_x_Estudiante.IdInstitucion = dbo.Aca_Familiar.IdInstitucion AND 
                         dbo.Aca_Familiar_x_Estudiante.IdFamiliar = dbo.Aca_Familiar.IdFamiliar INNER JOIN
                         dbo.Aca_estudiante ON dbo.Aca_Familiar_x_Estudiante.IdInstitucion = dbo.Aca_estudiante.IdInstitucion AND 
                         dbo.Aca_Familiar_x_Estudiante.IdEstudiante = dbo.Aca_estudiante.IdEstudiante ON per_col.IdPersona = dbo.Aca_estudiante.IdPersona LEFT OUTER JOIN
                         dbo.Aca_Documento_Bancario_x_Rep_Economico INNER JOIN
                         dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula ON 
                         dbo.Aca_Documento_Bancario_x_Rep_Economico.IdInstitucion = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdInstitucion AND 
                         dbo.Aca_Documento_Bancario_x_Rep_Economico.IdFamiliar = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdFamiliar AND 
                         dbo.Aca_Documento_Bancario_x_Rep_Economico.IdParentesco_cat = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdParentesco_cat
                          AND 
                         dbo.Aca_Documento_Bancario_x_Rep_Economico.IdDocumento_Bancario = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdDocumento_Bancario
                          ON dbo.Aca_Familiar_x_Estudiante.IdInstitucion = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdInstitucion AND 
                         dbo.Aca_Familiar_x_Estudiante.IdEstudiante = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdEstudiante AND 
                         dbo.Aca_Familiar_x_Estudiante.IdFamiliar = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdFamiliar AND 
                         dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdParentesco_cat RIGHT OUTER JOIN
                         dbo.ba_Catalogo INNER JOIN
                         dbo.ba_Archivo_Transferencia_Det INNER JOIN
                         dbo.ba_Archivo_Transferencia ON dbo.ba_Archivo_Transferencia_Det.IdEmpresa = dbo.ba_Archivo_Transferencia.IdEmpresa AND 
                         dbo.ba_Archivo_Transferencia_Det.IdArchivo = dbo.ba_Archivo_Transferencia.IdArchivo ON 
                         dbo.ba_Catalogo.IdCatalogo = dbo.ba_Archivo_Transferencia_Det.IdEstadoRegistro_cat ON 
                         dbo.Aca_Pre_Facturacion_det.IdInstitucion = dbo.ba_Archivo_Transferencia_Det.IdInstitucion_col AND 
                         dbo.Aca_Pre_Facturacion_det.IdPreFacturacion = dbo.ba_Archivo_Transferencia_Det.IdPreFacturacion_col AND 
                         dbo.Aca_Pre_Facturacion_det.Secuencia_Proce = dbo.ba_Archivo_Transferencia_Det.Secuencia_Proce_col AND 
                         dbo.Aca_Pre_Facturacion_det.secuencia = dbo.ba_Archivo_Transferencia_Det.secuencia_col LEFT OUTER JOIN
                         dbo.tb_persona AS per_op INNER JOIN
                         dbo.cp_orden_pago INNER JOIN
                         dbo.cp_orden_pago_det ON dbo.cp_orden_pago.IdEmpresa = dbo.cp_orden_pago_det.IdEmpresa AND 
                         dbo.cp_orden_pago.IdOrdenPago = dbo.cp_orden_pago_det.IdOrdenPago ON per_op.IdPersona = dbo.cp_orden_pago.IdPersona ON 
                         dbo.ba_Archivo_Transferencia_Det.IdEmpresa_OP = dbo.cp_orden_pago_det.IdEmpresa AND 
                         dbo.ba_Archivo_Transferencia_Det.IdOrdenPago = dbo.cp_orden_pago_det.IdOrdenPago AND 
                         dbo.ba_Archivo_Transferencia_Det.Secuencia_OP = dbo.cp_orden_pago_det.Secuencia LEFT OUTER JOIN
                         dbo.ro_empleado INNER JOIN
                         dbo.tb_persona AS per_rol ON dbo.ro_empleado.IdPersona = per_rol.IdPersona ON 
                         dbo.ba_Archivo_Transferencia_Det.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ba_Archivo_Transferencia_Det.IdEmpleado = dbo.ro_empleado.IdEmpleado LEFT OUTER JOIN
                         dbo.ct_cbtecble ON dbo.ba_Archivo_Transferencia_Det.IdEmpresa_pago = dbo.ct_cbtecble.IdEmpresa AND 
                         dbo.ba_Archivo_Transferencia_Det.IdTipoCbte_pago = dbo.ct_cbtecble.IdTipoCbte AND 
                         dbo.ba_Archivo_Transferencia_Det.IdCbteCble_pago = dbo.ct_cbtecble.IdCbteCble
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwba_Archivo_Transferencia_Det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'47
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_orden_pago_det"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1059
               Right = 247
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
      Begin ColumnWidths = 43
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwba_Archivo_Transferencia_Det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[84] 4[4] 2[4] 3) )"
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
         Top = -288
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "per_rol"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_Catalogo"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 399
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_Archivo_Transferencia_Det"
            Begin Extent = 
               Top = 317
               Left = 450
               Bottom = 653
               Right = 679
            End
            DisplayFlags = 280
            TopColumn = 19
         End
         Begin Table = "ba_Archivo_Transferencia"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 663
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "per_op"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 795
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_orden_pago"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 927
               Right = 2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwba_Archivo_Transferencia_Det';

