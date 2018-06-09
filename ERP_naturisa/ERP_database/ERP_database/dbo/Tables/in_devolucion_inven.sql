CREATE TABLE [dbo].[in_devolucion_inven] (
    [IdEmpresa]             INT           NOT NULL,
    [IdDev_Inven]           NUMERIC (18)  NOT NULL,
    [cod_Dev_Inven]         VARCHAR (50)  NOT NULL,
    [Fecha]                 DATETIME      NOT NULL,
    [Devuelve_toda_tran]    BIT           NOT NULL,
    [estado]                CHAR (1)      NOT NULL,
    [IdSucursal_movi_inven] INT           NOT NULL,
    [IdMovi_inven_tipo]     INT           NOT NULL,
    [IdNumMovi]             NUMERIC (18)  NOT NULL,
    [IdUsuario]             VARCHAR (50)  NULL,
    [Fecha_Transac]         DATETIME      NULL,
    [IdUsuarioUltModi]      VARCHAR (50)  NULL,
    [Fecha_UltMod]          DATETIME      NULL,
    [IdusuarioUltAnu]       VARCHAR (50)  NULL,
    [Fecha_UltAnu]          DATETIME      NULL,
    [nom_pc]                VARCHAR (50)  NULL,
    [ip]                    VARCHAR (50)  NULL,
    [observacion]           VARCHAR (300) NULL,
    [MotivoAnulacion]       VARCHAR (300) NULL,
    CONSTRAINT [PK_in_devolucion_inven] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDev_Inven] ASC)
);

