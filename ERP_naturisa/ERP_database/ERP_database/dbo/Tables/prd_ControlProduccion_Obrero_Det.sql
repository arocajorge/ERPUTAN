CREATE TABLE [dbo].[prd_ControlProduccion_Obrero_Det] (
    [IdEmpresa]                 INT           NOT NULL,
    [IdSucursal]                INT           NOT NULL,
    [IdControlProduccionObrero] NUMERIC (18)  NOT NULL,
    [Secuencia]                 INT           NOT NULL,
    [HoraInicio]                TIME (0)      NOT NULL,
    [Cantidad]                  FLOAT (53)    NOT NULL,
    [IdProducto]                NUMERIC (18)  NOT NULL,
    [CodBarra]                  VARCHAR (100) NOT NULL,
    [CodBarraMaestro]           VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_prd_ControlProduccion_Obrero_Det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdControlProduccionObrero] ASC, [Secuencia] ASC)
);

