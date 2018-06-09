CREATE VIEW Edehsa.vwprd_Guia_Remision_Electronica
AS
SELECT     dbo.fa_guia_remision.IdEmpresa, dbo.fa_guia_remision.IdSucursal, dbo.fa_guia_remision.IdBodega, dbo.fa_guia_remision.IdGuiaRemision, 
                      dbo.fa_guia_remision.CodGuiaRemision, dbo.fa_guia_remision.CodDocumentoTipo, dbo.fa_guia_remision.Serie1, dbo.fa_guia_remision.Serie2, 
                      dbo.fa_guia_remision.NumGuia_Preimpresa, dbo.fa_guia_remision.NUAutorizacion, dbo.fa_guia_remision.Fecha_Autorizacion, dbo.fa_guia_remision.IdCliente, 
                      dbo.fa_guia_remision.IdVendedor, dbo.fa_guia_remision.gi_fecha, dbo.fa_guia_remision.gi_fech_venc, dbo.fa_guia_remision.gi_Observacion, 
                      dbo.fa_guia_remision.gi_TotalKilos, dbo.fa_guia_remision.gi_plazo, dbo.fa_guia_remision.gi_TotalQuintales, dbo.fa_guia_remision.IdUsuario, 
                      dbo.fa_guia_remision.IdUsuarioUltMod, dbo.fa_guia_remision.Fecha_Transac, dbo.fa_guia_remision.Fecha_UltMod, dbo.fa_guia_remision.IdUsuarioUltAnu, 
                      dbo.fa_guia_remision.nom_pc, dbo.fa_guia_remision.Fecha_UltAnu, dbo.fa_guia_remision.ip, dbo.fa_guia_remision.Estado, dbo.fa_guia_remision.MotiAnula, 
                      dbo.fa_guia_remision.Impreso, dbo.fa_guia_remision.IdPeriodo, dbo.fa_guia_remision.gi_flete, dbo.fa_guia_remision.gi_interes, dbo.fa_guia_remision.gi_seguro, 
                      dbo.fa_guia_remision.gi_OtroValor1, dbo.fa_guia_remision.gi_OtroValor2, dbo.fa_guia_remision.gi_FechaIniTraslado, dbo.fa_guia_remision.placa, 
                      dbo.fa_guia_remision.gi_FechaFinTraslado, dbo.fa_guia_remision.ruta, dbo.fa_guia_remision.Direccion_Origen, dbo.fa_guia_remision.Direccion_Destino, 
                      dbo.fa_guia_remision.idMotivo_traslado, dbo.tb_transportista.IdTransportista, dbo.tb_transportista.Cedula AS Cedula_Transportista, 
                      dbo.tb_transportista.Nombre AS Nombre_Transportista, dbo.fa_guia_remision_det.IdProducto, dbo.fa_guia_remision_det.gi_cantidad, 
                      dbo.fa_guia_remision_det.gi_Precio, dbo.fa_guia_remision_det.gi_PorDescUnitario, dbo.fa_guia_remision_det.gi_DescUnitario, 
                      dbo.fa_guia_remision_det.gi_PrecioFinal, dbo.fa_guia_remision_det.gi_Subtotal, dbo.fa_guia_remision_det.gi_iva, dbo.fa_guia_remision_det.gi_total, 
                      dbo.fa_guia_remision_det.gi_costo, dbo.fa_guia_remision_det.gi_tieneIVA, dbo.fa_guia_remision_det.gi_detallexItems, dbo.fa_guia_remision_det.gi_peso, 
                      dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.IdTipoPersona, dbo.tb_persona.IdTipoDocumento, dbo.tb_persona.pe_razonSocial, 
                      dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_direccion, dbo.tb_persona.pe_correo, 
                      dbo.tb_empresa.em_nombre, dbo.tb_empresa.RazonSocial, dbo.tb_empresa.NombreComercial, dbo.tb_empresa.em_direccion, 
                      Edehsa.prd_motivo_traslado.descripcion_motivo_traslado, dbo.tb_empresa.em_ruc, dbo.tb_empresa.ObligadoAllevarConta, dbo.tb_empresa.ContribuyenteEspecial, 
                      dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_descripcion_2, dbo.in_UnidadMedida.Descripcion AS unidad_medida_consumo, 
                      dbo.prd_Obra.CodObra, dbo.prd_Obra.Descripcion AS descripcion_obra, dbo.tb_sucursal.Su_Direccion, dbo.prd_Despacho.ruta AS ruta_despacho
