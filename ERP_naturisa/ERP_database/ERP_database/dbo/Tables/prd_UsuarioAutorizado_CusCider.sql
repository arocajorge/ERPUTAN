CREATE TABLE [dbo].[prd_UsuarioAutorizado_CusCider] (
    [IdPersona]        NUMERIC (18)   NOT NULL,
    [Autoriza]         CHAR (1)       NOT NULL,
    [IdUsuario]        VARCHAR (20)   NOT NULL,
    [IdUsuarioAnu]     VARCHAR (20)   NULL,
    [MotivoAnu]        VARCHAR (100)  NULL,
    [IdUsuarioUltModi] VARCHAR (20)   NULL,
    [FechaAnu]         DATETIME       NULL,
    [FechaTransac]     DATETIME       NOT NULL,
    [FechaUltModi]     DATETIME       NULL,
    [Estado]           CHAR (1)       NOT NULL,
    [Observacion]      VARCHAR (1000) NULL,
    CONSTRAINT [PK_prd_UsuarioAutorizado_CusCider_1] PRIMARY KEY CLUSTERED ([IdPersona] ASC)
);

