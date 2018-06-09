CREATE TABLE [Fj_servindustrias].[ro_Calculo_Pago_Variable_Porcentaje] (
    [IdEmpresa]            INT          NOT NULL,
    [IdTipo_Nomina]        INT          NOT NULL,
    [IdEfectividad]        INT          NOT NULL,
    [Efec_Entrega_Rango]   FLOAT (53)   NOT NULL,
    [Efec_Entrega_Aplica]  FLOAT (53)   NOT NULL,
    [Efec_Volumen_Rango]   FLOAT (53)   NOT NULL,
    [Efec_Volumen_Aplica]  FLOAT (53)   NOT NULL,
    [Recup_Cartera_Rango]  FLOAT (53)   NOT NULL,
    [Recup_Cartera_Aplica] FLOAT (53)   NOT NULL,
    [Estado]               BIT          NOT NULL,
    [IdUsuario]            VARCHAR (50) NULL,
    [Fecha_Transaccion]    DATETIME     NULL,
    [IdUsuarioUltModi]     VARCHAR (50) NULL,
    [Fecha_UltMod]         DATETIME     NULL,
    [IdUsuarioUltAnu]      VARCHAR (50) NULL,
    [Fecha_UltAnu]         DATETIME     NULL,
    [MotivoAnulacion]      VARCHAR (50) NULL,
    [nom_pc]               VARCHAR (50) NULL,
    [ip]                   VARCHAR (50) NULL,
    CONSTRAINT [PK_ro_Calculo_Pago_Variable_Porcentaje] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipo_Nomina] ASC, [IdEfectividad] ASC)
);

