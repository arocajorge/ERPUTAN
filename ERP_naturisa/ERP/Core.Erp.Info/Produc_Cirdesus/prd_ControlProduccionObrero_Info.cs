using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_ControlProduccionObrero_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdControlProduccionObrero { get; set; }
        public int IdBodega { get; set; }
        public string CodObra { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public decimal IdGrupoTrabajo { get; set; }
        public decimal IdEmpleado { get; set; }
        public DateTime FechaRegistro { get; set; }
                public string Observacion { get; set; }
        public string Estado { get; set; }
        public int NumDoc { get; set; }
        public double CantAsignada { get; set; }

        public string pe_nombreCompleto { get; set; }
        public string ob_descripcion { get; set; }
        
        public string Su_Descripcion { get; set; }
        public string Descrip_Grupo { get; set; }
        public string OrdenTaller { get; set; }
        public string Descripcion_Obra { get; set; }
        // vista
        public string Nom_grupoTrabajo { get; set; }
        public string NombreProcesoProductivo { get; set; }
        public string NombreEtapa { get; set; }
        public string NombreProducto { get; set; }
        public DateTime FechaHoraInicioFabricacion { get; set; }
        public DateTime FechaHoraFinFabricacion { get; set; }
        public TimeSpan TiempoDuroPP { get; set; }
        public prd_ControlProduccionObrero_Info() { }
    }
}
