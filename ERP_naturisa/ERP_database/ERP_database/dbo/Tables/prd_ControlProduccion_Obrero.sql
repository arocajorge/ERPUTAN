CREATE TABLE [dbo].[prd_ControlProduccion_Obrero] (
    [IdEmpresa]                 INT            NOT NULL,
    [IdSucursal]                INT            NOT NULL,
    [IdControlProduccionObrero] NUMERIC (18)   NOT NULL,
    [IdBodega]                  INT            NULL,
    [NumCPO]                    INT            NOT NULL,
    [CodObra]                   VARCHAR (20)   NOT NULL,
    [IdOrdenTaller]             NUMERIC (18)   NOT NULL,
    [IdGrupoTrabajo]            NUMERIC (18)   NOT NULL,
    [IdEmpleado]                NUMERIC (18)   NOT NULL,
    [CantAsignada]              FLOAT (53)     NOT NULL,
    [FechaRegistro]             DATETIME       NOT NULL,
    [Observacion]               VARCHAR (1000) NOT NULL,
    [Estado]                    CHAR (1)       NOT NULL,
    CONSTRAINT [PK_prd_ControlProduccion_Obrero] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdControlProduccionObrero] ASC)
);

