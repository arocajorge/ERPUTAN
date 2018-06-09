CREATE TABLE [dbo].[ro_empleado_gastos_perso_x_otros_gast_deduci] (
    [IdEmpresa]           INT          NOT NULL,
    [IdEmpleado]          NUMERIC (18) NOT NULL,
    [Anio_fiscal]         INT          NOT NULL,
    [secuencia]           INT          NOT NULL,
    [Valor_Pension_alim]  FLOAT (53)   NULL,
    [Valor_no_cub_x_aseg] FLOAT (53)   NULL,
    CONSTRAINT [PK_ro_empleado_gastos_perso_x_otros_gast_deduci] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC, [Anio_fiscal] ASC, [secuencia] ASC)
);

