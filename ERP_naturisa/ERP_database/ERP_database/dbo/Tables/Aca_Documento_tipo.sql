CREATE TABLE [dbo].[Aca_Documento_tipo] (
    [IdTipoDocumento] INT          NOT NULL,
    [Descripcion_doc] VARCHAR (50) NULL,
    [estado]          CHAR (1)     NULL,
    CONSTRAINT [PK_Aca_Documento_tipo] PRIMARY KEY CLUSTERED ([IdTipoDocumento] ASC)
);

