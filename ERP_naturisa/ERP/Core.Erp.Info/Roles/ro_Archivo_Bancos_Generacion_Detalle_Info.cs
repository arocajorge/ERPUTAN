
/*CLASE: ro_Archivo_Bancos_Generacion_Detalle_Info
 *CREADA POR: ALBERTO MENA
 *FECHA:26-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
    public class ro_Archivo_Bancos_Generacion_Detalle_Info
    {
        public string tipoRegistro { get; set; }
        public string numSecuencial { get; set; }
        public string codBeneficiario { get; set; }
        public string tipoIdentificacion { get; set; }
        public string numIdentificacion { get; set; }
        public string nombreBeneficiario { get; set; }
        public string formaPago { get; set; }
        public string codPais { get; set; }
        public string codBanco { get; set; }
        public string tipoCuenta { get; set; }
        public string numCuenta { get; set; }
        public string codMoneda { get; set; }
        public string valorPago { get; set; }
        public string concepto { get; set; }
        public string numComprobante { get; set; }
        public string numComprobanteRetencion { get; set; }
        public string numComprobanteIVA { get; set; }
        public string numComprobanteFacturaSRI { get; set; }
        public string codGrupo { get; set; }
        public string descripcionGrupo { get; set; }
        public string direccionBeneficiario { get; set; }
        public string telefono { get; set; }
        public string codServicio { get; set; }
        public string cedula1 { get; set; }
        public string cedula2 { get; set; }
        public string cedula3 { get; set; }
        public string controlHorarioAtencion { get; set; }
        public string codEmpresa { get; set; }
        public string nemonicoSubEmpresa { get; set; }
        public string subMotivoPagoCobro { get; set; } 

        public ro_Archivo_Bancos_Generacion_Detalle_Info() { }
    }
}
