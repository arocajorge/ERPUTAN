
CREATE view Fj_servindustrias.vwfa_Margen_Ganacia_x_centro_subCentro as
SELECT        Fj_servindustrias.fa_pre_facturacion.IdEmpresa, Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion, Fj_servindustrias.fa_pre_facturacion.IdPeriodo, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdCentroCosto_sub_centro_costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.Facturar, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.Total_depreciado_x_cobrar AS Valor_Facturar,
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.Porc_ganancia,( (fa_pre_facturacion_det_Cobro_x_Depreciacion.Total_depreciado_x_cobrar* fa_pre_facturacion_det_Cobro_x_Depreciacion.Porc_ganancia)/100) as Margen_ganancia
FROM            Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion ON 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli AND 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdCentro_Costo = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc
UNION


SELECT        Fj_servindustrias.fa_pre_facturacion.IdEmpresa, Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion, Fj_servindustrias.fa_pre_facturacion.IdPeriodo, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdCentroCosto_sub_centro_costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.Facturar, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.Movilizacion AS Valor_Facturar, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.Porc_ganancia,( (fa_pre_facturacion_det_cobro_x_Movilizacion.Movilizacion* fa_pre_facturacion_det_cobro_x_Movilizacion.Porc_ganancia)/100) as Margen_ganancia
FROM            Fj_servindustrias.fa_pre_facturacion INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion ON 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdPrefacturacion INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdCentro_Costo = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc AND 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli
UNION



SELECT        Fj_servindustrias.fa_pre_facturacion.IdEmpresa, Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion, Fj_servindustrias.fa_pre_facturacion.IdPeriodo, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentroCosto_sub_centro_costo, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Facturar, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Total AS Valor_Facturar, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Porc_ganancia,( (fa_pre_facturacion_det_cobro_x_Poliza.Total* fa_pre_facturacion_det_cobro_x_Poliza.Porc_ganancia)/100) as Margen_ganancia
FROM            Fj_servindustrias.fa_pre_facturacion INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza ON 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPreFacturacion INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli AND 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentro_Costo = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc
UNION


SELECT        Fj_servindustrias.fa_pre_facturacion.IdEmpresa, Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion, Fj_servindustrias.fa_pre_facturacion.IdPeriodo, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdCentroCosto, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdCentroCosto_sub_centro_costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Facturar, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Total AS Valor_Facturar, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Porc_ganancia, ( (fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Total* fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Porc_ganancia)/100) as Margen_ganancia
FROM            Fj_servindustrias.fa_pre_facturacion INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas ON 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdPreFacturacion INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli AND 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdCentroCosto = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc
UNION


SELECT        Fj_servindustrias.fa_pre_facturacion.IdEmpresa, Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion, Fj_servindustrias.fa_pre_facturacion.IdPeriodo, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentroCosto_sub_centro_costo, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Facturar, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Total AS Valor_Facturar, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Porc_ganancia,( (fa_pre_facturacion_det_egr_x_bod.Total* fa_pre_facturacion_det_egr_x_bod.Porc_ganancia)/100) as Margen_ganancia
FROM            Fj_servindustrias.fa_pre_facturacion INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod ON 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPreFacturacion INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli AND 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentro_Costo = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc
UNION


SELECT        Fj_servindustrias.fa_pre_facturacion.IdEmpresa, Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion, Fj_servindustrias.fa_pre_facturacion.IdPeriodo, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCentroCosto_sub_centro_costo, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Facturar, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Total AS Valor_Facturar, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Porc_ganancia,( (fa_pre_facturacion_det_Fact_x_Gastos.Total* fa_pre_facturacion_det_Fact_x_Gastos.Porc_ganancia)/100) as Margen_ganancia
FROM            Fj_servindustrias.fa_pre_facturacion INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos ON 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdEmpresa INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli AND 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCentro_Costo = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc