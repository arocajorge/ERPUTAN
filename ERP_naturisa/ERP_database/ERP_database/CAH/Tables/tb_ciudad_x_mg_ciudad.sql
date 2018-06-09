CREATE TABLE [CAH].[tb_ciudad_x_mg_ciudad] (
    [IdCiudad_Erp]          VARCHAR (25)  NOT NULL,
    [IdCiudad_Academico]    INT           NOT NULL,
    [IdPais_Academico]      INT           NOT NULL,
    [IdProvincia_Academico] INT           NOT NULL,
    [nota1]                 VARCHAR (850) NULL,
    [nota2]                 VARCHAR (850) NULL,
    [fecha_insert]          DATETIME      NULL,
    [fecha_update]          DATETIME      NULL,
    CONSTRAINT [PK_tb_ciudad_x_mg_ciudad] PRIMARY KEY CLUSTERED ([IdCiudad_Erp] ASC, [IdCiudad_Academico] ASC),
    CONSTRAINT [FK_tb_ciudad_x_mg_ciudad_tb_ciudad] FOREIGN KEY ([IdCiudad_Erp]) REFERENCES [dbo].[tb_ciudad] ([IdCiudad])
);

