CREATE TABLE [dbo].[prod_GestionProductivaTechos_CusTalme_X_in_movi_inve] (
    [IdEmpresa]           INT            NOT NULL,
    [IdSucursal]          INT            NOT NULL,
    [IdBodega]            INT            NOT NULL,
    [IdMovi_inven_tipo]   INT            NOT NULL,
    [IdNumMovi]           NUMERIC (18)   NOT NULL,
    [prod_IdEmpresa]      INT            NOT NULL,
    [IdGestionProductiva] DECIMAL (18)   NOT NULL,
    [sec]                 VARBINARY (50) NULL,
    CONSTRAINT [PK_prod_GestionProductivaTechos_CusTalme_X_in_movi_inve] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdMovi_inven_tipo] ASC, [IdNumMovi] ASC, [prod_IdEmpresa] ASC, [IdGestionProductiva] ASC)
);