FROM         dbo.fa_guia_remision INNER JOIN
                      dbo.fa_guia_remision_det ON dbo.fa_guia_remision.IdEmpresa = dbo.fa_guia_remision_det.IdEmpresa AND 
                      dbo.fa_guia_remision.IdSucursal = dbo.fa_guia_remision_det.IdSucursal AND dbo.fa_guia_remision.IdBodega = dbo.fa_guia_remision_det.IdBodega AND 
                      dbo.fa_guia_remision.IdGuiaRemision = dbo.fa_guia_remision_det.IdGuiaRemision INNER JOIN
                      dbo.tb_empresa ON dbo.fa_guia_remision.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                      dbo.tb_transportista ON dbo.fa_guia_remision.IdEmpresa = dbo.tb_transportista.IdEmpresa AND 
                      dbo.fa_guia_remision.IdTransportista = dbo.tb_transportista.IdTransportista INNER JOIN
                      dbo.tb_persona ON dbo.fa_guia_remision.IdCliente = dbo.tb_persona.IdPersona INNER JOIN
                      Edehsa.prd_motivo_traslado ON dbo.fa_guia_remision.IdEmpresa = Edehsa.prd_motivo_traslado.IdEmpresa AND 
                      dbo.fa_guia_remision.idMotivo_traslado = Edehsa.prd_motivo_traslado.IdMotivo_traslado INNER JOIN
                      dbo.tb_sucursal ON dbo.tb_empresa.IdEmpresa = dbo.tb_sucursal.IdEmpresa INNER JOIN
                      dbo.in_Producto ON dbo.fa_guia_remision_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                      dbo.fa_guia_remision_det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                      dbo.in_UnidadMedida ON dbo.in_Producto.IdUnidadMedida_Consumo = dbo.in_UnidadMedida.IdUnidadMedida AND 
                      dbo.in_Producto.IdUnidadMedida_Consumo = dbo.in_UnidadMedida.IdUnidadMedida INNER JOIN
                      dbo.prd_Despacho ON dbo.fa_guia_remision.IdEmpresa = dbo.prd_Despacho.IdEmpresa AND dbo.fa_guia_remision.IdSucursal = dbo.prd_Despacho.IdSucursal AND 
                      dbo.fa_guia_remision.IdBodega = dbo.prd_Despacho.IdBodega AND dbo.fa_guia_remision.CodGuiaRemision = dbo.prd_Despacho.NumGuiaRemision INNER JOIN
                      dbo.prd_Obra ON dbo.prd_Despacho.IdEmpresa = dbo.prd_Obra.IdEmpresa AND dbo.prd_Despacho.CodObra = dbo.prd_Obra.CodObra
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwprd_Guia_Remision_Electronica';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       Right = 1174
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 35
               Left = 1305
               Bottom = 263
               Right = 1513
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "in_UnidadMedida"
            Begin Extent = 
               Top = 65
               Left = 1570
               Bottom = 173
               Right = 1759
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Despacho"
            Begin Extent = 
               Top = 257
               Left = 993
               Bottom = 440
               Right = 1182
            End
            DisplayFlags = 280
            TopColumn = 15
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 270
               Left = 1372
               Bottom = 378
               Right = 1561
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
      Begin ColumnWidths = 85
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1830
         Width = 1515
         Width = 2430
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 2190
         Width = 1635
         Width = 1200
         Width = 3495
         Width = 1950
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2415
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
         Alias = 2190
         Table = 2550
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
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwprd_Guia_Remision_Electronica';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[47] 4[25] 2[4] 3) )"
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
         Top = -384
         Left = -358
      End
      Begin Tables = 
         Begin Table = "fa_guia_remision"
            Begin Extent = 
               Top = 12
               Left = 483
               Bottom = 322
               Right = 727
            End
            DisplayFlags = 280
            TopColumn = 27
         End
         Begin Table = "fa_guia_remision_det"
            Begin Extent = 
               Top = 9
               Left = 993
               Bottom = 255
               Right = 1237
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "tb_empresa"
            Begin Extent = 
               Top = 448
               Left = 604
               Bottom = 609
               Right = 802
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_transportista"
            Begin Extent = 
               Top = 0
               Left = 23
               Bottom = 163
               Right = 267
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 344
               Left = 20
               Bottom = 639
               Right = 294
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_motivo_traslado (Edehsa)"
            Begin Extent = 
               Top = 169
               Left = 19
               Bottom = 332
               Right = 303
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 465
               Left = 937
               Bottom = 588
        ', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwprd_Guia_Remision_Electronica';

