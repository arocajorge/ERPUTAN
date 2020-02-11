


	CREATE view vwcp_orden_giro_det_liqui_comp_fac_elect as

SELECT  

         cp_orden_giro_det.IdEmpresa ,
         cp_orden_giro_det.IdCbteCble_Ogiro ,
         cp_orden_giro_det.IdTipoCbte_Ogiro ,
         Secuencia ,
         cp_orden_giro_det.IdProducto ,
         in_Producto.IdUnidadMedida ,
         Cantidad ,
         CostoUni ,
         PorDescuento ,
         DescuentoUni ,
         CostoUniFinal ,
         Subtotal ,
         cp_orden_giro_det.IdCod_Impuesto_Iva ,
         PorIva ,
         ValorIva ,
         Total ,
         pr_codigo ,
         pr_descripcion ,
         pr_descripcion_2 ,
         IdSucursal 
FROM            dbo.cp_orden_giro INNER JOIN
                         dbo.cp_orden_giro_det ON dbo.cp_orden_giro.IdEmpresa = dbo.cp_orden_giro_det.IdEmpresa AND dbo.cp_orden_giro.IdCbteCble_Ogiro = dbo.cp_orden_giro_det.IdCbteCble_Ogiro AND 
                         dbo.cp_orden_giro.IdTipoCbte_Ogiro = dbo.cp_orden_giro_det.IdTipoCbte_Ogiro INNER JOIN
                         dbo.in_Producto ON dbo.cp_orden_giro_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.cp_orden_giro_det.IdProducto = dbo.in_Producto.IdProducto