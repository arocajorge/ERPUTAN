CREATE TABLE [dbo].[prod_PuenteGrua] (
    [idEmpresa]        INT           NOT NULL,
    [Idsucural]        INT           NOT NULL,
    [idPuenteGrua]     INT           NOT NULL,
    [nombre]           VARCHAR (50)  NOT NULL,
    [marca]            VARCHAR (50)  NULL,
    [tonelada_Soporta] INT           NULL,
    [IdUsuario]        VARCHAR (20)  NOT NULL,
    [IdOperador]       INT           NULL,
    [Fecha_Transac]    DATETIME      NOT NULL,
    [IdUsuarioUltMod]  VARCHAR (20)  NULL,
    [Fecha_UltMod]     DATETIME      NULL,
    [IdUsuarioUltAnu]  VARCHAR (20)  NULL,
    [Fecha_UltAnu]     DATETIME      NULL,
    [nom_pc]           VARCHAR (50)  NULL,
    [ip]               VARCHAR (25)  NULL,
    [MotiAnula]        VARCHAR (200) NULL,
    [estado]           CHAR (1)      NOT NULL,
    CONSTRAINT [PK_prod_PuenteGrua] PRIMARY KEY CLUSTERED ([idEmpresa] ASC, [Idsucural] ASC, [idPuenteGrua] ASC)
);

