CREATE TABLE [Fj_servindustrias].[fa_tarifario_facturacion_x_cliente_det] (
    [IdEmpresa]        INT           NOT NULL,
    [IdTarifario]      NUMERIC (18)  NOT NULL,
    [Secuencia]        INT           NOT NULL,
    [cantidad]         INT           NOT NULL,
    [Valor_x_Unidad]   FLOAT (53)    NOT NULL,
    [Unidades_minimas] FLOAT (53)    NOT NULL,
    [IdUsuario]        VARCHAR (20)  NOT NULL,
    [Estado]           VARCHAR (1)   NOT NULL,
    [nom_pc]           VARCHAR (50)  NULL,
    [ip]               VARCHAR (25)  NULL,
    [IdUsuarioUltMod]  VARCHAR (20)  NULL,
    [FechaUltMod]      DATE          NULL,
    [IdUsuarioUltAnu]  VARCHAR (25)  NULL,
    [Fecha_UltAnu]     DATE          NULL,
    [MotiAnula]        VARCHAR (100) NULL,
    [IdCategoriaAF]    INT           NULL,
    CONSTRAINT [PK_fa_contrato_facturacion_x_cliente_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTarifario] ASC, [Secuencia] ASC)
);

