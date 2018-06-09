CREATE TABLE [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Movilizacion] (
    [IdEmpresa]                      INT          NOT NULL,
    [IdPrefacturacion]               NUMERIC (18) NOT NULL,
    [secuencia]                      INT          NOT NULL,
    [IdActivoFijo]                   INT          NOT NULL,
    [IdCentro_Costo]                 VARCHAR (20) NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20) NULL,
    [IdPunto_cargo]                  INT          NULL,
    [Movilizacion]                   FLOAT (53)   NULL,
    [Facturar]                       BIT          NOT NULL,
    [IdTarifario]                    NUMERIC (18) NULL,
    [Porc_ganancia]                  FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_fa_pre_facturacion_det_cobro_x_Movilizacion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPrefacturacion] ASC, [secuencia] ASC)
);

