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
        public string ClaveAcceso { get; set; }
        public string CodDocumento { get; set; }
        public string Establecimiento { get; set; }
        public string PuntoEmision { get; set; }
        public string NumeroDocumento { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public string rec_RazonSocial { get; set; }
        public string rec_Identificacion { get; set; }
        public Nullable<double> Subtotal0 { get; set; }
        public Nullable<double> SubtotalIVA { get; set; }
        public Nullable<double> Porcentaje { get; set; }
        public Nullable<double> ValorIVA { get; set; }
        public Nullable<double> Total { get; set; }
        public string FormaPago { get; set; }
        public Nullable<int> Plazo { get; set; }
        public string ret_CodDocumentoTipo { get; set; }
        public string ret_Establecimiento { get; set; }
        public string ret_PuntoEmision { get; set; }
        public string ret_NumeroDocumento { get; set; }
        public Nullable<System.DateTime> ret_Fecha { get; set; }
        public Nullable<System.DateTime> ret_FechaAutorizacion { get; set; }
        public string ret_NumeroAutorizacion { get; set; }
        public Nullable<bool> Estado { get; set; }

        #region Campos que no existen en la tabla
        public int Imagen { get; set; }
        public List<cp_XML_Documento_Retencion_Info> lstRetencion { get; set; }
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
        #endregion
        
    }
}
