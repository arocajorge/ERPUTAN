using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
  public  class vwfa_notaCreDeb_sri_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNota { get; set; }
        public string CreDeb { get; set; }
        public string CodNota { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public decimal IdCliente { get; set; }
        public DateTime no_fecha { get; set; }
        public string Estado { get; set; }
        public string NaturalezaNota { get; set; }
        public string NumAutorizacion { get; set; }
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
        public string NumNota_Impresa { get; set; }
        public string NumDocModificado { get; set; }
        public DateTime? fechaEmisionDocSustento { get; set; }
        
        public string observacion_factura { get; set; }
        public string observacion_Nota { get; set; }
        public string nc_Motivo { get; set; }
        public string tipo_doc_aplicado { get; set; }
        public List<fa_notaCreDeb_det_Info> lista_DetCreDeb { get; set; }

        public vwfa_notaCreDeb_sri_Info() { }
    }
}
