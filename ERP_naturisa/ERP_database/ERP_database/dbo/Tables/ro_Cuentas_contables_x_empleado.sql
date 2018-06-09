CREATE TABLE [dbo].[ro_Cuentas_contables_x_empleado] (
    [IdEmpresa]  INT          NOT NULL,
    [IdEmpleado] NUMERIC (18) NOT NULL,
    [IdRubro]    VARCHAR (10) NOT NULL,
    [IdCtaCble]  VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_ro_Cuentas_contables_x_empleado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC, [IdRubro] ASC, [IdCtaCble] ASC)
);

