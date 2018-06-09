using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt004_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string CodActivoFijo { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public string cod_tipo_depreciacion { get; set; }
        public string nom_tipo_depreciacion { get; set; }
        public string Af_Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public DateTime Af_fecha_compra { get; set; }
        public double Af_costo_compra { get; set; }
        public string Estado_Proceso { get; set; }
        public decimal IdDepreciacion { get; set; }
        public int Secuencia { get; set; }
        public int Ciclo { get; set; }
        public double Valor_Compra { get; set; }
        public double Valor_Salvamento { get; set; }
        public int Vida_Util { get; set; }
        public double Valor_Depreciacion { get; set; }
        public double Valor_Depre_Acum { get; set; }
        public double Valor_Importe { get; set; }
        public int IdPeriodo { get; set; }
        public int IdanioFiscal { get; set; }
        public byte pe_mes { get; set; }
        public string smes { get; set; }
        public string Nemonico { get; set; }
        public string Periodo_Mes { get; set; }
        public Image Logo { get; set; }


        public XACTF_Rpt004_Info()
        {

        }
    }
}
