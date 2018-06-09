CREATE TABLE [dbo].[ro_turno_x_tb_dia] (
    [IdEmpresa] INT          NOT NULL,
    [IdTurno]   NUMERIC (18) NOT NULL,
    [idDia]     TINYINT      NOT NULL,
    [Activo]    BIT          NOT NULL,
    CONSTRAINT [PK_ro_turno_x_tb_dia_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTurno] ASC, [idDia] ASC),
    CONSTRAINT [FK_ro_turno_x_tb_dia_ro_turno] FOREIGN KEY ([IdEmpresa], [IdTurno]) REFERENCES [dbo].[ro_turno] ([IdEmpresa], [IdTurno]),
    CONSTRAINT [FK_ro_turno_x_tb_dia_tb_dia] FOREIGN KEY ([idDia]) REFERENCES [dbo].[tb_dia] ([idDia])
);

