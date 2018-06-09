CREATE TABLE [dbo].[imp_ordencompra_ext_x_imp_gastosxImport_det] (
    [IdEmpresa]        INT          NOT NULL,
    [IdRegistroGasto]  NUMERIC (18) NOT NULL,
    [IdSucursal]       INT          NOT NULL,
    [IdOrdenCompraExt] NUMERIC (18) NOT NULL,
    [Secuencia]        INT          NOT NULL,
    [IdGastoImp]       INT          NOT NULL,
    [Valor]            FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_imp_ordencompra_ext_x_imp_gastosxImport_det_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdRegistroGasto] ASC, [IdSucursal] ASC, [Secuencia] ASC, [IdOrdenCompraExt] ASC),
    CONSTRAINT [FK_imp_ordencompra_ext_x_imp_gastosxImport_det_imp_ordencompra_ext_det] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdOrdenCompraExt], [Secuencia]) REFERENCES [dbo].[imp_ordencompra_ext_det] ([IdEmpresa], [IdSucursal], [IdOrdenCompraExt], [Secuencia])
);

