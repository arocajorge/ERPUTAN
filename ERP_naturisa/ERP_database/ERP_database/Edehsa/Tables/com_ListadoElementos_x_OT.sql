CREATE TABLE [Edehsa].[com_ListadoElementos_x_OT] (
    [IdEmpresa]               INT           NOT NULL,
    [IdListadoElementos_x_OT] NUMERIC (18)  NOT NULL,
    [CodObra]                 VARCHAR (20)  NOT NULL,
    [ot_IdSucursal]           INT           NOT NULL,
    [IdOrdenTaller]           NUMERIC (18)  NOT NULL,
    [FechaReg]                DATETIME      NOT NULL,
    [Estado]                  CHAR (1)      NOT NULL,
    [Usuario]                 VARCHAR (20)  NOT NULL,
    [Motivo]                  VARCHAR (50)  NOT NULL,
    [lm_Observacion]          VARCHAR (500) NULL,
    CONSTRAINT [PK_com_ListadoElementos_x_OT] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdListadoElementos_x_OT] ASC)
);

