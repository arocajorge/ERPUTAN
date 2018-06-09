CREATE TABLE [dbo].[Aca_Pre_Facturacion] (
    [IdInstitucion]              INT           NOT NULL,
    [IdPreFacturacion]           NUMERIC (18)  NOT NULL,
    [IdInstitucion_contrato]     INT           NOT NULL,
    [IdPeriodo]                  INT           NOT NULL,
    [fecha_prefacturacion]       DATETIME      NOT NULL,
    [IdEmpresa_fact]             INT           NOT NULL,
    [IdSucursal_fact]            INT           NOT NULL,
    [IdBodega_fact]              INT           NULL,
    [IdCbteVta]                  NUMERIC (18)  NULL,
    [IdPtoVta_fact]              INT           NOT NULL,
    [IdCaja_fact]                INT           NOT NULL,
    [vt_fecha_fact]              DATETIME      NOT NULL,
    [vt_plazo_fact]              INT           NOT NULL,
    [vt_fech_venc]               DATETIME      NOT NULL,
    [observacion_fact]           VARCHAR (500) NOT NULL,
    [Estado_Pre_factutacion_Cat] VARCHAR (10)  NOT NULL,
    CONSTRAINT [PK_Aca_Pre_Facturacion] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdPreFacturacion] ASC)
);

