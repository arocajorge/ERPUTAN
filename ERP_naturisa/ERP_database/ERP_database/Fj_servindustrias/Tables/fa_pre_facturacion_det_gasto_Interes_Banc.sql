CREATE TABLE [Fj_servindustrias].[fa_pre_facturacion_det_gasto_Interes_Banc] (
    [IdEmpresa]            INT           NOT NULL,
    [IdPreFacturacion]     NUMERIC (18)  NOT NULL,
    [secuencia]            INT           NOT NULL,
    [IdPrestamo]           NUMERIC (9)   NOT NULL,
    [IdSecuencia_Prestamo] INT           NOT NULL,
    [IdCliente]            NUMERIC (9)   NOT NULL,
    [Valor]                FLOAT (53)    NOT NULL,
    [Observacion]          VARCHAR (200) NULL,
    CONSTRAINT [PK_fa_pre_facturacion_det_gasto_Interes_Banc] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPreFacturacion] ASC, [secuencia] ASC)
);

