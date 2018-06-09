CREATE TABLE [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas] (
    [IdEmpresa]                      INT          NOT NULL,
    [IdPreFacturacion]               NUMERIC (18) NOT NULL,
    [secuencia]                      INT          NOT NULL,
    [IdPeriodo]                      INT          NOT NULL,
    [IdCentroCosto]                  VARCHAR (20) NOT NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20) NOT NULL,
    [IdPunto_cargo_PC]               INT          NOT NULL,
    [IdActivoFijo]                   INT          NOT NULL,
    [Cantidad]                       FLOAT (53)   NOT NULL,
    [Costo_Uni]                      FLOAT (53)   NOT NULL,
    [Subtotal]                       FLOAT (53)   NOT NULL,
    [Aplica_Iva]                     BIT          NOT NULL,
    [Por_Iva]                        FLOAT (53)   NOT NULL,
    [Valor_Iva]                      FLOAT (53)   NOT NULL,
    [Total]                          FLOAT (53)   NOT NULL,
    [Estado]                         VARCHAR (50) NULL,
    [IdTarifario]                    NUMERIC (18) NULL,
    [Facturar]                       BIT          NOT NULL,
    [Porc_ganancia]                  FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_fa_pre_facturacion_det_cobro_x_Unidades_Consumidas] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPreFacturacion] ASC, [secuencia] ASC)
);

