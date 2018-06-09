CREATE TABLE [dbo].[com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider] (
    [goc_IdEmpresa]     INT          NOT NULL,
    [goc_IdTransaccion] NUMERIC (18) NOT NULL,
    [goc_IdDetTrans]    INT          NOT NULL,
    [oc_IdEmpresa]      INT          NOT NULL,
    [oc_IdSucursal]     INT          NOT NULL,
    [oc_IdOrdenCompra]  NUMERIC (18) NOT NULL,
    [oc_Secuencia]      INT          NOT NULL,
    [dummy]             CHAR (1)     NULL,
    CONSTRAINT [PK_com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider] PRIMARY KEY CLUSTERED ([goc_IdEmpresa] ASC, [goc_IdTransaccion] ASC, [goc_IdDetTrans] ASC, [oc_IdEmpresa] ASC, [oc_IdSucursal] ASC, [oc_IdOrdenCompra] ASC, [oc_Secuencia] ASC),
    CONSTRAINT [FK_com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_com_GenerOCompra_Det] FOREIGN KEY ([goc_IdEmpresa], [goc_IdTransaccion], [goc_IdDetTrans]) REFERENCES [dbo].[com_GenerOCompra_Det] ([IdEmpresa], [IdTransaccion], [IdDetTrans]),
    CONSTRAINT [FK_com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_com_ordencompra_local_det] FOREIGN KEY ([oc_IdEmpresa], [oc_IdSucursal], [oc_IdOrdenCompra], [oc_Secuencia]) REFERENCES [dbo].[com_ordencompra_local_det] ([IdEmpresa], [IdSucursal], [IdOrdenCompra], [Secuencia])
);

