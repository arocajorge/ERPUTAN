using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_registro_unidades_x_equipo_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdRegistro { get; set; }
        public int IdFecha { get; set; }
        public string IdUnidad_Medida { get; set; }
        public string IdTipo_Reg_cat { get; set; }
        public int IdActivoFijo { get; set; }
        public double Valor { get; set; }
        public Nullable<System.DateTime> fecha_reg { get; set; }
        public Nullable<System.DateTime> fecha_modi { get; set; }
        public int IdPeriodo { get; set; }
        public string CodActivoFijo { get; set; }


        // vista 
        public Nullable<double> Num_horas_registradas { get; set; }
        public Nullable<double> Num_horas_facturadas { get; set; }
        public string Af_Nombre { get; set; }
        public System.DateTime pe_FechaIni { get; set; }
        public System.DateTime pe_FechaFin { get; set; }
        public Nullable<double> Horas_no_Facturadas { get; set; }

        public Nullable<double> Af_ValorUnidad_Actu { get; set; }
        public Nullable<double> Horas_Trabajada_x_Af { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<double> hora_trabajada { get; set; }

    }
}
