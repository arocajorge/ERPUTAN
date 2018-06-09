CREATE TABLE [dbo].[Aca_Jornada] (
    [IdJornada]           INT           NOT NULL,
    [IdSede]              INT           NOT NULL,
    [Descripcion_Jor]     VARCHAR (50)  NOT NULL,
    [CodJornada]          VARCHAR (25)  NOT NULL,
    [CodAlternoJor]       VARCHAR (25)  NOT NULL,
    [estado]              CHAR (1)      NOT NULL,
    [FechaCreacion]       DATETIME      NULL,
    [FechaModificacion]   DATETIME      NULL,
    [FechaAnulacion]      DATETIME      NULL,
    [UsuarioCreacion]     VARCHAR (25)  NULL,
    [UsuarioModificacion] VARCHAR (25)  NULL,
    [UsuarioAnulacion]    VARCHAR (25)  NULL,
    [MotivoAnulacion]     VARCHAR (150) NULL,
    CONSTRAINT [PK_Aca_Jornada_1] PRIMARY KEY CLUSTERED ([IdJornada] ASC),
    CONSTRAINT [FK_Aca_Jornada_Aca_Sede] FOREIGN KEY ([IdSede]) REFERENCES [dbo].[Aca_Sede] ([IdSede])
);

