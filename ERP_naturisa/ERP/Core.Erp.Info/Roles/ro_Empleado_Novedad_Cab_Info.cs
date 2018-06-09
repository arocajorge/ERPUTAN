using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Core.Erp.Info.General;
//05/07/2013
namespace Core.Erp.Info.Roles
{
   public class ro_Empleado_Novedad_Cab_Info
    {
        public ro_Empleado_Novedad_Det_Info InfoNovedadDet { get; set; }

        public List<ro_Empleado_Novedad_Det_Info> LstDetalle { get; set; }


        public List<ro_Novedad_x_Empleado_Info> lstNovedadEmpleado { get; set; }
        public tb_persona_Info InfoPersona { get; set; }
      
       
        public int IdEmpresa { get; set; }
        public decimal IdNovedad { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public DateTime Fecha { get; set; }
        public double TotalValor { get; set; }
        public DateTime Fecha_PrimerPago { get; set; }
        public int NumCoutas { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public string Estado { get; set; }
        public string EstadoCobro { get; set; }
        public decimal IdPersona { get; set; }
        public string descripcion_tiponomina { get; set; }
        public string DescripcionProcesoNomina { get; set; }
        public string IdRubro { get; set; }
        public string RubroDescp { get; set; }
        public string NomPerComp { get; set; }
        public string IdTipoLiqui_Rol { get; set; }
        public string descripcion { get; set; }
        public string MotivoModifica { get; set; }
        public decimal Secuencia { get; set; }
        public string IdCalendario { get; set; }
        public double? Num_Horas  { get; set; }

         public Bitmap Ico1 { get; set; }
         public Bitmap Ico2 { get; set; }

       public ro_Empleado_Novedad_Cab_Info()
         {
             InfoPersona = new tb_persona_Info();
           InfoNovedadDet = new ro_Empleado_Novedad_Det_Info();
           LstDetalle = new List<ro_Empleado_Novedad_Det_Info>();
           lstNovedadEmpleado = new List<ro_Novedad_x_Empleado_Info>();
       }
    }
}
