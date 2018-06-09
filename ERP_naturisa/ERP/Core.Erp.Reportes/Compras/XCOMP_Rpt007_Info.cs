using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt007_Info
    {
        public Nullable<int> IdEmpresa { get; set; }
        public string Nom_Empresa { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string Nom_Sucursal { get; set; }
        public Nullable<System.DateTime> Fecha_Corte { get; set; }
        public Nullable<int> IdMes1_anio { get; set; }
        public Nullable<int> IdMes2_anio { get; set; }
        public Nullable<int> IdMes3_anio { get; set; }
        public Nullable<int> IdMes4_anio { get; set; }
        public string Nom_Mes1_anio { get; set; }
        public string Nom_Mes2_anio { get; set; }
        public string Nom_Mes3_anio { get; set; }
        public string Nom_Mes4_anio { get; set; }
        public Nullable<int> Cant_Mes1_anio { get; set; }
        public Nullable<int> Cant_Mes2_anio { get; set; }
        public Nullable<int> Cant_Mes3_anio { get; set; }
        public Nullable<int> Cant_Mes4_anio { get; set; }
        public Nullable<int> Prom_cant_x_comp { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string Cod_Producto { get; set; }
        public string nom_producto { get; set; }
        public Nullable<int> stock_min { get; set; }
        public Nullable<int> stock_a_la_fecha { get; set; }
        public Nullable<int> Alerta { get; set; }
        public Nullable<double> varianza { get; set; }
        
        public enum eAlerta
        {
            Todos = 0,
            Quebrados = 1,
            Por_Quebrar = 2,
            Aceptable = 3
        }
    }
}
