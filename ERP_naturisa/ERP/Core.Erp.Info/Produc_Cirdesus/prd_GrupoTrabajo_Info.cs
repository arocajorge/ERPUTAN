using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
   public class prd_GrupoTrabajo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdGrupoTrabajo { get; set; }
        public string Descripcion { get; set; }
        public string AreaProduccion { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
