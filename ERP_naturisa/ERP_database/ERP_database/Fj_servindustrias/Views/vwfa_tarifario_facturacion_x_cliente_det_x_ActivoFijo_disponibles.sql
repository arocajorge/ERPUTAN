CREATE VIEW [Fj_servindustrias].[vwfa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_disponibles]
AS
SELECT        dbo.Af_Activo_fijo.IdEmpresa, dbo.Af_Activo_fijo.IdActivoFijo, dbo.Af_Activo_fijo.CodActivoFijo, dbo.Af_Activo_fijo.Af_Nombre, dbo.Af_Activo_fijo.IdActijoFijoTipo, 
                         dbo.Af_Activo_fijo.IdDepartamento, dbo.ro_Departamento.de_descripcion, Af_Catalogo_2.Descripcion AS Marca, Af_Catalogo_1.Descripcion AS Modelo, 
                         dbo.Af_Activo_fijo.Af_NumSerie, dbo.Af_Activo_fijo.Af_fecha_compra, dbo.Af_Activo_fijo.Af_fecha_ini_depre, dbo.Af_Activo_fijo.Af_fecha_fin_depre, 
                         dbo.Af_Activo_fijo.Af_Costo_historico, dbo.Af_Activo_fijo.Af_costo_compra, dbo.Af_Activo_fijo.Af_Vida_Util, dbo.Af_Activo_fijo.Af_Meses_depreciar, 
                         dbo.Af_Activo_fijo.Af_porcentaje_deprec, dbo.Af_Activo_fijo.Af_NumSerie_Motor, dbo.Af_Activo_fijo.Af_NumSerie_Chasis, dbo.tb_sucursal.IdSucursal, 
                         dbo.tb_sucursal.Su_Descripcion AS nom_Sucursal, dbo.Af_Activo_fijo_Categoria.Descripcion AS nom_Categoria, dbo.Af_Activo_fijo.Estado, 
                         dbo.Af_Encargado.nom_encargado, dbo.Af_Activo_fijo.Af_ValorUnidad_Actu, cat_Color.Descripcion AS nom_Color, dbo.Af_Activo_fijo.IdUnidadFact_cat, 
                         Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.pe_nombreCompleto AS nom_Cliente, 
                         Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.nom_punto_cargo, Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.nom_Centro_costo, 
                         Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.nom_UnidadFact, dbo.Af_Activo_fijo.IdCategoriaAF, dbo.Af_Activo_fijo.IdCentroCosto, 
                         dbo.Af_Activo_fijo.Af_ValorSalvamento, dbo.Af_Activo_fijo.Af_ValorResidual, 
                         Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.nom_Centro_costo_sub_centro_costo, dbo.Af_Activo_fijo.Es_carroceria, 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario
FROM            dbo.Af_Activo_fijo_Categoria RIGHT OUTER JOIN
                         dbo.tb_sucursal RIGHT OUTER JOIN
                         dbo.Af_Activo_fijo LEFT OUTER JOIN
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo INNER JOIN
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente ON 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario ON 
                         dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
                         dbo.Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo LEFT OUTER JOIN
                         Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo ON dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.IdEmpresa AND 
                         dbo.Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.IdActivoFijo LEFT OUTER JOIN
                         dbo.Af_Catalogo AS cat_Color ON dbo.Af_Activo_fijo.IdCatalogo_Color = cat_Color.IdCatalogo LEFT OUTER JOIN
                         dbo.ro_Departamento ON dbo.Af_Activo_fijo.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.Af_Activo_fijo.IdDepartamento = dbo.ro_Departamento.IdDepartamento LEFT OUTER JOIN
                         dbo.Af_Catalogo AS Af_Catalogo_2 ON dbo.Af_Activo_fijo.IdCatalogo_Marca = Af_Catalogo_2.IdCatalogo LEFT OUTER JOIN
                         dbo.Af_Catalogo AS Af_Catalogo_1 ON dbo.Af_Activo_fijo.IdCatalogo_Modelo = Af_Catalogo_1.IdCatalogo ON 
                         dbo.tb_sucursal.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa AND dbo.tb_sucursal.IdSucursal = dbo.Af_Activo_fijo.IdSucursal LEFT OUTER JOIN
                         dbo.Af_Encargado ON dbo.Af_Activo_fijo.IdEmpresa = dbo.Af_Encargado.IdEmpresa AND dbo.Af_Activo_fijo.IdEncargado = dbo.Af_Encargado.IdEncargado ON 
                         dbo.Af_Activo_fijo_Categoria.IdCategoriaAF = dbo.Af_Activo_fijo.IdCategoriaAF AND dbo.Af_Activo_fijo_Categoria.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa
WHERE        (dbo.Af_Activo_fijo.IdActivoFijo NOT IN
                             (SELECT        det.IdActivoFijo
                               FROM            Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo AS det INNER JOIN
                                                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente AS cab ON cab.IdEmpresa = det.IdEmpresa AND cab.IdTarifario = det.IdTarifario AND 
                                                         cab.IdEstadoVigencia_cat = 'EST_VIG_VIGENTE' AND dbo.Af_Activo_fijo.IdEmpresa = cab.IdEmpresa))