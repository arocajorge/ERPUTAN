CREATE TABLE [dbo].[prd_Despacho_cusCidersus_x_in_movi_inven] (
    [IdEmpresa]         INT          NOT NULL,
    [IdSucursal]        INT          NOT NULL,
    [IdBodega]          INT          NOT NULL,
    [IdMovi_inven_tipo] INT          NOT NULL,
    [IdNumMovi]         NUMERIC (18) NOT NULL,
    [dp_IdEmpresa]      INT          NOT NULL,
    [dp_IdSucursal]     INT          NOT NULL,
    [dp_IdDespacho]     NUMERIC (18) NOT NULL,
    [dp]                CHAR (1)     NULL,
    CONSTRAINT [PK_prd_Despacho_cusCidersus_x_in_movi_inven] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdMovi_inven_tipo] ASC, [IdNumMovi] ASC, [dp_IdEmpresa] ASC, [dp_IdSucursal] ASC, [dp_IdDespacho] ASC)
);

