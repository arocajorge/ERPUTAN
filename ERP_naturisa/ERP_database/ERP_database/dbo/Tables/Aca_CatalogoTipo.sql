CREATE TABLE [dbo].[Aca_CatalogoTipo] (
    [IdTipoCatalogo]  VARCHAR (25)  NOT NULL,
    [Descripcion]     NVARCHAR (50) NOT NULL,
    [estado]          VARCHAR (1)   NULL,
    [IdUsuario]       VARCHAR (20)  NULL,
    [nom_pc]          VARCHAR (50)  NULL,
    [ip]              VARCHAR (25)  NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [FechaUltMod]     DATETIME      NULL,
    [IdUsuarioUltAnu] VARCHAR (25)  NULL,
    [Fecha_UltAnu]    DATETIME      NULL,
    [MotiAnula]       VARCHAR (100) NULL,
    CONSTRAINT [PK_Aca_CatalogoTipo] PRIMARY KEY CLUSTERED ([IdTipoCatalogo] ASC)
);

