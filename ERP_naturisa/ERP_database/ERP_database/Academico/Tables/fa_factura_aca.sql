CREATE TABLE [Academico].[fa_factura_aca] (
    [IdEmpresa]        INT          NOT NULL,
    [IdSucursal]       INT          NOT NULL,
    [IdBodega]         INT          NOT NULL,
    [IdCbteVta]        NUMERIC (18) NOT NULL,
    [IdInstitucion]    INT          NOT NULL,
    [IdEstudiante]     NUMERIC (18) NOT NULL,
    [IdFamiliar]       NUMERIC (18) NOT NULL,
    [IdParentesco_cat] VARCHAR (35) NOT NULL,
    [IdAnioLectivo]    INT          NOT NULL,
    [IdPeriodo]        INT          NOT NULL,
    [IdRubro]          INT          NULL,
    CONSTRAINT [PK_fa_factura_aca] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdCbteVta] ASC),
    CONSTRAINT [FK_fa_factura_aca_Aca_estudiante] FOREIGN KEY ([IdInstitucion], [IdEstudiante]) REFERENCES [dbo].[Aca_estudiante] ([IdInstitucion], [IdEstudiante]),
    CONSTRAINT [FK_fa_factura_aca_Aca_Familiar_x_Estudiante1] FOREIGN KEY ([IdInstitucion], [IdEstudiante], [IdFamiliar], [IdParentesco_cat]) REFERENCES [dbo].[Aca_Familiar_x_Estudiante] ([IdInstitucion], [IdEstudiante], [IdFamiliar], [IdParentesco_cat]),
    CONSTRAINT [FK_fa_factura_aca_Aca_Rubro] FOREIGN KEY ([IdInstitucion], [IdRubro]) REFERENCES [dbo].[Aca_Rubro] ([IdInstitucion], [IdRubro]),
    CONSTRAINT [FK_fa_factura_aca_fa_factura] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdBodega], [IdCbteVta]) REFERENCES [dbo].[fa_factura] ([IdEmpresa], [IdSucursal], [IdBodega], [IdCbteVta])
);

