CREATE TABLE [dbo].[ro_TablaSectorial] (
    [IdCodSectorial]        INT           NOT NULL,
    [CodigoIESS]            VARCHAR (100) NOT NULL,
    [Actividad]             VARCHAR (100) NOT NULL,
    [EstructuraOcupacional] VARCHAR (20)  NULL,
    [Estado]                CHAR (1)      NOT NULL,
    [Fecha_Transac]         DATETIME      NULL,
    [Fecha_UltMod]          DATETIME      NULL,
    [IdUsuarioUltMod]       VARCHAR (25)  NULL,
    [FechaHoraAnul]         DATETIME      NULL,
    [IdUsuarioUltAnu]       VARCHAR (25)  NULL,
    [MotivoAnulacion]       VARCHAR (100) NULL,
    CONSTRAINT [PK_ro_CodSectorial] PRIMARY KEY CLUSTERED ([IdCodSectorial] ASC)
);

