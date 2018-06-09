using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario_Talme
{
    public class tbINV_TAL_Rpt001_Info
    {
        public decimal IdRegistro { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public string IdUsuario_SP { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public Nullable<System.DateTime> cm_fecha { get; set; }
        public string cm_observacion { get; set; }
        public Nullable<decimal> IdNumMovi { get; set; }
        public Nullable<int> IdMovi_inven_tipo { get; set; }
        public string Nom_Movi_inven_tipo { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string CodProducto { get; set; }
        public string Nom_Producto { get; set; }
        public string IdCategoria { get; set; }
        public string Nom_Categoria { get; set; }
        public string RutaPadreCategoria { get; set; }
        public Nullable<double> Cantidad { get; set; }
        public string Nom_Bodega { get; set; }
        public string Nom_Sucursal { get; set; }
        public Nullable<decimal> IdCliente { get; set; }
        public string Nom_Cliente { get; set; }
        public Nullable<decimal> IdCbteVta { get; set; }
        public string Num_Factura { get; set; }
        public string vt_Observacion { get; set; }
        public string CodGuiaRemision { get; set; }
        public string NumGuia_Preimpresa { get; set; }
        public Nullable<int> Entrada_Uni { get; set; }
        public Nullable<int> Salida_Uni { get; set; }
        public Nullable<int> Saldo_Uni { get; set; }
        public Nullable<int> Entrada_Peso { get; set; }
        public Nullable<int> Salida_Peso { get; set; }
        public Nullable<int> Saldo_Peso { get; set; }
        public string NomEmpresa { get; set; }
        
        public tbINV_TAL_Rpt001_Info()
        {

        }
    }
}
