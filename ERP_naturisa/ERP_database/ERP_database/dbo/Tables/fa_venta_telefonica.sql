CREATE TABLE [dbo].[fa_venta_telefonica] (
    [IdEmpresa]        INT           NOT NULL,
    [IdSucursal]       INT           NOT NULL,
    [IdVenta_tel]      NUMERIC (18)  NOT NULL,
    [IdCliente]        NUMERIC (18)  NOT NULL,
    [Fecha]            DATE          NOT NULL,
    [Observacion]      VARCHAR (250) NOT NULL,
    [IdMotivo]         VARCHAR (15)  NOT NULL,
    [Contactar_futuro] CHAR (1)      NOT NULL,
    [IdUsuario]        VARCHAR (20)  NOT NULL,
    [Estado]           CHAR (1)      NOT NULL,
    [Fecha_Transac]    DATETIME      NOT NULL,
    [IdUsuarioUltMod]  VARCHAR (20)  NULL,
    [Fecha_UltMod]     DATETIME      NULL,
    [IdUsuarioUltAnu]  VARCHAR (20)  NULL,
    [Fecha_UltAnu]     DATETIME      NULL,
    [nom_pc]           VARCHAR (50)  NULL,
    [ip]               VARCHAR (50)  NULL,
    CONSTRAINT [PK_fa_venta_telefonica] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdVenta_tel] ASC),
    CONSTRAINT [FK_fa_venta_telefonica_fa_cliente] FOREIGN KEY ([IdEmpresa], [IdCliente]) REFERENCES [dbo].[fa_cliente] ([IdEmpresa], [IdCliente]),
    CONSTRAINT [FK_fa_venta_telefonica_tb_sucursal] FOREIGN KEY ([IdEmpresa], [IdSucursal]) REFERENCES [dbo].[tb_sucursal] ([IdEmpresa], [IdSucursal])
);

