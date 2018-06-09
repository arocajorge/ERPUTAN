using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_Depreciacion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDepreciacion { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public string Cod_Depreciacion { get; set; }
        public int IdPeriodo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Depreciacion { get; set; }
        public int Num_Act_Depre { get; set; }
        public double Valor_Tot_Act { get; set; }
        public double Valor_Tot_Depre { get; set; }
        public double Valor_Tot_DepreAcum { get; set; }
        public double Valot_Tot_Importe { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public List<Af_Depreciacion_Det_Info> ListDetalle { get; set; }
        public List<vwAf_ActivoFijo_Info> lstGridDepre { get; set; }
        public int IdTipoCbte_Rev { get; set; }

        public string nom_tipo_depreciacion { get; set; }
        public string cod_tipo_depreciacion { get; set; }
        public double Valor_Depreciacion { get; set; }
        public double Valor_Depre_Acum { get; set; }
        public double Valor_Importe { get; set; }



        public Af_Depreciacion_Info()
        {

        }
    }
}
