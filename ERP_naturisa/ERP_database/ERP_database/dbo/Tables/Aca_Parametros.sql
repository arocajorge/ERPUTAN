CREATE TABLE [dbo].[Aca_Parametros] (
    [IdEmpresa]       INT NOT NULL,
    [IdInstitucion]   INT NOT NULL,
    [IdSucursal_fact] INT NULL,
    [IdBodega_fact]   INT NULL,
    [IdPuntoVta_fact] INT NULL,
    [IdCaja_fact]     INT NULL,
    CONSTRAINT [PK_Aca_Parametros] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdInstitucion] ASC)
);

