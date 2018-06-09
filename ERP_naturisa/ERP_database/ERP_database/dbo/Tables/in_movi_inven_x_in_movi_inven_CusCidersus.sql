CREATE TABLE [dbo].[in_movi_inven_x_in_movi_inven_CusCidersus] (
    [IdEmpresa1]         INT          NOT NULL,
    [IdSucursal1]        INT          NOT NULL,
    [IdBodega1]          INT          NOT NULL,
    [IdMovi_inven_tipo1] INT          NOT NULL,
    [IdNumMovi1]         NUMERIC (18) NOT NULL,
    [IdEmpresa2]         INT          NOT NULL,
    [IdSucursal2]        INT          NOT NULL,
    [IdBodega2]          INT          NOT NULL,
    [IdMovi_inven_tipo2] INT          NOT NULL,
    [IdNumMovi2]         NUMERIC (18) NOT NULL,
    [dummy]              CHAR (1)     NULL,
    CONSTRAINT [PK_in_movi_inven_x_in_movi_inven_CusCidersus] PRIMARY KEY CLUSTERED ([IdEmpresa1] ASC, [IdSucursal1] ASC, [IdBodega1] ASC, [IdMovi_inven_tipo1] ASC, [IdNumMovi1] ASC, [IdEmpresa2] ASC, [IdSucursal2] ASC, [IdBodega2] ASC, [IdMovi_inven_tipo2] ASC, [IdNumMovi2] ASC)
);

