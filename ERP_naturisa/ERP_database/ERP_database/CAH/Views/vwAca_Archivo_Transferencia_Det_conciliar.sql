CREATE VIEW CAH.vwAca_Archivo_Transferencia_Det_conciliar
AS
SELECT        transf.IdEmpresa, transf.IdArchivo, transf.IdBanco, transf.IdProceso_bancario, transf.Origen_Archivo, transf.Cod_Empresa, transf.Nom_Archivo, transf.Fecha, transf.Estado, transf.IdEstadoArchivo_cat, 
                         transf.Observacion, Transf_Det.Valor, person.pe_cedulaRuc, person.pe_apellido + ' ' + person.pe_nombre AS Nombres, catalogo.ca_descripcion AS nom_EstadoRegistro, Transf_Det.Id_Item, 
                         Transf_Det.Secuencia, Transf_Det.Valor AS Valor_Enviado, Transf_Det.Valor_cobrado, Transf_Det.Valor - Transf_Det.Valor_cobrado AS Saldo_x_Cobrar, transf.IdMotivoArchivo_cat, 
                         ba_Catalogo_1.ca_descripcion AS nom_MotivoArchivo, transf.Fecha_Proceso, Transf_Det.Secuencial_reg_x_proceso, person.IdTipoDocumento, NULL AS Expr2, person.pe_Naturaleza, person.IdPersona, 
                         person.IdPersona AS Identidad, rub.Descripcion_rubro, fam_x_estud.activo, doc_x_rep_eco.Numero_Documento, Transf_Det.IdInstitucion_Col, 
                       Transf_Det.Contabilizado, dbo.fa_factura.vt_serie1 + '-' + dbo.fa_factura.vt_serie2 + '-' + dbo.fa_factura.vt_NumFactura AS Factura, 
                         dbo.fa_factura.IdSucursal, dbo.fa_factura.IdBodega, dbo.fa_factura.IdCbteVta, dbo.fa_factura.IdCliente
