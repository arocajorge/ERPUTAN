CREATE TABLE [Fj_servindustrias].[ro_descuento_no_planificados_Det] (
    [IdEmpresa]         INT           NOT NULL,
    [IdNomina_Tipo]     INT           NOT NULL,
    [IdNomina_Tipo_Liq] INT           NOT NULL,
    [IdEmpleado]        NUMERIC (18)  NOT NULL,
    [IdDescuento]       INT           NOT NULL,
    [IdRubro]           VARCHAR (50)  NOT NULL,
    [Secuencia]         INT           NOT NULL,
    [Observacion]       VARCHAR (200) NULL,
    [Valor]             FLOAT (53)    NOT NULL,
    [Fecha_Descuento]   DATE          NOT NULL,
    CONSTRAINT [PK_ro_descuento_no_planificados_Det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdNomina_Tipo_Liq] ASC, [IdEmpleado] ASC, [IdDescuento] ASC, [IdRubro] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_ro_descuento_no_planificados_Det_ro_descuento_no_planificados] FOREIGN KEY ([IdEmpresa], [IdNomina_Tipo], [IdEmpleado], [IdDescuento]) REFERENCES [Fj_servindustrias].[ro_descuento_no_planificados] ([IdEmpresa], [IdNomina_Tipo], [IdEmpleado], [IdDescuento])
);

