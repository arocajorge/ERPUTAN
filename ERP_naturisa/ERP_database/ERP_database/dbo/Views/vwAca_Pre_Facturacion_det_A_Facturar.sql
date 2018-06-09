CREATE VIEW dbo.vwAca_Pre_Facturacion_det_A_Facturar
AS
SELECT Fmiliar.IdPersona, Pre_Fact_Cab.IdInstitucion, Pre_Fact_Cab.IdPreFacturacion, Pre_Fact_Cab.IdInstitucion_contrato, Pre_Fact_Cab.IdPeriodo, Pre_Fact_Cab.fecha_prefacturacion, Pre_Fact_Cab.IdEmpresa_fact, 
                  Pre_Fact_Cab.IdSucursal_fact, Pre_Fact_Cab.IdBodega_fact, Pre_Fact_Cab.IdCbteVta, Pre_Fact_Cab.IdPtoVta_fact, Pre_Fact_Cab.IdCaja_fact, Pre_Fact_Cab.vt_fecha_fact, Pre_Fact_Cab.vt_plazo_fact, 
                  Pre_Fact_Cab.vt_fech_venc, Pre_Fact_Cab.observacion_fact, Pre_Fact_Cab.Estado_Pre_factutacion_Cat, Pre_fact_Det.IdRubro, Pre_fact_Det.IdInstitucion_contra, Pre_fact_Det.IdContrato, 
                  Pre_fact_Det.IdInstitucion_Per, Pre_fact_Det.IdPeriodo_Per, Pre_fact_Det.IdProducto, Pre_fact_Det.IdGrupoFE, Pre_fact_Det.vt_cantidad, SUM(Pre_fact_Det.vt_Precio) AS vt_Precio, SUM(Pre_fact_Det.vt_Precio) 
                  AS vt_PorDescUnitario, SUM(Pre_fact_Det.vt_Precio) AS vt_DescUnitario, SUM(Pre_fact_Det.vt_Precio) AS vt_PrecioFinal, SUM(Pre_fact_Det.vt_Precio) AS vt_Subtotal, SUM(Pre_fact_Det.vt_Precio) AS vt_iva_valor, 
                  SUM(Pre_fact_Det.vt_Precio) AS vt_total, Pre_fact_Det.IdCod_Impuesto_Iva, fam_x_estud.activo, rubro.Descripcion_rubro, person.pe_Naturaleza, person.pe_apellido, person.pe_nombre, person.pe_cedulaRuc, 
                  client.IdVendedor, client.cl_plazo, client.cl_Cat_crediticia, client.IdTipoCredito, client.Idtipo_cliente, client.IdSucursal, client.cl_porcentaje_descuento, client.IdCtaCble_cxc, client.IdCtaCble_Anti, client.Mail_Principal, 
                  grupo.nom_GrupoFe, rubro.IdEmpresa_inv, rubro.IdProducto_inv, fam_x_estud.IdFamiliar, person.pe_nombreCompleto, client.IdCliente, fam_x_estud.IdParentesco_cat, contrat.IdMatricula, contrat.IdAnioLectivo, 
                  contrat.IdEstudiante, Pre_fact_Det.IdAnioLectivo_Per, fam_x_estud.porcentaje_dual, Pre_fact_Det.Secuencia_Proce, Pre_fact_Det.secuencia, rubro.IdCentroCosto_ct
FROM     dbo.Aca_Familiar AS Fmiliar INNER JOIN
                  dbo.Aca_Familiar_x_Estudiante AS fam_x_estud INNER JOIN
                  dbo.Aca_estudiante AS estudiant ON fam_x_estud.IdInstitucion = estudiant.IdInstitucion AND fam_x_estud.IdEstudiante = estudiant.IdEstudiante ON Fmiliar.IdInstitucion = fam_x_estud.IdInstitucion AND 
                  Fmiliar.IdFamiliar = fam_x_estud.IdFamiliar INNER JOIN
                  dbo.tb_persona AS person ON Fmiliar.IdPersona = person.IdPersona INNER JOIN
                  dbo.fa_cliente AS client ON person.IdPersona = client.IdPersona INNER JOIN
                  dbo.Aca_Pre_Facturacion AS Pre_Fact_Cab INNER JOIN
                  dbo.Aca_Pre_Facturacion_det AS Pre_fact_Det ON Pre_Fact_Cab.IdInstitucion = Pre_fact_Det.IdInstitucion AND Pre_Fact_Cab.IdPreFacturacion = Pre_fact_Det.IdPreFacturacion INNER JOIN
                  dbo.Aca_Rubro AS rubro ON Pre_fact_Det.IdInstitucion = rubro.IdInstitucion AND Pre_fact_Det.IdRubro = rubro.IdRubro INNER JOIN
                  dbo.Aca_Rubro_Grupo_FE AS grupo ON rubro.IdInstitucion = grupo.IdInstitucion AND rubro.IdGrupoFE = grupo.IdGrupoFE INNER JOIN
                  dbo.Aca_Contrato_x_Estudiante AS contrat ON Pre_fact_Det.IdInstitucion = contrat.IdInstitucion AND Pre_fact_Det.IdContrato = contrat.IdContrato ON estudiant.IdInstitucion = contrat.IdInstitucion AND 
                  estudiant.IdEstudiante = contrat.IdEstudiante AND fam_x_estud.IdInstitucion = Pre_fact_Det.IdInstitucion AND fam_x_estud.IdEstudiante = Pre_fact_Det.IdEstudiante AND 
                  fam_x_estud.IdFamiliar = Pre_fact_Det.IdFamiliar AND fam_x_estud.IdParentesco_cat = Pre_fact_Det.IdParentesco_cat
