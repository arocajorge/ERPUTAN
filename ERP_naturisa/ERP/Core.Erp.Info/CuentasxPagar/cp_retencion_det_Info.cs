using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_retencion_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdRetencion { get; set; }
        public int Idsecuencia { get; set; }
        public string re_Tiene_RTiva { get; set; }
        public string re_Tiene_RFuente { get; set; }
        public string re_tipoRet { get; set; }
        public double re_baseRetencion { get; set; }
        public int IdCodigo_SRI { get; set; }
        public string re_Codigo_impuesto { get; set; }
        public double re_Porcen_retencion { get; set; }
        public double? re_valor_retencion { get; set; }
        public string IdCtaCble { get; set; }
        public string re_estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
       
        public string CodigoSRI { get; set; }
        public string nCtaCble { get; set; }
        public string nRetencionSRI { get; set; }
        public string FVigCoSRI { get; set; }
        public string co_descripcion { get; set; }
        public string IdTipoSRI { get; set; }
     

        public cp_retencion_det_Info()
        {

        }
    }
}
/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 14/02/2014 10:45
/// </summary>

