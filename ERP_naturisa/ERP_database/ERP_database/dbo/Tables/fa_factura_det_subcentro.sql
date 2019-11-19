CREATE TABLE [dbo].[fa_factura_det_subcentro] (
    [IdEmpresa]                      INT          NOT NULL,
    [IdSucursal]                     INT          NOT NULL,
    [IdBodega]                       INT          NOT NULL,
    [IdCbteVta]                      NUMERIC (18) NOT NULL,
    [Secuencia]                      INT          NOT NULL,
    [vt_cantidad]                    FLOAT (53)   NOT NULL,
    [vt_Precio]                      FLOAT (53)   NOT NULL,
    [vt_PorDescUnitario]             FLOAT (53)   NOT NULL,
    [vt_DescUnitario]                FLOAT (53)   NOT NULL,
    [vt_PrecioFinal]                 FLOAT (53)   NOT NULL,
    [vt_Subtotal]                    FLOAT (53)   NOT NULL,
    [IdCod_Impuesto_Iva]             VARCHAR (25) NOT NULL,
    [vt_por_iva]                     FLOAT (53)   NOT NULL,
    [vt_iva]                         FLOAT (53)   NOT NULL,
    [vt_total]                       FLOAT (53)   NOT NULL,
    [IdCentroCosto]                  VARCHAR (20) NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20) NULL,
    CONSTRAINT [PK_fa_factura_det_subcentro] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdCbteVta] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_fa_factura_det_subcentro_ct_centro_costo_sub_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto], [IdCentroCosto_sub_centro_costo]) REFERENCES [dbo].[ct_centro_costo_sub_centro_costo] ([IdEmpresa], [IdCentroCosto], [IdCentroCosto_sub_centro_costo])
);

