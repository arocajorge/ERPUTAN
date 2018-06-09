using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt010_Info
    {
        public int IdEmpresa { get; set; }
        public int IdCambioUbicacion { get; set; }
        public int IdActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public int IdActijoFijoTipo { get; set; }
        public string Af_Descripcion { get; set; }
        public int IdSucursal_Actu { get; set; }
        public string SucActual { get; set; }
        public int IdSucursal_Ant { get; set; }
        public string SucAnterior { get; set; }
        public int IdDepartamento_Actu { get; set; }
        public string DepActual { get; set; }
        public int IdDepartamento_Ant { get; set; }
        public string DepAnterior { get; set; }
        public string IdTipoCatalogo_Ubicacion_Actu { get; set; }
        public string UbiActual { get; set; }
        public string IdTipoCatalogo_Ubicacion_Ant { get; set; }
        public string UbiAnterior { get; set; }
        public string MotivoCambio { get; set; }
        public DateTime FechaCambio { get; set; }
        public string IdUsuario { get; set; }
        public Image Logo { get; set; }


        public XACTF_Rpt010_Info()
        {

        }
    }
}
