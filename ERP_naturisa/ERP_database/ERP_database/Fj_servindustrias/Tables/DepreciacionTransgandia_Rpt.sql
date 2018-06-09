CREATE TABLE [Fj_servindustrias].[DepreciacionTransgandia_Rpt] (
    [IdEmpresa]                 INT           NOT NULL,
    [IdPeriodo]                 INT           NOT NULL,
    [IdActivofijo]              INT           NOT NULL,
    [Secuencia]                 INT           NOT NULL,
    [Fecha_adquisicion]         DATE          NULL,
    [Proveedor]                 VARCHAR (100) NULL,
    [Factura]                   VARCHAR (30)  NULL,
    [Cantidad]                  INT           NULL,
    [Af_nombre]                 VARCHAR (200) NULL,
    [Costo_Unitario_Camion]     FLOAT (53)    NULL,
    [Costo_unitario_carroceria] FLOAT (53)    NULL,
    [ValorSalvamento]           FLOAT (53)    NULL,
    [TotalDepreciar]            FLOAT (53)    NULL,
    [DepreciacionMensual]       FLOAT (53)    NULL,
    CONSTRAINT [PK_DepreciacionTransgandia_Rpt] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPeriodo] ASC, [IdActivofijo] ASC, [Secuencia] ASC)
);

