CREATE view  vwfa_ContabilizacionFactura_x_Item
as
SELECT        ISNULL(ROW_NUMBER() OVER (ORDER BY fac.IdEmpresa), 0) AS IdFila,
 fac.IdEmpresa, fac.IdSucursal, fac.IdBodega, fac.IdCbteVta, SUM(fac.vt_Subtotal) AS Subtotal, SUM(fac.vt_DescUnitario) AS Descuento, 
SUM(fac.vt_iva) AS iva, SUM(fac.vt_total) AS Total,                         Pro_Bod.IdCtaCble_Vta AS IdCtaCble_Ven0, Pro_Bod.IdCtaCble_Vta AS IdCtaCble_VenIva, dbo.fa_factura.vt_tipo_venta, dbo.fa_factura.vt_plazo, Pro_Bod.IdCtaCble_DesIva, Pro_Bod.IdCtaCble_Des0, 
                         fac.Secuencia, Pro_Bod.IdProducto, fac.IdCod_Impuesto_Iva, fac.IdCod_Impuesto_Ice, fac.IdCentroCosto, fac.IdCentroCosto_sub_centro_costo, dbo.tb_sis_Impuesto_x_ctacble.IdCtaCble AS IdCtaCble_Imp_Iva, 
                         tb_sis_Impuesto_x_ctacble_1.IdCtaCble AS IdCtaCble_Imp_Ice, fac.IdPunto_Cargo, fac.IdPunto_cargo_grupo
FROM            dbo.fa_factura_det AS fac INNER JOIN
                         dbo.fa_factura ON dbo.fa_factura.IdEmpresa = fac.IdEmpresa AND dbo.fa_factura.IdSucursal = fac.IdSucursal AND dbo.fa_factura.IdBodega = fac.IdBodega AND 
                         dbo.fa_factura.IdCbteVta = fac.IdCbteVta LEFT OUTER JOIN
                         dbo.tb_sis_Impuesto_x_ctacble ON fac.IdEmpresa = dbo.tb_sis_Impuesto_x_ctacble.IdEmpresa_cta AND fac.IdCod_Impuesto_Iva = dbo.tb_sis_Impuesto_x_ctacble.IdCod_Impuesto LEFT OUTER JOIN
                         dbo.tb_sis_Impuesto_x_ctacble AS tb_sis_Impuesto_x_ctacble_1 ON fac.IdEmpresa = tb_sis_Impuesto_x_ctacble_1.IdEmpresa_cta AND 
                         fac.IdCod_Impuesto_Ice = tb_sis_Impuesto_x_ctacble_1.IdCod_Impuesto LEFT OUTER JOIN
                         dbo.in_producto_x_tb_bodega AS Pro_Bod ON fac.IdEmpresa = Pro_Bod.IdEmpresa AND fac.IdSucursal = Pro_Bod.IdSucursal AND fac.IdBodega = Pro_Bod.IdBodega AND 
                         fac.IdProducto = Pro_Bod.IdProducto
GROUP BY fac.IdEmpresa, fac.IdSucursal, fac.IdBodega, fac.IdCbteVta, Pro_Bod.IdCtaCble_Vta, Pro_Bod.IdCtaCble_Vta, dbo.fa_factura.vt_tipo_venta, dbo.fa_factura.vt_plazo, Pro_Bod.IdCtaCble_DesIva, 
                         Pro_Bod.IdCtaCble_Des0, fac.Secuencia, Pro_Bod.IdProducto, fac.IdCod_Impuesto_Iva, fac.IdCod_Impuesto_Ice, fac.IdCentroCosto, fac.IdCentroCosto_sub_centro_costo, 
                         dbo.tb_sis_Impuesto_x_ctacble.IdCtaCble, tb_sis_Impuesto_x_ctacble_1.IdCtaCble, fac.IdPunto_Cargo, fac.IdPunto_cargo_grupo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_ContabilizacionFactura_x_Item';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[12] 4[4] 2[68] 3) )"
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
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_ContabilizacionFactura_x_Item';

