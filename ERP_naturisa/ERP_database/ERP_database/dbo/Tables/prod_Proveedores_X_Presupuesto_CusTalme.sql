CREATE TABLE [dbo].[prod_Proveedores_X_Presupuesto_CusTalme] (
    [IdEmpresa]   INT          NOT NULL,
    [Año]         INT          NOT NULL,
    [Mes]         INT          NOT NULL,
    [IdProveedor] NUMERIC (18) NOT NULL,
    [Presupuesto] FLOAT (53)   NULL,
    CONSTRAINT [PK_prod_Proveedores_X_Presupuesto_CusTalme] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [Año] ASC, [Mes] ASC, [IdProveedor] ASC)
);

