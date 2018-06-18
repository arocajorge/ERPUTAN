CREATE VIEW mobileSCI.vw_oc_x_aprobar
AS
SELECT        ISNULL(ROW_NUMBER() OVER (ORDER BY dbo.com_ordencompra_local_det.IdEmpresa), 0) IdRow, dbo.com_ordencompra_local_det.IdEmpresa, dbo.com_ordencompra_local_det.IdSucursal, 
dbo.com_ordencompra_local_det.IdOrdenCompra, dbo.com_ordencompra_local_det.Secuencia, dbo.com_ordencompra_local_det.IdProducto, dbo.com_ordencompra_local_det.IdUnidadMedida, dbo.com_ordencompra_local.IdProveedor, 
isnull(SUM(dbo.com_ordencompra_local_det.do_Cantidad), 0) AS cant_oc, ISNULL(SUM(dbo.in_Ing_Egr_Inven_det.dm_cantidad_sinConversion), 0) + isnull(sum(mov.cantidad),0)  AS cant_in, isnull(SUM(dbo.com_ordencompra_local_det.do_Cantidad) 
- ISNULL(SUM(dbo.in_Ing_Egr_Inven_det.dm_cantidad_sinConversion), 0), 0) - isnull(sum(mov.cantidad),0) AS saldo, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_codigo, dbo.in_UnidadMedida.Descripcion, dbo.tb_persona.pe_nombreCompleto, 
dbo.com_ordencompra_local.oc_fecha, dbo.com_ordencompra_local.oc_observacion, dbo.in_Producto.IdUnidadMedida_Consumo
FROM            dbo.tb_persona INNER JOIN
                         dbo.cp_proveedor INNER JOIN
                         dbo.com_ordencompra_local INNER JOIN
                         dbo.com_ordencompra_local_det ON dbo.com_ordencompra_local.IdEmpresa = dbo.com_ordencompra_local_det.IdEmpresa AND dbo.com_ordencompra_local.IdSucursal = dbo.com_ordencompra_local_det.IdSucursal AND 
                         dbo.com_ordencompra_local.IdOrdenCompra = dbo.com_ordencompra_local_det.IdOrdenCompra ON dbo.cp_proveedor.IdEmpresa = dbo.com_ordencompra_local.IdEmpresa AND 
                         dbo.cp_proveedor.IdProveedor = dbo.com_ordencompra_local.IdProveedor INNER JOIN
                         dbo.in_Producto ON dbo.com_ordencompra_local_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.com_ordencompra_local_det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                         dbo.in_UnidadMedida ON dbo.com_ordencompra_local_det.IdUnidadMedida = dbo.in_UnidadMedida.IdUnidadMedida ON dbo.tb_persona.IdPersona = dbo.cp_proveedor.IdPersona INNER JOIN
                         mobileSCI.tbl_producto ON dbo.in_Producto.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND dbo.in_Producto.IdProducto = mobileSCI.tbl_producto.IdProducto AND 
                         dbo.in_Producto.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND dbo.in_Producto.IdProducto = mobileSCI.tbl_producto.IdProducto AND dbo.in_Producto.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND 
                         dbo.in_Producto.IdProducto = mobileSCI.tbl_producto.IdProducto AND dbo.in_Producto.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND dbo.in_Producto.IdProducto = mobileSCI.tbl_producto.IdProducto LEFT OUTER JOIN
                         dbo.in_Ing_Egr_Inven INNER JOIN
                         dbo.in_Ing_Egr_Inven_det ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND dbo.in_Ing_Egr_Inven.IdNumMovi = dbo.in_Ing_Egr_Inven_det.IdNumMovi ON 
                         dbo.com_ordencompra_local_det.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa_oc AND dbo.com_ordencompra_local_det.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal_oc AND 
                         dbo.com_ordencompra_local_det.IdOrdenCompra = dbo.in_Ing_Egr_Inven_det.IdOrdenCompra AND dbo.com_ordencompra_local_det.Secuencia = dbo.in_Ing_Egr_Inven_det.Secuencia_oc
						 LEFT JOIN mobileSCI.tbl_movimientos_det as mov on mov.IdEmpresa_oc = dbo.com_ordencompra_local_det.IdEmpresa and mov.IdSucursal_oc = dbo.com_ordencompra_local_det.IdSucursal
						 and mov.IdOrdenCompra = dbo.com_ordencompra_local_det.IdOrdenCompra and mov.secuencia_oc = dbo.com_ordencompra_local_det.Secuencia and mov.Aprobado = 0 and mov.Estado = 'A'
WHERE        (dbo.com_ordencompra_local.IdEstadoAprobacion_cat = 'APRO') AND (dbo.com_ordencompra_local.IdEstado_cierre <> 'CER') AND (dbo.com_ordencompra_local.Estado = 'A') AND 
                         (dbo.com_ordencompra_local.oc_fecha BETWEEN DATEADD(MONTH, - 3, GETDATE()) AND GETDATE())
GROUP BY dbo.com_ordencompra_local_det.IdEmpresa, dbo.com_ordencompra_local_det.IdSucursal, dbo.com_ordencompra_local_det.IdOrdenCompra, dbo.com_ordencompra_local_det.Secuencia, 
                         dbo.com_ordencompra_local_det.IdProducto, dbo.com_ordencompra_local_det.IdUnidadMedida, dbo.com_ordencompra_local.IdProveedor, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_codigo, 
                         dbo.in_UnidadMedida.Descripcion, dbo.tb_persona.pe_nombreCompleto, dbo.com_ordencompra_local.oc_fecha, dbo.com_ordencompra_local.oc_observacion, dbo.in_Producto.IdUnidadMedida_Consumo
HAVING        (ROUND(SUM(dbo.com_ordencompra_local_det.do_Cantidad) - ISNULL(SUM(dbo.in_Ing_Egr_Inven_det.dm_cantidad_sinConversion), 0), 2) > 0)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'mobileSCI', @level1type = N'VIEW', @level1name = N'vw_oc_x_aprobar';


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
', @level0type = N'SCHEMA', @level0name = N'mobileSCI', @level1type = N'VIEW', @level1name = N'vw_oc_x_aprobar';

