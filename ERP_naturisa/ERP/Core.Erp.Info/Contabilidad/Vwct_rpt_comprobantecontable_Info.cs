using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
namespace Core.Erp.Info.Contabilidad
{
    public class Vwct_rpt_comprobantecontable_Info
    {
        public int IdEmpresa{ get; set; } 
	    public int IdTipoCbte{ get; set; } 
	    public decimal IdCbteCble{ get; set; } 
	    public string CodCbteCble{ get; set; } 
	    public int IdPeriodo{ get; set; } 
	    public DateTime cb_Fecha{ get; set; } 
	    public double cb_Valor{ get; set; } 
	    public string cb_Observacion{ get; set; } 
	    public string cb_Estado{ get; set; } 
	    public int cb_Anio{ get; set; } 
	    public int cb_mes{ get; set; } 
	    public int secuencia{ get; set; } 
	    public string IdCtaCble{ get; set; } 
	    public double dc_Valor{ get; set; } 
	    public string dc_Observacion{ get; set; } 
	    public string pc_Cuenta{ get; set; }
        public double Debito { get; set; }
        public double Credito { get; set; }
        public string tc_TipoCbte { get; set; }
        public tb_Empresa_Info   EmpresaInfo { get; set; }
        

    public Vwct_rpt_comprobantecontable_Info()
    {
        EmpresaInfo = new tb_Empresa_Info();
    }
    }
}
