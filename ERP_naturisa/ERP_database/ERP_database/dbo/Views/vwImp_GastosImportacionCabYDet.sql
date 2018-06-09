--sp_helptext 'vwImp_GastosImportacionCabYDet'


CREATE VIEW [dbo].[vwImp_GastosImportacionCabYDet]  
AS  
SELECT     dbo.ba_Banco_Cuenta.IdCtaCble AS IdCtaCble_Banco, dbo.imp_gastosxImport_x_Empresa.IdCtaCble AS IdCtaCble_Gaso,   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdEmpresa, dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdRegistroGasto,   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdSucusal, dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdOrdenCompraExt,   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.Fecha, dbo.imp_ordencompra_ext_x_imp_gastosxImport.Observacion,   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdProveedor, dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdBanco,   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.CodDocu_Pago, dbo.imp_ordencompra_ext_x_imp_gastosxImport.Estado,   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdGastoImp, dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.Valor,   
                      dbo.imp_Tipo_docu_pago_x_Empresa_x_tipocbte.IdTipoCbte, dbo.imp_ordencompra_ext.CodOrdenCompraExt,   
                      dbo.imp_gastosxImport_x_Empresa.debcre_DebBanco, dbo.imp_gastosxImport_x_Empresa.debCre_Provicion, dbo.imp_ordencompra_ext.IdCtaCble_import  
FROM         dbo.imp_ordencompra_ext_x_imp_gastosxImport_det INNER JOIN  
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport ON   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdEmpresa = dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdEmpresa AND   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdRegistroGasto = dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdRegistroGasto AND   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdSucursal = dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdSucusal AND   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdOrdenCompraExt = dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdOrdenCompraExt INNER JOIN  
                      dbo.ba_Banco_Cuenta ON dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdEmpresa = dbo.ba_Banco_Cuenta.IdEmpresa AND   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdBanco = dbo.ba_Banco_Cuenta.IdBanco INNER JOIN  
                      dbo.imp_gastosxImport_x_Empresa ON dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdEmpresa = dbo.imp_gastosxImport_x_Empresa.IdEmpresa AND   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdGastoImp = dbo.imp_gastosxImport_x_Empresa.IdGastoImp INNER JOIN  
                      dbo.imp_Tipo_docu_pago_x_Empresa_x_tipocbte ON   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdEmpresa = dbo.imp_Tipo_docu_pago_x_Empresa_x_tipocbte.IdEmpresa AND   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.CodDocu_Pago = dbo.imp_Tipo_docu_pago_x_Empresa_x_tipocbte.CodDocu_Pago AND   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdEmpresa = dbo.imp_Tipo_docu_pago_x_Empresa_x_tipocbte.IdEmpresa INNER JOIN  
                      dbo.imp_ordencompra_ext ON dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdEmpresa = dbo.imp_ordencompra_ext.IdEmpresa AND   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdSucusal = dbo.imp_ordencompra_ext.IdSucusal AND   
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdOrdenCompraExt = dbo.imp_ordencompra_ext.IdOrdenCompraExt