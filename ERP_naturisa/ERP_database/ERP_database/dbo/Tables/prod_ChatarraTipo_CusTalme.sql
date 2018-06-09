CREATE TABLE [dbo].[prod_ChatarraTipo_CusTalme] (
    [IdEmpresa]      INT          NOT NULL,
    [IdTipoChatarra] INT          NOT NULL,
    [Descripcion]    VARCHAR (50) NULL,
    [Precio]         FLOAT (53)   NULL,
    [Estado]         CHAR (1)     NOT NULL,
    CONSTRAINT [PK_prod_ChatarraTipo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipoChatarra] ASC)
);

