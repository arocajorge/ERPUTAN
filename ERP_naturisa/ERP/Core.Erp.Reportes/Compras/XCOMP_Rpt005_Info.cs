using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt005_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreAprobacion { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public int Secuencia_SC { get; set; }
        public Nullable<decimal> IdProducto_SC { get; set; }
        public string Su_Descripcion { get; set; }
        public string NomProducto_SC { get; set; }
        public double Cantidad_aprobada { get; set; }
        public string IdUsuarioAprueba { get; set; }
        public Nullable<System.DateTime> FechaHoraAprobacion { get; set; }
        public string observacion { get; set; }
        public string IdUnidadMedida { get; set; }
        public string Descripcion { get; set; }
        public Nullable<double> do_precioCompra { get; set; }
        public Nullable<double> do_porc_des { get; set; }
        public Nullable<double> do_subtotal { get; set; }
        public Nullable<double> do_iva { get; set; }
        public Nullable<double> do_total { get; set; }
        public Nullable<bool> do_ManejaIva { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public int ? IdDepartamento { get; set; }
        public string de_descripcion { get; set; }
        public decimal ? IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public decimal IdPersona { get; set; }
        public string nomSolicitante { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string NomEmpresa { get; set; }
        public Image Logo { get; set; }
        public string DescrpcionEstado { get; set; }

        public XCOMP_Rpt005_Info()
        {
                
        }
    }
}
