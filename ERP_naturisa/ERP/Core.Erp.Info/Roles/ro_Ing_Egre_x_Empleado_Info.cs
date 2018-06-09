using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Info.Roles
{
  public  class ro_Ing_Egre_x_Empleado_Info
    {

     // public ro_Empleado_Novedad_Cab_Info InfoNovedad { get; set; }

        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public string IdRubro { get; set; }
        public string IngEgr { get; set; }
        public double Valor { get; set; }
        public int iAnio { get; set; }
        public int iMes { get; set; }
        public string cerrado { get; set; }

        //haac 14/01/2014
       public decimal IdNovedad { get; set; }
       public int SecuenciaNovedad { get; set; }
       public decimal IdPrestamo { get; set; }
       public decimal NunCouta { get; set; }


        //Campo extra de la vista
        public string ru_descripcion { get; set; }
       // public DateTime Fecha { get; set; }
       //// public Nullable<Double> TotalPrestamo { get; set; }
       // public Double TotalValor{ get; set; }
       // public decimal IdNovedad { get; set; }
        //Campo extra de la vista

      //campos vista vwRo_Pago_Banco_Empleado
        public double neto_pagar { get; set; }
        public string pe_cedulaRuc{ get; set; }
        public string pe_nombreCompleto { get; set; }
        public int IdDivision { get; set; }
        public string Descripcion { get; set; } // descripcion de la division
        public string rub_codigo { get; set; }

      //reporte 
        public string em_sueldoBasicoMen { get; set; }

        //campos vista vwRo_Pago_Banco_Empleado


        public Bitmap Ico1 { get; set; }

        public Bitmap Ico2 { get; set; }

        public string observacionesSys { get; set; }
        public string TipoRegistro { get; set; }
        public string Unid_Medida { get; set; }


        
        public ro_Ing_Egre_x_Empleado_Info() 
        
        {
            //InfoNovedad = new ro_Empleado_Novedad_Cab_Info();
        
        }

    }
}
