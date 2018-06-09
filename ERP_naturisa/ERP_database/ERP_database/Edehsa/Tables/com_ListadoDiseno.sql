CREATE TABLE [Edehsa].[com_ListadoDiseno] (
    [IdEmpresa]       INT           NOT NULL,
    [IdListadoDiseno] NUMERIC (18)  NOT NULL,
    [CodObra]         VARCHAR (20)  NOT NULL,
    [ot_IdSucursal]   INT           NOT NULL,
    [IdOrdenTaller]   NUMERIC (18)  NULL,
    [FechaReg]        DATETIME      NOT NULL,
    [Estado]          CHAR (1)      NOT NULL,
    [Usuario]         VARCHAR (20)  NOT NULL,
    [Motivo]          VARCHAR (50)  NOT NULL,
    [lm_Observacion]  VARCHAR (500) NULL,
    [tipo_listado]    CHAR (1)      NULL,
    CONSTRAINT [PK_com_ListadoMateriales] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdListadoDiseno] ASC)
);

