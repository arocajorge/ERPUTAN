CREATE TABLE [dbo].[Aca_Contrato_x_Estudiante_det] (
    [IdInstitucion]       INT           NOT NULL,
    [IdContrato]          NUMERIC (18)  NOT NULL,
    [IdRubro]             NUMERIC (18)  NOT NULL,
    [IdInstitucion_Per]   INT           NOT NULL,
    [IdAnioLectivo_Per]   INT           NOT NULL,
    [IdPeriodo_Per]       INT           NOT NULL,
    [FechaCreacion]       DATETIME      NULL,
    [FechaModificacion]   DATETIME      NULL,
    [FechaAnulacion]      DATETIME      NULL,
    [UsuarioCreacion]     VARCHAR (50)  NULL,
    [UsuarioModificacion] VARCHAR (50)  NULL,
    [UsuarioAnulacion]    VARCHAR (50)  NULL,
    [MotivoAnulacion]     VARCHAR (250) NULL,
    [Observacion]         VARCHAR (50)  NOT NULL,
    [estado]              BIT           NULL,
    CONSTRAINT [PK_Aca_Contrato_x_Estudiante_det] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdContrato] ASC, [IdRubro] ASC, [IdInstitucion_Per] ASC, [IdAnioLectivo_Per] ASC, [IdPeriodo_Per] ASC)
);

