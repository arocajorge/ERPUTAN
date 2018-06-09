CREATE TABLE [dbo].[Aca_Seccion] (
    [IdSeccion]           INT           NOT NULL,
    [IdJornada]           INT           NOT NULL,
    [CodSeccion]          VARCHAR (50)  NOT NULL,
    [CodAlterno_Sec]      VARCHAR (50)  NOT NULL,
    [Descripcion_secc]    VARCHAR (50)  NOT NULL,
    [estado]              CHAR (1)      NOT NULL,
    [FechaCreacion]       DATETIME      NULL,
    [FechaModificacion]   DATETIME      NULL,
    [FechaAnulacion]      DATETIME      NULL,
    [UsuarioCreacion]     VARCHAR (25)  NULL,
    [UsuarioModificacion] VARCHAR (25)  NULL,
    [UsuarioAnulacion]    VARCHAR (25)  NULL,
    [MotivoAnulacion]     VARCHAR (150) NULL,
    CONSTRAINT [PK_Aca_Seccion] PRIMARY KEY CLUSTERED ([IdSeccion] ASC),
    CONSTRAINT [FK_Aca_Seccion_Aca_Jornada] FOREIGN KEY ([IdJornada]) REFERENCES [dbo].[Aca_Jornada] ([IdJornada])
);

