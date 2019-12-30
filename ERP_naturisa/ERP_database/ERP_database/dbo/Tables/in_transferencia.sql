﻿CREATE TABLE [dbo].[in_transferencia] (
    [IdEmpresa]                        INT            NOT NULL,
    [IdSucursalOrigen]                 INT            NOT NULL,
    [IdBodegaOrigen]                   INT            NOT NULL,
    [IdTransferencia]                  NUMERIC (18)   NOT NULL,
    [Codigo]                           VARCHAR (50)   NULL,
    [IdSucursalDest]                   INT            NOT NULL,
    [IdBodegaDest]                     INT            NOT NULL,
    [tr_Observacion]                   VARCHAR (500)  NOT NULL,
    [tr_fecha]                         DATETIME       NOT NULL,
    [IdEmpresa_Ing_Egr_Inven_Origen]   INT            NULL,
    [IdSucursal_Ing_Egr_Inven_Origen]  INT            NULL,
    [IdMovi_inven_tipo_SucuOrig]       INT            NULL,
    [IdNumMovi_Ing_Egr_Inven_Origen]   NUMERIC (18)   NULL,
    [IdEmpresa_Ing_Egr_Inven_Destino]  INT            NULL,
    [IdSucursal_Ing_Egr_Inven_Destino] INT            NULL,
    [IdMovi_inven_tipo_SucuDest]       INT            NULL,
    [IdNumMovi_Ing_Egr_Inven_Destino]  NUMERIC (18)   NULL,
    [IdUsuario]                        VARCHAR (20)   NULL,
    [Estado]                           CHAR (1)       NOT NULL,
    [tr_userAnulo]                     VARCHAR (20)   NULL,
    [tr_fechaAnulacion]                DATETIME       NULL,
    [tr_fecha_transaccion]             DATETIME       NULL,
    [IdUsuarioUltMod]                  VARCHAR (20)   NULL,
    [Fecha_UltMod]                     DATETIME       NULL,
    [motivo_anula]                     VARCHAR (1000) NULL,
    [IdGuia]                           NUMERIC (18)   NULL,
    [EstadoRevision]                   VARCHAR (5)    NULL,
    [IdUsuarioRevision]                VARCHAR (50)   NULL,
    [FechaRevision]                    DATETIME       NULL,
    CONSTRAINT [PK_in_transferencia] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursalOrigen] ASC, [IdBodegaOrigen] ASC, [IdTransferencia] ASC),
    CONSTRAINT [FK_in_transferencia_in_Ing_Egr_Inven] FOREIGN KEY ([IdEmpresa_Ing_Egr_Inven_Origen], [IdSucursal_Ing_Egr_Inven_Origen], [IdMovi_inven_tipo_SucuOrig], [IdNumMovi_Ing_Egr_Inven_Origen]) REFERENCES [dbo].[in_Ing_Egr_Inven] ([IdEmpresa], [IdSucursal], [IdMovi_inven_tipo], [IdNumMovi]),
    CONSTRAINT [FK_in_transferencia_in_Ing_Egr_Inven1] FOREIGN KEY ([IdEmpresa_Ing_Egr_Inven_Destino], [IdSucursal_Ing_Egr_Inven_Destino], [IdMovi_inven_tipo_SucuDest], [IdNumMovi_Ing_Egr_Inven_Destino]) REFERENCES [dbo].[in_Ing_Egr_Inven] ([IdEmpresa], [IdSucursal], [IdMovi_inven_tipo], [IdNumMovi]),
    CONSTRAINT [FK_in_transferencia_tb_bodega] FOREIGN KEY ([IdEmpresa], [IdSucursalOrigen], [IdBodegaOrigen]) REFERENCES [dbo].[tb_bodega] ([IdEmpresa], [IdSucursal], [IdBodega])
);







