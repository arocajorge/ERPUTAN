CREATE TABLE [dbo].[ro_Asignacion_Implemento_x_Empleado_det] (
    [IdEmpresa]         INT           NOT NULL,
    [IdAsignacion_Impl] NUMERIC (18)  NOT NULL,
    [IdProducto]        NUMERIC (18)  NOT NULL,
    [secuencia]         INT           NOT NULL,
    [Detalle]           VARCHAR (250) NOT NULL,
    [Vida_Util]         INT           NOT NULL,
    [Cantidad]          FLOAT (53)    NOT NULL,
    [Fecha_Caducidad]   DATE          NOT NULL,
    [Estado_implemnto]  VARCHAR (25)  NOT NULL,
    CONSTRAINT [PK_ro_Asignacion_Implemento_x_Empleado_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdAsignacion_Impl] ASC, [IdProducto] ASC, [secuencia] ASC)
);

