CREATE VIEW [dbo].[vwfa_factura] AS
SELECT        IdEmpresa, IdBodega, IdCbteVta, IdSucursal, CodCbteVta, vt_tipoDoc, vt_serie1, vt_serie2, vt_NumFactura, IdCliente, IdVendedor, vt_fecha, vt_plazo, vt_fech_venc, 
                         vt_tipo_venta, vt_Observacion, IdPeriodo, vt_anio, vt_mes, vt_flete, vt_interes, vt_OtroValor1, vt_OtroValor2, IdUsuario, Fecha_Transaccion, IdUsuarioUltModi, 
                         Fecha_UltMod, IdUsuarioUltAnu, Fecha_UltAnu, MotivoAnulacion, nom_pc, ip, Estado, Su_Descripcion, bo_Descripcion, Secuencia, Ve_Vendedor, 
                         pe_nombreCompleto, vt_autorizacion, IdTipoDocumento, pe_cedulaRuc, IdCaja, IdEmpresa_nc_anu, IdSucursal_nc_anu, IdBodega_nc_anu, IdNota_nc_anu, 
                         vt_seguro, SUM(vt_Subtotal) AS vt_Subtotal, SUM(vt_iva) AS vt_iva, SUM(vt_total) AS vt_total, SUM(vt_Subtotal0) AS vt_Subtotal0, SUM(vt_SubtotalIva) 
                         AS vt_SubtotalIva,fact_agrupadas.IdPuntoVta
FROM            (SELECT        dbo.fa_factura.IdEmpresa, dbo.fa_factura.IdBodega, dbo.fa_factura.IdCbteVta, dbo.fa_factura.IdSucursal, dbo.fa_factura.CodCbteVta, 
                                                    dbo.fa_factura.vt_tipoDoc, dbo.fa_factura.vt_serie1, dbo.fa_factura.vt_serie2, dbo.fa_factura.vt_NumFactura, dbo.fa_factura.IdCliente, 
                                                    dbo.fa_factura.IdVendedor, dbo.fa_factura.vt_fecha, dbo.fa_factura.vt_plazo, dbo.fa_factura.vt_fech_venc, dbo.fa_factura.vt_tipo_venta, 
                                                    dbo.fa_factura.vt_Observacion, dbo.fa_factura.IdPeriodo, dbo.fa_factura.vt_anio, dbo.fa_factura.vt_mes, dbo.fa_factura.vt_flete, 
                                                    dbo.fa_factura.vt_interes, dbo.fa_factura.vt_OtroValor1, dbo.fa_factura.vt_OtroValor2, dbo.fa_factura.IdUsuario, dbo.fa_factura.Fecha_Transaccion, 
                                                    dbo.fa_factura.IdUsuarioUltModi, dbo.fa_factura.Fecha_UltMod, dbo.fa_factura.IdUsuarioUltAnu, dbo.fa_factura.Fecha_UltAnu, 
                                                    dbo.fa_factura.MotivoAnulacion, dbo.fa_factura.nom_pc, dbo.fa_factura.ip, dbo.fa_factura.Estado, dbo.tb_sucursal.Su_Descripcion, 
                                                    dbo.tb_bodega.bo_Descripcion, 0 AS Secuencia, dbo.fa_Vendedor.Ve_Vendedor, dbo.tb_persona.pe_nombreCompleto, dbo.fa_factura.vt_autorizacion, 
                                                    dbo.tb_persona.IdTipoDocumento, dbo.tb_persona.pe_cedulaRuc, dbo.fa_factura.IdCaja, dbo.fa_factura.IdEmpresa_nc_anu, 
                                                    dbo.fa_factura.IdSucursal_nc_anu, dbo.fa_factura.IdBodega_nc_anu, dbo.fa_factura.IdNota_nc_anu, dbo.fa_factura.vt_seguro, 
                                                    SUM(dbo.fa_factura_det.vt_Subtotal) AS vt_Subtotal, SUM(dbo.fa_factura_det.vt_iva) AS vt_iva, SUM(dbo.fa_factura_det.vt_total) AS vt_total, 
                                                    CASE WHEN dbo.fa_factura_det.IdCod_Impuesto_Iva = 'IVA0' THEN SUM(dbo.fa_factura_det.vt_Subtotal) ELSE 0 END AS vt_Subtotal0, 
                                                    CASE WHEN dbo.fa_factura_det.IdCod_Impuesto_Iva <> 'IVA0' THEN SUM(dbo.fa_factura_det.vt_Subtotal) ELSE 0 END AS vt_SubtotalIva, 
                                                    dbo.fa_factura.IdPuntoVta
                          FROM            dbo.fa_factura INNER JOIN
                                                    dbo.tb_sucursal ON dbo.fa_factura.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.fa_factura.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                                                    dbo.tb_bodega ON dbo.tb_sucursal.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.tb_sucursal.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                                                    dbo.fa_factura.IdBodega = dbo.tb_bodega.IdBodega INNER JOIN
                                                    dbo.fa_factura_det ON dbo.fa_factura.IdEmpresa = dbo.fa_factura_det.IdEmpresa AND dbo.fa_factura.IdSucursal = dbo.fa_factura_det.IdSucursal AND 
                                                    dbo.fa_factura.IdBodega = dbo.fa_factura_det.IdBodega AND dbo.fa_factura.IdCbteVta = dbo.fa_factura_det.IdCbteVta INNER JOIN
                                                    dbo.fa_cliente ON dbo.fa_factura.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.fa_factura.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                                                    dbo.fa_Vendedor ON dbo.fa_factura.IdEmpresa = dbo.fa_Vendedor.IdEmpresa AND dbo.fa_factura.IdVendedor = dbo.fa_Vendedor.IdVendedor INNER JOIN
                                                    dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona
                          GROUP BY dbo.fa_factura.IdEmpresa, dbo.fa_factura.IdBodega, dbo.fa_factura.IdCbteVta, dbo.fa_factura.IdSucursal, dbo.fa_factura.CodCbteVta, 
                                                    dbo.fa_factura.vt_tipoDoc, dbo.fa_factura.vt_serie1, dbo.fa_factura.vt_serie2, dbo.fa_factura.vt_NumFactura, dbo.fa_factura.IdCliente, 
                                                    dbo.fa_factura.IdVendedor, dbo.fa_factura.vt_fecha, dbo.fa_factura.vt_plazo, dbo.fa_factura.vt_fech_venc, dbo.fa_factura.vt_tipo_venta, 
                                                    dbo.fa_factura.vt_Observacion, dbo.fa_factura.IdPeriodo, dbo.fa_factura.vt_anio, dbo.fa_factura.vt_mes, dbo.fa_factura.vt_flete, 
                                                    dbo.fa_factura.vt_interes, dbo.fa_factura.vt_OtroValor1, dbo.fa_factura.vt_OtroValor2, dbo.fa_factura.IdUsuario, dbo.fa_factura.Fecha_Transaccion, 
                                                    dbo.fa_factura.IdUsuarioUltModi, dbo.fa_factura.Fecha_UltMod, dbo.fa_factura.IdUsuarioUltAnu, dbo.fa_factura.Fecha_UltAnu, 
                                                    dbo.fa_factura.MotivoAnulacion, dbo.fa_factura.nom_pc, dbo.fa_factura.ip, dbo.fa_factura.Estado, dbo.tb_sucursal.Su_Descripcion, 
                                                    dbo.tb_bodega.bo_Descripcion, dbo.fa_Vendedor.Ve_Vendedor, dbo.tb_persona.pe_nombreCompleto, dbo.fa_factura.vt_autorizacion, 
                                                    dbo.tb_persona.IdTipoDocumento, dbo.tb_persona.pe_cedulaRuc, dbo.fa_factura.IdCaja, dbo.fa_factura.IdEmpresa_nc_anu, 
                                                    dbo.fa_factura.IdSucursal_nc_anu, dbo.fa_factura.IdBodega_nc_anu, dbo.fa_factura.IdNota_nc_anu, dbo.fa_factura.vt_seguro, 
                                                    dbo.fa_factura_det.IdCod_Impuesto_Iva, dbo.fa_factura.IdPuntoVta) AS fact_agrupadas
