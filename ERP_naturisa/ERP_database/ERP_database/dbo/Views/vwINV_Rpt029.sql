CREATE VIEW vwINV_Rpt029
AS
SELECT        in_transferencia_det.IdEmpresa, in_transferencia_det.IdSucursalOrigen, in_transferencia_det.IdBodegaOrigen, in_transferencia_det.IdTransferencia, in_transferencia_det.dt_secuencia, in_transferencia_det.IdProducto, 
                         in_transferencia_det.pr_descripcion, in_transferencia_det.dt_cantidad, in_Guia_x_traspaso_bodega.IdEstablecimiento, in_Guia_x_traspaso_bodega.IdPuntoEmision, in_Guia_x_traspaso_bodega.NumDocumento_Guia, 
                         in_Guia_x_traspaso_bodega.NumeroAutorizacion, in_Guia_x_traspaso_bodega.FechaAutorizacion, tb_transportista.Cedula AS IdentificacionTransportista, tb_transportista.Nombre AS NombreTransportista, 
                         in_Guia_x_traspaso_bodega.Placa AS MotivoGuia, in_Guia_x_traspaso_bodega.Direc_sucu_Llegada, in_Guia_x_traspaso_bodega.Direc_sucu_Partida, in_Guia_x_traspaso_bodega.Fecha, in_Catalogo.Nombre, 
                         in_Guia_x_traspaso_bodega.NombreDestinatario, in_Guia_x_traspaso_bodega.IdentificacionDestinatario, tb_sucursal.Su_Descripcion, tb_sucursal.Su_Direccion, tb_empresa.em_nombre AS NombreEmpresa, 
                         tb_empresa.ContribuyenteEspecial AS NumeroContribuyente, tb_empresa.em_ruc
FROM            tb_empresa INNER JOIN
                         tb_sucursal ON tb_empresa.IdEmpresa = tb_sucursal.IdEmpresa INNER JOIN
                         in_transferencia INNER JOIN
                         in_transferencia_det ON in_transferencia.IdEmpresa = in_transferencia_det.IdEmpresa AND in_transferencia.IdSucursalOrigen = in_transferencia_det.IdSucursalOrigen AND 
                         in_transferencia.IdBodegaOrigen = in_transferencia_det.IdBodegaOrigen AND in_transferencia.IdTransferencia = in_transferencia_det.IdTransferencia INNER JOIN
                         in_Guia_x_traspaso_bodega ON in_transferencia.IdEmpresa = in_Guia_x_traspaso_bodega.IdEmpresa AND in_transferencia.IdGuia = in_Guia_x_traspaso_bodega.IdGuia INNER JOIN
                         tb_transportista ON in_Guia_x_traspaso_bodega.IdEmpresa = tb_transportista.IdEmpresa AND in_Guia_x_traspaso_bodega.IdTransportista = tb_transportista.IdTransportista INNER JOIN
                         in_Catalogo ON in_Guia_x_traspaso_bodega.IdMotivo_Traslado = in_Catalogo.IdCatalogo ON tb_sucursal.IdEmpresa = in_Guia_x_traspaso_bodega.IdEmpresa AND 
                         tb_sucursal.IdSucursal = in_Guia_x_traspaso_bodega.IdSucursal_Partida