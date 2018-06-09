CREATE TABLE [dbo].[ba_parametros] (
    [IdEmpresa]                          INT           NOT NULL,
    [El_Diario_Contable_es_modificable]  BIT           NOT NULL,
    [CiudadDefaultParaCrearCheques]      VARCHAR (25)  NULL,
    [IdUsuario]                          VARCHAR (20)  NULL,
    [IdUsuarioUltMod]                    VARCHAR (20)  NULL,
    [FechaUltMod]                        DATETIME      NULL,
    [nom_pc]                             VARCHAR (50)  NULL,
    [ip]                                 VARCHAR (25)  NULL,
    [IdTipoCbte_x_Prestamo]              INT           NULL,
    [IdTipoNota_ND_Can_Cuotas]           INT           NULL,
    [Ruta_descarga_fila_x_PreAviso_cheq] VARCHAR (200) NULL,
    [IdCtaCble_Interes]                  VARCHAR (20)  NULL,
    [IdCtaCble_prestamos]                VARCHAR (20)  NULL,
    CONSTRAINT [PK_ba_parametros] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC),
    CONSTRAINT [FK_ba_parametros_tb_ciudad] FOREIGN KEY ([CiudadDefaultParaCrearCheques]) REFERENCES [dbo].[tb_ciudad] ([IdCiudad]),
    CONSTRAINT [FK_ba_parametros_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);

