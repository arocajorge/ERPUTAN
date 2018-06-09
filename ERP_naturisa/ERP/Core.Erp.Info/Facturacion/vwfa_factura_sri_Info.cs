using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
  public  class vwfa_factura_sri_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_serie1 { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_autorizacion { get; set; }
        public string vt_NumFactura { get; set; }
        public decimal IdCliente { get; set; }
        public DateTime vt_fecha { get; set; }
        public string Estado { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string ContribuyenteEspecial { get; set; }
        public string ObligadoAllevarConta { get; set; }
        public string em_ruc { get; set; }
        public string em_direccion { get; set; }
        public string Su_Descripcion { get; set; }
        public string Su_Direccion { get; set; }
        public string cl_RazonSocial { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string IdTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_correo { get; set; }
        public decimal vt_plazo { get; set; }

        public DateTime vt_fech_venc { get; set; }
        public string vt_Observacion { get; set; }
        public List<fa_factura_det_info> lista_FacturaDet = new List<fa_factura_det_info>();

      public  vwfa_factura_sri_Info()
      {
          lista_FacturaDet = new List<fa_factura_det_info>();
      
      }

    }
}
