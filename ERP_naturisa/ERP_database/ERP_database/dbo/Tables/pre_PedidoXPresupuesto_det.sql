CREATE TABLE [dbo].[pre_PedidoXPresupuesto_det] (
    [IdEmpresa]           INT           NOT NULL,
    [IdPedidoXPre]        NUMERIC (18)  NOT NULL,
    [Secuencia_reg]       INT           NOT NULL,
    [IdPresupuesto_pre]   NUMERIC (18)  NOT NULL,
    [IdAnio_pre]          INT           NOT NULL,
    [Secuencia_pre]       INT           NOT NULL,
    [Producto]            VARCHAR (150) NOT NULL,
    [Cant]                FLOAT (53)    NOT NULL,
    [CodEstadoAprobacion] VARCHAR (3)   NULL,
    [Cotizado]            VARCHAR (1)   NULL,
    [UltiFechaEstadoApro] DATETIME      NULL,
    [IdUsuarioEstadoApro] VARCHAR (20)  NULL,
    CONSTRAINT [PK_Pre_PedidoxPresupuesto_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPedidoXPre] ASC, [Secuencia_reg] ASC)
);

