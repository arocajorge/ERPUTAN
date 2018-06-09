using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class tbPRO_CUS_CID_Rpt008_Info
    {
        public int? IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public string CodigoBarra { get; set; }
        public string dm_observacion { get; set; }
        public int? IdSucursal { get; set; }
        public int? IdBodega { get; set; }
        public int? IdMovi_inven_tipo { get; set; }
        public decimal? IdNumMovi { get; set; }
        public int ?Secuencia { get; set; }
        public int? cb_secuencia { get; set; }
        public decimal? IdProducto { get; set; }
        public DateTime cm_fecha { get; set; }
        public double? dm_cantidad { get; set; }
        public string cm_observacion { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string tm_descripcion { get; set; }
        public string pr_descripcion { get; set; }
        public int Id { get; set; }
        public string pr_nombre { get; set; }
        public string NumDocumentoRelacionado { get; set; }
        public string NumFactura { get; set; }
        public string oc_NumDocumento { get; set; }
        public decimal? IdOrdenCompra { get; set; }
        public DateTime oc_fecha { get; set; }
        public string oc_observacion { get; set; }
        public double? ocdet_cantidad { get; set; }
        public string fecha { get; set; }
        public string fecha_oc { get; set; }

        public tbPRO_CUS_CID_Rpt008_Info()
        {

        }
    }
}
