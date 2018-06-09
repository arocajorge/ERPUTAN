CREATE TABLE [mobileSCI].[tbl_subcentro] (
    [IdEmpresaSCI]                   INT          NOT NULL,
    [IdSCI]                          NUMERIC (18) NOT NULL,
    [IdEmpresa]                      INT          NOT NULL,
    [IdCentroCosto]                  VARCHAR (20) NOT NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_tbl_subcentro] PRIMARY KEY CLUSTERED ([IdEmpresaSCI] ASC, [IdSCI] ASC),
    CONSTRAINT [FK_tbl_subcentro_ct_centro_costo_sub_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto], [IdCentroCosto_sub_centro_costo]) REFERENCES [dbo].[ct_centro_costo_sub_centro_costo] ([IdEmpresa], [IdCentroCosto], [IdCentroCosto_sub_centro_costo])
);

