CREATE TABLE [Fj_servindustrias].[ro_Parametro_calculo_Horas_Extras] (
    [IdEmpresa]                                      INT          NOT NULL,
    [Se_calcula_horas_Extras_al100]                  BIT          NOT NULL,
    [Se_calcula_horas_Extras_al50]                   BIT          NOT NULL,
    [Se_calcula_horas_Extras_al25]                   BIT          NOT NULL,
    [Corte_Horas_extras]                             INT          NOT NULL,
    [Se_Crea_reverso_h_extras_si_Emp_tiene_remplazo] BIT          NOT NULL,
    [IdRubro_rev_Horas]                              VARCHAR (50) NULL,
    [IdRubro_Rebaja_Desahucio]                       VARCHAR (50) NULL,
    [MinutosLunch]                                   INT          NULL,
    CONSTRAINT [PK_ro_Parametro_calculo_Horas_Extras] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC)
);

