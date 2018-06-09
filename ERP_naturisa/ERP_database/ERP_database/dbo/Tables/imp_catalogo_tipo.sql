CREATE TABLE [dbo].[imp_catalogo_tipo] (
    [IdCatalogoImport_tipo] INT          NOT NULL,
    [Descripcion]           VARCHAR (50) NOT NULL,
    [Estado]                CHAR (1)     NOT NULL,
    CONSTRAINT [PK_imp_catalogo_tipo] PRIMARY KEY CLUSTERED ([IdCatalogoImport_tipo] ASC)
);

