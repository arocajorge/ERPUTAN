CREATE TABLE [mobileSCI].[tbl_usuario_x_subcentro] (
    [IdUsuarioSCI]                   VARCHAR (50) NOT NULL,
    [IdSCI]                          NUMERIC (18) NOT NULL,
    [IdEmpresa]                      INT          NOT NULL,
    [IdCentroCosto]                  VARCHAR (20) NOT NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_tbl_usuario_x_subcentro] PRIMARY KEY CLUSTERED ([IdUsuarioSCI] ASC, [IdSCI] ASC),
    CONSTRAINT [FK_tbl_usuario_x_subcentro_ct_centro_costo_sub_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto], [IdCentroCosto_sub_centro_costo]) REFERENCES [dbo].[ct_centro_costo_sub_centro_costo] ([IdEmpresa], [IdCentroCosto], [IdCentroCosto_sub_centro_costo]),
    CONSTRAINT [FK_tbl_usuario_x_subcentro_tbl_usuario] FOREIGN KEY ([IdUsuarioSCI]) REFERENCES [mobileSCI].[tbl_usuario] ([IdUsuarioSCI])
);

