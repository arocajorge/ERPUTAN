using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt009_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string CodActivoFijo { get; set; }
        public string Af_Codigo_Barra { get; set; }
        public string Af_Nombre { get; set; }
        public DateTime Af_fecha_compra { get; set; }
        public string Descripcion { get; set; }
        public Image Logo { get; set; }

        public XACTF_Rpt009_Info()
        {

        }

    }
}
