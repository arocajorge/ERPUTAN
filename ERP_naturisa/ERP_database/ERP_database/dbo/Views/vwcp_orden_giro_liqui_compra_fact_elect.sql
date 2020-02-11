
create view vwcp_orden_giro_liqui_compra_fact_elect as
SELECT  


        cp_orden_giro. IdEmpresa ,
         IdCbteCble_Ogiro ,
         IdTipoCbte_Ogiro ,
         IdOrden_giro_Tipo ,
         cp_orden_giro. IdProveedor ,
         co_fechaOg ,
         co_serie ,
         co_factura ,
         co_FechaFactura ,
        co_FechaContabilizacion ,
         co_FechaFactura_vct ,
         co_plazo ,
         co_observacion ,
         co_subtotal_iva ,
         co_subtotal_siniva ,
         co_baseImponible ,
         co_Por_iva ,
         co_valoriva ,
         co_total ,
         co_valorpagar ,
         co_vaCoa ,
         PagoLocExt ,
         PaisPago ,
         pe_Naturaleza ,
         pe_nombreCompleto ,
         pe_razonSocial ,
         pe_apellido ,
         pe_nombre ,
         IdTipoDocumento ,
         pe_cedulaRuc ,
         pe_direccion ,
         pe_telfono_Contacto ,
         pe_celular ,
         pe_correo ,
         pe_sexo ,
         em_nombre ,
         RazonSocial ,
         NombreComercial ,
         ContribuyenteEspecial ,
         em_ruc ,
         em_direccion ,
         IdSucursal 
FROM            dbo.cp_orden_giro INNER JOIN
                         dbo.cp_proveedor ON dbo.cp_orden_giro.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.cp_orden_giro.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.tb_empresa ON dbo.cp_proveedor.IdEmpresa = dbo.tb_empresa.IdEmpresa

						 where cp_orden_giro.IdOrden_giro_Tipo='03'
						 and cp_orden_giro.Estado='A'