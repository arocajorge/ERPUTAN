CREATE TABLE [dbo].[com_OrdenPedidoPlantillaDet] (
    [IdEmpresa]         INT            NOT NULL,
    [IdPlantilla]       NUMERIC (18)   NOT NULL,
    [Secuencia]         INT            NOT NULL,
    [IdProducto]        NUMERIC (18)   NULL,
    [pr_descripcion]    NVARCHAR (500) NULL,
    [IdUnidadMedida]    VARCHAR (25)   NULL,
    [IdSucursalOrigen]  INT            NOT NULL,
    [IdSucursalDestino] INT            NOT NULL,
    [IdPunto_cargo]     INT            NULL,
    [opd_Cantidad]      FLOAT (53)     NOT NULL,
    [opd_Detalle]       VARCHAR (MAX)  NULL,
    CONSTRAINT [PK_com_OrdenPedidoPlantillaDet] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPlantilla] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_com_OrdenPedidoPlantillaDet_com_OrdenPedido] FOREIGN KEY ([IdEmpresa], [IdPlantilla]) REFERENCES [dbo].[com_OrdenPedidoPlantilla] ([IdEmpresa], [IdPlantilla]),
    CONSTRAINT [FK_com_OrdenPedidoPlantillaDet_ct_punto_cargo] FOREIGN KEY ([IdEmpresa], [IdPunto_cargo]) REFERENCES [dbo].[ct_punto_cargo] ([IdEmpresa], [IdPunto_cargo]),
    CONSTRAINT [FK_com_OrdenPedidoPlantillaDet_in_Producto] FOREIGN KEY ([IdEmpresa], [IdProducto]) REFERENCES [dbo].[in_Producto] ([IdEmpresa], [IdProducto]),
    CONSTRAINT [FK_com_OrdenPedidoPlantillaDet_tb_sucursal] FOREIGN KEY ([IdEmpresa], [IdSucursalOrigen]) REFERENCES [dbo].[tb_sucursal] ([IdEmpresa], [IdSucursal]),
    CONSTRAINT [FK_com_OrdenPedidoPlantillaDet_tb_sucursal1] FOREIGN KEY ([IdEmpresa], [IdSucursalDestino]) REFERENCES [dbo].[tb_sucursal] ([IdEmpresa], [IdSucursal])
);

