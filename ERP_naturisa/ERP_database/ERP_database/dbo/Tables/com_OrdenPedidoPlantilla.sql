CREATE TABLE [dbo].[com_OrdenPedidoPlantilla] (
    [IdEmpresa]         INT           NOT NULL,
    [IdPlantilla]       NUMERIC (18)  NOT NULL,
    [op_Codigo]         VARCHAR (50)  NULL,
    [op_Observacion]    VARCHAR (MAX) NULL,
    [Estado]            BIT           NOT NULL,
    [IdPunto_cargo]     INT           NULL,
    [IdUsuarioCreacion] VARCHAR (50)  NULL,
    [FechaCreacion]     DATETIME      NULL,
    [IdUsuarioUltModi]  VARCHAR (50)  NULL,
    [FechaUltModi]      DATETIME      NULL,
    [IdUsuarioAnu]      VARCHAR (50)  NULL,
    [FechaUltAnu]       DATETIME      NULL,
    [MotivoAnu]         VARCHAR (MAX) NULL,
    [EsCompraUrgente]   BIT           NULL,
    CONSTRAINT [PK_com_OrdenPedidoPlantilla] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPlantilla] ASC)
);

