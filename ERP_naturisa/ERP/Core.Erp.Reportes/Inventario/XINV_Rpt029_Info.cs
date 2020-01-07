using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt029_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string nom_bodega { get; set; }
        public string nom_sucursal { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_observacion { get; set; }
        public double Stock { get; set; }
        public decimal IdProducto { get; set; }
        public double costo { get; set; }
        public double costo_total { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }
        public int IdLinea { get; set; }
        public string nom_linea { get; set; }
        public string nom_UnidadMedida { get; set; }


        //public int IdEmpresa { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int dt_secuencia { get; set; }
        //public Nullable<decimal> IdProducto { get; set; }
        //public string pr_descripcion { get; set; }
        public double dt_cantidad { get; set; }
        public string IdEstablecimiento { get; set; }
        public string IdPuntoEmision { get; set; }
        public string NumDocumento_Guia { get; set; }
        public string NumeroAutorizacion { get; set; }
        public Nullable<System.DateTime> FechaAutorizacion { get; set; }
        public string IdentificacionTransportista { get; set; }
        public string NombreTransportista { get; set; }
        public string MotivoGuia { get; set; }
        public string Direc_sucu_Llegada { get; set; }
        public string Direc_sucu_Partida { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Nombre { get; set; }
        public string NombreDestinatario { get; set; }
        public string IdentificacionDestinatario { get; set; }
        public string Su_Descripcion { get; set; }
        public string Su_Direccion { get; set; }
        public string NombreEmpresa { get; set; }
        public string NumeroContribuyente { get; set; }
        public string em_ruc { get; set; }
    }
}
