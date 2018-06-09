CREATE TABLE [dbo].[prod_GestionProductivaAcero_CusTalme_x_in_movi_inven] (
    [gp_IdEmpresa]         INT          NOT NULL,
    [gp_IdSucursal]        INT          NOT NULL,
    [gp_IdGestionAceria]   NUMERIC (18) NOT NULL,
    [mv_IdEmpresa]         INT          NOT NULL,
    [mv_IdSucursal]        INT          NOT NULL,
    [mv_IdBodega]          INT          NOT NULL,
    [mv_IdMovi_inven_tipo] INT          NOT NULL,
    [mv_IdNumMovi]         NUMERIC (18) NOT NULL,
    [Observacion]          VARCHAR (50) NULL,
    CONSTRAINT [PK_prod_GestionProductivaAcero_CusTalme_x_in_movi_inven] PRIMARY KEY CLUSTERED ([gp_IdEmpresa] ASC, [gp_IdSucursal] ASC, [gp_IdGestionAceria] ASC, [mv_IdEmpresa] ASC, [mv_IdSucursal] ASC, [mv_IdBodega] ASC, [mv_IdMovi_inven_tipo] ASC, [mv_IdNumMovi] ASC)
);

