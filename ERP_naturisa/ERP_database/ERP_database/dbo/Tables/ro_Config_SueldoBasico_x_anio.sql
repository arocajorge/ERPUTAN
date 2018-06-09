CREATE TABLE [dbo].[ro_Config_SueldoBasico_x_anio] (
    [sb_IdRubro]      VARCHAR (10) NOT NULL,
    [sb_anio]         INT          NOT NULL,
    [sb_valor]        FLOAT (53)   NOT NULL,
    [IdUsuario]       VARCHAR (20) NOT NULL,
    [Fecha_Transac]   DATETIME     NOT NULL,
    [IdUsuarioUltMod] VARCHAR (20) NULL,
    [Fecha_UltMod]    DATETIME     NULL,
    [IdUsuarioUltAnu] VARCHAR (20) NULL,
    [Fecha_UltAnu]    DATETIME     NULL,
    [nom_pc]          VARCHAR (50) NOT NULL,
    [ip]              VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ro_Config_SueldoBasico_x_anio] PRIMARY KEY CLUSTERED ([sb_IdRubro] ASC, [sb_anio] ASC)
);

