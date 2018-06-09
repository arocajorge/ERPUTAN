CREATE TABLE [dbo].[ro_empleado_gastos_perso_x_Gastos_deduci] (
    [IdEmpresa]      INT          NOT NULL,
    [IdEmpleado]     NUMERIC (18) NOT NULL,
    [Anio_fiscal]    INT          NOT NULL,
    [Secuencia]      INT          NOT NULL,
    [Ruc]            VARCHAR (20) NULL,
    [Num_CbteVta]    VARCHAR (50) NULL,
    [Base_Imponible] FLOAT (53)   NULL,
    [IdTipoGastos]   VARCHAR (20) NULL,
    CONSTRAINT [PK_ro_empleado_gastos_perso_x_Gastos_deduci] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC, [Anio_fiscal] ASC, [Secuencia] ASC)
);

