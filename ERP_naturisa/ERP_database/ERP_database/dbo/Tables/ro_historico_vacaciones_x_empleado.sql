CREATE TABLE [dbo].[ro_historico_vacaciones_x_empleado] (
    [IdEmpresa]        INT          NOT NULL,
    [IdEmpleado]       NUMERIC (18) NOT NULL,
    [IdHis_Vacaciones] INT          NOT NULL,
    [Secuencia]        INT          NOT NULL,
    [FechaIni]         DATE         NULL,
    [FechaFin]         DATE         NULL,
    [DiasGanado]       INT          NULL,
    [DiasTomados]      INT          NULL,
    CONSTRAINT [PK_ro_historico_vacaciones_x_empleado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC, [IdHis_Vacaciones] ASC, [Secuencia] ASC)
);

