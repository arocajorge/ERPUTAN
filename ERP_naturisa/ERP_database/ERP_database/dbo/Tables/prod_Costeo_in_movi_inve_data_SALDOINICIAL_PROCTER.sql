CREATE TABLE [dbo].[prod_Costeo_in_movi_inve_data_SALDOINICIAL_PROCTER] (
    [IdEmpresa]         INT            NOT NULL,
    [IdSucursal]        INT            NOT NULL,
    [IdBodega]          INT            NOT NULL,
    [IdMovi_inven_tipo] INT            NOT NULL,
    [IdNumMovi]         NUMERIC (18)   NOT NULL,
    [CodMoviInven]      VARCHAR (25)   NOT NULL,
    [cm_tipo]           CHAR (1)       NOT NULL,
    [cm_observacion]    VARCHAR (1000) NOT NULL,
    [cm_fecha]          DATETIME       NOT NULL,
    [Secuencia]         INT            NOT NULL,
    [IdProducto]        NUMERIC (18)   NOT NULL,
    [dm_cantidad]       FLOAT (53)     NOT NULL,
    [dm_stock_ante]     FLOAT (53)     NOT NULL,
    [dm_stock_actu]     FLOAT (53)     NOT NULL,
    [mv_costo]          FLOAT (53)     NOT NULL,
    [pr_codigo]         NVARCHAR (40)  NOT NULL,
    [pr_descripcion]    NVARCHAR (500) NOT NULL,
    [pr_costo_promedio] FLOAT (53)     NOT NULL,
    [IdAnio]            INT            NULL,
    [IdMes]             INT            NULL,
    [dm_peso]           FLOAT (53)     NULL
);

