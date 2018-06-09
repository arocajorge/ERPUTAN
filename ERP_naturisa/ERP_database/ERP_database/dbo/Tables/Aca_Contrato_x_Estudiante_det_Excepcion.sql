CREATE TABLE [dbo].[Aca_Contrato_x_Estudiante_det_Excepcion] (
    [IdInstitucion]       INT          NOT NULL,
    [IdContrato]          NUMERIC (18) NOT NULL,
    [IdRubro]             NUMERIC (18) NOT NULL,
    [IdInstitucion_Per]   INT          NOT NULL,
    [IdAnioLectivo_Per]   INT          NOT NULL,
    [IdPeriodo_Per]       INT          NOT NULL,
    [IdExepcion]          NUMERIC (18) NOT NULL,
    [ValorExepcion]       FLOAT (53)   NOT NULL,
    [estado]              BIT          NOT NULL,
    [FechaCreacion]       DATETIME     NULL,
    [UsuarioCreacion]     VARCHAR (50) NULL,
    [FechaModificacion]   DATETIME     NULL,
    [UsuarioModificacion] VARCHAR (50) NULL,
    [FechaAnulaicon]      DATETIME     NULL,
    [UsuarioAnulacion]    VARCHAR (50) NULL,
    CONSTRAINT [PK_Aca_Contrato_x_Estudiante_det_Excepcion] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdContrato] ASC, [IdRubro] ASC, [IdInstitucion_Per] ASC, [IdAnioLectivo_Per] ASC, [IdPeriodo_Per] ASC, [IdExepcion] ASC)
);

