CREATE VIEW dbo.vwcom_OrdenPedidoAprobar
AS
SELECT dbo.com_OrdenPedido.IdEmpresa, dbo.com_OrdenPedido.IdOrdenPedido, dbo.com_OrdenPedido.EsCompraUrgente, dbo.com_OrdenPedido.op_Codigo, dbo.com_OrdenPedido.op_Fecha, dbo.com_OrdenPedido.op_Observacion, 
                  dbo.com_OrdenPedido.IdDepartamento, dbo.com_OrdenPedido.IdSolicitante, CASE WHEN COUNT(*) - A.Cont = 0 THEN 'PRECIO APROBADO' ELSE '' END AS IdCatalogoEstado, dbo.com_OrdenPedido.Estado, 
                  dbo.com_OrdenPedido.IdPunto_cargo, dbo.com_solicitante_aprobador.IdUsuario, dbo.ct_punto_cargo.nom_punto_cargo, dbo.com_departamento.nom_departamento, dbo.com_solicitante.nom_solicitante, ISNULL(A.cd_total, 0) 
                  AS cd_total
FROM     dbo.com_OrdenPedidoDet INNER JOIN
                  dbo.com_OrdenPedido ON dbo.com_OrdenPedidoDet.IdEmpresa = dbo.com_OrdenPedido.IdEmpresa AND dbo.com_OrdenPedidoDet.IdOrdenPedido = dbo.com_OrdenPedido.IdOrdenPedido INNER JOIN
                  dbo.com_solicitante ON dbo.com_OrdenPedido.IdEmpresa = dbo.com_solicitante.IdEmpresa AND dbo.com_OrdenPedido.IdSolicitante = dbo.com_solicitante.IdSolicitante INNER JOIN
                  dbo.com_solicitante_aprobador ON dbo.com_OrdenPedido.IdEmpresa = dbo.com_solicitante_aprobador.IdEmpresa AND dbo.com_OrdenPedido.IdDepartamento = dbo.com_solicitante_aprobador.IdDepartamento AND 
                  dbo.com_OrdenPedido.IdSolicitante = dbo.com_solicitante_aprobador.IdSolicitante INNER JOIN
                  dbo.com_departamento ON dbo.com_OrdenPedido.IdEmpresa = dbo.com_departamento.IdEmpresa AND dbo.com_OrdenPedido.IdDepartamento = dbo.com_departamento.IdDepartamento LEFT OUTER JOIN
                  dbo.ct_punto_cargo ON dbo.com_OrdenPedido.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo AND dbo.com_OrdenPedido.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa LEFT OUTER JOIN
                      (SELECT d.IdEmpresa, d.IdOrdenPedido, COUNT(d.IdOrdenPedido) AS Cont, SUM(c.cd_subtotal) AS cd_total
                       FROM      dbo.com_OrdenPedidoDet AS d LEFT OUTER JOIN
                                         dbo.com_CotizacionPedidoDet AS c ON c.IdEmpresa = d.IdEmpresa AND c.opd_IdOrdenPedido = d.IdOrdenPedido AND c.opd_Secuencia = d.Secuencia AND c.EstadoJC = 1
                       WHERE   (d.opd_EstadoProceso = 'AJC')
                       GROUP BY d.IdEmpresa, d.IdOrdenPedido) AS A ON dbo.com_OrdenPedido.IdEmpresa = A.IdEmpresa AND dbo.com_OrdenPedido.IdOrdenPedido = A.IdOrdenPedido
WHERE  (dbo.com_OrdenPedidoDet.opd_EstadoProceso NOT IN ('RA', 'RC', 'RGA', 'C')) AND (dbo.com_OrdenPedido.IdCatalogoEstado = 'EST_OP_PRO') AND (ISNULL(A.cd_total, 0) BETWEEN dbo.com_solicitante_aprobador.MontoMin AND 
                  dbo.com_solicitante_aprobador.MontoMax)
GROUP BY dbo.com_OrdenPedido.IdEmpresa, dbo.com_OrdenPedido.IdOrdenPedido, dbo.com_OrdenPedido.op_Codigo, dbo.com_OrdenPedido.op_Fecha, dbo.com_OrdenPedido.op_Observacion, dbo.com_OrdenPedido.IdDepartamento, 
                  dbo.com_OrdenPedido.IdSolicitante, dbo.com_OrdenPedido.IdCatalogoEstado, dbo.com_OrdenPedido.IdPunto_cargo, dbo.com_solicitante_aprobador.IdUsuario, dbo.ct_punto_cargo.nom_punto_cargo, 
                  dbo.com_departamento.nom_departamento, dbo.com_OrdenPedido.EsCompraUrgente, dbo.com_OrdenPedido.Estado, dbo.com_solicitante.nom_solicitante, A.Cont, A.cd_total
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoAprobar';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'9
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoAprobar';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[7] 4[3] 2[71] 3) )"
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
         Begin Table = "com_OrdenPedidoDet"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 289
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_OrdenPedido"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 300
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_solicitante"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 313
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_solicitante_aprobador"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 269
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_departamento"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 290
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_punto_cargo"
            Begin Extent = 
               Top = 847
               Left = 48
               Bottom = 1010
               Right = 300
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "A"
            Begin Extent = 
               Top = 7
               Left = 337
               Bottom = 170
               Right = 54', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoAprobar';

