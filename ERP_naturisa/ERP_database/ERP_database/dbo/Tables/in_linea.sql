CREATE TABLE [dbo].[in_linea] (
    [IdEmpresa]       INT           NOT NULL,
    [IdCategoria]     VARCHAR (25)  NOT NULL,
    [IdLinea]         INT           NOT NULL,
    [cod_linea]       VARCHAR (50)  NOT NULL,
    [nom_linea]       VARCHAR (150) NOT NULL,
    [abreviatura]     VARCHAR (10)  NOT NULL,
    [observacion]     VARCHAR (150) NOT NULL,
    [Estado]          CHAR (1)      NOT NULL,
    [IdUsuario]       VARCHAR (20)  NOT NULL,
    [Fecha_Transac]   DATETIME      NOT NULL,
    [nom_pc]          VARCHAR (50)  NULL,
    [ip]              VARCHAR (25)  NULL,
    [MotiAnula]       VARCHAR (200) NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [IdUsuarioUltAnu] VARCHAR (20)  NULL,
    [Fecha_UltAnu]    DATETIME      NULL,
    CONSTRAINT [PK_in_linea] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCategoria] ASC, [IdLinea] ASC),
    CONSTRAINT [FK_in_linea_in_categorias] FOREIGN KEY ([IdEmpresa], [IdCategoria]) REFERENCES [dbo].[in_categorias] ([IdEmpresa], [IdCategoria])
);

