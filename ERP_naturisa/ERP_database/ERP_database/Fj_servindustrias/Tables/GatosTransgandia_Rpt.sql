CREATE TABLE [Fj_servindustrias].[GatosTransgandia_Rpt] (
    [IdEmpresa]      INT           NOT NULL,
    [IdPeriodo]      INT           NOT NULL,
    [secuencia]      INT           NOT NULL,
    [IdProveedor]    NUMERIC (18)  NOT NULL,
    [Fecha]          DATE          NULL,
    [Proveedor]      VARCHAR (100) NULL,
    [Cantidad]       INT           NULL,
    [Factura]        VARCHAR (20)  NULL,
    [Descripcion]    VARCHAR (200) NULL,
    [Costounitario]  FLOAT (53)    NULL,
    [Total]          FLOAT (53)    NULL,
    [Fuerza]         VARCHAR (100) NULL,
    [NombreServicio] VARCHAR (200) NULL,
    CONSTRAINT [PK_ROLES_Rpt008_Tmp] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPeriodo] ASC, [secuencia] ASC)
);

