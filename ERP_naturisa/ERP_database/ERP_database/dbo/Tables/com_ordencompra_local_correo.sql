CREATE TABLE [dbo].[com_ordencompra_local_correo] (
    [IdEmpresa]     INT           NOT NULL,
    [IdSucursal]    INT           NOT NULL,
    [IdOrdenCompra] NUMERIC (18)  NOT NULL,
    [Correo]        VARCHAR (MAX) NOT NULL,
    [FechaEnvio]    DATETIME      NULL,
    [Mensaje]       VARCHAR (MAX) NULL,
    CONSTRAINT [PK_com_ordencompra_local_correo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdOrdenCompra] ASC)
);

