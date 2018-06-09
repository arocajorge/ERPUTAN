CREATE TABLE [dbo].[ro_Historico_Liquidacion_Vacaciones_Det] (
    [IdEmpresa]              INT          NOT NULL,
    [IdNominatipo]           INT          NOT NULL,
    [IdSolicitud_Vacaciones] INT          NOT NULL,
    [IdEmpleado]             NUMERIC (18) NOT NULL,
    [Sec]                    INT          NOT NULL,
    [Anio]                   INT          NOT NULL,
    [Mes]                    INT          NOT NULL,
    [Total_Remuneracion]     FLOAT (53)   NOT NULL,
    [Total_Vacaciones]       FLOAT (53)   NOT NULL,
    [Valor_Cancelar]         FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_ro_Historico_Liquidacion_Vacaciones_Det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNominatipo] ASC, [IdSolicitud_Vacaciones] ASC, [IdEmpleado] ASC, [Sec] ASC),
    CONSTRAINT [FK_ro_Historico_Liquidacion_Vacaciones_Det_ro_Historico_Liquidacion_Vacaciones] FOREIGN KEY ([IdEmpresa], [IdNominatipo], [IdSolicitud_Vacaciones], [IdEmpleado]) REFERENCES [dbo].[ro_Historico_Liquidacion_Vacaciones] ([IdEmpresa], [IdNomina_Tipo], [IdSolicitud_Vacaciones], [IdEmpleado])
);

