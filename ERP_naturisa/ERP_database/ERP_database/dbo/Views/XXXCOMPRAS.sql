CREATE VIEW [dbo].[XXXCOMPRAS]
AS
SELECT CASE WHEN dbo.com_ordencompra_local_det.IdEmpresa = 1 THEN 'NATURISA S.A' WHEN dbo.com_ordencompra_local_det.IdEmpresa = 3 THEN 'CAMARONERA RIO NILO S.A. RIONILSA' END AS Empresa, 
                  dbo.com_ordencompra_local_det.IdOrdenCompra, dbo.in_Producto.IdProducto, dbo.in_Producto.pr_descripcion AS NomProducto, dbo.com_ordencompra_local_det.do_Cantidad, dbo.com_ordencompra_local_det.do_precioCompra, 
                  dbo.com_ordencompra_local_det.do_porc_des, dbo.com_ordencompra_local_det.do_descuento, dbo.com_ordencompra_local_det.do_precioFinal, dbo.com_ordencompra_local_det.do_subtotal, dbo.com_ordencompra_local_det.Por_Iva, 
                  dbo.com_ordencompra_local_det.do_iva, dbo.com_ordencompra_local_det.do_total, dbo.com_ordencompra_local_det.IdUnidadMedida, dbo.in_UnidadMedida.Descripcion AS NomUnidadMedida, com.Descripcion AS Comprador, 
                  com.IdUsuario_com, dbo.com_ordencompra_local.oc_fecha, MONTH(dbo.com_ordencompra_local.oc_fecha) AS MES, YEAR(dbo.com_ordencompra_local.oc_fecha) AS ANIO, dbo.com_ordencompra_local.oc_plazo, 
                  dbo.com_ordencompra_local.IdProveedor, LTRIM(RTRIM(dbo.tb_persona.pe_nombreCompleto)) AS NomProveedor, dbo.com_ordencompra_local_det.IdEmpresa, dbo.com_ordencompra_local_det.IdSucursal, 
                  dbo.com_ordencompra_local_det.Secuencia, c.IdCategoria, c.ca_Categoria, dbo.com_TerminoPago.IdTerminoPago, dbo.com_TerminoPago.Descripcion AS NomTerminoPago, dbo.com_ordencompra_local.IdEstadoAprobacion_cat, 
                  CASE WHEN com_ordencompra_local.IdEstadoAprobacion_cat = 'xAPRO' THEN 'POR APROBAR' WHEN com_ordencompra_local.IdEstadoAprobacion_cat = 'APRO' THEN 'APROBADO' ELSE 'ANULADO' END AS EstadoAprobacion, 
                  dbo.com_ordencompra_local.IdEstado_cierre, pc.pc_Cuenta, dbo.com_ordencompra_local.IdUsuario AS IdUsuarioCreacion, dbo.com_ordencompra_local.Fecha_Transac AS FechaCreacion, dbo.com_ordencompra_local.IdUsuarioUltMod, 
                  dbo.com_ordencompra_local.Fecha_UltMod, inv.CantidadIng, dbo.com_ordencompra_local.oc_observacion
FROM     dbo.com_ordencompra_local INNER JOIN
                  dbo.com_ordencompra_local_det ON dbo.com_ordencompra_local.IdEmpresa = dbo.com_ordencompra_local_det.IdEmpresa AND dbo.com_ordencompra_local.IdSucursal = dbo.com_ordencompra_local_det.IdSucursal AND 
                  dbo.com_ordencompra_local.IdOrdenCompra = dbo.com_ordencompra_local_det.IdOrdenCompra INNER JOIN
                  dbo.in_Producto ON dbo.com_ordencompra_local_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.com_ordencompra_local_det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                  dbo.cp_proveedor ON dbo.com_ordencompra_local.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.com_ordencompra_local.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                  dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                  dbo.com_TerminoPago ON dbo.com_ordencompra_local.IdTerminoPago = dbo.com_TerminoPago.IdTerminoPago INNER JOIN
                  dbo.in_UnidadMedida ON dbo.com_ordencompra_local_det.IdUnidadMedida = dbo.in_UnidadMedida.IdUnidadMedida INNER JOIN
                  dbo.in_categorias AS c ON dbo.in_Producto.IdEmpresa = c.IdEmpresa AND dbo.in_Producto.IdCategoria = c.IdCategoria INNER JOIN
                  dbo.com_comprador AS com ON dbo.com_ordencompra_local.IdEmpresa = com.IdEmpresa AND dbo.com_ordencompra_local.IdComprador = com.IdComprador INNER JOIN
                  dbo.ct_plancta AS pc ON dbo.cp_proveedor.IdEmpresa = pc.IdEmpresa AND dbo.cp_proveedor.IdCtaCble_CXP = pc.IdCtaCble LEFT OUTER JOIN
                      (SELECT IdEmpresa, IdSucursal, IdOrdenCompra, Secuencia_oc, SUM(dm_cantidad_sinConversion) AS CantidadIng
                       FROM      dbo.in_Ing_Egr_Inven_det AS i
                       GROUP BY IdEmpresa, IdSucursal, IdOrdenCompra, Secuencia_oc) AS inv ON dbo.com_ordencompra_local_det.Secuencia = inv.Secuencia_oc AND dbo.com_ordencompra_local_det.IdOrdenCompra = inv.IdOrdenCompra AND 
                  dbo.com_ordencompra_local_det.IdSucursal = inv.IdSucursal AND inv.IdEmpresa = dbo.com_ordencompra_local_det.IdEmpresa
WHERE  (dbo.com_ordencompra_local.IdEmpresa = 3) AND (dbo.com_ordencompra_local.oc_fecha BETWEEN DATEFROMPARTS(2019, 1, 1) AND DATEFROMPARTS(2019, 8, 31)) AND (dbo.com_ordencompra_local.Estado = 'A')
GO


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'XXXCOMPRAS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N't = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 928
               Right = 267
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com"
            Begin Extent = 
               Top = 666
               Left = 286
               Bottom = 796
               Right = 465
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pc"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1060
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "inv"
            Begin Extent = 
               Top = 7
               Left = 520
               Bottom = 170
               Right = 722
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'XXXCOMPRAS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "com_ordencompra_local"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 255
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_ordencompra_local_det"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 272
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 532
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 664
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_TerminoPago"
            Begin Extent = 
               Top = 6
               Left = 293
               Bottom = 136
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_UnidadMedida"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 796
               Righ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'XXXCOMPRAS';

