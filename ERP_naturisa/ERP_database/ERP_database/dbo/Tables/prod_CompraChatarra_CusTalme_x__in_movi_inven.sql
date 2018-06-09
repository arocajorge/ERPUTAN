CREATE TABLE [dbo].[prod_CompraChatarra_CusTalme_x__in_movi_inven] (
    [IdEmpresa]            INT          NOT NULL,
    [IdLiquidacion]        NUMERIC (18) NOT NULL,
    [mv_IdEmpresa]         INT          NOT NULL,
    [mv_IdSucursal]        INT          NOT NULL,
    [mv_IdBodega]          INT          NOT NULL,
    [mv_IdMovi_inven_tipo] INT          NOT NULL,
    [mv_IdNumMovi]         NUMERIC (18) NOT NULL,
    [None]                 VARCHAR (50) NULL,
    CONSTRAINT [PK_prod_CompraChatarra_CusTalme_x__in_movi_inven] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdLiquidacion] ASC, [mv_IdEmpresa] ASC, [mv_IdSucursal] ASC, [mv_IdBodega] ASC, [mv_IdMovi_inven_tipo] ASC, [mv_IdNumMovi] ASC)
);

