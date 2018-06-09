CREATE TABLE [Edehsa].[com_ListadoDiseno_Det] (
    [IdEmpresa]       INT          NOT NULL,
    [IdListadoDiseno] NUMERIC (18) NOT NULL,
    [IdDetalle]       INT          NOT NULL,
    [CodObra]         VARCHAR (20) NOT NULL,
    [IdOrdenTaller]   NUMERIC (18) NULL,
    [IdProducto]      NUMERIC (18) NOT NULL,
    [Unidades]        FLOAT (53)   NOT NULL,
    [Det_Kg]          FLOAT (53)   NOT NULL,
    [IdEstadoAprob]   VARCHAR (25) NOT NULL,
    CONSTRAINT [PK_com_ListadoMateriales_Det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdListadoDiseno] ASC, [IdDetalle] ASC)
);

