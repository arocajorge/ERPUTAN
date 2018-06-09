CREATE TABLE [dbo].[prd_ControlInventarioProd] (
    [IdEmpresa]      INT          NOT NULL,
    [IdSucursal]     INT          NOT NULL,
    [CodObra]        VARCHAR (20) NOT NULL,
    [IdRegistro]     INT          NOT NULL,
    [IdEtapa]        INT          NOT NULL,
    [IdOrdenTrabajo] INT          NOT NULL,
    [FechaRegistro]  DATETIME     NOT NULL,
    [TipoMov]        CHAR (1)     NOT NULL,
    [Kilos]          FLOAT (53)   NOT NULL,
    [Unidades]       FLOAT (53)   NOT NULL,
    [Observacion]    VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_prd_ControlInventarioProd] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [CodObra] ASC, [IdRegistro] ASC, [IdEtapa] ASC)
);

