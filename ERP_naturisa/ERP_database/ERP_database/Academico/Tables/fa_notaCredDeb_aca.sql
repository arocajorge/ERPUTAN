CREATE TABLE [Academico].[fa_notaCredDeb_aca] (
    [IdEmpresa]     INT          NOT NULL,
    [IdSucursal]    INT          NOT NULL,
    [IdBodega]      INT          NOT NULL,
    [IdNotaCredDeb] NUMERIC (18) NOT NULL,
    [IdInstitucion] INT          NULL,
    [IdEstudiante]  NUMERIC (18) NOT NULL,
    [Observaciones] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_fa_notaCredDeb_aca] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdNotaCredDeb] ASC),
    CONSTRAINT [FK_fa_notaCredDeb_aca_Aca_estudiante] FOREIGN KEY ([IdInstitucion], [IdEstudiante]) REFERENCES [dbo].[Aca_estudiante] ([IdInstitucion], [IdEstudiante]),
    CONSTRAINT [FK_fa_notaCredDeb_aca_fa_notaCredDeb_aca] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdBodega], [IdNotaCredDeb]) REFERENCES [dbo].[fa_notaCreDeb] ([IdEmpresa], [IdSucursal], [IdBodega], [IdNota])
);

