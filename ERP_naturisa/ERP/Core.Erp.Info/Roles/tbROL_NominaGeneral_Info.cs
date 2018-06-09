using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{/*
     ///
     * Planificacion de Horarios
     * Programador : Ing Katiuska Franco T
     * Ultima Version  a unificar 0801 2014 hora 1500 
     * 
     * 
     */
    public class tbROL_NominaGeneral_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public string nom_pc { get; set; }
        public string IdUsuario { get; set; }
        public string NomEmpleado { get; set; }
        public int IdDivision { get; set; }
        public string NomDivision { get; set; }
        public int IdDepartamento { get; set; }
        public string NomDepartamento { get; set; }
        public string IdRubroIng1 { get; set; }
        public string NRubroIng1 { get; set; }
        public double ValorIng1 { get; set; }
        public string IdRubroIng2 { get; set; }
        public string NRubroIng2 { get; set; }
        public double ValorIng2 { get; set; }
        public string IdRubroIng3 { get; set; }
        public string NRubroIng3 { get; set; }
        public double ValorIng3 { get; set; }
        public string IdRubroIng4 { get; set; }
        public string NRubroIng4 { get; set; }
        public Nullable<double> ValorIng4 { get; set; }
        public string IdRubroIng5 { get; set; }
        public string NRubroIng5 { get; set; }
        public Nullable<double> ValorIng5 { get; set; }
        public string IdRubroIng6 { get; set; }
        public string NRubroIng6 { get; set; }
        public Nullable<double> ValorIng6 { get; set; }
        public string IdRubroIng7 { get; set; }
        public string NRubroIng7 { get; set; }
        public Nullable<double> ValorIng7 { get; set; }
        public string IdRubroIng8 { get; set; }
        public string NRubroIng8 { get; set; }
        public Nullable<double> ValorIng8 { get; set; }
        public string IdRubroIng9 { get; set; }
        public string NRubroIng9 { get; set; }
        public Nullable<double> ValorIng9 { get; set; }
        public string IdRubroIng10 { get; set; }
        public string NRubroIng10 { get; set; }
        public Nullable<double> ValorIng10 { get; set; }
        public Nullable<double> TotalIng { get; set; }
        public string IdRubroEgr1 { get; set; }
        public string NRubroEgr1 { get; set; }
        public double ValorEgr1 { get; set; }
        public string IdRubroEgr2 { get; set; }
        public string NRubroEgr2 { get; set; }
        public double ValorEgr2 { get; set; }
        public string IdRubroEgr3 { get; set; }
        public string NRubroEgr3 { get; set; }
        public double ValorEgr3 { get; set; }
        public string IdRubroEgr4 { get; set; }
        public string NRubroEgr4 { get; set; }
        public Nullable<double> ValorEgr4 { get; set; }
        public string IdRubroEgr5 { get; set; }
        public string NRubroEgr5 { get; set; }
        public Nullable<double> ValorEgr5 { get; set; }
        public string IdRubroEgr6 { get; set; }
        public string NRubroEgr6 { get; set; }
        public Nullable<double> ValorEgr6 { get; set; }
        public string IdRubroEgr7 { get; set; }
        public string NRubroEgr7 { get; set; }
        public Nullable<double> ValorEgr7 { get; set; }
        public string IdRubroEgr8 { get; set; }
        public string NRubroEgr8 { get; set; }
        public Nullable<double> ValorEgr8 { get; set; }
        public string IdRubroEgr9 { get; set; }
        public string NRubroEgr9 { get; set; }
        public Nullable<double> ValorEgr9 { get; set; }
        public string IdRubroEgr10 { get; set; }
        public string NRubroEgr10 { get; set; }
        public Nullable<double> ValorEgr10 { get; set; }
        public Nullable<double> TotalEgr { get; set; }
        public Nullable<double> Total { get; set; }
        public System.DateTime Fecha_Transac { get; set; }

        public tbROL_NominaGeneral_Info()
        {

        }
    }
}
