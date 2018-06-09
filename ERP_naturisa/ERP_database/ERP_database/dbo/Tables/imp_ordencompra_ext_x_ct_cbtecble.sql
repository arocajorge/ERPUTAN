CREATE TABLE [dbo].[imp_ordencompra_ext_x_ct_cbtecble] (
    [imp_IdEmpresa]        INT          NOT NULL,
    [imp_IdSucusal]        INT          NOT NULL,
    [imp_IdOrdenCompraExt] NUMERIC (18) NOT NULL,
    [ct_IdEmpresa]         INT          NOT NULL,
    [ct_IdTipoCbte]        INT          NOT NULL,
    [ct_IdCbteCble]        NUMERIC (18) NOT NULL,
    [TipoReg]              VARCHAR (5)  NULL,
    CONSTRAINT [PK_imp_ordencompra_ext_DiariosGenerados] PRIMARY KEY CLUSTERED ([imp_IdEmpresa] ASC, [imp_IdSucusal] ASC, [imp_IdOrdenCompraExt] ASC, [ct_IdEmpresa] ASC, [ct_IdTipoCbte] ASC, [ct_IdCbteCble] ASC),
    CONSTRAINT [FK_imp_ordencompra_ext_x_ct_cbtecble_ct_cbtecble] FOREIGN KEY ([ct_IdEmpresa], [ct_IdTipoCbte], [ct_IdCbteCble]) REFERENCES [dbo].[ct_cbtecble] ([IdEmpresa], [IdTipoCbte], [IdCbteCble]),
    CONSTRAINT [FK_imp_ordencompra_ext_x_ct_cbtecble_imp_ordencompra_ext] FOREIGN KEY ([imp_IdEmpresa], [imp_IdSucusal], [imp_IdOrdenCompraExt]) REFERENCES [dbo].[imp_ordencompra_ext] ([IdEmpresa], [IdSucusal], [IdOrdenCompraExt])
);

