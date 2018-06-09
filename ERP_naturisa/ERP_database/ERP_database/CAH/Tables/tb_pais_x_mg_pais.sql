CREATE TABLE [CAH].[tb_pais_x_mg_pais] (
    [IdPais_Erp]       VARCHAR (10)  NOT NULL,
    [IdPais_Academico] INT           NOT NULL,
    [nota1]            VARCHAR (850) NULL,
    [nota2]            VARCHAR (850) NULL,
    [fecha_insert]     DATETIME      NULL,
    [fecha_update]     NCHAR (10)    NULL,
    CONSTRAINT [PK_tb_pais_x_mg_pais] PRIMARY KEY CLUSTERED ([IdPais_Erp] ASC, [IdPais_Academico] ASC),
    CONSTRAINT [FK_tb_pais_x_mg_pais_tb_pais] FOREIGN KEY ([IdPais_Erp]) REFERENCES [dbo].[tb_pais] ([IdPais])
);

