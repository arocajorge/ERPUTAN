CREATE TABLE [Fj_servindustrias].[fa_pre_facturacion_det_Cobro_x_Depreciacion] (
    [IdEmpresa]                      INT           NOT NULL,
    [IdPreFacturacion]               NUMERIC (18)  NOT NULL,
    [secuencia]                      INT           NOT NULL,
    [IdCentro_Costo]                 VARCHAR (20)  NOT NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20)  NOT NULL,
    [IdPunto_cargo]                  INT           NOT NULL,
    [IdEmpresa_dep]                  INT           NOT NULL,
    [IdDepreciacion_dep]             NUMERIC (18)  NOT NULL,
    [IdTarifario]                    NUMERIC (18)  NULL,
    [Porc_ganancia]                  FLOAT (53)    NOT NULL,
    [Facturar]                       BIT           NOT NULL,
    [secuencia_dep]                  INT           NOT NULL,
    [IdActivoFijo]                   INT           NOT NULL,
    [concepto]                       VARCHAR (150) NOT NULL,
    [Total_depreciado_x_cobrar]      FLOAT (53)    NOT NULL,
    [Costo_unitario]                 FLOAT (53)    NULL,
    [Valor_salvamento]               FLOAT (53)    NULL,
    CONSTRAINT [PK_fa_pre_facturacion_det_Cobro_x_Depreciacion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPreFacturacion] ASC, [secuencia] ASC)
);

