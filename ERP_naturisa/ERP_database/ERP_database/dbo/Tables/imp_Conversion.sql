CREATE TABLE [dbo].[imp_Conversion] (
    [cv_Moneda_Act] INT   NOT NULL,
    [cv_Moneda_Fra] INT   NOT NULL,
    [cv_valor_Fra]  MONEY NOT NULL,
    CONSTRAINT [PK_imp_Conversion] PRIMARY KEY CLUSTERED ([cv_Moneda_Act] ASC, [cv_Moneda_Fra] ASC),
    CONSTRAINT [FK_imp_Conversion_tb_moneda] FOREIGN KEY ([cv_Moneda_Act]) REFERENCES [dbo].[tb_moneda] ([IdMoneda]),
    CONSTRAINT [FK_imp_Conversion_tb_moneda1] FOREIGN KEY ([cv_Moneda_Fra]) REFERENCES [dbo].[tb_moneda] ([IdMoneda])
);

