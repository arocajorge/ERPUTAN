CREATE TABLE [dbo].[Aca_Paralelo] (
    [IdParalelo]           INT           NOT NULL,
    [IdAnioLectivo]        INT           NULL,
    [CodParalelo]          VARCHAR (50)  NOT NULL,
    [IdCurso]              INT           NOT NULL,
    [CodAlterno]           VARCHAR (50)  NOT NULL,
    [CodUntis]             VARCHAR (50)  NULL,
    [Descripcion_paralelo] VARCHAR (100) NOT NULL,
    [Estado]               CHAR (1)      NOT NULL,
    [FechaCreacion]        DATETIME      NULL,
    [FechaModificacion]    DATETIME      NULL,
    [FechaAnulacion]       DATETIME      NULL,
    [UsuarioCreacion]      VARCHAR (25)  NULL,
    [UsuarioModificacion]  VARCHAR (25)  NULL,
    [UsuarioAnulacion]     VARCHAR (25)  NULL,
    [MotivoAnulacion]      VARCHAR (150) NULL,
    CONSTRAINT [PK_Aca_Paralelo] PRIMARY KEY CLUSTERED ([IdParalelo] ASC),
    CONSTRAINT [FK_Aca_Paralelo_Aca_curso] FOREIGN KEY ([IdCurso]) REFERENCES [dbo].[Aca_curso] ([IdCurso])
);

