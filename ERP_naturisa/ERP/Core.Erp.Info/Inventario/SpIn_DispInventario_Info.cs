using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class SpIn_DispInventario_Info
    {
        public int EmpresaSi { get; set; }
        public int IdSucursalSi { get; set; }
        public int IdBodegaSi { get; set; }
        public decimal IdProductoSi { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string pr_descripcion { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }
        public string pr_codigo { get; set; }
        public double Disponibles { get; set; }
        public Bitmap Imagen { get; set; }
        //public Nullable<int> IdEmpresa { get; set; }
        //public Nullable<int> IdSucursal { get; set; }
        //public Nullable<int> IdBodega { get; set; }
        //public Nullable<decimal> IdProducto { get; set; }
        public Nullable<double> stock { get; set; }
        public double pr_Pedidos { get; set; }
        public string IdUsuario { get; set; }
    }
}
