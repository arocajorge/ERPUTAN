

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Core.Erp.Info.Roles
{
   public class ro_Rol_Detalle_Info
    {

        public int IdEmpresa {get;set;}
        public int IdNominaTipo{get;set;}
        public int IdNominaTipoLiqui{get;set;}
        public int IdPeriodo{get;set;}
        public decimal IdEmpleado{get;set;}
        public string IdRubro{get;set;}
        public int Orden{get;set;}
        public double Valor { get; set; }
        public Nullable<bool> rub_visible_reporte { get; set; }
        public string Observacion { get; set; }
        public string TipoMovimiento { get; set; }

       //DATOS DE LA VISTA
        public string Tag { get; set; }
        public string DescRubroLargo { get; set; }
        public string DescNombreRubroCorto { get; set; }
        public string NominaLiqui { get; set; }
        public string Nomina { get; set; }
        public System.DateTime FechaIni { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string Empresa { get; set; }
        public string EstadoPeriodo { get; set; }
        public string Departamento { get; set; }
        public System.DateTime FechaIngresa { get; set; }
        public string IdCentroCosto { get; set; }
        public string EstadoRol { get; set; }
        public string Cerrado { get; set; }
        public string Procesado { get; set; }
        public string Contabilizado{ get; set; }
        public int? pe_anio { get; set; }
        public int? pe_mes { get; set; }
        public Boolean? pagacheque { get; set; }
        public string pe_apellido { get; set; }

        public string NombreCompleto { get; set; }
        public string Cargo { get; set; }
        public string CedulaRuc { get; set; }
        public string TipoCuenta { get; set; }
        public string NumCuenta { get; set; }
        public string IdBanco { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Division { get; set; }
        public int? IdDivision { get; set; }
        public Boolean? check { get; set; }
        public int? rub_grupo { get; set; }
        public string Tipo_Documento { get; set; }
        public int IdSucursal { get; set; }
        public int IdDepartamento { get; set; }
        public Nullable<int> IdArea { get; set; }
        public string StatusEmpleado { get; set; }
        public string EstadoEmpleado { get; set; }
        public Bitmap Ico1 { get; set; }
        public Bitmap Ico2 { get; set; }
        public string ru_tipo { get; set; }
        public String TipoRegistro { get; set; }
        public int IdNovedad { get; set; }
        public string Unidad_Medida { get; set; }
        public string CodigoLegal { get; set; }
        public string ba_descripcion { get; set; }
        public Nullable<double> ValorCancelado { get; set; }
        public Nullable<double> PendientePago { get; set; }
        public ro_Rol_Detalle_Info() { }        
   }
}
