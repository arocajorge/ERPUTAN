using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_His_Depre_Info
    {
        public int IdEmpresa { get; set; }
        public int IdHisDepreciacion { get; set; }
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


        public Af_His_Depre_Info()
        {

        }
    }
}
