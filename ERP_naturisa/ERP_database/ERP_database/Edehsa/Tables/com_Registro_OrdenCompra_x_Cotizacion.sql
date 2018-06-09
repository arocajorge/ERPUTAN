CREATE TABLE [Edehsa].[com_Registro_OrdenCompra_x_Cotizacion] (
    [IdEmpresa]                  INT          NOT NULL,
    [IdSucursal]                 INT          NOT NULL,
    [IdOrdenCompra]              NUMERIC (18) NOT NULL,
    [IdCotizacion]               NUMERIC (18) NOT NULL,
    [SecuenciaDetalleCotizacion] NUMERIC (18) NOT NULL,
    [IdListadoMateriales]        NUMERIC (18) NOT NULL,
    [estado]                     BIT          NOT NULL,
    CONSTRAINT [PK_com_Registro_OrdenCompra_x_Cotizacion_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdOrdenCompra] ASC, [IdCotizacion] ASC, [SecuenciaDetalleCotizacion] ASC, [IdListadoMateriales] ASC)
);

