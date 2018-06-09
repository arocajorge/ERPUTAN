CREATE TABLE [dbo].[prd_GrupoTrabajo_Det] (
    [IdEmpresa]      INT           NOT NULL,
    [IdSucursal]     INT           NOT NULL,
    [IdGrupotrabajo] NUMERIC (18)  NOT NULL,
    [Secuencia]      INT           NOT NULL,
    [IdEmpleado]     NUMERIC (18)  NOT NULL,
    [Observacion]    VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_prd_GrupoTrabajo_Det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdGrupotrabajo] ASC, [Secuencia] ASC)
);

