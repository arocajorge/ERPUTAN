CREATE view vwin_Ing_Egr_Inven_aprobacion_x_transaccion
as
SELECT dbo.in_Ing_Egr_Inven.IdEmpresa, dbo.in_Ing_Egr_Inven.IdSucursal, dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo, dbo.in_Ing_Egr_Inven.IdNumMovi, dbo.in_Ing_Egr_Inven.signo, dbo.in_Ing_Egr_Inven.cm_observacion, 
                  dbo.in_Ing_Egr_Inven.cm_fecha, dbo.tb_sucursal.Su_Descripcion, dbo.in_movi_inven_tipo.tm_descripcion, dbo.in_Ing_Egr_Inven.CodMoviInven AS bo_Descripcion, bod1.bo_Descripcion AS Bodega1, 
                  bod2.bo_Descripcion AS Bodega2, dbo.in_Ing_Egr_Inven.CodMoviInven
FROM     dbo.in_Ing_Egr_Inven_det INNER JOIN
                  dbo.in_Ing_Egr_Inven ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.in_Ing_Egr_Inven.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdSucursal = dbo.in_Ing_Egr_Inven.IdSucursal AND 
                  dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo AND dbo.in_Ing_Egr_Inven_det.IdNumMovi = dbo.in_Ing_Egr_Inven.IdNumMovi INNER JOIN
                  dbo.tb_sucursal ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = dbo.tb_sucursal.IdSucursal LEFT OUTER JOIN
                  dbo.in_movi_inven_tipo ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_movi_inven_tipo.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = dbo.in_movi_inven_tipo.IdMovi_inven_tipo LEFT OUTER JOIN
                  dbo.in_Motivo_Inven ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_Motivo_Inven.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdMotivo_Inv = dbo.in_Motivo_Inven.IdMotivo_Inv LEFT OUTER JOIN
                      (SELECT *
                       FROM      (SELECT ROW_NUMBER() OVER (partition BY D .IdEmpresa, D .IdSucursal, D .IdMovi_inven_tipo, D .IdNumMovi
                                          ORDER BY D .IdEmpresa, D .IdSucursal, D .IdBodega) AS Linea, D .IdEmpresa, D .IdSucursal, D .IdMovi_inven_tipo, D .IdNumMovi, D .IdBodega, b.bo_Descripcion
                       FROM      dbo.in_Ing_Egr_Inven_det AS D LEFT OUTER JOIN
                                         dbo.tb_bodega AS b ON D .IdBodega = b.IdBodega AND D .IdEmpresa = b.IdEmpresa AND D .IdSucursal = b.IdSucursal
                       WHERE   d .IdEstadoAproba = 'PEND'
                       GROUP BY D .IdEmpresa, D .IdSucursal, D .IdMovi_inven_tipo, D .IdNumMovi, D .IdBodega, b.bo_Descripcion) Bodega1
WHERE  Bodega1.Linea = 1) AS bod1 ON dbo.in_Ing_Egr_Inven.IdEmpresa = bod1.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = bod1.IdSucursal AND dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = bod1.IdMovi_inven_tipo AND 
dbo.in_Ing_Egr_Inven.IdNumMovi = bod1.IdNumMovi LEFT OUTER JOIN
    (SELECT *
     FROM      (SELECT ROW_NUMBER() OVER (partition BY D .IdEmpresa, D .IdSucursal, D .IdMovi_inven_tipo, D .IdNumMovi
                        ORDER BY D .IdEmpresa, D .IdSucursal, D .IdBodega) AS Linea, D .IdEmpresa, D .IdSucursal, D .IdMovi_inven_tipo, D .IdNumMovi, D .IdBodega, b.bo_Descripcion
     FROM      dbo.in_Ing_Egr_Inven_det AS D LEFT OUTER JOIN
                       dbo.tb_bodega AS b ON D .IdBodega = b.IdBodega AND D .IdEmpresa = b.IdEmpresa AND D .IdSucursal = b.IdSucursal
     WHERE   d .IdEstadoAproba = 'PEND'
     GROUP BY D .IdEmpresa, D .IdSucursal, D .IdMovi_inven_tipo, D .IdNumMovi, D .IdBodega, b.bo_Descripcion) Bodega1
WHERE  Bodega1.Linea = 2) AS bod2 ON dbo.in_Ing_Egr_Inven.IdEmpresa = bod2.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = bod2.IdSucursal AND dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = bod2.IdMovi_inven_tipo AND 
dbo.in_Ing_Egr_Inven.IdNumMovi = bod2.IdNumMovi
WHERE  (dbo.in_Ing_Egr_Inven.Estado = 'A') AND (dbo.in_Ing_Egr_Inven_det.IdEstadoAproba = 'PEND')
GROUP BY dbo.in_Ing_Egr_Inven.IdEmpresa, dbo.in_Ing_Egr_Inven.IdSucursal, dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo, dbo.in_Ing_Egr_Inven.IdNumMovi, dbo.in_Ing_Egr_Inven.signo, dbo.in_Ing_Egr_Inven.cm_observacion, 
                  dbo.in_Ing_Egr_Inven.cm_fecha, dbo.tb_sucursal.Su_Descripcion, dbo.in_movi_inven_tipo.tm_descripcion, dbo.in_Ing_Egr_Inven.CodMoviInven, bod1.bo_Descripcion, bod2.bo_Descripcion,dbo.in_Ing_Egr_Inven.CodMoviInven