using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_XML_Documento_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDocumento { get; set; }
        public string Comprobante { get; set; }
        public string XML { get; set; }
        public string Tipo { get; set; }
        public string emi_RazonSocial { get; set; }
        public string emi_NombreComercial { get; set; }
        public string emi_Ruc { get; set; }
        public string emi_DireccionMatriz { get; set; }
        public string emi_ContribuyenteEspecial { get; set; }
        public string ClaveAcceso { get; set; }
        public string CodDocumento { get; set; }
        public string Establecimiento { get; set; }
        public string PuntoEmision { get; set; }
        public string NumeroDocumento { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public string rec_RazonSocial { get; set; }
        public string rec_Identificacion { get; set; }
        public double Subtotal0 { get; set; }
        public double SubtotalIVA { get; set; }
        public double Porcentaje { get; set; }
        public double ValorIVA { get; set; }
        public double Total { get; set; }
        public string FormaPago { get; set; }
        public int Plazo { get; set; }
        public string ret_CodDocumentoTipo { get; set; }
        public string ret_Establecimiento { get; set; }
        public string ret_PuntoEmision { get; set; }
        public string ret_NumeroDocumento { get; set; }
        public Nullable<System.DateTime> ret_Fecha { get; set; }
        public Nullable<System.DateTime> ret_FechaAutorizacion { get; set; }
        public string ret_NumeroAutorizacion { get; set; }
        public bool Estado { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        

        #region Campos que no existen en la tabla
        public int Imagen { get; set; }
        public double Descuento { get; set; }
        public List<cp_XML_Documento_Retencion_Info> lstRetencion { get; set; }
        public List<cp_XML_DocumentoDet_Info> lstDetalle { get; set; }
        public string serie { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_correo { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telfono_Contacto { get; set; }
        public decimal IdProveedor { get; set; }
        public string co_serie { get; set; }
        public string IdTipoDocumento { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string Su_Direccion { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string ContribuyenteEspecial { get; set; }
        public string ObligadoAllevarConta { get; set; }
        public string em_ruc { get; set; }
        public string em_direccion { get; set; }
        public bool Automatico { get; set; }
        #endregion

        public bool EnviaXML { get; set; }

        public string IdUsuario { get; set; }

        public bool ValidacionD { get; set; }

        public bool ValidacionR { get; set; }

        public bool ValidacionC { get; set; }
    }
}
