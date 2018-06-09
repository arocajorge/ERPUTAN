using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
  public  class ro_DiasFaltados_x_Empleado_Info
    {

        public int IdFalta { get; set; }
        public int IdEmpresa { get; set; }
        public int IdEmpleado { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdNominaTipoLiq { get; set; }
        public string CodCatalogo { get; set; }

        public System.DateTime FechaFaltaDesde { get; set; }
        public System.DateTime FechaFaltaHasta { get; set; }
        public string DiasFaltados { get; set; }
        public Nullable<int> DiasDescuento { get; set; }
        public Nullable<System.DateTime> FechaDescuentaRol { get; set; }
        public Nullable<decimal> ValorDescuentaRol { get; set; }
        public string Observacion { get; set; }
        public string CatalogoDescripcion { get; set; }
        public string estado { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public Nullable<int> IdNovedad { get; set; }

      // vista
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
      


    }
}
