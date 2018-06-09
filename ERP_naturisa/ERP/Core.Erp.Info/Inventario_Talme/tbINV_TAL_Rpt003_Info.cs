using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario_Talme
{
    public class tbINV_TAL_Rpt003_Info
    {
        public string NomEmpresa { get; set; }
        public string IdUsuario_SP { get; set; }
        public Nullable<DateTime> Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public string CodProducto { get; set; }
        public string Nom_Producto { get; set; }
        public string Nom_Categoria { get; set; }
        public string RutaPadreCategoria { get; set; }
        public Nullable<int> IdSucursal1 { get; set; }
        public string NomSucursal1 { get; set; }
        public Nullable<int> IdSucursal2 { get; set; }
        public string NomSucursal2 { get; set; }
        public Nullable<int> IdSucursal3 { get; set; }
        public string NomSucursal3 { get; set; }
        public double Uni_Sucursal1 { get; set; }
        public double Ton_Sucursal1 { get; set; }
        public double Uni_Sucursal2 { get; set; }
        public double Ton_Sucursal2 { get; set; }
        public double Uni_Sucursal3 { get; set; }
        public double Ton_Sucursal3 { get; set; }
        public double Uni_total { get; set; }
        public double Ton_total { get; set; }
        public double peso { get; set; }

        public tbINV_TAL_Rpt003_Info()
        {

        }
    }
}
