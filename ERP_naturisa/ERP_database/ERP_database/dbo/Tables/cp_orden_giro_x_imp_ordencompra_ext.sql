CREATE TABLE [dbo].[cp_orden_giro_x_imp_ordencompra_ext] (
    [og_IdEmpresa]         INT          NOT NULL,
    [og_IdCbteCble]        NUMERIC (18) NOT NULL,
    [og_IdTipoCbte]        INT          NOT NULL,
    [imp_IdEmpresa]        INT          NOT NULL,
    [imp_IdSucursal]       INT          NOT NULL,
    [imp_IdOrdenCompraExt] NUMERIC (18) NOT NULL,
    [IdGastoImp]           INT          NULL,
    CONSTRAINT [PK_cp_ordenGiro_x_Imp_ordenCompraExt] PRIMARY KEY CLUSTERED ([og_IdEmpresa] ASC, [og_IdCbteCble] ASC, [og_IdTipoCbte] ASC, [imp_IdEmpresa] ASC, [imp_IdSucursal] ASC, [imp_IdOrdenCompraExt] ASC),
    CONSTRAINT [FK_cp_orden_giro_x_imp_ordencompra_ext_cp_orden_giro] FOREIGN KEY ([og_IdEmpresa], [og_IdCbteCble], [og_IdTipoCbte]) REFERENCES [dbo].[cp_orden_giro] ([IdEmpresa], [IdCbteCble_Ogiro], [IdTipoCbte_Ogiro]),
    CONSTRAINT [FK_cp_orden_giro_x_imp_ordencompra_ext_imp_ordencompra_ext] FOREIGN KEY ([imp_IdEmpresa], [imp_IdSucursal], [imp_IdOrdenCompraExt]) REFERENCES [dbo].[imp_ordencompra_ext] ([IdEmpresa], [IdSucusal], [IdOrdenCompraExt])
);

