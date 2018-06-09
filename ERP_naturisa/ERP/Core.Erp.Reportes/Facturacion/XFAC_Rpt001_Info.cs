using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string IdTipoDocumento { get; set; }
        public string numDocumento { get; set; }
        public decimal IdCliente { get; set; }
        public string nombreCliente { get; set; }
        public DateTime vt_fecha { get; set; }
        public int IdCalendario { get; set; }
        public int AnioFiscal { get; set; }
        public string NombreMes { get; set; }
        public string NombreCortoFecha { get; set; }
        public decimal IdProducto { get; set; }
        public string nombreProducto { get; set; }
        public double vt_cantidad { get; set; }
        public double vt_PrecioFinal { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public double vt_total { get; set; }
        public string IdCategoria { get; set; }
        public Nullable<int> IdLinea { get; set; }
        public Nullable<int> IdGrupo { get; set; }
        public Nullable<int> IdSubgrupo { get; set; }
        public string ca_Categoria { get; set; }
        public string nom_linea { get; set; }
        public string nom_grupo { get; set; }
        public string nom_subgrupo { get; set; }
        public int Idtipo_cliente { get; set; }
        public string Descripcion_tip_cliente { get; set; }
        public string vt_Observacion { get; set; }
        public int IdVendedor { get; set; }
        public string Vendedor { get; set; }

        public XFAC_Rpt001_Info()
        {

        }
    }
}
