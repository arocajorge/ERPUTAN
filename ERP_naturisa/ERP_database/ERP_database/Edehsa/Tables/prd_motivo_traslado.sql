CREATE TABLE [Edehsa].[prd_motivo_traslado] (
    [IdEmpresa]                   INT           NOT NULL,
    [IdMotivo_traslado]           INT           NOT NULL,
    [codMotivo_traslado]          VARCHAR (50)  NOT NULL,
    [descripcion_motivo_traslado] VARCHAR (250) NOT NULL,
    [Estado]                      CHAR (1)      NOT NULL,
    [FechaModificacion]           DATETIME      NULL,
    [FechaCreacion]               DATETIME      NULL,
    [UsuarioModificacion]         VARCHAR (50)  NULL,
    [UsuarioCreacion]             VARCHAR (50)  NULL,
    [FechaAnulacion]              DATETIME      NULL,
    [UsuarioAnulacion]            VARCHAR (50)  NULL,
    [MotivoAnulacion]             VARCHAR (100) NULL,
    CONSTRAINT [PK_fa_motivo_traslado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdMotivo_traslado] ASC)
);

