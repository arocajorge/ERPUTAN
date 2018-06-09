using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public  class XCXP_NATU_Rpt003_Info

    {
        public int IdEmpresa { get; set; }
        public decimal? IdCbteCble_Ogiro { get; set; }
        public int? IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string Documento { get; set; }
        public string nom_tipo_doc { get; set; }
        public string cod_tipo_doc { get; set; }
        public DateTime co_fechaOg { get; set; }
        public string Tipo_persona { get; set; }
        public decimal? IdProveedor { get; set; }
        public decimal IdPersona { get; set; }
        public string nom_proveedor { get; set; }
        public string Observacion { get; set; }
        public double? Valor_a_pagar { get; set; }
        public double? Valor_debe { get; set; }
        public double Valor_Haber { get; set; }
        //elementos del spCXP_NATU_Rpt003
        public double? Saldo { get; set; }
        public double? SaldoInicial { get; set; }
        public double? SaldoFinal { get; set; }
        //datos de la tb_empresa
        public string ruc_Empresa { get; set; }
        public string nom_empresa { get; set; }

        public XCXP_NATU_Rpt003_Info()
        {
        }
    
      }
         
    }
    

