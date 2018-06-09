CREATE TABLE [dbo].[prod_ParametrosPorCampos] (
    [IdEmpresa]            INT          NOT NULL,
    [Secuencia]            INT          NOT NULL,
    [NombreLaber]          VARCHAR (50) NULL,
    [NompreCampo]          VARCHAR (50) NULL,
    [IdProducto]           DECIMAL (18) NULL,
    [TipoModeloProduccion] VARCHAR (50) NULL,
    CONSTRAINT [PK_prod_ParametrosPorCampos] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [Secuencia] ASC)
);

