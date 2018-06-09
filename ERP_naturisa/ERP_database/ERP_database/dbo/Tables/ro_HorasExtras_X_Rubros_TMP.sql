CREATE TABLE [dbo].[ro_HorasExtras_X_Rubros_TMP] (
    [IdEmpresa]      INT           NOT NULL,
    [IdNomina]       INT           NOT NULL,
    [IdDepartamento] INT           NOT NULL,
    [IdEmpleado]     INT           NOT NULL,
    [Num_horas25]    FLOAT (53)    NULL,
    [Valor_hora_25]  FLOAT (53)    NULL,
    [Num_horas50]    FLOAT (53)    NULL,
    [Valor_hora_50]  FLOAT (53)    NULL,
    [Num_horas100]   FLOAT (53)    NULL,
    [Valor_hora_100] FLOAT (53)    NULL,
    [Nomina]         VARCHAR (100) NULL,
    [Nombre]         VARCHAR (100) NULL,
    [Cedula]         VARCHAR (15)  NULL,
    [Departamento]   VARCHAR (100) NULL,
    CONSTRAINT [PK_ro_HorasExtras_X_Rubros_TMP] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina] ASC, [IdDepartamento] ASC, [IdEmpleado] ASC)
);

