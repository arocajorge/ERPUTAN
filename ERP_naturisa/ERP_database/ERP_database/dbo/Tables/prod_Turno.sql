CREATE TABLE [dbo].[prod_Turno] (
    [IdEmpresa]   INT           NOT NULL,
    [IdTurno]     INT           NOT NULL,
    [HoraInicio]  TIME (7)      NULL,
    [HoraFin]     TIME (7)      NULL,
    [Descripcion] NVARCHAR (50) NULL,
    CONSTRAINT [PK_prod_Turno] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTurno] ASC)
);

