CREATE TABLE [dbo].[prd_ControlProduccion_Obrero_x_in_movi_inve] (
    [cp_IdEmpresa]                 INT          NOT NULL,
    [cp_IdSucursal]                INT          NOT NULL,
    [cp_IdControlProduccionObrero] NUMERIC (18) NOT NULL,
    [mv_IdEmpresa]                 INT          NOT NULL,
    [mv_IdSucursal]                INT          NOT NULL,
    [mv_IdBodega]                  INT          NOT NULL,
    [mv_IdMovi_inven_tipo]         INT          NOT NULL,
    [mv_IdNumMovi]                 NUMERIC (18) NOT NULL,
    CONSTRAINT [PK_prd_ControlProduccion_Obrero_x_in_movi_inve] PRIMARY KEY CLUSTERED ([cp_IdEmpresa] ASC, [cp_IdSucursal] ASC, [cp_IdControlProduccionObrero] ASC, [mv_IdEmpresa] ASC, [mv_IdSucursal] ASC, [mv_IdBodega] ASC, [mv_IdMovi_inven_tipo] ASC, [mv_IdNumMovi] ASC)
);

