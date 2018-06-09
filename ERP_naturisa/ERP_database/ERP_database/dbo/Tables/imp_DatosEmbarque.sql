CREATE TABLE [dbo].[imp_DatosEmbarque] (
    [IdEmpresa]        INT          NOT NULL,
    [IdSucursal]       INT          NOT NULL,
    [IdOrdenCompraExt] NUMERIC (18) NOT NULL,
    [cp_secuencia]     INT          NOT NULL,
    [cp_TipoEmbarque]  NVARCHAR (5) NULL,
    [cp_TipoConten]    NVARCHAR (5) NULL,
    [cp_cantidad]      FLOAT (53)   NULL,
    [cp_Kiligramo]     FLOAT (53)   NULL,
    [cp_MCubicos]      FLOAT (53)   NULL,
    [cp_ValorFlete]    FLOAT (53)   NULL,
    CONSTRAINT [PK_imp_DatosEmbarque] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdOrdenCompraExt] ASC, [cp_secuencia] ASC)
);

