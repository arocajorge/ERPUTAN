CREATE VIEW Naturisa.vwCOMP_NATU_Rpt007
AS
SELECT OC.IdEmpresa, OC.IdSucursal, OC.IdOrdenCompra, OC.IdProveedor, OC.oc_NumDocumento, OC.Tipo, OC.IdTerminoPago, OC.oc_plazo AS Plazo, OC.oc_fecha AS Fecha, OC.oc_flete AS Flete, OC.oc_observacion AS Observacion, 
                  OC.Estado, OC.IdSolicitante, OC.IdComprador, OC.IdDepartamento, OC_det.Secuencia, OC_det.IdProducto, OC_det.do_Cantidad AS cantidad, OC_det.do_precioCompra AS precio, OC_det.do_porc_des AS por_desc, 
                  OC_det.do_descuento AS valor_descuento, OC_det.do_subtotal AS subtotal, OC_det.do_iva AS iva, OC_det.do_total AS total, OC_det.do_peso AS peso, Prod.pr_codigo AS cod_producto, Prod.pr_descripcion AS nom_producto, 
                  sucu.Su_Descripcion AS sucursal, empr.em_nombre AS empresa, empr.em_ruc AS ruc_empresa, empr.em_logo AS logo_empresa, prove.pr_nombre AS nom_proveedor, per_prov.pe_cedulaRuc AS ced_ruc_provee, 
                  per_prov.pe_direccion AS direc_provee, per_prov.pe_telefonoOfic AS telef_provee, dbo.in_UnidadMedida.Descripcion AS NomUnidad, dbo.com_comprador.Descripcion AS Nom_comprador, OC_det.IdCentroCosto, 
                  OC_det.IdCentroCosto_sub_centro_costo, dbo.ct_centro_costo.Centro_costo AS nom_centro_costo, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_sub_centro_costo, OC_det.do_observacion AS Detalle_x_Items, 
                  OC_det.IdPunto_cargo, dbo.ct_punto_cargo.nom_punto_cargo, empr.em_direccion, dbo.com_solicitante.nom_solicitante, dbo.com_Motivo_Orden_Compra.Descripcion, dbo.com_TerminoPago.Descripcion AS Nom_TerminoPago, 
                  dbo.com_departamento.nom_departamento AS departamento, dbo.com_estado_cierre.Descripcion AS nom_EstadoCierre, prove.pr_codigo, sucu.codigo AS CodigoSucursal, dbo.seg_usuario.Nombre AS NombreUsuarioApro, 
                  SU.Su_Descripcion AS SucursalDestino, CASE WHEN co.oc_IdOrdenCompra IS NULL THEN CAST(0 AS bit) ELSE CAST(1 AS bit) END AS EsProcesoSolicitud, co.IdOrdenPedido, OC.oc_fechaVencimiento, ped.ObservacionGA
FROM     dbo.com_Motivo_Orden_Compra RIGHT OUTER JOIN
                  dbo.seg_usuario RIGHT OUTER JOIN
                  dbo.com_ordencompra_local AS OC INNER JOIN
                  dbo.com_ordencompra_local_det AS OC_det ON OC.IdEmpresa = OC_det.IdEmpresa AND OC.IdSucursal = OC_det.IdSucursal AND OC.IdOrdenCompra = OC_det.IdOrdenCompra INNER JOIN
                  dbo.cp_proveedor AS prove ON OC.IdEmpresa = prove.IdEmpresa AND OC.IdProveedor = prove.IdProveedor INNER JOIN
                  dbo.tb_sucursal AS sucu ON OC.IdEmpresa = sucu.IdEmpresa AND OC.IdSucursal = sucu.IdSucursal INNER JOIN
                  dbo.tb_empresa AS empr ON sucu.IdEmpresa = empr.IdEmpresa INNER JOIN
                  dbo.in_Producto AS Prod ON OC_det.IdEmpresa = Prod.IdEmpresa AND OC_det.IdProducto = Prod.IdProducto INNER JOIN
                  dbo.tb_persona AS per_prov ON prove.IdPersona = per_prov.IdPersona INNER JOIN
                  dbo.com_comprador ON OC.IdEmpresa = dbo.com_comprador.IdEmpresa AND OC.IdComprador = dbo.com_comprador.IdComprador INNER JOIN
                  dbo.com_TerminoPago ON OC.IdTerminoPago = dbo.com_TerminoPago.IdTerminoPago INNER JOIN
                  dbo.com_departamento ON OC.IdEmpresa = dbo.com_departamento.IdEmpresa AND OC.IdDepartamento = dbo.com_departamento.IdDepartamento INNER JOIN
                  dbo.com_estado_cierre ON OC.IdEstado_cierre = dbo.com_estado_cierre.IdEstado_cierre ON dbo.seg_usuario.IdUsuario = OC.IdUsuario_Aprueba ON dbo.com_Motivo_Orden_Compra.IdEmpresa = OC.IdEmpresa AND 
                  dbo.com_Motivo_Orden_Compra.IdMotivo = OC.IdMotivo LEFT OUTER JOIN
                  dbo.ct_centro_costo_sub_centro_costo ON OC_det.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                  OC_det.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo LEFT OUTER JOIN
                  dbo.in_UnidadMedida ON OC_det.IdUnidadMedida = dbo.in_UnidadMedida.IdUnidadMedida LEFT OUTER JOIN
                  dbo.com_solicitante ON OC.IdEmpresa = dbo.com_solicitante.IdEmpresa AND OC.IdSolicitante = dbo.com_solicitante.IdSolicitante LEFT OUTER JOIN
                  dbo.ct_punto_cargo ON OC_det.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND OC_det.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo LEFT OUTER JOIN
                  dbo.ct_centro_costo ON OC_det.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND OC_det.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto LEFT OUTER JOIN
                  dbo.tb_sucursal AS SU ON OC_det.IdEmpresa = SU.IdEmpresa AND OC_det.IdSucursalDestino = SU.IdSucursal LEFT OUTER JOIN
                  dbo.com_CotizacionPedido AS co ON co.IdEmpresa = OC.IdEmpresa AND co.IdSucursal = OC.IdSucursal AND co.oc_IdOrdenCompra = OC.IdOrdenCompra LEFT OUTER JOIN
                  dbo.com_OrdenPedido AS ped ON co.IdEmpresa = ped.IdEmpresa AND co.IdOrdenPedido = ped.IdOrdenPedido
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 3, @level0type = N'SCHEMA', @level0name = N'Naturisa', @level1type = N'VIEW', @level1name = N'vwCOMP_NATU_Rpt007';




GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' 280
            TopColumn = 0
         End
         Begin Table = "Prod"
            Begin Extent = 
               Top = 138
               Left = 210
               Bottom = 268
               Right = 444
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "per_prov"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_comprador"
            Begin Extent = 
               Top = 270
               Left = 308
               Bottom = 400
               Right = 517
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_TerminoPago"
            Begin Extent = 
               Top = 252
               Left = 38
               Bottom = 382
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_departamento"
            Begin Extent = 
               Top = 271
               Left = 154
               Bottom = 401
               Right = 363
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_estado_cierre"
            Begin Extent = 
               Top = 6
               Left = 339
               Bottom = 136
               Right = 548
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_UnidadMedida"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 532
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_solicitante"
            Begin Extent = 
               Top = 402
               Left = 286
               Bottom = 532
               Right = 495
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_punto_cargo"
            Begin Extent = 
               Top = 4
               Left = 0
               Bottom = 134
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 288
               Left = 0
               Bottom = 418
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SU"
            Begin Extent = 
               Top = 7
               Left = 1421
               Bottom = 170
               Right = 1693
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "co"
            Begin Extent = 
               Top = 175
               Left = 1421
               Bottom = 338
               Right = 1645
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ped"
            Begin Extent = 
               Top = 399
               Left = 915
               Bottom = 562
               Right = 1151
            End
            DisplayFlags = 280', @level0type = N'SCHEMA', @level0name = N'Naturisa', @level1type = N'VIEW', @level1name = N'vwCOMP_NATU_Rpt007';




GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[30] 4[4] 2[44] 3) )"
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
         Begin Table = "com_Motivo_Orden_Compra"
            Begin Extent = 
               Top = 39
               Left = 0
               Bottom = 169
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "seg_usuario"
            Begin Extent = 
               Top = 7
               Left = 1079
               Bottom = 393
               Right = 1373
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "OC"
            Begin Extent = 
               Top = 51
               Left = 650
               Bottom = 540
               Right = 867
            End
            DisplayFlags = 280
            TopColumn = 16
         End
         Begin Table = "OC_det"
            Begin Extent = 
               Top = 32
               Left = 234
               Bottom = 162
               Right = 497
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prove"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sucu"
            Begin Extent = 
               Top = 194
               Left = 138
               Bottom = 402
               Right = 368
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "empr"
            Begin Extent = 
               Top = 19
               Left = 32
               Bottom = 149
               Right = 251
            End
            DisplayFlags =', @level0type = N'SCHEMA', @level0name = N'Naturisa', @level1type = N'VIEW', @level1name = N'vwCOMP_NATU_Rpt007';




GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane3', @value = N'
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
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
', @level0type = N'SCHEMA', @level0name = N'Naturisa', @level1type = N'VIEW', @level1name = N'vwCOMP_NATU_Rpt007';

