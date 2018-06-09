using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class tbPRD_Rpt_RPRD001_Info
    {
	
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal  IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public decimal  IdProducto { get; set; }
        public string  CodigoBarra { get; set; }
        public string IdUsuario { get; set; }
        public DateTime  Fecha_Transac { get; set; }
        public string  nom_pc { get; set; }
        public string  pr_descripcion { get; set; }
        public string Obra { get; set; }
        public string Cliente { get; set; }
        public tbPRD_Rpt_RPRD001_Info()
        {

        }

    }
}
