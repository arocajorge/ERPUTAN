CREATE TABLE [dbo].[Aca_matricula_x_documento] (
    [IdInstitucion]       INT             NOT NULL,
    [IdSede]              INT             NOT NULL,
    [IdMatricula]         NUMERIC (18)    NOT NULL,
    [IdTipoDocumento]     INT             NOT NULL,
    [Observacion]         VARCHAR (250)   NOT NULL,
    [Archivo]             VARBINARY (MAX) NULL,
    [Estado]              CHAR (1)        NOT NULL,
    [FechaCreacion]       DATETIME        NOT NULL,
    [FechaModificacion]   DATETIME        NULL,
    [FechaAnulacion]      DATETIME        NULL,
    [UsuarioCreacion]     VARCHAR (25)    NOT NULL,
    [UsuarioModificacion] VARCHAR (25)    NULL,
    [UsuarioAnulacion]    VARCHAR (25)    NULL,
    [MotivoAnulacion]     VARCHAR (150)   NULL,
    CONSTRAINT [PK_Aca_matricula_x_documento] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdSede] ASC, [IdMatricula] ASC, [IdTipoDocumento] ASC),
    CONSTRAINT [FK_Aca_matricula_x_documento_Aca_matricula] FOREIGN KEY ([IdInstitucion], [IdSede], [IdMatricula]) REFERENCES [dbo].[Aca_matricula] ([IdInstitucion], [IdSede], [IdMatricula]),
    CONSTRAINT [FK_Aca_matricula_x_documento_Aca_matricula_Tipo_documento] FOREIGN KEY ([IdTipoDocumento]) REFERENCES [dbo].[Aca_matricula_Tipo_documento] ([IdTipoDocumento])
);

