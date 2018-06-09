CREATE TABLE [dbo].[Aca_Profesor] (
    [IdInstitucion]       INT           NOT NULL,
    [IdProfesor]          NUMERIC (18)  NOT NULL,
    [CodProfesor]         VARCHAR (25)  NOT NULL,
    [IdPersona]           NUMERIC (18)  NOT NULL,
    [estado]              CHAR (1)      NOT NULL,
    [FechaCreacion]       DATETIME      NULL,
    [FechaModificacion]   DATETIME      NULL,
    [FechaAnulacion]      DATETIME      NULL,
    [UsuarioCreacion]     VARCHAR (50)  NULL,
    [UsuarioModificacion] VARCHAR (50)  NULL,
    [UsuarioAnulacion]    VARCHAR (50)  NULL,
    [MotivoAnulacion]     VARCHAR (150) NULL,
    CONSTRAINT [PK_Aca_Profesor] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdProfesor] ASC),
    CONSTRAINT [FK_Aca_Profesor_Aca_Institucion] FOREIGN KEY ([IdInstitucion]) REFERENCES [dbo].[Aca_Institucion] ([IdInstitucion]),
    CONSTRAINT [FK_Aca_Profesor_tb_persona] FOREIGN KEY ([IdPersona]) REFERENCES [dbo].[tb_persona] ([IdPersona])
);

