using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_SubGrupoTrabajo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string CodObra { get; set; }
        public string ob_descripcion { get; set; }
        public decimal IdGrupoTrabajo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string DetOT { get; set; }
        public decimal  IdOrdenTaller { get; set; }
        public decimal IdLider { get; set; }
        public int IdProcesoProductivo { get; set; }
        public int IdEtapa { get; set; }
        public int idGrupo { get; set; }
        public string Estado { get; set; }

        public string DescripModelo { get; set; }
        public string NombreEtapa { get; set; }
        public string pe_nombreCompleto { get; set; }
        public int NumeroOT { get; set; }
        
       
        public string Su_Descripcion { get; set; }

        // vista
        public bool check { get; set; }
        public string NombreSubgrupo { get; set; }
        public string NombreGrupos { get; set; }

        public prd_SubGrupoTrabajo_Info(){}

    }
}
