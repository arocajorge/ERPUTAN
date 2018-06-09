CREATE TABLE [dbo].[pre_ordencompra_local_det] (
    [IdEmpresa]         INT           NOT NULL,
    [IdSucursal]        INT           NOT NULL,
    [IdOrdenCompra]     NUMERIC (18)  NOT NULL,
    [Secuencia]         INT           NOT NULL,
    [IdPedidoXPre]      NUMERIC (18)  NOT NULL,
    [Secuencia_reg_ped] INT           NOT NULL,
    [IdPresupuesto_pre] NUMERIC (18)  NOT NULL,
    [IdAnio_pre]        INT           NOT NULL,
    [Secuencia_pre]     INT           NOT NULL,
    [Producto]          VARCHAR (150) NOT NULL,
    [do_Cantidad]       FLOAT (53)    NOT NULL,
    [do_precioCompra]   FLOAT (53)    NOT NULL,
    [do_porc_des]       FLOAT (53)    NOT NULL,
    [do_descuento]      FLOAT (53)    NOT NULL,
    [do_subtotal]       FLOAT (53)    NOT NULL,
    [do_iva]            FLOAT (53)    NOT NULL,
    [do_total]          FLOAT (53)    NOT NULL,
    [do_ManejaIva]      CHAR (1)      NOT NULL,
    [do_observacion]    VARCHAR (200) NOT NULL,
    [do_NumDocumento]   VARCHAR (50)  NULL,
    CONSTRAINT [PK_pre_ordencompra_local_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdOrdenCompra] ASC, [Secuencia] ASC)
);

