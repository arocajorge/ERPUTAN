CREATE TABLE [dbo].[Aca_Contrato_x_Estudiante_det_Beca] (
    [IdInstitucion]     INT          NOT NULL,
    [IdContrato]        NUMERIC (18) NOT NULL,
    [IdRubro]           NUMERIC (18) NOT NULL,
    [IdInstitucion_Per] INT          NOT NULL,
    [IdAnioLectivo_Per] INT          NOT NULL,
    [IdPeriodo_Per]     INT          NOT NULL,
    [IdBeca]            INT          NOT NULL,
    [valor_beca]        FLOAT (53)   NOT NULL,
    [porc_beca]         FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_Aca_Contrato_x_Estudiante_det_Beca] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdContrato] ASC, [IdRubro] ASC, [IdInstitucion_Per] ASC, [IdAnioLectivo_Per] ASC, [IdPeriodo_Per] ASC, [IdBeca] ASC)
);

