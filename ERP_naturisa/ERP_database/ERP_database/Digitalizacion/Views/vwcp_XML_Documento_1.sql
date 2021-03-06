﻿CREATE VIEW Digitalizacion.vwcp_XML_Documento
AS
SELECT a.IdEmpresa, a.IdDocumento, a.ret_Establecimiento + '-' + a.ret_PuntoEmision AS serie, a.ret_NumeroDocumento, a.ret_Fecha, a.emi_RazonSocial AS pe_nombreCompleto, a.emi_RazonSocial, a.emi_Ruc, per.pe_correo, per.pe_direccion, 
                  per.pe_telfono_Contacto, pro.IdProveedor, a.Establecimiento + '-' + a.PuntoEmision AS co_serie, a.NumeroDocumento, a.FechaEmision, a.CodDocumento, CASE WHEN LEN(A.emi_Ruc) = 10 THEN 'CED' WHEN LEN(A.emi_Ruc) 
                  = 13 THEN 'RUC' ELSE 'PAS' END AS IdTipoDocumento, su.IdSucursal, su.Su_Descripcion, su.Su_Direccion, em.RazonSocial, em.NombreComercial, em.ContribuyenteEspecial, em.ObligadoAllevarConta, em.em_ruc, em.em_direccion, 
                  a.Estado
FROM     Digitalizacion.cp_XML_Documento AS a LEFT OUTER JOIN
                  dbo.tb_persona AS per ON a.emi_Ruc = per.pe_cedulaRuc LEFT OUTER JOIN
                  dbo.cp_proveedor AS pro ON per.IdPersona = pro.IdPersona AND a.IdEmpresa = pro.IdEmpresa INNER JOIN
                  dbo.tb_sucursal AS su ON su.IdEmpresa = a.IdEmpresa AND su.IdSucursal = 1 INNER JOIN
                  dbo.tb_empresa AS em ON em.IdEmpresa = a.IdEmpresa
WHERE  (a.ret_NumeroDocumento IS NOT NULL) AND (a.Estado = 1) AND (a.Tipo = 'FACTURA')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Digitalizacion', @level1type = N'VIEW', @level1name = N'vwcp_XML_Documento';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'd
', @level0type = N'SCHEMA', @level0name = N'Digitalizacion', @level1type = N'VIEW', @level1name = N'vwcp_XML_Documento';




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
         Begin Table = "a"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 321
            End
            DisplayFlags = 280
            TopColumn = 37
         End
         Begin Table = "per"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 322
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pro"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 322
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "su"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 320
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "em"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 305
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
En', @level0type = N'SCHEMA', @level0name = N'Digitalizacion', @level1type = N'VIEW', @level1name = N'vwcp_XML_Documento';



