﻿CREATE TABLE [dbo].[Af_Mej_Baj_Activo] (
    [IdEmpresa]             INT           NOT NULL,
    [Id_Mejora_Baja_Activo] NUMERIC (18)  NOT NULL,
    [Id_Tipo]               VARCHAR (20)  NOT NULL,
    [IdActivoFijo]          INT           NOT NULL,
    [IdProveedor]           NUMERIC (18)  NOT NULL,
    [Cod_Mej_Baj_Activo]    CHAR (20)     NOT NULL,
    [ValorActivo]           FLOAT (53)    NULL,
    [Valor_Mej_Baj_Activo]  FLOAT (53)    NULL,
    [Compr_Mej_Baj]         VARCHAR (50)  NULL,
    [DescripcionTecnica]    VARCHAR (500) NULL,
    [Motivo]                VARCHAR (500) NULL,
    [IdUsuario]             VARCHAR (20)  NULL,
    [Fecha_Transac]         DATETIME      NULL,
    [IdUsuarioUltMod]       VARCHAR (20)  NULL,
    [Fecha_UltMod]          DATETIME      NULL,
    [IdUsuarioUltAnu]       VARCHAR (20)  NULL,
    [Fecha_UltAnu]          DATETIME      NULL,
    [MotivoAnula]           VARCHAR (100) NULL,
    [nom_pc]                VARCHAR (50)  NULL,
    [ip]                    VARCHAR (25)  NULL,
    [Estado]                CHAR (1)      NULL,
    CONSTRAINT [PK_Af_Mej_Baj_Activo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [Id_Mejora_Baja_Activo] ASC, [Id_Tipo] ASC),
    CONSTRAINT [FK_Af_Mej_Baj_Activo_Af_Activo_fijo] FOREIGN KEY ([IdEmpresa], [IdActivoFijo]) REFERENCES [dbo].[Af_Activo_fijo] ([IdEmpresa], [IdActivoFijo]),
    CONSTRAINT [FK_Af_Mej_Baj_Activo_cp_proveedor] FOREIGN KEY ([IdEmpresa], [IdProveedor]) REFERENCES [dbo].[cp_proveedor] ([IdEmpresa], [IdProveedor])
);

