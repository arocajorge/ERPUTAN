CREATE TABLE [CAH].[tb_provincia_x_mg_provincia] (
    [IdProvincia_Erp]       VARCHAR (25)  NOT NULL,
    [IdProvincia_Academico] INT           NOT NULL,
    [nota1]                 VARCHAR (850) NULL,
    [nota2]                 VARCHAR (850) NULL,
    [fecha_insert]          DATETIME      NULL,
    [fecha_update]          DATETIME      NULL,
    CONSTRAINT [PK_tb_provincia_x_mg_provincia] PRIMARY KEY CLUSTERED ([IdProvincia_Erp] ASC, [IdProvincia_Academico] ASC)
);

