CREATE TABLE [dbo].[Aca_matricula_Tipo_documento] (
    [IdTipoDocumento]     INT             NOT NULL,
    [codTipoDocumento]    VARCHAR (20)    NOT NULL,
    [descripcion]         VARCHAR (250)   NOT NULL,
    [Archivo]             VARBINARY (MAX) NULL,
    [Estado]              CHAR (1)        NOT NULL,
    [FechaCreacion]       DATETIME        NULL,
    [FechaModificacion]   DATETIME        NULL,
    [FechaAnulacion]      DATETIME        NULL,
    [UsuarioCreacion]     VARCHAR (25)    NULL,
    [UsuarioModificacion] VARCHAR (25)    NULL,
    [UsuarioAnulacion]    VARCHAR (25)    NULL,
    [MotivoAnulacion]     VARCHAR (150)   NULL,
    CONSTRAINT [PK_Aca_Matricula_Tipo_documento] PRIMARY KEY CLUSTERED ([IdTipoDocumento] ASC)
);

