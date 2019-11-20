﻿CREATE TABLE [dbo].[com_CotizacionPedidoDet] (
    [IdEmpresa]         INT           NOT NULL,
    [IdCotizacion]      NUMERIC (18)  NOT NULL,
    [Secuencia]         INT           NOT NULL,
    [opd_IdEmpresa]     INT           NOT NULL,
    [opd_IdOrdenPedido] NUMERIC (18)  NOT NULL,
    [opd_Secuencia]     INT           NOT NULL,
    [IdProducto]        NUMERIC (18)  NOT NULL,
    [cd_Cantidad]       FLOAT (53)    NOT NULL,
    [cd_precioCompra]   FLOAT (53)    NOT NULL,
    [cd_porc_des]       FLOAT (53)    NOT NULL,
    [cd_descuento]      FLOAT (53)    NOT NULL,
    [cd_precioFinal]    FLOAT (53)    NOT NULL,
    [cd_subtotal]       FLOAT (53)    NOT NULL,
    [IdCod_Impuesto]    VARCHAR (25)  NOT NULL,
    [Por_Iva]           FLOAT (53)    NOT NULL,
    [cd_iva]            FLOAT (53)    NOT NULL,
    [cd_total]          FLOAT (53)    NOT NULL,
    [IdUnidadMedida]    VARCHAR (25)  NOT NULL,
    [IdPunto_cargo]     INT           NULL,
    [EstadoJC]          BIT           NOT NULL,
    [EstadoGA]          BIT           NOT NULL,
    [cd_DetallePorItem] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_com_CotizacionPedidoDet] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCotizacion] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_com_CotizacionPedidoDet_com_CotizacionPedido] FOREIGN KEY ([IdEmpresa], [IdCotizacion]) REFERENCES [dbo].[com_CotizacionPedido] ([IdEmpresa], [IdCotizacion]),
    CONSTRAINT [FK_com_CotizacionPedidoDet_com_OrdenPedidoDet] FOREIGN KEY ([opd_IdEmpresa], [opd_IdOrdenPedido], [opd_Secuencia]) REFERENCES [dbo].[com_OrdenPedidoDet] ([IdEmpresa], [IdOrdenPedido], [Secuencia])
);
