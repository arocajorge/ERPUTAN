using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.MobileSCI
{
    public class tbl_bodega_Info
    {
        public int IdEmpresaSCI { get; set; }
        public decimal IdSCI { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }

        //Campos que no existen en la base
        public string nom_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public bool seleccionado { get; set; }
    }
}
