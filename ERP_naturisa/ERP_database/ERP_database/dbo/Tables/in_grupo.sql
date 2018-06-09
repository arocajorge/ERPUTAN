CREATE TABLE [dbo].[in_grupo] (
    [IdEmpresa]       INT           NOT NULL,
    [IdCategoria]     VARCHAR (25)  NOT NULL,
    [IdLinea]         INT           NOT NULL,
    [IdGrupo]         INT           NOT NULL,
    [cod_grupo]       VARCHAR (50)  NOT NULL,
    [nom_grupo]       VARCHAR (150) NOT NULL,
    [Estado]          CHAR (1)      NOT NULL,
    [abreviatura]     VARCHAR (10)  NOT NULL,
    [observacion]     VARCHAR (150) NOT NULL,
    [IdUsuario]       VARCHAR (20)  NOT NULL,
    [Fecha_Transac]   DATETIME      NOT NULL,
    [nom_pc]          VARCHAR (50)  NULL,
    [ip]              VARCHAR (25)  NULL,
    [MotiAnula]       VARCHAR (200) NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [IdUsuarioUltAnu] VARCHAR (20)  NULL,
    [Fecha_UltAnu]    DATETIME      NULL,
    CONSTRAINT [PK_in_grupo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCategoria] ASC, [IdLinea] ASC, [IdGrupo] ASC),
    CONSTRAINT [FK_in_grupo_in_linea] FOREIGN KEY ([IdEmpresa], [IdCategoria], [IdLinea]) REFERENCES [dbo].[in_linea] ([IdEmpresa], [IdCategoria], [IdLinea])
);

