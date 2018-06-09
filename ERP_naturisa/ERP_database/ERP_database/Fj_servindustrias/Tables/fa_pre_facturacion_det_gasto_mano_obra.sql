CREATE TABLE [Fj_servindustrias].[fa_pre_facturacion_det_gasto_mano_obra] (
    [Idempresa]         INT           NOT NULL,
    [IdPreFacturacion]  NUMERIC (18)  NOT NULL,
    [IdNomina_Tipo]     INT           NOT NULL,
    [IdEmpleado]        NUMERIC (18)  NOT NULL,
    [Observacion]       VARCHAR (100) NULL,
    [IdCentro_costo]    VARCHAR (20)  NULL,
    [IdSubCentroCosoto] VARCHAR (20)  NULL,
    CONSTRAINT [PK_fa_pre_facturacion_det_gasto_mano_obra] PRIMARY KEY CLUSTERED ([Idempresa] ASC, [IdPreFacturacion] ASC, [IdNomina_Tipo] ASC, [IdEmpleado] ASC)
);

