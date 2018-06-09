CREATE TABLE [dbo].[imp_ordencompra_ext_x_Condiciones_Pago] (
    [IdEmpresa]           INT            NOT NULL,
    [IdSucusal]           INT            NOT NULL,
    [IdOrdenCompraExt]    NUMERIC (18)   NOT NULL,
    [Secuencia]           INT            NOT NULL,
    [IdCondicion_Pago]    VARCHAR (15)   NULL,
    [Fecha_Pago]          DATETIME       NOT NULL,
    [IdConfirmacion_Pago] VARCHAR (15)   NOT NULL,
    [Por_Pago]            FLOAT (53)     NOT NULL,
    [Valor_Pago]          FLOAT (53)     NOT NULL,
    [Observacion]         VARCHAR (1000) NOT NULL,
    CONSTRAINT [PK_imp_ordencompra_ext_x_Condiciones_Pago_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucusal] ASC, [IdOrdenCompraExt] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_imp_ordencompra_ext_x_Condiciones_Pago_com_ordencompra_local_det] FOREIGN KEY ([IdEmpresa], [IdSucusal], [IdOrdenCompraExt], [Secuencia]) REFERENCES [dbo].[com_ordencompra_local_det] ([IdEmpresa], [IdSucursal], [IdOrdenCompra], [Secuencia])
);

