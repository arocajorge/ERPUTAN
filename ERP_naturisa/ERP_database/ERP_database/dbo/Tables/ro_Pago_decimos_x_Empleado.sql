CREATE TABLE [dbo].[ro_Pago_decimos_x_Empleado] (
    [IdEmpresa]          INT          NOT NULL,
    [IdEmpleado]         NUMERIC (18) NOT NULL,
    [IdTipoDecimo_rubro] VARCHAR (10) NOT NULL,
    [Anio_Fiscal]        INT          NOT NULL,
    [Valor_Acumulado]    FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_ro_pago_decimos_x_Empleado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC, [IdTipoDecimo_rubro] ASC, [Anio_Fiscal] ASC)
);

