CREATE TABLE [Fj_servindustrias].[fa_pre_facturacion_Parametro] (
    [IdEmpresa]                INT          NOT NULL,
    [Se_Cobra_Iva]             BIT          NOT NULL,
    [Tipo_Cobro_Poliza_X]      VARCHAR (50) NULL,
    [IdSucursal_para_facturar] INT          NULL,
    [IdBodega_para_facturar]   INT          NULL,
    [Liquidar_x_grupo]         BIT          NOT NULL,
    CONSTRAINT [PK_fa_pre_facturacion_Parametro] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC)
);

