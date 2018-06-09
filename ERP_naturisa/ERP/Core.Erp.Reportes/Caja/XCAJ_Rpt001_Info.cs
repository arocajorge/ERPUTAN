using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public string Tipo_Cbte { get; set; }
        public string cod_caja { get; set; }	
        public string Caja { get; set; }
        public string Sucursal { get; set; }
        public string Tipo { get; set; }
        public string Beneficiario { get; set; }
        public double ? Valor { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo_Movi_Caja { get; set; }
        public string IdCobro_tipo { get; set; }
        public string Banco { get; set; }
        public string Num_Documento { get; set; }
        public string Observacion { get; set; }
        public int IdCalendario { get; set; }
        public int ? AnioFiscal { get; set; }
        public int ? IdMes { get; set; }
        public string Mes { get; set; }
        public string Dia { get; set; }


    }
}
