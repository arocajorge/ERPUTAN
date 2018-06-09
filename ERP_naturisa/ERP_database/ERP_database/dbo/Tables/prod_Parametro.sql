CREATE TABLE [dbo].[prod_Parametro] (
    [IdEmpresa]                                           INT          NOT NULL,
    [IdSucursal_IngxProduc]                               INT          NOT NULL,
    [IdBodega_IngxProduc]                                 INT          NOT NULL,
    [IdMovi_inven_tipo_x_IngxProduc_ProdTermi]            INT          NOT NULL,
    [IdMovi_inven_tipo_x_EgrxProduc_MatPri]               INT          NOT NULL,
    [IdCargo_JefeTurno]                                   INT          NOT NULL,
    [IdSucursal_EgrxMateriaPrima]                         INT          NULL,
    [IdBodega_EgrxMateriaPrima]                           NCHAR (10)   NULL,
    [IdProducto_ChatarraProcesada]                        NUMERIC (18) NOT NULL,
    [IdProducto_ChatarraNoProcesada]                      NUMERIC (18) NOT NULL,
    [IdMovi_inven_tipo_x_IngXProdAceriaProdTerm]          INT          NOT NULL,
    [IdMovi_inven_tipo_x_EgrxProduAceria_ChatNoProcesada] INT          NOT NULL,
    [IdMovi_inven_tipo_x_EgrxProduAceria_ChatProcesada]   INT          NOT NULL,
    [IdMovi_inven_tipo_x_IngCompraChatarra]               INT          NULL,
    [IdProducto_ChatarraIngreso]                          NUMERIC (18) NULL,
    [IdBodegaCompraChatarra]                              INT          NULL,
    [IdSucursalCOmpraChatarra]                            INT          NULL,
    CONSTRAINT [PK_prod_Parametro] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC)
);

