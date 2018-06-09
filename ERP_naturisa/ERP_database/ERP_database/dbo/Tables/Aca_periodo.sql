CREATE TABLE [dbo].[Aca_periodo] (
    [IdInstitucion]   INT           NOT NULL,
    [IdAnioLectivo]   INT           NOT NULL,
    [IdPeriodo]       INT           NOT NULL,
    [pe_anio]         INT           NOT NULL,
    [pe_mes]          INT           NOT NULL,
    [pe_FechaIni]     SMALLDATETIME NOT NULL,
    [pe_FechaFin]     SMALLDATETIME NOT NULL,
    [pe_estado]       NVARCHAR (1)  NOT NULL,
    [Fecha_Transac]   DATETIME      NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [IdUsuarioUltMod] VARCHAR (25)  NULL,
    [FechaHoraAnul]   DATETIME      NULL,
    [IdUsuarioUltAnu] VARCHAR (25)  NULL,
    [MotivoAnulacion] VARCHAR (100) NULL,
    [est_apertura]    CHAR (1)      NULL,
    CONSTRAINT [PK_Aca_periodo] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdAnioLectivo] ASC, [IdPeriodo] ASC),
    CONSTRAINT [FK_Aca_periodo_Aca_Anio_Lectivo] FOREIGN KEY ([IdInstitucion], [IdAnioLectivo]) REFERENCES [dbo].[Aca_Anio_Lectivo] ([IdInstitucion], [IdAnioLectivo]),
    CONSTRAINT [FK_Aca_periodo_tb_mes] FOREIGN KEY ([pe_mes]) REFERENCES [dbo].[tb_mes] ([idMes])
);

