using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt006_Info
    {
        public int IdEmpresa { get; set; }
        public decimal Id_Mejora_Baja_Activo { get; set; }
        public string Id_Tipo { get; set; }
        public int IdActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public string Encargado { get; set; }
        public string Af_Marca { get; set; }
        public string Af_Modelo { get; set; }
        public string Af_NumSerie { get; set; }
        public string Af_Color { get; set; }
        public string Af_Ubicacion { get; set; }
        public int Af_Vida_Util { get; set; }
        public int Af_Meses_depreciar { get; set; }
        public double Af_porcentaje_deprec { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public double ValorActivo { get; set; }
        public double Valor_Mej_Baj_Activo { get; set; }
        public string Compr_Mej_Baj { get; set; }
        public string DescripcionTecnica { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public Image Logo { get; set; }

        public XACTF_Rpt006_Info()
        {

        }
    }
}
