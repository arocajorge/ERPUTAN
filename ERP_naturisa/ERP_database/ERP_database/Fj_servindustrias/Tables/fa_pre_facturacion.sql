CREATE TABLE [Fj_servindustrias].[fa_pre_facturacion] (
    [IdEmpresa]        INT          NOT NULL,
    [IdPreFacturacion] NUMERIC (18) NOT NULL,
    [IdPeriodo]        INT          NOT NULL,
    [Observacion]      VARCHAR (50) NOT NULL,
    [IdEstado_Proceso] VARCHAR (25) NOT NULL,
    [fecha]            DATETIME     NOT NULL,
    [estado]           CHAR (1)     NOT NULL,
    CONSTRAINT [PK_fa_pre_facturacion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPreFacturacion] ASC, [IdPeriodo] ASC)
);

