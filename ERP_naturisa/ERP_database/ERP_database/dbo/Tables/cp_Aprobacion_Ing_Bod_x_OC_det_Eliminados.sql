CREATE TABLE [dbo].[cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados] (
    [IdEmpresa]                          INT          NOT NULL,
    [IdAprobacion]                       NUMERIC (18) NOT NULL,
    [Secuencia]                          INT          NOT NULL,
    [IdEmpresa_Ing_Egr_Inv]              INT          NOT NULL,
    [IdSucursal_Ing_Egr_Inv]             INT          NOT NULL,
    [IdNumMovi_Ing_Egr_Inv]              NUMERIC (18) NOT NULL,
    [Secuencia_Ing_Egr_Inv]              INT          NOT NULL,
    [Cantidad]                           FLOAT (53)   NOT NULL,
    [Costo_uni]                          FLOAT (53)   NOT NULL,
    [Descuento]                          FLOAT (53)   NOT NULL,
    [SubTotal]                           FLOAT (53)   NOT NULL,
    [PorIva]                             FLOAT (53)   NOT NULL,
    [valor_Iva]                          FLOAT (53)   NOT NULL,
    [Total]                              FLOAT (53)   NOT NULL,
    [IdCtaCble_Gasto]                    VARCHAR (20) NOT NULL,
    [IdCtaCble_IVA]                      VARCHAR (20) NULL,
    [IdCentro_Costo_x_Gasto_x_cxp]       VARCHAR (20) NULL,
    [IdCentroCosto_sub_centro_costo_cxp] VARCHAR (20) NULL,
    [IdMovi_inven_tipo_Ing_Egr_Inv]      INT          NOT NULL,
    CONSTRAINT [PK_cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdAprobacion] ASC, [Secuencia] ASC)
);

