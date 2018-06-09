CREATE TABLE [dbo].[prod_ModeloProduccion_CusTalme] (
    [IdModeloProd]                             INT          NOT NULL,
    [Descripcion]                              VARCHAR (50) NULL,
    [Estado]                                   CHAR (1)     NULL,
    [Tipo]                                     NCHAR (10)   NULL,
    [IdSucursal_IngxProduc]                    INT          NULL,
    [IdBodega_IngxProduc]                      INT          NULL,
    [IdMovi_inven_tipo_x_IngxProduc_ProdTermi] INT          NULL,
    [IdMovi_inven_tipo_x_EgrxProduc_MatPri]    INT          NULL,
    [IdCargo_JefeTurno]                        INT          NULL,
    [IdSucursal_EgrxMateriaPrima]              INT          NULL,
    [IdBodega_EgrxMateriaPrima]                INT          NULL,
    CONSTRAINT [PK_prod_ModeloProduccion_CusTalme] PRIMARY KEY CLUSTERED ([IdModeloProd] ASC)
);

