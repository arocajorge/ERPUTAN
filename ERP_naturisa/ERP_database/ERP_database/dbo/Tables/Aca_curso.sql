CREATE TABLE [dbo].[Aca_curso] (
    [IdCurso]             INT           NOT NULL,
    [IdSeccion]           INT           NOT NULL,
    [CodCurso]            VARCHAR (50)  NOT NULL,
    [CodAlternoCur]       VARCHAR (50)  NOT NULL,
    [Descripcion_cur]     VARCHAR (50)  NOT NULL,
    [estado]              CHAR (1)      NOT NULL,
    [FechaCreacion]       DATETIME      NULL,
    [FechaModificacion]   DATETIME      NULL,
    [FechaAnulacion]      DATETIME      NULL,
    [UsuarioCreacion]     VARCHAR (25)  NULL,
    [UsuarioModificacion] VARCHAR (25)  NULL,
    [UsuarioAnulacion]    VARCHAR (25)  NULL,
    [MotivoAnulacion]     VARCHAR (150) NULL,
    [es_sistema_dual]     BIT           CONSTRAINT [DF_Aca_curso_es_sistema_dual] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Aca_curso] PRIMARY KEY CLUSTERED ([IdCurso] ASC),
    CONSTRAINT [FK_Aca_curso_Aca_Seccion] FOREIGN KEY ([IdSeccion]) REFERENCES [dbo].[Aca_Seccion] ([IdSeccion])
);

