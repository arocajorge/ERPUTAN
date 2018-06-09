CREATE TABLE [dbo].[prd_DespachoDet] (
    [IdEmpresa]          INT             NOT NULL,
    [IdSucursal]         INT             NOT NULL,
    [IdDespacho]         NUMERIC (18)    NOT NULL,
    [Secuencia]          INT             NOT NULL,
    [precio]             DECIMAL (18, 2) NULL,
    [peso]               DECIMAL (18, 2) NULL,
    [IdOrdenTaller]      NUMERIC (18)    NOT NULL,
    [Hora]               TIME (0)        NOT NULL,
    [IdProducto]         NUMERIC (18)    NOT NULL,
    [CodigoBarraMaestro] NVARCHAR (100)  NULL,
    [CodigoBarra]        NVARCHAR (100)  NOT NULL,
    [Cantidad]           FLOAT (53)      NOT NULL,
    [Observacion]        VARCHAR (200)   NULL,
    CONSTRAINT [PK_prd_DespachoDet_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdDespacho] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_prd_DespachoDet_in_Producto] FOREIGN KEY ([IdEmpresa], [IdProducto]) REFERENCES [dbo].[in_Producto] ([IdEmpresa], [IdProducto]),
    CONSTRAINT [FK_prd_DespachoDet_prd_Despacho] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdDespacho]) REFERENCES [dbo].[prd_Despacho] ([IdEmpresa], [IdSucursal], [IdDespacho]),
    CONSTRAINT [FK_prd_DespachoDet_prd_Orden_Taller] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdOrdenTaller]) REFERENCES [dbo].[prd_Orden_Taller] ([IdEmpresa], [IdSucursal], [IdOrdenTaller])
);

