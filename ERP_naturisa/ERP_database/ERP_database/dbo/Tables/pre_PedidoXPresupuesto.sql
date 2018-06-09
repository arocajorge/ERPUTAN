CREATE TABLE [dbo].[pre_PedidoXPresupuesto] (
    [IdEmpresa]       INT           NOT NULL,
    [IdPedidoXPre]    NUMERIC (18)  NOT NULL,
    [IdDepartamento]  INT           NULL,
    [Fecha]           DATETIME      NOT NULL,
    [Observacion]     VARCHAR (100) NULL,
    [IdProveedor1]    NUMERIC (18)  NULL,
    [IdProveedor2]    NUMERIC (18)  NULL,
    [IdProveedor3]    NUMERIC (18)  NULL,
    [IdUsuario]       VARCHAR (20)  NULL,
    [Fecha_Transac]   DATETIME      NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [IdUsuarioUltAnu] VARCHAR (20)  NULL,
    [Fecha_UltAnu]    DATETIME      NULL,
    [nom_pc]          VARCHAR (50)  NULL,
    [ip]              VARCHAR (25)  NULL,
    [Estado]          CHAR (1)      NULL,
    [MotivoAnulacion] VARCHAR (200) NULL,
    CONSTRAINT [PK_Pre_PedidoXPresupuesto] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPedidoXPre] ASC)
);

