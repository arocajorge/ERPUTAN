CREATE TABLE [Fj_servindustrias].[fa_liquidaciones_tipo_proceso] (
    [IdTipo_Proceso]             VARCHAR (50)  NOT NULL,
    [nom_IdTipo_Proceso_x_Liqui] VARCHAR (150) NOT NULL,
    [IdProducto_Liqui_x_defecto] INT           NULL,
    [IdEmpresa_Prod_Liqui]       INT           NULL,
    CONSTRAINT [PK_fa_liquidaciones_tipo_proceso] PRIMARY KEY CLUSTERED ([IdTipo_Proceso] ASC),
    CONSTRAINT [FK_fa_liquidaciones_tipo_proceso_fa_liquidacion_gastos_producto] FOREIGN KEY ([IdEmpresa_Prod_Liqui], [IdProducto_Liqui_x_defecto]) REFERENCES [Fj_servindustrias].[fa_liquidacion_gastos_producto] ([IdEmpresa], [IdProducto_Liqui])
);

