CREATE TABLE [dbo].[imp_catalogo] (
    [IdCatalogoImport]      VARCHAR (15) NOT NULL,
    [IdCatalogoImport_tipo] INT          NOT NULL,
    [Nombre]                VARCHAR (50) NOT NULL,
    [Estado]                CHAR (1)     NOT NULL,
    [Abrebiatura]           VARCHAR (10) NULL,
    [NombreIngles]          VARCHAR (50) NULL,
    [Orden]                 INT          NULL,
    [IdUsuario]             VARCHAR (20) NULL,
    [IdUsuarioUltMod]       VARCHAR (20) NULL,
    [FechaUltMod]           DATETIME     NULL,
    [nom_pc]                VARCHAR (50) NULL,
    [ip]                    VARCHAR (25) NULL,
    CONSTRAINT [PK_imp_catalogo] PRIMARY KEY CLUSTERED ([IdCatalogoImport] ASC),
    CONSTRAINT [FK_imp_catalogo_imp_catalogo_tipo] FOREIGN KEY ([IdCatalogoImport_tipo]) REFERENCES [dbo].[imp_catalogo_tipo] ([IdCatalogoImport_tipo])
);

