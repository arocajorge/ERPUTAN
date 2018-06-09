CREATE TABLE [dbo].[cp_codigo_SRI_x_CtaCble] (
    [IdEmpresa]    INT          NOT NULL,
    [idCodigo_SRI] INT          NOT NULL,
    [IdCtaCble]    VARCHAR (20) NOT NULL,
    [fecha_UltMod] DATETIME     NOT NULL,
    [idUsuario]    VARCHAR (20) NOT NULL,
    [nom_pc]       VARCHAR (50) NOT NULL,
    [ip]           VARCHAR (25) NOT NULL,
    CONSTRAINT [PK_cp_codigo_SRI_x_CtaCble] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [idCodigo_SRI] ASC),
    CONSTRAINT [FK_cp_codigo_SRI_x_CtaCble_cp_codigo_SRI] FOREIGN KEY ([idCodigo_SRI]) REFERENCES [dbo].[cp_codigo_SRI] ([IdCodigo_SRI]),
    CONSTRAINT [FK_cp_codigo_SRI_x_CtaCble_ct_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble])
);

