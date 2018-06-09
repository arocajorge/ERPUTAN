CREATE view [dbo].[vwFAC_CUS_TAL_Rpt002]
as
SELECT        OrDes.IdEmpresa, OrDes.IdSucursal, OrDes.IdBodega, OrDes.IdOrdenDespacho, OrDes.IdCliente, OrDes.IdVendedor, OrDes.IdTransportista, 
                         OrDes.od_fecha AS Fecha, OrDes.od_plazo AS Plazo, OrDes.od_fech_venc AS Fecha_vct, OrDes.od_Observacion AS Observacion, 
                         OrDes.od_TotalKilos AS Total_kilos, OrDes.od_TotalQuintales AS TotalQuint, OrDes.od_DespAbierto AS DespachoAbiert, OrDes_det.IdProducto, 
                         OrDes_det.od_cantidad AS Cantidad_det, OrDes_det.od_Precio AS Precio_det, OrDes_det.od_PorDescUnitario AS Porcent_des_Uni__det, 
                         OrDes_det.od_DescUnitario AS Valor_desc_uni__det, OrDes_det.od_PrecioFinal AS Precio_Final__det, OrDes_det.od_Subtotal AS Subtotal_det, 
                         OrDes_det.od_iva AS Iva_det, OrDes_det.od_total AS Total_det, OrDes_det.od_peso AS Peso_det, OrDes_det.od_detallexItems AS detallexItems_det, 
                         OrDes_det.od_costo AS costo_det, Empr.em_nombre AS Nom_Empresa, Sucu.Su_Descripcion AS Nom_Sucursal, Bod.bo_Descripcion AS Nom_Bodega, 
                         Pers_cli.pe_nombreCompleto AS Nom_Cliente, Pers_cli.pe_razonSocial AS Razon_social_clie, Pers_cli.pe_cedulaRuc AS Cedula_ruc_clie, 
                         Pers_cli.pe_direccion AS direccion_clie, Pers_cli.pe_telefonoOfic AS telefonoOfi_clie, Pers_cli.pe_correo AS correo_clie, Prod.pr_codigo AS codigo_prod, 
                         Prod.pr_descripcion AS Nom_produc, Empr.em_logo AS logo_empre, Empr.em_ruc AS ruc_empre, Empr.em_telefonos AS telefono_empre, 
                         Empr.em_direccion AS direccion_empr, tb_transportista.Nombre AS Nom_Transportista
FROM            fa_orden_Desp AS OrDes INNER JOIN
                         fa_orden_Desp_det AS OrDes_det ON OrDes.IdEmpresa = OrDes_det.IdEmpresa AND OrDes.IdSucursal = OrDes_det.IdSucursal AND 
                         OrDes.IdBodega = OrDes_det.IdBodega AND OrDes.IdOrdenDespacho = OrDes_det.IdOrdenDespacho INNER JOIN
                         fa_cliente AS Clien ON OrDes.IdEmpresa = Clien.IdEmpresa AND OrDes.IdCliente = Clien.IdCliente INNER JOIN
                         tb_persona AS Pers_cli ON Clien.IdPersona = Pers_cli.IdPersona INNER JOIN
                         tb_bodega AS Bod ON OrDes.IdEmpresa = Bod.IdEmpresa AND OrDes.IdSucursal = Bod.IdSucursal AND OrDes.IdBodega = Bod.IdBodega INNER JOIN
                         tb_sucursal AS Sucu ON Bod.IdEmpresa = Sucu.IdEmpresa AND Bod.IdSucursal = Sucu.IdSucursal INNER JOIN
                         in_Producto AS Prod ON OrDes_det.IdEmpresa = Prod.IdEmpresa AND OrDes_det.IdProducto = Prod.IdProducto INNER JOIN
                         tb_transportista AS Trans ON OrDes.IdEmpresa = Trans.IdEmpresa AND OrDes.IdTransportista = Trans.IdTransportista INNER JOIN
                         tb_empresa AS Empr ON Sucu.IdEmpresa = Empr.IdEmpresa INNER JOIN
                         tb_transportista ON OrDes.IdEmpresa = tb_transportista.IdEmpresa AND OrDes.IdTransportista = tb_transportista.IdTransportista