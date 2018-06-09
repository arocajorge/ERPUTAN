CREATE TABLE [dbo].[prod_ParametrosAceria] (
    [IdEmpresa]              INT NOT NULL,
    [IdSucursalEgresoMovi]   INT NULL,
    [IdBodegaEgresoMovi]     INT NULL,
    [IdMoviInvenTipoEgreso]  INT NULL,
    [IdSucursalIngresoMovi]  INT NULL,
    [IdBodegaIngresoMovi]    INT NULL,
    [IdMoviInvenTipoIngreso] INT NULL,
    CONSTRAINT [PK_prod_ParametrosAceria] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC)
);

