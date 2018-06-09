using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario_Talme
{
    public class tbINV_TAL_Rpt002_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public string IdCategoria { get; set; }
        public string pr_descripcion { get; set; }
        public double pr_stock { get; set; }
        public double pr_peso { get; set; }
        public string IdUsuario { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string codProducto { get; set; }
        public double Uni_Entrada { get; set; }
        public double Uni_salida { get; set; }
        public double Uni_Saldo { get; set; }
        public double Kil_Entrada { get; set; }
        public double Kil_salida { get; set; }
        public double Kil_Saldo { get; set; }
        public string Nom_Sucursal { get; set; }
        public string Nom_Bodega { get; set; }
        public string Nom_Categoria { get; set; }
        public string nom_pc { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public DateTime fecha_corte { get; set; }

        public tbINV_TAL_Rpt002_Info()
        {

        }
    }
}
