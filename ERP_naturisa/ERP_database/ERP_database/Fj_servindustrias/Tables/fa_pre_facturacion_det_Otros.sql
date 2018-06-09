CREATE TABLE [Fj_servindustrias].[fa_pre_facturacion_det_Otros] (
    [IdEmpresa]        INT           NOT NULL,
    [IdPreFacturacion] NUMERIC (18)  NOT NULL,
    [secuencia]        INT           NOT NULL,
    [Valor]            FLOAT (53)    NOT NULL,
    [Nombre_Cobro]     VARCHAR (200) NOT NULL,
    [Observacion]      VARCHAR (200) NULL,
    CONSTRAINT [PK_fa_pre_facturacion_det_Otros] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPreFacturacion] ASC, [secuencia] ASC)
);

