using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Info.Roles
{
   public class vwRo_Ing_Egr_x_Empleado_Info
    {
        public string IdRubro { get; set; }
        public string ru_descripcion { get; set; }
        public string ru_tipo { get; set; }
        public string Expr1 { get; set; }
        public int IdPeriodo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public int IdNomina_Tipo { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdNovedad { get; set; }
        public int SecuenciaNovedad { get; set; }
        public decimal IdPrestamo { get; set; }
        public decimal NunCouta { get; set; }
        public string IngEgr { get; set; }
        public double Valor { get; set; }
        public int iAnio { get; set; }
        public int iMes { get; set; }
        public string cerrado { get; set; }
        public string TipoRegistro { get; set; }
        public string observacionesSys { get; set; }
        public string Unidad_Medida { get; set; }

        public Bitmap Ico1 { get; set; }
        public Bitmap Ico2 { get; set; }


        public bool check { get; set; }

       //campos extras vista vwRo_Total_IngEgr_x_Empleado
        public double totIng { get; set; }
        public double totEgr { get; set; }
        public double totNeto { get; set; }
        public string NomCompleto { get; set; }

        public string cargo { get; set; }
        public string departamento { get; set; }
        public string em_codigo { get; set; }
        public string pe_cedulaRuc{ get; set; }



        public vwRo_Ing_Egr_x_Empleado_Info() { }

    }
}
