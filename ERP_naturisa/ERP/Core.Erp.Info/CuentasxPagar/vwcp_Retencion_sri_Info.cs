using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
   public class vwcp_Retencion_sri_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdRetencion { get; set; }
        public string serie { get; set; }
        public string NumRetencion { get; set; }
        public DateTime fecha { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_razonSocial { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_correo { get; set; }
        public decimal IdProveedor { get; set; }
        public DateTime co_FechaFactura { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telfono_Contacto { get; set; }
        public string co_serie { get; set; }
        public string co_factura { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string ContribuyenteEspecial { get; set; }
        public string ObligadoAllevarConta { get; set; }
        public string em_ruc { get; set; }
        public string em_direccion { get; set; }
        public string IdTipoDocumento { get; set; }

        public int? IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string Su_Direccion { get; set; }
        public string Estado { get; set; }

              
       public  vwcp_Retencion_sri_Info(){}

    }
}
