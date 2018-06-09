CREATE TABLE [dbo].[Aca_Contrato_x_Estudiante] (
    [IdInstitucion]                    INT            NOT NULL,
    [IdContrato]                       NUMERIC (18)   NOT NULL,
    [IdSede]                           INT            NOT NULL,
    [IdMatricula]                      NUMERIC (18)   NOT NULL,
    [IdAnioLectivo]                    INT            NOT NULL,
    [IdEstudiante]                     NUMERIC (18)   NOT NULL,
    [observacion]                      VARCHAR (1550) NOT NULL,
    [FechaCreacion]                    DATETIME       NULL,
    [FechaModificacion]                DATETIME       NULL,
    [FechaAnulacion]                   DATETIME       NULL,
    [UsuarioCreacion]                  VARCHAR (50)   NULL,
    [UsuarioModificacion]              VARCHAR (50)   NULL,
    [UsuarioAnulacion]                 VARCHAR (50)   NULL,
    [MotivoAnulacion]                  VARCHAR (150)  NULL,
    [estado_contrato_con_prefactura]   BIT            NULL,
    [estado_contrato_pago_garantizado] BIT            NULL,
    [estado]                           BIT            NOT NULL,
    CONSTRAINT [PK_Aca_Contrato_x_Estudiante] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdContrato] ASC),
    CONSTRAINT [FK_Aca_Contrato_x_Estudiante_Aca_matricula] FOREIGN KEY ([IdInstitucion], [IdSede], [IdMatricula]) REFERENCES [dbo].[Aca_matricula] ([IdInstitucion], [IdSede], [IdMatricula])
);

