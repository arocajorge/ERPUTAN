CREATE TABLE [dbo].[prd_Conversion_det_CusCidersus] (
    [IdEmpresa]    INT            NOT NULL,
    [IdConversion] DECIMAL (18)   NOT NULL,
    [Secuencial]   INT            NOT NULL,
    [IdSucursal]   INT            NOT NULL,
    [IdBodega]     INT            NOT NULL,
    [IdProducto]   NUMERIC (18)   NULL,
    [CodBarra]     NVARCHAR (50)  NULL,
    [TipoPro]      NCHAR (10)     NULL,
    [Observacion]  VARCHAR (1000) NULL,
    CONSTRAINT [PK_prd_Conversion_det_CusCidersus_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdConversion] ASC, [Secuencial] ASC)
);

