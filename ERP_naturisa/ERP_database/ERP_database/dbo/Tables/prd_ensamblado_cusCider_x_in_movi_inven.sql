CREATE TABLE [dbo].[prd_ensamblado_cusCider_x_in_movi_inven] (
    [IdSucursal]        INT          NOT NULL,
    [IdEmpresa]         INT          NOT NULL,
    [IdBodega]          INT          NOT NULL,
    [IdMovi_inven_tipo] INT          NOT NULL,
    [IdNumMovi]         NUMERIC (18) NOT NULL,
    [en_IdEmpresa]      INT          NOT NULL,
    [en_IdSucursal]     INT          NOT NULL,
    [en_IdEnsamblado]   NUMERIC (18) NOT NULL,
    CONSTRAINT [PK_prd_ensamblado_cusCider_x_in_movi_inven] PRIMARY KEY CLUSTERED ([IdSucursal] ASC, [IdEmpresa] ASC, [IdBodega] ASC, [IdMovi_inven_tipo] ASC, [IdNumMovi] ASC, [en_IdEmpresa] ASC, [en_IdSucursal] ASC, [en_IdEnsamblado] ASC)
);

