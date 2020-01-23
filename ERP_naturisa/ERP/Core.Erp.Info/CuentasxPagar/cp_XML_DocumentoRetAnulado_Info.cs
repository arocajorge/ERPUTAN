using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_XML_DocumentoRetAnulado_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDocumento { get; set; }
        public int SecuenciaAnu { get; set; }
        public string Comprobante { get; set; }
        public string emi_Ruc { get; set; }
        public string emi_RazonSocial { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public string ret_CodDocumentoTipo { get; set; }
        public string ret_Establecimiento { get; set; }
        public string ret_PuntoEmision { get; set; }
        public string ret_NumeroDocumento { get; set; }
        public Nullable<System.DateTime> ret_Fecha { get; set; }
        public Nullable<System.DateTime> ret_FechaAutorizacion { get; set; }
        public string ret_NumeroAutorizacion { get; set; }
        public string IdUsuarioAnulacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }

        #region Campos que no existen en la tabla
        public List<cp_XML_DocumentoRetAnuladoDet_Info> ListaDet { get; set; }
        #endregion
        
    }
}
