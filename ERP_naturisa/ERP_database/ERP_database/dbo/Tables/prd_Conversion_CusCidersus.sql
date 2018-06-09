CREATE TABLE [dbo].[prd_Conversion_CusCidersus] (
    [IdEmpresa]         INT            NOT NULL,
    [IdConversion]      DECIMAL (18)   NOT NULL,
    [IdSucursal]        INT            NOT NULL,
    [IdBodega]          INT            NOT NULL,
    [Fecha]             DATE           NULL,
    [CodObra]           VARCHAR (20)   NULL,
    [IdOrdenTaller]     NUMERIC (18)   NULL,
    [IdEtapa]           INT            NULL,
    [CodBarraProducto]  NVARCHAR (100) NULL,
    [NomProducto]       NVARCHAR (200) NULL,
    [Observacion]       VARCHAR (1000) NULL,
    [IdUsuario]         VARCHAR (20)   NULL,
    [Fecha_transaccion] DATETIME       NULL,
    [IdUsuarioAnu]      VARCHAR (20)   NULL,
    [Fecha_Anu]         DATETIME       NULL,
    [Estado]            CHAR (1)       NULL,
    [IdGrupoTrabajo]    NUMERIC (18)   NULL,
    CONSTRAINT [PK_prd_Conversion_CusCidersus_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdConversion] ASC)
);

