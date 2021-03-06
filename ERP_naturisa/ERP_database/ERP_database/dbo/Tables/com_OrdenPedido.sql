﻿CREATE TABLE [dbo].[com_OrdenPedido] (
    [IdEmpresa]           INT           NOT NULL,
    [IdOrdenPedido]       NUMERIC (18)  NOT NULL,
    [op_Codigo]           VARCHAR (50)  NULL,
    [op_Fecha]            DATE          NOT NULL,
    [op_Observacion]      VARCHAR (MAX) NULL,
    [IdDepartamento]      NUMERIC (18)  NOT NULL,
    [IdSolicitante]       NUMERIC (18)  NOT NULL,
    [IdCatalogoEstado]    VARCHAR (25)  NOT NULL,
    [Estado]              BIT           NOT NULL,
    [IdPunto_cargo]       INT           NULL,
    [IdUsuarioCreacion]   VARCHAR (50)  NULL,
    [FechaCreacion]       DATETIME      NULL,
    [IdUsuarioUltModi]    VARCHAR (50)  NULL,
    [FechaUltModi]        DATETIME      NULL,
    [IdUsuarioAnu]        VARCHAR (50)  NULL,
    [FechaUltAnu]         DATETIME      NULL,
    [MotivoAnu]           VARCHAR (MAX) NULL,
    [EsCompraUrgente]     BIT           NULL,
    [ObservacionGA]       VARCHAR (MAX) NULL,
    [FechaAprobacion]     DATETIME      NULL,
    [IdUsuarioAprobacion] VARCHAR (50)  NULL,
    CONSTRAINT [PK_com_OrdenPedido] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdOrdenPedido] ASC),
    CONSTRAINT [FK_com_OrdenPedido_com_catalogo] FOREIGN KEY ([IdCatalogoEstado]) REFERENCES [dbo].[com_catalogo] ([IdCatalogocompra]),
    CONSTRAINT [FK_com_OrdenPedido_com_departamento] FOREIGN KEY ([IdEmpresa], [IdDepartamento]) REFERENCES [dbo].[com_departamento] ([IdEmpresa], [IdDepartamento]),
    CONSTRAINT [FK_com_OrdenPedido_com_solicitante] FOREIGN KEY ([IdEmpresa], [IdSolicitante]) REFERENCES [dbo].[com_solicitante] ([IdEmpresa], [IdSolicitante])
);

