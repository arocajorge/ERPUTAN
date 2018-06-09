CREATE TABLE [dbo].[ro_Config_Rubros_Acumulado] (
    [IdEmpresa]    INT          NOT NULL,
    [IdRubro]      VARCHAR (50) NOT NULL,
    [FechaInicio]  DATETIME     NOT NULL,
    [FechaFin]     DATETIME     NOT NULL,
    [Configurable] BIT          NULL,
    CONSTRAINT [PK_ro_Config_Rubros_Acumulado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdRubro] ASC)
);

