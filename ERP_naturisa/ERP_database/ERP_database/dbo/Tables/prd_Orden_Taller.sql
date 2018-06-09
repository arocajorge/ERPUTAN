CREATE TABLE [dbo].[prd_Orden_Taller] (
    [IdEmpresa]        INT             NOT NULL,
    [IdSucursal]       INT             NOT NULL,
    [IdOrdenTaller]    NUMERIC (18)    NOT NULL,
    [CodObra]          VARCHAR (20)    NOT NULL,
    [NumeroOT]         INT             NOT NULL,
    [Codigo]           VARCHAR (20)    NOT NULL,
    [IdProducto]       NUMERIC (18)    NOT NULL,
    [CantidadPieza]    DECIMAL (18, 2) NOT NULL,
    [PesoUnitaro]      DECIMAL (18, 2) NOT NULL,
    [TotalPeso]        DECIMAL (18, 2) NOT NULL,
    [Estado]           CHAR (1)        NOT NULL,
    [Observacion]      VARCHAR (150)   NOT NULL,
    [FechaReg]         DATETIME        NOT NULL,
    [IdCliente]        NUMERIC (18)    NOT NULL,
    [IdListadoDiseno]  NUMERIC (18)    NULL,
    [TotalLongitud]    DECIMAL (18, 2) NULL,
    [LongitudUnitaria] DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_prd_Orden_Taller] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdOrdenTaller] ASC)
);

