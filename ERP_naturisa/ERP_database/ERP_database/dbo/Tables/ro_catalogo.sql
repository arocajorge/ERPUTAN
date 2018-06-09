CREATE TABLE [dbo].[ro_catalogo] (
    [CodCatalogo]    VARCHAR (10)  NOT NULL,
    [IdCatalogo]     INT           NOT NULL,
    [IdTipoCatalogo] INT           NOT NULL,
    [ca_descripcion] VARCHAR (250) NOT NULL,
    [ca_estado]      VARCHAR (1)   NOT NULL,
    [ca_orden]       INT           NOT NULL,
    CONSTRAINT [PK_ro_Catalogo] PRIMARY KEY CLUSTERED ([CodCatalogo] ASC),
    CONSTRAINT [FK_ro_catalogo_ro_catalogoTipo] FOREIGN KEY ([IdTipoCatalogo]) REFERENCES [dbo].[ro_catalogoTipo] ([IdTipoCatalogo])
);

