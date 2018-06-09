CREATE TABLE [dbo].[prod_TipoParada_CusTalme] (
    [IdTipoParada] VARCHAR (10) NOT NULL,
    [Descripcion]  VARCHAR (50) NULL,
    [Estado]       CHAR (1)     NULL,
    CONSTRAINT [PK_prod_TipoParada_CusTalme] PRIMARY KEY CLUSTERED ([IdTipoParada] ASC)
);

