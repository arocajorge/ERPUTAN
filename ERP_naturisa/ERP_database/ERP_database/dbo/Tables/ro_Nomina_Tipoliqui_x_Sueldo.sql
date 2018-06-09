CREATE TABLE [dbo].[ro_Nomina_Tipoliqui_x_Sueldo] (
    [IdEmpresa]                   INT        NOT NULL,
    [IdNomina_Tipo]               INT        NOT NULL,
    [IdNomina_TipoLiqui]          INT        NOT NULL,
    [PorSueldo]                   FLOAT (53) NOT NULL,
    [PermiteAcumularDecimoTercer] BIT        NULL,
    [PermiteAcumularDecimoCuarto] BIT        NULL,
    [PermiteAcumularFondoReserva] BIT        NULL,
    CONSTRAINT [PK_ro_Nomina_Tipoliqui_x_Sueldo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdNomina_TipoLiqui] ASC)
);