FROM            dbo.ba_Catalogo AS catalogo INNER JOIN
                         dbo.ba_Archivo_Transferencia AS transf INNER JOIN
                         dbo.ba_Archivo_Transferencia_Det AS Transf_Det ON transf.IdEmpresa = Transf_Det.IdEmpresa AND transf.IdArchivo = Transf_Det.IdArchivo ON catalogo.IdCatalogo = Transf_Det.IdEstadoRegistro_cat INNER JOIN
                         dbo.tb_persona AS person INNER JOIN
                         dbo.Aca_estudiante AS Estud ON person.IdPersona = Estud.IdPersona ON Transf_Det.IdInstitucion_Col = Estud.IdInstitucion INNER JOIN
                         dbo.Aca_Rubro AS rub ON Transf_Det.IdInstitucion_Col = rub.IdInstitucion INNER JOIN
                         dbo.Aca_Familiar_x_Estudiante AS fam_x_estud ON Estud.IdInstitucion = fam_x_estud.IdInstitucion AND Estud.IdEstudiante = fam_x_estud.IdEstudiante INNER JOIN
                         dbo.Aca_Documento_Bancario_x_Rep_Economico AS doc_x_rep_eco ON fam_x_estud.IdInstitucion = doc_x_rep_eco.IdInstitucion AND fam_x_estud.IdFamiliar = doc_x_rep_eco.IdFamiliar AND 
                         fam_x_estud.IdParentesco_cat = doc_x_rep_eco.IdParentesco_cat INNER JOIN
                         dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula AS doc_x_estud ON doc_x_rep_eco.IdInstitucion = doc_x_estud.IdInstitucion AND 
                         doc_x_rep_eco.IdFamiliar = doc_x_estud.IdFamiliar AND doc_x_rep_eco.IdParentesco_cat = doc_x_estud.IdParentesco_cat AND 
                         doc_x_rep_eco.IdDocumento_Bancario = doc_x_estud.IdDocumento_Bancario INNER JOIN
                         dbo.Aca_Catalogo ON doc_x_rep_eco.Tipo_documento_cat = dbo.Aca_Catalogo.IdCatalogo INNER JOIN
                         Academico.fa_factura_aca ON Transf_Det.IdInstitucion_Col = Academico.fa_factura_aca.IdInstitucion INNER JOIN
                         dbo.fa_factura ON Academico.fa_factura_aca.IdEmpresa = dbo.fa_factura.IdEmpresa AND Academico.fa_factura_aca.IdSucursal = dbo.fa_factura.IdSucursal AND 
                         Academico.fa_factura_aca.IdBodega = dbo.fa_factura.IdBodega AND Academico.fa_factura_aca.IdCbteVta = dbo.fa_factura.IdCbteVta AND Academico.fa_factura_aca.IdEmpresa = dbo.fa_factura.IdEmpresa AND 
                         Academico.fa_factura_aca.IdSucursal = dbo.fa_factura.IdSucursal AND Academico.fa_factura_aca.IdBodega = dbo.fa_factura.IdBodega AND Academico.fa_factura_aca.IdCbteVta = dbo.fa_factura.IdCbteVta AND 
                         Academico.fa_factura_aca.IdEmpresa = dbo.fa_factura.IdEmpresa AND Academico.fa_factura_aca.IdSucursal = dbo.fa_factura.IdSucursal AND Academico.fa_factura_aca.IdBodega = dbo.fa_factura.IdBodega AND 
                         Academico.fa_factura_aca.IdCbteVta = dbo.fa_factura.IdCbteVta AND Academico.fa_factura_aca.IdEmpresa = dbo.fa_factura.IdEmpresa AND Academico.fa_factura_aca.IdSucursal = dbo.fa_factura.IdSucursal AND 
                         Academico.fa_factura_aca.IdBodega = dbo.fa_factura.IdBodega AND Academico.fa_factura_aca.IdCbteVta = dbo.fa_factura.IdCbteVta AND Academico.fa_factura_aca.IdEmpresa = dbo.fa_factura.IdEmpresa AND 
                         Academico.fa_factura_aca.IdSucursal = dbo.fa_factura.IdSucursal AND Academico.fa_factura_aca.IdBodega = dbo.fa_factura.IdBodega AND Academico.fa_factura_aca.IdCbteVta = dbo.fa_factura.IdCbteVta AND 
                         Academico.fa_factura_aca.IdEmpresa = dbo.fa_factura.IdEmpresa AND Academico.fa_factura_aca.IdSucursal = dbo.fa_factura.IdSucursal AND Academico.fa_factura_aca.IdBodega = dbo.fa_factura.IdBodega AND 
                         Academico.fa_factura_aca.IdCbteVta = dbo.fa_factura.IdCbteVta AND Academico.fa_factura_aca.IdEmpresa = dbo.fa_factura.IdEmpresa AND Academico.fa_factura_aca.IdSucursal = dbo.fa_factura.IdSucursal AND 
                         Academico.fa_factura_aca.IdBodega = dbo.fa_factura.IdBodega AND Academico.fa_factura_aca.IdCbteVta = dbo.fa_factura.IdCbteVta AND Academico.fa_factura_aca.IdEmpresa = dbo.fa_factura.IdEmpresa AND 
                         Academico.fa_factura_aca.IdSucursal = dbo.fa_factura.IdSucursal AND Academico.fa_factura_aca.IdBodega = dbo.fa_factura.IdBodega AND Academico.fa_factura_aca.IdCbteVta = dbo.fa_factura.IdCbteVta AND 
                         Academico.fa_factura_aca.IdEmpresa = dbo.fa_factura.IdEmpresa AND Academico.fa_factura_aca.IdSucursal = dbo.fa_factura.IdSucursal AND Academico.fa_factura_aca.IdBodega = dbo.fa_factura.IdBodega AND 
                         Academico.fa_factura_aca.IdCbteVta = dbo.fa_factura.IdCbteVta LEFT OUTER JOIN
                         dbo.ba_Catalogo AS ba_Catalogo_1 ON transf.IdMotivoArchivo_cat = ba_Catalogo_1.IdCatalogo
WHERE        (fam_x_estud.activo = 1)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vwAca_Archivo_Transferencia_Det_conciliar';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'           TopColumn = 0
         End
         Begin Table = "doc_x_rep_eco"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1060
               Right = 257
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "doc_x_estud"
            Begin Extent = 
               Top = 1062
               Left = 38
               Bottom = 1192
               Right = 257
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Catalogo"
            Begin Extent = 
               Top = 1194
               Left = 38
               Bottom = 1324
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_factura_aca (Academico)"
            Begin Extent = 
               Top = 1326
               Left = 38
               Bottom = 1456
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_factura"
            Begin Extent = 
               Top = 1458
               Left = 38
               Bottom = 1588
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_Catalogo_1"
            Begin Extent = 
               Top = 1590
               Left = 38
               Bottom = 1720
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
      Begin ColumnWidths = 9
         Width = 284
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
', @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vwAca_Archivo_Transferencia_Det_conciliar';


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
         Begin Table = "catalogo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "transf"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Transf_Det"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 267
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "person"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 532
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Estud"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 664
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "rub"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 796
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fam_x_estud"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 928
               Right = 298
            End
            DisplayFlags = 280
 ', @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vwAca_Archivo_Transferencia_Det_conciliar';

