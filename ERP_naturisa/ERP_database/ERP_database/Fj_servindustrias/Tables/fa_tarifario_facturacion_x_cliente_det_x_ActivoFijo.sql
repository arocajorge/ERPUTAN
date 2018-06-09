CREATE TABLE [Fj_servindustrias].[fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo] (
    [IdEmpresa]                INT          NOT NULL,
    [IdTarifario]              DECIMAL (18) NOT NULL,
    [IdActivoFijo]             INT          NOT NULL,
    [Valor_x_Unidad]           FLOAT (53)   NULL,
    [Unidades_minimas]         FLOAT (53)   NULL,
    [Num_empleado_relacionado] INT          NULL,
    CONSTRAINT [PK_fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTarifario] ASC, [IdActivoFijo] ASC)
);

