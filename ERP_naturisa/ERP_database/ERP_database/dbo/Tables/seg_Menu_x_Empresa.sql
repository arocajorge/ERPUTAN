CREATE TABLE [dbo].[seg_Menu_x_Empresa] (
    [IdEmpresa]           INT           NOT NULL,
    [IdMenu]              INT           NOT NULL,
    [Habilitado]          BIT           NOT NULL,
    [NombreAsambly_x_Emp] VARCHAR (200) NOT NULL,
    [NomFormulario_x_Emp] VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_seg_Menu_x_Empresa] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdMenu] ASC),
    CONSTRAINT [FK_seg_Menu_x_Empresa_seg_Menu] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[seg_Menu] ([IdMenu]),
    CONSTRAINT [FK_seg_Menu_x_Empresa_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);

