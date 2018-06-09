CREATE TABLE [dbo].[Aca_Rubro_x_Aca_Periodo_Lectivo] (
    [IdInstitucion_rub]   INT           NOT NULL,
    [IdRubro]             INT           NOT NULL,
    [IdInstitucion_per]   INT           NOT NULL,
    [IdAnioLectivo]       INT           NOT NULL,
    [IdPeriodo]           INT           NOT NULL,
    [Valor]               FLOAT (53)    NOT NULL,
    [Estado]              CHAR (1)      NOT NULL,
    [UsuarioCreacion]     VARCHAR (50)  NULL,
    [FechaCreacion]       DATETIME      NULL,
    [UsuarioModificacion] VARCHAR (50)  NULL,
    [FechaModificacion]   DATETIME      NULL,
    [UsuarioAnulacion]    VARCHAR (50)  NULL,
    [FechaAnulacion]      DATETIME      NULL,
    [MotivoAnulacion]     VARCHAR (150) NULL,
    CONSTRAINT [PK_Aca_Rubro_x_Aca_Periodo_Lectivo] PRIMARY KEY CLUSTERED ([IdInstitucion_rub] ASC, [IdRubro] ASC, [IdInstitucion_per] ASC, [IdAnioLectivo] ASC, [IdPeriodo] ASC),
    CONSTRAINT [FK_Aca_Rubro_x_Aca_Periodo_Lectivo_Aca_periodo] FOREIGN KEY ([IdInstitucion_per], [IdAnioLectivo], [IdPeriodo]) REFERENCES [dbo].[Aca_periodo] ([IdInstitucion], [IdAnioLectivo], [IdPeriodo]),
    CONSTRAINT [FK_Aca_Rubro_x_Aca_Periodo_Lectivo_Aca_Rubro] FOREIGN KEY ([IdInstitucion_rub], [IdRubro]) REFERENCES [dbo].[Aca_Rubro] ([IdInstitucion], [IdRubro])
);

