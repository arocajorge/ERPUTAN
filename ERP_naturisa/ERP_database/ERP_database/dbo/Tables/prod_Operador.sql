CREATE TABLE [dbo].[prod_Operador] (
    [IdOperador]      INT           NOT NULL,
    [IdEmpleado]      INT           NOT NULL,
    [NomEmpleado]     VARCHAR (100) NOT NULL,
    [Estado]          CHAR (1)      NOT NULL,
    [IdUsuario]       VARCHAR (20)  NOT NULL,
    [Fecha_Transac]   DATETIME      NOT NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [IdUsuarioUltAnu] VARCHAR (20)  NULL,
    [Fecha_UltAnu]    DATETIME      NULL,
    [nom_pc]          VARCHAR (50)  NULL,
    [ip]              VARCHAR (25)  NULL,
    [MotiAnula]       VARCHAR (200) NULL,
    CONSTRAINT [PK_prod_Operador] PRIMARY KEY CLUSTERED ([IdOperador] ASC, [IdEmpleado] ASC)
);

