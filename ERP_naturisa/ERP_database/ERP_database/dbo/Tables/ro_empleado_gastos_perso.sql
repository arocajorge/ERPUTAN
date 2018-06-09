CREATE TABLE [dbo].[ro_empleado_gastos_perso] (
    [IdEmpresa]          INT           NOT NULL,
    [IdEmpleado]         NUMERIC (18)  NOT NULL,
    [Anio_fiscal]        INT           NOT NULL,
    [fecha]              DATETIME      NOT NULL,
    [observacion]        VARCHAR (150) NOT NULL,
    [Estado]             CHAR (1)      NOT NULL,
    [Tipo_Iden]          VARCHAR (5)   NOT NULL,
    [Num_Identificacion] VARCHAR (20)  NOT NULL,
    [Apellidos_Nombres]  VARCHAR (150) NOT NULL,
    [telefono]           VARCHAR (50)  NOT NULL,
    [calle_prin]         VARCHAR (250) NOT NULL,
    [Numero]             VARCHAR (50)  NOT NULL,
    [Intersecion]        VARCHAR (50)  NOT NULL,
    [IdProvincia]        VARCHAR (20)  NOT NULL,
    [IdCidudad]          VARCHAR (20)  NOT NULL,
    CONSTRAINT [PK_ro_empleado_gastos_personales] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC, [Anio_fiscal] ASC)
);

