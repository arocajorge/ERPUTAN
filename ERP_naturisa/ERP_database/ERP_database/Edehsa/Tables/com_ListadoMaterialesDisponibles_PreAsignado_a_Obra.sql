CREATE TABLE [Edehsa].[com_ListadoMaterialesDisponibles_PreAsignado_a_Obra] (
    [IdEmpresa]              INT           NOT NULL,
    [IdSucursal]             INT           NOT NULL,
    [IdBodega]               INT           NOT NULL,
    [IdMovi_inven_tipo]      INT           NOT NULL,
    [IdListadoMPPreasingado] NUMERIC (18)  NOT NULL,
    [IdNumMovi]              NUMERIC (18)  NOT NULL,
    [CodObra_preasignada]    VARCHAR (20)  NOT NULL,
    [FechaReg]               DATETIME      NOT NULL,
    [Estado]                 CHAR (1)      NOT NULL,
    [Usuario]                VARCHAR (20)  NOT NULL,
    [Motivo]                 VARCHAR (50)  NOT NULL,
    [lm_Observacion]         VARCHAR (500) NULL,
    CONSTRAINT [PK_com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdMovi_inven_tipo] ASC, [IdListadoMPPreasingado] ASC, [IdNumMovi] ASC, [CodObra_preasignada] ASC)
);

