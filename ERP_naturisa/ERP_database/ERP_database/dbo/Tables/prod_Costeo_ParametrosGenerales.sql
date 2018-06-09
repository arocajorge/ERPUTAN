CREATE TABLE [dbo].[prod_Costeo_ParametrosGenerales] (
    [IdEmpresa]                         INT NOT NULL,
    [pa_IdMovi_inven_tipo_SaldoInicial] INT NOT NULL,
    CONSTRAINT [PK_prod_Costeo_ParametrosGenerales] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC)
);

