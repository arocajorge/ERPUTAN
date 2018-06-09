CREATE TABLE [dbo].[prod_Parametros_x_MoviInven_x_ModeloProduccion] (
    [IdEmpresa]                                INT          NOT NULL,
    [IdModeloProd]                             INT          NOT NULL,
    [Secuencia]                                INT          NOT NULL,
    [IdSucursal_IngxProducTermi]               INT          NULL,
    [IdBodega_IngxProducTermi]                 INT          NULL,
    [IdMovi_inven_tipo_x_IngxProduc_ProdTermi] INT          NULL,
    [IdSucursal_EgrxMateriaPrima]              INT          NULL,
    [IdBodega_EgrxMateriaPrima]                INT          NULL,
    [IdMovi_inven_tipo_x_EgrxProduc_MatPri]    INT          NULL,
    [IdProducto_ParaIngreso]                   NUMERIC (18) NULL,
    [IdProducto_ParaEgreso]                    NUMERIC (18) NULL,
    CONSTRAINT [PK_prod_Parametros_x_MoviInven_x_ModeloProduccion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdModeloProd] ASC, [Secuencia] ASC)
);