GROUP BY IdEmpresa, IdBodega, IdCbteVta, IdSucursal, CodCbteVta, vt_tipoDoc, vt_serie1, vt_serie2, vt_NumFactura, IdCliente, IdVendedor, vt_fecha, vt_plazo, vt_fech_venc, 
                         vt_tipo_venta, vt_Observacion, IdPeriodo, vt_anio, vt_mes, vt_flete, vt_interes, vt_OtroValor1, vt_OtroValor2, IdUsuario, Fecha_Transaccion, IdUsuarioUltModi, 
                         Fecha_UltMod, IdUsuarioUltAnu, Fecha_UltAnu, MotivoAnulacion, nom_pc, ip, Estado, Su_Descripcion, bo_Descripcion, Secuencia, Ve_Vendedor, 
                         pe_nombreCompleto, vt_autorizacion, IdTipoDocumento, pe_cedulaRuc, IdCaja, IdEmpresa_nc_anu, IdSucursal_nc_anu, IdBodega_nc_anu, IdNota_nc_anu, 
                         vt_seguro,IdPuntoVta
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_factura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' = 1080
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1305
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_factura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[22] 4[4] 2[60] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[30] 2[35] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[30] 2[40] 3) )"
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
         Top = -39
         Left = 0
      End
      Begin Tables = 
         Begin Table = "fact_agrupadas"
            Begin Extent = 
               Top = 45
               Left = 38
               Bottom = 174
               Right = 263
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
      Begin ColumnWidths = 54
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
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 4935
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 2280
         Alias = 990
         Table', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_factura';

