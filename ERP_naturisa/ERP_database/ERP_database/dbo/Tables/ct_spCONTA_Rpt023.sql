CREATE TABLE [dbo].[ct_spCONTA_Rpt023] (
    [IdEmpresa]          INT             NOT NULL,
    [IdCtaCble]          VARCHAR (20)    NOT NULL,
    [IdCentroCosto]      VARCHAR (20)    NOT NULL,
    [IdUsuario]          VARCHAR (50)    NOT NULL,
    [IdCtaCblePadre]     VARCHAR (20)    NULL,
    [Naturaleza]         VARCHAR (10)    NOT NULL,
    [NombreCuenta]       VARCHAR (1000)  NOT NULL,
    [NombreCentroCosto]  VARCHAR (1000)  NOT NULL,
    [EsCuentaMovimiento] BIT             NOT NULL,
    [NivelCuenta]        INT             NOT NULL,
    [Saldo]              DECIMAL (18, 2) NOT NULL,
    [SaldoNaturaleza]    DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_ct_spCONTA_Rpt023] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCtaCble] ASC, [IdCentroCosto] ASC, [IdUsuario] ASC)
);

