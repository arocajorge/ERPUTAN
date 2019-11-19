CREATE TABLE [dbo].[com_solicitante] (
    [IdEmpresa]            INT           NOT NULL,
    [IdSolicitante]        NUMERIC (18)  NOT NULL,
    [nom_solicitante]      VARCHAR (500) NOT NULL,
    [estado]               VARCHAR (50)  NOT NULL,
    [IdUsuario]            VARCHAR (20)  NULL,
    [IdDepartamento]       NUMERIC (18)  NULL,
    [ConsultaDepartamento] BIT           NOT NULL,
    [Fecha_Transac]        DATETIME      NULL,
    [IdUsuarioUltMod]      VARCHAR (20)  NULL,
    [Fecha_UltMod]         DATETIME      NULL,
    [IdUsuarioUltAnu]      VARCHAR (20)  NULL,
    [Fecha_UltAnu]         DATETIME      NULL,
    [MotiAnula]            VARCHAR (150) NULL,
    CONSTRAINT [PK_com_solicitante] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSolicitante] ASC),
    CONSTRAINT [FK_com_solicitante_com_departamento] FOREIGN KEY ([IdEmpresa], [IdDepartamento]) REFERENCES [dbo].[com_departamento] ([IdEmpresa], [IdDepartamento]),
    CONSTRAINT [FK_com_solicitante_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);



