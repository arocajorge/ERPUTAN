CREATE TABLE [dbo].[ro_Acta_Finiquito_Detalle] (
    [IdEmpresa]       INT           NOT NULL,
    [IdActaFiniquito] NUMERIC (18)  NOT NULL,
    [IdEmpleado]      NUMERIC (18)  NOT NULL,
    [IdSecuencia]     INT           NOT NULL,
    [Observacion]     VARCHAR (250) NOT NULL,
    [Signo]           VARCHAR (1)   NOT NULL,
    [Valor]           FLOAT (53)    NOT NULL,
    [IdUsuario]       VARCHAR (20)  NOT NULL,
    [Fecha_Transac]   DATETIME      NOT NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [Otros_valor]     FLOAT (53)    NULL,
    CONSTRAINT [PK_ro_Acta_Finiquito_Detalle] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdActaFiniquito] ASC, [IdEmpleado] ASC, [IdSecuencia] ASC),
    CONSTRAINT [FK_ro_Acta_Finiquito_Detalle_ro_Acta_Finiquito] FOREIGN KEY ([IdEmpresa], [IdActaFiniquito], [IdEmpleado]) REFERENCES [dbo].[ro_Acta_Finiquito] ([IdEmpresa], [IdActaFiniquito], [IdEmpleado])
);

