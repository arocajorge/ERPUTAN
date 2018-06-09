CREATE TABLE [dbo].[in_devolucion_inven_det] (
    [IdEmpresa]                  INT          NOT NULL,
    [IdDev_Inven]                NUMERIC (18) NOT NULL,
    [secuencia]                  INT          NOT NULL,
    [IdEmpresa_movi_inv]         INT          NOT NULL,
    [IdSucursal_movi_inv]        INT          NOT NULL,
    [IdBodega_movi_inv]          INT          NOT NULL,
    [IdMovi_inven_tipo_movi_inv] INT          NOT NULL,
    [IdNumMovi_movi_inv]         NUMERIC (18) NOT NULL,
    [Secuencia_movi_inv]         INT          NOT NULL,
    [cantidad_devuelta]          FLOAT (53)   NOT NULL,
    [cantidad_a_devolver]        FLOAT (53)   NOT NULL,
    [cantidad_egresada]          FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_in_devolucion_inven_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDev_Inven] ASC, [secuencia] ASC),
    CONSTRAINT [FK_in_devolucion_inven_det_in_devolucion_inven] FOREIGN KEY ([IdEmpresa], [IdDev_Inven]) REFERENCES [dbo].[in_devolucion_inven] ([IdEmpresa], [IdDev_Inven]),
    CONSTRAINT [FK_in_devolucion_inven_det_in_movi_inve_detalle] FOREIGN KEY ([IdEmpresa_movi_inv], [IdSucursal_movi_inv], [IdBodega_movi_inv], [IdMovi_inven_tipo_movi_inv], [IdNumMovi_movi_inv], [Secuencia_movi_inv]) REFERENCES [dbo].[in_movi_inve_detalle] ([IdEmpresa], [IdSucursal], [IdBodega], [IdMovi_inven_tipo], [IdNumMovi], [Secuencia])
);

