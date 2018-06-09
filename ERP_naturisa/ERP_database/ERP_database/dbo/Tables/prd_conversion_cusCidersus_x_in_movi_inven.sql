CREATE TABLE [dbo].[prd_conversion_cusCidersus_x_in_movi_inven] (
    [IdEmpresa]         INT          NOT NULL,
    [IdSucursal]        INT          NOT NULL,
    [IdBodega]          INT          NOT NULL,
    [IdMovi_inven_tipo] INT          NOT NULL,
    [IdNumMovi]         NUMERIC (18) NOT NULL,
    [cv_IdEmpresa]      INT          NOT NULL,
    [cv_IdConversion]   DECIMAL (18) NOT NULL,
    [cv]                CHAR (1)     NULL,
    CONSTRAINT [PK_prd_conversion_cusCidersus_x_in_movi_inven] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdMovi_inven_tipo] ASC, [IdNumMovi] ASC, [cv_IdEmpresa] ASC, [cv_IdConversion] ASC)
);

