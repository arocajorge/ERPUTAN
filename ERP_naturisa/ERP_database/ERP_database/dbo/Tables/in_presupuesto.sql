﻿CREATE TABLE [dbo].[in_presupuesto] (
    [IdEmpresa]             INT            NOT NULL,
    [IdSucursal]            INT            NOT NULL,
    [IdPresupuesto]         NUMERIC (18)   NOT NULL,
    [Tipo]                  VARCHAR (5)    NOT NULL,
    [IdProveedor]           NUMERIC (18)   NOT NULL,
    [pr_plazo]              INT            NOT NULL,
    [pr_fecha]              DATETIME       NOT NULL,
    [pr_subtotal]           FLOAT (53)     NOT NULL,
    [pr_iva]                FLOAT (53)     NOT NULL,
    [pr_descuento]          FLOAT (53)     NOT NULL,
    [pr_pordesc]            SMALLINT       NOT NULL,
    [pr_flete]              FLOAT (53)     NOT NULL,
    [pr_total]              FLOAT (53)     NOT NULL,
    [pr_Base_conIva]        FLOAT (53)     NOT NULL,
    [pr_Base_sinIva]        FLOAT (53)     NOT NULL,
    [pr_observacion]        VARCHAR (1000) NOT NULL,
    [Fechreg]               DATETIME       NOT NULL,
    [Estado]                CHAR (1)       NOT NULL,
    [pr_NumDocumento]       VARCHAR (50)   NULL,
    [IdEstadoAprobacion]    CHAR (3)       NOT NULL,
    [co_fecha_aprobacion]   DATETIME       NULL,
    [IdTerminoPago]         INT            NULL,
    [co_FechaFactProv]      DATETIME       NULL,
    [co_DiasFecFacProv]     INT            NULL,
    [co_fecha_salida]       DATETIME       NULL,
    [co_fecha_llegada]      DATETIME       NULL,
    [IdUsuario_Aprueba]     VARCHAR (20)   NULL,
    [IdUsuario_Reprue]      VARCHAR (20)   NULL,
    [co_fechaReproba]       DATETIME       NULL,
    [Fecha_Transac]         DATETIME       NULL,
    [Fecha_UltMod]          DATETIME       NULL,
    [IdUsuarioUltMod]       CHAR (20)      NULL,
    [FechaHoraAnul]         DATETIME       NULL,
    [IdUsuarioUltAnu]       CHAR (20)      NULL,
    [pr_PesoTotal]          FLOAT (53)     NULL,
    [IdCentroCosto]         VARCHAR (20)   NULL,
    [pr_fecha_emision]      DATETIME       NULL,
    [IdUsuario_Solicitante] VARCHAR (20)   NULL,
    [IdUsuario_Emicion]     VARCHAR (20)   NULL,
    CONSTRAINT [PK_in_presupuesto_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdPresupuesto] ASC),
    CONSTRAINT [FK_in_presupuesto_cp_proveedor] FOREIGN KEY ([IdEmpresa], [IdProveedor]) REFERENCES [dbo].[cp_proveedor] ([IdEmpresa], [IdProveedor]),
    CONSTRAINT [FK_in_presupuesto_tb_sucursal] FOREIGN KEY ([IdEmpresa], [IdSucursal]) REFERENCES [dbo].[tb_sucursal] ([IdEmpresa], [IdSucursal])
);

