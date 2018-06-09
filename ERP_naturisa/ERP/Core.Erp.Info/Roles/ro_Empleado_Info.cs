
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles_Fj;
namespace Core.Erp.Info.Roles
{
    public class ro_Empleado_Info: tb_persona_Info
    {
        //PERSONA
        public tb_persona_Info InfoPersona { get; set; }

        public ro_HistoricoSueldo_Info InfoSueldo { get; set; }
        //CABECERA-DETALLE
        public List<ro_DocumentoxEmp_Info> oListRo_DocumentoxEmp_Info = new List<ro_DocumentoxEmp_Info>();
        public List<ro_CargaFamiliar_Info> oListRo_CargaFamiliar_Info = new List<ro_CargaFamiliar_Info>();
        public List<ro_empleado_x_titulos_Info> oListRo_empleado_x_titulos_Info = new List<ro_empleado_x_titulos_Info>();
        public List<ro_Empleado_estudios_Info> oListRo_Empleado_estudios_Info = new List<ro_Empleado_estudios_Info>();
        public List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> oListRo_empleado_x_Proyeccion_Gastos_Personales_Info = new List<ro_empleado_x_Proyeccion_Gastos_Personales_Info>();
        public List<ro_empleado_x_rubro_acumulado_Info> oListRo_empleado_x_rubro_acumulado_Info = new List<ro_empleado_x_rubro_acumulado_Info>();
        public List<ro_empleado_x_centro_costo_Info> oListro_empleado_x_centro_costo_Info = new List<ro_empleado_x_centro_costo_Info>();
        public List<ro_empleado_x_ro_rubro_Info> oListRo_empleado_x_ro_rubro_Info = new List<ro_empleado_x_ro_rubro_Info>();
        public List<ro_Empleado_TipoNomina_Info> oListRo_Empleado_TipoNomina_Info = new List<ro_Empleado_TipoNomina_Info>();
        public List<ro_Empleado_X_Horario_Info> oListRo_Empleado_X_Horario_Info = new List<ro_Empleado_X_Horario_Info>();
        public List<ro_Nomina_X_Horas_Extras_Info> oListRo_Nomina_X_Horas_Extras_Info = new List<ro_Nomina_X_Horas_Extras_Info>();
        public List<ro_Capacitaciones_x_Empleado_Info> ListCapacitaciones = new List<ro_Capacitaciones_x_Empleado_Info>();
        public ro_Grupo_empleado_Info grupo { get; set; }
        public ro_marcaciones_x_empleado_Info Info_marcaciones_x_empleado { get; set; }
        public ro_turno_Info Info_turno { get; set; }
        //EMPLEADO
        public int Secuancia { get; set; }
        public int	IdEmpresa	 { get; set; }
        public decimal	IdEmpleado { get; set; }
        public decimal? IdEmpleado_Supervisor { get; set; }
        public decimal IdPersona { get; set; }
        public int	IdSucursal	 { get; set; }
        public string IdTipoEmpleado { get; set; }
        public string	em_codigo	 { get; set; }
        public string em_lugarNacimiento { get; set; }
        public string em_CarnetIees { get; set; }
        public string em_cedulaMil { get; set; }
        public DateTime? em_fecha_ingreso { get; set; }
        public DateTime? em_fechaSalida { get; set; }
        public DateTime? em_fechaTerminoContra { get; set; }
        public DateTime? em_fechaIngaRol { get; set; }
        public DateTime? em_fecha_inicio_contrato_Actual { get; set; }
        public string em_SeAcreditaBanco { get; set; }
        public string em_tipoCta { get; set; }
        public string em_NumCta { get; set; }
        public string em_SepagaBeneficios { get; set; }
        public string em_SePagaConTablaSec { get; set; }
        public string em_estado { get; set; }
        public double em_sueldoBasicoMen { get; set; }
        public byte[] em_foto { get; set; }
        public string em_empEspecial { get; set; }
        public string em_pagoFdoRsv { get; set; }
        public string em_huella { get; set; }
        public int ?IdCodSectorial { get; set; }
        public int ?IdDepartamento { get; set; }
        public string IdTipoSangre { get; set; }
        public int ?IdCargo { get; set; }
        public string IdCtaCble_Emplea { get; set; }
        public string IdUbicacion { get; set; }
        public string IdPais { get; set; }
        public string IdProvincia { get; set; }
        public string em_mail { get; set; }
        public string IdTipoLicencia { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdBanco { get; set; }
        public int IdNomina_Tipo { get; set; }
        public byte[] Archivo { get; set; }
        public string NombreArchivo { get; set; }
        public string Codigo_Biometrico { get; set; }
        public string CodCatalogo { get; set; }
        public string em_motivo_salisa { get; set; }
         public int IdNominaTipoLiqui { get; set; }
         public int IdPeriodo { get; set; }
         public Nullable<int> IdGrupo { get; set; }
         public Nullable<bool> Marca_Biometrico { get; set; }

                          

        //CAMPOS TEMPORALES
        public double em_Sueldo { get; set; }
        public double ? em_AnticipoSueldo { get; set; }
        public string IdTipoAnticipo { get; set; }
        public Boolean? es_TruncarDecimalAnticipo { get; set; }
        public Nullable<double> Transporte { get; set; }
        public Nullable<double> Alimentacion { get; set; }
        public Nullable<int> Dias_Efectivos { get; set; }
        public string idTipoContrato { get; set; }
        public string NoDocumentoContrato { get; set; }
        public DateTime fechaInicioContrato { get; set; }
        public DateTime fechaFinContrato { get; set; }


        //Campos extras de la vista
        public string Sucursal_Descripcion { get; set; }
        public string cargo_Descripcion { get; set; }
        public string nacionalidad_Descripcion { get; set; }
        public string de_descripcion { get; set; }
        public string NomCompleto { get; set; }
        public Nullable<double> Valor_bono { get; set; }
        public Nullable<double> porc_recup_cartera { get; set; }
        public Nullable<double> porc_efect_entrega { get; set; }
        public Nullable<double> porc_efect_volumen { get; set; }

        //Campos extras vista vwro_empleadoXdepXcargo

        public string cargo { get; set; }
        public string departamento { get; set; }
        public string Sucursal { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_NomCompleto { get; set; }
        public DateTime em_fecha_Actual { get; set; }

        //campos extras vacaciones
        public double diasTrabajo { get; set; }
        public int diasVacacion { get; set; }
        public int diasTomados { get; set; }
        public int diasPendientes { get; set; }
       
        public double SueldoActual { get; set; }
        public Nullable<int> IdArea { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string Error { get; set; }
        public int  Id_Periodo { get; set; }
        public string ExcInc { get; set; }
        public double Valor_Decimo_XIII { get; set; }
        public bool check { get; set; }


        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transaccion { get; set; }

        public string IdUsuarioUltModi { get; set; }
        public DateTime ? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime ? Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string EstadoEmpleado { get; set; }

        
        public double por_discapacidad { get; set; }
        public string carnet_conadis { get; set; }
	    public string recibi_uniforme { get; set; }
        public double talla_pant { get; set; }
        public string talla_camisa { get; set; }
        public double talla_zapato { get; set; }
        public string em_status { get; set; }
        public Boolean? es_AcreditaHorasExtras { get; set; }
        public Double? DiasAntiguedad { get; set; }
        public bool es_HorasExtrasAutorizadas { get; set; }
        //DATOS PARA EL SRI
        public string IdCondicionDiscapacidadSRI { get; set; }
        public string IdTipoIdentDiscapacitadoSustitutoSRI { get; set; }
        public string IdentDiscapacitadoSustitutoSRI { get; set; }
        public string IdAplicaConvenioDobleImposicionSRI { get; set; }
        public string IdTipoResidenciaSRI { get; set; }
        public string IdTipoSistemaSalarioNetoSRI { get; set; }
   

        public bool checkSaldoNegativo { get; set; }

        //VISTA DE SUELDO DIGNO
        public double totSueldo { get; set; }
        public double totDecimoCuarto { get; set; }
        public double totDecimoTercer { get; set; }
        public double totFondoReserva { get; set; }
        public double totUtilidad { get; set; }
        public double sueldoDigno { get; set; }
        public double totIngreso { get; set; }
        public double totSueldoDigno { get; set; }
        public double totIESS { get; set; }
        public double compensacion { get; set; }

        public double proporcionalUtilidad { get; set; }
        public double valorEntregar { get; set; }

        //VISTA CALCULO DE UTILIDADES
        public double alicuotaIndividual { get; set; }
        public double subTotalIndividual { get; set; }
        public double cargas { get; set; }
        public double diasTrabAnual { get; set; }
        public double factorA { get; set; }
        public double alicuotaCarga { get; set; }
        public double subTotalCarga { get; set; }
        public double exedenteIESS { get; set; }

        //VISTA RDEP
        public double totComision { get; set; }
        public double totHoraExtra { get; set; }


        //VISTA GASTOS PERSONALES
        public double totGastoVivienda { get; set; }
        public double totGastoVestimenta { get; set; }
        public double totGastoSalud { get; set; }
        public double totGastoEducacion { get; set; }
        public double totGastoAlimentacion { get; set; }


        //IESS
        public string CodigoSectorialIESS { get; set; }


        public int IdSala { get; set; }
        public int Iddisco { get; set; }
        public int IdRuta { get; set; }



        //TMP WIZARD - IMPORTACION DE EMPLEADOS
        public string acumulaDecimoTercer { get; set; }
        public string acumulaDecimoCuarto { get; set; }
        public string acumulaFondoReserva { get; set; }
        public bool si_tiene_rubros_fijo { get; set; }
        // NOVEDADES EN BACT
        public string Nomina { get; set; }
        public Nullable<int> Dias_SyD { get; set; }


        public List<ro_Nomina_X_Horas_Extras_Info> ChildList 
        {
            get { return oListRo_Nomina_X_Horas_Extras_Info; }
            set { oListRo_Nomina_X_Horas_Extras_Info = value; }
        }
        public string Observacion { get; set; }

     

        public ro_Empleado_Info()
        {
            InfoPersona = new tb_persona_Info();
            InfoSueldo = new ro_HistoricoSueldo_Info();
            grupo = new ro_Grupo_empleado_Info();
            Info_marcaciones_x_empleado = new ro_marcaciones_x_empleado_Info();
        }


      

    }
}
