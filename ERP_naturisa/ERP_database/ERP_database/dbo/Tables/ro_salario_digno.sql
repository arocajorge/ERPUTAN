CREATE TABLE [dbo].[ro_salario_digno] (
    [IdEmpresa]        INT           NOT NULL,
    [IdNominaTipo]     INT           NOT NULL,
    [IdPeriodo]        INT           NOT NULL,
    [SueldoDigno]      FLOAT (53)    NOT NULL,
    [Observacion]      VARCHAR (255) NULL,
    [UtilidadRepartir] FLOAT (53)    NOT NULL,
    [FechaIngresa]     DATETIME      NOT NULL,
    [UsuarioIngresa]   VARCHAR (25)  NOT NULL,
    [FechaModifica]    DATETIME      NULL,
    [UsuarioModifica]  VARCHAR (25)  NULL,
    CONSTRAINT [PK_ro_salario_digno] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNominaTipo] ASC, [IdPeriodo] ASC),
    CONSTRAINT [FK_ro_salario_digno_ro_Nomina_Tipo] FOREIGN KEY ([IdEmpresa], [IdNominaTipo]) REFERENCES [dbo].[ro_Nomina_Tipo] ([IdEmpresa], [IdNomina_Tipo]),
    CONSTRAINT [FK_ro_salario_digno_ro_periodo] FOREIGN KEY ([IdEmpresa], [IdPeriodo]) REFERENCES [dbo].[ro_periodo] ([IdEmpresa], [IdPeriodo])
);

