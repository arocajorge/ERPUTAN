using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles.Archivos_para_Bancos
{
  public  class ro_Archivo_Banco_Guayaquil_Pagos_Info
  {
      public string Multi_codigoOrientación { get; set; }
      public string Multi_cuentaEmpresa { get; set; }
      public string Multi_secuencialPago { get; set; }
      public string Multi_comprobantedePago { get; set; }
      public string Multi_codigo { get; set; }
      public string Multi_moneda { get; set; }
      public string valor { get; set; }
      public string Multi_formaPago { get; set; }
      public string Multi_codigoDeInstitucionFinanciera { get; set; }
      public string Multi_tipoCuenta { get; set; }
      public string Multi_numeroDeCuenta { get; set; }
      public string Multi_tipoIdClienteBeneficiario { get; set; }
      public string Multi_numeroIdClienteBeneficiario { get; set; }
      public string Multi_nombreClienteBeneficiario { get; set; }
      public string Multi_direccionBeneficiario { get; set; }
      public string Multi_ciudadBeneficiario { get; set; }
      public string Multi_telefonoBeneficiario { get; set; }
      public string Multi_localidadPago { get; set; }
      public string Multi_referenciaAdicional { get; set; }
      public string Multi_referencia { get; set; }



      // campos para transferencia a otros bancos




      public string NCR_TiposdeCuenta { get; set; }
      public string NCR_NumerodeCuentaBancoGuayaquil { get; set; }
      public string NCR_Motivo { get; set; }
      public string NCR_TipoNota { get; set; }
      public string NCR_Agencia { get; set; }
      public string NCR_CodigoBancoParaPagoInterbancario { get; set; }
      public string NCR_NumeroCuentaOtrosBancos { get; set; }
      public string NCR_NombreTitularCuentaOtrosBancos { get; set; }
      public string NCR_NuevoMotivo { get; set; }
      public string NCR_Email { get; set; }
      public string NCR_Celular { get; set; }
      public string NCR_BancoDestinopagointerbancario { get; set; }
      public string NCR_TipoIdentificaciónBeneficiario { get; set; }
      public string NCR_NúmeroIdentificacionBeneficiario { get; set; }





      // campos para archivo rol electronico
      //cabecera datos adicionales
      public string Rol_Elect_NumCtaEmpresa { get; set; }
      public string Rol_Elect_NumCreditos { get; set; }
      //detalle
      public string Rol_Elect_TipoRegistro { get; set; }
      public string Rol_Elect_CodigoEmpresa { get; set; }
      public string Rol_Elect_CodigoEmpleado { get; set; }
      public string Rol_Elect_Nombre { get; set; }
      public string Rol_Elect_CobroServicio { get; set; }
      public string Rol_Elect_Filler { get; set; }
      public string Rol_Elect_CodigoProceso { get; set; }
      public string Rol_Elect_Monto { get; set; }
      public string Rol_Elect_Motivo3 { get; set; }
      public string Rol_Elect_Filler2 { get; set; }
      public string Rol_Elect_Email { get; set; }
      public string Rol_Elect_Celular { get; set; }
      public string Rol_Elect_Fecha_Envio { get; set; }


    }
}