WHERE  (fam_x_estud.activo = 1) AND (fam_x_estud.IdParentesco_cat = 'REP_ECO' OR
                  fam_x_estud.IdParentesco_cat = 'REP_ECO_DUAL')
GROUP BY Fmiliar.IdPersona, Pre_Fact_Cab.IdInstitucion, Pre_Fact_Cab.IdPreFacturacion, Pre_Fact_Cab.IdInstitucion_contrato, Pre_Fact_Cab.IdPeriodo, Pre_Fact_Cab.fecha_prefacturacion, Pre_Fact_Cab.IdEmpresa_fact, 
                  Pre_Fact_Cab.IdSucursal_fact, Pre_Fact_Cab.IdBodega_fact, Pre_Fact_Cab.IdCbteVta, Pre_Fact_Cab.IdPtoVta_fact, Pre_Fact_Cab.IdCaja_fact, Pre_Fact_Cab.vt_fecha_fact, Pre_Fact_Cab.vt_plazo_fact, 
                  Pre_Fact_Cab.vt_fech_venc, Pre_Fact_Cab.observacion_fact, Pre_Fact_Cab.Estado_Pre_factutacion_Cat, Pre_fact_Det.IdRubro, Pre_fact_Det.IdInstitucion_contra, Pre_fact_Det.IdContrato, 
                  Pre_fact_Det.IdInstitucion_Per, Pre_fact_Det.IdPeriodo_Per, Pre_fact_Det.IdProducto, Pre_fact_Det.IdGrupoFE, Pre_fact_Det.vt_cantidad, Pre_fact_Det.IdCod_Impuesto_Iva, fam_x_estud.activo, 
                  rubro.Descripcion_rubro, person.pe_Naturaleza, person.pe_apellido, person.pe_nombre, person.pe_cedulaRuc, client.IdVendedor, client.cl_plazo, client.cl_Cat_crediticia, client.IdTipoCredito, client.Idtipo_cliente, 
                  client.IdSucursal, client.cl_porcentaje_descuento, client.IdCtaCble_cxc, client.IdCtaCble_Anti, client.Mail_Principal, grupo.nom_GrupoFe, rubro.IdEmpresa_inv, rubro.IdProducto_inv, fam_x_estud.IdFamiliar, 
                  person.pe_nombreCompleto, client.IdCliente, fam_x_estud.IdParentesco_cat, contrat.IdMatricula, contrat.IdAnioLectivo, contrat.IdEstudiante, Pre_fact_Det.IdAnioLectivo_Per, fam_x_estud.porcentaje_dual, 
                  Pre_fact_Det.Secuencia_Proce, Pre_fact_Det.secuencia, rubro.IdCentroCosto_ct
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion_det_A_Facturar';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'layFlags = 280
            TopColumn = 0
         End
         Begin Table = "rubro"
            Begin Extent = 
               Top = 522
               Left = 315
               Bottom = 977
               Right = 540
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "grupo"
            Begin Extent = 
               Top = 623
               Left = 0
               Bottom = 967
               Right = 225
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "contrat"
            Begin Extent = 
               Top = 578
               Left = 1085
               Bottom = 1006
               Right = 1379
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
      PaneHidden = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 64
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
         Width = 2148
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
         Width = 1920
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
         Width = 3900
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1692
         Width = 1632
         Width = 1776
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 9432
         Alias = 900
         Table = 3072
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion_det_A_Facturar';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[16] 4[34] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[54] 4[22] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[45] 3) )"
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
         Configuration = "(V (3) )"
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
      ActivePaneConfig = 1
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -360
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Fmiliar"
            Begin Extent = 
               Top = 4
               Left = 13
               Bottom = 174
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fam_x_estud"
            Begin Extent = 
               Top = 0
               Left = 1214
               Bottom = 358
               Right = 1490
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "estudiant"
            Begin Extent = 
               Top = 270
               Left = 1579
               Bottom = 832
               Right = 1804
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "person"
            Begin Extent = 
               Top = 136
               Left = 321
               Bottom = 367
               Right = 569
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "client"
            Begin Extent = 
               Top = 179
               Left = 0
               Bottom = 377
               Right = 254
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pre_Fact_Cab"
            Begin Extent = 
               Top = 384
               Left = 0
               Bottom = 514
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pre_fact_Det"
            Begin Extent = 
               Top = 0
               Left = 679
               Bottom = 703
               Right = 904
            End
            Disp', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion_det_A_Facturar';

