using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.Facturacion
{
    public  class XFAC_GRAF_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public int IdBodega { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public string CodGuiaRemision { get; set; }
        public decimal IdCliente { get; set; }
        public string pe_razonSocial { get; set; }
        public string gi_Observacion { get; set; }
        public int Secuencia { get; set; }
        public double gi_cantidad { get; set; }
        public double gi_Precio { get; set; }
        public double gi_PorDescUnitario { get; set; }
        public double gi_DescUnitario { get; set; }
        public double gi_PrecioFinal { get; set; }
        public double gi_Subtotal { get; set; }
        public double gi_iva { get; set; }
        public double gi_total { get; set; }
        public string gi_detallexItems { get; set; }
        public string Nombre_Transportista { get; set; }
        public string Nombre_Producto { get; set; }
        public string Numero_OP { get; set; }
        public Nullable<decimal> Num_Cotizacion { get; set; }
        public string Nom_Maquina { get; set; }
        public string Direccion_Destino { get; set; }
        public string Direccion_Origen { get; set; }
        public string ruta { get; set; }
        public string placa { get; set; }
        public System.DateTime gi_FechaFinTraslado { get; set; }
        public System.DateTime gi_FechaIniTraslado { get; set; }
        public System.DateTime gi_fecha { get; set; }
    }
}
